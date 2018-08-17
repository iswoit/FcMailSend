using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace FcMailSend
{
    public partial class MailSenderEditDialog : BaseEditDialog
    {
        private Manager _manager;

        private Manager Manager
        {
            get { return _manager; }
        }



        public MailSenderEditDialog(Manager mgr)
        {
            InitializeComponent();

            _manager = mgr;
            ResetDialog();
        }


        /// <summary>
        /// 内存对象重新加载
        /// </summary>
        protected override void ResetDialog()
        {
            MailSender mailSender = Manager.MailSender;
            txtHost.Text = mailSender.Host;
            txtPort.Text = mailSender.Port.ToString();
            cbEnableSSL.Checked = mailSender.EnableSSL;
            txtAddress.Text = mailSender.Address;
            txtPassword.Text = mailSender.Password;
            numTimeout.Value = mailSender.Timeout;
            txtDisplayName.Text = mailSender.DisplayName;
            switch (mailSender.Priority)
            {
                case MailPriority.High:
                    rdPrioHigh.Checked = true;
                    break;
                case MailPriority.Low:
                    rdPrioLow.Checked = true;
                    break;
                case MailPriority.Normal:
                default:
                    rdPrioNormal.Checked = true;
                    break;
            }

            // priority
            txtTailContent.Text = mailSender.TailContent.Replace("\n", System.Environment.NewLine);


            //base.ResetDialog();
        }




        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveSettings(e);
        }


        private void SaveSettings(CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定保存修改?", "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // 获取产品基本信息
                string host = txtHost.Text.Trim();
                int port = int.Parse(txtPort.Text.Trim());
                bool enableSSL = cbEnableSSL.Checked;
                string address = txtAddress.Text.Trim();
                string password = txtPassword.Text;
                int timeout = int.Parse(numTimeout.Value.ToString());
                string displayName = txtDisplayName.Text;
                MailPriority priority = MailPriority.Normal;
                if (rdPrioNormal.Checked)
                    priority = MailPriority.Normal;
                else if (rdPrioLow.Checked)
                    priority = MailPriority.Low;
                else if (rdPrioHigh.Checked)
                    priority = MailPriority.High;
                string tailContent = txtTailContent.Text.Replace(System.Environment.NewLine, "\n");

                // 重新生成内存对象
                Manager.MailSender = new MailSender(host, port, enableSSL, address, password, timeout, displayName, priority, tailContent);

                // 写数据库
                MailSenderStorage.WriteMailSender(Manager.MailSender);

                MessageBox.Show("保存完成!");
            }
            else
            {
                e.Cancel = true;
            }
        }


    }
}
