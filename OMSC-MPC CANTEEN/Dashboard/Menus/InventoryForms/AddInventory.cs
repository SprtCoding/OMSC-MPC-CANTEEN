using OMSC_MPC_CANTEEN.Loaders;
using OMSC_MPC_CANTEEN.UserData.DataSets.DailySalesDataSetTableAdapters;
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

namespace OMSC_MPC_CANTEEN.Dashboard.Menus.InventoryForms
{
    public partial class AddInventory : Form
    {
        private BunifuCustomDataGrid? myDTG;
        private double item_price = 0;
        private int total_stocks = 0;
        private string? item;

        public AddInventory(BunifuCustomDataGrid dtg, string item)
        {
            InitializeComponent();
            myDTG = dtg;
            getItem();
            getItemTotalStocks();

            item_name_cbx.SelectedIndex = 0;

            if (!item.Equals(""))
            {
                products_gb.Text = "Update Products";
                item_name_cbx.Text = item;
                update_btn.Enabled = true;
                save_btn.Enabled = false;
                item_name_cbx.Enabled = false;
                category_cbx.Enabled = false;
                expiration_dtp.Enabled = false;
                this.item = item;
            }
            else
            {
                update_btn.Enabled = false;
                save_btn.Enabled = true;
            }
        }

        private void updateProducts(string item)
        {
            try
            {
                int newStocks = int.Parse(current_stocks_tb.Text);
                decimal newAmount = decimal.Parse(price_tb.Text);
                int totalNewStocks = 0, totalStocks = 0, totalProductsStocks = 0;
                decimal totalNewAmount = 0, price = 0;

                ProductsTableAdapter product = new ProductsTableAdapter();
                ProductsDataSet.ProductsDataTable pDT = product.getProductsData(item);
                ProductsDataSet.ProductsRow pRow = pDT.Rows[0] as ProductsDataSet.ProductsRow;

                if (pRow != null)
                {
                    totalProductsStocks = pRow.CurrentStocks;
                }

                InventoryProductsTableAdapter adapter = new InventoryProductsTableAdapter();
                InvProduct.InventoryProductsDataTable dt = adapter.getInventoryData(item);

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
                    MessageBox.Show(item + " is low stocks.\nPlease add new stocks in purchases!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        adapter.UpdateInventoryProducts(
                            item,
                            totalNewStocks,
                            totalStocks,
                            totalNewAmount,
                            category_cbx.Text,
                            price,
                            item
                        );

                        ProductsTableAdapter productsTableAdapter = new ProductsTableAdapter();
                        productsTableAdapter.UpdateProductsStocks(
                            totalProductsStocks - newStocks,
                            item
                        );

                        loadData();
                        getItemTotalStocks();
                        clear();
                        Hide();
                    }
                    catch
                    {
                        MessageBox.Show(item + " failed to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string item = item_name_cbx.Text;
                int currentStocks = int.Parse(current_stocks_tb.Text);
                DateTime expiration = expiration_dtp.Value;
                double price = double.Parse(price_tb.Text);
                string category = category_cbx.Text;

                if (String.IsNullOrEmpty(item))
                {
                    MessageBox.Show("Item name is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    item_name_cbx.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(current_stocks_tb.Text))
                {
                    MessageBox.Show("Current Stocks is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    current_stocks_tb.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(price_tb.Text))
                {
                    MessageBox.Show("Price is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    price_tb.Focus();
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
                    setProducts(item, currentStocks, expiration, price, category);
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

        private void setProducts(string item, int currentStocks, DateTime expiration, double price, string category)
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
                    InventoryProductsTableAdapter adapter = new InventoryProductsTableAdapter();
                    adapter.InsertInventory(
                            item,
                            0,
                            currentStocks,
                            currentStocks,
                            (decimal)price,
                            category,
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

        private void clear()
        {
            item_name_cbx.Text = "";
            current_stocks_tb.Text = "";
            expiration_dtp.Value = DateTime.Now;
            price_tb.Text = "";
            category_cbx.Text = "";
        }

        private void getItem()
        {
            ProductsTableAdapter pr = new ProductsTableAdapter();
            ProductsDataSet.ProductsDataTable dt = pr.getProductsItem();
            item_name_cbx.DataSource = dt;
            item_name_cbx.DisplayMember = "Item";

            item_name_cbx.SelectedIndex = 0;
        }

        private void getItemCategory()
        {
            string selectedValue = item_name_cbx.Text;
            ProductsTableAdapter pr = new ProductsTableAdapter();
            ProductsDataSet.ProductsDataTable dt = pr.getItemCategory(selectedValue);
            category_cbx.DataSource = dt;
            category_cbx.DisplayMember = "Category";
        }

        private void getItemExpirationDate()
        {
            string selectedValue = item_name_cbx.Text;
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
            string selectedValue = item_name_cbx.Text;
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
            string selectedValue = item_name_cbx.Text;
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

        private void item_name_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            getItemCategory();
            getPrice();
            getItemExpirationDate();
            getItemTotalStocks();
        }

        private void item_name_cbx_TextChanged(object sender, EventArgs e)
        {
            getItemCategory();
            getPrice();
            getItemExpirationDate();
            getItemTotalStocks();
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

            InventoryProductsTableAdapter adapter = new InventoryProductsTableAdapter();
            InvProduct.InventoryProductsDataTable dt = adapter.GetData();
            myDTG.DataSource = dt;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Description");
            filteredTable.Columns.Add("Total Inventory");
            filteredTable.Columns.Add("Inventory End");
            filteredTable.Columns.Add("Quantity Sold");
            filteredTable.Columns.Add("Unit Price");
            filteredTable.Columns.Add("Cash Sales");
            filteredTable.Columns.Add("Warning", typeof(Image));
            filteredTable.Columns.Add("Edit", typeof(Image));
            filteredTable.Columns.Add("Delete", typeof(Image));

            // Populate the filtered DataTable with the selected columns from the original DataTable
            foreach (InvProduct.InventoryProductsRow row in dt.Rows)
            {
                // Fetch the quantity sold for the current item from the "DailySales" table
                DailySalesTableAdapter dailySales = new DailySalesTableAdapter();

                double cashSales = double.Parse(dailySales.getCashSales(row.Item).GetValueOrDefault().ToString());

                // Check if currentStocks is below 10
                if (row.CurrentStocks < 10)
                {
                    filteredTable.Rows.Add(row.Item, row.TotalStocks, row.CurrentStocks, row.QuantitySold, string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price), string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", cashSales), Properties.Resources.warning_small, Properties.Resources.edit_small, Properties.Resources.trash);

                }
                else
                {
                    filteredTable.Rows.Add(row.Item, row.TotalStocks, row.CurrentStocks, row.QuantitySold, string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price), string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", cashSales), Properties.Resources.badge_check, Properties.Resources.badge_check, Properties.Resources.trash);
                }
            }

            myDTG.DataSource = filteredTable;

            // Set the column headers
            myDTG.Columns[0].HeaderText = "Description";
            myDTG.Columns[1].HeaderText = "Total Inventory";
            myDTG.Columns[2].HeaderText = "Inventory End";
            myDTG.Columns[3].HeaderText = "Quantity Sold";
            myDTG.Columns[4].HeaderText = "Unit Price";
            myDTG.Columns[5].HeaderText = "Cash Sales";
            myDTG.Columns[6].HeaderText = "Warning";
            myDTG.Columns[7].HeaderText = "Edit";
            myDTG.Columns[8].HeaderText = "Delete";

            // Set the column widths
            myDTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myDTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Set the padding and size of the icon
            myDTG.Columns[6].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            myDTG.Columns[6].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            myDTG.Columns[6].Width = 30; // Adjust the width of the icon column

            // Set the padding and size of the icon
            myDTG.Columns[7].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            myDTG.Columns[7].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            myDTG.Columns[7].Width = 30; // Adjust the width of the icon column

            // Set the padding and size of the icon
            myDTG.Columns[8].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            myDTG.Columns[8].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            myDTG.Columns[8].Width = 30; // Adjust the width of the icon column
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            updateProducts(item);
        }
    }
}
