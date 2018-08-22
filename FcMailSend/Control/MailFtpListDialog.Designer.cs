namespace FcMailSend
{
    partial class MailFtpListDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvFtpList = new System.Windows.Forms.ListView();
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFtpDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFtpServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxMailFtp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuFtpAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFtpEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFtpDel = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ctxMailFtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Text = "关闭";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Visible = false;
            // 
            // lvFtpList
            // 
            this.lvFtpList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNo,
            this.chFtpDesc,
            this.chFtpServer,
            this.chUserName});
            this.lvFtpList.ContextMenuStrip = this.ctxMailFtp;
            this.lvFtpList.FullRowSelect = true;
            this.lvFtpList.GridLines = true;
            this.lvFtpList.Location = new System.Drawing.Point(14, 24);
            this.lvFtpList.MultiSelect = false;
            this.lvFtpList.Name = "lvFtpList";
            this.lvFtpList.Size = new System.Drawing.Size(501, 308);
            this.lvFtpList.TabIndex = 3;
            this.lvFtpList.UseCompatibleStateImageBehavior = false;
            this.lvFtpList.View = System.Windows.Forms.View.Details;
            // 
            // chNo
            // 
            this.chNo.Text = "No";
            this.chNo.Width = 36;
            // 
            // chFtpDesc
            // 
            this.chFtpDesc.Text = "FTP描述";
            this.chFtpDesc.Width = 124;
            // 
            // chFtpServer
            // 
            this.chFtpServer.Text = "FTP服务器";
            this.chFtpServer.Width = 143;
            // 
            // chUserName
            // 
            this.chUserName.Text = "用户名";
            this.chUserName.Width = 79;
            // 
            // ctxMailFtp
            // 
            this.ctxMailFtp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFtpAdd,
            this.menuFtpEdit,
            this.menuFtpDel});
            this.ctxMailFtp.Name = "ctxMailFtp";
            this.ctxMailFtp.Size = new System.Drawing.Size(154, 70);
            this.ctxMailFtp.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMailFtp_Opening);
            // 
            // menuFtpAdd
            // 
            this.menuFtpAdd.Name = "menuFtpAdd";
            this.menuFtpAdd.Size = new System.Drawing.Size(153, 22);
            this.menuFtpAdd.Text = "新增FTP连接...";
            this.menuFtpAdd.Click += new System.EventHandler(this.menuFtpAdd_Click);
            // 
            // menuFtpEdit
            // 
            this.menuFtpEdit.Name = "menuFtpEdit";
            this.menuFtpEdit.Size = new System.Drawing.Size(153, 22);
            this.menuFtpEdit.Text = "修改FTP连接...";
            this.menuFtpEdit.Click += new System.EventHandler(this.menuFtpEdit_Click);
            // 
            // menuFtpDel
            // 
            this.menuFtpDel.Name = "menuFtpDel";
            this.menuFtpDel.Size = new System.Drawing.Size(153, 22);
            this.menuFtpDel.Text = "删除FTP连接";
            this.menuFtpDel.Click += new System.EventHandler(this.menuFtpDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "FTP服务器列表:";
            // 
            // MailFtpListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvFtpList);
            this.Name = "MailFtpListDialog";
            this.Text = "FTP连接串信息";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lvFtpList, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ctxMailFtp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFtpList;
        private System.Windows.Forms.ColumnHeader chFtpDesc;
        private System.Windows.Forms.ColumnHeader chFtpServer;
        private System.Windows.Forms.ColumnHeader chUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chNo;
        private System.Windows.Forms.ContextMenuStrip ctxMailFtp;
        private System.Windows.Forms.ToolStripMenuItem menuFtpAdd;
        private System.Windows.Forms.ToolStripMenuItem menuFtpEdit;
        private System.Windows.Forms.ToolStripMenuItem menuFtpDel;
    }
}