using Bunifu.Framework.UI;
using OMSC_MPC_CANTEEN.Loaders;
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

namespace OMSC_MPC_CANTEEN.Dashboard.Menus.DailySalesForms
{
    public partial class AddDailySales : Form
    {
        private string? _userID = Dashboard.username_id;
        private BunifuCustomDataGrid myDTG;
        private Label totalLabel;
        decimal totalRevenue = 0;
        decimal totalCOGS = 0;

        public AddDailySales(BunifuCustomDataGrid dtg, Label totalLabel)
        {
            InitializeComponent();
            myDTG = dtg;

            item_name_cbx.Text = "";

            getItem();
            this.totalLabel = totalLabel;
        }

        private void getPrice()
        {
            string selectedValue = item_name_cbx.Text;
            // Now you can work with the selected value (item name) as needed

            if (selectedValue != null || String.IsNullOrEmpty(selectedValue))
            {
                InventoryProductsTableAdapter product = new InventoryProductsTableAdapter();
                InvProduct.InventoryProductsDataTable dt = product.getItemPrice(selectedValue); // Assuming the price is a decimal

                // Display the price in a TextBox (assuming you have a TextBox named 'priceTextBox')
                foreach (InvProduct.InventoryProductsRow row in dt)
                {
                    price_tb.Text = row.Price.ToString();
                }
            }
        }

        private void getTotalSale()
        {
            // Fetch the quantity sold for the current item from the "DailySales" table
            DailySalesTableAdapter dailySales = new DailySalesTableAdapter();

            double totalCashSales = double.Parse(dailySales.getAllSales().GetValueOrDefault().ToString());

            totalLabel.Text = string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", totalCashSales);
        }

        private void getItem()
        {
            InventoryProductsTableAdapter inventory = new InventoryProductsTableAdapter();
            InvProduct.InventoryProductsDataTable dt = inventory.GetData();
            item_name_cbx.DataSource = dt;
            item_name_cbx.DisplayMember = "Item";
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        public void loadData()
        {
            myDTG.DataSource = null;

            DailySalesTableAdapter pr = new DailySalesTableAdapter();
            // Retrieve the updated data from the database
            DailySalesDataSet.DailySalesDataTable dt = pr.GetData(_userID);
            myDTG.DataSource = dt;

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
                filteredTable.Rows.Add(row.ID, row.Item, string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price), row.Quantity, string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.TotalSales), row.DateOfSales, Properties.Resources.delete);
            }

            myDTG.DataSource = filteredTable;

            // Set the column headers
            myDTG.Columns[0].HeaderText = "ID";
            myDTG.Columns[1].HeaderText = "Item";
            myDTG.Columns[2].HeaderText = "Price";
            myDTG.Columns[3].HeaderText = "Quantity";
            myDTG.Columns[4].HeaderText = "Total Sales";
            myDTG.Columns[5].HeaderText = "Date";
            myDTG.Columns[6].HeaderText = "Action";

            // Set the column widths
            myDTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myDTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Set the padding and size of the icon
            myDTG.Columns[6].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            myDTG.Columns[6].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            myDTG.Columns[6].Width = 30; // Adjust the width of the icon column
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string item_name = item_name_cbx.Text;
                double price = Convert.ToDouble(price_tb.Text);
                int quantity = int.Parse(quantity_tb.Text);

                if (String.IsNullOrEmpty(item_name))
                {
                    MessageBox.Show("Item name is empty.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    item_name_cbx.Focus();
                    return;
                }
                else if (String.IsNullOrEmpty(price_tb.Text))
                {
                    MessageBox.Show("Price is empty.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(quantity_tb.Text))
                {
                    MessageBox.Show("Cash Sales is empty.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                    {
                        frm_wait.ShowDialog(this);
                    }
                    savedToDB(item_name, price, quantity);
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

        private void savedToDB(string item_name, double price, int quantity)
        {
            try
            {
                InvProduct dataSet = new InvProduct(); // Replace with your dataset name
                InventoryProductsTableAdapter tableAdapter = new InventoryProductsTableAdapter(); // Replace with your table adapter name

                // Load data into the dataset (if needed)
                tableAdapter.Fill(dataSet.InventoryProducts);

                // Get the DataRow for the product you want to update
                InvProduct.InventoryProductsRow row = dataSet.InventoryProducts.FirstOrDefault(p => p.Item == item_name); // Replace "Item" with your column name

                if (row != null)
                {
                    if (row.CurrentStocks <= 9)
                    {
                        MessageBox.Show(item_name + " is low stocks.\nPlease add new stocks in inventory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (quantity > row.CurrentStocks)
                    {
                        MessageBox.Show(item_name + " Stocks is only " + row.CurrentStocks, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        try
                        {
                            // Update the stock quantity in the DataRow
                            row.CurrentStocks -= quantity;
                            // Update the database using the table adapter's Update method
                            tableAdapter.Update(dataSet.InventoryProducts);

                            DateTime currentDate = DateTime.Now;

                            // Format time as "10:00 am"
                            string formattedTime = currentDate.ToString("hh:mm tt");

                            // Format date as "Jan 20, 2023"
                            string formattedDate = currentDate.ToString("MMM dd, yyyy");
                            string month = currentDate.ToString("MMMM");
                            string days = currentDate.ToString("dddd");
                            string year = currentDate.ToString("yyyy");

                            DailySalesTableAdapter adapter = new DailySalesTableAdapter();
                            adapter.InsertDailySales(
                                _userID,
                                item_name,
                                (decimal)price,
                                quantity,
                                formattedDate,
                                month,
                                days,
                                year,
                                formattedTime);

                            InventoryProductsTableAdapter inventoryProductsTableAdapter = new InventoryProductsTableAdapter();
                            InvProduct.InventoryProductsDataTable dt = inventoryProductsTableAdapter.getCostPrice(item_name);

                            foreach (InvProduct.InventoryProductsRow rowInv in dt)
                            {
                                totalRevenue = (decimal)(price * quantity);
                                totalCOGS = (decimal)(rowInv.Price * quantity);
                                decimal totalProfit = totalRevenue - totalCOGS;
                                UpdateProfit(item_name, totalProfit);
                            }

                            // Update product stock
                            UpdateQuantitySold(item_name, quantity);

                            MessageBox.Show(item_name + " saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            getTotalSale();
                            clear();
                            Hide();
                        }
                        catch
                        {
                            MessageBox.Show("Failed to add " + item_name, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    // Handle the case where the product is not found
                    MessageBox.Show("Product not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, e.g., display an error message
                MessageBox.Show("Error updating product stock: " + ex.Message);
            }
        }

        private void UpdateProfit(string item_name, decimal totalProfit)
        {
            InventoryProductsTableAdapter tableAdapter = new InventoryProductsTableAdapter();

            InvProduct.InventoryProductsDataTable dt = tableAdapter.getProfit(item_name);

            if (dt.Rows.Count > 0)
            {
                // Product exists in the database, update the quantity
                InvProduct.InventoryProductsRow row = dt[0]; // Assuming only one row is returned
                decimal currentProfit = row.Profit;
                decimal newProfit = currentProfit + totalProfit;

                // Update the quantity sold
                tableAdapter.UpdateProfit(newProfit, item_name);
            }
            else
            {
                // Product doesn't exist in the database, insert a new row
                tableAdapter.UpdateProfit(totalProfit, item_name);
            }
        }

        private void UpdateQuantitySold(string productName, int soldQuantity)
        {
            InventoryProductsTableAdapter tableAdapter = new InventoryProductsTableAdapter();

            InvProduct.InventoryProductsDataTable dt = tableAdapter.getQuantitySold(productName);

            if (dt.Rows.Count > 0)
            {
                // Product exists in the database, update the quantity
                InvProduct.InventoryProductsRow row = dt[0]; // Assuming only one row is returned
                int currentQuantitySold = row.QuantitySold;
                int newQuantitySold = currentQuantitySold + soldQuantity;

                // Update the quantity sold
                tableAdapter.updateQuantitySold(newQuantitySold, productName);
            }
            else
            {
                // Product doesn't exist in the database, insert a new row
                tableAdapter.updateQuantitySold(soldQuantity, productName);
            }
        }

        private void clear()
        {
            item_name_cbx.Text = "";
            price_tb.Text = "";
            quantity_tb.Text = "";
        }

        private void price_tb_Leave(object sender, EventArgs e)
        {
            try
            {
                price_tb.Text = string.Format("{0:n}", double.Parse(price_tb.Text.Trim()));
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

        private void quantity_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    quantity_tb.Text = string.Format("{0:n}", int.Parse(quantity_tb.Text.Trim()));

                    string item_name = item_name_cbx.Text;
                    double price = Convert.ToDouble(price_tb.Text);
                    int quatity = int.Parse(quantity_tb.Text);

                    if (String.IsNullOrEmpty(item_name))
                    {
                        MessageBox.Show("Item name is empty.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                    else if (String.IsNullOrEmpty(price_tb.Text))
                    {
                        MessageBox.Show("Price is empty.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                    else if (String.IsNullOrEmpty(quantity_tb.Text))
                    {
                        MessageBox.Show("Cash Sales is empty.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                        {
                            frm_wait.ShowDialog(this);
                        }
                        savedToDB(item_name, price, quatity);
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
        }
    }
}
