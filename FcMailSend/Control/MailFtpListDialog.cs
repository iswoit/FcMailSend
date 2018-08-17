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

        private void menuFtpAdd_Click(object sender, EventArgs e)
        {
            using (MailFtpEditDialog dlg = new MailFtpEditDialog(Manager, null))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Manager.ReloadFtpList();
                    ResetDialog();
                }
            }

        }

        private void menuFtpEdit_Click(object sender, EventArgs e)
        {
            if (lvFtpList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvFtpList.SelectedItems[0];
                if (lvi != null)
                {
                    MailFtp mailFtp = (MailFtp)lvi.Tag;
                    using (MailFtpEditDialog dlg = new MailFtpEditDialog(Manager, mailFtp))
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            Manager.ReloadFtpList();
                            ResetDialog();
                        }
                    }
                }
            }
        }

        private void ctxMailFtp_Opening(object sender, CancelEventArgs e)
        {
            // 邮件没选中不弹出
            int iCount = lvFtpList.SelectedItems.Count;
            if (iCount <= 0)
            {
                menuFtpEdit.Enabled = false;
                menuFtpDel.Enabled = false;
            }
            else
            {
                menuFtpEdit.Enabled = true;
                menuFtpDel.Enabled = true;
            }

        }

        private void menuFtpDel_Click(object sender, EventArgs e)
        {
            if (lvFtpList.SelectedItems.Count > 0)
            {
                MailFtp mailFtp = (MailFtp)lvFtpList.SelectedItems[0].Tag;

                DialogResult dr = MessageBox.Show("确定删除此条连接?", "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        MailFtpStorage.DelMailFtp(mailFtp);
                        MessageBox.Show("已删除!");
                        Manager.ReloadFtpList();
                        ResetDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }



        }
    }
}
