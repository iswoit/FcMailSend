using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FcMailSend
{
    public partial class MailFtpListDialog : BaseEditDialog
    {
        private Manager _manager;

        private Manager Manager
        {
            get { return _manager; }
        }

        public MailFtpListDialog(Manager mgr)
        {
            InitializeComponent();

            _manager = mgr;
            ResetDialog();
        }

        protected override void ResetDialog()
        {
            lvFtpList.Items.Clear();
            lvFtpList.BeginUpdate();

            int idx = 0;
            foreach (MailFtp mailFtp in Manager.MailFtpList)
            {
                ListViewItem lvi = new ListViewItem((++idx).ToString());
                lvi.SubItems.Add(mailFtp.FtpDesc);
                lvi.SubItems.Add(mailFtp.FtpServer);
                lvi.SubItems.Add(mailFtp.UserName);
                lvi.Tag = mailFtp;

                lvFtpList.Items.Add(lvi);
            }
            lvFtpList.EndUpdate();
        }
    }
}
