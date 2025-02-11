
namespace WifiPocketProject.UI
{
    partial class SettingsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ll3 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.lblConnectedPort = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblComPort = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.btnTestDevice = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 64);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(68, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Module Settings";
            // 
            // bodyPanel
            // 
            this.bodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.bodyPanel.Controls.Add(this.panel4);
            this.bodyPanel.Controls.Add(this.panel3);
            this.bodyPanel.Controls.Add(this.btnTestDevice);
            this.bodyPanel.Location = new System.Drawing.Point(0, 64);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1111, 586);
            this.bodyPanel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.ll3);
            this.panel4.Controls.Add(this.iconButton4);
            this.panel4.Controls.Add(this.lblConnectedPort);
            this.panel4.Location = new System.Drawing.Point(882, 22);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 101);
            this.panel4.TabIndex = 34;
            // 
            // ll3
            // 
            this.ll3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ll3.AutoSize = true;
            this.ll3.BackColor = System.Drawing.Color.Transparent;
            this.ll3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll3.ForeColor = System.Drawing.Color.White;
            this.ll3.Location = new System.Drawing.Point(76, 64);
            this.ll3.Name = "ll3";
            this.ll3.Size = new System.Drawing.Size(84, 17);
            this.ll3.TabIndex = 36;
            this.ll3.Text = "Total Device";
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(13, 28);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(45, 47);
            this.iconButton4.TabIndex = 2;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // lblConnectedPort
            // 
            this.lblConnectedPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConnectedPort.AutoSize = true;
            this.lblConnectedPort.BackColor = System.Drawing.Color.Transparent;
            this.lblConnectedPort.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectedPort.ForeColor = System.Drawing.Color.White;
            this.lblConnectedPort.Location = new System.Drawing.Point(73, 23);
            this.lblConnectedPort.Name = "lblConnectedPort";
            this.lblConnectedPort.Size = new System.Drawing.Size(79, 32);
            this.lblConnectedPort.TabIndex = 1;
            this.lblConnectedPort.Text = "0kWh";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.lblComPort);
            this.panel3.Controls.Add(this.comboBoxPorts);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(56, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 101);
            this.panel3.TabIndex = 16;
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComPort.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblComPort.Location = new System.Drawing.Point(8, 6);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(75, 21);
            this.lblComPort.TabIndex = 13;
            this.lblComPort.Text = "Com Port";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPorts.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 43);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(758, 38);
            this.comboBoxPorts.TabIndex = 56;
            // 
            // btnTestDevice
            // 
            this.btnTestDevice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTestDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(110)))));
            this.btnTestDevice.FlatAppearance.BorderSize = 0;
            this.btnTestDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestDevice.ForeColor = System.Drawing.Color.White;
            this.btnTestDevice.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTestDevice.IconColor = System.Drawing.Color.White;
            this.btnTestDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTestDevice.IconSize = 32;
            this.btnTestDevice.Location = new System.Drawing.Point(56, 143);
            this.btnTestDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnTestDevice.Name = "btnTestDevice";
            this.btnTestDevice.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTestDevice.Size = new System.Drawing.Size(190, 44);
            this.btnTestDevice.TabIndex = 24;
            this.btnTestDevice.Text = "Test Device";
            this.btnTestDevice.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1111, 650);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bodyPanel;
        private FontAwesome.Sharp.IconButton btnTestDevice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label lblConnectedPort;
        private System.Windows.Forms.Label ll3;
        private System.Windows.Forms.ComboBox comboBoxPorts;
    }
}