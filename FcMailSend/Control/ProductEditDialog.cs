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

        /// <summary>
        /// 重置整个产品
        /// </summary>
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
            ResetAttachmentList();
            // 收件人
            ResetReceiverList();

            if (Product.Id <= 0)
                this.Text = "新增产品发送参数";
            else
                this.Text = "修改产品发送参数";

        }

        /// <summary>
        /// 刷新附件列表
        /// </summary>
        private void ResetAttachmentList()
        {
            lvAttachment.Items.Clear();
            lvAttachment.BeginUpdate();

            int idx = 0;
            foreach (ProductAttachment att in Product.ProductAttachmentList)
            {
                ListViewItem lvi = new ListViewItem((++idx).ToString());
                lvi.SubItems.Add(att.Type.ToString());
                lvi.SubItems.Add(att.DisplayPath);
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

        /// <summary>
        /// 附件菜单打开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctxAttachment_Opening(object sender, CancelEventArgs e)
        {
            int iCount = lvAttachment.SelectedItems.Count;
            if (iCount <= 0)
            {
                menuAttachmentEdit.Enabled = false;
                menuAttachmentDel.Enabled = false;
            }
            else
            {
                menuAttachmentEdit.Enabled = true;
                menuAttachmentDel.Enabled = true;
            }
        }

        /// <summary>
        /// 附件增加（内存）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAttachmentAdd_Click(object sender, EventArgs e)
        {
            ProductAttachment tmpAtt = new ProductAttachment(Product.Id, AttachmentType.磁盘路径, string.Empty, null);
            using (ProductAttachmentEditDialog dlg = new ProductAttachmentEditDialog(Product.ProductAttachmentList, tmpAtt))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // 增加对象
                    Product.ProductAttachmentList.Add(tmpAtt);
                    // 刷新界面
                    ResetAttachmentList();
                }
            }
        }

        /// <summary>
        /// 附件修改（内存）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAttachmentEdit_Click(object sender, EventArgs e)
        {
            if (lvAttachment.SelectedItems.Count > 0)
            {
                ProductAttachment att = (ProductAttachment)lvAttachment.SelectedItems[0].Tag;
                using (ProductAttachmentEditDialog dlg = new ProductAttachmentEditDialog(Product.ProductAttachmentList, att))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        // 刷新界面
                        ResetAttachmentList();
                    }
                }
            }
        }

        /// <summary>
        /// 附件删除（内存）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAttachmentDel_Click(object sender, EventArgs e)
        {
            if (lvAttachment.SelectedItems.Count > 0)
            {
                ProductAttachment att = (ProductAttachment)lvAttachment.SelectedItems[0].Tag;
                Product.ProductAttachmentList.Remove(att);   // 删除对象
                ResetAttachmentList();   // 刷新界面
            }
        }

        /// <summary>
        /// 收件人菜单打开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 收件人增加（内存）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 收件人修改（内存）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// 收件人删除(内存)
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


        /// <summary>
        /// 关闭保存
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveSettings(e);
        }

        private void SaveSettings(CancelEventArgs e)
        {
            Product.ProductName = txtProductName.Text;
            Product.MailTitle = txtMailTitle.Text;
            Product.Disable = cbDisable.Checked;
            Product.MailContent = txtMailContent.Text.Replace(System.Environment.NewLine, "\n");

            DialogResult dr = MessageBox.Show("确定提交修改?", "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ProductID <= 0)    // 新增
                {
                    ProductStorage.AddProduct(Product);
                }
                else  // 修改
                {

                }
            }
        }
    }
}
