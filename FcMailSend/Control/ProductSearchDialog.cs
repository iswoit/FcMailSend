using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FcMailSend
{
    public partial class ProductSearchDialog : Form
    {
        private int _lastIdx = -1;      // 上一个索引值
        private FrmMain _frmMain;       // 主窗口

        private FrmMain FrmMain         // 主窗口
        {
            get { return _frmMain; }
        }


        public ProductSearchDialog(FrmMain frmMain)
        {
            InitializeComponent();

            _frmMain = frmMain;
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.Trim();        // 产品名称
            if (productName.Length <= 0)
            {
                txtProductName.Focus();
                return;
            }


            int start0, end0;
            int start1 = -1, end1 = -1;
            start0 = _lastIdx + 1;
            end0 = FrmMain.lvProductList.Items.Count - 1;
            if (start0 != -1)
            {
                start1 = 0;
                end1 = _lastIdx;
            }



            for (int i = start0; i <= end0; i++)
            {
                Product product = (Product)FrmMain.lvProductList.Items[i].Tag;
                if (product.ProductName.Contains(productName))
                {
                    FrmMain.lvProductList.Items[i].Selected = true;
                    FrmMain.lvProductList.Items[i].EnsureVisible();
                    _lastIdx = i;

                    FrmMain.Focus();
                    return;
                }
            }
            for(int i= start1;i<= end1;i++)
            {
                Product product = (Product)FrmMain.lvProductList.Items[i].Tag;
                if (product.ProductName.Contains(productName))
                {
                    FrmMain.lvProductList.Items[i].Selected = true;
                    FrmMain.lvProductList.Items[i].EnsureVisible();
                    _lastIdx = i;

                    FrmMain.Focus();
                    return;
                }
            }
        }

    }
}
