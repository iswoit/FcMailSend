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

    /// <summary>
    /// 发送模式参数，用于送入runasync后的dowork进行解析
    /// </summary>
    public class MailSendArgument
    {
        private MailSendMode _sendMode;
        private DateTime _date;
        private ProductList _productList;
        private bool _isCredit;
        private int _sendInterval;          // 发送间隔

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

        public bool IsCredit
        {
            get { return _isCredit; }
        }

        public int SendInterval
        {
            get { return _sendInterval; }
        }

        public MailSendArgument(MailSendMode mode, DateTime date, ProductList productList, bool isCredit, int sendInterval)
        {
            _sendMode = mode;
            _date = date;
            _productList = productList;
            _isCredit = isCredit;
            _sendInterval = sendInterval;
        }
    }
}
