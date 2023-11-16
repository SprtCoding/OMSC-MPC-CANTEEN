using OMSC_MPC_CANTEEN.Dashboard;
using OMSC_MPC_CANTEEN.Loaders;
using OMSC_MPC_CANTEEN.UserData.DataSets;
using OMSC_MPC_CANTEEN.UserData.DataSets.UserDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMSC_MPC_CANTEEN.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        // Hash a password using SHA-256
        public string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        // Generate a random salt
        public string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // Save hashed password and salt to the database
        public void LoginUsernameAndPassword(string username, string password)
        {
            try
            {
                // Save username, hashedPassword, and salt to the database
                // ... your database code here ...
                USERSTableAdapter user = new USERSTableAdapter();
                UserDataSet.USERSDataTable dt = user.getHashPassword(
                        username
                    );
                if (dt.Rows.Count > 0)
                {
                    string? hashPassword = dt.Rows[0]["Password"].ToString(); // Replace with the actual column name
                    string? salt = dt.Rows[0]["Salt"].ToString();
                    string pass = HashPassword(password, salt);

                    if (pass == hashPassword)
                    {
                        MessageBox.Show("Login Successfully.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dashboard.Dashboard dashboard = new Dashboard.Dashboard(username);
                        dashboard.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Username is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            ResgisterUser reg = new ResgisterUser();
            reg.Show();
            Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_tb.Text;
            string password = password_tb.Text;
            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password_tb.Focus();
                return;
            }
            else
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                LoginUsernameAndPassword(username, password);
            }
        }

        private void show_pass_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass_cb.Checked)
            {
                password_tb.isPassword = false;
            }
            else
            {
                password_tb.isPassword = true;
            }
        }

        private void password_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = username_tb.Text;
                string password = password_tb.Text;
                if (String.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    username_tb.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter your password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    password_tb.Focus();
                    return;
                }
                else
                {
                    using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                    {
                        frm_wait.ShowDialog(this);
                    }
                    LoginUsernameAndPassword(username, password);
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
