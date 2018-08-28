using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FcMailSend
{
    public partial class ProductSendLogDialog : BaseEditDialog
    {
        private ProductSendLogList _sendLogList;

        private ProductSendLogList SendLogList
        {
            get { return _sendLogList; }
            set { _sendLogList = value; }
        }


        public ProductSendLogDialog()
        {
            InitializeComponent();


            ResetDialog();
        }

        protected override void ResetDialog()
        {
            // 初始化列表

            lvLog.Items.Clear();


        }


        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                ResetDialog();
                SaveSettings(e);
            }
        }

        private void SaveSettings(CancelEventArgs e)
        {
            DateTime dtBegin = new DateTime(dtpBegin.Value.Year, dtpBegin.Value.Month, dtpBegin.Value.Day, 0, 0, 0);
            DateTime dtEnd = new DateTime(dtpEnd.Value.Year, dtpEnd.Value.Month, dtpEnd.Value.Day, 23, 59, 59);

            // 加载日志
            SendLogList = ProductSendLogStorage.ReadSendLogList(dtBegin, dtEnd);

            lvLog.BeginUpdate();
            int idx = 0;    // 计数器
            foreach (ProductSendLog sendLog in SendLogList)
            {
                ListViewItem lvi = new ListViewItem((++idx).ToString());
                lvi.SubItems.Add(sendLog.ProductName);
                lvi.SubItems.Add(sendLog.ProductDate.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(sendLog.IsSendOK ? "√" : "×");
                lvi.SubItems.Add(sendLog.Note);
                lvi.SubItems.Add(sendLog.OpTime.ToString("yyyy-MM-dd HH:mm:ss"));


                lvi.Tag = sendLog;
                lvLog.Items.Add(lvi);
            }

            lvLog.EndUpdate();


            e.Cancel = true;
        }
    }
}
