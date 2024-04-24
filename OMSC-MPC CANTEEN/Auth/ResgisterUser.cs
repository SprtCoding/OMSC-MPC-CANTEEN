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
using OMSC_MPC_CANTEEN.Loaders;
using OMSC_MPC_CANTEEN.UserData.DataSets;
using OMSC_MPC_CANTEEN.UserData.DataSets.UserDataSetTableAdapters;

namespace OMSC_MPC_CANTEEN.Auth
{
    public partial class ResgisterUser : Form
    {
        public ResgisterUser()
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
        public void SavePasswordToDatabase(string username, string password, string name)
        {
            string salt = GenerateSalt();
            string hashedPassword = HashPassword(password, salt);
            // Get the current date and time
            DateTime currentDateAndTime = DateTime.Now;

            try
            {
                // Save username, hashedPassword, and salt to the database
                // ... your database code here ...
                USERS1TableAdapter user = new USERS1TableAdapter();
                user.setUsers(
                    username,
                    username,
                    hashedPassword,
                    salt,
                    name,
                    currentDateAndTime.ToLongDateString(),
                    currentDateAndTime.ToLongTimeString(),
                    false,
                    "",
                    "",
                    "",
                    "");
                MessageBox.Show("Account Created Successfully.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm login = new LoginForm();
                login.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string name = name_tb.Text;
            string username = username_tb.Text;
            string password = password_tb.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                name_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(username))
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
                SavePasswordToDatabase(username, password, name);
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Hide();
        }

        private void password_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name = name_tb.Text;
                string username = username_tb.Text;
                string password = password_tb.Text;

                if (String.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter your name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    name_tb.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(username))
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
                    SavePasswordToDatabase(username, password, name);
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
