using Bunifu.Framework.UI;
using OMSC_MPC_CANTEEN.UserData.DataSets.InvProductTableAdapters;
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
using System.Drawing.Printing;
using OMSC_MPC_CANTEEN.UserData.DataSets.ProductsDataSetTableAdapters;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus.PrintData
{
    public partial class PrintPreview : Form
    {
        BunifuCustomDataGrid dtg;
        private PrintPreviewDialog? printPrevDialog = new PrintPreviewDialog();
        private PrintDocument? printDoc = new PrintDocument();
        Bitmap? bitmap;
        string type, title;

        public PrintPreview(BunifuCustomDataGrid dtg, string type, string title)
        {
            InitializeComponent();
            this.dtg = dtg;
            this.type = type;
            this.title = title;

            dateNow.Text = DateTime.Now.ToString("\nMM/dd/yyyy hh:mm tt\n");
            itemType.Text = type;
            title_lbl.Text = title;
            if(title.Equals("Inventory"))
            {
                getInventoryData();
            }
            else if(title.Equals("Daily Sales"))
            {
                getCategoriesData(type);
            }
            else if(title.Equals("Stocks"))
            {
                getStocks();
            }
            else if (title.Equals("Purchase Products"))
            {
                getPurchases();
            }

        }

        private void getPurchases()
        {
            dtg = DTG;
            dtg.DataSource = null;

            ProductsTableAdapter pr = new ProductsTableAdapter();
            // Retrieve the updated data from the database
            ProductsDataSet.ProductsDataTable table = pr.GetData();
            dtg.DataSource = table;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Date");
            filteredTable.Columns.Add("Suplier");
            filteredTable.Columns.Add("Item");
            filteredTable.Columns.Add("Quantity");
            filteredTable.Columns.Add("Total Amount");
            filteredTable.Columns.Add("Category");

            // Populate the filtered DataTable with the selected columns from the original DataTable
            foreach (ProductsDataSet.ProductsRow row in table.Rows)
            {
                filteredTable.Rows.Add(
                    row.DateAdded,
                    row.Suplier,
                    row.Item,
                    row.CurrentStocks + " " + row.QuantityLevel,
                    string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.TotalAmount),
                    row.Category);
            }

            dtg.DataSource = filteredTable;

            // Set the column headers
            dtg.Columns[0].HeaderText = "Date";
            dtg.Columns[1].HeaderText = "Suplier";
            dtg.Columns[2].HeaderText = "Item";
            dtg.Columns[3].HeaderText = "Quantity";
            dtg.Columns[4].HeaderText = "Total Amount";
            dtg.Columns[5].HeaderText = "Category";

            // Set the column widths
            dtg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void getStocks()
        {
            dtg = DTG;
            dtg.DataSource = null;

            ProductsTableAdapter pr = new ProductsTableAdapter();
            // Retrieve the updated data from the database
            ProductsDataSet.ProductsDataTable table = pr.GetData();
            dtg.DataSource = table;

            // Create a new DataTable with only the desired columns
            DataTable filteredTable = new DataTable();
            filteredTable.Columns.Add("Suplier");
            filteredTable.Columns.Add("Item");
            filteredTable.Columns.Add("Category");
            filteredTable.Columns.Add("CurrentStocks");
            filteredTable.Columns.Add("Price");
            filteredTable.Columns.Add("Date");

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
                        row.DateAdded);
                }
                else
                {
                    filteredTable.Rows.Add(
                        row.Suplier,
                        row.Item,
                        row.Category,
                        row.CurrentStocks,
                        string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.Price),
                        row.DateAdded);
                }
            }

            dtg.DataSource = filteredTable;

            // Set the column headers
            dtg.Columns[0].HeaderText = "Suplier";
            dtg.Columns[1].HeaderText = "Item";
            dtg.Columns[2].HeaderText = "Category";
            dtg.Columns[3].HeaderText = "Quantity";
            dtg.Columns[4].HeaderText = "Price";
            dtg.Columns[5].HeaderText = "Date";

            // Set the column widths
            dtg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void getInventoryData()
        {
            dtg = DTG;
            dtg.DataSource = null;

            InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
            InvProduct.InventoryProducts1DataTable dt = adapter.GetData();
            dtg.DataSource = dt;

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
                        row.CashSales)
                        );
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
                        string.Format(CultureInfo.CreateSpecificCulture("en-PH"), "{0:C}", row.CashSales));
                }
            }

            dtg.DataSource = filteredTable;

            // Set the column headers
            dtg.Columns[0].HeaderText = "ID";
            dtg.Columns[1].HeaderText = "Description";
            dtg.Columns[2].HeaderText = "Category";
            dtg.Columns[3].HeaderText = "Total Inventory";
            dtg.Columns[4].HeaderText = "Inventory End";
            dtg.Columns[5].HeaderText = "Quantity Sold";
            dtg.Columns[6].HeaderText = "Unit Price";
            dtg.Columns[7].HeaderText = "Cash Sales";

            // Set the column widths
            dtg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dtg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtg.Columns[0].Visible = false;

        }

        private int getEndInventory(int no, int quantitySold)
        {
            if (no == 0)
            {
                return 0;
            }
            return no - quantitySold;
        }

        public void getCategoriesData(string cat)
        {
            dtg = DTG;

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
                        dtg.Columns[10].HeaderText = "Date Added";
                        dtg.Columns[11].HeaderText = "Day Added";
                        dtg.Columns[12].HeaderText = "Month Added";
                        dtg.Columns[13].HeaderText = "Year Added";
                        dtg.Columns[14].HeaderText = "Category";
                        dtg.Columns[15].HeaderText = "Profit";

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
                        dtg.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dtg.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        dtg.Columns[0].Visible = false;
                        dtg.Columns[10].Visible = false;
                        dtg.Columns[11].Visible = false;
                        dtg.Columns[12].Visible = false;
                        dtg.Columns[13].Visible = false;
                        dtg.Columns[14].Visible = false;
                        dtg.Columns[15].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("no data found 1");
                    }
                }
                else
                {
                    MessageBox.Show("no data found");
                }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintCard(this.printPanel);
        }

        private void PrintCard(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            this.printPanel = pnl;
            getPrinterArea(pnl);
            printPrevDialog.Document = printDoc;
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_printpage);
            printPrevDialog.ShowDialog();
        }

        public void printDoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle printArea = e.MarginBounds;

            // Calculate the aspect ratio of the panel content
            float aspectRatio = (float)this.printPanel.Width / this.printPanel.Height;

            // Calculate the width and height to fit the content within the printable area
            int width = printArea.Width;
            int height = (int)(width / aspectRatio);

            // If the calculated height exceeds the printable height, adjust the height and width
            if (height > printArea.Height)
            {
                height = printArea.Height;
                width = (int)(height * aspectRatio);
            }

            // Calculate the position to center the scaled content horizontally and vertically
            int x = printArea.Left + (printArea.Width - width) / 2;
            int y = printArea.Top;

            // Draw the scaled image
            e.Graphics.DrawImage(bitmap, x, y, width, height);
        }

        private void getPrinterArea(Panel card_panel)
        {
            bitmap = new Bitmap(card_panel.Width, card_panel.Height);
            card_panel.DrawToBitmap(bitmap, new Rectangle(0, 0, card_panel.Width, card_panel.Height));
        }
    }
}
