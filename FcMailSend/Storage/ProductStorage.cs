using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Configuration;

namespace FcMailSend
{
    /// <summary>
    /// 分仓产品I/O相关
    /// </summary>
    public class ProductStorage
    {
        // 读取产品列表
        public static ProductList ReadProductlist(string conStr)
        {
            ProductList productList = ReadProduct(conStr);
            return productList;
        }

        // 读取产品
        private static ProductList ReadProduct(string conStr)
        {
            ProductList productList = new ProductList();

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(conStr))
                {
                    cn.Open();

                    string query = "select * from Product";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                    {
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                // 获取产品基本信息
                                int id = int.Parse(dr["ID"].ToString());
                                string productName = dr["ProductName"].ToString();
                                string mailTitle = dr["MailTitle"].ToString();
                                string mailContent = dr["MailContent"].ToString();

                                DateTime? lastSendTime;
                                if (Convert.IsDBNull(dr["LastSendTime"]))
                                    lastSendTime = null;
                                else
                                    lastSendTime = DateTime.Parse(dr["LastSendTime"].ToString());

                                bool disable = bool.Parse(dr["Disable"].ToString());

                                // 获取附件列表
                                ProductAttachmentList attList = ReadProductAttachmentList(id, cn);

                                // 获取收件人列表
                                ProductReceiverList receiverList = ReadProductReceiver(id, cn);

                                Product product = new Product(
                                    id,
                                    productName,
                                    mailTitle,
                                    mailContent,
                                    lastSendTime,
                                    disable,
                                    attList,
                                    receiverList);

                                productList.Add(product);
                            }//eof while
                        }//eof dr
                    }//eof cmd
                }//eof conn
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return productList;
        }


        /// <summary>
        /// 读取一个产品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Product ReadProduct(int id)
        {
            Product product = null;

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(cn))
                    {
                        cmd.CommandText = "select * from Product where ID=@ID";
                        cmd.Parameters.Add(new SQLiteParameter("@ID", id));

                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                dr.Read();

                                string productName = dr["ProductName"].ToString();
                                string mailTitle = dr["MailTitle"].ToString();
                                string mailContent = dr["MailContent"].ToString();
                                DateTime? lastSendTime;
                                if (Convert.IsDBNull(dr["LastSendTime"]))
                                    lastSendTime = null;
                                else
                                    lastSendTime = DateTime.Parse(dr["LastSendTime"].ToString());
                                bool disable = bool.Parse(dr["Disable"].ToString());

                                // 获取附件列表
                                ProductAttachmentList attList = ReadProductAttachmentList(id, cn);

                                // 获取收件人列表
                                ProductReceiverList receiverList = ReadProductReceiver(id, cn);

                                product = new Product(
                                    id,
                                    productName,
                                    mailTitle,
                                    mailContent,
                                    lastSendTime,
                                    disable,
                                    attList,
                                    receiverList);
                            }
                            else
                            {
                                throw new Exception(string.Format(@"记录ID[{0}]不存在!", id));
                            }
                        }//eof dr
                    }//eof cmd
                }//eof conn
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return product;
        }


        /// <summary>
        /// 读取id对应的附件列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        private static ProductAttachmentList ReadProductAttachmentList(int id, SQLiteConnection conn)
        {
            ProductAttachmentList attList = new ProductAttachmentList();

            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "select * from ProductAttachment where ProductID=@ProductID;";
                cmd.Parameters.Add(new SQLiteParameter("@ProductID", id));

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // 获取产品基本信息
                        int productID = int.Parse(dr["ProductID"].ToString());
                        AttachmentType type = (AttachmentType)Enum.Parse(typeof(AttachmentType), dr["AttachmentType"].ToString());
                        string path = dr["AttachmentPath"].ToString();
                        int? ftpID = null;
                        if (Convert.IsDBNull(dr["FtpID"]))
                            ftpID = null;
                        else
                            ftpID = int.Parse(dr["FtpID"].ToString());

                        ProductAttachment att = new ProductAttachment(productID, type, path, ftpID);
                        attList.Add(att);
                    }//eof while
                }//eof dr
            }//eof cmd

            return attList;
        }


        /// <summary>
        /// 读取id对应的收件人列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        private static ProductReceiverList ReadProductReceiver(int id, SQLiteConnection conn)
        {
            ProductReceiverList receiverList = new ProductReceiverList();

            string query = string.Format("select * from ProductReceiver where ProductID='{0}';", id);
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // 获取产品基本信息
                        int productID = int.Parse(dr["ProductID"].ToString());
                        string emailAddress = dr["EmailAddress"].ToString();
                        ReceiverType receiverType = (ReceiverType)Enum.Parse(typeof(ReceiverType), dr["ReceiverType"].ToString());

                        ProductReceiver receiver = new ProductReceiver(productID, emailAddress, receiverType);
                        receiverList.Add(receiver);
                    }//eof while
                }//eof dr
            }//eof cmd

            return receiverList;
        }

    }
}
