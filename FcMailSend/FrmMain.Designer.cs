namespace FcMailSend
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnSendAll = new System.Windows.Forms.Button();
            this.bwSendMail = new System.ComponentModel.BackgroundWorker();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditMailSender = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditMailFtp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditProductAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditProductEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditProductDel = new System.Windows.Forms.ToolStripMenuItem();
            this.查看VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewSendLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rbDateOther = new System.Windows.Forms.RadioButton();
            this.rbDateToday = new System.Windows.Forms.RadioButton();
            this.cbSendMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProductCheckAll = new System.Windows.Forms.Button();
            this.btnProductCheckReverse = new System.Windows.Forms.Button();
            this.gbProductSel = new System.Windows.Forms.GroupBox();
            this.lvProductList = new FcMailSend.DoubleBufferListView();
            this.PNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIsEnable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PFileOK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIsSend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.lbIsAllSendOK = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbProductSel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendAll
            // 
            this.btnSendAll.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendAll.Location = new System.Drawing.Point(622, 387);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(127, 27);
            this.btnSendAll.TabIndex = 1;
            this.btnSendAll.Text = "发送邮件";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // bwSendMail
            // 
            this.bwSendMail.WorkerReportsProgress = true;
            this.bwSendMail.WorkerSupportsCancellation = true;
            this.bwSendMail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSendMail_DoWork);
            this.bwSendMail.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwSendMail_ProgressChanged);
            this.bwSendMail.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSendMail_RunWorkerCompleted);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(14, 322);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(374, 95);
            this.txtLog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "系统日志:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.查看VToolStripMenuItem,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(763, 25);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFilePrint,
            this.toolStripSeparator2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(58, 21);
            this.menuFile.Text = "文件(&F)";
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Image = ((System.Drawing.Image)(resources.GetObject("menuFilePrint.Image")));
            this.menuFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFilePrint.Name = "menuFilePrint";
            this.menuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuFilePrint.Size = new System.Drawing.Size(144, 22);
            this.menuFilePrint.Text = "打印";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(144, 22);
            this.menuFileExit.Text = "关闭(&X)";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditMailSender,
            this.menuEditMailFtp,
            this.toolStripMenuItem2,
            this.menuEditProductAdd,
            this.menuEditProductEdit,
            this.menuEditProductDel});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(59, 21);
            this.menuEdit.Text = "编辑(&E)";
            this.menuEdit.DropDownOpening += new System.EventHandler(this.menuEdit_DropDownOpening);
            // 
            // menuEditMailSender
            // 
            this.menuEditMailSender.Name = "menuEditMailSender";
            this.menuEditMailSender.Size = new System.Drawing.Size(169, 22);
            this.menuEditMailSender.Text = "修改发件人信息...";
            this.menuEditMailSender.Click += new System.EventHandler(this.menuEditMailSender_Click);
            // 
            // menuEditMailFtp
            // 
            this.menuEditMailFtp.Name = "menuEditMailFtp";
            this.menuEditMailFtp.Size = new System.Drawing.Size(169, 22);
            this.menuEditMailFtp.Text = "FTP连接设置...";
            this.menuEditMailFtp.Click += new System.EventHandler(this.menuEditMailFtp_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 6);
            // 
            // menuEditProductAdd
            // 
            this.menuEditProductAdd.Name = "menuEditProductAdd";
            this.menuEditProductAdd.Size = new System.Drawing.Size(169, 22);
            this.menuEditProductAdd.Text = "新增产品发送...";
            this.menuEditProductAdd.Click += new System.EventHandler(this.menuEditProductAdd_Click);
            // 
            // menuEditProductEdit
            // 
            this.menuEditProductEdit.Name = "menuEditProductEdit";
            this.menuEditProductEdit.Size = new System.Drawing.Size(169, 22);
            this.menuEditProductEdit.Text = "修改产品发送...";
            this.menuEditProductEdit.Click += new System.EventHandler(this.menuEditProductEdit_Click);
            // 
            // menuEditProductDel
            // 
            this.menuEditProductDel.Name = "menuEditProductDel";
            this.menuEditProductDel.Size = new System.Drawing.Size(169, 22);
            this.menuEditProductDel.Text = "删除产品发送...";
            this.menuEditProductDel.Click += new System.EventHandler(this.menuEditProductDel_Click);
            // 
            // 查看VToolStripMenuItem
            // 
            this.查看VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewSearch,
            this.menuViewSendLog});
            this.查看VToolStripMenuItem.Name = "查看VToolStripMenuItem";
            this.查看VToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.查看VToolStripMenuItem.Text = "查看(&V)";
            // 
            // menuViewSearch
            // 
            this.menuViewSearch.Name = "menuViewSearch";
            this.menuViewSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuViewSearch.Size = new System.Drawing.Size(181, 22);
            this.menuViewSearch.Text = "搜索产品(&F)";
            // 
            // menuViewSendLog
            // 
            this.menuViewSendLog.Name = "menuViewSendLog";
            this.menuViewSendLog.Size = new System.Drawing.Size(181, 22);
            this.menuViewSendLog.Text = "产品发送日志(&L)";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 21);
            this.menuHelp.Text = "帮助(&H)";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.menuHelpAbout.Text = "关于(&A)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.rbDateOther);
            this.groupBox1.Controls.Add(this.rbDateToday);
            this.groupBox1.Location = new System.Drawing.Point(412, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送日期";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(63, 33);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 21);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // rbDateOther
            // 
            this.rbDateOther.AutoSize = true;
            this.rbDateOther.Location = new System.Drawing.Point(15, 37);
            this.rbDateOther.Name = "rbDateOther";
            this.rbDateOther.Size = new System.Drawing.Size(47, 16);
            this.rbDateOther.TabIndex = 1;
            this.rbDateOther.Text = "其他";
            this.rbDateOther.UseVisualStyleBackColor = true;
            // 
            // rbDateToday
            // 
            this.rbDateToday.AutoSize = true;
            this.rbDateToday.Location = new System.Drawing.Point(15, 15);
            this.rbDateToday.Name = "rbDateToday";
            this.rbDateToday.Size = new System.Drawing.Size(47, 16);
            this.rbDateToday.TabIndex = 0;
            this.rbDateToday.Text = "本日";
            this.rbDateToday.UseVisualStyleBackColor = true;
            this.rbDateToday.CheckedChanged += new System.EventHandler(this.rbDate_CheckedChanged);
            // 
            // cbSendMode
            // 
            this.cbSendMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSendMode.FormattingEnabled = true;
            this.cbSendMode.Location = new System.Drawing.Point(475, 319);
            this.cbSendMode.Name = "cbSendMode";
            this.cbSendMode.Size = new System.Drawing.Size(131, 20);
            this.cbSendMode.TabIndex = 8;
            this.cbSendMode.SelectedIndexChanged += new System.EventHandler(this.cbSendMode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "发送模式:";
            // 
            // btnProductCheckAll
            // 
            this.btnProductCheckAll.Location = new System.Drawing.Point(7, 15);
            this.btnProductCheckAll.Name = "btnProductCheckAll";
            this.btnProductCheckAll.Size = new System.Drawing.Size(54, 23);
            this.btnProductCheckAll.TabIndex = 10;
            this.btnProductCheckAll.Text = "全选";
            this.btnProductCheckAll.UseVisualStyleBackColor = true;
            this.btnProductCheckAll.Click += new System.EventHandler(this.btnProductCheckAll_Click);
            // 
            // btnProductCheckReverse
            // 
            this.btnProductCheckReverse.Location = new System.Drawing.Point(67, 15);
            this.btnProductCheckReverse.Name = "btnProductCheckReverse";
            this.btnProductCheckReverse.Size = new System.Drawing.Size(54, 23);
            this.btnProductCheckReverse.TabIndex = 12;
            this.btnProductCheckReverse.Text = "反选";
            this.btnProductCheckReverse.UseVisualStyleBackColor = true;
            this.btnProductCheckReverse.Click += new System.EventHandler(this.btnProductCheckReverse_Click);
            // 
            // gbProductSel
            // 
            this.gbProductSel.Controls.Add(this.btnProductCheckAll);
            this.gbProductSel.Controls.Add(this.btnProductCheckReverse);
            this.gbProductSel.Location = new System.Drawing.Point(622, 307);
            this.gbProductSel.Name = "gbProductSel";
            this.gbProductSel.Size = new System.Drawing.Size(127, 44);
            this.gbProductSel.TabIndex = 13;
            this.gbProductSel.TabStop = false;
            this.gbProductSel.Text = "产品勾选";
            // 
            // lvProductList
            // 
            this.lvProductList.CheckBoxes = true;
            this.lvProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PNo,
            this.PName,
            this.PIsEnable,
            this.PFileOK,
            this.PIsSend,
            this.PStatus});
            this.lvProductList.FullRowSelect = true;
            this.lvProductList.GridLines = true;
            this.lvProductList.Location = new System.Drawing.Point(14, 27);
            this.lvProductList.MultiSelect = false;
            this.lvProductList.Name = "lvProductList";
            this.lvProductList.Size = new System.Drawing.Size(735, 268);
            this.lvProductList.TabIndex = 0;
            this.lvProductList.UseCompatibleStateImageBehavior = false;
            this.lvProductList.View = System.Windows.Forms.View.Details;
            this.lvProductList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvProductList_MouseMove);
            // 
            // PNo
            // 
            this.PNo.Text = "No";
            this.PNo.Width = 45;
            // 
            // PName
            // 
            this.PName.Text = "产品名称";
            this.PName.Width = 127;
            // 
            // PIsEnable
            // 
            this.PIsEnable.Text = "是否启用";
            this.PIsEnable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PFileOK
            // 
            this.PFileOK.Text = "附件就绪";
            this.PFileOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PFileOK.Width = 64;
            // 
            // PIsSend
            // 
            this.PIsSend.Text = "发送完成";
            this.PIsSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PStatus
            // 
            this.PStatus.Text = "状态说明";
            this.PStatus.Width = 344;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "完成:";
            // 
            // lbIsAllSendOK
            // 
            this.lbIsAllSendOK.AutoSize = true;
            this.lbIsAllSendOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbIsAllSendOK.Location = new System.Drawing.Point(668, 361);
            this.lbIsAllSendOK.Name = "lbIsAllSendOK";
            this.lbIsAllSendOK.Size = new System.Drawing.Size(35, 16);
            this.lbIsAllSendOK.TabIndex = 15;
            this.lbIsAllSendOK.Text = "N/A";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 50000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 429);
            this.Controls.Add(this.lbIsAllSendOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbProductSel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSendMode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSendAll);
            this.Controls.Add(this.lvProductList);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分仓数据邮件发送";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbProductSel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferListView lvProductList;
        private System.Windows.Forms.ColumnHeader PNo;
        private System.Windows.Forms.ColumnHeader PName;
        private System.Windows.Forms.ColumnHeader PFileOK;
        private System.Windows.Forms.ColumnHeader PIsSend;
        private System.Windows.Forms.ColumnHeader PStatus;
        private System.Windows.Forms.Button btnSendAll;
        private System.ComponentModel.BackgroundWorker bwSendMail;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuEditMailSender;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuEditProductAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEditMailFtp;
        private System.Windows.Forms.ToolStripMenuItem menuEditProductEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditProductDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rbDateOther;
        private System.Windows.Forms.RadioButton rbDateToday;
        private System.Windows.Forms.ToolStripMenuItem 查看VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuViewSearch;
        private System.Windows.Forms.ColumnHeader PIsEnable;
        private System.Windows.Forms.ToolStripMenuItem menuViewSendLog;
        private System.Windows.Forms.ComboBox cbSendMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProductCheckAll;
        private System.Windows.Forms.Button btnProductCheckReverse;
        private System.Windows.Forms.GroupBox gbProductSel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIsAllSendOK;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

