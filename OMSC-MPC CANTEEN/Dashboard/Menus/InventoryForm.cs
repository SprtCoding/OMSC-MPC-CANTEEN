using OMSC_MPC_CANTEEN.Dashboard.Menus.InventoryForms;
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
using OMSC_MPC_CANTEEN.UserData.DataSets.DailySalesDataSetTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.InvProductTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Cryptography;
using DGVPrinterHelper;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    public partial class InventoryForm : Form
    {
        private string? _userID = Dashboard.username_id;
        public InventoryForm()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            INVENTORY_DTG.DataSource = null;

            InventoryProductsTableAdapter adapter = new InventoryProductsTableAdapter();
            InvProduct.InventoryProductsDataTable dt = adapter.GetData();
            INVENTORY_DTG.DataSource = dt;

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

            INVENTORY_DTG.DataSource = filteredTable;

            // Set the column headers
            INVENTORY_DTG.Columns[0].HeaderText = "Description";
            INVENTORY_DTG.Columns[1].HeaderText = "Total Inventory";
            INVENTORY_DTG.Columns[2].HeaderText = "Inventory End";
            INVENTORY_DTG.Columns[3].HeaderText = "Quantity Sold";
            INVENTORY_DTG.Columns[4].HeaderText = "Unit Price";
            INVENTORY_DTG.Columns[5].HeaderText = "Cash Sales";
            INVENTORY_DTG.Columns[6].HeaderText = "Warning";
            INVENTORY_DTG.Columns[7].HeaderText = "Edit";
            INVENTORY_DTG.Columns[8].HeaderText = "Delete";

            // Set the column widths
            INVENTORY_DTG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            INVENTORY_DTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            INVENTORY_DTG.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Set the padding and size of the icon
            INVENTORY_DTG.Columns[6].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            INVENTORY_DTG.Columns[6].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            INVENTORY_DTG.Columns[6].Width = 30; // Adjust the width of the icon column

            // Set the padding and size of the icon
            INVENTORY_DTG.Columns[7].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            INVENTORY_DTG.Columns[7].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            INVENTORY_DTG.Columns[7].Width = 30; // Adjust the width of the icon column

            // Set the padding and size of the icon
            INVENTORY_DTG.Columns[8].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); // Adjust the padding values to resize the icon
            INVENTORY_DTG.Columns[8].DefaultCellStyle.NullValue = null; // Remove the default null value display for the image column
            INVENTORY_DTG.Columns[8].Width = 30; // Adjust the width of the icon column

        }

        private void add_new_btn_Click(object sender, EventArgs e)
        {
            AddInventory addNew = new AddInventory(INVENTORY_DTG, "");
            addNew.ShowDialog();
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

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void INVENTORY_DTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = INVENTORY_DTG.Rows[e.RowIndex];
                string? item = selectedRow.Cells["Description"].Value.ToString();
                string? current_quantity = selectedRow.Cells["Inventory End"].Value.ToString();

                if (INVENTORY_DTG.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + item + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        InventoryProductsTableAdapter adapter = new InventoryProductsTableAdapter();
                        adapter.DeleteFromInventory(item);
                        loadData();
                    }
                }

                if (INVENTORY_DTG.Columns[e.ColumnIndex].Name == "Edit")
                {
                    // Check the cell value (image) to determine which icon was clicked
                    DataGridViewImageCell cell = (DataGridViewImageCell)INVENTORY_DTG.Rows[e.RowIndex].Cells["Edit"];
                    Image cellImage = (Image)cell.Value;

                    if (cellImage != null)
                    {

                        byte[] editSmallBytes = ImageToByteArray(Properties.Resources.edit_small);
                        byte[] cellImageBytes = ImageToByteArray(cellImage);

                        bool imagesMatch = ByteArrayEquals(editSmallBytes, cellImageBytes);

                        if (imagesMatch)
                        {
                            AddInventory addNew = new AddInventory(INVENTORY_DTG, item);
                            addNew.ShowDialog();
                        }
                    }
                }
            }
        }

        private void print_btn_MouseEnter(object sender, EventArgs e)
        {
            print_tooltip.SetToolTip(print_btn, "Print");
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Inventory";
            printer.SubTitle = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "List of Inventory";
            printer.FooterSpacing = 15;
            // Adjust column widths to fit on one page, excluding the last column
            printer.PageSettings.Landscape = false; // Set to true if you want landscape orientation

            for (int i = 0; i < INVENTORY_DTG.Columns.Count - 1; i++)
            {
                INVENTORY_DTG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            printer.PrintDataGridView(INVENTORY_DTG);
        }
    }
}
