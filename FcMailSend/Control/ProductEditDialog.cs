using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FcMailSend
{
    public partial class ProductEditDialog : BaseEditDialog
    {
        private Manager _manager;
        private Product _product;

        private Manager Manager
        {
            get { return _manager; }
        }

        private Product Product
        {
            get { return _product; }
        }



        public ProductEditDialog(Manager mgr, Product product)
        {
            InitializeComponent();

            _manager = mgr;
            _product = product;

            ResetDialog();
        }

        protected override void ResetDialog()
        {
            if (Product != null)
            {
                txtProductName.Text = Product.ProductName;
                txtMailTitle.Text = Product.MailTitle;
                txtMailContent.Text = Product.MailContent.Replace("\n", System.Environment.NewLine);
                cbDisable.Checked = Product.Disable;

                this.Text = "修改产品发送参数";
            }
            else
            {
                txtProductName.Text = string.Empty;
                txtMailTitle.Text = string.Empty;
                txtMailContent.Text = string.Empty;
                cbDisable.Checked = false;

                this.Text = "新增产品发送参数";
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveSettings(e);
        }

        private void SaveSettings(CancelEventArgs e)
        {

        }
    }
}
