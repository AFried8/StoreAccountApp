using System;
using System.Linq;
using System.Windows.Forms;

namespace SemesterProj {
    public partial class Welcome_form : Form {

        DataClasses1DataContext db;
        Account account;
        public Welcome_form() {
            InitializeComponent();
            db = new DataClasses1DataContext();
        }


        private void lbl_login_Click(object sender, EventArgs e) {
            Pnl_welcome.Visible = false;
            Pnl_login.Visible = true;

        }

        private void Btn_create_account_Click(object sender, EventArgs e) {
            Pnl_welcome.Visible = false;
            Pnl_create_account.Visible = true;
        }

        private void btn_create_account_c_Click(object sender, EventArgs e) {
            if (db.Accounts.Any(a => a.Username == Txt_username_c.Text)) {
                Lbl_error_c.Text = "That username is already taken";
                Txt_username_c.Text = "";
                Txt_password_c.Text = "";
            }
            else {
                Account newAccount = new Account {
                    Username = Txt_username_c.Text,
                    Password = Txt_password_c.Text,
                    Balance = 0
                };
                db.Accounts.InsertOnSubmit(newAccount);
                db.SubmitChanges();
                account = db.Accounts.Where(a => a.Username == Txt_username_c.Text && a.Password == Txt_password_c.Text).First();
                load_next_page();
            }
        }

        private void btn_login_Click(object sender, EventArgs e) {
            
            if(!db.Accounts.Any(a => a.Username == Txt_username_l.Text && a.Password == Txt_password_l.Text)){
                Lbl_error.Text = "Incorrect username and password";
                Txt_password_l.Text = "";
                Txt_username_l.Text = "";
            }
            else {
                account = db.Accounts.Where(a => a.Username == Txt_username_l.Text && a.Password == Txt_password_l.Text).First();
                load_next_page();
            }
        }

        private void Btn_back_c_Click(object sender, EventArgs e) {
            Pnl_create_account.Visible = false;
            Pnl_welcome.Visible = true;
        }

        private void Btn_back_c_Click_1(object sender, EventArgs e) {
            Lbl_error.Text = "";
            Pnl_create_account.Visible=false;
            Pnl_welcome.Visible=true;
            
        }

        private void Btn_back_l_Click(object sender, EventArgs e) {
            Lbl_error_c.Text = "";
            Pnl_login.Visible=false;
            Pnl_welcome.Visible=true;
           
        }


        private void load_next_page() {
            MainMenu mainMenu = new MainMenu(account, db);
            mainMenu.Show();
        }

        private void Welcome_form_FormClosing(object sender, FormClosingEventArgs e) {
            db.Dispose();
        }
    }
}
