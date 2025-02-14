
namespace WifiPocketProject.UI
{
    partial class SandBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSendSMS = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.RichTextBox();
            this.tbContactNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbContactNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.statusConnection = new System.Windows.Forms.TextBox();
            this.infoMessages = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgvCellLevel = new System.Windows.Forms.DataGridView();
            this.Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Battery1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Battery2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Battery3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Battery4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Battery5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCellLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.comPorts);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 79);
            this.panel1.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(13, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Port";
            // 
            // comPorts
            // 
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Location = new System.Drawing.Point(57, 21);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(326, 21);
            this.comPorts.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(1, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 184);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnSendSMS);
            this.panel2.Controls.Add(this.tbMessage);
            this.panel2.Controls.Add(this.tbContactNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbContactNo);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 173);
            this.panel2.TabIndex = 69;
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Location = new System.Drawing.Point(883, 95);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(171, 63);
            this.btnSendSMS.TabIndex = 70;
            this.btnSendSMS.Text = "Send SMS";
            this.btnSendSMS.UseVisualStyleBackColor = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click_1);
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMessage.Location = new System.Drawing.Point(103, 60);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(774, 98);
            this.tbMessage.TabIndex = 14;
            this.tbMessage.Text = "34erdfs";
            // 
            // tbContactNo
            // 
            this.tbContactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbContactNo.BackColor = System.Drawing.Color.White;
            this.tbContactNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContactNo.Location = new System.Drawing.Point(103, 15);
            this.tbContactNo.Name = "tbContactNo";
            this.tbContactNo.Size = new System.Drawing.Size(431, 35);
            this.tbContactNo.TabIndex = 68;
            this.tbContactNo.Text = "+923349149169";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Message";
            // 
            // lbContactNo
            // 
            this.lbContactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbContactNo.AutoSize = true;
            this.lbContactNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactNo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbContactNo.Location = new System.Drawing.Point(9, 23);
            this.lbContactNo.Name = "lbContactNo";
            this.lbContactNo.Size = new System.Drawing.Size(88, 21);
            this.lbContactNo.TabIndex = 13;
            this.lbContactNo.Text = "Contact No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label12.Location = new System.Drawing.Point(18, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Cell Level";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.panel9.Controls.Add(this.statusConnection);
            this.panel9.Controls.Add(this.infoMessages);
            this.panel9.Controls.Add(this.groupBox1);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(1, 270);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1080, 523);
            this.panel9.TabIndex = 10;
            // 
            // statusConnection
            // 
            this.statusConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusConnection.Location = new System.Drawing.Point(3, 500);
            this.statusConnection.Name = "statusConnection";
            this.statusConnection.Size = new System.Drawing.Size(116, 20);
            this.statusConnection.TabIndex = 14;
            // 
            // infoMessages
            // 
            this.infoMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoMessages.Location = new System.Drawing.Point(119, 500);
            this.infoMessages.Name = "infoMessages";
            this.infoMessages.Size = new System.Drawing.Size(958, 20);
            this.infoMessages.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.dgvCellLevel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(14, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 455);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Record";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 54);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(756, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // dgvCellLevel
            // 
            this.dgvCellLevel.AllowUserToAddRows = false;
            this.dgvCellLevel.AllowUserToDeleteRows = false;
            this.dgvCellLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCellLevel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCellLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCellLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parameter,
            this.Battery1,
            this.Battery2,
            this.Battery3,
            this.Battery4,
            this.Battery5});
            this.dgvCellLevel.Location = new System.Drawing.Point(3, 15);
            this.dgvCellLevel.Name = "dgvCellLevel";
            this.dgvCellLevel.ReadOnly = true;
            this.dgvCellLevel.RowHeadersWidth = 51;
            this.dgvCellLevel.Size = new System.Drawing.Size(1037, 434);
            this.dgvCellLevel.TabIndex = 0;
            // 
            // Parameter
            // 
            this.Parameter.HeaderText = "Parameter";
            this.Parameter.MinimumWidth = 6;
            this.Parameter.Name = "Parameter";
            this.Parameter.ReadOnly = true;
            this.Parameter.Width = 125;
            // 
            // Battery1
            // 
            this.Battery1.HeaderText = "Battery-1";
            this.Battery1.MinimumWidth = 6;
            this.Battery1.Name = "Battery1";
            this.Battery1.ReadOnly = true;
            this.Battery1.Width = 125;
            // 
            // Battery2
            // 
            this.Battery2.HeaderText = "Battery-2";
            this.Battery2.MinimumWidth = 6;
            this.Battery2.Name = "Battery2";
            this.Battery2.ReadOnly = true;
            this.Battery2.Width = 125;
            // 
            // Battery3
            // 
            this.Battery3.HeaderText = "Battery-3";
            this.Battery3.MinimumWidth = 6;
            this.Battery3.Name = "Battery3";
            this.Battery3.ReadOnly = true;
            this.Battery3.Width = 125;
            // 
            // Battery4
            // 
            this.Battery4.HeaderText = "Battery-4";
            this.Battery4.MinimumWidth = 6;
            this.Battery4.Name = "Battery4";
            this.Battery4.ReadOnly = true;
            this.Battery4.Width = 125;
            // 
            // Battery5
            // 
            this.Battery5.HeaderText = "Battery-5";
            this.Battery5.MinimumWidth = 6;
            this.Battery5.Name = "Battery5";
            this.Battery5.ReadOnly = true;
            this.Battery5.Width = 125;
            // 
            // MessageTemplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1080, 791);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageTemplete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SandBox";
            this.Load += new System.EventHandler(this.MainParamatersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCellLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCellLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Battery1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Battery2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Battery3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Battery4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Battery5;
        private System.Windows.Forms.TextBox statusConnection;
        private System.Windows.Forms.TextBox infoMessages;
        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbContactNo;
        private System.Windows.Forms.TextBox tbContactNo;
        private System.Windows.Forms.RichTextBox tbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSendSMS;
    }
}