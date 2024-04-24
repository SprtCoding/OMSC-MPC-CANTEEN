using Bunifu.Framework.UI;
using DGVPrinterHelper;
using OMSC_MPC_CANTEEN.Dashboard.Menus.InventoryForms;
using OMSC_MPC_CANTEEN.Dashboard.Menus.PrintData;
using OMSC_MPC_CANTEEN.Loaders;
using OMSC_MPC_CANTEEN.UserData.DataSets;
using OMSC_MPC_CANTEEN.UserData.DataSets.DailySalesReportDataSetTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.InvProductTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.ProductsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using TheArtOfDev.HtmlRenderer.Adapters;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    public partial class DailySales : Form
    {
        private string? _userID = Dashboard.username_id;

        public DailySales()
        {
            InitializeComponent();
            getCategoriesData("Groceries", save_all_groceries);
            getCategoriesData("School Supplies", save_all_school);
            getCategoriesData("Ice Cream", save_all_ice_cream);
            getCategoriesData("Drinks", save_all_drinks);

            getTotalCashSales("Groceries");
            getTotalCashSales("School Supplies");
            getTotalCashSales("Ice Cream");
            getTotalCashSales("Drinks");
            //loadData();
            //getTotalSale();
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

        public void getCategoriesData(string cat, PictureBox saveBtn)
        {
            BunifuCustomDataGrid? dtg = null;

            if (cat.Equals("Groceries"))
            {
                dtg = DAILY_SALES_GROCERIES_DTG;
            }
            else if (cat.Equals("Drinks"))
            {
                dtg = DRINKS_DTG;
            }
            else if (cat.Equals("School Supplies"))
            {
                dtg = SCHOOL_DTG;
            }
            else if (cat.Equals("Ice Cream"))
            {
                dtg = ICE_CREAM_DTG;
            }
            else
            {
                dtg = null;
            }

            if (dtg != null)
            {
                dtg.DataSource = null;

                InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
                InvProduct.InventoryProducts1DataTable dt = adapter.GetDataByCategory(cat);

                if (dt.Rows.Count > 0)
                {
                    dtg.DataSource = dt;
                    // Create a new DataTable with only the desired columns
                    DataTable filteredTable = new DataTable();
                    filteredTable.Columns.Add("ID");
                    filteredTable.Columns.Add("Description");
                    filteredTable.Columns.Add("Inventory End");
                    filteredTable.Columns.Add("Inventory Beg");
                    filteredTable.Columns.Add("Total Inventory");
                    filteredTable.Columns.Add("Inventory End(Now)");
                    filteredTable.Columns.Add("Quantity Sold");
                    filteredTable.Columns.Add("Unit Price");
                    filteredTable.Columns.Add("Cost Price");
                    filteredTable.Columns.Add("Cash Sales");
                    filteredTable.Columns.Add("Warning", typeof(Image));
                    filteredTable.Columns.Add("Delete", typeof(Image));
                    filteredTable.Columns.Add("DateAdded");
                    filteredTable.Columns.Add("DayAdded");
                    filteredTable.Columns.Add("MonthAdded");
                    filteredTable.Columns.Add("YearAdded");
                    filteredTable.Columns.Add("Category");
                    filteredTable.Columns.Add("Profit");

                    // Populate the filtered DataTable with the selected columns from the original DataTable
                    foreach (InvProduct.InventoryProducts1Row row in dt.Rows)
                    {
                        int totalInventory;
                        //int inventoryEndNow = totalInventory - row.QuantitySold;

                        // Check if the inventoryEndNow is from yesterday
                        DateTime currentDate = DateTime.Now;
                        DateTime yesterday = currentDate.AddDays(-1);
                        DateTime inventoryEndNowDate = row.DateAdded; // Assuming there is a Date column in your data
                        bool isYesterday = inventoryEndNowDate.Date == yesterday.Date;

                        //int inventoryEndNow;

                        int inventoryEnd = row.InventoryEndNow;

                        if (isYesterday)
                        {
                            // Set inventoryEndNow to inventoryBeg value if it's from yesterday
                            int newBeg = 0;

                            InventoryProducts1TableAdapter inventoryProducts1TableAdapter = new InventoryProducts1TableAdapter();
                            inventoryProducts1TableAdapter.UpdateInventoryEnd(inventoryEnd, row.ID);
                            inventoryProducts1TableAdapter.UpdateInventoryBeg(newBeg, row.ID);
                            inventoryProducts1TableAdapter.UpdateTotalStocksById(inventoryEnd, row.ID);
                            inventoryProducts1TableAdapter.UpdateQuantitySoldById(0, row.ID);
                            inventoryProducts1TableAdapter.UpdateCashSalesById(0, row.ID);
                            totalInventory = row.InventoryEnd + row.InventoryBeg;
                            //inventoryEndNow = getEndInventory(row.InventoryEndNow, row.QuantitySold);
                        }
                        else
                        {
                            totalInventory = row.InventoryEnd + row.InventoryBeg;
                            //inventoryEndNow = getEndInventory(row.InventoryEndNow, row.QuantitySold);
                        }

                        // Check if currentStocks is below 10
                        if (row.CurrentStocks < 10)
                        {
                            filteredTable.Rows.Add(
                                row.ID,
                                row.Item,
                                row.InventoryEnd,
                                row.InventoryBeg,
                                totalInventory,
                                row.InventoryEndNow,
                                row.QuantitySold,
                                string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}",
                                row.UnitPrice),
                                string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}",
                                row.Price),
                                string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}",
                                row.CashSales),
                                Properties.Resources.warning_small,
                                Properties.Resources.trash,
                                row.DateAdded, row.DaysAdded,
                                row.MonthsAdded,
                                row.YearAdded,
                                row.Category,
                                row.Profit);
                        }
                        else
                        {
                            filteredTable.Rows.Add(
                                row.ID, row.Item,
                                row.InventoryEnd,
                                row.InventoryBeg,
                                totalInventory,
                                row.InventoryEndNow,
                                row.QuantitySold,
                                string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.UnitPrice),
                                string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price),
                                string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.CashSales),
                                Properties.Resources.badge_check,
                                Properties.Resources.trash,
                                row.DateAdded,
                                row.DaysAdded,
                                row.MonthsAdded,
                                row.YearAdded,
                                row.Category,
                                row.Profit);
                        }
                    }

                    if (filteredTable.Rows.Count > 0)
                    {
                        dtg.DataSource = filteredTable;

                        // Set the column headers
                        dtg.Columns[0].HeaderText = "ID";
                        dtg.Columns[1].HeaderText = "Description";
                        dtg.Columns[2].HeaderText = "Inventory End";
                        dtg.Columns[3].HeaderText = "Inventory Beg";
                        dtg.Columns[4].HeaderText = "Total Inventory";
                        dtg.Columns[5].HeaderText = "Inventory End";
                        dtg.Columns[6].HeaderText = "Quantity Sold";
                        dtg.Columns[7].HeaderText = "Unit Price";
                        dtg.Columns[8].HeaderText = "Cost Price";
                        dtg.Columns[9].HeaderText = "Cash Sales";
                        dtg.Columns[10].HeaderText = "Warning";
                        dtg.Columns[11].HeaderText = "Delete";
                        dtg.Columns[12].HeaderText = "Date Added";
                        dtg.Columns[13].HeaderText = "Day Added";
                        dtg.Columns[14].HeaderText = "Month Added";
                        dtg.Columns[15].HeaderText = "Year Added";
                        dtg.Columns[16].HeaderText = "Category";
                        dtg.Columns[17].HeaderText = "Profit";

                        // Set the column widths
                        dtg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dtg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dtg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dtg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dtg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dtg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dtg.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dtg.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dtg.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dtg.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dtg.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dtg.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        dtg.Columns[0].Visible = false;
                        dtg.Columns[12].Visible = false;
                        dtg.Columns[13].Visible = false;
                        dtg.Columns[14].Visible = false;
                        dtg.Columns[15].Visible = false;
                        dtg.Columns[16].Visible = false;
                        dtg.Columns[17].Visible = false;

                        // Set the padding and size of the icon
                        dtg.Columns[10].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
                        dtg.Columns[10].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
                        dtg.Columns[10].Width = 30; // Adjust the width of the icon column

                        // Set the padding and size of the icon
                        dtg.Columns[11].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
                        dtg.Columns[11].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
                        dtg.Columns[11].Width = 30; // Adjust the width of the icon column

                        // Add the CellFormatting event to set the tooltip for the Warning column
                        dtg.CellFormatting += (sender, e) =>
                        {
                            if (e.ColumnIndex == 10 && e.RowIndex >= 0 && e.RowIndex < dtg.Rows.Count)
                            {
                                DataGridViewCell cell = dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                string? invEndNow = dtg.Rows[e.RowIndex].Cells["Inventory End(Now)"].Value.ToString();
                                int currentStocks = int.Parse(invEndNow);

                                if (currentStocks <= 9)
                                {
                                    cell.ToolTipText = dtg.Rows[e.RowIndex].Cells["Description"].Value.ToString() + " is low stock!\nJust click in Inventory Beg to add more stocks.";
                                }
                                else
                                {
                                    cell.ToolTipText = dtg.Rows[e.RowIndex].Cells["Description"].Value.ToString() + " has stocks available.";
                                }
                            }
                            else if (e.ColumnIndex == 11 && e.RowIndex >= 0 && e.RowIndex < dtg.Rows.Count)
                            {
                                DataGridViewCell cell = dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                cell.ToolTipText = "Delete " + dtg.Rows[e.RowIndex].Cells["Description"].Value.ToString() + "?";
                            }
                        };

                        // Add the CellMouseEnter event to change the cursor to a hand cursor
                        dtg.CellMouseEnter += (sender, e) =>
                        {
                            if (e.ColumnIndex == 11 && e.RowIndex >= 0 && e.RowIndex < dtg.Rows.Count)
                            {
                                dtg.Cursor = System.Windows.Forms.Cursors.Hand;
                            }
                        };

                        // Add the CellMouseLeave event to revert the cursor to the default cursor
                        dtg.CellMouseLeave += (sender, e) =>
                        {
                            dtg.Cursor = System.Windows.Forms.Cursors.Default;
                        };

                        saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
                    }
                    else
                    {
                        // no data
                        saveBtn.Enabled = false;
                        saveBtn.Cursor = System.Windows.Forms.Cursors.No;
                    }
                }
                else
                {
                    // no data
                    saveBtn.Enabled = false;
                    saveBtn.Cursor = System.Windows.Forms.Cursors.No;
                }
            }
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

            for (int i = 0; i < DAILY_SALES_GROCERIES_DTG.Columns.Count - 1; i++)
            {
                DAILY_SALES_GROCERIES_DTG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            printer.PrintDataGridView(DAILY_SALES_GROCERIES_DTG);
        }

        // Assuming you have a method to get inventoryEnd for a specific date
        private int GetInventoryEndForDate(int productId, DateTime date)
        {
            InventoryProducts1TableAdapter inv = new InventoryProducts1TableAdapter();
            InvProduct.InventoryProducts1DataTable dt = inv.GetInventoryEndForDate(date, productId);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0].Field<int>("InventoryEndNow");
            }

            // Return a default value or handle the case where no data is found
            return 0;
        }

        private void getTotalCashSales(string cat)
        {
            InventoryProducts1TableAdapter inv = new InventoryProducts1TableAdapter();
            decimal totalCashSales = decimal.Parse(inv.getTotalCashSales(cat).GetValueOrDefault().ToString());

            if (cat.Equals("Groceries"))
            {
                groceries_total_sale.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);
                groceries_cash_sales.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);
            }
            else if (cat.Equals("Drinks"))
            {
                drinks_total_sale.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);
                drinks_cash_sales.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);
            }
            else if (cat.Equals("School Supplies"))
            {
                school_sup_total_sale.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);
                school_cash_sales.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);
            }
            else if (cat.Equals("Ice Cream"))
            {
                ice_cream_total_sale.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);
                ice_cream_cash_sales.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);
            }

            double sales = Convert.ToDouble(inv.getCashSalesAll().GetValueOrDefault().ToString());
            sales_all_cat.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", sales);
        }

        private void DRINKS_DTG_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (DRINKS_DTG.Columns[e.ColumnIndex].Name == "Quantity Sold")
            {
                // Check if the entered value is numeric
                if (!int.TryParse(e.FormattedValue.ToString(), out _))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DRINKS_DTG_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Replace "NumericColumnName" with the actual name of the column that should contain numeric values
            if (DRINKS_DTG.Columns[e.ColumnIndex].Name == "Quantity Sold")
            {
                // Handle conversion after validation
                if (int.TryParse(DRINKS_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out int numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < DRINKS_DTG.Rows.Count)
                    {
                        updateData(rowIndex, e.ColumnIndex, DRINKS_DTG, "Drinks", save_all_drinks);
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
            else if (DRINKS_DTG.Columns[e.ColumnIndex].Name == "Unit Price")
            {
                // Handle conversion after validation
                if (decimal.TryParse(DRINKS_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out decimal numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < DRINKS_DTG.Rows.Count)
                    {
                        updateUnitPrice(rowIndex, e.ColumnIndex, DRINKS_DTG, "Drinks", save_all_drinks);
                        //MessageBox.Show("Unit Price");
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
            else if (DRINKS_DTG.Columns[e.ColumnIndex].Name == "Inventory Beg")
            {
                // Handle conversion after validation
                if (decimal.TryParse(DRINKS_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out decimal numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < DRINKS_DTG.Rows.Count)
                    {
                        updateInventoryBeg(rowIndex, e.ColumnIndex, DRINKS_DTG, "Drinks", save_all_drinks);
                        //MessageBox.Show("Inventory Beg");
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
        }

        private void DRINKS_DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Perform the "Edit" action
            DataGridViewRow selectedRow = DRINKS_DTG.Rows[e.RowIndex];
            int id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
            string? item = selectedRow.Cells["Description"].Value.ToString();

            if (DRINKS_DTG.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + item + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
                    adapter.DeleteFromInventory(id);
                    getCategoriesData("Drinks", save_all_drinks);
                    getTotalCashSales("Drinks");
                }
            }
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private bool InsertRowIntoDatabase(DataRow row, string id)
        {
            // Assuming you have a method to insert a row into the database
            // Replace the code below with your actual database insertion logic

            // Remove non-numeric characters
            string? unitPrice = row.Field<string>("Unit Price");
            string? CashSalePrice = row.Field<string>("Cash Sales");
            string numericUnitPricePart = new string(unitPrice.Where(c => Char.IsDigit(c) || c == '.' || c == ',').ToArray());
            string numericCashSalePart = new string(CashSalePrice.Where(c => Char.IsDigit(c) || c == '.' || c == ',').ToArray());

            if (decimal.TryParse(numericUnitPricePart, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal unitPriceValue) && decimal.TryParse(numericCashSalePart, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal CashSalePriceValue))
            {
                // Example:
                DailySalesReport1TableAdapter adapter = new DailySalesReport1TableAdapter();
                adapter.InsertDailySalesReport(
                    id,
                    int.Parse(row.Field<string>("Inventory Beg")),
                    int.Parse(row.Field<string>("Total Inventory")),
                    int.Parse(row.Field<string>("Inventory End(Now)")),
                    int.Parse(row.Field<string>("Quantity Sold")),
                    unitPriceValue,
                    CashSalePriceValue,
                    DateTime.Parse(row.Field<string>("DateAdded")),
                    row.Field<string>("DayAdded"),
                    row.Field<string>("MonthAdded"),
                    row.Field<string>("YearAdded"),
                    row.Field<string>("Category"),
                    row.Field<string>("Description"),
                    decimal.Parse(row.Field<string>("Profit")));

                return true;  // Indicate success
            }
            else
            {
                MessageBox.Show("Failed to parse the numeric part of the price.");
                return false;  // Indicate failure
            }
        }

        private void UpdateProfit(int id, decimal totalProfit)
        {
            InventoryProducts1TableAdapter tableAdapter = new InventoryProducts1TableAdapter();

            InvProduct.InventoryProducts1DataTable dt = tableAdapter.GetProfitById(id);

            if (dt.Rows.Count > 0)
            {
                // Product exists in the database, update the quantity
                InvProduct.InventoryProducts1Row row = dt[0]; // Assuming only one row is returned
                decimal currentProfit = row.Profit;
                decimal newProfit = currentProfit + totalProfit;

                // Update the quantity sold
                tableAdapter.UpdateProfitById(newProfit, id);
            }
            else
            {
                // Product doesn't exist in the database, insert a new row
                tableAdapter.UpdateProfitById(totalProfit, id);
            }
        }

        private void updateData(int rowIndex, int columnIndex, BunifuCustomDataGrid dtg, string cat, PictureBox saveBtn)
        {
            // Check if the specified rowIndex is valid
            if (rowIndex >= 0 && rowIndex < dtg.Rows.Count)
            {
                DataGridViewRow row = dtg.Rows[rowIndex];

                // Check if the specified columnIndex is valid
                if (columnIndex >= 0 && columnIndex < row.Cells.Count)
                {
                    DataGridViewCell cell = row.Cells[columnIndex];
                    DataGridViewCell idCell = row.Cells["ID"];
                    DataGridViewCell priceCell = row.Cells["Unit Price"];
                    DataGridViewCell begCell = row.Cells["Inventory Beg"];
                    DataGridViewCell endCell = row.Cells["Inventory End"];
                    DataGridViewCell totalInventoryCell = row.Cells["Total Inventory"];

                    // Check if the cell value is not null
                    if (cell.Value != null)
                    {
                        DateTime currentDate = DateTime.Now;

                        // Format time as "10:00 am"
                        string formattedTime = currentDate.ToString("hh:mm tt");

                        // Format date as "Jan 20, 2023"
                        string formattedDate = currentDate.ToString("MMM dd, yyyy");
                        DateTime parsedTime = DateTime.ParseExact(formattedTime, "hh:mm tt", CultureInfo.InvariantCulture);
                        DateTime parsedDate = DateTime.ParseExact(formattedDate, "MMM dd, yyyy", CultureInfo.InvariantCulture);
                        string month = currentDate.ToString("MMMM");
                        string days = currentDate.ToString("dddd");
                        string year = currentDate.ToString("yyyy");

                        string? cellValue = cell.Value.ToString();
                        int sold = int.Parse(cellValue);
                        string? id = idCell.Value.ToString();
                        string? price = priceCell.Value.ToString();
                        string? oldEnd = endCell.Value.ToString();
                        string? oldBeg = begCell.Value.ToString();
                        string? totalInv = totalInventoryCell.Value.ToString();

                        // Remove non-numeric characters
                        string numericPart = new string(price.Where(c => Char.IsDigit(c) || c == '.' || c == ',').ToArray());

                        // Convert the numeric part to a decimal
                        if (decimal.TryParse(numericPart, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal priceValue))
                        {
                            InventoryProducts1TableAdapter inv = new InventoryProducts1TableAdapter();

                            InvProduct.InventoryProducts1DataTable dt = inv.GetCurrentStocks(int.Parse(id));
                            InvProduct.InventoryProducts1DataTable dtQuantitySold = inv.GetQuantitySoldById(int.Parse(id));
                            InvProduct.InventoryProducts1DataTable dtInventoryEndNow = inv.GetInventoryEndNow(int.Parse(id));
                            InvProduct.InventoryProducts1DataTable dtDate = inv.GetDate(int.Parse(id));
                            InvProduct.InventoryProducts1DataTable dtPrice = inv.GetPriceById(int.Parse(id));

                            // Check if the DataTable has rows
                            if (dt.Rows.Count > 0 || dtQuantitySold.Rows.Count > 0 || dtInventoryEndNow.Rows.Count > 0)
                            {
                                // Assuming 'CurrentStocks' is of type int, retrieve the value from the first row
                                int currentStocksValue = dt.Rows[0].Field<int>("CurrentStocks");
                                int oldQuantitySold = dtQuantitySold.Rows[0].Field<int>("QuantitySold");
                                int oldInventoryEndNow = dtInventoryEndNow.Rows[0].Field<int>("InventoryEndNow");
                                DateTime date = dtDate.Rows[0].Field<DateTime>("DateAdded");
                                decimal costPrice = dtPrice.Rows[0].Field<decimal>("Price");

                                int totalInventory = int.Parse(oldBeg) + int.Parse(oldEnd);

                                DateTime yesterday = currentDate.AddDays(-1);
                                DateTime inventoryEndNowDate = date; // Assuming there is a Date column in your data
                                bool isYesterday = inventoryEndNowDate.Date == yesterday.Date;

                                int inventoryEndYesterday = GetInventoryEndForDate(int.Parse(id), yesterday);

                                // Now, 'currentStocksValue' contains the value of 'CurrentStocks'

                                if (oldQuantitySold == 0 && oldInventoryEndNow == 0)
                                {
                                    int newCurrentStocks = currentStocksValue - sold;
                                    int newInventoryEnd = currentStocksValue - sold;

                                    if (sold == int.Parse(totalInv))
                                    {
                                        newInventoryEnd = 0;
                                        // Now, priceValue contains the numeric part as a decimal
                                        decimal CashSales = priceValue * sold;

                                        decimal totalRevenue = priceValue * sold;
                                        decimal totalCOGS = costPrice * sold;
                                        decimal totalProfit = totalRevenue - totalCOGS;

                                        UpdateProfit(int.Parse(id), totalProfit);

                                        // Update the inventory asynchronously
                                        BeginInvoke(new Action(() =>
                                        {
                                            inv.UpdateInventoryEndNow(
                                                sold,
                                                newInventoryEnd,
                                                CashSales,
                                                parsedDate,
                                                parsedTime,
                                                days,
                                                month,
                                                year,
                                                newCurrentStocks,
                                                int.Parse(oldBeg),
                                                int.Parse(id)
                                            );

                                            // Reload the DataGridView
                                            getTotalCashSales(cat);
                                            getCategoriesData(cat, saveBtn);
                                            dtg.Refresh();
                                        }));
                                    }
                                    else if (sold > int.Parse(totalInv))
                                    {
                                        MessageBox.Show("Not enough stocks.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cell.Value = oldQuantitySold;
                                    }
                                    else
                                    {
                                        // Now, priceValue contains the numeric part as a decimal
                                        decimal CashSales = priceValue * sold;

                                        decimal totalRevenue = priceValue * sold;
                                        decimal totalCOGS = costPrice * sold;
                                        decimal totalProfit = totalRevenue - totalCOGS;

                                        UpdateProfit(int.Parse(id), totalProfit);

                                        // Update the inventory asynchronously
                                        BeginInvoke(new Action(() =>
                                        {
                                            inv.UpdateInventoryEndNow(
                                                sold,
                                                newInventoryEnd,
                                                CashSales,
                                                parsedDate,
                                                parsedTime,
                                                days,
                                                month,
                                                year,
                                                newCurrentStocks,
                                                int.Parse(oldBeg),
                                                int.Parse(id)
                                            );

                                            // Reload the DataGridView
                                            getTotalCashSales(cat);
                                            getCategoriesData(cat, saveBtn);
                                            dtg.Refresh();
                                        }));
                                    }
                                }
                                else
                                {
                                    int newQuantitySold = oldQuantitySold + sold;
                                    int newCurrentStocks = currentStocksValue - sold;
                                    int newInventoryEnd = oldInventoryEndNow - sold;

                                    if (newQuantitySold == int.Parse(totalInv))
                                    {
                                        newInventoryEnd = 0;
                                        // Now, priceValue contains the numeric part as a decimal
                                        decimal CashSales = priceValue * newQuantitySold;

                                        decimal totalRevenue = (decimal)(priceValue * newQuantitySold);
                                        decimal totalCOGS = (decimal)(costPrice * newQuantitySold);
                                        decimal totalProfit = totalRevenue - totalCOGS;

                                        UpdateProfit(int.Parse(id), totalProfit);

                                        // Update the inventory asynchronously
                                        BeginInvoke(new Action(() =>
                                        {
                                            inv.UpdateInventoryEndNow(
                                                newQuantitySold,
                                                newInventoryEnd,
                                                CashSales,
                                                parsedDate,
                                                parsedTime,
                                                days,
                                                month,
                                                year,
                                                newCurrentStocks,
                                                int.Parse(oldBeg),
                                                int.Parse(id)
                                            );

                                            // Reload the DataGridView
                                            getTotalCashSales(cat);
                                            getCategoriesData(cat, saveBtn);
                                            dtg.Refresh();
                                        }));
                                    }
                                    else if (newQuantitySold > int.Parse(totalInv))
                                    {
                                        MessageBox.Show("Not enough stocks.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cell.Value = oldQuantitySold;
                                    }
                                    else
                                    {
                                        // Now, priceValue contains the numeric part as a decimal
                                        decimal CashSales = priceValue * newQuantitySold;

                                        decimal totalRevenue = (decimal)(priceValue * newQuantitySold);
                                        decimal totalCOGS = (decimal)(costPrice * newQuantitySold);
                                        decimal totalProfit = totalRevenue - totalCOGS;

                                        UpdateProfit(int.Parse(id), totalProfit);

                                        // Update the inventory asynchronously
                                        BeginInvoke(new Action(() =>
                                        {
                                            inv.UpdateInventoryEndNow(
                                                newQuantitySold,
                                                newInventoryEnd,
                                                CashSales,
                                                parsedDate,
                                                parsedTime,
                                                days,
                                                month,
                                                year,
                                                newCurrentStocks,
                                                int.Parse(oldBeg),
                                                int.Parse(id)
                                            );

                                            // Reload the DataGridView
                                            getTotalCashSales(cat);
                                            getCategoriesData(cat, saveBtn);
                                            dtg.Refresh();
                                        }));
                                    }
                                }
                            }
                            else
                            {
                                // Handle the case where no rows are returned for the given ID
                                Console.WriteLine("No data found for the given ID.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to parse the numeric part of the price.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cell value is null");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid columnIndex");
                }
            }
            else
            {
                MessageBox.Show("Invalid rowIndex");
            }
        }

        private void updateUnitPrice(int rowIndex, int columnIndex, BunifuCustomDataGrid dtg, string cat, PictureBox saveBtn)
        {
            // Check if the specified rowIndex is valid
            if (rowIndex >= 0 && rowIndex < dtg.Rows.Count)
            {
                DataGridViewRow row = dtg.Rows[rowIndex];

                // Check if the specified columnIndex is valid
                if (columnIndex >= 0 && columnIndex < row.Cells.Count)
                {
                    DataGridViewCell unitPriceCell = row.Cells[columnIndex];
                    DataGridViewCell idCell = row.Cells["ID"];

                    if (unitPriceCell.Value != null)
                    {
                        string? unitPriceString = unitPriceCell.Value.ToString();
                        if (unitPriceString != null)
                        {
                            // Remove non-numeric characters
                            string? itemID = idCell.Value.ToString();
                            string numericPart = new string(unitPriceString.Where(c => Char.IsDigit(c) || c == '.' || c == ',').ToArray());

                            //parsed
                            int itemIDParsed = int.Parse(itemID);

                            // Convert the numeric part to a decimal
                            if (decimal.TryParse(numericPart, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal unitPriceValue))
                            {

                                // Update the inventory asynchronously
                                BeginInvoke(new Action(() =>
                                {
                                    InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
                                    adapter.UpdateUnitPriceById(
                                            unitPriceValue,
                                            itemIDParsed
                                        );
                                    // Reload the DataGridView
                                    getTotalCashSales(cat);
                                    getCategoriesData(cat, saveBtn);
                                    dtg.Refresh();
                                }));

                            }
                            else
                            {
                                MessageBox.Show("failed to parsed");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cell value is null");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid column index!");
                }
            }
            else
            {
                MessageBox.Show("Invalid row index!");
            }
        }

        private void updateInventoryBeg(int rowIndex, int columnIndex, BunifuCustomDataGrid dtg, string cat, PictureBox saveBtn)
        {
            // Check if the specified rowIndex is valid
            if (rowIndex >= 0 && rowIndex < dtg.Rows.Count)
            {
                DataGridViewRow row = dtg.Rows[rowIndex];

                // Check if the specified columnIndex is valid
                if (columnIndex >= 0 && columnIndex < row.Cells.Count)
                {
                    DataGridViewCell invBegCell = row.Cells[columnIndex];
                    DataGridViewCell idCell = row.Cells["ID"];
                    DataGridViewCell itemCell = row.Cells["Description"];

                    if (invBegCell.Value != null)
                    {
                        string? invBegString = invBegCell.Value.ToString();
                        if (invBegString != null)
                        {
                            DateTime currentDate = DateTime.Now;

                            // Format time as "10:00 am"
                            string formattedTime = currentDate.ToString("hh:mm tt");

                            // Format date as "Jan 20, 2023"
                            string formattedDate = currentDate.ToString("MMM dd, yyyy");
                            DateTime parsedTime = DateTime.ParseExact(formattedTime, "hh:mm tt", CultureInfo.InvariantCulture);
                            DateTime parsedDate = DateTime.ParseExact(formattedDate, "MMM dd, yyyy", CultureInfo.InvariantCulture);
                            string month = currentDate.ToString("MMMM");
                            string days = currentDate.ToString("dddd");
                            string year = currentDate.ToString("yyyy");

                            int invBeg = int.Parse(invBegString);
                            int ItemID = int.Parse(idCell.Value.ToString());
                            string? item = itemCell.Value.ToString();
                            int totalProductsStocks = 0, oldInvEndNow = 0, oldCStocks = 0, oldTStocks = 0;

                            InventoryProducts1TableAdapter inv = new InventoryProducts1TableAdapter();

                            InvProduct.InventoryProducts1DataTable dtInvBeg = inv.GetInvBegById(ItemID);
                            InvProduct.InventoryProducts1DataTable dtInventoryEndNow = inv.GetInventoryEndNow(ItemID);
                            InvProduct.InventoryProducts1DataTable dtCurrentStocks = inv.GetCurrentStocks(ItemID);

                            int oldInventoryBeg = dtInvBeg.Rows[0].Field<int>("InventoryBeg");
                            int oldInventoryEndNow = dtInventoryEndNow.Rows[0].Field<int>("InventoryEndNow");
                            int oldCurrentStocks = dtCurrentStocks.Rows[0].Field<int>("CurrentStocks");
                            int oldTotalStocks = dtCurrentStocks.Rows[0].Field<int>("TotalStocks");

                            if (oldInventoryBeg != 0 || oldInventoryEndNow != 0 || oldCurrentStocks != 0 || oldTotalStocks != 0)
                            {
                                invBeg += oldInventoryBeg;
                                oldInvEndNow += oldInventoryEndNow;
                                oldCStocks += oldCurrentStocks;
                                oldTStocks += oldTotalStocks;
                            }

                            ProductsTableAdapter product = new ProductsTableAdapter();
                            ProductsDataSet.ProductsDataTable pDT = product.getProductsData(item);
                            ProductsDataSet.ProductsRow pRow = pDT.Rows[0] as ProductsDataSet.ProductsRow;

                            if (pRow != null)
                            {
                                totalProductsStocks = pRow.CurrentStocks;
                            }

                            if (totalProductsStocks <= 9)
                            {
                                MessageBox.Show(item + " is low stocks.\nPlease add new stocks in stocks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                invBegCell.Value = oldInventoryBeg;
                            }
                            else if (int.Parse(invBegString) > totalProductsStocks)
                            {
                                MessageBox.Show("Current stocks is greater than old stocks.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                invBegCell.Value = oldInventoryBeg;
                            }
                            else
                            {
                                try
                                {
                                    ProductsTableAdapter productsTableAdapter = new ProductsTableAdapter();
                                    productsTableAdapter.UpdateProductsStocks(
                                        totalProductsStocks - int.Parse(invBegString),
                                        item
                                    );

                                    // Update the inventory asynchronously
                                    BeginInvoke(new Action(() =>
                                    {
                                        InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
                                        adapter.UpdateInvBegById(
                                                invBeg,
                                                oldInvEndNow + int.Parse(invBegString),
                                                oldCStocks + int.Parse(invBegString),
                                                oldTStocks + int.Parse(invBegString),
                                                parsedDate,
                                                parsedTime,
                                                days,
                                                month,
                                                year,
                                                ItemID
                                            );

                                        // Reload the DataGridView
                                        getTotalCashSales(cat);
                                        getCategoriesData(cat, saveBtn);
                                        dtg.Refresh();
                                    }));
                                }
                                catch
                                {
                                    MessageBox.Show("Failed to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cell value is null");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid column index!");
                }
            }
            else
            {
                MessageBox.Show("Invalid row index!");
            }
        }

        private void DAILY_SALES_GROCERIES_DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Perform the "Edit" action
            DataGridViewRow selectedRow = DAILY_SALES_GROCERIES_DTG.Rows[e.RowIndex];
            int id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
            string? item = selectedRow.Cells["Description"].Value.ToString();

            if (DAILY_SALES_GROCERIES_DTG.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + item + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
                    adapter.DeleteFromInventory(id);
                    getCategoriesData("Groceries", save_all_groceries);
                    getTotalCashSales("Groceries");
                }
            }
        }

        private void SCHOOL_DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Perform the "Edit" action
            DataGridViewRow selectedRow = SCHOOL_DTG.Rows[e.RowIndex];
            int id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
            string? item = selectedRow.Cells["Description"].Value.ToString();

            if (SCHOOL_DTG.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + item + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
                    adapter.DeleteFromInventory(id);
                    getCategoriesData("School Supplies", save_all_school);
                    getTotalCashSales("School Supplies");
                }
            }
        }

        private void ICE_CREAM_DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Perform the "Edit" action
            DataGridViewRow selectedRow = ICE_CREAM_DTG.Rows[e.RowIndex];
            int id = int.Parse(selectedRow.Cells["ID"].Value.ToString());
            string? item = selectedRow.Cells["Description"].Value.ToString();

            if (ICE_CREAM_DTG.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + item + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
                    adapter.DeleteFromInventory(id);
                    getCategoriesData("Ice Cream", save_all_ice_cream);
                    getTotalCashSales("Ice Cream");
                }
            }
        }

        private void DAILY_SALES_GROCERIES_DTG_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Replace "NumericColumnName" with the actual name of the column that should contain numeric values
            if (DAILY_SALES_GROCERIES_DTG.Columns[e.ColumnIndex].Name == "Quantity Sold")
            {
                // Handle conversion after validation
                if (int.TryParse(DAILY_SALES_GROCERIES_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out int numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < DAILY_SALES_GROCERIES_DTG.Rows.Count)
                    {
                        updateData(rowIndex, e.ColumnIndex, DAILY_SALES_GROCERIES_DTG, "Groceries", save_all_groceries);
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
            else if (DAILY_SALES_GROCERIES_DTG.Columns[e.ColumnIndex].Name == "Unit Price")
            {
                // Handle conversion after validation
                if (decimal.TryParse(DAILY_SALES_GROCERIES_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out decimal numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < DAILY_SALES_GROCERIES_DTG.Rows.Count)
                    {
                        updateUnitPrice(rowIndex, e.ColumnIndex, DAILY_SALES_GROCERIES_DTG, "Groceries", save_all_groceries);
                        //MessageBox.Show("Unit Price");
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
            else if (DAILY_SALES_GROCERIES_DTG.Columns[e.ColumnIndex].Name == "Inventory Beg")
            {
                // Handle conversion after validation
                if (decimal.TryParse(DAILY_SALES_GROCERIES_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out decimal numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < DAILY_SALES_GROCERIES_DTG.Rows.Count)
                    {
                        updateInventoryBeg(rowIndex, e.ColumnIndex, DAILY_SALES_GROCERIES_DTG, "Groceries", save_all_groceries);
                        //MessageBox.Show("Inventory Beg");
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
        }

        private void SCHOOL_DTG_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Replace "NumericColumnName" with the actual name of the column that should contain numeric values
            if (SCHOOL_DTG.Columns[e.ColumnIndex].Name == "Quantity Sold")
            {
                // Handle conversion after validation
                if (int.TryParse(SCHOOL_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out int numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < SCHOOL_DTG.Rows.Count)
                    {
                        updateData(rowIndex, e.ColumnIndex, SCHOOL_DTG, "School Supplies", save_all_school);
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
            else if (SCHOOL_DTG.Columns[e.ColumnIndex].Name == "Unit Price")
            {
                // Handle conversion after validation
                if (decimal.TryParse(SCHOOL_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out decimal numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < SCHOOL_DTG.Rows.Count)
                    {
                        updateUnitPrice(rowIndex, e.ColumnIndex, SCHOOL_DTG, "School Supplies", save_all_school);
                        //MessageBox.Show("Unit Price");
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
            else if (SCHOOL_DTG.Columns[e.ColumnIndex].Name == "Inventory Beg")
            {
                // Handle conversion after validation
                if (decimal.TryParse(SCHOOL_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out decimal numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < SCHOOL_DTG.Rows.Count)
                    {
                        updateInventoryBeg(rowIndex, e.ColumnIndex, SCHOOL_DTG, "School Supplies", save_all_school);
                        //MessageBox.Show("Inventory Beg");
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
        }

        private void ICE_CREAM_DTG_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Replace "NumericColumnName" with the actual name of the column that should contain numeric values
            if (ICE_CREAM_DTG.Columns[e.ColumnIndex].Name == "Quantity Sold")
            {
                // Handle conversion after validation
                if (int.TryParse(ICE_CREAM_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out int numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < ICE_CREAM_DTG.Rows.Count)
                    {
                        updateData(rowIndex, e.ColumnIndex, ICE_CREAM_DTG, "Ice Cream", save_all_ice_cream);
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
            else if (ICE_CREAM_DTG.Columns[e.ColumnIndex].Name == "Unit Price")
            {
                // Handle conversion after validation
                if (decimal.TryParse(ICE_CREAM_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out decimal numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < ICE_CREAM_DTG.Rows.Count)
                    {
                        updateUnitPrice(rowIndex, e.ColumnIndex, ICE_CREAM_DTG, "Ice Cream", save_all_ice_cream);
                        //MessageBox.Show("Unit Price");
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
            else if (ICE_CREAM_DTG.Columns[e.ColumnIndex].Name == "Inventory Beg")
            {
                // Handle conversion after validation
                if (decimal.TryParse(ICE_CREAM_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out decimal numericValue))
                {
                    // Use 'numericValue' for further processing
                    // ...
                    int rowIndex = e.RowIndex;

                    // Check if the rowIndex is within the valid range
                    if (rowIndex >= 0 && rowIndex < ICE_CREAM_DTG.Rows.Count)
                    {
                        updateInventoryBeg(rowIndex, e.ColumnIndex, ICE_CREAM_DTG, "Ice Cream", save_all_ice_cream);
                        //MessageBox.Show("Inventory Beg");
                    }
                    else
                    {
                        MessageBox.Show("Invalid rowIndex");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You might want to handle this case, e.g., set a default value or clear the cell
                }
            }
        }

        private void DAILY_SALES_GROCERIES_DTG_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (DAILY_SALES_GROCERIES_DTG.Columns[e.ColumnIndex].Name == "Quantity Sold")
            {
                // Check if the entered value is numeric
                if (!int.TryParse(e.FormattedValue.ToString(), out _))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SCHOOL_DTG_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (SCHOOL_DTG.Columns[e.ColumnIndex].Name == "Quantity Sold")
            {
                // Check if the entered value is numeric
                if (!int.TryParse(e.FormattedValue.ToString(), out _))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ICE_CREAM_DTG_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (ICE_CREAM_DTG.Columns[e.ColumnIndex].Name == "Quantity Sold")
            {
                // Check if the entered value is numeric
                if (!int.TryParse(e.FormattedValue.ToString(), out _))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void save_all_groceries_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(save_all_groceries, "Save");
        }

        private void save_all_drinks_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(save_all_drinks, "Save");
        }

        private void save_all_school_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(save_all_school, "Save");
        }

        private void save_all_ice_cream_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(save_all_ice_cream, "Save");
        }

        private void save_all_drinks_Click(object sender, EventArgs e)
        {
            bool success = false;  // Variable to track success

            try
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                // Create a data table to hold the data from the DataGridView
                DataTable dt = (DataTable)DRINKS_DTG.DataSource;

                // Loop through each row in the DataTable
                foreach (DataRow row in dt.Rows)
                {
                    // Assuming you have a method to insert a row into the database
                    // Generate a new UID
                    string newUID = Guid.NewGuid().ToString();
                    success |= InsertRowIntoDatabase(row, newUID);  // Use |= to set success to true if at least one row is successful
                }
                if (success)
                {
                    MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No rows were successfully saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void save_all_groceries_Click(object sender, EventArgs e)
        {
            bool success = false;  // Variable to track success

            try
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                // Create a data table to hold the data from the DataGridView
                DataTable dt = (DataTable)DAILY_SALES_GROCERIES_DTG.DataSource;

                // Loop through each row in the DataTable
                foreach (DataRow row in dt.Rows)
                {
                    // Assuming you have a method to insert a row into the database
                    // Generate a new UID
                    string newUID = Guid.NewGuid().ToString();
                    success |= InsertRowIntoDatabase(row, newUID);  // Use |= to set success to true if at least one row is successful
                }
                if (success)
                {
                    MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No rows were successfully saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void save_all_school_Click(object sender, EventArgs e)
        {
            bool success = false;  // Variable to track success

            try
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                // Create a data table to hold the data from the DataGridView
                DataTable dt = (DataTable)SCHOOL_DTG.DataSource;

                // Loop through each row in the DataTable
                foreach (DataRow row in dt.Rows)
                {
                    // Assuming you have a method to insert a row into the database
                    // Generate a new UID
                    string newUID = Guid.NewGuid().ToString();
                    success |= InsertRowIntoDatabase(row, newUID);  // Use |= to set success to true if at least one row is successful
                }
                if (success)
                {
                    MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No rows were successfully saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void save_all_ice_cream_Click(object sender, EventArgs e)
        {
            bool success = false;  // Variable to track success

            try
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                // Create a data table to hold the data from the DataGridView
                DataTable dt = (DataTable)ICE_CREAM_DTG.DataSource;

                // Loop through each row in the DataTable
                foreach (DataRow row in dt.Rows)
                {
                    // Assuming you have a method to insert a row into the database
                    // Generate a new UID
                    string newUID = Guid.NewGuid().ToString();
                    success |= InsertRowIntoDatabase(row, newUID);  // Use |= to set success to true if at least one row is successful
                }
                if (success)
                {
                    MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No rows were successfully saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void credits_et_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string allSalesStr = sales_all_cat.Text;
                string numericPart = new string(allSalesStr.Where(c => Char.IsDigit(c) || c == '.' || c == ',').ToArray());

                decimal totalSales = 0;
                decimal credit = decimal.Parse(credits_et.Text);

                // Convert the numeric part to a decimal
                if (decimal.TryParse(numericPart, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal allSalesValue))
                {
                    totalSales = allSalesValue - credit;

                    if (credit > allSalesValue)
                    {
                        MessageBox.Show("Credit is to high than your sales.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        credits_et.Text = "0";
                        credits_et.Focus();
                    }
                    else
                    {
                        total_sales_cat.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalSales);
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void credits_et_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, decimal point, backspace, and delete
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void print_groceries_btn_Click(object sender, EventArgs e)
        {
            /*DGVPrinter printer = new DGVPrinter();
            printer.Title = "Daily Sales\nGroceries";
            printer.SubTitle = DateTime.Now.ToString("\nMM/dd/yyyy hh:mm tt\n");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "List of Groceries";
            printer.FooterSpacing = 15;
            // Adjust column widths to fit on one page, excluding the last column
            printer.PageSettings.Landscape = false; // Set to true if you want landscape orientation

            for (int i = 0; i < DAILY_SALES_GROCERIES_DTG.Columns.Count - 1; i++)
            {
                DAILY_SALES_GROCERIES_DTG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            printer.PrintDataGridView(DAILY_SALES_GROCERIES_DTG);*/

            PrintPreview printPrev = new PrintPreview(DAILY_SALES_GROCERIES_DTG, "Groceries", "Daily Sales");
            printPrev.ShowDialog();
        }

        private void print_groceries_btn_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(print_groceries_btn, "Print Groceries");
        }

        private void print_drinks_btn_Click(object sender, EventArgs e)
        {
            /*DGVPrinter printer = new DGVPrinter();
            printer.Title = "Daily Sales\nDrinks";
            printer.SubTitle = DateTime.Now.ToString("\nMM/dd/yyyy hh:mm tt\n");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "List of Drinks";
            printer.FooterSpacing = 15;
            // Adjust column widths to fit on one page, excluding the last column
            printer.PageSettings.Landscape = false; // Set to true if you want landscape orientation

            for (int i = 0; i < DRINKS_DTG.Columns.Count - 1; i++)
            {
                DRINKS_DTG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            printer.PrintDataGridView(DRINKS_DTG);*/
            PrintPreview printPrev = new PrintPreview(DRINKS_DTG, "Drinks", "Daily Sales");
            printPrev.ShowDialog();
        }

        private void print_drinks_btn_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(print_drinks_btn, "Print Drinks");
        }

        private void print_school_supp_btn_Click(object sender, EventArgs e)
        {
            /*DGVPrinter printer = new DGVPrinter();
            printer.Title = "Daily Sales\nSchool Supplies";
            printer.SubTitle = DateTime.Now.ToString("\nMM/dd/yyyy hh:mm tt\n");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "List of School Supplies";
            printer.FooterSpacing = 15;
            // Adjust column widths to fit on one page, excluding the last column
            printer.PageSettings.Landscape = false; // Set to true if you want landscape orientation

            for (int i = 0; i < SCHOOL_DTG.Columns.Count - 1; i++)
            {
                SCHOOL_DTG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            printer.PrintDataGridView(SCHOOL_DTG);*/
            PrintPreview printPrev = new PrintPreview(SCHOOL_DTG, "School Supplies", "Daily Sales");
            printPrev.ShowDialog();
        }

        private void print_school_supp_btn_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(print_school_supp_btn, "Print School Supplies");
        }

        private void print_ice_cream_btn_Click(object sender, EventArgs e)
        {
            /*DGVPrinter printer = new DGVPrinter();
            printer.Title = "Daily Sales\nIce Cream";
            printer.SubTitle = DateTime.Now.ToString("\nMM/dd/yyyy hh:mm tt\n");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "List of Ice Cream";
            printer.FooterSpacing = 15;
            // Adjust column widths to fit on one page, excluding the last column
            printer.PageSettings.Landscape = false; // Set to true if you want landscape orientation

            for (int i = 0; i < ICE_CREAM_DTG.Columns.Count - 1; i++)
            {
                ICE_CREAM_DTG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            printer.PrintDataGridView(ICE_CREAM_DTG);*/
            PrintPreview printPrev = new PrintPreview(ICE_CREAM_DTG, "Ice Cream", "Daily Sales");
            printPrev.ShowDialog();
        }

        private void print_ice_cream_btn_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(print_ice_cream_btn, "Print Ice Cream");
        }

        private void print_all_cat_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = pd;
                printPreviewDialog.ShowDialog();

                print_all_cat.Visible = false;
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define font and brush for header
            Font headerFont = new Font("Poppins", 16, FontStyle.Bold);
            System.Drawing.Brush headerBrush = System.Drawing.Brushes.Black;

            // Define font and brush for data
            Font dataFont = new Font("Poppins", 12);
            System.Drawing.Brush dataBrush = System.Drawing.Brushes.Black;

            // Define header and sample data
            string headerText = "All Categories Data";
            string dataText = "Groceries\nDrinks\nSchool Supplies\nIce Cream";

            // Get the current date
            string currentDate = DateTime.Now.ToString("MMMM dd, yyyy");

            // Calculate the height of the header
            float headerHeight = e.Graphics.MeasureString(headerText, headerFont).Height;

            // Draw header with date
            e.Graphics.DrawString($"{headerText} - {currentDate}", headerFont, headerBrush, new PointF(50, 50));

            // Draw data below the header
            float dataTop = 50 + headerHeight + 20; // Add some spacing below the header
            e.Graphics.DrawString(dataText, dataFont, dataBrush, new PointF(50, dataTop));

            // Calculate the height of the data
            //float dataHeight = e.Graphics.MeasureString(dataText, dataFont).Height;

            // Draw the panel content
            Bitmap bmp = new Bitmap(all_cat_panel.Width, all_cat_panel.Height + 100);
            all_cat_panel.DrawToBitmap(bmp, new Rectangle(20, (int)dataTop + 10, all_cat_panel.Width, all_cat_panel.Height + 100));
            e.Graphics.DrawImage(bmp, new Point(20, (int)dataTop + 10 + (int)headerHeight + 10));
        }

        private void saveAll_btn_Click(object sender, EventArgs e)
        {
            bool success = false;  // Variable to track success

            try
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }

                string newUID = Guid.NewGuid().ToString();
                // Save data from each DataGridView
                success |= SaveDataFromDataGridView(DAILY_SALES_GROCERIES_DTG);
                success |= SaveDataFromDataGridView(DRINKS_DTG);
                success |= SaveDataFromDataGridView(SCHOOL_DTG);
                success |= SaveDataFromDataGridView(ICE_CREAM_DTG);

                if (success)
                {
                    MessageBox.Show("All data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No data was successfully saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool SaveDataFromDataGridView(BunifuCustomDataGrid dtgs)
        {
            bool success = false;  // Variable to track success

            try
            {
                // Create a data table to hold the data from the DataGridView
                DataTable dt = (DataTable)dtgs.DataSource;

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Loop through each row in the DataTable
                    foreach (DataRow row in dt.Rows)
                    {
                        // Assuming you have a method to insert a row into the database
                        // Generate a new UID
                        string newUID = Guid.NewGuid().ToString();
                        success |= InsertRowIntoDatabase(row, newUID);  // Use |= to set success to true if at least one row is successful
                    }
                }
                else
                {
                    //MessageBox.Show("No data in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    success = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }

            return success;
        }
    }
}
