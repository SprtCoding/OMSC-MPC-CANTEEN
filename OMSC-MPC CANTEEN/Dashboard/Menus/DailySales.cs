using DGVPrinterHelper;
using OMSC_MPC_CANTEEN.Dashboard.Menus.DailySalesForms;
using OMSC_MPC_CANTEEN.Dashboard.Menus.InventoryForms;
using OMSC_MPC_CANTEEN.UserData.DataSets;
using OMSC_MPC_CANTEEN.UserData.DataSets.DailySalesDataSetTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.InvProductTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.ProductsDataSetTableAdapters;
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

namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    public partial class DailySales : Form
    {
        private string? _userID = Dashboard.username_id;

        public DailySales()
        {
            InitializeComponent();
            loadData();
            getTotalSale();
            //loadInventoryData();
        }

        private void date_time_timer_Tick(object sender, EventArgs e)
        {
            date_now.Text = DateTime.Now.ToLongDateString();
            time_now.Text = DateTime.Now.ToLongTimeString();
        }

        private void DailySales_Load(object sender, EventArgs e)
        {
            date_time_timer.Start();
        }

        public void loadData()
        {
            DAILY_SALES_DTG.DataSource = null;

            DailySalesTableAdapter pr = new DailySalesTableAdapter();
            // Retrieve the updated data from the database
            DailySalesDataSet.DailySalesDataTable dt = pr.GetData(_userID);
            DAILY_SALES_DTG.DataSource = dt;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("ID");
            filteredTable.Columns.Add("Item");
            filteredTable.Columns.Add("Price");
            filteredTable.Columns.Add("Quantity");
            filteredTable.Columns.Add("Total Sales");
            filteredTable.Columns.Add("Date");
            filteredTable.Columns.Add("Delete", typeof(Image));

            // Populate the filtered DataTable with the selected columns from the original DataTable
            foreach (DailySalesDataSet.DailySalesRow row in dt.Rows)
            {
                filteredTable.Rows.Add(row.ID, row.Item, string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price), row.Quantity, string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.TotalSales), row.DateOfSales, Properties.Resources.trash);
            }

            DAILY_SALES_DTG.DataSource = filteredTable;

            // Set the column headers
            DAILY_SALES_DTG.Columns[0].HeaderText = "ID";
            DAILY_SALES_DTG.Columns[1].HeaderText = "Item";
            DAILY_SALES_DTG.Columns[2].HeaderText = "Price";
            DAILY_SALES_DTG.Columns[3].HeaderText = "Quantity";
            DAILY_SALES_DTG.Columns[4].HeaderText = "Total Sales";
            DAILY_SALES_DTG.Columns[5].HeaderText = "Date";
            DAILY_SALES_DTG.Columns[6].HeaderText = "Action";

            // Set the column widths
            DAILY_SALES_DTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAILY_SALES_DTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DAILY_SALES_DTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAILY_SALES_DTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAILY_SALES_DTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAILY_SALES_DTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DAILY_SALES_DTG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DAILY_SALES_DTG.Columns["ID"].Visible = false;

            // Set the padding and size of the icon
            DAILY_SALES_DTG.Columns[6].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            DAILY_SALES_DTG.Columns[6].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            DAILY_SALES_DTG.Columns[6].Width = 30; // Adjust the width of the icon column
        }

        public void loadInventoryData()
        {
            INVENTORY_DTG.DataSource = null;

            ProductsTableAdapter pr = new ProductsTableAdapter();
            // Retrieve the updated data from the database
            ProductsDataSet.ProductsDataTable dt = pr.GetData();
            INVENTORY_DTG.DataSource = dt;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("ID");
            filteredTable.Columns.Add("Item");
            filteredTable.Columns.Add("Category");
            filteredTable.Columns.Add("Current Stocks");
            filteredTable.Columns.Add("Price");
            filteredTable.Columns.Add("Expiration Date");
            filteredTable.Columns.Add("Delete", typeof(Image));

            // Populate the filtered DataTable with the selected columns from the original DataTable
            foreach (ProductsDataSet.ProductsRow row in dt.Rows)
            {
                filteredTable.Rows.Add(row.ID, row.Item, row.Category, row.CurrentStocks, string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price), row.ExpirationDate.ToLongDateString(), Properties.Resources.delete);
            }

            INVENTORY_DTG.DataSource = filteredTable;

            // Set the column headers
            INVENTORY_DTG.Columns[0].HeaderText = "ID";
            INVENTORY_DTG.Columns[1].HeaderText = "Item";
            INVENTORY_DTG.Columns[2].HeaderText = "Category";
            INVENTORY_DTG.Columns[3].HeaderText = "Current Stocks";
            INVENTORY_DTG.Columns[4].HeaderText = "Price";
            INVENTORY_DTG.Columns[5].HeaderText = "Expiration Date";
            INVENTORY_DTG.Columns[6].HeaderText = "Action";

            // Set the column widths
            INVENTORY_DTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            INVENTORY_DTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            INVENTORY_DTG.Columns["ID"].Visible = false;

            // Set the padding and size of the icon
            INVENTORY_DTG.Columns[6].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            INVENTORY_DTG.Columns[6].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            INVENTORY_DTG.Columns[6].Width = 30; // Adjust the width of the icon column
        }

        private void getTotalSale()
        {
            // Fetch the quantity sold for the current item from the "DailySales" table
            DailySalesTableAdapter dailySales = new DailySalesTableAdapter();

            double totalCashSales = double.Parse(dailySales.getAllSales().GetValueOrDefault().ToString());

            total_sales_lbl.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);
        }

        private void add_new_btn_Click(object sender, EventArgs e)
        {
            AddDailySales dailySales = new AddDailySales(DAILY_SALES_DTG, total_sales_lbl);
            dailySales.ShowDialog(this);
        }

        private void print_btn_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(print_btn, "Print");
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Daily Sales";
            printer.SubTitle = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "List of Daily Sales";
            printer.FooterSpacing = 15;
            // Adjust column widths to fit on one page, excluding the last column
            printer.PageSettings.Landscape = false; // Set to true if you want landscape orientation

            for (int i = 0; i < DAILY_SALES_DTG.Columns.Count - 1; i++)
            {
                DAILY_SALES_DTG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            printer.PrintDataGridView(DAILY_SALES_DTG);
        }

        private void DAILY_SALES_DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = DAILY_SALES_DTG.Rows[e.RowIndex];
                int id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
                string? item = selectedRow.Cells["Item"].Value.ToString();

                if (DAILY_SALES_DTG.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + item + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DailySalesTableAdapter dailySales = new DailySalesTableAdapter();
                        dailySales.DeleteDailySale(id);
                        loadData();
                    }
                }
            }
        }
    }
}
