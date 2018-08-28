using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Text;

namespace FcMailSend
{
    public class ProductSendLogStorage
    {
        /// <summary>
        /// 增加日志
        /// </summary>
        /// <param name="sendLog"></param>
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



        public static ProductSendLogList ReadSendLogList(DateTime dtBegin,DateTime dtEnd)
        {
            ProductSendLogList sendLogList = new ProductSendLogList();

            // 临时键值对，存放产品id-产品名称
            Dictionary<int, string> dicProduct = new Dictionary<int, string>();

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(ConfigurationManager.AppSettings["conn"]))
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(cn))
                    {
                        cmd.CommandText= "select * from ProductSendLog where ProductDate between @Begin and @End";
                        cmd.Parameters.Add(new SQLiteParameter("@Begin", dtBegin));
                        cmd.Parameters.Add(new SQLiteParameter("@End", dtEnd));

                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                // 获取产品基本信息
                                int id = int.Parse(dr["ID"].ToString());
                                int productID = int.Parse(dr["ProductID"].ToString());

                                // 获取产品名称
                                string productName = string.Empty;
                                if (dicProduct.ContainsKey(productID))
                                    productName = dicProduct[productID];
                                else
                                {
                                    productName = ProductStorage.GetProductNameById(productID, cn);
                                    dicProduct.Add(productID, productName);
                                }
                                DateTime productDate = DateTime.Parse(dr["ProductDate"].ToString());
                                bool isSendOK = bool.Parse(dr["IsSendOK"].ToString());
                                string note = dr["Note"].ToString();
                                DateTime opTime = DateTime.Parse(dr["OpTime"].ToString());


                                ProductSendLog sendLog = new ProductSendLog(
                                    id,
                                    productID,
                                    productName,
                                    productDate,
                                    isSendOK,
                                    note,
                                    opTime
                                    );

                                sendLogList.Add(sendLog);
                            }//eof while
                        }//eof dr
                    }//eof cmd
                }//eof conn
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dicProduct.Clear();
            }

            return sendLogList;
        }


    }
}
