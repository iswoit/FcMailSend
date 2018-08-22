namespace FcMailSend
{
    partial class ProductAttachmentEditDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFtp = new System.Windows.Forms.ComboBox();
            this.rdFtp = new System.Windows.Forms.RadioButton();
            this.rdPath = new System.Windows.Forms.RadioButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(185, 130);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 130);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(104, 130);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "附件类型:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFtp);
            this.panel1.Controls.Add(this.rdFtp);
            this.panel1.Controls.Add(this.rdPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(74, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 66);
            this.panel1.TabIndex = 4;
            // 
            // cbFtp
            // 
            this.cbFtp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFtp.FormattingEnabled = true;
            this.cbFtp.Location = new System.Drawing.Point(59, 36);
            this.cbFtp.Name = "cbFtp";
            this.cbFtp.Size = new System.Drawing.Size(112, 20);
            this.cbFtp.TabIndex = 8;
            // 
            // rdFtp
            // 
            this.rdFtp.AutoSize = true;
            this.rdFtp.Location = new System.Drawing.Point(12, 37);
            this.rdFtp.Name = "rdFtp";
            this.rdFtp.Size = new System.Drawing.Size(41, 16);
            this.rdFtp.TabIndex = 1;
            this.rdFtp.TabStop = true;
            this.rdFtp.Text = "FTP";
            this.rdFtp.UseVisualStyleBackColor = true;
            this.rdFtp.CheckedChanged += new System.EventHandler(this.rdType_CheckedChanged);
            // 
            // rdPath
            // 
            this.rdPath.AutoSize = true;
            this.rdPath.Location = new System.Drawing.Point(12, 8);
            this.rdPath.Name = "rdPath";
            this.rdPath.Size = new System.Drawing.Size(71, 16);
            this.rdPath.TabIndex = 0;
            this.rdPath.TabStop = true;
            this.rdPath.Text = "磁盘路径";
            this.rdPath.UseVisualStyleBackColor = true;
            this.rdPath.CheckedChanged += new System.EventHandler(this.rdType_CheckedChanged);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(74, 75);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(224, 21);
            this.txtPath.TabIndex = 5;
            this.txtPath.Validating += new System.ComponentModel.CancelEventHandler(this.txtPath_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "路径:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.58055F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.41946F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPath, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 100);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ProductAttachmentEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 162);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductAttachmentEditDialog";
            this.Text = "ProductAttachmentEditDialog";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdFtp;
        private System.Windows.Forms.RadioButton rdPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFtp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}