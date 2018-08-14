using System;
using System.Collections.Generic;
using System.Text;

namespace FcMailSend
{
    public class MailFtp
    {
        private int _id;
        private string _ftpDesc;
        private string _ftpServer;
        private string _userName;
        private string _password;


        #region 属性
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FtpDesc
        {
            get { return _ftpDesc; }
            set { _ftpDesc = value; }
        }

        public string FtpServer
        {
            get { return _ftpServer; }
            set { _ftpServer = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        #endregion


        public MailFtp(
            int id,
            string ftpDesc,
            string ftpServer,
            string userName,
            string password)
        {
            _id = id;
            _ftpDesc = ftpDesc;
            _ftpServer = ftpServer;
            _userName = userName;
            _password = password;
        }
    }
}
