using OMSC_MPC_CANTEEN.UserData.DataSets;
using OMSC_MPC_CANTEEN.UserData.DataSets.DailySalesReportDataSetTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.InvProductTableAdapters;
using OMSC_MPC_CANTEEN.UserData.DataSets.ProductsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    public partial class HomeDashboard : Form
    {
        private string? _userID = Dashboard.username_id;
        public HomeDashboard()
        {
            InitializeComponent();

            int currentYear = DateTime.Now.Year;

            sort_cbx.SelectedIndex = 0;

            getCostP();

            getProfit();
        }

        private void getProfit()
        {
            DailySalesReport1TableAdapter adapter = new DailySalesReport1TableAdapter();
            decimal profit = decimal.Parse(adapter.getAllProfit().GetValueOrDefault().ToString());
            profit_value.Text = FormatDecimalNumber(profit);
        }

        private void getCostP()
        {
            ProductsTableAdapter products = new ProductsTableAdapter();
            decimal purchases = decimal.Parse(products.getCostPrice().GetValueOrDefault().ToString());
            purchases_lbl.Text = FormatDecimalNumber(purchases);
        }

        private void getTotalSales()
        {
            DailySalesReport1TableAdapter adapter = new DailySalesReport1TableAdapter();

            string? sort = sort_cbx.Text;

            if (sort == "Month")
            {
                // Get the selected month and year from the combo boxes
                string? selectedSort = sort_select_cbx.Text;

                // Check if "All" is selected in the combo boxes
                bool showAllData = (selectedSort == "All");

                if (showAllData)
                {
                    double sales = Convert.ToDouble(adapter.getTotalSales().GetValueOrDefault().ToString());
                    sales_lbl.Text = FormatNumber(sales);

                    double profit = Convert.ToDouble(adapter.getAllProfit().GetValueOrDefault().ToString());
                    profit_value.Text = FormatNumber(profit);
                }
                else
                {
                    double sales = Convert.ToDouble(adapter.getTotalSalesByMonthAdded(selectedSort).GetValueOrDefault().ToString());
                    sales_lbl.Text = FormatNumber(sales);

                    double profit = Convert.ToDouble(adapter.getProfitsByMonth(selectedSort).GetValueOrDefault().ToString());
                    profit_value.Text = FormatNumber(profit);
                }
            }
            else if (sort == "Year")
            {
                // Get the selected month and year from the combo boxes
                string? selectedSort = sort_select_cbx.Text;

                // Check if "All" is selected in the combo boxes
                bool showAllData = (selectedSort == "All");

                if (showAllData)
                {
                    double sales = Convert.ToDouble(adapter.getTotalSales().GetValueOrDefault().ToString());
                    sales_lbl.Text = FormatNumber(sales);

                    double profit = Convert.ToDouble(adapter.getAllProfit().GetValueOrDefault().ToString());
                    profit_value.Text = FormatNumber(profit);
                }
                else
                {
                    double sales = Convert.ToDouble(adapter.getTotalSalesByYear(selectedSort).GetValueOrDefault().ToString());
                    sales_lbl.Text = FormatNumber(sales);

                    double profit = Convert.ToDouble(adapter.getProfitsByYear(selectedSort).GetValueOrDefault().ToString());
                    profit_value.Text = FormatNumber(profit);
                }
            }

        }//getting total sales

        private void loadChart()
        {
            DailySalesReport1TableAdapter adapter = new DailySalesReport1TableAdapter();

            ProductsTableAdapter products = new ProductsTableAdapter();
            decimal purchases = decimal.Parse(products.getCostPrice().GetValueOrDefault().ToString());

            decimal profit = decimal.Parse(adapter.getAllProfit().GetValueOrDefault().ToString());

            // Clear existing series from the chart
            dashboard_chart.Series.Clear();

            // Set the font for the axis titles, axis labels, and legend only once
            dashboard_chart.ChartAreas[0].AxisX.TitleFont = new Font("Poppins", 10, FontStyle.Italic);
            dashboard_chart.ChartAreas[0].AxisY.TitleFont = new Font("Poppins", 10, FontStyle.Italic);
            dashboard_chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Poppins", 8, FontStyle.Italic);
            dashboard_chart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Poppins", 8, FontStyle.Italic);
            dashboard_chart.Legends[0].Font = new Font("Poppins", 6, FontStyle.Bold);
            dashboard_chart.ChartAreas[0].IsSameFontSizeForAllAxes = true;

            string? sort = sort_cbx.Text;

            SeriesChartType chartType = SeriesChartType.Column;

            Series SalesSeries = new Series("Monthly Sales");
            Series YearlySalesSeries = new Series("Yearly Sales");
            Series CostPriceSeries = new Series("Cost Price");
            Series ProfitSeries = new Series("Profit");

            //cost price series
            // Add a new series for the dashboard_chart
            dashboard_chart.Series.Add(CostPriceSeries);

            CostPriceSeries.ChartType = chartType;
            CostPriceSeries.BorderColor = Color.FromArgb(72, 114, 203);
            CostPriceSeries.Color = Color.FromArgb(72, 114, 203);
            CostPriceSeries.BorderWidth = 2;

            CostPriceSeries.Points.AddXY("Total Data", purchases);
            CostPriceSeries["PointWidth"] = "1";
            CostPriceSeries.Points[0].ToolTip = $"Cost Price: {purchases:C}"; // Add tooltip for the first data point

            //profit series
            // Add a new series for the dashboard_chart
            dashboard_chart.Series.Add(ProfitSeries);

            ProfitSeries.ChartType = chartType;
            ProfitSeries.BorderColor = Color.FromArgb(49, 149, 91);
            ProfitSeries.Color = Color.FromArgb(49, 149, 91);
            ProfitSeries.BorderWidth = 2;

            ProfitSeries.Points.AddXY("", profit);
            ProfitSeries["PointWidth"] = ".8";
            ProfitSeries.Points[0].ToolTip = $"Profit: {profit:C}"; // Add tooltip for the first data point

            if (sort == "Month")
            {
                // Get the selected month and year from the combo boxes
                string? selectedMonth = sort_select_cbx.Text;
            
                // Check if "All" is selected in the combo boxes
                bool showAllData = (selectedMonth == "All");
            
                // Create a dictionary to store month-wise sales
                Dictionary<string, double> monthSales = new Dictionary<string, double>();
            
                if (showAllData)
                {
                    double sales = (double)adapter.getTotalSales().GetValueOrDefault();
                    // Add a new series for the dashboard_chart

                    SalesSeries.Points.AddXY("All Month Sales", sales);
                    // Set point width to add margin between columns
                    SalesSeries["PointWidth"] = "1";
                    SalesSeries.ToolTip = $"All Month Sales : {sales:C}";
                }
                else
                {
                    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\adrle\\source\\repos\\OMSC-MPC CANTEEN\\OMSC-MPC CANTEEN\\bin\\Debug\\net7.0-windows\\OmscCanteen.accdb\";Persist Security Info=True";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "SELECT DISTINCT MonthAdded FROM DailySalesReport WHERE MonthAdded = '" + selectedMonth + "'";

                        using (OleDbDataAdapter oleAdapter = new OleDbDataAdapter(query, connection))
                        {
                            DataTable dataTable = new DataTable();
                            oleAdapter.Fill(dataTable);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string? monthObject = row["MonthAdded"].ToString();

                                double sales = (double)adapter.getTotalSalesByMonthAdded(monthObject).GetValueOrDefault();
                                monthSales.Add(monthObject, sales);
                            }

                        }
                    }
                }
            
                // Sort the months in the desired order (e.g., chronological order)
                var sortedMonthSales = monthSales.OrderBy(kv => DateTime.ParseExact(kv.Key, "MMMM", CultureInfo.InvariantCulture).Month);
            
                // Add a new series for the dashboard_chart
                dashboard_chart.Series.Add(SalesSeries);
                
                SalesSeries.ChartType = chartType;
                SalesSeries.BorderColor = Color.FromArgb(43, 47, 84);
                SalesSeries.Color = Color.FromArgb(43, 47, 84);
                SalesSeries.BorderWidth = 1;
                
                // Add data points for each month to the dashboard_chart
                foreach (var entry in sortedMonthSales)
                {
                    SalesSeries.Points.AddXY(entry.Key, entry.Value);
                    // Set point width to add margin between columns
                    SalesSeries["PointWidth"] = "1";
                    SalesSeries.ToolTip = $"Sales for {entry.Key}: {entry.Value:C}"; // Add tooltip for each data point
                }
            }
            else if (sort == "Year")
            {
                // Get the selected year from the combo boxes
                string? selectedYear = sort_select_cbx.Text;

                // Check if "All" is selected in the combo boxes
                bool showAllData = (selectedYear == "All");

                // Create a dictionary to store month-wise sales
                Dictionary<string, double> yearSales = new Dictionary<string, double>();

                if (showAllData)
                {
                    double sales = (double)adapter.getTotalSales().GetValueOrDefault();
                    // Add a new series for the dashboard_chart

                    YearlySalesSeries.Points.AddXY("All Year Sales", sales);
                    // Set point width to add margin between columns
                    YearlySalesSeries["PointWidth"] = "1";
                    YearlySalesSeries.ToolTip = $"All Year Sales : {sales:C}";
                }
                else
                {
                    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\adrle\\source\\repos\\OMSC-MPC CANTEEN\\OMSC-MPC CANTEEN\\bin\\Debug\\net7.0-windows\\OmscCanteen.accdb\";Persist Security Info=True";
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "SELECT DISTINCT YearAdded FROM DailySalesReport WHERE YearAdded = '" + selectedYear + "'";

                        using (OleDbDataAdapter oleAdapter = new OleDbDataAdapter(query, connection))
                        {
                            DataTable dataTable = new DataTable();
                            oleAdapter.Fill(dataTable);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string? year = row["YearAdded"].ToString();

                                double sales = (double)adapter.getTotalSalesByYear(year).GetValueOrDefault();
                                yearSales.Add(year, sales);
                            }

                        }
                    }
                }

                // Sort the months in the desired order (e.g., chronological order)
                var sortedMonthSales = yearSales.OrderBy(kv => DateTime.ParseExact(kv.Key, "yyyy", CultureInfo.InvariantCulture).Year);

                // Add a new series for the dashboard_chart
                // Add a new series for the dashboard_chart
                dashboard_chart.Series.Add(YearlySalesSeries);
                YearlySalesSeries.ChartType = SeriesChartType.Column;
                YearlySalesSeries.BorderColor = Color.FromArgb(43, 47, 84);
                YearlySalesSeries.Color = Color.FromArgb(43, 47, 84);
                YearlySalesSeries.BorderWidth = 1;

                // Add data points for each month to the dashboard_chart
                foreach (var entry in sortedMonthSales)
                {
                    YearlySalesSeries.Points.AddXY(entry.Key, entry.Value);
                    // Set point width to add margin between columns
                    YearlySalesSeries["PointWidth"] = "1";
                    YearlySalesSeries.ToolTip = $"Sales for Year {entry.Key}: {entry.Value:C}"; // Add tooltip for each data
                }
            }

        }//load chart data

        private string FormatNumber(double value)
        {
            CultureInfo phCulture = new CultureInfo("en-PH");
            if (value > 100000)
            {
                return string.Format(phCulture, "₱{0:#,#.#}k", value / 1000);
            }
            else
            {
                return string.Format(phCulture, "₱{0:#,#.00}", value);
            }
        }//format currency if number is greater than 1000 i will be 1k

        private string FormatDecimalNumber(decimal value)
        {
            CultureInfo phCulture = new CultureInfo("en-PH");
            if (value > 100000)
            {
                return string.Format(phCulture, "₱{0:#,#.#}k", value / 1000);
            }
            else
            {
                return string.Format(phCulture, "₱{0:#,#.00}", value);
            }
        }//format currency if number is greater than 1000 i will be 1k

        private void sort_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear items from comboBox2
            sort_select_cbx.Items.Clear();

            string? selectedCat = sort_cbx.SelectedItem.ToString();

            if (selectedCat == "Month")
            {
                sort_select_cbx.Items.Add("All");
                sort_select_cbx.Items.Add("January");
                sort_select_cbx.Items.Add("February");
                sort_select_cbx.Items.Add("March");
                sort_select_cbx.Items.Add("April");
                sort_select_cbx.Items.Add("May");
                sort_select_cbx.Items.Add("June");
                sort_select_cbx.Items.Add("July");
                sort_select_cbx.Items.Add("August");
                sort_select_cbx.Items.Add("September");
                sort_select_cbx.Items.Add("October");
                sort_select_cbx.Items.Add("November");
                sort_select_cbx.Items.Add("December");

                sort_select_cbx.SelectedIndex = 0;
            }
            else if (selectedCat == "Year")
            {
                sort_select_cbx.Items.Add("All");

                int currentYear = DateTime.Now.Year;

                for (int year = 2000; year <= currentYear; year++)
                {
                    sort_select_cbx.Items.Add(year.ToString());
                }

                sort_select_cbx.SelectedIndex = 0;
            }
        }

        private void sort_select_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTotalSales();
            loadChart();
        }
    }
}
