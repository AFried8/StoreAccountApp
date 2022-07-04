namespace SemesterProj {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Tab_menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Lbl_welcome = new System.Windows.Forms.Label();
            this.Tab_menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_menu
            // 
            this.Tab_menu.Controls.Add(this.tabPage1);
            this.Tab_menu.Controls.Add(this.tabPage2);
            this.Tab_menu.Location = new System.Drawing.Point(2, 1);
            this.Tab_menu.Name = "Tab_menu";
            this.Tab_menu.SelectedIndex = 0;
            this.Tab_menu.Size = new System.Drawing.Size(798, 375);
            this.Tab_menu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Lbl_welcome);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Lbl_welcome
            // 
            this.Lbl_welcome.AutoSize = true;
            this.Lbl_welcome.Location = new System.Drawing.Point(235, 97);
            this.Lbl_welcome.Name = "Lbl_welcome";
            this.Lbl_welcome.Size = new System.Drawing.Size(293, 24);
            this.Lbl_welcome.TabIndex = 0;
            this.Lbl_welcome.Text = "Welcome to you store account";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tab_menu);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Tab_menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Lbl_welcome;
        private System.Windows.Forms.TabPage tabPage2;
    }
}