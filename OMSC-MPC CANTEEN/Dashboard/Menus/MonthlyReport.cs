using OMSC_MPC_CANTEEN.UserData.DataSets.DailySalesDataSetTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.ProductsDataSetTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets;
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
using DGVPrinterHelper;
using OMSC_MPC_CANTEEN.UserData.DataSets.InvProductTableAdapters;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    public partial class MonthlyReport : Form
    {
        private string? month_selected;
        private bool? isActive = false;

        public MonthlyReport()
        {
            InitializeComponent();
            year_select_cbx.SelectedIndex = 0;
        }

        public void loadData(string year, string month)
        {
            MONTHLY_REPORT_DTG.DataSource = null;

            InventoryProductsTableAdapter pr = new InventoryProductsTableAdapter();
            // Retrieve the updated data from the database
            InvProduct.InventoryProductsDataTable dt = pr.GetMonthlyReport(year, month);
            MONTHLY_REPORT_DTG.DataSource = dt;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Description");
            filteredTable.Columns.Add("Total Inventory");
            filteredTable.Columns.Add("Inventory End");
            filteredTable.Columns.Add("Quantity Sold");
            filteredTable.Columns.Add("Unit Price");
            filteredTable.Columns.Add("Cash Sales");

            // Populate the filtered DataTable with the selected columns from the original DataTable
            foreach (InvProduct.InventoryProductsRow row in dt.Rows)
            {
                // Fetch the quantity sold for the current item from the "DailySales" table
                DailySalesTableAdapter dailySales = new DailySalesTableAdapter();

                double cashSales = double.Parse(dailySales.getCashSales(row.Item).GetValueOrDefault().ToString());

                double cashSalesMonth = double.Parse(dailySales.getTotalSalesAll(month).GetValueOrDefault().ToString());

                total_sales_lbl.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", cashSalesMonth);

                if (row.QuantitySold != 0)
                {
                    filteredTable.Rows.Add(row.Item, row.TotalStocks, row.CurrentStocks, row.QuantitySold, string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price), string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", cashSales));
                }

            }

            MONTHLY_REPORT_DTG.DataSource = filteredTable;

            // Set the column headers
            MONTHLY_REPORT_DTG.Columns[0].HeaderText = "Description";
            MONTHLY_REPORT_DTG.Columns[1].HeaderText = "Total Inventory";
            MONTHLY_REPORT_DTG.Columns[2].HeaderText = "Inventory End";
            MONTHLY_REPORT_DTG.Columns[3].HeaderText = "Quantity Sold";
            MONTHLY_REPORT_DTG.Columns[4].HeaderText = "Unit Price";
            MONTHLY_REPORT_DTG.Columns[5].HeaderText = "Cash Sales";

            // Set the column widths
            MONTHLY_REPORT_DTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MONTHLY_REPORT_DTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MONTHLY_REPORT_DTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MONTHLY_REPORT_DTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MONTHLY_REPORT_DTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MONTHLY_REPORT_DTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void loadAllData()
        {
            MONTHLY_REPORT_DTG.DataSource = null;

            InventoryProductsTableAdapter pr = new InventoryProductsTableAdapter();
            // Retrieve the updated data from the database
            InvProduct.InventoryProductsDataTable dt = pr.GetData();
            MONTHLY_REPORT_DTG.DataSource = dt;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Description");
            filteredTable.Columns.Add("Total Inventory");
            filteredTable.Columns.Add("Inventory End");
            filteredTable.Columns.Add("Quantity Sold");
            filteredTable.Columns.Add("Unit Price");
            filteredTable.Columns.Add("Cash Sales");

            // Populate the filtered DataTable with the selected columns from the original DataTable
            foreach (InvProduct.InventoryProductsRow row in dt.Rows)
            {
                // Fetch the quantity sold for the current item from the "DailySales" table
                DailySalesTableAdapter dailySales = new DailySalesTableAdapter();

                double cashSales = double.Parse(dailySales.getCashSales(row.Item).GetValueOrDefault().ToString());

                double totalCashSales = double.Parse(dailySales.getAllSales().GetValueOrDefault().ToString());

                total_sales_lbl.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);

                if (row.QuantitySold != 0)
                {
                    filteredTable.Rows.Add(row.Item, row.TotalStocks, row.CurrentStocks, row.QuantitySold, string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price), string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", cashSales));
                }
            }

            MONTHLY_REPORT_DTG.DataSource = filteredTable;

            // Set the column headers
            MONTHLY_REPORT_DTG.Columns[0].HeaderText = "Description";
            MONTHLY_REPORT_DTG.Columns[1].HeaderText = "Total Inventory";
            MONTHLY_REPORT_DTG.Columns[2].HeaderText = "Inventory End";
            MONTHLY_REPORT_DTG.Columns[3].HeaderText = "Quantity Sold";
            MONTHLY_REPORT_DTG.Columns[4].HeaderText = "Unit Price";
            MONTHLY_REPORT_DTG.Columns[5].HeaderText = "Cash Sales";

            // Set the column widths
            MONTHLY_REPORT_DTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MONTHLY_REPORT_DTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MONTHLY_REPORT_DTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MONTHLY_REPORT_DTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MONTHLY_REPORT_DTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MONTHLY_REPORT_DTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void year_select_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isActive == true)
            {
                loadData(year_select_cbx.Text, month_selected);
            }
            else
            {
                if (year_select_cbx.SelectedIndex == 0)
                {
                    loadAllData();
                }
            }
        }

        private void jan_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "January";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void feb_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "February";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void sep_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "September";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void oct_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "October";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Monthly Report";
            printer.SubTitle = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "List of Products";
            printer.FooterSpacing = 15;
            // Adjust column widths to fit on one page
            printer.PageSettings.Landscape = false; // Set to true if you want landscape orientation

            foreach (DataGridViewColumn col in MONTHLY_REPORT_DTG.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            printer.PrintDataGridView(MONTHLY_REPORT_DTG);
        }

        private void print_btn_MouseHover(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(print_btn, "Print Document.");
        }

        private void mar_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "March";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void apr_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "April";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void may_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "May";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void june_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "June";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void july_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "July";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void aug_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "August";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void nov_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "November";
            loadData(year_select_cbx.Text, month_selected);
        }

        private void dec_btn_Click(object sender, EventArgs e)
        {
            isActive = true;
            month_selected = "December";
            loadData(year_select_cbx.Text, month_selected);
        }
    }
}
