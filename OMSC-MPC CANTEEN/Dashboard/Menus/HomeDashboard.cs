using OMSC_MPC_CANTEEN.UserData.DataSets;
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
            InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();
            decimal profit = decimal.Parse(adapter.getProfits().GetValueOrDefault().ToString());
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
            InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();

            string? sort = sort_cbx.Text;

            if (sort == "Month")
            {
                // Get the selected month and year from the combo boxes
                string? selectedSort = sort_select_cbx.Text;

                // Check if "All" is selected in the combo boxes
                bool showAllData = (selectedSort == "All");

                if (showAllData)
                {
                    double sales = Convert.ToDouble(adapter.getCashSalesAll().GetValueOrDefault().ToString());
                    sales_lbl.Text = FormatNumber(sales);
                }
                else
                {
                    double sales = Convert.ToDouble(adapter.getCashSalesByMonth(selectedSort).GetValueOrDefault().ToString());
                    sales_lbl.Text = FormatNumber(sales);
                }
            }
            else if (sort == "Year")
            {
                // Get the selected month and year from the combo boxes
                string? selectedSort = sort_select_cbx.Text;

                double sales = Convert.ToDouble(adapter.getCashSalesByYear(selectedSort).GetValueOrDefault().ToString());
                sales_lbl.Text = FormatNumber(sales);
            }

        }//getting total sales

        private void loadChart()
        {
            InventoryProducts1TableAdapter adapter = new InventoryProducts1TableAdapter();

            // Clear existing series from the chart
            dashboard_chart.Series.Clear();

            string? sort = sort_cbx.Text;

            SeriesChartType chartType;

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
                    // When "All" is selected, retrieve data for all months
                    DataTable allMonthsData = adapter.GetDistinctMonths();

                    foreach (DataRow row in allMonthsData.Rows)
                    {
                        string? month = row["MonthsAdded"].ToString();
                        double sales = (double)adapter.getCashSalesByMonth(month).GetValueOrDefault();
                        monthSales.Add(month, sales);
                    }

                    chartType = SeriesChartType.Column;
                }
                else
                {
                    // Retrieve data for the selected month and year
                    DataTable selectedMonthData = adapter.GetDistinctMonthsByMonth(selectedMonth);

                    foreach (DataRow row in selectedMonthData.Rows)
                    {
                        string? month = row["MonthsAdded"].ToString();
                        double sales = (double)adapter.getCashSalesByMonth(month).GetValueOrDefault();
                        monthSales.Add(month, sales);
                    }

                    chartType = SeriesChartType.Column;
                }

                // Sort the months in the desired order (e.g., chronological order)
                var sortedMonthSales = monthSales.OrderBy(kv => DateTime.ParseExact(kv.Key, "MMMM", CultureInfo.InvariantCulture).Month);

                // Add a new series for the dashboard_chart
                dashboard_chart.Series.Add("Monthly Sales");

                // Set the font for the axis titles
                dashboard_chart.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 10, FontStyle.Italic);
                dashboard_chart.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 10, FontStyle.Italic);

                // Set the font for the axis labels
                dashboard_chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Century Gothic", 8, FontStyle.Italic);
                dashboard_chart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Century Gothic", 8, FontStyle.Italic);

                // Set the font for the legend
                dashboard_chart.Legends[0].Font = new Font("Century Gothic", 6, FontStyle.Bold);

                dashboard_chart.Series["Monthly Sales"].ChartType = chartType;
                dashboard_chart.Series["Monthly Sales"].BorderColor = Color.FromArgb(43, 47, 84);
                dashboard_chart.Series["Monthly Sales"].Color = Color.FromArgb(43, 47, 84);
                dashboard_chart.Series["Monthly Sales"].BorderWidth = 2;

                // Add data points for each month to the dashboard_chart
                foreach (var entry in sortedMonthSales)
                {
                    dashboard_chart.Series["Monthly Sales"].Points.AddXY(entry.Key, entry.Value);
                }
            }
            else if (sort == "Year")
            {
                // Get the selected year from the combo boxes
                string? selectedYear = sort_select_cbx.Text;

                // Create a dictionary to store month-wise sales
                Dictionary<string, double> yearSales = new Dictionary<string, double>();

                // When "All" is selected, retrieve data for all months
                DataTable allYearsData = adapter.GetDistinctMonthsByYear(selectedYear);

                foreach (DataRow row in allYearsData.Rows)
                {
                    string? month = row["MonthsAdded"].ToString();
                    double sales = (double)adapter.getCashSalesByMonth(month).GetValueOrDefault();
                    yearSales.Add(month, sales);
                }

                // Sort the months in the desired order (e.g., chronological order)
                var sortedMonthSales = yearSales.OrderBy(kv => DateTime.ParseExact(kv.Key, "MMMM", CultureInfo.InvariantCulture).Month);

                // Add a new series for the dashboard_chart
                dashboard_chart.Series.Add("Yearly Sales");
                dashboard_chart.Series["Yearly Sales"].ChartType = SeriesChartType.Area;

                // Add data points for each month to the dashboard_chart
                foreach (var entry in sortedMonthSales)
                {
                    dashboard_chart.Series["Yearly Sales"].Points.AddXY(entry.Key, entry.Value);
                }
            }

        }//load chart data

        private string FormatNumber(double value)
        {
            CultureInfo phCulture = new CultureInfo("en-PH");
            if (value > 10000)
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
            if (value > 10000)
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
                sort_select_cbx.Items.Add("2019");
                sort_select_cbx.Items.Add("2020");
                sort_select_cbx.Items.Add("2021");
                sort_select_cbx.Items.Add("2022");
                sort_select_cbx.Items.Add("2023");

                int currentYear = DateTime.Now.Year;

                sort_select_cbx.Text = currentYear.ToString();
            }
        }

        private void sort_select_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTotalSales();
            loadChart();
        }
    }
}
