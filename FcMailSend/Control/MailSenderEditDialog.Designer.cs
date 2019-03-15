namespace FcMailSend
{
    partial class MailSenderEditDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.cbEnableSSL = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTailContent = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdPrioHigh = new System.Windows.Forms.RadioButton();
            this.rdPrioLow = new System.Windows.Forms.RadioButton();
            this.rdPrioNormal = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSendInterval = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(260, 405);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(341, 405);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(179, 405);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP服务器:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPort, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbEnableSSL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtTailContent, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDisplayName, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.numTimeout, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtSendInterval, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 377);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 152);
            this.label9.TabIndex = 12;
            this.label9.Text = "邮件末尾附文:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "发件人地址:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "是否启用SSL:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHost
            // 
            this.txtHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHost.Location = new System.Drawing.Point(95, 3);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(306, 21);
            this.txtHost.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPort.Location = new System.Drawing.Point(95, 28);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(78, 21);
            this.txtPort.TabIndex = 4;
            // 
            // cbEnableSSL
            // 
            this.cbEnableSSL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEnableSSL.AutoSize = true;
            this.cbEnableSSL.Location = new System.Drawing.Point(95, 53);
            this.cbEnableSSL.Name = "cbEnableSSL";
            this.cbEnableSSL.Size = new System.Drawing.Size(48, 19);
            this.cbEnableSSL.TabIndex = 5;
            this.cbEnableSSL.Text = "启用";
            this.cbEnableSSL.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "发件人密码:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "超时时间(秒):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "发件人描述:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "优先级:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTailContent
            // 
            this.txtTailContent.AcceptsReturn = true;
            this.txtTailContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTailContent.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTailContent.Location = new System.Drawing.Point(95, 203);
            this.txtTailContent.Multiline = true;
            this.txtTailContent.Name = "txtTailContent";
            this.txtTailContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTailContent.Size = new System.Drawing.Size(306, 146);
            this.txtTailContent.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAddress.Location = new System.Drawing.Point(95, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(306, 21);
            this.txtAddress.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassword.Location = new System.Drawing.Point(95, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(306, 21);
            this.txtPassword.TabIndex = 15;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDisplayName.Location = new System.Drawing.Point(95, 153);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(306, 21);
            this.txtDisplayName.TabIndex = 16;
            // 
            // numTimeout
            // 
            this.numTimeout.Location = new System.Drawing.Point(95, 128);
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(78, 21);
            this.numTimeout.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdPrioHigh);
            this.panel1.Controls.Add(this.rdPrioLow);
            this.panel1.Controls.Add(this.rdPrioNormal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(95, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 19);
            this.panel1.TabIndex = 19;
            // 
            // rdPrioHigh
            // 
            this.rdPrioHigh.AutoSize = true;
            this.rdPrioHigh.Location = new System.Drawing.Point(131, 1);
            this.rdPrioHigh.Name = "rdPrioHigh";
            this.rdPrioHigh.Size = new System.Drawing.Size(35, 16);
            this.rdPrioHigh.TabIndex = 2;
            this.rdPrioHigh.TabStop = true;
            this.rdPrioHigh.Text = "高";
            this.rdPrioHigh.UseVisualStyleBackColor = true;
            // 
            // rdPrioLow
            // 
            this.rdPrioLow.AutoSize = true;
            this.rdPrioLow.Location = new System.Drawing.Point(72, 1);
            this.rdPrioLow.Name = "rdPrioLow";
            this.rdPrioLow.Size = new System.Drawing.Size(35, 16);
            this.rdPrioLow.TabIndex = 1;
            this.rdPrioLow.TabStop = true;
            this.rdPrioLow.Text = "低";
            this.rdPrioLow.UseVisualStyleBackColor = true;
            // 
            // rdPrioNormal
            // 
            this.rdPrioNormal.AutoSize = true;
            this.rdPrioNormal.Location = new System.Drawing.Point(3, 1);
            this.rdPrioNormal.Name = "rdPrioNormal";
            this.rdPrioNormal.Size = new System.Drawing.Size(47, 16);
            this.rdPrioNormal.TabIndex = 0;
            this.rdPrioNormal.TabStop = true;
            this.rdPrioNormal.Text = "普通";
            this.rdPrioNormal.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "发送间隔(秒):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSendInterval
            // 
            this.txtSendInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSendInterval.Location = new System.Drawing.Point(95, 355);
            this.txtSendInterval.Name = "txtSendInterval";
            this.txtSendInterval.Size = new System.Drawing.Size(78, 21);
            this.txtSendInterval.TabIndex = 21;
            // 
            // MailSenderEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 439);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MailSenderEditDialog";
            this.Text = "发件人信息";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.CheckBox cbEnableSSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTailContent;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.NumericUpDown numTimeout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdPrioNormal;
        private System.Windows.Forms.RadioButton rdPrioHigh;
        private System.Windows.Forms.RadioButton rdPrioLow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSendInterval;
    }
}