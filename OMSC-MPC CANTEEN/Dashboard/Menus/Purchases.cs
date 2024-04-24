using OMSC_MPC_CANTEEN.Dashboard.Menus.Products;
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
using OMSC_MPC_CANTEEN.Dashboard.Menus.PrintData;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    public partial class Purchases : Form
    {
        public Purchases()
        {
            InitializeComponent();
            loadData();
        }

        private void add_new_btn_Click(object sender, EventArgs e)
        {
            AddProducts products = new AddProducts(PURCHASES_DTG, "");
            products.ShowDialog();
        }

        private void loadData()
        {
            PURCHASES_DTG.DataSource = null;

            ProductsTableAdapter pr = new ProductsTableAdapter();
            // Retrieve the updated data from the database
            ProductsDataSet.ProductsDataTable table = pr.GetData();
            PURCHASES_DTG.DataSource = table;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Date");
            filteredTable.Columns.Add("Suplier");
            filteredTable.Columns.Add("Item");
            filteredTable.Columns.Add("Quantity");
            filteredTable.Columns.Add("Total Amount");
            filteredTable.Columns.Add("Category");
            filteredTable.Columns.Add("Delete", typeof(Image));

            // Populate the filtered DataTable with the selected columns from the original DataTable
            foreach (ProductsDataSet.ProductsRow row in table.Rows)
            {
                filteredTable.Rows.Add(
                    row.DateAdded,
                    row.Suplier,
                    row.Item,
                    row.CurrentStocks + " " + row.QuantityLevel,
                    string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.TotalAmount),
                    row.Category,
                    Properties.Resources.trash);
            }

            PURCHASES_DTG.DataSource = filteredTable;

            // Set the column headers
            PURCHASES_DTG.Columns[0].HeaderText = "Date";
            PURCHASES_DTG.Columns[1].HeaderText = "Suplier";
            PURCHASES_DTG.Columns[2].HeaderText = "Item";
            PURCHASES_DTG.Columns[3].HeaderText = "Quantity";
            PURCHASES_DTG.Columns[4].HeaderText = "Total Amount";
            PURCHASES_DTG.Columns[5].HeaderText = "Category";
            PURCHASES_DTG.Columns[6].HeaderText = "Action";

            // Set the column widths
            PURCHASES_DTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PURCHASES_DTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PURCHASES_DTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PURCHASES_DTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PURCHASES_DTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PURCHASES_DTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PURCHASES_DTG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Set the padding and size of the icon
            PURCHASES_DTG.Columns[6].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            PURCHASES_DTG.Columns[6].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            PURCHASES_DTG.Columns[6].Width = 30; // Adjust the width of the icon column

            // Add the CellFormatting event to set the tooltip for the Warning column
            PURCHASES_DTG.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < PURCHASES_DTG.Rows.Count)
                {
                    DataGridViewCell cell = PURCHASES_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.ToolTipText = "Delete " + PURCHASES_DTG.Rows[e.RowIndex].Cells["Item"].Value.ToString() + "?";
                }
            };
        }

        private void print_btn_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(print_btn, "Print");
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
           /* DGVPrinter printer = new DGVPrinter();
            printer.Title = "Purchase Products";
            printer.SubTitle = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "List of Purchases";
            printer.FooterSpacing = 15;
            // Adjust column widths to fit on one page, excluding the last column
            printer.PageSettings.Landscape = false; // Set to true if you want landscape orientation

            for (int i = 0; i < PURCHASES_DTG.Columns.Count - 1; i++)
            {
                PURCHASES_DTG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            printer.PrintDataGridView(PURCHASES_DTG);*/

            PrintPreview print = new PrintPreview(PURCHASES_DTG, "", "Purchase Products");
            print.ShowDialog();
        }

        private void PURCHASES_DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = PURCHASES_DTG.Rows[e.RowIndex];
                string? item = selectedRow.Cells["Item"].Value.ToString();

                if (PURCHASES_DTG.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + item + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //InventoryProductsTableAdapter adapter = new InventoryProductsTableAdapter();
                        //adapter.DeleteFromInventory(item);
                        //loadData();
                        ProductsTableAdapter product = new ProductsTableAdapter();
                        product.DeleteProducts(item);
                        loadData();
                    }
                }
            }
        }
    }
}
