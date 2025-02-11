
namespace WifiPocketProject.UI
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBtnMenu = new FontAwesome.Sharp.IconButton();
            this.pnBtnSetting = new FontAwesome.Sharp.IconButton();
            this.pnBtnDataExport = new FontAwesome.Sharp.IconButton();
            this.pnBtnAboutUs = new FontAwesome.Sharp.IconButton();
            this.pnBtnLogout = new FontAwesome.Sharp.IconButton();
            this.MenuContainer = new FontAwesome.Sharp.IconButton();
            this.SidebarTransaction = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Application";
            // 
            // btnHam
            // 
            this.btnHam.Location = new System.Drawing.Point(0, 0);
            this.btnHam.Margin = new System.Windows.Forms.Padding(2);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(80, 39);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.sidebarPanel.Controls.Add(this.pnBtnDashboard);
            this.sidebarPanel.Controls.Add(this.pnBtnMenu);
            this.sidebarPanel.Controls.Add(this.pnBtnSetting);
            this.sidebarPanel.Controls.Add(this.pnBtnDataExport);
            this.sidebarPanel.Controls.Add(this.pnBtnAboutUs);
            this.sidebarPanel.Controls.Add(this.pnBtnLogout);
            this.sidebarPanel.Controls.Add(this.MenuContainer);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 40);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(166, 660);
            this.sidebarPanel.TabIndex = 1;
            // 
            // pnBtnDashboard
            // 
             this.pnBtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pnBtnDashboard.FlatAppearance.BorderSize = 0;
            this.pnBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnBtnDashboard.ForeColor = System.Drawing.Color.White;
            this.pnBtnDashboard.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.pnBtnDashboard.IconColor = System.Drawing.Color.White;
            this.pnBtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnBtnDashboard.IconSize = 32;
            this.pnBtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnBtnDashboard.Location = new System.Drawing.Point(2, 2);
            this.pnBtnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.pnBtnDashboard.Name = "pnBtnDashboard";
            this.pnBtnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnBtnDashboard.Size = new System.Drawing.Size(179, 48);
            this.pnBtnDashboard.TabIndex = 11;
            this.pnBtnDashboard.Text = "Dashboard";
            this.pnBtnDashboard.UseVisualStyleBackColor = false;
            this.pnBtnDashboard.Click += new System.EventHandler(this.pnBtnDashboard_Click);
            // 
            // pnBtnMenu
            // 
            this.pnBtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pnBtnMenu.FlatAppearance.BorderSize = 0;
            this.pnBtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnBtnMenu.ForeColor = System.Drawing.Color.White;
             this.pnBtnMenu.IconChar = FontAwesome.Sharp.IconChar.Deezer;
            this.pnBtnMenu.IconColor = System.Drawing.Color.White;
             this.pnBtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnBtnMenu.IconSize = 32;
            this.pnBtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnBtnMenu.Location = new System.Drawing.Point(2, 54);
            this.pnBtnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnBtnMenu.Name = "pnBtnMenu";
            this.pnBtnMenu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnBtnMenu.Size = new System.Drawing.Size(179, 48);
            this.pnBtnMenu.TabIndex = 10;
            this.pnBtnMenu.Text = "Menu";
            this.pnBtnMenu.UseVisualStyleBackColor = false;
            this.pnBtnMenu.Click += new System.EventHandler(this.pnBtnMenu_Click);
            // 
            // pnBtnSetting
            // 
            this.pnBtnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pnBtnSetting.FlatAppearance.BorderSize = 0;
            this.pnBtnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnBtnSetting.ForeColor = System.Drawing.Color.White;
             this.pnBtnSetting.IconChar = FontAwesome.Sharp.IconChar.SquareVirus;
            this.pnBtnSetting.IconColor = System.Drawing.Color.White;
             this.pnBtnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnBtnSetting.IconSize = 32;
            this.pnBtnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnBtnSetting.Location = new System.Drawing.Point(2, 106);
            this.pnBtnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.pnBtnSetting.Name = "pnBtnSetting";
            this.pnBtnSetting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnBtnSetting.Size = new System.Drawing.Size(179, 48);
            this.pnBtnSetting.TabIndex = 11;
            this.pnBtnSetting.Text = "Settings";
            this.pnBtnSetting.UseVisualStyleBackColor = false;
            this.pnBtnSetting.Click += new System.EventHandler(this.pnBtnSetting_Click);
            // 
            // pnBtnDataExport
            // 
            this.pnBtnDataExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pnBtnDataExport.FlatAppearance.BorderSize = 0;
            this.pnBtnDataExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnBtnDataExport.ForeColor = System.Drawing.Color.White;
            this.pnBtnDataExport.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.pnBtnDataExport.IconColor = System.Drawing.Color.White;
            this.pnBtnDataExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnBtnDataExport.IconSize = 32;
            this.pnBtnDataExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnBtnDataExport.Location = new System.Drawing.Point(2, 158);
            this.pnBtnDataExport.Margin = new System.Windows.Forms.Padding(2);
            this.pnBtnDataExport.Name = "pnBtnDataExport";
            this.pnBtnDataExport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnBtnDataExport.Size = new System.Drawing.Size(179, 48);
            this.pnBtnDataExport.TabIndex = 15;
            this.pnBtnDataExport.Text = "Data Export";
            this.pnBtnDataExport.UseVisualStyleBackColor = false;
            this.pnBtnDataExport.Click += new System.EventHandler(this.pnBtnDataExport_Click);
            // 
            // pnBtnAboutUs
            // 
            this.pnBtnAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pnBtnAboutUs.FlatAppearance.BorderSize = 0;
            this.pnBtnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnBtnAboutUs.ForeColor = System.Drawing.Color.White;
            this.pnBtnAboutUs.IconChar = FontAwesome.Sharp.IconChar.Uncharted;
            this.pnBtnAboutUs.IconColor = System.Drawing.Color.White;
            this.pnBtnAboutUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnBtnAboutUs.IconSize = 32;
            this.pnBtnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnBtnAboutUs.Location = new System.Drawing.Point(2, 210);
            this.pnBtnAboutUs.Margin = new System.Windows.Forms.Padding(2);
            this.pnBtnAboutUs.Name = "pnBtnAboutUs";
            this.pnBtnAboutUs.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnBtnAboutUs.Size = new System.Drawing.Size(179, 48);
            this.pnBtnAboutUs.TabIndex = 12;
            this.pnBtnAboutUs.Text = "About Us";
            this.pnBtnAboutUs.UseVisualStyleBackColor = false;
            this.pnBtnAboutUs.Visible = false;
            this.pnBtnAboutUs.Click += new System.EventHandler(this.pnBtnAboutUs_Click);
            // 
            // pnBtnLogout
            // 
            this.pnBtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pnBtnLogout.FlatAppearance.BorderSize = 0;
            this.pnBtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnBtnLogout.ForeColor = System.Drawing.Color.White;
            this.pnBtnLogout.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.pnBtnLogout.IconColor = System.Drawing.Color.White;
            this.pnBtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pnBtnLogout.IconSize = 32;
            this.pnBtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnBtnLogout.Location = new System.Drawing.Point(2, 262);
            this.pnBtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.pnBtnLogout.Name = "pnBtnLogout";
            this.pnBtnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnBtnLogout.Size = new System.Drawing.Size(179, 48);
            this.pnBtnLogout.TabIndex = 13;
            this.pnBtnLogout.Text = "Logout";
            this.pnBtnLogout.UseVisualStyleBackColor = false;
            this.pnBtnLogout.Click += new System.EventHandler(this.pnBtnLogout_Click);
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.MenuContainer.FlatAppearance.BorderSize = 0;
            this.MenuContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuContainer.ForeColor = System.Drawing.Color.White;
            this.MenuContainer.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.MenuContainer.IconColor = System.Drawing.Color.White;
            this.MenuContainer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuContainer.IconSize = 32;
            this.MenuContainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuContainer.Location = new System.Drawing.Point(2, 314);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(2);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.MenuContainer.Size = new System.Drawing.Size(179, 48);
            this.MenuContainer.TabIndex = 14;
            this.MenuContainer.Text = "Menu Con";
            this.MenuContainer.UseVisualStyleBackColor = false;
            this.MenuContainer.Visible = false;
            // 
            // SidebarTransaction
            // 
            this.SidebarTransaction.Interval = 10;
            this.SidebarTransaction.Tick += new System.EventHandler(this.SidebarTransaction_Tick);
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebarPanel;
        private FontAwesome.Sharp.IconButton pnBtnMenu;
        private FontAwesome.Sharp.IconButton pnBtnSetting;
        private FontAwesome.Sharp.IconButton pnBtnAboutUs;
        private FontAwesome.Sharp.IconButton pnBtnLogout;
        private System.Windows.Forms.Timer SidebarTransaction;
        private FontAwesome.Sharp.IconButton MenuContainer;
        private FontAwesome.Sharp.IconButton pnBtnDashboard;
        private FontAwesome.Sharp.IconButton pnBtnDataExport;
    }
}