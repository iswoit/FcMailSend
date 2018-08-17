using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;
using System.Threading;
using System.Net.Mail;

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
        public void SendMail(BackgroundWorker bgWorker, DoWorkEventArgs e)
        {
            // 循环每一个产品
            foreach (Product product in ProductList)
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


                // 1.判断所有附件是否存在
                if (product.ProductAttachmentList.Count <= 0)
                {
                    product.IsRunning = false;
                    product.IsAttachmentOK = false;
                    product.IsSendOK = false;
                    product.Note = "没有设置任何附件, 不发送";

                    bgWorker.ReportProgress(1);
                    continue;
                }
                List<string> missingAttachments = new List<string>();       // 缺失文件列表
                foreach (ProductAttachment attachment in product.ProductAttachmentList)    //要改
                {
                    if (!File.Exists(attachment.Path))
                    {
                        missingAttachments.Add(attachment.Path);
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
                    product.Note = "附件缺失: " + sbAttachments.ToString();         // 可以具体一点
                                                                                // 写日志
                    bgWorker.ReportProgress(1);
                    continue;
                }
                else
                {
                    product.IsAttachmentOK = true;
                    product.Note = string.Empty;         // 可以具体一点
                    bgWorker.ReportProgress(1);
                }
                Thread.Sleep(40);


                // 2.开始发邮件
                if (product.ProductReceiverList.Count <= 0)
                {
                    product.IsRunning = false;
                    product.IsSendOK = false;
                    product.Note = "没有设置任何收件人, 不发送";

                    bgWorker.ReportProgress(1);
                    continue;
                }


                // SmtpClient对象
                SmtpClient client = new SmtpClient();
                client.Host = MailSender.Host;                  // smtp服务器
                client.Port = MailSender.Port;                  // smtp端口
                client.EnableSsl = MailSender.EnableSSL;        // ssl加密
                client.Credentials = new System.Net.NetworkCredential(MailSender.Address, MailSender.Password);
                client.Timeout = MailSender.Timeout * 1000;     // 超时时间


                // msg对象
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(MailSender.Address, MailSender.DisplayName, Encoding.UTF8);   // 发件人信息
                msg.Subject = product.ProductName + DateTime.Now.ToString("yyyyMMdd");  //邮件标题    
                msg.SubjectEncoding = System.Text.Encoding.UTF8;                        //邮件标题编码    
                msg.Body = "" + MailSender.TailContent;                             //邮件内容    
                msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码    
                msg.IsBodyHtml = false;//是否是HTML邮件    
                msg.Priority = MailSender.Priority;     //邮件优先级   

                // 添加收件人
                foreach (ProductReceiver receiver in product.ProductReceiverList) 
                {
                    switch(receiver.ReceiverType)
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
                    

                foreach (ProductAttachment atta in product.ProductAttachmentList)      //附件
                    msg.Attachments.Add(new Attachment(atta.Path));

                

                try
                {
                    product.Note = "正在发送...";
                    bgWorker.ReportProgress(1);

                    client.Send(msg);
                    //client.SendAsync(msg, userState);

                    product.IsSendOK = true;
                    product.Note = "发送完成";
                    bgWorker.ReportProgress(1);
                }
                catch (Exception ex)
                {
                    product.IsRunning = false;
                    product.IsSendOK = false;
                    product.Note = "发送失败：" + ex.Message;         // 可以具体一点
                                                                 // 写日志
                    bgWorker.ReportProgress(1);
                    continue;
                }


                // 3.发完更新数据库时间戳，写日志


                // 4.收尾
                product.IsRunning = false;
                bgWorker.ReportProgress(1);
            }
        }

        #endregion
    }
}
