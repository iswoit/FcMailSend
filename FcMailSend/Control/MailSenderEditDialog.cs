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
            txtSendInterval.Text = mailSender.SendInterval.ToString();

            //base.ResetDialog();
        }


        private bool ValidatePort()
        {
            // 验证端口
            int iTmp;
            if (!int.TryParse(txtPort.Text.Trim(), out iTmp))
                return false;

            if (iTmp >= 0 && iTmp <= 65535)
                return true;
            else
                return false;
        }

        private bool ValidateSendInterval()
        {
            // 验证发送间隔
            int iTmp;
            if (!int.TryParse(txtSendInterval.Text.Trim(), out iTmp))
                return false;

            if (iTmp >= 0 && iTmp <= 30)
                return true;
            else
                return false;
        }



        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (!ValidatePort())
                {
                    DialogResult result = MessageBox.Show("[端口]必须是0-65535之间的数字", "格式", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPort.Focus();
                    e.Cancel = true;
                }

                if (!ValidateSendInterval())
                {
                    DialogResult result = MessageBox.Show("[发送间隔]必须是0-30之间的数字", "格式", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSendInterval.Focus();
                    e.Cancel = true;
                }


                if (!e.Cancel)
                    SaveSettings(e);
            }

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
                int sendInterval = int.Parse(txtSendInterval.Text.Trim());

                // 重新生成内存对象
                Manager.MailSender = new MailSender(host, port, enableSSL, address, password, timeout, displayName, priority, tailContent, sendInterval);

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
