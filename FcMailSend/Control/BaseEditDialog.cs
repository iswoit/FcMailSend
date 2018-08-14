using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FcMailSend
{
    public partial class BaseEditDialog : Form
    {
        public BaseEditDialog()
        {
            InitializeComponent();
        }

        protected virtual void ResetDialog()
        {
            // 基类不操作
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDialog();
        }
    }
}
