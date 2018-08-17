using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FcMailSend
{
    public partial class MailFtpEditDialog : BaseEditDialog
    {
        private Manager _manager;
        private MailFtp _mailFtp;



        private Manager Manager
        {
            get { return _manager; }
        }

        private MailFtp MailFtp
        {
            get { return _mailFtp; }
        }



        public MailFtpEditDialog(Manager mgr, MailFtp mailFtp)
        {
            InitializeComponent();

            _manager = mgr;
            _mailFtp = mailFtp;

            ResetDialog();
        }

        protected override void ResetDialog()
        {
            if (MailFtp == null)
            {
                this.Text = "新增FTP连接";

                txtFtpDesc.Text = string.Empty;
                txtFtpServer.Text = string.Empty;
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else
            {
                this.Text = "修改FTP连接";

                txtFtpDesc.Text = MailFtp.FtpDesc;
                txtFtpServer.Text = MailFtp.FtpServer;
                txtUserName.Text = MailFtp.UserName;
                txtPassword.Text = MailFtp.Password;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveSettings(e);
        }

        private void SaveSettings(CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定提交修改?", "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                string ftpDesc = txtFtpDesc.Text.Trim();
                string ftpServer = txtFtpServer.Text.Trim();
                string userName = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();


                // 如果MailFtp为空，则是新增
                if (MailFtp == null)
                {
                    MailFtp mailFtp = new MailFtp(0, ftpDesc, ftpServer, userName, password);
                    MailFtpStorage.AddMailFtp(mailFtp);
                }
                else
                {
                    MailFtp.FtpDesc = ftpDesc;
                    MailFtp.FtpServer = ftpServer;
                    MailFtp.UserName = userName;
                    MailFtp.Password = password;

                    MailFtpStorage.UpdateMailFtp(MailFtp);
                }

                

                MessageBox.Show("保存完成!");
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
