namespace FcMailSend
{
    partial class ProductReceiverEditDialog
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
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdTypeBcc = new System.Windows.Forms.RadioButton();
            this.rdTypeCc = new System.Windows.Forms.RadioButton();
            this.rdTypeTo = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(163, 89);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 89);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(82, 89);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(85, 3);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(189, 21);
            this.txtEmailAddress.TabIndex = 2;
            this.txtEmailAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailAddress_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdTypeBcc);
            this.panel1.Controls.Add(this.rdTypeCc);
            this.panel1.Controls.Add(this.rdTypeTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(85, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 29);
            this.panel1.TabIndex = 3;
            // 
            // rdTypeBcc
            // 
            this.rdTypeBcc.AutoSize = true;
            this.rdTypeBcc.Location = new System.Drawing.Point(121, 7);
            this.rdTypeBcc.Name = "rdTypeBcc";
            this.rdTypeBcc.Size = new System.Drawing.Size(47, 16);
            this.rdTypeBcc.TabIndex = 2;
            this.rdTypeBcc.TabStop = true;
            this.rdTypeBcc.Text = "密送";
            this.rdTypeBcc.UseVisualStyleBackColor = true;
            // 
            // rdTypeCc
            // 
            this.rdTypeCc.AutoSize = true;
            this.rdTypeCc.Location = new System.Drawing.Point(68, 7);
            this.rdTypeCc.Name = "rdTypeCc";
            this.rdTypeCc.Size = new System.Drawing.Size(47, 16);
            this.rdTypeCc.TabIndex = 1;
            this.rdTypeCc.TabStop = true;
            this.rdTypeCc.Text = "抄送";
            this.rdTypeCc.UseVisualStyleBackColor = true;
            // 
            // rdTypeTo
            // 
            this.rdTypeTo.AutoSize = true;
            this.rdTypeTo.Location = new System.Drawing.Point(3, 7);
            this.rdTypeTo.Name = "rdTypeTo";
            this.rdTypeTo.Size = new System.Drawing.Size(59, 16);
            this.rdTypeTo.TabIndex = 0;
            this.rdTypeTo.TabStop = true;
            this.rdTypeTo.Text = "收件人";
            this.rdTypeTo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtEmailAddress, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 62);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "收件人地址:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "收件人类型:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ProductReceiverEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 121);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ProductReceiverEditDialog";
            this.Text = "ProductMailReceiverEditDialog";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdTypeBcc;
        private System.Windows.Forms.RadioButton rdTypeCc;
        private System.Windows.Forms.RadioButton rdTypeTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}