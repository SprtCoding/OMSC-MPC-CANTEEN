namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    partial class MonthlyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyReport));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            year_select_cbx = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            dec_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            jan_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            feb_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            mar_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            apr_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            may_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            june_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            july_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            aug_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            sep_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            oct_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            nov_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            panel4 = new Panel();
            print_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            total_sales_lbl = new Label();
            label3 = new Label();
            MONTHLY_REPORT_DTG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            rad = new Bunifu.Framework.UI.BunifuElipse(components);
            print_tooltip = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MONTHLY_REPORT_DTG).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.05658F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9434166F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 7);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(747, 56);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(547, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 52);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 52);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 34);
            label1.TabIndex = 1;
            label1.Text = "Monthly Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 2;
            label2.Text = "Year";
            // 
            // year_select_cbx
            // 
            year_select_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            year_select_cbx.FlatStyle = FlatStyle.Flat;
            year_select_cbx.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            year_select_cbx.FormattingEnabled = true;
            year_select_cbx.IntegralHeight = false;
            year_select_cbx.Items.AddRange(new object[] { "All", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            year_select_cbx.Location = new Point(73, 68);
            year_select_cbx.Margin = new Padding(2);
            year_select_cbx.Name = "year_select_cbx";
            year_select_cbx.Size = new Size(295, 34);
            year_select_cbx.TabIndex = 5;
            year_select_cbx.SelectedIndexChanged += year_select_cbx_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7460346F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.25397F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Location = new Point(8, 110);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(747, 442);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(2, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 438);
            panel3.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dec_btn, 0, 11);
            tableLayoutPanel3.Controls.Add(jan_btn, 0, 0);
            tableLayoutPanel3.Controls.Add(feb_btn, 0, 1);
            tableLayoutPanel3.Controls.Add(mar_btn, 0, 2);
            tableLayoutPanel3.Controls.Add(apr_btn, 0, 3);
            tableLayoutPanel3.Controls.Add(may_btn, 0, 4);
            tableLayoutPanel3.Controls.Add(june_btn, 0, 5);
            tableLayoutPanel3.Controls.Add(july_btn, 0, 6);
            tableLayoutPanel3.Controls.Add(aug_btn, 0, 7);
            tableLayoutPanel3.Controls.Add(sep_btn, 0, 8);
            tableLayoutPanel3.Controls.Add(oct_btn, 0, 9);
            tableLayoutPanel3.Controls.Add(nov_btn, 0, 10);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 12;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tableLayoutPanel3.Size = new Size(150, 438);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // dec_btn
            // 
            dec_btn.Active = false;
            dec_btn.Activecolor = Color.FromArgb(248, 195, 23);
            dec_btn.BackColor = Color.Transparent;
            dec_btn.BackgroundImageLayout = ImageLayout.Stretch;
            dec_btn.BorderRadius = 0;
            dec_btn.ButtonText = "  December";
            dec_btn.DisabledColor = Color.Gray;
            dec_btn.Dock = DockStyle.Fill;
            dec_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dec_btn.ForeColor = Color.DimGray;
            dec_btn.Iconcolor = Color.Transparent;
            dec_btn.Iconimage = (Image)resources.GetObject("dec_btn.Iconimage");
            dec_btn.Iconimage_right = null;
            dec_btn.Iconimage_right_Selected = null;
            dec_btn.Iconimage_Selected = null;
            dec_btn.IconMarginLeft = 15;
            dec_btn.IconMarginRight = 0;
            dec_btn.IconRightVisible = true;
            dec_btn.IconRightZoom = 0D;
            dec_btn.IconVisible = true;
            dec_btn.IconZoom = 25D;
            dec_btn.IsTab = false;
            dec_btn.Location = new Point(4, 399);
            dec_btn.Margin = new Padding(4, 3, 4, 3);
            dec_btn.Name = "dec_btn";
            dec_btn.Normalcolor = Color.Transparent;
            dec_btn.OnHovercolor = Color.DarkGray;
            dec_btn.OnHoverTextColor = Color.Black;
            dec_btn.Padding = new Padding(7, 6, 7, 6);
            dec_btn.selected = false;
            dec_btn.Size = new Size(142, 36);
            dec_btn.TabIndex = 12;
            dec_btn.Text = "  December";
            dec_btn.TextAlign = ContentAlignment.MiddleLeft;
            dec_btn.Textcolor = Color.DimGray;
            dec_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dec_btn.Click += dec_btn_Click;
            // 
            // jan_btn
            // 
            jan_btn.Active = false;
            jan_btn.Activecolor = Color.FromArgb(248, 195, 23);
            jan_btn.BackColor = Color.Transparent;
            jan_btn.BackgroundImageLayout = ImageLayout.Stretch;
            jan_btn.BorderRadius = 0;
            jan_btn.ButtonText = "  January";
            jan_btn.DisabledColor = Color.Gray;
            jan_btn.Dock = DockStyle.Fill;
            jan_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            jan_btn.ForeColor = Color.DimGray;
            jan_btn.Iconcolor = Color.Transparent;
            jan_btn.Iconimage = (Image)resources.GetObject("jan_btn.Iconimage");
            jan_btn.Iconimage_right = null;
            jan_btn.Iconimage_right_Selected = null;
            jan_btn.Iconimage_Selected = null;
            jan_btn.IconMarginLeft = 15;
            jan_btn.IconMarginRight = 0;
            jan_btn.IconRightVisible = true;
            jan_btn.IconRightZoom = 0D;
            jan_btn.IconVisible = true;
            jan_btn.IconZoom = 25D;
            jan_btn.IsTab = false;
            jan_btn.Location = new Point(4, 3);
            jan_btn.Margin = new Padding(4, 3, 4, 3);
            jan_btn.Name = "jan_btn";
            jan_btn.Normalcolor = Color.Transparent;
            jan_btn.OnHovercolor = Color.DarkGray;
            jan_btn.OnHoverTextColor = Color.Black;
            jan_btn.Padding = new Padding(7, 6, 7, 6);
            jan_btn.selected = false;
            jan_btn.Size = new Size(142, 30);
            jan_btn.TabIndex = 1;
            jan_btn.Text = "  January";
            jan_btn.TextAlign = ContentAlignment.MiddleLeft;
            jan_btn.Textcolor = Color.DimGray;
            jan_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            jan_btn.Click += jan_btn_Click;
            // 
            // feb_btn
            // 
            feb_btn.Active = false;
            feb_btn.Activecolor = Color.FromArgb(248, 195, 23);
            feb_btn.BackColor = Color.Transparent;
            feb_btn.BackgroundImageLayout = ImageLayout.Stretch;
            feb_btn.BorderRadius = 0;
            feb_btn.ButtonText = "  February";
            feb_btn.DisabledColor = Color.Gray;
            feb_btn.Dock = DockStyle.Fill;
            feb_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            feb_btn.ForeColor = Color.DimGray;
            feb_btn.Iconcolor = Color.Transparent;
            feb_btn.Iconimage = (Image)resources.GetObject("feb_btn.Iconimage");
            feb_btn.Iconimage_right = null;
            feb_btn.Iconimage_right_Selected = null;
            feb_btn.Iconimage_Selected = null;
            feb_btn.IconMarginLeft = 15;
            feb_btn.IconMarginRight = 0;
            feb_btn.IconRightVisible = true;
            feb_btn.IconRightZoom = 0D;
            feb_btn.IconVisible = true;
            feb_btn.IconZoom = 25D;
            feb_btn.IsTab = false;
            feb_btn.Location = new Point(4, 39);
            feb_btn.Margin = new Padding(4, 3, 4, 3);
            feb_btn.Name = "feb_btn";
            feb_btn.Normalcolor = Color.Transparent;
            feb_btn.OnHovercolor = Color.DarkGray;
            feb_btn.OnHoverTextColor = Color.Black;
            feb_btn.Padding = new Padding(7, 6, 7, 6);
            feb_btn.selected = false;
            feb_btn.Size = new Size(142, 30);
            feb_btn.TabIndex = 2;
            feb_btn.Text = "  February";
            feb_btn.TextAlign = ContentAlignment.MiddleLeft;
            feb_btn.Textcolor = Color.DimGray;
            feb_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            feb_btn.Click += feb_btn_Click;
            // 
            // mar_btn
            // 
            mar_btn.Active = false;
            mar_btn.Activecolor = Color.FromArgb(248, 195, 23);
            mar_btn.BackColor = Color.Transparent;
            mar_btn.BackgroundImageLayout = ImageLayout.Stretch;
            mar_btn.BorderRadius = 0;
            mar_btn.ButtonText = "  March";
            mar_btn.DisabledColor = Color.Gray;
            mar_btn.Dock = DockStyle.Fill;
            mar_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            mar_btn.ForeColor = Color.DimGray;
            mar_btn.Iconcolor = Color.Transparent;
            mar_btn.Iconimage = (Image)resources.GetObject("mar_btn.Iconimage");
            mar_btn.Iconimage_right = null;
            mar_btn.Iconimage_right_Selected = null;
            mar_btn.Iconimage_Selected = null;
            mar_btn.IconMarginLeft = 15;
            mar_btn.IconMarginRight = 0;
            mar_btn.IconRightVisible = true;
            mar_btn.IconRightZoom = 0D;
            mar_btn.IconVisible = true;
            mar_btn.IconZoom = 25D;
            mar_btn.IsTab = false;
            mar_btn.Location = new Point(4, 75);
            mar_btn.Margin = new Padding(4, 3, 4, 3);
            mar_btn.Name = "mar_btn";
            mar_btn.Normalcolor = Color.Transparent;
            mar_btn.OnHovercolor = Color.DarkGray;
            mar_btn.OnHoverTextColor = Color.Black;
            mar_btn.Padding = new Padding(7, 6, 7, 6);
            mar_btn.selected = false;
            mar_btn.Size = new Size(142, 30);
            mar_btn.TabIndex = 3;
            mar_btn.Text = "  March";
            mar_btn.TextAlign = ContentAlignment.MiddleLeft;
            mar_btn.Textcolor = Color.DimGray;
            mar_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mar_btn.Click += mar_btn_Click;
            // 
            // apr_btn
            // 
            apr_btn.Active = false;
            apr_btn.Activecolor = Color.FromArgb(248, 195, 23);
            apr_btn.BackColor = Color.Transparent;
            apr_btn.BackgroundImageLayout = ImageLayout.Stretch;
            apr_btn.BorderRadius = 0;
            apr_btn.ButtonText = "  April";
            apr_btn.DisabledColor = Color.Gray;
            apr_btn.Dock = DockStyle.Fill;
            apr_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            apr_btn.ForeColor = Color.DimGray;
            apr_btn.Iconcolor = Color.Transparent;
            apr_btn.Iconimage = (Image)resources.GetObject("apr_btn.Iconimage");
            apr_btn.Iconimage_right = null;
            apr_btn.Iconimage_right_Selected = null;
            apr_btn.Iconimage_Selected = null;
            apr_btn.IconMarginLeft = 15;
            apr_btn.IconMarginRight = 0;
            apr_btn.IconRightVisible = true;
            apr_btn.IconRightZoom = 0D;
            apr_btn.IconVisible = true;
            apr_btn.IconZoom = 25D;
            apr_btn.IsTab = false;
            apr_btn.Location = new Point(4, 111);
            apr_btn.Margin = new Padding(4, 3, 4, 3);
            apr_btn.Name = "apr_btn";
            apr_btn.Normalcolor = Color.Transparent;
            apr_btn.OnHovercolor = Color.DarkGray;
            apr_btn.OnHoverTextColor = Color.Black;
            apr_btn.Padding = new Padding(7, 6, 7, 6);
            apr_btn.selected = false;
            apr_btn.Size = new Size(142, 30);
            apr_btn.TabIndex = 4;
            apr_btn.Text = "  April";
            apr_btn.TextAlign = ContentAlignment.MiddleLeft;
            apr_btn.Textcolor = Color.DimGray;
            apr_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            apr_btn.Click += apr_btn_Click;
            // 
            // may_btn
            // 
            may_btn.Active = false;
            may_btn.Activecolor = Color.FromArgb(248, 195, 23);
            may_btn.BackColor = Color.Transparent;
            may_btn.BackgroundImageLayout = ImageLayout.Stretch;
            may_btn.BorderRadius = 0;
            may_btn.ButtonText = "  May";
            may_btn.DisabledColor = Color.Gray;
            may_btn.Dock = DockStyle.Fill;
            may_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            may_btn.ForeColor = Color.DimGray;
            may_btn.Iconcolor = Color.Transparent;
            may_btn.Iconimage = (Image)resources.GetObject("may_btn.Iconimage");
            may_btn.Iconimage_right = null;
            may_btn.Iconimage_right_Selected = null;
            may_btn.Iconimage_Selected = null;
            may_btn.IconMarginLeft = 15;
            may_btn.IconMarginRight = 0;
            may_btn.IconRightVisible = true;
            may_btn.IconRightZoom = 0D;
            may_btn.IconVisible = true;
            may_btn.IconZoom = 25D;
            may_btn.IsTab = false;
            may_btn.Location = new Point(4, 147);
            may_btn.Margin = new Padding(4, 3, 4, 3);
            may_btn.Name = "may_btn";
            may_btn.Normalcolor = Color.Transparent;
            may_btn.OnHovercolor = Color.DarkGray;
            may_btn.OnHoverTextColor = Color.Black;
            may_btn.Padding = new Padding(7, 6, 7, 6);
            may_btn.selected = false;
            may_btn.Size = new Size(142, 30);
            may_btn.TabIndex = 5;
            may_btn.Text = "  May";
            may_btn.TextAlign = ContentAlignment.MiddleLeft;
            may_btn.Textcolor = Color.DimGray;
            may_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            may_btn.Click += may_btn_Click;
            // 
            // june_btn
            // 
            june_btn.Active = false;
            june_btn.Activecolor = Color.FromArgb(248, 195, 23);
            june_btn.BackColor = Color.Transparent;
            june_btn.BackgroundImageLayout = ImageLayout.Stretch;
            june_btn.BorderRadius = 0;
            june_btn.ButtonText = "  June";
            june_btn.DisabledColor = Color.Gray;
            june_btn.Dock = DockStyle.Fill;
            june_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            june_btn.ForeColor = Color.DimGray;
            june_btn.Iconcolor = Color.Transparent;
            june_btn.Iconimage = (Image)resources.GetObject("june_btn.Iconimage");
            june_btn.Iconimage_right = null;
            june_btn.Iconimage_right_Selected = null;
            june_btn.Iconimage_Selected = null;
            june_btn.IconMarginLeft = 15;
            june_btn.IconMarginRight = 0;
            june_btn.IconRightVisible = true;
            june_btn.IconRightZoom = 0D;
            june_btn.IconVisible = true;
            june_btn.IconZoom = 25D;
            june_btn.IsTab = false;
            june_btn.Location = new Point(4, 183);
            june_btn.Margin = new Padding(4, 3, 4, 3);
            june_btn.Name = "june_btn";
            june_btn.Normalcolor = Color.Transparent;
            june_btn.OnHovercolor = Color.DarkGray;
            june_btn.OnHoverTextColor = Color.Black;
            june_btn.Padding = new Padding(7, 6, 7, 6);
            june_btn.selected = false;
            june_btn.Size = new Size(142, 30);
            june_btn.TabIndex = 6;
            june_btn.Text = "  June";
            june_btn.TextAlign = ContentAlignment.MiddleLeft;
            june_btn.Textcolor = Color.DimGray;
            june_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            june_btn.Click += june_btn_Click;
            // 
            // july_btn
            // 
            july_btn.Active = false;
            july_btn.Activecolor = Color.FromArgb(248, 195, 23);
            july_btn.BackColor = Color.Transparent;
            july_btn.BackgroundImageLayout = ImageLayout.Stretch;
            july_btn.BorderRadius = 0;
            july_btn.ButtonText = "  July";
            july_btn.DisabledColor = Color.Gray;
            july_btn.Dock = DockStyle.Fill;
            july_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            july_btn.ForeColor = Color.DimGray;
            july_btn.Iconcolor = Color.Transparent;
            july_btn.Iconimage = (Image)resources.GetObject("july_btn.Iconimage");
            july_btn.Iconimage_right = null;
            july_btn.Iconimage_right_Selected = null;
            july_btn.Iconimage_Selected = null;
            july_btn.IconMarginLeft = 15;
            july_btn.IconMarginRight = 0;
            july_btn.IconRightVisible = true;
            july_btn.IconRightZoom = 0D;
            july_btn.IconVisible = true;
            july_btn.IconZoom = 25D;
            july_btn.IsTab = false;
            july_btn.Location = new Point(4, 219);
            july_btn.Margin = new Padding(4, 3, 4, 3);
            july_btn.Name = "july_btn";
            july_btn.Normalcolor = Color.Transparent;
            july_btn.OnHovercolor = Color.DarkGray;
            july_btn.OnHoverTextColor = Color.Black;
            july_btn.Padding = new Padding(7, 6, 7, 6);
            july_btn.selected = false;
            july_btn.Size = new Size(142, 30);
            july_btn.TabIndex = 7;
            july_btn.Text = "  July";
            july_btn.TextAlign = ContentAlignment.MiddleLeft;
            july_btn.Textcolor = Color.DimGray;
            july_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            july_btn.Click += july_btn_Click;
            // 
            // aug_btn
            // 
            aug_btn.Active = false;
            aug_btn.Activecolor = Color.FromArgb(248, 195, 23);
            aug_btn.BackColor = Color.Transparent;
            aug_btn.BackgroundImageLayout = ImageLayout.Stretch;
            aug_btn.BorderRadius = 0;
            aug_btn.ButtonText = "  August";
            aug_btn.DisabledColor = Color.Gray;
            aug_btn.Dock = DockStyle.Fill;
            aug_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            aug_btn.ForeColor = Color.DimGray;
            aug_btn.Iconcolor = Color.Transparent;
            aug_btn.Iconimage = (Image)resources.GetObject("aug_btn.Iconimage");
            aug_btn.Iconimage_right = null;
            aug_btn.Iconimage_right_Selected = null;
            aug_btn.Iconimage_Selected = null;
            aug_btn.IconMarginLeft = 15;
            aug_btn.IconMarginRight = 0;
            aug_btn.IconRightVisible = true;
            aug_btn.IconRightZoom = 0D;
            aug_btn.IconVisible = true;
            aug_btn.IconZoom = 25D;
            aug_btn.IsTab = false;
            aug_btn.Location = new Point(4, 255);
            aug_btn.Margin = new Padding(4, 3, 4, 3);
            aug_btn.Name = "aug_btn";
            aug_btn.Normalcolor = Color.Transparent;
            aug_btn.OnHovercolor = Color.DarkGray;
            aug_btn.OnHoverTextColor = Color.Black;
            aug_btn.Padding = new Padding(7, 6, 7, 6);
            aug_btn.selected = false;
            aug_btn.Size = new Size(142, 30);
            aug_btn.TabIndex = 8;
            aug_btn.Text = "  August";
            aug_btn.TextAlign = ContentAlignment.MiddleLeft;
            aug_btn.Textcolor = Color.DimGray;
            aug_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            aug_btn.Click += aug_btn_Click;
            // 
            // sep_btn
            // 
            sep_btn.Active = false;
            sep_btn.Activecolor = Color.FromArgb(248, 195, 23);
            sep_btn.BackColor = Color.Transparent;
            sep_btn.BackgroundImageLayout = ImageLayout.Stretch;
            sep_btn.BorderRadius = 0;
            sep_btn.ButtonText = "  September";
            sep_btn.DisabledColor = Color.Gray;
            sep_btn.Dock = DockStyle.Fill;
            sep_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            sep_btn.ForeColor = Color.DimGray;
            sep_btn.Iconcolor = Color.Transparent;
            sep_btn.Iconimage = (Image)resources.GetObject("sep_btn.Iconimage");
            sep_btn.Iconimage_right = null;
            sep_btn.Iconimage_right_Selected = null;
            sep_btn.Iconimage_Selected = null;
            sep_btn.IconMarginLeft = 15;
            sep_btn.IconMarginRight = 0;
            sep_btn.IconRightVisible = true;
            sep_btn.IconRightZoom = 0D;
            sep_btn.IconVisible = true;
            sep_btn.IconZoom = 25D;
            sep_btn.IsTab = false;
            sep_btn.Location = new Point(4, 291);
            sep_btn.Margin = new Padding(4, 3, 4, 3);
            sep_btn.Name = "sep_btn";
            sep_btn.Normalcolor = Color.Transparent;
            sep_btn.OnHovercolor = Color.DarkGray;
            sep_btn.OnHoverTextColor = Color.Black;
            sep_btn.Padding = new Padding(7, 6, 7, 6);
            sep_btn.selected = false;
            sep_btn.Size = new Size(142, 30);
            sep_btn.TabIndex = 9;
            sep_btn.Text = "  September";
            sep_btn.TextAlign = ContentAlignment.MiddleLeft;
            sep_btn.Textcolor = Color.DimGray;
            sep_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sep_btn.Click += sep_btn_Click;
            // 
            // oct_btn
            // 
            oct_btn.Active = false;
            oct_btn.Activecolor = Color.FromArgb(248, 195, 23);
            oct_btn.BackColor = Color.Transparent;
            oct_btn.BackgroundImageLayout = ImageLayout.Stretch;
            oct_btn.BorderRadius = 0;
            oct_btn.ButtonText = "  October";
            oct_btn.DisabledColor = Color.Gray;
            oct_btn.Dock = DockStyle.Fill;
            oct_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            oct_btn.ForeColor = Color.DimGray;
            oct_btn.Iconcolor = Color.Transparent;
            oct_btn.Iconimage = (Image)resources.GetObject("oct_btn.Iconimage");
            oct_btn.Iconimage_right = null;
            oct_btn.Iconimage_right_Selected = null;
            oct_btn.Iconimage_Selected = null;
            oct_btn.IconMarginLeft = 15;
            oct_btn.IconMarginRight = 0;
            oct_btn.IconRightVisible = true;
            oct_btn.IconRightZoom = 0D;
            oct_btn.IconVisible = true;
            oct_btn.IconZoom = 25D;
            oct_btn.IsTab = false;
            oct_btn.Location = new Point(4, 327);
            oct_btn.Margin = new Padding(4, 3, 4, 3);
            oct_btn.Name = "oct_btn";
            oct_btn.Normalcolor = Color.Transparent;
            oct_btn.OnHovercolor = Color.DarkGray;
            oct_btn.OnHoverTextColor = Color.Black;
            oct_btn.Padding = new Padding(7, 6, 7, 6);
            oct_btn.selected = false;
            oct_btn.Size = new Size(142, 30);
            oct_btn.TabIndex = 10;
            oct_btn.Text = "  October";
            oct_btn.TextAlign = ContentAlignment.MiddleLeft;
            oct_btn.Textcolor = Color.DimGray;
            oct_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            oct_btn.Click += oct_btn_Click;
            // 
            // nov_btn
            // 
            nov_btn.Active = false;
            nov_btn.Activecolor = Color.FromArgb(248, 195, 23);
            nov_btn.BackColor = Color.Transparent;
            nov_btn.BackgroundImageLayout = ImageLayout.Stretch;
            nov_btn.BorderRadius = 0;
            nov_btn.ButtonText = "  November";
            nov_btn.DisabledColor = Color.Gray;
            nov_btn.Dock = DockStyle.Fill;
            nov_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            nov_btn.ForeColor = Color.DimGray;
            nov_btn.Iconcolor = Color.Transparent;
            nov_btn.Iconimage = (Image)resources.GetObject("nov_btn.Iconimage");
            nov_btn.Iconimage_right = null;
            nov_btn.Iconimage_right_Selected = null;
            nov_btn.Iconimage_Selected = null;
            nov_btn.IconMarginLeft = 15;
            nov_btn.IconMarginRight = 0;
            nov_btn.IconRightVisible = true;
            nov_btn.IconRightZoom = 0D;
            nov_btn.IconVisible = true;
            nov_btn.IconZoom = 25D;
            nov_btn.IsTab = false;
            nov_btn.Location = new Point(4, 363);
            nov_btn.Margin = new Padding(4, 3, 4, 3);
            nov_btn.Name = "nov_btn";
            nov_btn.Normalcolor = Color.Transparent;
            nov_btn.OnHovercolor = Color.DarkGray;
            nov_btn.OnHoverTextColor = Color.Black;
            nov_btn.Padding = new Padding(7, 6, 7, 6);
            nov_btn.selected = false;
            nov_btn.Size = new Size(142, 30);
            nov_btn.TabIndex = 11;
            nov_btn.Text = "  November";
            nov_btn.TextAlign = ContentAlignment.MiddleLeft;
            nov_btn.Textcolor = Color.DimGray;
            nov_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nov_btn.Click += nov_btn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(print_btn);
            panel4.Controls.Add(total_sales_lbl);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(MONTHLY_REPORT_DTG);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(156, 2);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(589, 438);
            panel4.TabIndex = 1;
            // 
            // print_btn
            // 
            print_btn.Active = false;
            print_btn.Activecolor = Color.FromArgb(46, 139, 87);
            print_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            print_btn.BackColor = Color.FromArgb(46, 139, 87);
            print_btn.BackgroundImageLayout = ImageLayout.Stretch;
            print_btn.BorderRadius = 5;
            print_btn.ButtonText = "  Print";
            print_btn.DisabledColor = Color.Gray;
            print_btn.Iconcolor = Color.Transparent;
            print_btn.Iconimage = (Image)resources.GetObject("print_btn.Iconimage");
            print_btn.Iconimage_right = null;
            print_btn.Iconimage_right_Selected = null;
            print_btn.Iconimage_Selected = null;
            print_btn.IconMarginLeft = 0;
            print_btn.IconMarginRight = 0;
            print_btn.IconRightVisible = true;
            print_btn.IconRightZoom = 0D;
            print_btn.IconVisible = true;
            print_btn.IconZoom = 25D;
            print_btn.IsTab = false;
            print_btn.Location = new Point(502, 4);
            print_btn.Margin = new Padding(4);
            print_btn.Name = "print_btn";
            print_btn.Normalcolor = Color.FromArgb(46, 139, 87);
            print_btn.OnHovercolor = Color.FromArgb(36, 129, 77);
            print_btn.OnHoverTextColor = Color.White;
            print_btn.selected = false;
            print_btn.Size = new Size(78, 29);
            print_btn.TabIndex = 9;
            print_btn.Text = "  Print";
            print_btn.TextAlign = ContentAlignment.MiddleLeft;
            print_btn.Textcolor = Color.White;
            print_btn.TextFont = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            print_btn.Click += print_btn_Click;
            print_btn.MouseHover += print_btn_MouseHover;
            // 
            // total_sales_lbl
            // 
            total_sales_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            total_sales_lbl.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            total_sales_lbl.Location = new Point(111, 411);
            total_sales_lbl.Margin = new Padding(2, 0, 2, 0);
            total_sales_lbl.Name = "total_sales_lbl";
            total_sales_lbl.Size = new Size(469, 18);
            total_sales_lbl.TabIndex = 7;
            total_sales_lbl.Text = "0";
            total_sales_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 411);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 6;
            label3.Text = "Total Sales:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MONTHLY_REPORT_DTG
            // 
            MONTHLY_REPORT_DTG.AllowUserToAddRows = false;
            MONTHLY_REPORT_DTG.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            MONTHLY_REPORT_DTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            MONTHLY_REPORT_DTG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MONTHLY_REPORT_DTG.BackgroundColor = SystemColors.Control;
            MONTHLY_REPORT_DTG.BorderStyle = BorderStyle.None;
            MONTHLY_REPORT_DTG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 195, 23);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 215, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MONTHLY_REPORT_DTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MONTHLY_REPORT_DTG.ColumnHeadersHeight = 45;
            MONTHLY_REPORT_DTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(250, 215, 100);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            MONTHLY_REPORT_DTG.DefaultCellStyle = dataGridViewCellStyle3;
            MONTHLY_REPORT_DTG.DoubleBuffered = true;
            MONTHLY_REPORT_DTG.EnableHeadersVisualStyles = false;
            MONTHLY_REPORT_DTG.GridColor = Color.FromArgb(250, 215, 100);
            MONTHLY_REPORT_DTG.HeaderBgColor = Color.FromArgb(248, 195, 23);
            MONTHLY_REPORT_DTG.HeaderForeColor = SystemColors.ControlText;
            MONTHLY_REPORT_DTG.Location = new Point(13, 39);
            MONTHLY_REPORT_DTG.Margin = new Padding(2);
            MONTHLY_REPORT_DTG.Name = "MONTHLY_REPORT_DTG";
            MONTHLY_REPORT_DTG.ReadOnly = true;
            MONTHLY_REPORT_DTG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MONTHLY_REPORT_DTG.RowHeadersVisible = false;
            MONTHLY_REPORT_DTG.RowHeadersWidth = 62;
            MONTHLY_REPORT_DTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            MONTHLY_REPORT_DTG.RowTemplate.Height = 33;
            MONTHLY_REPORT_DTG.Size = new Size(567, 370);
            MONTHLY_REPORT_DTG.TabIndex = 5;
            // 
            // rad
            // 
            rad.ElipseRadius = 10;
            rad.TargetControl = MONTHLY_REPORT_DTG;
            // 
            // MonthlyReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 560);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(year_select_cbx);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MonthlyReport";
            Text = "MonthlyReport";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MONTHLY_REPORT_DTG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox year_select_cbx;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Bunifu.Framework.UI.BunifuFlatButton jan_btn;
        private Bunifu.Framework.UI.BunifuFlatButton dec_btn;
        private Bunifu.Framework.UI.BunifuFlatButton feb_btn;
        private Bunifu.Framework.UI.BunifuFlatButton mar_btn;
        private Bunifu.Framework.UI.BunifuFlatButton apr_btn;
        private Bunifu.Framework.UI.BunifuFlatButton may_btn;
        private Bunifu.Framework.UI.BunifuFlatButton june_btn;
        private Bunifu.Framework.UI.BunifuFlatButton july_btn;
        private Bunifu.Framework.UI.BunifuFlatButton aug_btn;
        private Bunifu.Framework.UI.BunifuFlatButton sep_btn;
        private Bunifu.Framework.UI.BunifuFlatButton oct_btn;
        private Bunifu.Framework.UI.BunifuFlatButton nov_btn;
        private Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid MONTHLY_REPORT_DTG;
        private Label total_sales_lbl;
        private Label label3;
        private Bunifu.Framework.UI.BunifuElipse rad;
        private Bunifu.Framework.UI.BunifuFlatButton print_btn;
        private ToolTip print_tooltip;
    }
}