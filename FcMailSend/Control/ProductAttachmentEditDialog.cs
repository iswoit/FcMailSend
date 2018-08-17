using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FcMailSend
{
    public partial class ProductAttachmentEditDialog : BaseEditDialog
    {
        private class ComboBoxFtpItem
        {
            private string _Text;
            private int _Value;

            public ComboBoxFtpItem(string sText, int sValue)
            {
                this._Text = sText;
                this._Value = sValue;
            }

            public string Text
            {
                get { return _Text; }
            }

            public int Value
            {
                get { return _Value; }
            }

            public override string ToString()
            {
                return this.Text;
            }
        }

        private ProductAttachmentList _attList;
        private ProductAttachment _att;
        private MailFtpList _ftpList;


        private ProductAttachmentList AttachmentList
        {
            get { return _attList; }
            set { _attList = value; }
        }
        private ProductAttachment Attachment
        {
            get { return _att; }
            set { _att = value; }
        }
        private MailFtpList FtpList
        {
            get { return _ftpList; }
        }


        public ProductAttachmentEditDialog(ProductAttachmentList attList, ProductAttachment att)
        {
            InitializeComponent();

            _attList = attList;
            _att = att;

            // 加载ftp列表
            _ftpList = MailFtpStorage.ReadMailFtpList();
            cbFtp.Items.Clear();

            foreach (MailFtp ftp in _ftpList)
                cbFtp.Items.Add(new ComboBoxFtpItem(ftp.FtpDesc, ftp.Id));

            ResetDialog();
        }


        protected override void ResetDialog()
        {
            switch (Attachment.Type)
            {
                case AttachmentType.磁盘路径:
                    rdPath.Checked = true;
                    break;
                case AttachmentType.FTP:
                    {
                        rdFtp.Checked = true;
                        if (Attachment.FtpID != null)
                        {
                            foreach (object ftp in cbFtp.Items)
                            {
                                if (Attachment.FtpID == ((ComboBoxFtpItem)ftp).Value)
                                {
                                    cbFtp.SelectedItem = ftp;
                                    break;
                                }
                            }
                        }
                    }
                    break;
                default:
                    rdPath.Checked = true;
                    break;
            }


            txtPath.Text = Attachment.Path;
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveSettings(e);
        }

        private void SaveSettings(CancelEventArgs e)
        {
            if (rdPath.Checked)
            {
                Attachment.Type = AttachmentType.磁盘路径;
                Attachment.FtpID = null;
            }
            else if (rdFtp.Checked)
            {
                Attachment.Type = AttachmentType.FTP;
                Attachment.FtpID = ((ComboBoxFtpItem)cbFtp.SelectedItem).Value;
            }

            Attachment.Path = txtPath.Text;
        }

        private void rdType_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPath.Checked)
                cbFtp.Enabled = false;
            else if (rdFtp.Checked)
                cbFtp.Enabled = true;
        }
    }
}
