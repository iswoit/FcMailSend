using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.Configuration;

namespace FcMailSend
{
    public class MailFtpStorage
    {
        /// <summary>
        /// 读取FTP列表
        /// </summary>
        /// <returns></returns>
        public static MailFtpList ReadMailFtpList()
        {
            MailFtpList mailFtpList = new MailFtpList();

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(ConfigurationManager.AppSettings["conn"]))
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
                                string defaultPath = dr["DefaultPath"].ToString();

                                MailFtp mailFtp = new MailFtp(id, ftpDesc, ftpServer, userName, password, defaultPath);


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


        /// <summary>
        /// 按照id读ftp
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static MailFtp ReadMailFtp(int id)
        {
            MailFtp mailFtp;
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(cn))
                    {
                        cmd.CommandText = "select * from MailFtp where ID=@ID";
                        cmd.Parameters.Add(new SQLiteParameter("@ID", id));
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.HasRows)
                                throw new Exception("无数据");

                            dr.Read();

                            // 获取产品基本信息
                            string ftpDesc = dr["FtpDesc"].ToString();
                            string ftpServer = dr["FtpServer"].ToString();
                            string userName = dr["UserName"].ToString();
                            string password = dr["Password"].ToString();
                            string defaultPath = dr["DefaultPath"].ToString();

                            mailFtp = new MailFtp(id, ftpDesc, ftpServer, userName, password, defaultPath);

                        }//eof dr
                    }//eof cmd
                }//eof conn
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mailFtp;
        }

        /// <summary>
        /// 新增FTP连接信息
        /// </summary>
        /// <param name="mailFtp"></param>
        public static void AddMailFtp(MailFtp mailFtp)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {

                        cmd.CommandText = string.Format(@"insert into MailFtp (FtpDesc, FtpServer, UserName, Password, DefaultPath) values (@FtpDesc, @FtpServer, @UserName, @Password, @DefaultPath);");
                        cmd.Parameters.Add(new SQLiteParameter("@FtpDesc", mailFtp.FtpDesc));
                        cmd.Parameters.Add(new SQLiteParameter("@FtpServer", mailFtp.FtpServer));
                        cmd.Parameters.Add(new SQLiteParameter("@UserName", mailFtp.UserName));
                        cmd.Parameters.Add(new SQLiteParameter("@Password", mailFtp.Password));
                        cmd.Parameters.Add(new SQLiteParameter("@DefaultPath", mailFtp.DefaultPath));

                        cmd.ExecuteNonQuery();

                    }//eof cmd
                }//eof cn
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// 修改FTP连接信息
        /// </summary>
        /// <param name="mailFtp"></param>
        public static void UpdateMailFtp(MailFtp mailFtp)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {

                        cmd.CommandText = string.Format(@"update MailFtp set FtpDesc=@FtpDesc, FtpServer=@FtpServer, UserName=@UserName, Password=@Password, DefaultPath=@DefaultPath where ID=@ID;");
                        cmd.Parameters.Add(new SQLiteParameter("@FtpDesc", mailFtp.FtpDesc));
                        cmd.Parameters.Add(new SQLiteParameter("@FtpServer", mailFtp.FtpServer));
                        cmd.Parameters.Add(new SQLiteParameter("@UserName", mailFtp.UserName));
                        cmd.Parameters.Add(new SQLiteParameter("@Password", mailFtp.Password));
                        cmd.Parameters.Add(new SQLiteParameter("@DefaultPath", mailFtp.DefaultPath));
                        cmd.Parameters.Add(new SQLiteParameter("@ID", mailFtp.Id));

                        cmd.ExecuteNonQuery();

                    }//eof cmd
                }//eof cn
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// 删除FTP连接信息
        /// </summary>
        /// <param name="mailFtp"></param>
        public static void DelMailFtp(MailFtp mailFtp)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        // 判断是否有产品用到此连接，有的话不允许删除
                        cmd.CommandText = string.Format(@"select count(1) from ProductAttachment where FtpID=@FtpID;");
                        cmd.Parameters.Add(new SQLiteParameter("@FtpID", mailFtp.Id));
                        int iCount = int.Parse(cmd.ExecuteScalar().ToString());
                        if (iCount > 0)
                            throw new Exception("目前仍有产品从此FTP下载文件, 无法删除!");

                        cmd.Parameters.Clear();
                        cmd.CommandText = string.Format(@"delete from MailFtp where ID=@ID;");
                        cmd.Parameters.Add(new SQLiteParameter("@ID", mailFtp.Id));

                        cmd.ExecuteNonQuery();

                    }//eof cmd
                }//eof cn
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
