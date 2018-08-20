using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Text;

namespace FcMailSend
{
    public class ProductSendLogStorage
    {
        public static void AddSendLog(ProductSendLog sendLog)
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    cn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cn))
                    {
                        // 插入product表
                        cmd.Parameters.Clear();
                        cmd.CommandText = "insert into ProductSendLog(ProductID, ProductDate, IsSendOK, Note, OpTime) values (@ProductID, @ProductDate, @IsSendOK, @Note, @OpTime)";
                        cmd.Parameters.Add(new SQLiteParameter("@ProductID", sendLog.ProductID));
                        cmd.Parameters.Add(new SQLiteParameter("@ProductDate", sendLog.ProductDate));
                        cmd.Parameters.Add(new SQLiteParameter("@IsSendOK", sendLog.IsSendOK));
                        cmd.Parameters.Add(new SQLiteParameter("@Note", sendLog.Note));
                        cmd.Parameters.Add(new SQLiteParameter("@OpTime", sendLog.OpTime));
                        cmd.ExecuteNonQuery();

                    }//eof cmd
                }//eof conn
            }
            catch (Exception)
            {
                // 插日志异常就不报了，不能影响业务逻辑
            }
        }

    }
}
