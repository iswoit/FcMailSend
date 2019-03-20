using System;
using System.Collections.Generic;
using System.Text;

namespace FcMailSend
{
    /// <summary>
    /// Product代表一个分仓的产品
    /// </summary>
    public class Product
    {
        private int _id;                                    // 主键
        private string _productName;                        // 产品名称
        private string _mailTitle;                          // 邮件名称
        private string _mailContent;                        // 邮件正文
        private bool _disable = true;                       // 是否禁用(默认不启用)
        private bool _isCredit = false;                     // 是否信用批次（默认关）
        private bool _isDelay = false;                      // 是否自定义延迟时间（false就用全局变量20190320）
        private int? _delaySeconds;                         // 配合_isDelay使用，延迟时间

        private ProductAttachmentList _attachmentList;      // 附件列表
        private ProductReceiverList _receiverList;          // 收件人列表

        // 运行时变量
        private bool _isRunning = false;                    // 是否在运行
        private bool _isAttachmentOK = false;               // 附件是否已就绪
        private bool _isSendOK = false;                     // 是否发送完毕
        private string _note = string.Empty;                // 状态说明文字


        #region 属性
        public int Id
        {
            get { return _id; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public string MailTitle
        {
            get { return _mailTitle; }
            set { _mailTitle = value; }
        }

        public string MailContent
        {
            get { return _mailContent; }
            set { _mailContent = value; }
        }


        public bool Disable
        {
            get { return _disable; }
            set { _disable = value; }
        }

        public bool IsCredit
        {
            get { return _isCredit; }
            set { _isCredit = value; }
        }

        public bool IsDelay
        {
            get { return _isDelay; }
            set { _isDelay = value; }
        }

        public int? DelaySeconds
        {
            get { return _delaySeconds; }
            set { _delaySeconds = value; }
        }


        public ProductAttachmentList ProductAttachmentList
        {
            get { return _attachmentList; }
            set { _attachmentList = value; }
        }

        public ProductReceiverList ProductReceiverList
        {
            get { return _receiverList; }
            set { _receiverList = value; }
        }

        public bool IsRunning
        {
            get { return _isRunning; }
            set { _isRunning = value; }
        }

        public bool IsAttachmentOK
        {
            get { return _isAttachmentOK; }
            set { _isAttachmentOK = value; }
        }

        public bool IsSendOK
        {
            get { return _isSendOK; }
            set { _isSendOK = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        #endregion


        #region 方法
        //构造函数
        public Product(int id,
            string productName,
            string mailTitle,
            string mailContent,
            bool disable,
            ProductAttachmentList attachmentList,
            ProductReceiverList receiverList,
            bool isCredit,
            bool isDelay,
            int? delaySeconds)
        {
            _id = id;
            _productName = productName;
            _mailTitle = mailTitle;
            _mailContent = mailContent;
            _disable = disable;
            _attachmentList = attachmentList;
            _receiverList = receiverList;
            _isCredit = isCredit;
            _isDelay = isDelay;
            _delaySeconds = delaySeconds;
        }

        #endregion
    }
}
