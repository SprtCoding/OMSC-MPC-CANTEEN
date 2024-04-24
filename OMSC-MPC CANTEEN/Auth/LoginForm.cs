using OMSC_MPC_CANTEEN.Dashboard;
using OMSC_MPC_CANTEEN.Loaders;
using OMSC_MPC_CANTEEN.UserData.DataSets;
using OMSC_MPC_CANTEEN.UserData.DataSets.ProductsDataSetTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.UserDataSetTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.UserLogsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OMSC_MPC_CANTEEN.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //private bool isUserLogin(bool isLogin)
        //{
        //    // Check if the product already exists in the database
        //    USERS1TableAdapter users = new USERS1TableAdapter();
        //    int count = Convert.ToInt32(users.checkIfLogin(isLogin));
        //    return count > 0;
        //}

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
                USERS1TableAdapter user = new USERS1TableAdapter();
                UserDataSet.USERS1DataTable dt = user.getHashPassword(
                        username
                    );
                if (dt.Rows.Count > 0)
                {
                    string? hashPassword = dt.Rows[0]["Password"].ToString(); // Replace with the actual column name
                    string? salt = dt.Rows[0]["Salt"].ToString();
                    string pass = HashPassword(password, salt);

                    if (pass == hashPassword)
                    {
                        string newUID = Guid.NewGuid().ToString();
                        DateTime currentDate = DateTime.Now;

                        // Format time as "10:00 am"
                        string formattedTime = currentDate.ToString("hh:mm tt");

                        // Format date as "Jan 20, 2023"
                        string formattedDate = currentDate.ToString("MMM dd, yyyy");
                        DateTime parsedTime = DateTime.ParseExact(formattedTime, "hh:mm tt", CultureInfo.InvariantCulture);
                        DateTime parsedDate = DateTime.ParseExact(formattedDate, "MMM dd, yyyy", CultureInfo.InvariantCulture);

                        UserLogsTableAdapter userAdapter = new UserLogsTableAdapter();
                        USERS1TableAdapter userTAdapter = new USERS1TableAdapter();

                        userTAdapter.setLogs(
                                true,
                                formattedTime,
                                "",
                                formattedDate,
                                "",
                                username
                            );

                        userAdapter.setLogs(
                                newUID,
                                username,
                                true,
                                formattedTime,
                                "",
                                formattedDate
                            );

                        Dashboard.Dashboard dashboard = new Dashboard.Dashboard(username, newUID);
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
