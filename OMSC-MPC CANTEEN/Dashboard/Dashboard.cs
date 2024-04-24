using Bunifu.Framework.UI;
using Microsoft.VisualBasic.Logging;
using OMSC_MPC_CANTEEN.Auth;
using OMSC_MPC_CANTEEN.Dashboard.Menus;
using OMSC_MPC_CANTEEN.UserData.DataSets.UserDataSetTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.UserLogsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OMSC_MPC_CANTEEN.Dashboard
{
    public partial class Dashboard : Form
    {
        bool sidebarExpand;
        private BunifuFlatButton? currentBtn;
        private Color activeColor = Color.FromArgb(60, 64, 98);
        private Color originalColor = Color.FromArgb(248, 195, 23);

        public static string? username_id, logsId;

        public Dashboard(string username, string Id)
        {
            InitializeComponent();
            //nav_menu_panel.Bounds.Intersect(leftBorderBtn.Bounds);
            //nav_menu_panel.Controls.Add(leftBorderBtn);

            username_id = username;
            logsId = Id;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
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
                    false,
                    "",
                    formattedTime,
                    "",
                    formattedDate,
                    username_id
                );

            userAdapter.updateLogs(
                    false,
                    formattedTime,
                    formattedDate,
                    logsId
                );
            Application.Exit();
        }

        private Form? activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            main_panel.Controls.Add(childForm);
            main_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void activeButton(BunifuFlatButton btn)
        {
            if (currentBtn != null)
            {
                currentBtn.Normalcolor = originalColor;
            }
            currentBtn = btn;

            currentBtn.Normalcolor = activeColor;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            activeButton(logout_btn);
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
                        false,
                        "",
                        formattedTime,
                        "",
                        formattedDate,
                        username_id
                    );

                userAdapter.updateLogs(
                        false,
                        formattedTime,
                        formattedDate,
                        logsId
                    );

                LoginForm login = new LoginForm();
                login.Show();
                Hide();
            }
        }

        private void sidebar_timer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                nav_panel.Width -= 10;
                if (nav_panel.Width == nav_panel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebar_timer.Stop();
                }
            }
            else
            {
                nav_panel.Width += 10;
                if (nav_panel.Width == nav_panel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebar_timer.Stop();
                }
            }
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            sidebar_timer.Start();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Text = dashboard_btn.Text;
            openChildForm(new HomeDashboard());
            activeButton(dashboard_btn);
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            Text = dashboard_btn.Text;
            openChildForm(new HomeDashboard());
            activeButton(dashboard_btn);
        }

        private void daily_sales_btn_Click(object sender, EventArgs e)
        {
            Text = daily_sales_btn.Text;
            openChildForm(new DailySales());
            activeButton(daily_sales_btn);
        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            Text = inventory_btn.Text;
            openChildForm(new InventoryForm());
            activeButton(inventory_btn);
        }

        private void monthly_report_btn_Click(object sender, EventArgs e)
        {
            Text = monthly_report_btn.Text;
            openChildForm(new MonthlyReport());
            activeButton(monthly_report_btn);
        }

        private void stocks_btn_Click(object sender, EventArgs e)
        {
            Text = stocks_btn.Text;
            openChildForm(new Stocks());
            activeButton(stocks_btn);
        }

        private void purchase_btn_Click(object sender, EventArgs e)
        {
            Text = purchase_btn.Text;
            openChildForm(new Purchases());
            activeButton(purchase_btn);
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            Text = settings_btn.Text;
            activeButton(settings_btn);
            openChildForm(new OtherOptions());
        }
    }
}
