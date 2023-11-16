﻿using Bunifu.Framework.UI;
using OMSC_MPC_CANTEEN.Loaders;
using OMSC_MPC_CANTEEN.UserData.DataSets;
using OMSC_MPC_CANTEEN.UserData.DataSets.ProductsDataSetTableAdapters;
using System.Data;
using System.Globalization;
using static System.Windows.Forms.DataFormats;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus.Products
{
    public partial class AddProducts : Form
    {
        private BunifuCustomDataGrid? myDTG;
        private string? item;
        private int newStocks = 0, oldStocks = 0, oldTotalStocks = 0;
        private decimal newTotalAmount = 0, oldTotalAmount = 0;
        public AddProducts(BunifuCustomDataGrid dtg, string item)
        {
            InitializeComponent();
            myDTG = dtg;
            if (!item.Equals(""))
            {
                titleLbl.Text = "Update Products";
                save_btn.Text = "Update";
                product_tb.Text = item;
                date_dtp.Enabled = false;
                expiration_date_dtp.Enabled = false;
                product_tb.Enabled = false;
                suplier_tb.Enabled = false;
                price_tb.Enabled = false;
                total_amount_tb.Enabled = false;
                category_cbx.Enabled = false;
                this.item = item;

                ProductsTableAdapter product = new ProductsTableAdapter();
                ProductsDataSet.ProductsDataTable pDT = product.getProductsData(item);
                ProductsDataSet.ProductsRow pRow = pDT.Rows[0] as ProductsDataSet.ProductsRow;

                if (pRow != null)
                {
                    expiration_date_dtp.Value = pRow.ExpirationDate;
                    date_dtp.Value = pRow.DateAdded;
                    suplier_tb.Text = pRow.Suplier;
                    price_tb.Text = pRow.Price.ToString();
                    oldTotalAmount = pRow.TotalAmount;
                    category_cbx.Text = pRow.Category;
                    q_level_cbx.Text = pRow.QuantityLevel;
                    oldStocks = pRow.CurrentStocks;
                    oldTotalStocks = pRow.TotalStocks;
                }

            }
            else
            {
                save_btn.Text = "Save";
            }
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void clear()
        {
            product_tb.Text = "";
            suplier_tb.Text = "";
            date_dtp.Value = DateTime.Now;
            expiration_date_dtp.Value = DateTime.Now;
            price_tb.Text = "";
            category_cbx.Text = "";
            quantity_tb.Text = "";
            q_level_cbx.Text = "";
            total_amount_tb.Text = "";
        }

        private void loadData()
        {
            myDTG.DataSource = null;

            ProductsTableAdapter pr = new ProductsTableAdapter();
            // Retrieve the updated data from the database
            ProductsDataSet.ProductsDataTable table = pr.GetData();
            myDTG.DataSource = table;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Date");
            filteredTable.Columns.Add("Suplier");
            filteredTable.Columns.Add("Total Amount");
            filteredTable.Columns.Add("Purchase");
            filteredTable.Columns.Add("Delete", typeof(Image));

            // Populate the filtered DataTable with the selected columns from the original DataTable
            foreach (ProductsDataSet.ProductsRow row in table.Rows)
            {
                filteredTable.Rows.Add(row.DateAdded, row.Suplier, string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.TotalAmount), row.Item, Properties.Resources.trash);
            }

            myDTG.DataSource = filteredTable;

            // Set the column headers
            myDTG.Columns[0].HeaderText = "Date";
            myDTG.Columns[1].HeaderText = "Suplier";
            myDTG.Columns[2].HeaderText = "Total Amount";
            myDTG.Columns[3].HeaderText = "Purchase";
            myDTG.Columns[4].HeaderText = "Action";

            // Set the column widths
            myDTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myDTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myDTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Set the padding and size of the icon
            myDTG.Columns[4].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            myDTG.Columns[4].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            myDTG.Columns[4].Width = 30; // Adjust the width of the icon column
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = date_dtp.Value;
                DateTime expiration = expiration_date_dtp.Value;
                string product = product_tb.Text;
                string suplier = suplier_tb.Text;
                double price = double.Parse(price_tb.Text);
                string category = category_cbx.Text;
                int quantity = int.Parse(quantity_tb.Text);
                string quantityLevel = q_level_cbx.Text;
                double totalAmount = double.Parse(total_amount_tb.Text);

                if (save_btn.Text == "Save")
                {
                    if (String.IsNullOrEmpty(product))
                    {
                        MessageBox.Show("Product is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        product_tb.Focus();
                        return;
                    }
                    else if (String.IsNullOrEmpty(suplier))
                    {
                        MessageBox.Show("Suplier is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        suplier_tb.Focus();
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
                    else if (String.IsNullOrEmpty(quantity_tb.Text))
                    {
                        MessageBox.Show("Quantity is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        quantity_tb.Focus();
                        return;
                    }
                    else if (String.IsNullOrEmpty(q_level_cbx.Text))
                    {
                        MessageBox.Show("Quantity Level is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        q_level_cbx.Focus();
                        return;
                    }
                    else
                    {
                        using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                        {
                            frm_wait.ShowDialog(this);
                        }
                        setProducts(
                                date,
                                expiration,
                                product,
                                suplier,
                                price,
                                category,
                                quantity,
                                quantityLevel,
                                totalAmount
                            );
                    }
                }
                else
                {
                    updateStocks();
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

        private void updateStocks()
        {
            newStocks = int.Parse(quantity_tb.Text);
            newTotalAmount = decimal.Parse(total_amount_tb.Text);

            DateTime date = DateTime.Now;

            // Format time as "10:00 am"
            string formattedTime = date.ToString("hh:mm tt");

            // Format date as "Jan 20, 2023"
            string formattedDate = date.ToString("MMM dd, yyyy");
            DateTime parsedTime = DateTime.ParseExact(formattedTime, "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime parsedDate = DateTime.ParseExact(formattedDate, "MMM dd, yyyy", CultureInfo.InvariantCulture);
            string month = date.ToString("MMMM");
            string days = date.ToString("dddd");
            string year = date.ToString("yyyy");

            int newCurrentStocks = newStocks + oldStocks;
            int newTotalStocks = newCurrentStocks + oldTotalStocks;
            decimal newTotal = newTotalAmount + oldTotalAmount;

            try
            {
                ProductsTableAdapter products = new ProductsTableAdapter();
                products.UpdateNewStocks(
                        newCurrentStocks,
                        newTotalStocks,
                        newTotal,
                        parsedDate,
                        parsedTime,
                        days,
                        month,
                        year,
                        item
                    );
                MessageBox.Show("New stocks added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
                Hide();
            }
            catch
            {
                MessageBox.Show("Failed to add new stocks!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void setProducts(DateTime date, DateTime expiration, string product, string suplier, double price, string category, int quantity, string quantityLevel, double totalAmount)
        {
            try
            {
                // Format time as "10:00 am"
                string formattedTime = date.ToString("hh:mm tt");

                // Format date as "Jan 20, 2023"
                string formattedDate = date.ToString("MMM dd, yyyy");
                DateTime parsedTime = DateTime.ParseExact(formattedTime, "hh:mm tt", CultureInfo.InvariantCulture);
                DateTime parsedDate = DateTime.ParseExact(formattedDate, "MMM dd, yyyy", CultureInfo.InvariantCulture);
                string month = date.ToString("MMMM");
                string days = date.ToString("dddd");
                string year = date.ToString("yyyy");

                ProductsTableAdapter products = new ProductsTableAdapter();
                products.InsertProducts(
                        product,
                        0,
                        quantityLevel,
                        quantity,
                        quantity,
                        category,
                        suplier,
                        (decimal)totalAmount,
                        (decimal)price,
                        expiration,
                        parsedDate,
                        parsedTime,
                        days,
                        month,
                        year
                    );
                MessageBox.Show(product + " saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
                Hide();
            }
            catch
            {
                MessageBox.Show("Failed to saved " + item);
            }
        }

        private void quantity_tb_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                double? total;
                double price = double.Parse(price_tb.Text);
                int quantity = int.Parse(quantity_tb.Text);

                total = price * quantity;
                total_amount_tb.Text = total.ToString();
            }
            catch
            {
                total_amount_tb.Text = "0";
                return;
            }
        }
    }
}
