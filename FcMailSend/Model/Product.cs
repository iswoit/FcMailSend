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
        private DateTime? _lastSendTime;                    // 最后一次发送成功的时间（可以用来判断今天是否已经发送成功）
        private bool _disable = true;                       // 是否禁用(默认不启用)
        private ProductAttachment _productAttachment;       // 附件列表
        private ProductMailReceiver _productMailReceiver;   // 收件人列表

        // 运行时变量
        private bool _isRunning = false;                    // 是否在运行
        private bool _isAttachmentOK = false;               // 附件是否已就绪
        private bool _isSendOK = false;                     // 是否发送完毕
        private string _note = string.Empty;              // 状态说明文字


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

        public DateTime? LastSendTime
        {
            get { return _lastSendTime; }
            set { _lastSendTime = value; }
        }

        public bool Disable
        {
            get { return _disable; }
            set { _disable = value; }
        }

        public ProductAttachment ProductAttachment
        {
            get { return _productAttachment; }
            set { _productAttachment = value; }
        }

        public ProductMailReceiver ProductMailReceiver
        {
            get { return _productMailReceiver; }
            set { _productMailReceiver = value; }
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


        #region
        //构造函数
        public Product(int id,
            string productName,
            string mailTitle,
            string mailContent,
            DateTime? lastSendTime,
            bool disable,
            ProductAttachment productAttachment,
            ProductMailReceiver productMailReceiver)
        {
            _id = id;
            _productName = productName;
            _mailTitle = mailTitle;
            _mailContent = mailContent;
            _lastSendTime = lastSendTime;
            _disable = disable;
            _productAttachment = productAttachment;
            _productMailReceiver = productMailReceiver;
        }

        #endregion
    }
}
