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
            this.components = new System.ComponentModel.Container();
            this.Tab_menu = new System.Windows.Forms.TabControl();
            this.Tab_welcome = new System.Windows.Forms.TabPage();
            this.Lbl_welcome = new System.Windows.Forms.Label();
            this.Tab_buy = new System.Windows.Forms.TabPage();
            this.Lbl_purchase_message = new System.Windows.Forms.Label();
            this.Nbr_amount = new System.Windows.Forms.NumericUpDown();
            this.Lbl_error = new System.Windows.Forms.Label();
            this.Btn_buy = new System.Windows.Forms.Button();
            this.Lsv_items = new System.Windows.Forms.ListView();
            this.Tab_myAcct = new System.Windows.Forms.TabPage();
            this.Pnl_pay = new System.Windows.Forms.Panel();
            this.Btn_final_pay = new System.Windows.Forms.Button();
            this.Lbl_amount = new System.Windows.Forms.Label();
            this.Txt_amount = new System.Windows.Forms.TextBox();
            this.Btn_pay = new System.Windows.Forms.Button();
            this.Lbl_balanceT = new System.Windows.Forms.Label();
            this.Lbl_balance = new System.Windows.Forms.Label();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeSalesDataSet = new SemesterProj.StoreSalesDataSet();
            this.itemTableAdapter = new SemesterProj.StoreSalesDataSetTableAdapters.ItemTableAdapter();
            this.Lbl_pay_error = new System.Windows.Forms.Label();
            this.Tab_purchases = new System.Windows.Forms.TabPage();
            this.Lsv_purchases = new System.Windows.Forms.ListView();
            this.Cmb_filter = new System.Windows.Forms.ComboBox();
            this.Pnl_date_filter = new System.Windows.Forms.Panel();
            this.Dtp_from = new System.Windows.Forms.DateTimePicker();
            this.Dtp_to = new System.Windows.Forms.DateTimePicker();
            this.Lbl_date_from = new System.Windows.Forms.Label();
            this.Lbl_date_to = new System.Windows.Forms.Label();
            this.Btn_date_go = new System.Windows.Forms.Button();
            this.Lbl_error_filter = new System.Windows.Forms.Label();
            this.Pnl_filter_price = new System.Windows.Forms.Panel();
            this.Lbl_price_between = new System.Windows.Forms.Label();
            this.Lbl_price_and = new System.Windows.Forms.Label();
            this.Txt_price_from = new System.Windows.Forms.TextBox();
            this.Txt_price_to = new System.Windows.Forms.TextBox();
            this.Btn_price_go = new System.Windows.Forms.Button();
            this.Tab_menu.SuspendLayout();
            this.Tab_welcome.SuspendLayout();
            this.Tab_buy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nbr_amount)).BeginInit();
            this.Tab_myAcct.SuspendLayout();
            this.Pnl_pay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeSalesDataSet)).BeginInit();
            this.Tab_purchases.SuspendLayout();
            this.Pnl_date_filter.SuspendLayout();
            this.Pnl_filter_price.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_menu
            // 
            this.Tab_menu.Controls.Add(this.Tab_welcome);
            this.Tab_menu.Controls.Add(this.Tab_buy);
            this.Tab_menu.Controls.Add(this.Tab_myAcct);
            this.Tab_menu.Controls.Add(this.Tab_purchases);
            this.Tab_menu.Location = new System.Drawing.Point(3, 2);
            this.Tab_menu.Name = "Tab_menu";
            this.Tab_menu.SelectedIndex = 0;
            this.Tab_menu.Size = new System.Drawing.Size(797, 373);
            this.Tab_menu.TabIndex = 0;
            // 
            // Tab_welcome
            // 
            this.Tab_welcome.Controls.Add(this.Lbl_welcome);
            this.Tab_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_welcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tab_welcome.Location = new System.Drawing.Point(4, 22);
            this.Tab_welcome.Name = "Tab_welcome";
            this.Tab_welcome.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_welcome.Size = new System.Drawing.Size(789, 347);
            this.Tab_welcome.TabIndex = 0;
            this.Tab_welcome.Text = "Welcome";
            this.Tab_welcome.UseVisualStyleBackColor = true;
            // 
            // Lbl_welcome
            // 
            this.Lbl_welcome.AutoSize = true;
            this.Lbl_welcome.Location = new System.Drawing.Point(235, 107);
            this.Lbl_welcome.Name = "Lbl_welcome";
            this.Lbl_welcome.Size = new System.Drawing.Size(300, 24);
            this.Lbl_welcome.TabIndex = 0;
            this.Lbl_welcome.Text = "Welcome to your store account";
            // 
            // Tab_buy
            // 
            this.Tab_buy.Controls.Add(this.Lbl_purchase_message);
            this.Tab_buy.Controls.Add(this.Nbr_amount);
            this.Tab_buy.Controls.Add(this.Lbl_error);
            this.Tab_buy.Controls.Add(this.Btn_buy);
            this.Tab_buy.Controls.Add(this.Lsv_items);
            this.Tab_buy.Location = new System.Drawing.Point(4, 22);
            this.Tab_buy.Name = "Tab_buy";
            this.Tab_buy.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_buy.Size = new System.Drawing.Size(789, 347);
            this.Tab_buy.TabIndex = 1;
            this.Tab_buy.Text = "Buy Items";
            this.Tab_buy.UseVisualStyleBackColor = true;
            // 
            // Lbl_purchase_message
            // 
            this.Lbl_purchase_message.AutoSize = true;
            this.Lbl_purchase_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_purchase_message.Location = new System.Drawing.Point(23, 233);
            this.Lbl_purchase_message.Name = "Lbl_purchase_message";
            this.Lbl_purchase_message.Size = new System.Drawing.Size(0, 20);
            this.Lbl_purchase_message.TabIndex = 4;
            // 
            // Nbr_amount
            // 
            this.Nbr_amount.Location = new System.Drawing.Point(684, 195);
            this.Nbr_amount.Name = "Nbr_amount";
            this.Nbr_amount.Size = new System.Drawing.Size(41, 20);
            this.Nbr_amount.TabIndex = 3;
            this.Nbr_amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_error
            // 
            this.Lbl_error.AutoSize = true;
            this.Lbl_error.Location = new System.Drawing.Point(627, 33);
            this.Lbl_error.Name = "Lbl_error";
            this.Lbl_error.Size = new System.Drawing.Size(0, 13);
            this.Lbl_error.TabIndex = 2;
            // 
            // Btn_buy
            // 
            this.Btn_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buy.Location = new System.Drawing.Point(652, 144);
            this.Btn_buy.Name = "Btn_buy";
            this.Btn_buy.Size = new System.Drawing.Size(96, 73);
            this.Btn_buy.TabIndex = 1;
            this.Btn_buy.Text = "Buy";
            this.Btn_buy.UseVisualStyleBackColor = true;
            this.Btn_buy.Click += new System.EventHandler(this.Btn_buy_Click);
            // 
            // Lsv_items
            // 
            this.Lsv_items.HideSelection = false;
            this.Lsv_items.Location = new System.Drawing.Point(23, 33);
            this.Lsv_items.Name = "Lsv_items";
            this.Lsv_items.Size = new System.Drawing.Size(598, 184);
            this.Lsv_items.TabIndex = 0;
            this.Lsv_items.UseCompatibleStateImageBehavior = false;
            // 
            // Tab_myAcct
            // 
            this.Tab_myAcct.Controls.Add(this.Lbl_pay_error);
            this.Tab_myAcct.Controls.Add(this.Pnl_pay);
            this.Tab_myAcct.Controls.Add(this.Btn_pay);
            this.Tab_myAcct.Controls.Add(this.Lbl_balanceT);
            this.Tab_myAcct.Controls.Add(this.Lbl_balance);
            this.Tab_myAcct.Location = new System.Drawing.Point(4, 22);
            this.Tab_myAcct.Name = "Tab_myAcct";
            this.Tab_myAcct.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_myAcct.Size = new System.Drawing.Size(789, 347);
            this.Tab_myAcct.TabIndex = 2;
            this.Tab_myAcct.Text = "My Account";
            this.Tab_myAcct.UseVisualStyleBackColor = true;
            // 
            // Pnl_pay
            // 
            this.Pnl_pay.Controls.Add(this.Btn_final_pay);
            this.Pnl_pay.Controls.Add(this.Lbl_amount);
            this.Pnl_pay.Controls.Add(this.Txt_amount);
            this.Pnl_pay.Location = new System.Drawing.Point(433, 83);
            this.Pnl_pay.Name = "Pnl_pay";
            this.Pnl_pay.Size = new System.Drawing.Size(203, 126);
            this.Pnl_pay.TabIndex = 3;
            this.Pnl_pay.Visible = false;
            // 
            // Btn_final_pay
            // 
            this.Btn_final_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_final_pay.Location = new System.Drawing.Point(52, 84);
            this.Btn_final_pay.Name = "Btn_final_pay";
            this.Btn_final_pay.Size = new System.Drawing.Size(77, 32);
            this.Btn_final_pay.TabIndex = 2;
            this.Btn_final_pay.Text = "Pay";
            this.Btn_final_pay.UseVisualStyleBackColor = true;
            this.Btn_final_pay.Click += new System.EventHandler(this.Btn_final_pay_Click);
            // 
            // Lbl_amount
            // 
            this.Lbl_amount.AutoSize = true;
            this.Lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_amount.Location = new System.Drawing.Point(49, 16);
            this.Lbl_amount.Name = "Lbl_amount";
            this.Lbl_amount.Size = new System.Drawing.Size(63, 18);
            this.Lbl_amount.TabIndex = 1;
            this.Lbl_amount.Text = "Amount:";
            // 
            // Txt_amount
            // 
            this.Txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_amount.Location = new System.Drawing.Point(52, 50);
            this.Txt_amount.Name = "Txt_amount";
            this.Txt_amount.Size = new System.Drawing.Size(100, 24);
            this.Txt_amount.TabIndex = 0;
            // 
            // Btn_pay
            // 
            this.Btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pay.Location = new System.Drawing.Point(61, 154);
            this.Btn_pay.Name = "Btn_pay";
            this.Btn_pay.Size = new System.Drawing.Size(156, 55);
            this.Btn_pay.TabIndex = 2;
            this.Btn_pay.Text = "Pay my balance";
            this.Btn_pay.UseVisualStyleBackColor = true;
            this.Btn_pay.Click += new System.EventHandler(this.Btn_pay_Click);
            // 
            // Lbl_balanceT
            // 
            this.Lbl_balanceT.AutoSize = true;
            this.Lbl_balanceT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_balanceT.Location = new System.Drawing.Point(146, 52);
            this.Lbl_balanceT.Name = "Lbl_balanceT";
            this.Lbl_balanceT.Size = new System.Drawing.Size(18, 20);
            this.Lbl_balanceT.TabIndex = 1;
            this.Lbl_balanceT.Text = "$";
            // 
            // Lbl_balance
            // 
            this.Lbl_balance.AutoSize = true;
            this.Lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_balance.Location = new System.Drawing.Point(57, 49);
            this.Lbl_balance.Name = "Lbl_balance";
            this.Lbl_balance.Size = new System.Drawing.Size(88, 24);
            this.Lbl_balance.TabIndex = 0;
            this.Lbl_balance.Text = "Balance: ";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.storeSalesDataSet;
            // 
            // storeSalesDataSet
            // 
            this.storeSalesDataSet.DataSetName = "StoreSalesDataSet";
            this.storeSalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // Lbl_pay_error
            // 
            this.Lbl_pay_error.AutoSize = true;
            this.Lbl_pay_error.Location = new System.Drawing.Point(430, 49);
            this.Lbl_pay_error.Name = "Lbl_pay_error";
            this.Lbl_pay_error.Size = new System.Drawing.Size(0, 13);
            this.Lbl_pay_error.TabIndex = 4;
            // 
            // Tab_purchases
            // 
            this.Tab_purchases.Controls.Add(this.Lbl_error_filter);
            this.Tab_purchases.Controls.Add(this.Pnl_date_filter);
            this.Tab_purchases.Controls.Add(this.Cmb_filter);
            this.Tab_purchases.Controls.Add(this.Lsv_purchases);
            this.Tab_purchases.Location = new System.Drawing.Point(4, 22);
            this.Tab_purchases.Name = "Tab_purchases";
            this.Tab_purchases.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_purchases.Size = new System.Drawing.Size(789, 347);
            this.Tab_purchases.TabIndex = 3;
            this.Tab_purchases.Text = "My Purchases";
            this.Tab_purchases.UseVisualStyleBackColor = true;
            // 
            // Lsv_purchases
            // 
            this.Lsv_purchases.HideSelection = false;
            this.Lsv_purchases.Location = new System.Drawing.Point(31, 36);
            this.Lsv_purchases.Name = "Lsv_purchases";
            this.Lsv_purchases.Size = new System.Drawing.Size(463, 241);
            this.Lsv_purchases.TabIndex = 0;
            this.Lsv_purchases.UseCompatibleStateImageBehavior = false;
            // 
            // Cmb_filter
            // 
            this.Cmb_filter.FormattingEnabled = true;
            this.Cmb_filter.Items.AddRange(new object[] {
            "Date",
            "Total"});
            this.Cmb_filter.Location = new System.Drawing.Point(514, 36);
            this.Cmb_filter.Name = "Cmb_filter";
            this.Cmb_filter.Size = new System.Drawing.Size(121, 21);
            this.Cmb_filter.TabIndex = 1;
            this.Cmb_filter.Text = "Filter by";
            this.Cmb_filter.SelectedIndexChanged += new System.EventHandler(this.Cmb_filter_SelectedIndexChanged);
            // 
            // Pnl_date_filter
            // 
            this.Pnl_date_filter.Controls.Add(this.Pnl_filter_price);
            this.Pnl_date_filter.Controls.Add(this.Btn_date_go);
            this.Pnl_date_filter.Controls.Add(this.Lbl_date_to);
            this.Pnl_date_filter.Controls.Add(this.Lbl_date_from);
            this.Pnl_date_filter.Controls.Add(this.Dtp_to);
            this.Pnl_date_filter.Controls.Add(this.Dtp_from);
            this.Pnl_date_filter.Location = new System.Drawing.Point(514, 85);
            this.Pnl_date_filter.Name = "Pnl_date_filter";
            this.Pnl_date_filter.Size = new System.Drawing.Size(247, 157);
            this.Pnl_date_filter.TabIndex = 3;
            this.Pnl_date_filter.Visible = false;
            // 
            // Dtp_from
            // 
            this.Dtp_from.Location = new System.Drawing.Point(1, 31);
            this.Dtp_from.Name = "Dtp_from";
            this.Dtp_from.Size = new System.Drawing.Size(200, 20);
            this.Dtp_from.TabIndex = 0;
            // 
            // Dtp_to
            // 
            this.Dtp_to.Location = new System.Drawing.Point(0, 82);
            this.Dtp_to.Name = "Dtp_to";
            this.Dtp_to.Size = new System.Drawing.Size(200, 20);
            this.Dtp_to.TabIndex = 1;
            // 
            // Lbl_date_from
            // 
            this.Lbl_date_from.AutoSize = true;
            this.Lbl_date_from.Location = new System.Drawing.Point(2, 15);
            this.Lbl_date_from.Name = "Lbl_date_from";
            this.Lbl_date_from.Size = new System.Drawing.Size(30, 13);
            this.Lbl_date_from.TabIndex = 2;
            this.Lbl_date_from.Text = "From";
            // 
            // Lbl_date_to
            // 
            this.Lbl_date_to.AutoSize = true;
            this.Lbl_date_to.Location = new System.Drawing.Point(2, 66);
            this.Lbl_date_to.Name = "Lbl_date_to";
            this.Lbl_date_to.Size = new System.Drawing.Size(20, 13);
            this.Lbl_date_to.TabIndex = 3;
            this.Lbl_date_to.Text = "To";
            // 
            // Btn_date_go
            // 
            this.Btn_date_go.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_date_go.Location = new System.Drawing.Point(67, 109);
            this.Btn_date_go.Name = "Btn_date_go";
            this.Btn_date_go.Size = new System.Drawing.Size(75, 23);
            this.Btn_date_go.TabIndex = 4;
            this.Btn_date_go.Text = "Go";
            this.Btn_date_go.UseVisualStyleBackColor = false;
            this.Btn_date_go.Click += new System.EventHandler(this.Btn_date_go_Click);
            // 
            // Lbl_error_filter
            // 
            this.Lbl_error_filter.AutoSize = true;
            this.Lbl_error_filter.Location = new System.Drawing.Point(512, 254);
            this.Lbl_error_filter.Name = "Lbl_error_filter";
            this.Lbl_error_filter.Size = new System.Drawing.Size(0, 13);
            this.Lbl_error_filter.TabIndex = 4;
            // 
            // Pnl_filter_price
            // 
            this.Pnl_filter_price.Controls.Add(this.Btn_price_go);
            this.Pnl_filter_price.Controls.Add(this.Txt_price_to);
            this.Pnl_filter_price.Controls.Add(this.Txt_price_from);
            this.Pnl_filter_price.Controls.Add(this.Lbl_price_and);
            this.Pnl_filter_price.Controls.Add(this.Lbl_price_between);
            this.Pnl_filter_price.Location = new System.Drawing.Point(1, 0);
            this.Pnl_filter_price.Name = "Pnl_filter_price";
            this.Pnl_filter_price.Size = new System.Drawing.Size(244, 157);
            this.Pnl_filter_price.TabIndex = 5;
            this.Pnl_filter_price.Visible = false;
            // 
            // Lbl_price_between
            // 
            this.Lbl_price_between.AutoSize = true;
            this.Lbl_price_between.Location = new System.Drawing.Point(99, 31);
            this.Lbl_price_between.Name = "Lbl_price_between";
            this.Lbl_price_between.Size = new System.Drawing.Size(49, 13);
            this.Lbl_price_between.TabIndex = 0;
            this.Lbl_price_between.Text = "Between";
            // 
            // Lbl_price_and
            // 
            this.Lbl_price_and.AutoSize = true;
            this.Lbl_price_and.Location = new System.Drawing.Point(111, 66);
            this.Lbl_price_and.Name = "Lbl_price_and";
            this.Lbl_price_and.Size = new System.Drawing.Size(25, 13);
            this.Lbl_price_and.TabIndex = 1;
            this.Lbl_price_and.Text = "and";
            // 
            // Txt_price_from
            // 
            this.Txt_price_from.Location = new System.Drawing.Point(28, 63);
            this.Txt_price_from.Name = "Txt_price_from";
            this.Txt_price_from.Size = new System.Drawing.Size(66, 20);
            this.Txt_price_from.TabIndex = 2;
            // 
            // Txt_price_to
            // 
            this.Txt_price_to.Location = new System.Drawing.Point(155, 63);
            this.Txt_price_to.Name = "Txt_price_to";
            this.Txt_price_to.Size = new System.Drawing.Size(66, 20);
            this.Txt_price_to.TabIndex = 3;
            // 
            // Btn_price_go
            // 
            this.Btn_price_go.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_price_go.Location = new System.Drawing.Point(90, 108);
            this.Btn_price_go.Name = "Btn_price_go";
            this.Btn_price_go.Size = new System.Drawing.Size(75, 23);
            this.Btn_price_go.TabIndex = 4;
            this.Btn_price_go.Text = "Go";
            this.Btn_price_go.UseVisualStyleBackColor = false;
            this.Btn_price_go.Click += new System.EventHandler(this.Btn_price_go_Click);
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
            this.Tab_welcome.ResumeLayout(false);
            this.Tab_welcome.PerformLayout();
            this.Tab_buy.ResumeLayout(false);
            this.Tab_buy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nbr_amount)).EndInit();
            this.Tab_myAcct.ResumeLayout(false);
            this.Tab_myAcct.PerformLayout();
            this.Pnl_pay.ResumeLayout(false);
            this.Pnl_pay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeSalesDataSet)).EndInit();
            this.Tab_purchases.ResumeLayout(false);
            this.Tab_purchases.PerformLayout();
            this.Pnl_date_filter.ResumeLayout(false);
            this.Pnl_date_filter.PerformLayout();
            this.Pnl_filter_price.ResumeLayout(false);
            this.Pnl_filter_price.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_menu;
        private System.Windows.Forms.TabPage Tab_welcome;
        private System.Windows.Forms.Label Lbl_welcome;
        private System.Windows.Forms.TabPage Tab_buy;
        private StoreSalesDataSet storeSalesDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private StoreSalesDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.ListView Lsv_items;
        private System.Windows.Forms.Button Btn_buy;
        private System.Windows.Forms.Label Lbl_error;
        private System.Windows.Forms.NumericUpDown Nbr_amount;
        private System.Windows.Forms.Label Lbl_purchase_message;
        private System.Windows.Forms.TabPage Tab_myAcct;
        private System.Windows.Forms.Label Lbl_balanceT;
        private System.Windows.Forms.Label Lbl_balance;
        private System.Windows.Forms.Button Btn_pay;
        private System.Windows.Forms.Panel Pnl_pay;
        private System.Windows.Forms.Label Lbl_amount;
        private System.Windows.Forms.TextBox Txt_amount;
        private System.Windows.Forms.Button Btn_final_pay;
        private System.Windows.Forms.Label Lbl_pay_error;
        private System.Windows.Forms.TabPage Tab_purchases;
        private System.Windows.Forms.ListView Lsv_purchases;
        private System.Windows.Forms.ComboBox Cmb_filter;
        private System.Windows.Forms.Panel Pnl_date_filter;
        private System.Windows.Forms.Label Lbl_date_to;
        private System.Windows.Forms.Label Lbl_date_from;
        private System.Windows.Forms.DateTimePicker Dtp_to;
        private System.Windows.Forms.DateTimePicker Dtp_from;
        private System.Windows.Forms.Button Btn_date_go;
        private System.Windows.Forms.Label Lbl_error_filter;
        private System.Windows.Forms.Panel Pnl_filter_price;
        private System.Windows.Forms.Button Btn_price_go;
        private System.Windows.Forms.TextBox Txt_price_to;
        private System.Windows.Forms.TextBox Txt_price_from;
        private System.Windows.Forms.Label Lbl_price_and;
        private System.Windows.Forms.Label Lbl_price_between;
    }
}