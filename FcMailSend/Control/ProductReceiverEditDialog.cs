using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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


        private void txtEmailAddress_Validating(object sender, CancelEventArgs e)
        {

            if (txtEmailAddress.Text.Trim().Length <= 0)
                errorProvider.SetError(txtEmailAddress, "收件人地址不能为空");
            else
            {
                Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\S+\\.)+\\w{2,5})\\s*$");
                if (!r.IsMatch(txtEmailAddress.Text.Trim()))
                    errorProvider.SetError(txtEmailAddress, "收件人地址格式不正确");
                else
                    errorProvider.SetError(txtEmailAddress, string.Empty);
            }
        }


        /// <summary>
        /// 收件人长度
        /// </summary>
        /// <returns></returns>
        private bool ValidateEmailAddressLength()
        {
            if (txtEmailAddress.Text.Trim().Length > 0)
                return true;
            else
                return false;
        }

        private bool ValidateEmailFormat()
        {
            Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\S+\\.)+\\w{2,5})\\s*$");
            if (r.IsMatch(txtEmailAddress.Text.Trim()))
                return true;
            else
                return false;
        }

        private bool ValidateReceiverType()
        {
            if (!rdTypeTo.Checked && !rdTypeCc.Checked && !rdTypeBcc.Checked)
                return false;

            return true;
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            // 输入项格式验证
            if (DialogResult == DialogResult.OK)
            {
                if (!ValidateEmailAddressLength())
                {
                    DialogResult result = MessageBox.Show("[收件人地址]不能为空", "收件人格式", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailAddress.Focus();
                    e.Cancel = true;
                }
                else if (!ValidateEmailFormat())
                {
                    DialogResult result = MessageBox.Show("[收件人地址]不符合格式规范", "收件人格式", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailAddress.Focus();
                    e.Cancel = true;
                }
                else if (!ValidateReceiverType())
                {
                    DialogResult result = MessageBox.Show("[收件人类型]请至少选择一种", "收件人类型", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }

            if (!e.Cancel)
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

    }
}
