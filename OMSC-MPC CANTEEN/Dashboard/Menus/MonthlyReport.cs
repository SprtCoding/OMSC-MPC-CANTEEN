﻿using OMSC_MPC_CANTEEN.UserData.DataSets.ProductsDataSetTableAdapters;
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
using OMSC_MPC_CANTEEN.UserData.DataSets.DailySalesReportDataSetTableAdapters;
using OMSC_MPC_CANTEEN.Dashboard.Menus.PrintData;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    public partial class MonthlyReport : Form
    {
        private string? month_selected;
        private bool isActive = false;

        public MonthlyReport()
        {
            InitializeComponent();
            populateYear();
        }

        private void populateYear()
        {
            year_select_cbx.Items.Add("All");

            int currentYear = DateTime.Now.Year;

            for(int year = 2000; year <= currentYear; year++)
            {
                year_select_cbx.Items.Add(year.ToString());
            }

            year_select_cbx.SelectedIndex = 0;
        }

        public void loadData(string year, string month)
        {
            MONTHLY_REPORT_DTG.DataSource = null;

            DailySalesReport1TableAdapter adapter = new DailySalesReport1TableAdapter();
            DailySalesReportDataSet.DailySalesReport1DataTable myDt = adapter.GetSalesReportByMonth(year, month);

            if (myDt.Rows.Count > 0)
            {
                MONTHLY_REPORT_DTG.DataSource = myDt;

                // Create a new DataTable with only the desired columns
                DataTable filteredTable = new DataTable();
                filteredTable.Columns.Add("ID");
                filteredTable.Columns.Add("Description");
                filteredTable.Columns.Add("Total Inventory");
                filteredTable.Columns.Add("Inventory End");
                filteredTable.Columns.Add("Quantity Sold");
                filteredTable.Columns.Add("Unit Price");
                filteredTable.Columns.Add("Cash Sales");
                filteredTable.Columns.Add("Category");
                filteredTable.Columns.Add("Profit");

                // Populate the filtered DataTable with the selected columns from the original DataTable
                foreach (DailySalesReportDataSet.DailySalesReport1Row row in myDt.Rows)
                {
                    filteredTable.Rows.Add(
                            row.ID,
                            row.Item,
                            row.TotalInventory,
                            row.InventoryEnd,
                            row.QuantitySold,
                            string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.UnitPrice),
                            string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.CashSales),
                            row.Category,
                            string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Profit)
                        );
                }

                if (filteredTable.Rows.Count > 0)
                {
                    MONTHLY_REPORT_DTG.DataSource = filteredTable;

                    // Set the column headers
                    MONTHLY_REPORT_DTG.Columns[0].HeaderText = "ID";
                    MONTHLY_REPORT_DTG.Columns[1].HeaderText = "Description";
                    MONTHLY_REPORT_DTG.Columns[2].HeaderText = "Total Inventory";
                    MONTHLY_REPORT_DTG.Columns[3].HeaderText = "Inventory End";
                    MONTHLY_REPORT_DTG.Columns[4].HeaderText = "Quantity Sold";
                    MONTHLY_REPORT_DTG.Columns[5].HeaderText = "Unit Price";
                    MONTHLY_REPORT_DTG.Columns[6].HeaderText = "Cash Sales";
                    MONTHLY_REPORT_DTG.Columns[7].HeaderText = "Category";
                    MONTHLY_REPORT_DTG.Columns[8].HeaderText = "Profit";

                    // Set the column widths
                    MONTHLY_REPORT_DTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    MONTHLY_REPORT_DTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    MONTHLY_REPORT_DTG.Columns[0].Visible = false;

                    no_data.Visible = false;
                    getTotalSaleByMonth(year, month);
                }
                else
                {
                    no_data.Visible = true;
                    total_sales_lbl.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", 0);
                }
            }
            else
            {
                no_data.Visible = true;
                total_sales_lbl.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", 0);
            }
        }

        public void loadAllData()
        {
            MONTHLY_REPORT_DTG.DataSource = null;

            DailySalesReport1TableAdapter adapter = new DailySalesReport1TableAdapter();
            DailySalesReportDataSet.DailySalesReport1DataTable myDt = adapter.GetData();

            MONTHLY_REPORT_DTG.DataSource = myDt;

            if (myDt.Rows.Count > 0)
            {
                // Create a new DataTable with only the desired columns
                DataTable filteredTable = new DataTable();
                filteredTable.Columns.Add("ID");
                filteredTable.Columns.Add("Description");
                filteredTable.Columns.Add("Total Inventory");
                filteredTable.Columns.Add("Inventory End");
                filteredTable.Columns.Add("Quantity Sold");
                filteredTable.Columns.Add("Unit Price");
                filteredTable.Columns.Add("Cash Sales");
                filteredTable.Columns.Add("Category");
                filteredTable.Columns.Add("Profit");

                // Populate the filtered DataTable with the selected columns from the original DataTable
                foreach (DailySalesReportDataSet.DailySalesReport1Row row in myDt.Rows)
                {
                    filteredTable.Rows.Add(
                            row.ID,
                            row.Item,
                            row.TotalInventory,
                            row.InventoryEnd,
                            row.QuantitySold,
                            string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.UnitPrice),
                            string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.CashSales),
                            row.Category,
                            string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Profit)
                        );
                }

                if (filteredTable.Rows.Count > 0)
                {
                    MONTHLY_REPORT_DTG.DataSource = filteredTable;

                    // Set the column headers
                    MONTHLY_REPORT_DTG.Columns[0].HeaderText = "ID";
                    MONTHLY_REPORT_DTG.Columns[1].HeaderText = "Description";
                    MONTHLY_REPORT_DTG.Columns[2].HeaderText = "Total Inventory";
                    MONTHLY_REPORT_DTG.Columns[3].HeaderText = "Inventory End";
                    MONTHLY_REPORT_DTG.Columns[4].HeaderText = "Quantity Sold";
                    MONTHLY_REPORT_DTG.Columns[5].HeaderText = "Unit Price";
                    MONTHLY_REPORT_DTG.Columns[6].HeaderText = "Cash Sales";
                    MONTHLY_REPORT_DTG.Columns[7].HeaderText = "Category";
                    MONTHLY_REPORT_DTG.Columns[8].HeaderText = "Profit";

                    // Set the column widths
                    MONTHLY_REPORT_DTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    MONTHLY_REPORT_DTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MONTHLY_REPORT_DTG.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    MONTHLY_REPORT_DTG.Columns[0].Visible = false;

                    getTotalSale();

                    no_data.Visible = false;
                }
                else
                {
                    no_data.Visible = true;
                    total_sales_lbl.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", 0);
                }
            }
            else
            {
                no_data.Visible = true;
                total_sales_lbl.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", 0);
            }
        }

        private void year_select_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isActive)
            {
                if (year_select_cbx.SelectedItem.ToString().Equals("All"))
                {
                    loadAllData();
                }
                else
                {
                    loadData(year_select_cbx.Text, month_selected);
                }
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
            printer.PageSettings.Landscape = false; // Set to true if you want landscape orientation

            // Calculate the total width of all columns
            int totalWidth = 0;
            foreach (DataGridViewColumn col in MONTHLY_REPORT_DTG.Columns)
            {
                totalWidth += col.Width;
            }

            // Calculate the scaling factor to fit all columns on one page
            float scaleFactor = (printer.PageSettings.PrintableArea.Width - 40) / totalWidth;

            // Adjust column widths and font size
            foreach (DataGridViewColumn col in MONTHLY_REPORT_DTG.Columns)
            {
                col.Width = (int)(col.Width * scaleFactor);
                col.DefaultCellStyle.Font = new Font(MONTHLY_REPORT_DTG.Font.FontFamily, MONTHLY_REPORT_DTG.Font.Size * scaleFactor);
            }

            // Print the DataGridView
            printer.PrintDataGridView(MONTHLY_REPORT_DTG);



            /*PrintPreview print = new PrintPreview(MONTHLY_REPORT_DTG, "", "Monthly Report");
            print.ShowDialog();*/
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

        private void getTotalSale()
        {
            DailySalesReport1TableAdapter adapter = new DailySalesReport1TableAdapter();
            double sales = Convert.ToDouble(adapter.getTotalSales().GetValueOrDefault().ToString());
            total_sales_lbl.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", sales);
        }

        private void getTotalSaleByMonth(string year, string month)
        {
            DailySalesReport1TableAdapter adapter = new DailySalesReport1TableAdapter();
            double sales = Convert.ToDouble(adapter.getTotalSalesByMonth(year, month).GetValueOrDefault().ToString());
            total_sales_lbl.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", sales);
        }
    }
}
