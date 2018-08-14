using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

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
                                ProductAttachment productAttachment = ReadProductAttachment(id, cn);

                                // 获取收件人列表
                                ProductMailReceiver productMailReceiver = ReadProductMailReceiver(id, cn);

                                Product product = new Product(
                                    id,
                                    productName,
                                    mailTitle,
                                    mailContent,
                                    lastSendTime,
                                    disable,
                                    productAttachment,
                                    productMailReceiver);

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


        // 读取产品附件列表
        private static ProductAttachment ReadProductAttachment(int id, SQLiteConnection conn)
        {
            ProductAttachment productAttachment = new ProductAttachment();

            string query = string.Format("select * from ProductAttachment where ProductID='{0}';", id);
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // 获取产品基本信息
                        string attachmentPath = dr["AttachmentPath"].ToString();

                        productAttachment.Add(attachmentPath);
                    }//eof while
                }//eof dr
            }//eof cmd

            return productAttachment;
        }


        // 读取产品收件人列表
        private static ProductMailReceiver ReadProductMailReceiver(int id, SQLiteConnection conn)
        {
            ProductMailReceiver productMailReceiver = new ProductMailReceiver();

            string query = string.Format("select * from ProductMailReceiver where ProductID='{0}';", id);
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        // 获取产品基本信息
                        string emailAddress = dr["EmailAddress"].ToString();

                        productMailReceiver.Add(emailAddress);
                    }//eof while
                }//eof dr
            }//eof cmd

            return productMailReceiver;
        }

    }
}
