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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnSendAll = new System.Windows.Forms.Button();
            this.bwSendMail = new System.ComponentModel.BackgroundWorker();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditProductDel = new System.Windows.Forms.ToolStripMenuItem();
            this.lvProductList = new FcMailSend.DoubleBufferListView();
            this.PNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PFileOK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIsSend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(705, 322);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(87, 25);
            this.btnSendAll.TabIndex = 1;
            this.btnSendAll.Text = "发送所有邮件";
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
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(14, 322);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(415, 95);
            this.tbLog.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "发送未发邮件";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(833, 25);
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
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpSearch,
            this.menuHelpLog,
            this.toolStripSeparator5,
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 21);
            this.menuHelp.Text = "帮助(&H)";
            // 
            // menuHelpSearch
            // 
            this.menuHelpSearch.Name = "menuHelpSearch";
            this.menuHelpSearch.Size = new System.Drawing.Size(139, 22);
            this.menuHelpSearch.Text = "搜索产品(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(136, 6);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(139, 22);
            this.menuHelpAbout.Text = "关于(&A)";
            // 
            // menuHelpLog
            // 
            this.menuHelpLog.Name = "menuHelpLog";
            this.menuHelpLog.Size = new System.Drawing.Size(139, 22);
            this.menuHelpLog.Text = "日志(&L)";
            // 
            // menuEditProductDel
            // 
            this.menuEditProductDel.Name = "menuEditProductDel";
            this.menuEditProductDel.Size = new System.Drawing.Size(169, 22);
            this.menuEditProductDel.Text = "删除产品发送...";
            // 
            // lvProductList
            // 
            this.lvProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PNo,
            this.PName,
            this.PFileOK,
            this.PIsSend,
            this.PStatus});
            this.lvProductList.FullRowSelect = true;
            this.lvProductList.GridLines = true;
            this.lvProductList.Location = new System.Drawing.Point(14, 27);
            this.lvProductList.MultiSelect = false;
            this.lvProductList.Name = "lvProductList";
            this.lvProductList.Size = new System.Drawing.Size(790, 268);
            this.lvProductList.TabIndex = 0;
            this.lvProductList.UseCompatibleStateImageBehavior = false;
            this.lvProductList.View = System.Windows.Forms.View.Details;
            // 
            // PNo
            // 
            this.PNo.Text = "No";
            this.PNo.Width = 45;
            // 
            // PName
            // 
            this.PName.Text = "产品名称";
            this.PName.Width = 210;
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
            this.PStatus.Width = 240;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(461, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送日期";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "本日";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "其他";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLog);
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
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuEditMailSender;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuEditProductAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEditMailFtp;
        private System.Windows.Forms.ToolStripMenuItem menuEditProductEdit;
        private System.Windows.Forms.ToolStripMenuItem menuHelpLog;
        private System.Windows.Forms.ToolStripMenuItem menuEditProductDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

