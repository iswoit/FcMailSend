using System;
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
        #region 变量
        private Manager _manager;
        #endregion

        #region 属性
        private Manager Manager
        {
            get { return _manager; }
            set { _manager = value; }
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

            DisplayProductList();
        }


        private void DisplayProductList()
        {

            lvProductList.Items.Clear();
            lvProductList.BeginUpdate();
            int idx = 0;    // 计数器
            foreach (Product product in Manager.ProductList)
            {
                ListViewItem lvi = new ListViewItem((++idx).ToString());
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add("×");
                lvi.SubItems.Add("×");
                lvi.SubItems.Add(string.Empty);

                lvi.Tag = product;

                //if (bankDist.IsFileAllCopied)
                //    lvi.BackColor = SystemColors.Window;
                //else
                //    lvi.BackColor = Color.Pink;

                lvProductList.Items.Add(lvi);
            }

            //lvProductList.Columns[0].Width = -1;
            //lvProductList.Columns[1].Width = -1;
            //lvProductList.Columns[2].Width = -1;
            //lvProductList.Columns[3].Width = -1;
            //lvProductList.Columns[4].Width = -1;
            //lvProductList.Columns[5].Width = -1;

            lvProductList.EndUpdate();

            //if (Manager.GetInstance().BankDistCollection.IsAllBankCopied)
            //{
            //    isAllOKLb.Text = "是";
            //    isAllOKLb.ForeColor = Color.Green;
            //}
            //else
            //{
            //    isAllOKLb.Text = "否";
            //    isAllOKLb.ForeColor = Color.Red;
            //}
        }


        private void UpdateProductList()
        {
            lvProductList.BeginUpdate();
            // 进度列表
            try
            {
                for (int i = 0; i < lvProductList.Items.Count; i++)
                {
                    Product product = (Product)lvProductList.Items[i].Tag;
                    lvProductList.Items[i].SubItems[2].Text = product.IsAttachmentOK ? "√" : "×";
                    lvProductList.Items[i].SubItems[3].Text = product.IsSendOK ? "√" : "×"; ;
                    lvProductList.Items[i].SubItems[4].Text = product.Note;

                    if (product.IsRunning)
                    {
                        lvProductList.Items[i].BackColor = Color.LightBlue;
                        lvProductList.Items[i].EnsureVisible();
                    }
                    else
                    {
                        lvProductList.Items[i].BackColor = SystemColors.Window;
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


            //if ((Manager.GetInstance().IsRunning))
            //{
            //    stautsLb.Text = "运行中...";
            //}
            //else
            //{
            //    stautsLb.Text = "运行完毕";
            //}


            //if (Manager.GetInstance().BankDistCollection.IsAllBankCopied)
            //{
            //    isAllOKLb.Text = "是";
            //    isAllOKLb.ForeColor = Color.Green;
            //}
            //else
            //{
            //    isAllOKLb.Text = "否";
            //    isAllOKLb.ForeColor = Color.Red;
            //}
        }

        private void btnSendAll_Click(object sender, EventArgs e)
        {
            if (!bwSendMail.IsBusy)
            {
                //executeBtn.Text = "执行中...";
                bwSendMail.RunWorkerAsync();

                //Manager.GetInstance().IsRunning = true;
            }
            else
            {
                //executeBtn.Text = "执行";
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

            try
            {
                Manager.SendMail(sender as BackgroundWorker, e);
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
            catch (Exception ex)
            {
                //Print_Message(ex.Message);
            }
        }

        private void bwSendMail_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)    // 未处理的异常，需要弹框
            {
                //Print_Message(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                //Print_Message("任务被手工取消");
            }
            else
            {
                //Print_Message(string.Format(@"****执行完成 [进度: ({0}/{1}), 是否完成: {2}]****", Manager.GetInstance().BankDistCollection.OKCnt, Manager.GetInstance().BankDistCollection.Count, Manager.GetInstance().BankDistCollection.IsAllBankCopied ? "是" : "否"));
            }

            //Manager.GetInstance().IsRunning = false;
            //executeBtn.Text = "执行";

            // 最后刷新

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



        private void ctxFcMailSend_Opening(object sender, CancelEventArgs e)
        {
            // 邮件没选中不弹出
            int iCount = lvProductList.SelectedItems.Count;
            if (iCount <= 0)
                e.Cancel = true;
        }



        private void menuEditProductAdd_Click(object sender, EventArgs e)
        {
            using (ProductEditDialog dlg = new ProductEditDialog(Manager, null))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // 刷新列表
                }
            }
        }


        /// <summary>
        /// 修改产品参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditProductEdit_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lvProductList.SelectedItems[0];
            if (lvi != null)
            {
                Product product = (Product)lvi.Tag;
                using (ProductEditDialog dlg = new ProductEditDialog(Manager, product))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        // 刷新列表
                    }
                }
            }
        }

        private void menuEditMailFtp_Click(object sender, EventArgs e)
        {
            using (MailFtpListDialog dlg = new MailFtpListDialog(Manager))
            {
                if(dlg.ShowDialog()==DialogResult.OK)
                {

                }
            }
        }
    }
}
