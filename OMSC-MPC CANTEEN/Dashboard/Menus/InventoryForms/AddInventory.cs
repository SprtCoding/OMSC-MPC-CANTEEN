using OMSC_MPC_CANTEEN.Loaders;
using OMSC_MPC_CANTEEN.UserData.DataSets;
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
using Bunifu.Framework.UI;
using OMSC_MPC_CANTEEN.UserData.DataSets.InvProductTableAdapters;
using System.Windows.Controls;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus.InventoryForms
{
    public partial class AddInventory : Form
    {
        private BunifuCustomDataGrid? myDTG;
        private double item_price = 0;
        private int total_stocks = 0;
        // Assuming you have a class-level variable to store the list of products
        private List<string> productList = new List<string>();

        public AddInventory(BunifuCustomDataGrid dtg)
        {
            InitializeComponent();
            myDTG = dtg;
            setAutoCompleteTB(item_name_tb);
            getItemTotalStocks();
        }

        private void updateProducts()
        {
            try
            {
                int newStocks = int.Parse(current_stocks_tb.Text);
                decimal newAmount = decimal.Parse(unit_price.Text);
                int totalNewStocks = 0, totalStocks = 0, totalProductsStocks = 0;
                decimal totalNewAmount = 0, price = 0;
                string itemName = item_name_tb.Text;

                ProductsTableAdapter product = new ProductsTableAdapter();
                ProductsDataSet.ProductsDataTable pDT = product.getProductsData(itemName);
                ProductsDataSet.ProductsRow pRow = pDT.Rows[0] as ProductsDataSet.ProductsRow;

                if (pRow != null)
                {
                    totalProductsStocks = pRow.CurrentStocks;
                }

                InventoryProductsTableAdapter adapter = new InventoryProductsTableAdapter();
                InvProduct.InventoryProductsDataTable dt = adapter.getInventoryData(itemName);

                // Assuming item is a unique identifier in your DataTable
                InvProduct.InventoryProductsRow row = dt.Rows[0] as InvProduct.InventoryProductsRow;

                if (row != null)
                {
                    totalNewStocks = newStocks + row.CurrentStocks;
                    totalStocks = newStocks + row.TotalStocks;
                    totalNewAmount = newAmount + row.TotalAmount;
                    price = row.Price;
                }

                if (totalProductsStocks <= 9)
                {
                    MessageBox.Show(itemName + " is low stocks.\nPlease add new stocks in purchases!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        adapter.UpdateInventoryProducts(
                            itemName,
                            totalNewStocks,
                            totalStocks,
                            totalNewAmount,
                            category_cbx.Text,
                            price,
                            itemName
                        );

                        ProductsTableAdapter productsTableAdapter = new ProductsTableAdapter();
                        productsTableAdapter.UpdateProductsStocks(
                            totalProductsStocks - newStocks,
                            itemName
                        );

                        loadData();
                        getItemTotalStocks();
                        clear();
                        Hide();
                    }
                    catch
                    {
                        MessageBox.Show(itemName + " failed to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FormatException ex)
            {
                // Handle parsing errors (e.g., invalid input format)
                MessageBox.Show("Invalid input format. Please enter valid numeric values.");
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
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
            try
            {
                string item = item_name_tb.Text;
                int currentStocks = int.Parse(current_stocks_tb.Text);
                DateTime expiration = expiration_dtp.Value;
                double price = double.Parse(price_tb.Text);
                double unitPrice = double.Parse(unit_price.Text);
                string category = category_cbx.Text;

                if (String.IsNullOrEmpty(item))
                {
                    MessageBox.Show("Item name is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    item_name_tb.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(current_stocks_tb.Text))
                {
                    MessageBox.Show("Current Stocks is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    current_stocks_tb.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(unit_price.Text))
                {
                    MessageBox.Show("Price is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    unit_price.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(price_tb.Text))
                {
                    MessageBox.Show("Unit Price is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    unit_price.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(category))
                {
                    MessageBox.Show("Category is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    category_cbx.Focus();
                    return;
                }
                else
                {
                    using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                    {
                        frm_wait.ShowDialog(this);
                    }
                    setProducts(item, currentStocks, expiration, price, category, unitPrice);
                }
            }
            catch (FormatException ex)
            {
                // Handle parsing errors (e.g., invalid input format)
                MessageBox.Show(ex.Message + "\nInvalid input format. Please enter valid numeric values.");
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void setProducts(string item, int currentStocks, DateTime expiration, double price, string category, double unitPrice)
        {
            int new_stocks = total_stocks - currentStocks;
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

            if (currentStocks > total_stocks)
            {
                MessageBox.Show(item + " Stocks is only " + total_stocks, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (!InventoryExists(item))
                    {
                        InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
                        adapter.InsertInventory(
                                item,
                                0,
                                0,
                                currentStocks,
                                currentStocks,
                                currentStocks,
                                currentStocks,
                                0,
                                0,
                                (decimal)price,
                                category,
                                (decimal)unitPrice,
                                (decimal)item_price,
                                parsedDate,
                                parsedTime,
                                days,
                                month,
                                year
                            );

                        ProductsTableAdapter pr = new ProductsTableAdapter();
                        pr.UpdateProductsStocks(
                                new_stocks,
                                item
                            );

                        MessageBox.Show(item + " saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(item + " already exists!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    loadData();
                    clear();
                    Hide();
                }
                catch
                {
                    MessageBox.Show("Failed to add " + item, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool InventoryExists(string productName)
        {
            // Check if the product already exists in the database
            InventoryProducts1TableAdapter inv = new InventoryProducts1TableAdapter();
            int count = Convert.ToInt32(inv.InventoryExists(productName));
            return count > 0;
        }

        private void clear()
        {
            item_name_tb.Text = "";
            current_stocks_tb.Text = "";
            expiration_dtp.Value = DateTime.Now;
            unit_price.Text = "";
            category_cbx.Text = "";
        }

        private void setAutoCompleteTB(BunifuMaterialTextbox tb)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(getItem());
            tb.AutoCompleteCustomSource = source;
            tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private string[] getItem()
        {
            // Clear the existing list
            productList.Clear();

            // Instantiate the table adapter and retrieve the data
            ProductsTableAdapter pr = new ProductsTableAdapter();
            ProductsDataSet.ProductsDataTable dt = pr.getProductsItem();

            // Iterate through each row in the data table and add the product names to the list
            foreach (ProductsDataSet.ProductsRow row in dt.Rows)
            {
                productList.Add(row.Item); // Assuming 'ProductName' is the column containing product names
            }

            // Convert the list to an array and return
            return productList.ToArray();
        }

        private void getItemCategory()
        {
            string selectedValue = item_name_tb.Text;
            ProductsTableAdapter pr = new ProductsTableAdapter();
            ProductsDataSet.ProductsDataTable dt = pr.getItemCategory(selectedValue);
            category_cbx.DataSource = dt;
            category_cbx.DisplayMember = "Category";
        }

        private void getItemExpirationDate()
        {
            string selectedValue = item_name_tb.Text;
            ProductsTableAdapter pr = new ProductsTableAdapter();
            ProductsDataSet.ProductsDataTable dt = pr.getExpirationDate(selectedValue);
            if (dt.Rows.Count > 0)
            {
                // Assuming expiration_dtp is a DateTimePicker control.
                DateTime earliestExpirationDate = dt.Rows[0].Field<DateTime>("ExpirationDate");

                foreach (ProductsDataSet.ProductsRow row in dt)
                {
                    DateTime currentExpirationDate = row.ExpirationDate;
                    if (currentExpirationDate < earliestExpirationDate)
                    {
                        earliestExpirationDate = currentExpirationDate;
                    }
                }

                expiration_dtp.Value = earliestExpirationDate.Date;
            }
            //else
            //{
            //    // Handle the case where no expiration date is found for the selected item.
            //    // You can display a message or handle it as needed.
            //    MessageBox.Show("No expiration date found for the selected item.");
            //}
        }

        private void getPrice()
        {
            string selectedValue = item_name_tb.Text;
            // Now you can work with the selected value (item name) as needed

            if (selectedValue != null || String.IsNullOrEmpty(selectedValue))
            {
                ProductsTableAdapter product = new ProductsTableAdapter();
                ProductsDataSet.ProductsDataTable dt = product.getItemPrice(selectedValue); // Assuming the price is a decimal

                // Display the price in a TextBox (assuming you have a TextBox named 'priceTextBox')
                foreach (ProductsDataSet.ProductsRow row in dt)
                {
                    item_price = Double.Parse(row.Price.ToString());
                    price_tb.Text = row.Price.ToString();
                }
            }
        }

        private void getItemTotalStocks()
        {
            string selectedValue = item_name_tb.Text;
            // Now you can work with the selected value (item name) as needed

            if (selectedValue != null || String.IsNullOrEmpty(selectedValue))
            {
                ProductsTableAdapter product = new ProductsTableAdapter();
                ProductsDataSet.ProductsDataTable dt = product.GetItemTotalStocks(selectedValue); // Assuming the price is a decimal

                // Display the price in a TextBox (assuming you have a TextBox named 'priceTextBox')
                foreach (ProductsDataSet.ProductsRow row in dt)
                {
                    total_stocks = int.Parse(row.CurrentStocks.ToString());
                }
            }
        }

        private void current_stocks_tb_OnValueChanged(object sender, EventArgs e)
        {
            string input = current_stocks_tb.Text;

            if (!string.IsNullOrEmpty(input))
            {
                try
                {
                    // Do something with the parsed integer value here
                    int quantity = int.Parse(input);
                    double total = item_price * quantity;
                    price_tb.Text = total.ToString();
                }
                catch (FormatException)
                {
                    // Handle the case where the input is not a valid integer
                    MessageBox.Show("Please enter a valid integer.");
                }
            }
            else
            {
                // Handle the case where the TextBox is empty or contains no input
                getPrice();
            }
        }

        private void loadData()
        {
            myDTG.DataSource = null;

            InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
            InvProduct.InventoryProducts1DataTable dt = adapter.GetData();
            myDTG.DataSource = dt;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("ID");
            filteredTable.Columns.Add("Description");
            filteredTable.Columns.Add("Category");
            filteredTable.Columns.Add("Total Inventory");
            filteredTable.Columns.Add("Inventory End");
            filteredTable.Columns.Add("Quantity Sold");
            filteredTable.Columns.Add("Unit Price");
            filteredTable.Columns.Add("Cash Sales");
            filteredTable.Columns.Add("Warning", typeof(System.Drawing.Image));
            filteredTable.Columns.Add("Delete", typeof(System.Drawing.Image));

            // Populate the filtered DataTable with the selected columns from the original DataTable
            foreach (InvProduct.InventoryProducts1Row row in dt.Rows)
            {
                int totalInventory = row.InventoryEnd + row.InventoryBeg;

                // Check if the inventoryEndNow is from yesterday
                DateTime currentDate = DateTime.Now;
                DateTime yesterday = currentDate.AddDays(-1);
                DateTime inventoryEndNowDate = row.DateAdded; // Assuming there is a Date column in your data
                bool isYesterday = inventoryEndNowDate.Date == yesterday.Date;

                int inventoryEndNow;

                if (isYesterday)
                {
                    // Set inventoryEndNow to inventoryBeg value if it's from yesterday
                    inventoryEndNow = row.InventoryBeg;
                }
                else
                {
                    // Calculate inventoryEndNow as usual
                    inventoryEndNow = getEndInventory(totalInventory, row.QuantitySold);
                }

                // Check if currentStocks is below 10
                if (row.CurrentStocks < 10)
                {
                    filteredTable.Rows.Add(
                        row.ID, row.Item,
                        row.Category,
                        totalInventory,
                        row.InventoryEndNow,
                        row.QuantitySold,
                        string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}",
                        row.UnitPrice),
                        string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}",
                        row.CashSales),
                        Properties.Resources.warning_small,
                        Properties.Resources.trash);
                }
                else
                {
                    filteredTable.Rows.Add(
                        row.ID,
                        row.Item,
                        row.Category,
                        totalInventory,
                        row.InventoryEndNow,
                        row.QuantitySold,
                        string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.UnitPrice),
                        string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.CashSales),
                        Properties.Resources.badge_check,
                        Properties.Resources.trash);
                }
            }

            myDTG.DataSource = filteredTable;

            // Set the column headers
            myDTG.Columns[0].HeaderText = "ID";
            myDTG.Columns[1].HeaderText = "Description";
            myDTG.Columns[2].HeaderText = "Category";
            myDTG.Columns[3].HeaderText = "Total Inventory";
            myDTG.Columns[4].HeaderText = "Inventory End";
            myDTG.Columns[5].HeaderText = "Quantity Sold";
            myDTG.Columns[6].HeaderText = "Unit Price";
            myDTG.Columns[7].HeaderText = "Cash Sales";
            myDTG.Columns[8].HeaderText = "Warning";
            myDTG.Columns[9].HeaderText = "Delete";

            // Set the column widths
            myDTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            myDTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myDTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myDTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myDTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myDTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myDTG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myDTG.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myDTG.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            myDTG.Columns[0].Visible = false;

            // Set the padding and size of the icon
            myDTG.Columns[8].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            myDTG.Columns[8].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            myDTG.Columns[8].Width = 30; // Adjust the width of the icon column

            // Set the padding and size of the icon
            myDTG.Columns[9].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            myDTG.Columns[9].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            myDTG.Columns[9].Width = 30; // Adjust the width of the icon column

            // Add the CellFormatting event to set the tooltip for the Warning column
            myDTG.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == 8 && e.RowIndex >= 0 && e.RowIndex < myDTG.Rows.Count)
                {
                    DataGridViewCell cell = myDTG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string? invEndNow = myDTG.Rows[e.RowIndex].Cells["Inventory End"].Value.ToString();
                    int currentStocks = int.Parse(invEndNow);

                    if (currentStocks <= 9)
                    {
                        cell.ToolTipText = myDTG.Rows[e.RowIndex].Cells["Description"].Value.ToString() + " is low stock.";
                    }
                    else
                    {
                        cell.ToolTipText = myDTG.Rows[e.RowIndex].Cells["Description"].Value.ToString() + " has stocks available.";
                    }
                }
                else if (e.ColumnIndex == 9 && e.RowIndex >= 0 && e.RowIndex < myDTG.Rows.Count)
                {
                    DataGridViewCell cell = myDTG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.ToolTipText = "Delete " + myDTG.Rows[e.RowIndex].Cells["Description"].Value.ToString() + "?";
                }
            };

            // Add the CellMouseEnter event to change the cursor to a hand cursor
            myDTG.CellMouseEnter += (sender, e) =>
            {
                if (e.ColumnIndex == 9 && e.RowIndex >= 0 && e.RowIndex < myDTG.Rows.Count)
                {
                    myDTG.Cursor = Cursors.Hand;
                }
            };

            // Add the CellMouseLeave event to revert the cursor to the default cursor
            myDTG.CellMouseLeave += (sender, e) =>
            {
                myDTG.Cursor = Cursors.Default;
            };
        }

        private int getEndInventory(int no, int quantitySold)
        {
            if (no == 0)
            {
                return 0;
            }
            return no - quantitySold;
        }

        private void item_name_tb_OnValueChanged(object sender, EventArgs e)
        {
            getItemCategory();
            getPrice();
            getItemExpirationDate();
            getItemTotalStocks();
        }
    }
}
