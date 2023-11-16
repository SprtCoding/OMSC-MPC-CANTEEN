namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    partial class HomeDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel1 = new Panel();
            sort_select_cbx = new ComboBox();
            sort_cbx = new ComboBox();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            sale_panel = new Panel();
            profit_value = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            profit_panel = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            purchases_lbl = new Label();
            purchase_panel = new Panel();
            sales_lbl = new Label();
            label11 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            dashboard_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(components);
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            pie_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            sale_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            profit_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            purchase_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dashboard_chart).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pie_chart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 34);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.79395F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.206049F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 38);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(747, 50);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(530, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 46);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(sort_select_cbx);
            panel1.Controls.Add(sort_cbx);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 46);
            panel1.TabIndex = 0;
            // 
            // sort_select_cbx
            // 
            sort_select_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            sort_select_cbx.FlatStyle = FlatStyle.Flat;
            sort_select_cbx.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sort_select_cbx.FormattingEnabled = true;
            sort_select_cbx.IntegralHeight = false;
            sort_select_cbx.Location = new Point(175, 6);
            sort_select_cbx.Margin = new Padding(2);
            sort_select_cbx.Name = "sort_select_cbx";
            sort_select_cbx.Size = new Size(295, 34);
            sort_select_cbx.TabIndex = 4;
            sort_select_cbx.SelectedIndexChanged += sort_select_cbx_SelectedIndexChanged;
            // 
            // sort_cbx
            // 
            sort_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            sort_cbx.FlatStyle = FlatStyle.Flat;
            sort_cbx.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            sort_cbx.FormattingEnabled = true;
            sort_cbx.IntegralHeight = false;
            sort_cbx.Items.AddRange(new object[] { "Month", "Year" });
            sort_cbx.Location = new Point(71, 6);
            sort_cbx.Margin = new Padding(2);
            sort_cbx.Name = "sort_cbx";
            sort_cbx.Size = new Size(100, 34);
            sort_cbx.TabIndex = 3;
            sort_cbx.SelectedIndexChanged += sort_cbx_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 22);
            label2.TabIndex = 2;
            label2.Text = "Sort By:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(sale_panel, 2, 0);
            tableLayoutPanel2.Controls.Add(profit_panel, 1, 0);
            tableLayoutPanel2.Controls.Add(purchase_panel, 0, 0);
            tableLayoutPanel2.Location = new Point(8, 92);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(747, 220);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // sale_panel
            // 
            sale_panel.BackColor = Color.FromArgb(49, 149, 91);
            sale_panel.Controls.Add(profit_value);
            sale_panel.Controls.Add(label10);
            sale_panel.Controls.Add(pictureBox2);
            sale_panel.Controls.Add(label7);
            sale_panel.Dock = DockStyle.Fill;
            sale_panel.Location = new Point(502, 3);
            sale_panel.Margin = new Padding(4, 3, 4, 3);
            sale_panel.Name = "sale_panel";
            sale_panel.Size = new Size(241, 214);
            sale_panel.TabIndex = 2;
            // 
            // profit_value
            // 
            profit_value.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profit_value.Font = new Font("Poppins", 30F, FontStyle.Bold, GraphicsUnit.Point);
            profit_value.ForeColor = Color.WhiteSmoke;
            profit_value.Location = new Point(7, 57);
            profit_value.Margin = new Padding(2, 0, 2, 0);
            profit_value.Name = "profit_value";
            profit_value.Size = new Size(222, 119);
            profit_value.TabIndex = 11;
            profit_value.Text = "0";
            profit_value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(8, 182);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 6;
            label10.Text = "Total Profit";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.chart_histogram;
            pictureBox2.Location = new Point(183, 16);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(8, 9);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 28);
            label7.TabIndex = 10;
            label7.Text = "Profit";
            // 
            // profit_panel
            // 
            profit_panel.BackColor = Color.FromArgb(72, 114, 203);
            profit_panel.Controls.Add(label8);
            profit_panel.Controls.Add(pictureBox1);
            profit_panel.Controls.Add(label4);
            profit_panel.Controls.Add(purchases_lbl);
            profit_panel.Dock = DockStyle.Fill;
            profit_panel.Location = new Point(253, 3);
            profit_panel.Margin = new Padding(4, 3, 4, 3);
            profit_panel.Name = "profit_panel";
            profit_panel.Size = new Size(241, 214);
            profit_panel.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(10, 182);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(120, 25);
            label8.TabIndex = 10;
            label8.Text = "Total Cost Price";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(184, 16);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(8, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 3;
            label4.Text = "Cost Price";
            // 
            // purchases_lbl
            // 
            purchases_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            purchases_lbl.Font = new Font("Poppins", 30F, FontStyle.Bold, GraphicsUnit.Point);
            purchases_lbl.ForeColor = Color.WhiteSmoke;
            purchases_lbl.Location = new Point(10, 57);
            purchases_lbl.Margin = new Padding(2, 0, 2, 0);
            purchases_lbl.Name = "purchases_lbl";
            purchases_lbl.Size = new Size(221, 119);
            purchases_lbl.TabIndex = 4;
            purchases_lbl.Text = "0";
            purchases_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // purchase_panel
            // 
            purchase_panel.BackColor = Color.FromArgb(43, 47, 84);
            purchase_panel.Controls.Add(sales_lbl);
            purchase_panel.Controls.Add(label11);
            purchase_panel.Controls.Add(pictureBox3);
            purchase_panel.Controls.Add(label9);
            purchase_panel.Dock = DockStyle.Fill;
            purchase_panel.Location = new Point(4, 3);
            purchase_panel.Margin = new Padding(4, 3, 4, 3);
            purchase_panel.Name = "purchase_panel";
            purchase_panel.Size = new Size(241, 214);
            purchase_panel.TabIndex = 0;
            // 
            // sales_lbl
            // 
            sales_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sales_lbl.Font = new Font("Poppins", 30F, FontStyle.Bold, GraphicsUnit.Point);
            sales_lbl.ForeColor = Color.WhiteSmoke;
            sales_lbl.Location = new Point(8, 57);
            sales_lbl.Margin = new Padding(2, 0, 2, 0);
            sales_lbl.Name = "sales_lbl";
            sales_lbl.Size = new Size(221, 119);
            sales_lbl.TabIndex = 9;
            sales_lbl.Text = "0";
            sales_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Poppins", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(8, 182);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(86, 25);
            label11.TabIndex = 7;
            label11.Text = "Total Sales";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.money_graph_with_up_arrow;
            pictureBox3.Location = new Point(183, 16);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(8, 9);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 28);
            label9.TabIndex = 7;
            label9.Text = "Sales";
            // 
            // dashboard_chart
            // 
            chartArea1.AxisX.TitleFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.AxisX2.TitleFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.AxisY.TitleFont = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.AxisY2.TitleFont = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.Name = "ChartArea1";
            dashboard_chart.ChartAreas.Add(chartArea1);
            dashboard_chart.Dock = DockStyle.Fill;
            legend1.BackColor = Color.FromArgb(248, 195, 23);
            legend1.Name = "Legend1";
            dashboard_chart.Legends.Add(legend1);
            dashboard_chart.Location = new Point(0, 0);
            dashboard_chart.Margin = new Padding(2);
            dashboard_chart.Name = "dashboard_chart";
            dashboard_chart.Size = new Size(496, 223);
            dashboard_chart.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 20;
            bunifuElipse1.TargetControl = purchase_panel;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 20;
            bunifuElipse2.TargetControl = profit_panel;
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 20;
            bunifuElipse3.TargetControl = sale_panel;
            // 
            // bunifuElipse4
            // 
            bunifuElipse4.ElipseRadius = 10;
            bunifuElipse4.TargetControl = dashboard_chart;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.01323F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.9867668F));
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Controls.Add(panel4, 1, 0);
            tableLayoutPanel3.Location = new Point(8, 326);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(747, 227);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboard_chart);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(2, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(496, 223);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(pie_chart);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(502, 2);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 223);
            panel4.TabIndex = 1;
            // 
            // pie_chart
            // 
            chartArea2.AxisX.TitleFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea2.AxisX2.TitleFont = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea2.AxisY.TitleFont = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea2.AxisY2.TitleFont = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea2.Name = "ChartArea1";
            pie_chart.ChartAreas.Add(chartArea2);
            pie_chart.Dock = DockStyle.Fill;
            legend2.BackColor = Color.FromArgb(248, 195, 23);
            legend2.Name = "Legend1";
            pie_chart.Legends.Add(legend2);
            pie_chart.Location = new Point(0, 0);
            pie_chart.Margin = new Padding(2);
            pie_chart.Name = "pie_chart";
            pie_chart.Size = new Size(243, 223);
            pie_chart.TabIndex = 4;
            // 
            // HomeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 560);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "HomeDashboard";
            Text = "HomeDashboard";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            sale_panel.ResumeLayout(false);
            sale_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            profit_panel.ResumeLayout(false);
            profit_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            purchase_panel.ResumeLayout(false);
            purchase_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dashboard_chart).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pie_chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private ComboBox year_cbx;
        private Label label3;
        private Panel panel1;
        private ComboBox sort_cbx;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel sale_panel;
        private Panel profit_panel;
        private Panel purchase_panel;
        private Label purchases_lbl;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart dashboard_chart;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie_chart;
        private ComboBox sort_select_cbx;
        private Label profit_value;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Label sales_lbl;
        private Label label9;
    }
}