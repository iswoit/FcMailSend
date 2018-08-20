using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace FcMailSend
{
    /// <summary>
    /// 产品的集合
    /// </summary>
    public class ProductList : Collection<Product>
    {
        public int FinishedCount
        {
            get
            {
                int iCount = 0;
                foreach (Product product in this)
                {
                    if (product.IsSendOK)
                        iCount++;
                }
                return iCount;
            }
        }

        public bool IsAllSendOK
        {
            get
            {
                if (FinishedCount == this.Count)
                    return true;
                else
                    return false;
            }
        }


        #region 方法
        public ProductList()
        {

        }
        #endregion

    }
}
