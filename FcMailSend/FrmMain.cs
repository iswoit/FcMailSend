﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FcMailSend
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// 发送模式键值对
        /// </summary>
        public class ComboBoxSendModeItem
        {
            private string _Text;
            private MailSendMode _Value;

            public ComboBoxSendModeItem(string sText, MailSendMode sValue)
            {
                this._Text = sText;
                this._Value = sValue;
            }

            public string Text
            {
                get { return _Text; }
            }

            public MailSendMode Value
            {
                get { return _Value; }
            }

            public override string ToString()
            {
                return this.Text;
            }
        }


        #region 变量
        private Point preToolTipPoint = new Point(-1, -1);      // 提示框坐标
        private Manager _manager;
        private ProductSearchDialog _searchDialog = null;
        #endregion

        #region 属性
        private Manager Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }


        private ProductSearchDialog SearchDialog
        {
            get { return _searchDialog; }
            set { _searchDialog = value; }
        }
        #endregion


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 加载配置
            try
            {
                // 打开新相册
                Manager = new Manager();
            }
            catch (Exception ex)
            {
                string msg = String.Format("读取配置发生异常：\n{0}", ex.Message);
                MessageBox.Show(msg, "发生异常");
            }

            // 初始化产品列表
            DisplayProductList();

            // 日期选择为当天
            rbDateToday.Checked = true;

            // 发送模式列表框
            cbSendMode.Items.Clear();
            foreach (MailSendMode sendMode in Enum.GetValues(typeof(MailSendMode)))
            {
                cbSendMode.Items.Add(new ComboBoxSendModeItem(sendMode.ToString(), sendMode));
            }
            if (cbSendMode.Items.Count > 0)
            {
                cbSendMode.SelectedIndex = 0;
            }
        }


        /// <summary>
        /// 初始化列表
        /// </summary>
        private void DisplayProductList()
        {
            DateTime date = DateTime.Now.Date;
            if (rbDateToday.Checked)
            {
                date = DateTime.Now.Date;
            }
            else if (rbDateOther.Checked)
            {
                date = dtpDate.Value.Date;
            }
            // 初始化前先更新一遍状态
            ProductStorage.UpdateProductListOKFlag(Manager.ProductList, date);


            lvProductList.Items.Clear();
            lvProductList.BeginUpdate();
            int idx = 0;    // 计数器
            foreach (Product product in Manager.ProductList)
            {
                if (cbShowNoCreditOnly.Checked)
                {
                    if (product.IsCredit)
                        continue;
                }

                ListViewItem lvi = new ListViewItem((++idx).ToString());
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.IsCredit ? "√" : string.Empty);
                lvi.SubItems.Add("×");
                lvi.SubItems.Add(product.IsSendOK ? "√" : "×");
                lvi.SubItems.Add(string.Empty);

                lvi.Tag = product;
                //lvi.Checked = true;

                if (product.IsSendOK)
                    lvi.BackColor = SystemColors.Window;
                else
                    lvi.BackColor = Color.Pink;

                lvProductList.Items.Add(lvi);
            }

            //lvProductList.Columns[0].Width = -1;
            //lvProductList.Columns[1].Width = -1;
            //lvProductList.Columns[2].Width = -1;
            //lvProductList.Columns[3].Width = -1;
            //lvProductList.Columns[4].Width = -1;
            //lvProductList.Columns[5].Width = -1;

            lvProductList.EndUpdate();

            lbIsAllSendOK.Text = "N/A";
            lbIsAllSendOK.ForeColor = Color.Black;
        }

        /// <summary>
        /// 刷新列表
        /// </summary>
        private void ReloadProductList()
        {
            Manager.ReloadProductList();
            DisplayProductList();
        }

        /// <summary>
        /// 刷新列表
        /// </summary>
        private void UpdateProductList()
        {
            lvProductList.BeginUpdate();
            // 进度列表
            try
            {
                for (int i = 0; i < lvProductList.Items.Count; i++)
                {
                    Product product = (Product)lvProductList.Items[i].Tag;
                    lvProductList.Items[i].SubItems[3].Text = product.IsAttachmentOK ? "√" : "×";
                    lvProductList.Items[i].SubItems[4].Text = product.IsSendOK ? "√" : "×"; ;
                    lvProductList.Items[i].SubItems[5].Text = product.Note;

                    if (product.IsRunning)
                    {
                        lvProductList.Items[i].BackColor = Color.LightBlue;
                        lvProductList.Items[i].EnsureVisible();
                    }
                    else
                    {
                        if (product.IsSendOK)
                            lvProductList.Items[i].BackColor = SystemColors.Window;
                        else
                            lvProductList.Items[i].BackColor = Color.Pink;
                    }
                }

                //bankDistLv.Columns[0].Width = -1;
                //bankDistLv.Columns[1].Width = -1;
                //bankDistLv.Columns[2].Width = -1;
                //bankDistLv.Columns[3].Width = -1;
                //bankDistLv.Columns[5].Width = -1;
            }
            catch (Exception)
            {
                // ui异常过滤
            }

            lvProductList.EndUpdate();

            lbIsAllSendOK.Text = "N/A";
            lbIsAllSendOK.ForeColor = Color.Black;

            //if ((Manager.GetInstance().IsRunning))
            //{
            //    stautsLb.Text = "运行中...";
            //}
            //else
            //{
            //    stautsLb.Text = "运行完毕";
            //}



        }


        private void btnSendAllNoCredit_Click(object sender, EventArgs e)
        {
            if (!bwSendMail.IsBusy)
            {
                // 获取参数对象
                MailSendMode sendMode = ((ComboBoxSendModeItem)cbSendMode.SelectedItem).Value;
                DateTime date;
                if (rbDateToday.Checked)
                    date = DateTime.Now.Date;
                else
                    date = dtpDate.Value.Date;

                ProductList productListTmp = new ProductList();
                switch (sendMode)
                {
                    case MailSendMode.重发所有产品:
                        foreach (Product product in Manager.ProductList)
                        {
                            if (product.IsCredit == false)
                            {
                                product.Note = string.Empty;
                                productListTmp.Add(product);
                            }
                        }
                        break;
                    case MailSendMode.只发送勾选的产品:
                        foreach (ListViewItem lvi in lvProductList.Items)
                        {
                            if (lvi.Checked == true)
                            {
                                if (((Product)lvi.Tag).IsCredit == false)
                                {
                                    productListTmp.Add((Product)lvi.Tag);
                                }
                            }
                        }
                        break;
                    case MailSendMode.发送未发送的产品:
                    default:
                        foreach (Product product in Manager.ProductList)
                        {
                            if (product.IsCredit == false)
                            {
                                if (product.IsSendOK == false)
                                {
                                    productListTmp.Add(product);
                                }
                            }

                            product.Note = string.Empty;
                        }
                        break;
                }


                MailSendArgument arg = new MailSendArgument(sendMode, date, productListTmp, true, Manager.MailSender.SendInterval);

                lbIsAllSendOK.Text = "N/A";
                lbIsAllSendOK.ForeColor = Color.Black;
                btnSendAllNoCredit.Text = "点击取消...";

                // 禁用菜单
                menuStrip.Enabled = false;
                btnSendAll.Enabled = false;

                bwSendMail.RunWorkerAsync(arg);
            }
            else
            {
                btnSendAllNoCredit.Text = "发送邮件(不含信用)";
                bwSendMail.CancelAsync();
            }
        }


        private void btnSendAll_Click(object sender, EventArgs e)
        {
            if (!bwSendMail.IsBusy)
            {
                // 获取参数对象
                MailSendMode sendMode = ((ComboBoxSendModeItem)cbSendMode.SelectedItem).Value;
                DateTime date;
                if (rbDateToday.Checked)
                    date = DateTime.Now.Date;
                else
                    date = dtpDate.Value.Date;

                ProductList productListTmp = new ProductList();
                switch (sendMode)
                {
                    case MailSendMode.重发所有产品:
                        foreach (Product product in Manager.ProductList)
                        {
                            product.Note = string.Empty;
                            productListTmp.Add(product);
                        }
                        break;
                    case MailSendMode.只发送勾选的产品:
                        foreach (ListViewItem lvi in lvProductList.Items)
                        {
                            if (lvi.Checked == true)
                            {
                                productListTmp.Add((Product)lvi.Tag);
                            }
                        }
                        break;
                    case MailSendMode.发送未发送的产品:
                    default:
                        foreach (Product product in Manager.ProductList)
                        {
                            if (product.IsSendOK == false)
                            {
                                productListTmp.Add(product);
                            }

                            product.Note = string.Empty;
                        }
                        break;
                }


                MailSendArgument arg = new MailSendArgument(sendMode, date, productListTmp, false, Manager.MailSender.SendInterval);

                lbIsAllSendOK.Text = "N/A";
                lbIsAllSendOK.ForeColor = Color.Black;
                btnSendAll.Text = "点击取消...";

                // 禁用菜单
                menuStrip.Enabled = false;
                btnSendAllNoCredit.Enabled = false;

                bwSendMail.RunWorkerAsync(arg);
            }
            else
            {
                btnSendAll.Text = "发送邮件";
                bwSendMail.CancelAsync();
            }
        }

        private void bwSendMail_DoWork(object sender, DoWorkEventArgs e)
        {
            /* 处理逻辑
             * 1.检查附件是否都存在
             * 2.发送
             * 3.写sqlite、数据库
             */

            MailSendArgument arg = (MailSendArgument)e.Argument;
            // 根据模式筛选product
            ProductList productListTmp = arg.ProductList;


            try
            {
                Manager.SendMail(productListTmp, arg.Date, sender as BackgroundWorker, e, arg.SendInterval);
                e.Result = arg.IsCredit;    // 是否信用(简略)
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void bwSendMail_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // 更新listView
            try
            {
                UpdateProductList();
            }
            catch (Exception)
            {
                //Print_Message(ex.Message);
            }
        }

        private void bwSendMail_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Error != null)    // 未处理的异常，需要弹框
            {
                Print_Message(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                Print_Message("任务被手工取消");
            }
            else
            {
                if ((bool)e.Result == true)
                {
                    Print_Message(string.Format(@"邮件发送完成(不含信用). 进度{0}/{1}. 是否完成: {2}", Manager.ProductList.FinishedCountNoCredit, Manager.ProductList.TotalCountNoCredit, Manager.ProductList.IsAllSendOKNoCredit ? "√" : "×"));

                    if (Manager.ProductList.IsAllSendOKNoCredit == true)
                    {
                        lbIsAllSendOK.Text = "是";
                        lbIsAllSendOK.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbIsAllSendOK.Text = "否";
                        lbIsAllSendOK.ForeColor = Color.Red;
                    }
                }
                else
                {
                    Print_Message(string.Format(@"邮件发送完成. 进度{0}/{1}. 是否完成: {2}", Manager.ProductList.FinishedCount, Manager.ProductList.Count, Manager.ProductList.IsAllSendOK ? "√" : "×"));

                    if (Manager.ProductList.IsAllSendOK == true)
                    {
                        lbIsAllSendOK.Text = "是";
                        lbIsAllSendOK.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbIsAllSendOK.Text = "否";
                        lbIsAllSendOK.ForeColor = Color.Red;
                    }
                }
            }


            btnSendAllNoCredit.Text = "发送邮件(不含信用)";
            btnSendAll.Text = "发送邮件";

            menuStrip.Enabled = true;
            btnSendAll.Enabled = true;
            btnSendAllNoCredit.Enabled = true;
        }


        /// <summary>
        /// 编辑-修改发件人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditMailSender_Click(object sender, EventArgs e)
        {
            using (MailSenderEditDialog dlg = new MailSenderEditDialog(Manager))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // 不做操作
                }
            }
        }

        /// <summary>
        /// 编辑-修改ftp信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditMailFtp_Click(object sender, EventArgs e)
        {
            using (MailFtpListDialog dlg = new MailFtpListDialog(Manager))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        /// <summary>
        /// 编辑-新增产品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditProductAdd_Click(object sender, EventArgs e)
        {
            using (ProductEditDialog dlg = new ProductEditDialog(0))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // 刷新列表
                    ReloadProductList();
                }
            }
        }

        /// <summary>
        /// 编辑-修改产品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditProductEdit_Click(object sender, EventArgs e)
        {
            if (lvProductList.SelectedItems.Count <= 0)
                return;

            ListViewItem lvi = lvProductList.SelectedItems[0];
            if (lvi != null)
            {
                Product product = (Product)lvi.Tag;
                using (ProductEditDialog dlg = new ProductEditDialog(product.Id))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        // 刷新列表
                        ReloadProductList();
                    }
                }
            }
        }


        /// <summary>
        /// 编辑-删除产品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditProductDel_Click(object sender, EventArgs e)
        {
            if (lvProductList.SelectedItems.Count > 0)
            {
                Product product = (Product)lvProductList.SelectedItems[0].Tag;

                DialogResult dr = MessageBox.Show(string.Format(@"确定删除产品[{0}]?", product.ProductName), "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        ProductStorage.DeleteProduct(product);
                        MessageBox.Show("产品已删除!");
                        ReloadProductList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        private void menuEdit_DropDownOpening(object sender, EventArgs e)
        {
            if (lvProductList.SelectedItems.Count > 0)
            {
                menuEditProductEdit.Enabled = true;
                menuEditProductDel.Enabled = true;
            }
            else
            {
                menuEditProductEdit.Enabled = false;
                menuEditProductDel.Enabled = false;
            }
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProductCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvProductList.Items)
                lvi.Checked = true;
        }


        private void btnProductCheckReverse_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvProductList.Items)
                lvi.Checked = !lvi.Checked;
        }

        private void cbSendMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBoxSendModeItem)cbSendMode.SelectedItem).Value)
            {

                case MailSendMode.只发送勾选的产品:
                    lvProductList.CheckBoxes = true;
                    foreach (Control control in gbProductSel.Controls)
                    {
                        if (control is Button)
                            control.Enabled = true;
                    }
                    break;
                default:
                    lvProductList.CheckBoxes = false;
                    foreach (Control control in gbProductSel.Controls)
                    {
                        if (control is Button)
                            control.Enabled = false;
                    }
                    break;
            }
        }

        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Date;
            if (rbDateToday.Checked)
            {
                dtpDate.Enabled = false;
                date = DateTime.Now.Date;
            }
            else if (rbDateOther.Checked)
            {
                dtpDate.Enabled = true;
                date = dtpDate.Value.Date;
            }

            // 更新日期

            DisplayProductList();
        }

        private void Print_Message(string message)
        {
            txtLog.Text = string.Format("{0}:{1}", DateTime.Now.ToString("HH:mm:ss"), message) + System.Environment.NewLine + txtLog.Text;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // 更新日期
            DisplayProductList();
        }

        /// <summary>
        /// 鼠标提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvProductList_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                // 防止闪烁
                if (preToolTipPoint.X != e.X || preToolTipPoint.Y != e.Y)
                {
                    ListViewItem lvi = lvProductList.GetItemAt(e.X, e.Y);
                    if (lvi != null)
                        toolTip.Show(((Product)lvi.Tag).Note, lvProductList, new Point(e.X + 30, e.Y + 20), 200000);
                    else
                        toolTip.Hide(lvProductList);
                }

                preToolTipPoint = e.Location;
            }
            catch
            { }
        }



        /// <summary>
        /// 查看-搜索产品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuViewSearch_Click(object sender, EventArgs e)
        {
            if (SearchDialog == null || SearchDialog.IsDisposed)
            {
                SearchDialog = new ProductSearchDialog(this);
                SearchDialog.Owner = this;
            }

            SearchDialog.StartPosition = FormStartPosition.Manual;
            SearchDialog.Location = new Point(this.Location.X + this.Width, this.Location.Y);

            SearchDialog.Show();

        }


        /// <summary>
        /// 查看-日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuViewSendLog_Click(object sender, EventArgs e)
        {
            using (ProductSendLogDialog dlg = new ProductSendLogDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        /// <summary>
        /// 帮助-关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            using (AboutDialog dlg = new AboutDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                { }
            }
        }

        private void cbShowNoCreditOnly_CheckedChanged(object sender, EventArgs e)
        {
            DisplayProductList();
        }
    }
}
