namespace FcMailSend
{
    partial class ProductEditDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDisable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMailTitle = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMailContent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvAttachment = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxAttachment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAttachmentAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttachmentEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttachmentDel = new System.Windows.Forms.ToolStripMenuItem();
            this.lvReceiver = new System.Windows.Forms.ListView();
            this.chReceiverNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReceiverEmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReceiverType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxReceiver = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuReceiverAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReceiverEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReceiverDel = new System.Windows.Forms.ToolStripMenuItem();
            this.rbCreditYes = new System.Windows.Forms.RadioButton();
            this.rbCreditNo = new System.Windows.Forms.RadioButton();
            this.gbIsCredit = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numWaitSeconds = new System.Windows.Forms.NumericUpDown();
            this.rbWaitSpecific = new System.Windows.Forms.RadioButton();
            this.rbWaitGlobal = new System.Windows.Forms.RadioButton();
            this.ctxAttachment.SuspendLayout();
            this.ctxReceiver.SuspendLayout();
            this.gbIsCredit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(620, 433);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(701, 433);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(539, 433);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "产品名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "是否禁用:";
            // 
            // cbDisable
            // 
            this.cbDisable.AutoSize = true;
            this.cbDisable.Location = new System.Drawing.Point(667, 12);
            this.cbDisable.Name = "cbDisable";
            this.cbDisable.Size = new System.Drawing.Size(48, 16);
            this.cbDisable.TabIndex = 5;
            this.cbDisable.Text = "禁用";
            this.cbDisable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "邮件主题:";
            // 
            // txtMailTitle
            // 
            this.txtMailTitle.Location = new System.Drawing.Point(77, 44);
            this.txtMailTitle.Name = "txtMailTitle";
            this.txtMailTitle.Size = new System.Drawing.Size(364, 21);
            this.txtMailTitle.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(77, 9);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(188, 21);
            this.txtProductName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "邮件正文:";
            // 
            // txtMailContent
            // 
            this.txtMailContent.AcceptsReturn = true;
            this.txtMailContent.Location = new System.Drawing.Point(76, 272);
            this.txtMailContent.Multiline = true;
            this.txtMailContent.Name = "txtMailContent";
            this.txtMailContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMailContent.Size = new System.Drawing.Size(700, 136);
            this.txtMailContent.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "附件:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "收件人:";
            // 
            // lvAttachment
            // 
            this.lvAttachment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lvAttachment.ContextMenuStrip = this.ctxAttachment;
            this.lvAttachment.FullRowSelect = true;
            this.lvAttachment.GridLines = true;
            this.lvAttachment.Location = new System.Drawing.Point(77, 189);
            this.lvAttachment.MultiSelect = false;
            this.lvAttachment.Name = "lvAttachment";
            this.lvAttachment.Size = new System.Drawing.Size(699, 77);
            this.lvAttachment.TabIndex = 13;
            this.lvAttachment.UseCompatibleStateImageBehavior = false;
            this.lvAttachment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No";
            this.columnHeader3.Width = 39;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "类型";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "路径";
            this.columnHeader2.Width = 573;
            // 
            // ctxAttachment
            // 
            this.ctxAttachment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAttachmentAdd,
            this.menuAttachmentEdit,
            this.menuAttachmentDel});
            this.ctxAttachment.Name = "ctxAttachment";
            this.ctxAttachment.Size = new System.Drawing.Size(137, 70);
            this.ctxAttachment.Opening += new System.ComponentModel.CancelEventHandler(this.ctxAttachment_Opening);
            // 
            // menuAttachmentAdd
            // 
            this.menuAttachmentAdd.Name = "menuAttachmentAdd";
            this.menuAttachmentAdd.Size = new System.Drawing.Size(136, 22);
            this.menuAttachmentAdd.Text = "增加附件...";
            this.menuAttachmentAdd.Click += new System.EventHandler(this.menuAttachmentAdd_Click);
            // 
            // menuAttachmentEdit
            // 
            this.menuAttachmentEdit.Name = "menuAttachmentEdit";
            this.menuAttachmentEdit.Size = new System.Drawing.Size(136, 22);
            this.menuAttachmentEdit.Text = "修改附件...";
            this.menuAttachmentEdit.Click += new System.EventHandler(this.menuAttachmentEdit_Click);
            // 
            // menuAttachmentDel
            // 
            this.menuAttachmentDel.Name = "menuAttachmentDel";
            this.menuAttachmentDel.Size = new System.Drawing.Size(136, 22);
            this.menuAttachmentDel.Text = "删除附件";
            this.menuAttachmentDel.Click += new System.EventHandler(this.menuAttachmentDel_Click);
            // 
            // lvReceiver
            // 
            this.lvReceiver.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chReceiverNo,
            this.chReceiverEmailAddress,
            this.chReceiverType});
            this.lvReceiver.ContextMenuStrip = this.ctxReceiver;
            this.lvReceiver.FullRowSelect = true;
            this.lvReceiver.GridLines = true;
            this.lvReceiver.Location = new System.Drawing.Point(77, 81);
            this.lvReceiver.MultiSelect = false;
            this.lvReceiver.Name = "lvReceiver";
            this.lvReceiver.Size = new System.Drawing.Size(499, 92);
            this.lvReceiver.TabIndex = 14;
            this.lvReceiver.UseCompatibleStateImageBehavior = false;
            this.lvReceiver.View = System.Windows.Forms.View.Details;
            // 
            // chReceiverNo
            // 
            this.chReceiverNo.Text = "No";
            this.chReceiverNo.Width = 40;
            // 
            // chReceiverEmailAddress
            // 
            this.chReceiverEmailAddress.Text = "收件人地址";
            this.chReceiverEmailAddress.Width = 368;
            // 
            // chReceiverType
            // 
            this.chReceiverType.Text = "收件人类型";
            this.chReceiverType.Width = 72;
            // 
            // ctxReceiver
            // 
            this.ctxReceiver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReceiverAdd,
            this.menuReceiverEdit,
            this.menuReceiverDel});
            this.ctxReceiver.Name = "ctxReceiver";
            this.ctxReceiver.Size = new System.Drawing.Size(149, 70);
            this.ctxReceiver.Opening += new System.ComponentModel.CancelEventHandler(this.ctxReceiver_Opening);
            // 
            // menuReceiverAdd
            // 
            this.menuReceiverAdd.Name = "menuReceiverAdd";
            this.menuReceiverAdd.Size = new System.Drawing.Size(148, 22);
            this.menuReceiverAdd.Text = "新增收件人...";
            this.menuReceiverAdd.Click += new System.EventHandler(this.menuReceiverAdd_Click);
            // 
            // menuReceiverEdit
            // 
            this.menuReceiverEdit.Name = "menuReceiverEdit";
            this.menuReceiverEdit.Size = new System.Drawing.Size(148, 22);
            this.menuReceiverEdit.Text = "编辑收件人...";
            this.menuReceiverEdit.Click += new System.EventHandler(this.menuReceiverEdit_Click);
            // 
            // menuReceiverDel
            // 
            this.menuReceiverDel.Name = "menuReceiverDel";
            this.menuReceiverDel.Size = new System.Drawing.Size(148, 22);
            this.menuReceiverDel.Text = "删除收件人...";
            this.menuReceiverDel.Click += new System.EventHandler(this.menuReceiverDel_Click);
            // 
            // rbCreditYes
            // 
            this.rbCreditYes.AutoSize = true;
            this.rbCreditYes.Location = new System.Drawing.Point(69, 20);
            this.rbCreditYes.Name = "rbCreditYes";
            this.rbCreditYes.Size = new System.Drawing.Size(35, 16);
            this.rbCreditYes.TabIndex = 16;
            this.rbCreditYes.Text = "是";
            this.rbCreditYes.UseVisualStyleBackColor = true;
            // 
            // rbCreditNo
            // 
            this.rbCreditNo.AutoSize = true;
            this.rbCreditNo.Checked = true;
            this.rbCreditNo.Location = new System.Drawing.Point(18, 20);
            this.rbCreditNo.Name = "rbCreditNo";
            this.rbCreditNo.Size = new System.Drawing.Size(35, 16);
            this.rbCreditNo.TabIndex = 17;
            this.rbCreditNo.TabStop = true;
            this.rbCreditNo.Text = "否";
            this.rbCreditNo.UseVisualStyleBackColor = true;
            // 
            // gbIsCredit
            // 
            this.gbIsCredit.Controls.Add(this.rbCreditYes);
            this.gbIsCredit.Controls.Add(this.rbCreditNo);
            this.gbIsCredit.Location = new System.Drawing.Point(461, 9);
            this.gbIsCredit.Name = "gbIsCredit";
            this.gbIsCredit.Size = new System.Drawing.Size(115, 50);
            this.gbIsCredit.TabIndex = 18;
            this.gbIsCredit.TabStop = false;
            this.gbIsCredit.Text = "是否信用批次";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numWaitSeconds);
            this.groupBox1.Controls.Add(this.rbWaitSpecific);
            this.groupBox1.Controls.Add(this.rbWaitGlobal);
            this.groupBox1.Location = new System.Drawing.Point(604, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 92);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邮件发送前等待时间(秒):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(9, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "*某些邮箱有发送频率限制\r\n需设置延迟防止退信";
            // 
            // numWaitSeconds
            // 
            this.numWaitSeconds.Location = new System.Drawing.Point(76, 38);
            this.numWaitSeconds.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numWaitSeconds.Name = "numWaitSeconds";
            this.numWaitSeconds.Size = new System.Drawing.Size(45, 21);
            this.numWaitSeconds.TabIndex = 2;
            // 
            // rbWaitSpecific
            // 
            this.rbWaitSpecific.AutoSize = true;
            this.rbWaitSpecific.Location = new System.Drawing.Point(11, 43);
            this.rbWaitSpecific.Name = "rbWaitSpecific";
            this.rbWaitSpecific.Size = new System.Drawing.Size(59, 16);
            this.rbWaitSpecific.TabIndex = 1;
            this.rbWaitSpecific.TabStop = true;
            this.rbWaitSpecific.Text = "自定义";
            this.rbWaitSpecific.UseVisualStyleBackColor = true;
            this.rbWaitSpecific.CheckedChanged += new System.EventHandler(this.rbWaitType_CheckedChanged);
            // 
            // rbWaitGlobal
            // 
            this.rbWaitGlobal.AutoSize = true;
            this.rbWaitGlobal.Location = new System.Drawing.Point(11, 20);
            this.rbWaitGlobal.Name = "rbWaitGlobal";
            this.rbWaitGlobal.Size = new System.Drawing.Size(95, 16);
            this.rbWaitGlobal.TabIndex = 0;
            this.rbWaitGlobal.TabStop = true;
            this.rbWaitGlobal.Text = "采用全局设置";
            this.rbWaitGlobal.UseVisualStyleBackColor = true;
            this.rbWaitGlobal.CheckedChanged += new System.EventHandler(this.rbWaitType_CheckedChanged);
            // 
            // ProductEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbIsCredit);
            this.Controls.Add(this.lvReceiver);
            this.Controls.Add(this.lvAttachment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMailContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtMailTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDisable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductEditDialog";
            this.Text = "xx产品发送";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbDisable, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtMailTitle, 0);
            this.Controls.SetChildIndex(this.txtProductName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtMailContent, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lvAttachment, 0);
            this.Controls.SetChildIndex(this.lvReceiver, 0);
            this.Controls.SetChildIndex(this.gbIsCredit, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.ctxAttachment.ResumeLayout(false);
            this.ctxReceiver.ResumeLayout(false);
            this.gbIsCredit.ResumeLayout(false);
            this.gbIsCredit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDisable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMailTitle;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMailContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvAttachment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvReceiver;
        private System.Windows.Forms.ColumnHeader chReceiverEmailAddress;
        private System.Windows.Forms.ColumnHeader chReceiverType;
        private System.Windows.Forms.ColumnHeader chReceiverNo;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip ctxReceiver;
        private System.Windows.Forms.ToolStripMenuItem menuReceiverAdd;
        private System.Windows.Forms.ToolStripMenuItem menuReceiverEdit;
        private System.Windows.Forms.ToolStripMenuItem menuReceiverDel;
        private System.Windows.Forms.ContextMenuStrip ctxAttachment;
        private System.Windows.Forms.ToolStripMenuItem menuAttachmentAdd;
        private System.Windows.Forms.ToolStripMenuItem menuAttachmentEdit;
        private System.Windows.Forms.ToolStripMenuItem menuAttachmentDel;
        private System.Windows.Forms.RadioButton rbCreditYes;
        private System.Windows.Forms.RadioButton rbCreditNo;
        private System.Windows.Forms.GroupBox gbIsCredit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numWaitSeconds;
        private System.Windows.Forms.RadioButton rbWaitSpecific;
        private System.Windows.Forms.RadioButton rbWaitGlobal;
        private System.Windows.Forms.Label label7;
    }
}