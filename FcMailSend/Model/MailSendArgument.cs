using System;
using System.Collections.Generic;
using System.Text;

namespace FcMailSend
{
    public enum MailSendMode
    {
        发送未发送的产品 = 0,
        重发所有产品 = 1,
        只发送勾选的产品 = 2
    }

    public class MailSendArgument
    {
        private MailSendMode _sendMode;
        private DateTime _date;
        private ProductList _productList;

        public MailSendMode SendMode
        {
            get { return _sendMode; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

        public ProductList ProductList
        {
            get { return _productList; }
        }


        public MailSendArgument(MailSendMode mode,DateTime date,ProductList productList)
        {
            _sendMode = mode;
            _date = date;
            _productList = productList;
        }
    }
}
