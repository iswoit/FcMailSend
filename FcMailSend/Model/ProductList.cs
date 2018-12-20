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
        // 不含信用完成的个数
        public int FinishedCountNoCredit
        {
            get
            {
                int iCount = 0;
                foreach (Product product in this)
                {
                    if (product.IsCredit == false && product.IsSendOK)
                        iCount++;
                }
                return iCount;
            }
        }

        // 总完成的个数
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

        // 不含信用的个数
        public int TotalCountNoCredit
        {
            get
            {
                int iCount = 0;
                foreach (Product product in this)
                {
                    if (!product.IsCredit)
                        iCount++;
                }
                return iCount;

            }
        }

        // 信用是否都完成
        public bool IsAllSendOKNoCredit
        {
            get
            {
                if (FinishedCountNoCredit == TotalCountNoCredit)
                    return true;
                else
                    return false;
            }
        }


        // 是否都完成
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
