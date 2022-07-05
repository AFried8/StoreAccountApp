using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProj {
    public partial class MainMenu : Form {

        Account account;
        DataClasses1DataContext db;

        public MainMenu(Account account, DataClasses1DataContext db) {
            this.account = account;
            this.db = db;
            InitializeComponent();
            Reload();

        }

        private void Reload() {
            PopulateBalance();
            PopulateItems();
            var purchases = db.Purchases.Where(p => p.Account == account.AccountID);
            PopulatePurchases(purchases);
        }

        private void PopulateItems() {

            Lsv_items.Clear();

            Lsv_items.View = View.Details;
            Lsv_items.GridLines = true;
            Lsv_items.FullRowSelect = true;

            //Add column header
            Lsv_items.Columns.Add("Item", 200);
            Lsv_items.Columns.Add("Price", 120);
            Lsv_items.Columns.Add("Available", 120);
            Lsv_items.Columns.Add("Item ID", 80);

            var items = db.Items;
            ListViewItem item;

            foreach (var thisItem in items) {
                String[] arr = new String[4];
                arr[0] = thisItem.Name;
                arr[1] = thisItem.Price.ToString();
                arr[2] = thisItem.Available.ToString();
                arr[3] = thisItem.ItemID.ToString();
                item = new ListViewItem(arr);
                Lsv_items.Items.Add(item);
            }
        }
        private void PopulateBalance() {
            Lbl_balanceT.Text = "$" + account.Balance.ToString();
        }

        private void PopulatePurchases(IQueryable<SemesterProj.Purchase> purchases) {
            Lsv_purchases.Clear();

            Lsv_purchases.View = View.Details;
            Lsv_purchases.GridLines = true;
            Lsv_purchases.FullRowSelect = true;

            //Add column header
            Lsv_purchases.Columns.Add("Item", 150);
            Lsv_purchases.Columns.Add("Quantity", 80);
            Lsv_purchases.Columns.Add("Total", 100);
            Lsv_purchases.Columns.Add("Date", 110);

            ListViewItem purchase;

            foreach (var thisPurchase in purchases) {
                var item = db.Items.Where(a => a.ItemID == thisPurchase.Item).FirstOrDefault();

                String[] arr = new String[4];
                arr[0] = item.Name;
                arr[1] = thisPurchase.Quantity.ToString();
                arr[2] = thisPurchase.Total.ToString();
                arr[3] = thisPurchase.Date.ToShortDateString();
                purchase = new ListViewItem(arr);
                Lsv_purchases.Items.Add(purchase);
            }
        }
        private void Btn_buy_Click(object sender, EventArgs e) {
            if (Lsv_items.SelectedItems.Count <= 0) {
                Lbl_error.Text = "Please select an item to buy";
            }
            else {
                ListViewItem selectedItem = Lsv_items.SelectedItems[0];

                String name = selectedItem.SubItems[0].Text;
                Decimal price = Convert.ToDecimal(selectedItem.SubItems[1].Text);
                int available = Convert.ToInt32(selectedItem.SubItems[2].Text);
                int id = Convert.ToInt32(selectedItem.SubItems[3].Text);

                int quantity = (int)Nbr_amount.Value;

                if (available <= 0) {
                    Lbl_error.Text = name + " is not available";
                }
                else if(quantity < 1 || quantity > available) {
                    Lbl_error.Text = "Please choose a valid quantity";
                }
                else if(account.Balance + quantity * price > 1000) {
                    Lbl_error.Text = "The max credit is " + 1000 +
                                        "\n Your current balance is " + account.Balance +
                                        "\n which is too high" +
                                        "\n to complete this purchase";
                }
                else {
                    Purchase purchase = new Purchase {
                        Account = account.AccountID,
                        Item = id,
                        Quantity = quantity,
                        Total = price * quantity
                    };

                    account.Balance = account.Balance + (quantity * price);
                    Item thisItem = db.Items.Where(i => i.ItemID == id).FirstOrDefault();
                    thisItem.Available = thisItem.Available - quantity;

                    db.Purchases.InsertOnSubmit(purchase);
                    db.SubmitChanges();

                    Lbl_error.Text = "";
                    String pluralInsert = quantity > 1 ? quantity.ToString() + " " : "a ";
                    String pluralInsert2 = quantity > 1 ? "s": "";
                    Lbl_purchase_message.Text = ("Congratulations, you purchased " + pluralInsert + name + pluralInsert2);
                    Reload();
                }
            }
        }

        


        private void Btn_pay_Click(object sender, EventArgs e) {
            Pnl_pay.Visible = true;
        }

        private void Btn_final_pay_Click(object sender, EventArgs e) {
            int amount;
            if (Int32.TryParse(Txt_amount.Text, out amount)) {
                if (amount <= 0) {
                    Lbl_pay_error.Text = "Please enter a valid amount";
                }
                else {
                    account.Balance = account.Balance - amount;
                    Txt_amount.Text = "";
                    Lbl_pay_error.Text = "";
                    PopulateBalance();
                }
            }
            else {
                Lbl_pay_error.Text = "Please enter a number";
            }
        }

        private void Cmb_filter_SelectedIndexChanged(object sender, EventArgs e) {

            if (Cmb_filter.SelectedIndex == 0) {
                Pnl_date_filter.Visible = true;
            }
            if(Cmb_filter.SelectedIndex == 1) {
                Pnl_filter_price.Visible = true;
            }
        }

        private void Btn_date_go_Click(object sender, EventArgs e) {
            if(Dtp_from.Value > Dtp_to.Value) {
                Lbl_error_filter.Text = "From date must be before to date";
            }
            else {
                Lbl_error_filter.Text = "";
                var dateFilteredPurchases = db.Purchases.Where(p => p.Account == account.AccountID);
                dateFilteredPurchases = dateFilteredPurchases.Where(p => p.Date >= Dtp_from.Value && p.Date <= Dtp_to.Value); 
                PopulatePurchases(dateFilteredPurchases);

            }
        }

        private void Btn_price_go_Click(object sender, EventArgs e) {
            Decimal from, to;
            if (Decimal.TryParse(Txt_price_from.Text, out from) && Decimal.TryParse(Txt_price_to.Text, out to)) {
                if (from > to) {
                    Lbl_error_filter.Text = "Starting number must be lower than ending number";
                }
                else {
                    var priceFilteredPurchases = db.Purchases.Where(p => p.Account == account.AccountID);
                    priceFilteredPurchases = priceFilteredPurchases.Where(p => p.Total >= from && p.Total <= to);
                    PopulatePurchases(priceFilteredPurchases);
                    Lbl_error_filter.Text = "";
                }
            }
            else {
                Lbl_error_filter.Text = "Please enter a number";
            }
        }
    }
}
