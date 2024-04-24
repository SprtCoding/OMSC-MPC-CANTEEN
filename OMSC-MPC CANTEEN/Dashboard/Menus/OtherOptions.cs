using OMSC_MPC_CANTEEN.Auth;
using OMSC_MPC_CANTEEN.Loaders;
using OMSC_MPC_CANTEEN.UserData.DataSets;
using OMSC_MPC_CANTEEN.UserData.DataSets.UserDataSetTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.UserLogsDataSetTableAdapters;
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
using System.Xml.Linq;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    public partial class OtherOptions : Form
    {
        private string? username = Dashboard.username_id;
        public OtherOptions()
        {
            InitializeComponent();
            getTimeLogin();
            getUserData();
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

        private void getUserData()
        {
            USERS1TableAdapter adapter = new USERS1TableAdapter();
            UserDataSet.USERS1DataTable dt = adapter.GetUserByID(username);

            if (dt.Rows.Count > 0)
            {
                string? username = dt.Rows[0]["Username"].ToString();
                //string? hashPassword = dt.Rows[0]["Password"].ToString();
                //string? salt = dt.Rows[0]["Salt"].ToString();

                username_tb.Text = username;
            }
            else
            {
                MessageBox.Show("No Data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void getTimeLogin()
        {
            if (username != null)
            {
                Login_time_dtg.DataSource = null;

                UserLogsTableAdapter userLogs = new UserLogsTableAdapter();
                UserLogsDataSet.UserLogsDataTable dt = userLogs.getLogsByUserId(username);

                if (dt.Rows.Count > 0)
                {
                    Login_time_dtg.DataSource = dt;

                    // Create a new DataTable with only the desired columns
                    DataTable filteredTable = new DataTable();
                    filteredTable.Columns.Add("ID");
                    filteredTable.Columns.Add("Username");
                    filteredTable.Columns.Add("Login Time");
                    filteredTable.Columns.Add("Logout Time");
                    filteredTable.Columns.Add("Date");

                    // Populate the filtered DataTable with the selected columns from the original DataTable
                    foreach (UserLogsDataSet.UserLogsRow row in dt.Rows)
                    {
                        filteredTable.Rows.Add(
                                row.ID,
                                row.UserID,
                                row.TimeLogin,
                                row.TimeLogout,
                                row.Date
                            );
                    }

                    Login_time_dtg.DataSource = filteredTable;

                    // Set the column headers
                    Login_time_dtg.Columns[0].HeaderText = "ID";
                    Login_time_dtg.Columns[1].HeaderText = "Username";
                    Login_time_dtg.Columns[2].HeaderText = "Login Time";
                    Login_time_dtg.Columns[3].HeaderText = "Logout Time";
                    Login_time_dtg.Columns[4].HeaderText = "Login Date";

                    // Set the column widths
                    Login_time_dtg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    Login_time_dtg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    Login_time_dtg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    Login_time_dtg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    Login_time_dtg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    Login_time_dtg.Columns[0].Visible = false;
                }
            }
        }

        private void change_pass_btn_Click(object sender, EventArgs e)
        {
            USERS1TableAdapter adapter = new USERS1TableAdapter();
            UserDataSet.USERS1DataTable dt = adapter.GetUserByID(username);

            if (dt.Rows.Count > 0)
            {
                string? userName = dt.Rows[0]["Username"].ToString();

                if (username_tb.Text != userName)
                {
                    MessageBox.Show("You cannot change password! Save your username first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pass_panel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No Data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void old_pass_tb_TextChanged(object sender, EventArgs e)
        {
            USERS1TableAdapter adapter = new USERS1TableAdapter();
            UserDataSet.USERS1DataTable dt = adapter.GetUserByID(username);

            if (dt.Rows.Count > 0)
            {
                string? hashPassword = dt.Rows[0]["Password"].ToString();
                string? salt = dt.Rows[0]["Salt"].ToString();
                string old_pass = HashPassword(old_pass_tb.Text, salt);

                if (old_pass == hashPassword)
                {
                    check_pic.Visible = true;
                    check_pic.Image = Properties.Resources.badge_check;
                    new_pass_tb.Enabled = true;
                    save_btn.Enabled = true;
                }
                else
                {
                    check_pic.Visible = false;
                    check_pic.Image = Properties.Resources.cross__2_;
                    check_pic.Visible = true;
                    new_pass_tb.Enabled = false;
                    save_btn.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No Data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            if (String.IsNullOrEmpty(new_pass_tb.Text))
            {
                MessageBox.Show("Please enter a password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                new_pass_tb.Focus();
                return;
            }
            else
            {
                string salt = GenerateSalt();
                string hashedPassword = HashPassword(new_pass_tb.Text, salt);
                try
                {
                    // Save hashedPassword, and salt to the database
                    // ... your database code here ...
                    USERS1TableAdapter user = new USERS1TableAdapter();
                    user.updatePasswordById(
                    hashedPassword,
                        salt,
                        username);
                    MessageBox.Show("Password changed.", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pass_panel.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            username_tb.Enabled = true;
            username_tb.Focus();
        }

        private void username_tb_TextChanged(object sender, EventArgs e)
        {
            USERS1TableAdapter adapter = new USERS1TableAdapter();
            UserDataSet.USERS1DataTable dt = adapter.GetUserByID(username);

            if (dt.Rows.Count > 0)
            {
                string? username = dt.Rows[0]["Username"].ToString();
                //string? hashPassword = dt.Rows[0]["Password"].ToString();
                //string? salt = dt.Rows[0]["Salt"].ToString();

                if (username_tb.Text == username)
                {
                    save_username_btn.Enabled = false;
                    save_username_btn.Visible = false;
                }
                else
                {
                    save_username_btn.Enabled = true;
                    save_username_btn.Visible = true;
                    if (String.IsNullOrEmpty(username_tb.Text))
                    {
                        save_username_btn.Enabled = false;
                        save_username_btn.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("No Data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void save_username_btn_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }

            USERS1TableAdapter adapter = new USERS1TableAdapter();
            adapter.updateUsernameById(username_tb.Text, username_tb.Text, username);
            username = newID(username_tb.Text);
            MessageBox.Show("Username updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            save_username_btn.Visible = false;
            username_tb.Enabled = false;
        }

        public string newID(string id)
        {
            return id;
        }
    }
}
