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
using OMSC_MPC_CANTEEN.Dashboard.Menus.InventoryForms;
using OMSC_MPC_CANTEEN.UserData.DataSets.InvProductTableAdapters;
using OMSC_MPC_CANTEEN.Dashboard.Menus.Products;
using OMSC_MPC_CANTEEN.Dashboard.Menus.PrintData;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    public partial class Stocks : Form
    {
        bool isHasStocks;

        public Stocks()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            STOCKS_DTG.DataSource = null;

            ProductsTableAdapter pr = new ProductsTableAdapter();
            // Retrieve the updated data from the database
            ProductsDataSet.ProductsDataTable table = pr.GetData();
            STOCKS_DTG.DataSource = table;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Suplier");
            filteredTable.Columns.Add("Item");
            filteredTable.Columns.Add("Category");
            filteredTable.Columns.Add("CurrentStocks");
            filteredTable.Columns.Add("Price");
            filteredTable.Columns.Add("Date");
            filteredTable.Columns.Add("Warning", typeof(Image));
            filteredTable.Columns.Add("Edit", typeof(Image));
            filteredTable.Columns.Add("Delete", typeof(Image));

            // Populate the filtered DataTable with the selected columns from the original DataTable
            foreach (ProductsDataSet.ProductsRow row in table.Rows)
            {
                if (row.CurrentStocks <= 10)
                {
                    filteredTable.Rows.Add(
                        row.Suplier,
                        row.Item,
                        row.Category,
                        row.CurrentStocks,
                        string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price),
                        row.DateAdded,
                        Properties.Resources.warning_small,
                        Properties.Resources.edit_small,
                        Properties.Resources.trash);
                }
                else
                {
                    filteredTable.Rows.Add(
                        row.Suplier,
                        row.Item,
                        row.Category,
                        row.CurrentStocks,
                        string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price),
                        row.DateAdded,
                        Properties.Resources.badge_check,
                        Properties.Resources.badge_check,
                        Properties.Resources.trash);
                }
            }

            STOCKS_DTG.DataSource = filteredTable;

            // Set the column headers
            STOCKS_DTG.Columns[0].HeaderText = "Suplier";
            STOCKS_DTG.Columns[1].HeaderText = "Item";
            STOCKS_DTG.Columns[2].HeaderText = "Category";
            STOCKS_DTG.Columns[3].HeaderText = "Quantity";
            STOCKS_DTG.Columns[4].HeaderText = "Price";
            STOCKS_DTG.Columns[5].HeaderText = "Date";
            STOCKS_DTG.Columns[6].HeaderText = "Warning";
            STOCKS_DTG.Columns[7].HeaderText = "Edit";
            STOCKS_DTG.Columns[8].HeaderText = "Delete";

            // Set the column widths
            STOCKS_DTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            STOCKS_DTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            STOCKS_DTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            STOCKS_DTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            STOCKS_DTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            STOCKS_DTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            STOCKS_DTG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STOCKS_DTG.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STOCKS_DTG.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Set the padding and size of the icon
            STOCKS_DTG.Columns[6].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            STOCKS_DTG.Columns[6].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            STOCKS_DTG.Columns[6].Width = 30; // Adjust the width of the icon column

            // Set the padding and size of the icon
            STOCKS_DTG.Columns[7].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            STOCKS_DTG.Columns[7].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            STOCKS_DTG.Columns[7].Width = 30; // Adjust the width of the icon column

            // Set the padding and size of the icon
            STOCKS_DTG.Columns[8].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            STOCKS_DTG.Columns[8].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            STOCKS_DTG.Columns[8].Width = 30; // Adjust the width of the icon column

            // Add the CellFormatting event to set the tooltip for the Warning column
            STOCKS_DTG.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < STOCKS_DTG.Rows.Count)
                {
                    DataGridViewCell cell = STOCKS_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string? quantity = STOCKS_DTG.Rows[e.RowIndex].Cells["CurrentStocks"].Value.ToString();
                    int currentQuantity = int.Parse(quantity);

                    if (currentQuantity <= 10)
                    {
                        cell.ToolTipText = STOCKS_DTG.Rows[e.RowIndex].Cells["Item"].Value.ToString() + " is low stock!\nClick edit to add more stocks.";
                    }
                    else
                    {
                        cell.ToolTipText = STOCKS_DTG.Rows[e.RowIndex].Cells["Item"].Value.ToString() + " has stocks available.";
                    }
                }
                else if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < STOCKS_DTG.Rows.Count)
                {
                    DataGridViewCell cell = STOCKS_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string? quantity = STOCKS_DTG.Rows[e.RowIndex].Cells["CurrentStocks"].Value.ToString();
                    int currentQuantity = int.Parse(quantity);
                    if (currentQuantity <= 10)
                    {
                        cell.ToolTipText = "Edit " + STOCKS_DTG.Rows[e.RowIndex].Cells["Item"].Value.ToString() + "?";
                    }
                    else
                    {
                        cell.ToolTipText = STOCKS_DTG.Rows[e.RowIndex].Cells["Item"].Value.ToString() + " has stocks available.";
                    }
                }
                else if (e.ColumnIndex == 8 && e.RowIndex >= 0 && e.RowIndex < STOCKS_DTG.Rows.Count)
                {
                    DataGridViewCell cell = STOCKS_DTG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.ToolTipText = "Delete " + STOCKS_DTG.Rows[e.RowIndex].Cells["Item"].Value.ToString() + "?";
                }
            };
        }

        private void print_btn_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(print_btn, "Print");
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            /*DGVPrinter printer = new DGVPrinter();
            printer.Title = "Stocks";
            printer.SubTitle = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "List of Stocks";
            printer.FooterSpacing = 15;
            // Adjust column widths to fit on one page, excluding the last column
            printer.PageSettings.Landscape = false; // Set to true if you want landscape orientation

            for (int i = 0; i < STOCKS_DTG.Columns.Count - 1; i++)
            {
                STOCKS_DTG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            printer.PrintDataGridView(STOCKS_DTG);*/

            PrintPreview print = new PrintPreview(STOCKS_DTG, "", "Stocks");
            print.ShowDialog();
        }

        private void STOCKS_DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = STOCKS_DTG.Rows[e.RowIndex];
                string? item = selectedRow.Cells["Item"].Value.ToString();

                if (STOCKS_DTG.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + item + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ProductsTableAdapter product = new ProductsTableAdapter();
                        product.DeleteProducts(item);
                        loadData();
                    }
                }

                if (STOCKS_DTG.Columns[e.ColumnIndex].Name == "Edit")
                {
                    // Check the cell value (image) to determine which icon was clicked
                    DataGridViewImageCell cell = (DataGridViewImageCell)STOCKS_DTG.Rows[e.RowIndex].Cells["Edit"];
                    Image cellImage = (Image)cell.Value;

                    if (cellImage != null)
                    {

                        byte[] editSmallBytes = ImageToByteArray(Properties.Resources.edit_small);
                        byte[] cellImageBytes = ImageToByteArray(cellImage);

                        bool imagesMatch = ByteArrayEquals(editSmallBytes, cellImageBytes);

                        if (imagesMatch)
                        {
                            AddProducts addNew = new AddProducts(STOCKS_DTG, item);
                            addNew.ShowDialog();
                        }
                    }
                }
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private bool ByteArrayEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
