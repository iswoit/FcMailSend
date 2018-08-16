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
            this.lvReceiver = new System.Windows.Forms.ListView();
            this.chReceiverNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReceiverEmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReceiverType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxReceiver = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuReceiverAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReceiverEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReceiverDel = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxReceiver.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(621, 309);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(702, 309);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(540, 309);
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
            this.label2.Location = new System.Drawing.Point(271, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "是否禁用:";
            // 
            // cbDisable
            // 
            this.cbDisable.AutoSize = true;
            this.cbDisable.Location = new System.Drawing.Point(336, 12);
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
            this.txtMailTitle.Size = new System.Drawing.Size(307, 21);
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
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "邮件正文:";
            // 
            // txtMailContent
            // 
            this.txtMailContent.AcceptsReturn = true;
            this.txtMailContent.Location = new System.Drawing.Point(77, 174);
            this.txtMailContent.Multiline = true;
            this.txtMailContent.Name = "txtMailContent";
            this.txtMailContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMailContent.Size = new System.Drawing.Size(700, 127);
            this.txtMailContent.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "附件:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 47);
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
            this.lvAttachment.GridLines = true;
            this.lvAttachment.Location = new System.Drawing.Point(77, 76);
            this.lvAttachment.Name = "lvAttachment";
            this.lvAttachment.Size = new System.Drawing.Size(307, 92);
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
            this.columnHeader2.Width = 169;
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
            this.lvReceiver.Location = new System.Drawing.Point(452, 44);
            this.lvReceiver.MultiSelect = false;
            this.lvReceiver.Name = "lvReceiver";
            this.lvReceiver.Size = new System.Drawing.Size(325, 124);
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
            this.chReceiverEmailAddress.Width = 188;
            // 
            // chReceiverType
            // 
            this.chReceiverType.Text = "收件人类型";
            this.chReceiverType.Width = 77;
            // 
            // ctxReceiver
            // 
            this.ctxReceiver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReceiverAdd,
            this.menuReceiverEdit,
            this.menuReceiverDel});
            this.ctxReceiver.Name = "ctxReceiver";
            this.ctxReceiver.Size = new System.Drawing.Size(146, 70);
            this.ctxReceiver.Opening += new System.ComponentModel.CancelEventHandler(this.ctxReceiver_Opening);
            // 
            // menuReceiverAdd
            // 
            this.menuReceiverAdd.Name = "menuReceiverAdd";
            this.menuReceiverAdd.Size = new System.Drawing.Size(145, 22);
            this.menuReceiverAdd.Text = "新增收件人...";
            this.menuReceiverAdd.Click += new System.EventHandler(this.menuReceiverAdd_Click);
            // 
            // menuReceiverEdit
            // 
            this.menuReceiverEdit.Name = "menuReceiverEdit";
            this.menuReceiverEdit.Size = new System.Drawing.Size(145, 22);
            this.menuReceiverEdit.Text = "编辑收件人...";
            this.menuReceiverEdit.Click += new System.EventHandler(this.menuReceiverEdit_Click);
            // 
            // menuReceiverDel
            // 
            this.menuReceiverDel.Name = "menuReceiverDel";
            this.menuReceiverDel.Size = new System.Drawing.Size(145, 22);
            this.menuReceiverDel.Text = "删除收件人...";
            this.menuReceiverDel.Click += new System.EventHandler(this.menuReceiverDel_Click);
            // 
            // ProductEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 344);
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
            this.ctxReceiver.ResumeLayout(false);
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
    }
}