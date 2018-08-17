using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.Net.Mail;
using System.Configuration;

namespace FcMailSend
{
    public class MailSenderStorage
    {
        /// <summary>
        /// 读取发件人信息
        /// </summary>
        /// <param name="connStr"></param>
        /// <returns></returns>
        public static MailSender ReadMailSender()
        {
            MailSender mailSender = null;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();

                    string query = string.Format("select * from MailSender order by ID asc limit 1;");
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.HasRows)
                                throw new Exception("未配置发件人信息, 请先配置!");

                            if (dr.Read())
                            {
                                // 获取产品基本信息
                                string host = dr["Host"].ToString();
                                int port = int.Parse(dr["Port"].ToString());
                                bool enableSSL = bool.Parse(dr["EnableSSL"].ToString());
                                string address = dr["Address"].ToString();
                                string password = dr["Password"].ToString();
                                int timeout = int.Parse(dr["Timeout"].ToString());
                                string displayName = dr["DisplayName"].ToString();
                                MailPriority priority = (MailPriority)(int.Parse(dr["Priority"].ToString()));

                                string tailContent = dr["TailContent"].ToString();


                                mailSender = new MailSender(host, port, enableSSL, address, password, timeout, displayName, priority, tailContent);
                            }

                        }//eof dr
                    }//eof cmd
                }//eof cn
            }
            catch (Exception ex)
            {
                mailSender = null;
                throw new Exception(ex.Message);
            }

            return mailSender;
        }


        /// <summary>
        /// 更新发件人信息
        /// </summary>
        /// <param name="mailSender">发件人</param>
        /// <param name="connStr">数据库连接串</param>
        public static void WriteMailSender(MailSender mailSender)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {

                        cmd.CommandText = string.Format(@"update MailSender set Host=@Host, Port=@Port, EnableSSL=@EnableSSL, Address=@Address, Password=@Password, Timeout=@Timeout, DisplayName=@DisplayName, Priority=@Priority, TailContent=@TailContent;");
                        cmd.Parameters.Add(new SQLiteParameter("@Host", mailSender.Host));
                        cmd.Parameters.Add(new SQLiteParameter("@Port", mailSender.Port));
                        cmd.Parameters.Add(new SQLiteParameter("@EnableSSL", mailSender.EnableSSL));
                        cmd.Parameters.Add(new SQLiteParameter("@Address", mailSender.Address));
                        cmd.Parameters.Add(new SQLiteParameter("@Password", mailSender.Password));
                        cmd.Parameters.Add(new SQLiteParameter("@Timeout", mailSender.Timeout));
                        cmd.Parameters.Add(new SQLiteParameter("@DisplayName", mailSender.DisplayName));
                        cmd.Parameters.Add(new SQLiteParameter("@Priority", mailSender.Priority));
                        cmd.Parameters.Add(new SQLiteParameter("@TailContent", mailSender.TailContent));


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
