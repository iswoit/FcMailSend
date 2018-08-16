using System;
using System.Collections.Generic;
using System.Text;

namespace FcMailSend
{
    /// <summary>
    /// 收件人类型
    /// </summary>
    public enum ReceiverType
    {
        收件人 = 0,     // 收件人
        抄送 = 1,     // 抄送
        密送 = 2     // 密送
    }

    public class ProductReceiver
    {
        private int _productID;                 // 产品的主键
        private string _emailAddress;           // email地址
        private ReceiverType _receiverType;     // 收件人类型

        #region 属性
        public int ProductID
        {
            get { return _productID; }
        }

        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        public ReceiverType ReceiverType
        {
            get { return _receiverType; }
            set { _receiverType = value; }
        }
        #endregion



        public ProductReceiver(int productID, string emailAddress, ReceiverType receiverType)
        {
            _productID = productID;
            _emailAddress = emailAddress;
            _receiverType = receiverType;
        }
    }
}
