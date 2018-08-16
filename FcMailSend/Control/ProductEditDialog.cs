using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace FcMailSend
{
    public partial class ProductEditDialog : BaseEditDialog
    {
        private int _productID;
        private Product _product;


        #region 属性
        private int ProductID
        {
            get { return _productID; }
        }
        private Product Product
        {
            get { return _product; }
        }
        #endregion


        public ProductEditDialog(int productID)
        {
            InitializeComponent();

            _productID = productID;
            ResetDialog();
        }

        protected override void ResetDialog()
        {
            Product product;
            if (ProductID <= 0)
                product = new Product(0, string.Empty, string.Empty, string.Empty, null, false, new ProductAttachmentList(), new ProductReceiverList());
            else
                product = ProductStorage.ReadProduct(ProductID);
            _product = product;

            // 总体参数
            txtProductName.Text = Product.ProductName;
            txtMailTitle.Text = Product.MailTitle;
            txtMailContent.Text = Product.MailContent.Replace("\n", System.Environment.NewLine);
            cbDisable.Checked = Product.Disable;

            // 附件

            // 收件人
            ResetReceiverList();

            if (Product.Id <= 0)
                this.Text = "新增产品发送参数";
            else
                this.Text = "修改产品发送参数";

        }


        private void ResetAttachmentList()
        {
            lvAttachment.Items.Clear();
            lvAttachment.BeginUpdate();

            int idx = 0;
            foreach (ProductAttachment att in Product.ProductAttachmentList)
            {
                ListViewItem lvi = new ListViewItem((++idx).ToString());
                lvi.SubItems.Add(att.Type.ToString());
                lvi.SubItems.Add(att.Path);
                lvi.Tag = att;

                lvAttachment.Items.Add(lvi);
            }
            lvAttachment.EndUpdate();
        }


        /// <summary>
        /// 刷新收件人列表
        /// </summary>
        private void ResetReceiverList()
        {
            lvReceiver.Items.Clear();
            lvReceiver.BeginUpdate();

            int idx = 0;    // 计数器
            foreach (ProductReceiver receiver in Product.ProductReceiverList)
            {
                ListViewItem lvi = new ListViewItem((++idx).ToString());
                lvi.SubItems.Add(receiver.EmailAddress);
                lvi.SubItems.Add(receiver.ReceiverType.ToString());
                lvi.Tag = receiver;

                lvReceiver.Items.Add(lvi);
            }
            lvReceiver.EndUpdate();
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveSettings(e);
        }

        private void SaveSettings(CancelEventArgs e)
        {

        }

        private void ctxReceiver_Opening(object sender, CancelEventArgs e)
        {
            int iCount = lvReceiver.SelectedItems.Count;
            if (iCount <= 0)
            {
                menuReceiverEdit.Enabled = false;
                menuReceiverDel.Enabled = false;
            }
            else
            {
                menuReceiverEdit.Enabled = true;
                menuReceiverDel.Enabled = true;
            }
        }

        private void menuReceiverAdd_Click(object sender, EventArgs e)
        {
            ProductReceiver tmpReceiver = new ProductReceiver(Product.Id, string.Empty, ReceiverType.收件人);

            using (ProductReceiverEditDialog dlg = new ProductReceiverEditDialog(Product.ProductReceiverList, tmpReceiver))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // 增加对象
                    Product.ProductReceiverList.Add(tmpReceiver);

                    // 刷新界面
                    ResetReceiverList();
                }
            }
        }

        private void menuReceiverEdit_Click(object sender, EventArgs e)
        {
            if (lvReceiver.SelectedItems.Count > 0)
            {
                ProductReceiver receiver = (ProductReceiver)lvReceiver.SelectedItems[0].Tag;

                using (ProductReceiverEditDialog dlg = new ProductReceiverEditDialog(Product.ProductReceiverList, receiver))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        // 刷新界面
                        ResetReceiverList();
                    }
                }
            }


        }


        /// <summary>
        /// 收件人删除(只是内存对象)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuReceiverDel_Click(object sender, EventArgs e)
        {
            if (lvReceiver.SelectedItems.Count > 0)
            {
                ProductReceiver receiver = (ProductReceiver)lvReceiver.SelectedItems[0].Tag;
                Product.ProductReceiverList.Remove(receiver);   // 删除对象
                ResetReceiverList();    // 刷新界面
            }
        }
    }
}
