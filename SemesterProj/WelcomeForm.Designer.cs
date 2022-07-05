namespace SemesterProj {
    partial class Welcome_form {
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
            this.Pnl_login = new System.Windows.Forms.Panel();
            this.Lbl_error = new System.Windows.Forms.Label();
            this.Lbl_password_l = new System.Windows.Forms.Label();
            this.Lbl_username_l = new System.Windows.Forms.Label();
            this.Txt_username_l = new System.Windows.Forms.TextBox();
            this.Txt_password_l = new System.Windows.Forms.TextBox();
            this.Btn_login_l = new System.Windows.Forms.Button();
            this.Pnl_create_account = new System.Windows.Forms.Panel();
            this.Lbl_error_c = new System.Windows.Forms.Label();
            this.Lbl_password_c = new System.Windows.Forms.Label();
            this.Lbl_username_c = new System.Windows.Forms.Label();
            this.Txt_username_c = new System.Windows.Forms.TextBox();
            this.Txt_password_c = new System.Windows.Forms.TextBox();
            this.Btn_create_account_c = new System.Windows.Forms.Button();
            this.Pnl_welcome = new System.Windows.Forms.Panel();
            this.Btn_create_account = new System.Windows.Forms.Button();
            this.Btn_login = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.itemTableAdapter1 = new SemesterProj.StoreSalesDataSetTableAdapters.ItemTableAdapter();
            this.Btn_back_c = new System.Windows.Forms.Button();
            this.Btn_back_l = new System.Windows.Forms.Button();
            this.Pnl_login.SuspendLayout();
            this.Pnl_create_account.SuspendLayout();
            this.Pnl_welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_login
            // 
            this.Pnl_login.Controls.Add(this.Btn_back_l);
            this.Pnl_login.Controls.Add(this.Lbl_error);
            this.Pnl_login.Controls.Add(this.Lbl_password_l);
            this.Pnl_login.Controls.Add(this.Lbl_username_l);
            this.Pnl_login.Controls.Add(this.Txt_username_l);
            this.Pnl_login.Controls.Add(this.Txt_password_l);
            this.Pnl_login.Controls.Add(this.Btn_login_l);
            this.Pnl_login.Location = new System.Drawing.Point(176, 93);
            this.Pnl_login.Name = "Pnl_login";
            this.Pnl_login.Size = new System.Drawing.Size(350, 162);
            this.Pnl_login.TabIndex = 0;
            this.Pnl_login.Visible = false;
            // 
            // Lbl_error
            // 
            this.Lbl_error.AutoSize = true;
            this.Lbl_error.ForeColor = System.Drawing.Color.Red;
            this.Lbl_error.Location = new System.Drawing.Point(114, 11);
            this.Lbl_error.Name = "Lbl_error";
            this.Lbl_error.Size = new System.Drawing.Size(0, 13);
            this.Lbl_error.TabIndex = 6;
            // 
            // Lbl_password_l
            // 
            this.Lbl_password_l.AutoSize = true;
            this.Lbl_password_l.Location = new System.Drawing.Point(21, 75);
            this.Lbl_password_l.Name = "Lbl_password_l";
            this.Lbl_password_l.Size = new System.Drawing.Size(53, 13);
            this.Lbl_password_l.TabIndex = 4;
            this.Lbl_password_l.Text = "Password";
            // 
            // Lbl_username_l
            // 
            this.Lbl_username_l.AutoSize = true;
            this.Lbl_username_l.Location = new System.Drawing.Point(18, 39);
            this.Lbl_username_l.Name = "Lbl_username_l";
            this.Lbl_username_l.Size = new System.Drawing.Size(55, 13);
            this.Lbl_username_l.TabIndex = 3;
            this.Lbl_username_l.Text = "Username";
            // 
            // Txt_username_l
            // 
            this.Txt_username_l.Location = new System.Drawing.Point(117, 39);
            this.Txt_username_l.Name = "Txt_username_l";
            this.Txt_username_l.Size = new System.Drawing.Size(100, 20);
            this.Txt_username_l.TabIndex = 2;
            // 
            // Txt_password_l
            // 
            this.Txt_password_l.Location = new System.Drawing.Point(117, 75);
            this.Txt_password_l.Name = "Txt_password_l";
            this.Txt_password_l.Size = new System.Drawing.Size(100, 20);
            this.Txt_password_l.TabIndex = 1;
            // 
            // Btn_login_l
            // 
            this.Btn_login_l.Location = new System.Drawing.Point(90, 116);
            this.Btn_login_l.Name = "Btn_login_l";
            this.Btn_login_l.Size = new System.Drawing.Size(75, 23);
            this.Btn_login_l.TabIndex = 0;
            this.Btn_login_l.Text = "Login";
            this.Btn_login_l.UseVisualStyleBackColor = true;
            this.Btn_login_l.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Pnl_create_account
            // 
            this.Pnl_create_account.Controls.Add(this.Btn_back_c);
            this.Pnl_create_account.Controls.Add(this.Lbl_error_c);
            this.Pnl_create_account.Controls.Add(this.Lbl_password_c);
            this.Pnl_create_account.Controls.Add(this.Lbl_username_c);
            this.Pnl_create_account.Controls.Add(this.Txt_username_c);
            this.Pnl_create_account.Controls.Add(this.Txt_password_c);
            this.Pnl_create_account.Controls.Add(this.Btn_create_account_c);
            this.Pnl_create_account.Location = new System.Drawing.Point(222, 93);
            this.Pnl_create_account.Name = "Pnl_create_account";
            this.Pnl_create_account.Size = new System.Drawing.Size(254, 158);
            this.Pnl_create_account.TabIndex = 5;
            this.Pnl_create_account.Visible = false;
            // 
            // Lbl_error_c
            // 
            this.Lbl_error_c.AutoSize = true;
            this.Lbl_error_c.Location = new System.Drawing.Point(24, 10);
            this.Lbl_error_c.Name = "Lbl_error_c";
            this.Lbl_error_c.Size = new System.Drawing.Size(0, 13);
            this.Lbl_error_c.TabIndex = 5;
            // 
            // Lbl_password_c
            // 
            this.Lbl_password_c.AutoSize = true;
            this.Lbl_password_c.Location = new System.Drawing.Point(21, 75);
            this.Lbl_password_c.Name = "Lbl_password_c";
            this.Lbl_password_c.Size = new System.Drawing.Size(53, 13);
            this.Lbl_password_c.TabIndex = 4;
            this.Lbl_password_c.Text = "Password";
            // 
            // Lbl_username_c
            // 
            this.Lbl_username_c.AutoSize = true;
            this.Lbl_username_c.Location = new System.Drawing.Point(19, 35);
            this.Lbl_username_c.Name = "Lbl_username_c";
            this.Lbl_username_c.Size = new System.Drawing.Size(55, 13);
            this.Lbl_username_c.TabIndex = 3;
            this.Lbl_username_c.Text = "Username";
            // 
            // Txt_username_c
            // 
            this.Txt_username_c.Location = new System.Drawing.Point(117, 35);
            this.Txt_username_c.Name = "Txt_username_c";
            this.Txt_username_c.Size = new System.Drawing.Size(100, 20);
            this.Txt_username_c.TabIndex = 2;
            // 
            // Txt_password_c
            // 
            this.Txt_password_c.Location = new System.Drawing.Point(117, 75);
            this.Txt_password_c.Name = "Txt_password_c";
            this.Txt_password_c.Size = new System.Drawing.Size(100, 20);
            this.Txt_password_c.TabIndex = 1;
            // 
            // Btn_create_account_c
            // 
            this.Btn_create_account_c.Location = new System.Drawing.Point(90, 116);
            this.Btn_create_account_c.Name = "Btn_create_account_c";
            this.Btn_create_account_c.Size = new System.Drawing.Size(99, 23);
            this.Btn_create_account_c.TabIndex = 0;
            this.Btn_create_account_c.Text = "Create Account";
            this.Btn_create_account_c.UseVisualStyleBackColor = true;
            this.Btn_create_account_c.Click += new System.EventHandler(this.btn_create_account_c_Click);
            // 
            // Pnl_welcome
            // 
            this.Pnl_welcome.Controls.Add(this.Btn_create_account);
            this.Pnl_welcome.Controls.Add(this.Btn_login);
            this.Pnl_welcome.Location = new System.Drawing.Point(225, 93);
            this.Pnl_welcome.Name = "Pnl_welcome";
            this.Pnl_welcome.Size = new System.Drawing.Size(251, 155);
            this.Pnl_welcome.TabIndex = 5;
            // 
            // Btn_create_account
            // 
            this.Btn_create_account.Location = new System.Drawing.Point(73, 91);
            this.Btn_create_account.Name = "Btn_create_account";
            this.Btn_create_account.Size = new System.Drawing.Size(116, 23);
            this.Btn_create_account.TabIndex = 1;
            this.Btn_create_account.Text = "Create Account ";
            this.Btn_create_account.UseVisualStyleBackColor = true;
            this.Btn_create_account.Click += new System.EventHandler(this.Btn_create_account_Click);
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(73, 37);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(116, 23);
            this.Btn_login.TabIndex = 0;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(217, 35);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(309, 25);
            this.lbl_Welcome.TabIndex = 1;
            this.lbl_Welcome.Text = "Welcome to your store account";
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // Btn_back_c
            // 
            this.Btn_back_c.Location = new System.Drawing.Point(0, 4);
            this.Btn_back_c.Name = "Btn_back_c";
            this.Btn_back_c.Size = new System.Drawing.Size(28, 23);
            this.Btn_back_c.TabIndex = 6;
            this.Btn_back_c.Text = "<-";
            this.Btn_back_c.UseVisualStyleBackColor = true;
            this.Btn_back_c.Click += new System.EventHandler(this.Btn_back_c_Click_1);
            // 
            // Btn_back_l
            // 
            this.Btn_back_l.Location = new System.Drawing.Point(0, 0);
            this.Btn_back_l.Name = "Btn_back_l";
            this.Btn_back_l.Size = new System.Drawing.Size(30, 23);
            this.Btn_back_l.TabIndex = 7;
            this.Btn_back_l.Text = "<-";
            this.Btn_back_l.UseVisualStyleBackColor = true;
            this.Btn_back_l.Click += new System.EventHandler(this.Btn_back_l_Click);
            // 
            // Welcome_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pnl_welcome);
            this.Controls.Add(this.Pnl_create_account);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.Pnl_login);
            this.Name = "Welcome_form";
            this.Text = "Welcome";
            this.Pnl_login.ResumeLayout(false);
            this.Pnl_login.PerformLayout();
            this.Pnl_create_account.ResumeLayout(false);
            this.Pnl_create_account.PerformLayout();
            this.Pnl_welcome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_login;
        private System.Windows.Forms.Button Btn_login_l;
        private System.Windows.Forms.Label Lbl_password_l;
        private System.Windows.Forms.Label Lbl_username_l;
        private System.Windows.Forms.TextBox Txt_username_l;
        private System.Windows.Forms.TextBox Txt_password_l;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Panel Pnl_welcome;
        private System.Windows.Forms.Button Btn_create_account;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Panel Pnl_create_account;
        private System.Windows.Forms.Label Lbl_password_c;
        private System.Windows.Forms.Label Lbl_username_c;
        private System.Windows.Forms.TextBox Txt_username_c;
        private System.Windows.Forms.TextBox Txt_password_c;
        private System.Windows.Forms.Button Btn_create_account_c;
        private System.Windows.Forms.Label Lbl_error;
        private System.Windows.Forms.Label Lbl_error_c;
        private StoreSalesDataSetTableAdapters.ItemTableAdapter itemTableAdapter1;
        private System.Windows.Forms.Button Btn_back_c;
        private System.Windows.Forms.Button Btn_back_l;
    }
}

