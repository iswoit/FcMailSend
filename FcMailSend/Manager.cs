using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace FcMailSend
{
    public class Manager
    {
        #region 字段
        private string connStr = "Data Source=FcMailSend.db3;Version=3;";   // 数据库连接串
        private MailSender _mailSender;         // 发件人信息
        private MailFtpList _mailFtpList;           // ftp信息
        private ProductList _productList;       // 产品列表对象
        #endregion


        #region 属性

        public string ConnStr
        {
            get { return connStr; }
        }

        public MailSender MailSender
        {
            get { return _mailSender; }
            set { _mailSender = value; }
        }

        public MailFtpList MailFtpList
        {
            get { return _mailFtpList; }
            set { _mailFtpList = value; }
        }

        public ProductList ProductList
        {
            get { return _productList; }
            set { _productList = value; }
        }

        #endregion


        #region 方法
        public Manager()
        {
            ReloadMailSender();
            ReloadFtpList();
            ReloadProductList();
        }

        public void ReloadMailSender()
        {
            _mailSender = MailSenderStorage.ReadMailSender();    // 读取发件人信息
        }

        public void ReloadFtpList()
        {
            _mailFtpList = MailFtpStorage.ReadMailFtpList();     // 读取FTP信息
        }

        public void ReloadProductList()
        {
            _productList = ProductStorage.ReadProductlist();     // 读取产品信息
        }


        // 发送整个list的邮件
        public void SendMail(ProductList productList, DateTime date, BackgroundWorker bgWorker, DoWorkEventArgs e)
        {
            // 循环每一个产品
            foreach (Product product in productList)
            {
                if (true == bgWorker.CancellationPending)       // 取消事件
                {
                    e.Cancel = true;
                    return;
                }


                // 0.打标记
                product.IsRunning = true;
                bgWorker.ReportProgress(1);
                Thread.Sleep(40);

                if (product.Disable == true)
                {
                    string err = "禁用, 跳过";
                    product.Note = err;
                    product.IsRunning = false;
                    bgWorker.ReportProgress(1);
                    ProductSendLogStorage.AddSendLog(new ProductSendLog(0,
                        product.Id,
                        date,
                        false,
                        err,
                        DateTime.Now));

                    Thread.Sleep(40);
                    continue;
                }


                #region 1.参数校验
                // 判断附件是否有设置
                if (product.ProductAttachmentList.Count <= 0)
                {
                    string err = "没有设置任何附件, 不发送";
                    product.IsRunning = false;
                    product.IsAttachmentOK = false;
                    product.IsSendOK = false;
                    product.Note = err;
                    ProductSendLogStorage.AddSendLog(new ProductSendLog(0,
                        product.Id,
                        date,
                        false,
                        err,
                        DateTime.Now));

                    bgWorker.ReportProgress(1);
                    continue;
                }

                // 判断收件人是否有设置
                int iReceiverCnt = 0;
                foreach (ProductReceiver receiver in product.ProductReceiverList)
                {
                    if (receiver.ReceiverType == ReceiverType.收件人)
                        iReceiverCnt++;
                }
                if (iReceiverCnt <= 0)
                {
                    string err = "没有设置收件人, 不发送";
                    product.IsRunning = false;
                    product.IsSendOK = false;
                    product.Note = err;
                    ProductSendLogStorage.AddSendLog(new ProductSendLog(0,
                        product.Id,
                        date,
                        false,
                        err,
                        DateTime.Now));

                    bgWorker.ReportProgress(1);
                    continue;
                }
                #endregion


                #region 2.下载附件
                product.Note = "正在下载附件...";
                bgWorker.ReportProgress(1);

                // 创建临时目录(后需要删文件)
                string tmpFile = Path.Combine(System.Environment.CurrentDirectory, "tmp");
                if (!Directory.Exists(tmpFile))
                    Directory.CreateDirectory(tmpFile);

                // 循环配置下载每一个附件
                List<ProductAttachmentTmp> tmpAttList = new List<ProductAttachmentTmp>();   // 临时文件列表
                try
                {
                    foreach (ProductAttachment att in product.ProductAttachmentList)
                    {
                        string displayPath = Util.ReplaceStringWithDateFormat(att.DisplayPath, date);
                        string actualPath = string.Empty;
                        bool isExist = false;

                        switch (att.Type)
                        {
                            case AttachmentType.磁盘路径:
                                actualPath = displayPath;
                                break;
                            case AttachmentType.FTP:
                                actualPath = Path.Combine(tmpFile, Path.GetFileName(displayPath));
                                // ftp下载
                                MailFtp ftpInfo = MailFtpStorage.ReadMailFtp(att.FtpID.Value);
                                DownloadFtpFile(displayPath, actualPath, ftpInfo);

                                break;
                        }

                        if (!File.Exists(actualPath))
                            isExist = false;
                        else
                            isExist = true;

                        tmpAttList.Add(new ProductAttachmentTmp(displayPath, actualPath, isExist));
                    }
                }
                catch (Exception ex)
                {
                    // note处写异常
                    string err = string.Format(@"下载附件失败: {0}", ex.Message);
                    product.IsRunning = false;
                    product.IsAttachmentOK = false;
                    product.IsSendOK = false;
                    product.Note = err;
                    ProductSendLogStorage.AddSendLog(new ProductSendLog(0,
                        product.Id,
                        date,
                        false,
                        err,
                        DateTime.Now));

                    bgWorker.ReportProgress(1);
                    continue;
                }


                // 判断附件缺失
                List<string> missingAttachments = new List<string>();       // 缺失文件列表
                foreach (ProductAttachmentTmp tmpAttr in tmpAttList)    //要改
                {
                    if (tmpAttr.IsExist == false)
                    {
                        missingAttachments.Add(tmpAttr.DisplayPath);
                    }
                }
                if (missingAttachments.Count > 0)
                {
                    product.IsRunning = false;
                    product.IsAttachmentOK = false;
                    product.IsSendOK = false;

                    StringBuilder sbAttachments = new StringBuilder();
                    foreach (string att in missingAttachments)
                    {
                        if (sbAttachments.Length > 0)
                            sbAttachments.Append(";");
                        sbAttachments.Append(att);
                    }

                    string err = "附件缺失: " + sbAttachments.ToString();

                    product.Note = err;                                         // 写日志
                    ProductSendLogStorage.AddSendLog(new ProductSendLog(0,
                        product.Id,
                        date,
                        false,
                        err,
                        DateTime.Now));

                    bgWorker.ReportProgress(1);
                    continue;
                }
                else
                {
                    product.Note = "附件下载完成";
                    product.IsAttachmentOK = true;
                    product.Note = string.Empty;         // 可以具体一点
                    bgWorker.ReportProgress(1);
                }
                Thread.Sleep(40);
                #endregion



                #region 3.开始发送邮件
                // SmtpClient对象
                SmtpClient client = new SmtpClient();
                client.Host = MailSender.Host;                  // smtp服务器
                client.Port = MailSender.Port;                  // smtp端口
                client.EnableSsl = MailSender.EnableSSL;        // ssl加密
                client.Credentials = new System.Net.NetworkCredential(MailSender.Address, MailSender.Password);
                client.Timeout = MailSender.Timeout * 1000;     // 超时时间


                // msg对象
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(MailSender.Address, MailSender.DisplayName, Encoding.UTF8);  // 发件人信息
                msg.Subject = Util.ReplaceStringWithDateFormat(product.MailTitle, date);              // 邮件标题    
                msg.SubjectEncoding = System.Text.Encoding.UTF8;                                        // 邮件标题编码    
                msg.Body = Util.ReplaceStringWithDateFormat(product.MailContent + MailSender.TailContent, date);        //邮件内容    
                msg.BodyEncoding = System.Text.Encoding.UTF8;                                           // 邮件内容编码    
                msg.IsBodyHtml = false;                                                                 // 是否是HTML邮件    
                msg.Priority = MailSender.Priority;                                                     // 邮件优先级   



                // 添加收件人
                foreach (ProductReceiver receiver in product.ProductReceiverList)
                {
                    switch (receiver.ReceiverType)
                    {
                        case ReceiverType.收件人:
                            msg.To.Add(receiver.EmailAddress);
                            break;
                        case ReceiverType.抄送:
                            msg.CC.Add(receiver.EmailAddress);
                            break;
                        case ReceiverType.密送:
                            msg.Bcc.Add(receiver.EmailAddress);
                            break;
                        default:
                            msg.To.Add(receiver.EmailAddress);
                            break;
                    }
                }

                // 添加附件
                foreach (ProductAttachmentTmp attTmp in tmpAttList)
                    msg.Attachments.Add(new Attachment(attTmp.ActualPath));


                try
                {
                    product.Note = "正在发送...";
                    bgWorker.ReportProgress(1);

                    client.Send(msg);
                    //client.SendAsync(msg, userState);

                    product.IsSendOK = true;
                    product.Note = "发送完成";
                    bgWorker.ReportProgress(1);

                    ProductSendLogStorage.AddSendLog(new ProductSendLog(0,
                        product.Id,
                        date,
                        true,
                        "发送完成",
                        DateTime.Now));
                }
                catch (Exception ex)
                {
                    product.IsRunning = false;
                    product.IsSendOK = false;
                    product.Note = "发送失败：" + ex.Message;         // 可以具体一点
                                                                 // 写日志
                    bgWorker.ReportProgress(1);

                    ProductSendLogStorage.AddSendLog(new ProductSendLog(0,
                        product.Id,
                        date,
                        false,
                        "发送失败：" + ex.Message,
                        DateTime.Now));
                    continue;
                }
                finally
                {
                    if (msg != null)
                        msg.Dispose();
                }

                #endregion


                // 3.发完更新数据库时间戳，写日志


                // 4.收尾
                product.IsRunning = false;
                bgWorker.ReportProgress(1);
            }


            // 删除tmp目录
            try
            {
                string tmpFile = Path.Combine(System.Environment.CurrentDirectory, "tmp");
                if (Directory.Exists(tmpFile))
                    Directory.Delete(tmpFile, true);
            }
            catch (Exception)
            { }

        }


        /// <summary>
        /// ftp文件是否存在
        /// </summary>
        /// <param name="ftpPath"></param>
        /// <param name="ftpInfo"></param>
        private void IsFtpFileExist(string ftpPath, MailFtp ftpInfo)
        {
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpPath));
                reqFTP.Method = WebRequestMethods.Ftp.GetFileSize;
                reqFTP.UseBinary = true;
                reqFTP.UsePassive = false;
                reqFTP.Credentials = new NetworkCredential(ftpInfo.UserName, ftpInfo.Password);
                using (FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse())
                {

                }
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                switch (response.StatusCode)
                {
                    case FtpStatusCode.ActionNotTakenFileUnavailable:
                        throw new Exception(string.Format(@"文件[{0}]不存在", ftpPath));
                    case FtpStatusCode.NotLoggedIn:
                        throw new Exception("无法登录FTP, 请检查连接串");
                    default:
                        throw new Exception(ex.Message);
                }
            }
        }


        /// <summary>
        /// 下载ftp文件
        /// </summary>
        /// <param name="ftpPath"></param>
        /// <param name="filePath"></param>
        /// <param name="ftpInfo"></param>
        private void DownloadFtpFile(string ftpPath, string filePath, MailFtp ftpInfo)
        {
            IsFtpFileExist(ftpPath, ftpInfo);

            FtpWebRequest reqFTP;
            try
            {
                using (FileStream outputStream = new FileStream(filePath, FileMode.Create))
                {
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpPath));
                    reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                    reqFTP.UseBinary = true;
                    reqFTP.UsePassive = false;
                    reqFTP.Credentials = new NetworkCredential(ftpInfo.UserName, ftpInfo.Password);
                    using (FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse())
                    {
                        using (Stream ftpStream = response.GetResponseStream())
                        {
                            long cl = response.ContentLength;
                            int bufferSize = 2048;
                            int readCount;
                            byte[] buffer = new byte[bufferSize];

                            readCount = ftpStream.Read(buffer, 0, bufferSize);
                            while (readCount > 0)
                            {
                                outputStream.Write(buffer, 0, readCount);
                                readCount = ftpStream.Read(buffer, 0, bufferSize);
                            }
                            ftpStream.Close();
                        }
                        response.Close();
                    }
                    outputStream.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        #endregion
    }
}
