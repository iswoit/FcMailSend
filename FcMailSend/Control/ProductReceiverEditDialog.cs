using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FcMailSend
{
    public partial class ProductReceiverEditDialog : BaseEditDialog
    {
        private ProductReceiverList _receiverList;              // 收件人列表
        private ProductReceiver _receiver;                      // 收件人



        private ProductReceiverList ProductReceiverList
        {
            get { return _receiverList; }
            set { _receiverList = value; }
        }

        private ProductReceiver ProductReceiver
        {
            get { return _receiver; }
            set { _receiver = value; }
        }



        public ProductReceiverEditDialog(ProductReceiverList receiverList, ProductReceiver receiver)
        {
            InitializeComponent();

            _receiverList = receiverList;
            _receiver = receiver;

            ResetDialog();
        }

        protected override void ResetDialog()
        {
            txtEmailAddress.Text = ProductReceiver.EmailAddress;

            switch (ProductReceiver.ReceiverType)
            {
                case ReceiverType.收件人:
                    rdTypeTo.Checked = true;
                    break;
                case ReceiverType.抄送:
                    rdTypeCc.Checked = true;
                    break;
                case ReceiverType.密送:
                    rdTypeBcc.Checked = true;
                    break;
                default:
                    rdTypeTo.Checked = true;
                    break;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveSettings(e);
        }

        private void SaveSettings(CancelEventArgs e)
        {
            string emailAddress = txtEmailAddress.Text.Trim();
            ReceiverType type = ReceiverType.收件人;
            if (rdTypeTo.Checked)
                type = ReceiverType.收件人;
            else if (rdTypeCc.Checked)
                type = ReceiverType.抄送;
            else if (rdTypeBcc.Checked)
                type = ReceiverType.密送;


            ProductReceiver.EmailAddress = emailAddress;
            ProductReceiver.ReceiverType = type;

        }
    }
}
