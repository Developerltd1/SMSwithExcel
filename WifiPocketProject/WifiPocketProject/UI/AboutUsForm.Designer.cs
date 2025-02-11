
namespace WifiPocketProject.UI
{
    partial class AboutUsForm
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
            this.AboutUs = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // AboutUs
            // 
            this.AboutUs.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AboutUs.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AboutUs.DisabledForeColor = System.Drawing.Color.Gray;
            this.AboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AboutUs.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.AboutUs.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.AboutUs.HoverTextColor = System.Drawing.Color.White;
            this.AboutUs.IsDerivedStyle = true;
            this.AboutUs.Location = new System.Drawing.Point(219, 156);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AboutUs.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AboutUs.NormalTextColor = System.Drawing.Color.White;
            this.AboutUs.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.AboutUs.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.AboutUs.PressTextColor = System.Drawing.Color.White;
            this.AboutUs.Size = new System.Drawing.Size(170, 87);
            this.AboutUs.Style = MetroSet_UI.Enums.Style.Light;
            this.AboutUs.StyleManager = null;
            this.AboutUs.TabIndex = 0;
            this.AboutUs.Text = "AboutUs";
            this.AboutUs.ThemeAuthor = "Narwin";
            this.AboutUs.ThemeName = "MetroLite";
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AboutUs);
            this.Name = "AboutUsForm";
            this.Text = "AboutUsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton AboutUs;
    }
}