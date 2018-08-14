using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace FcMailSend
{
    /// <summary>
    /// 发件人信息
    /// </summary>
    public class MailSender
    {
        private string _host;               // smtp地址
        private int _port;                  // 端口
        private bool _enableSSL;            // 启用SSL
        private string _address;            // 账号
        private string _password;           // 密码
        private int _timeout;               // 超时时间
        private string _displayName;        // 显示的名称
        private MailPriority _priority;     // 优先级
        private string _tailContent;        // 尾部信息


        #region 属性
        public string Host
        {
            get { return _host; }
        }

        public int Port
        {
            get { return _port; }
        }

        public bool EnableSSL
        {
            get { return _enableSSL; }
        }

        public string Address
        {
            get { return _address; }
        }

        public string Password
        {
            get { return _password; }
        }

        public int Timeout
        {
            get { return _timeout; }
        }

        public string DisplayName
        {
            get { return _displayName; }
        }

        public MailPriority Priority
        {
            get { return _priority; }
        }

        public string TailContent
        {
            get { return _tailContent; }
        }

        #endregion




        public MailSender(string host, int port, bool enableSSL, string address, string password, int timeout, string displayName, MailPriority priority,  string tailContent = "")
        {
            _host = host;
            _port = port;
            _enableSSL = enableSSL;
            _address = address;
            _password = password;
            _displayName = displayName;
            _priority = priority;
            _timeout = timeout;
            _tailContent = tailContent;
        }


        public void UpdateMailSender(string host, int port, bool enableSSL, string address, string password, int timeout, string displayName, MailPriority priority, string tailContent = "")
        {
            _host = host;
            _port = port;
            _enableSSL = enableSSL;
            _address = address;
            _password = password;
            _displayName = displayName;
            _priority = priority;
            _timeout = timeout;
            _tailContent = tailContent;
        }
    }
}
