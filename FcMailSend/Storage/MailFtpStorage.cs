using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace FcMailSend
{
    public class MailFtpStorage
    {
        /// <summary>
        /// 读取FTP列表
        /// </summary>
        /// <param name="connStr"></param>
        /// <returns></returns>
        public static MailFtpList ReadMailFtpList(string connStr)
        {
            MailFtpList mailFtpList = new MailFtpList();

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(connStr))
                {
                    cn.Open();

                    string query = "select * from MailFtp";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                    {
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                // 获取产品基本信息
                                int id = int.Parse(dr["ID"].ToString());
                                string ftpDesc = dr["FtpDesc"].ToString();
                                string ftpServer = dr["FtpServer"].ToString();
                                string userName = dr["UserName"].ToString();
                                string password = dr["Password"].ToString();

                                MailFtp mailFtp = new MailFtp(id, ftpDesc, ftpServer, userName, password);


                                mailFtpList.Add(mailFtp);
                            }//eof while
                        }//eof dr
                    }//eof cmd
                }//eof conn
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mailFtpList;
        }
    }
}
