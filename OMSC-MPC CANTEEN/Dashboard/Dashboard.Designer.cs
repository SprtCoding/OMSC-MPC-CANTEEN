namespace OMSC_MPC_CANTEEN.Dashboard
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            nav_panel = new Bunifu.Framework.UI.BunifuCards();
            nav_menu_panel = new TableLayoutPanel();
            panel10 = new Panel();
            logout_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            settings_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            panel6 = new Panel();
            purchase_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            panel5 = new Panel();
            stocks_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            panel4 = new Panel();
            monthly_report_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            panel3 = new Panel();
            inventory_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            panel2 = new Panel();
            daily_sales_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            panel1 = new Panel();
            dashboard_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            pictureBox2 = new PictureBox();
            menu_btn = new PictureBox();
            header_panel = new Panel();
            label1 = new Label();
            main_panel = new Panel();
            sidebar_timer = new System.Windows.Forms.Timer(components);
            nav_panel.SuspendLayout();
            nav_menu_panel.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu_btn).BeginInit();
            header_panel.SuspendLayout();
            SuspendLayout();
            // 
            // nav_panel
            // 
            nav_panel.BackColor = Color.FromArgb(248, 195, 23);
            nav_panel.BorderRadius = 0;
            nav_panel.BottomSahddow = true;
            nav_panel.color = Color.FromArgb(248, 195, 23);
            nav_panel.Controls.Add(nav_menu_panel);
            nav_panel.Controls.Add(pictureBox2);
            nav_panel.Controls.Add(menu_btn);
            nav_panel.Dock = DockStyle.Left;
            nav_panel.LeftSahddow = false;
            nav_panel.Location = new Point(0, 0);
            nav_panel.Margin = new Padding(2);
            nav_panel.MaximumSize = new Size(203, 0);
            nav_panel.MinimumSize = new Size(49, 0);
            nav_panel.Name = "nav_panel";
            nav_panel.RightSahddow = true;
            nav_panel.ShadowDepth = 20;
            nav_panel.Size = new Size(203, 604);
            nav_panel.TabIndex = 1;
            // 
            // nav_menu_panel
            // 
            nav_menu_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nav_menu_panel.ColumnCount = 1;
            nav_menu_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            nav_menu_panel.Controls.Add(panel10, 0, 9);
            nav_menu_panel.Controls.Add(panel9, 0, 8);
            nav_menu_panel.Controls.Add(panel8, 0, 7);
            nav_menu_panel.Controls.Add(panel7, 0, 6);
            nav_menu_panel.Controls.Add(panel6, 0, 5);
            nav_menu_panel.Controls.Add(panel5, 0, 4);
            nav_menu_panel.Controls.Add(panel4, 0, 3);
            nav_menu_panel.Controls.Add(panel3, 0, 2);
            nav_menu_panel.Controls.Add(panel2, 0, 1);
            nav_menu_panel.Controls.Add(panel1, 0, 0);
            nav_menu_panel.Location = new Point(2, 214);
            nav_menu_panel.Margin = new Padding(2);
            nav_menu_panel.Name = "nav_menu_panel";
            nav_menu_panel.RowCount = 10;
            nav_menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            nav_menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            nav_menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            nav_menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            nav_menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            nav_menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            nav_menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            nav_menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            nav_menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            nav_menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            nav_menu_panel.Size = new Size(199, 388);
            nav_menu_panel.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(logout_btn);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(2, 354);
            panel10.Margin = new Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new Size(195, 32);
            panel10.TabIndex = 9;
            // 
            // logout_btn
            // 
            logout_btn.Active = false;
            logout_btn.Activecolor = Color.FromArgb(248, 195, 23);
            logout_btn.BackColor = Color.Transparent;
            logout_btn.BackgroundImageLayout = ImageLayout.Stretch;
            logout_btn.BorderRadius = 0;
            logout_btn.ButtonText = "    Logout";
            logout_btn.DisabledColor = Color.Gray;
            logout_btn.Dock = DockStyle.Fill;
            logout_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            logout_btn.ForeColor = Color.WhiteSmoke;
            logout_btn.Iconcolor = Color.Transparent;
            logout_btn.Iconimage = Properties.Resources.sign_out_alt;
            logout_btn.Iconimage_right = null;
            logout_btn.Iconimage_right_Selected = null;
            logout_btn.Iconimage_Selected = null;
            logout_btn.IconMarginLeft = 15;
            logout_btn.IconMarginRight = 0;
            logout_btn.IconRightVisible = true;
            logout_btn.IconRightZoom = 0D;
            logout_btn.IconVisible = true;
            logout_btn.IconZoom = 30D;
            logout_btn.IsTab = false;
            logout_btn.Location = new Point(0, 0);
            logout_btn.Margin = new Padding(4, 3, 4, 3);
            logout_btn.Name = "logout_btn";
            logout_btn.Normalcolor = Color.Transparent;
            logout_btn.OnHovercolor = Color.FromArgb(250, 215, 100);
            logout_btn.OnHoverTextColor = Color.Black;
            logout_btn.Padding = new Padding(7, 6, 7, 6);
            logout_btn.selected = false;
            logout_btn.Size = new Size(195, 32);
            logout_btn.TabIndex = 1;
            logout_btn.Text = "    Logout";
            logout_btn.TextAlign = ContentAlignment.MiddleLeft;
            logout_btn.Textcolor = Color.WhiteSmoke;
            logout_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            logout_btn.Click += logout_btn_Click;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(2, 290);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(195, 60);
            panel9.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(2, 226);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(195, 60);
            panel8.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Controls.Add(settings_btn);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(2, 194);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(195, 28);
            panel7.TabIndex = 6;
            // 
            // settings_btn
            // 
            settings_btn.Active = false;
            settings_btn.Activecolor = Color.FromArgb(248, 195, 23);
            settings_btn.BackColor = Color.Transparent;
            settings_btn.BackgroundImageLayout = ImageLayout.Stretch;
            settings_btn.BorderRadius = 0;
            settings_btn.ButtonText = "    Settings";
            settings_btn.DisabledColor = Color.Gray;
            settings_btn.Dock = DockStyle.Fill;
            settings_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            settings_btn.ForeColor = Color.WhiteSmoke;
            settings_btn.Iconcolor = Color.Transparent;
            settings_btn.Iconimage = Properties.Resources.settings;
            settings_btn.Iconimage_right = null;
            settings_btn.Iconimage_right_Selected = null;
            settings_btn.Iconimage_Selected = null;
            settings_btn.IconMarginLeft = 15;
            settings_btn.IconMarginRight = 0;
            settings_btn.IconRightVisible = true;
            settings_btn.IconRightZoom = 0D;
            settings_btn.IconVisible = true;
            settings_btn.IconZoom = 30D;
            settings_btn.IsTab = false;
            settings_btn.Location = new Point(0, 0);
            settings_btn.Margin = new Padding(4, 3, 4, 3);
            settings_btn.Name = "settings_btn";
            settings_btn.Normalcolor = Color.Transparent;
            settings_btn.OnHovercolor = Color.FromArgb(250, 215, 100);
            settings_btn.OnHoverTextColor = Color.Black;
            settings_btn.Padding = new Padding(7, 6, 7, 6);
            settings_btn.selected = false;
            settings_btn.Size = new Size(195, 28);
            settings_btn.TabIndex = 1;
            settings_btn.Text = "    Settings";
            settings_btn.TextAlign = ContentAlignment.MiddleLeft;
            settings_btn.Textcolor = Color.WhiteSmoke;
            settings_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            settings_btn.Click += settings_btn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(purchase_btn);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(2, 162);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(195, 28);
            panel6.TabIndex = 5;
            // 
            // purchase_btn
            // 
            purchase_btn.Active = false;
            purchase_btn.Activecolor = Color.FromArgb(248, 195, 23);
            purchase_btn.BackColor = Color.Transparent;
            purchase_btn.BackgroundImageLayout = ImageLayout.Stretch;
            purchase_btn.BorderRadius = 0;
            purchase_btn.ButtonText = "    Purchases";
            purchase_btn.DisabledColor = Color.Gray;
            purchase_btn.Dock = DockStyle.Fill;
            purchase_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            purchase_btn.ForeColor = Color.WhiteSmoke;
            purchase_btn.Iconcolor = Color.Transparent;
            purchase_btn.Iconimage = Properties.Resources.shopping_cart_check_24px;
            purchase_btn.Iconimage_right = null;
            purchase_btn.Iconimage_right_Selected = null;
            purchase_btn.Iconimage_Selected = null;
            purchase_btn.IconMarginLeft = 15;
            purchase_btn.IconMarginRight = 0;
            purchase_btn.IconRightVisible = true;
            purchase_btn.IconRightZoom = 0D;
            purchase_btn.IconVisible = true;
            purchase_btn.IconZoom = 30D;
            purchase_btn.IsTab = false;
            purchase_btn.Location = new Point(0, 0);
            purchase_btn.Margin = new Padding(4, 3, 4, 3);
            purchase_btn.Name = "purchase_btn";
            purchase_btn.Normalcolor = Color.Transparent;
            purchase_btn.OnHovercolor = Color.FromArgb(250, 215, 100);
            purchase_btn.OnHoverTextColor = Color.Black;
            purchase_btn.Padding = new Padding(7, 6, 7, 6);
            purchase_btn.selected = false;
            purchase_btn.Size = new Size(195, 28);
            purchase_btn.TabIndex = 1;
            purchase_btn.Text = "    Purchases";
            purchase_btn.TextAlign = ContentAlignment.MiddleLeft;
            purchase_btn.Textcolor = Color.WhiteSmoke;
            purchase_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            purchase_btn.Click += purchase_btn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(stocks_btn);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(2, 130);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(195, 28);
            panel5.TabIndex = 4;
            // 
            // stocks_btn
            // 
            stocks_btn.Active = false;
            stocks_btn.Activecolor = Color.FromArgb(248, 195, 23);
            stocks_btn.BackColor = Color.Transparent;
            stocks_btn.BackgroundImageLayout = ImageLayout.Stretch;
            stocks_btn.BorderRadius = 0;
            stocks_btn.ButtonText = "    Stocks";
            stocks_btn.DisabledColor = Color.Gray;
            stocks_btn.Dock = DockStyle.Fill;
            stocks_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            stocks_btn.ForeColor = Color.WhiteSmoke;
            stocks_btn.Iconcolor = Color.Transparent;
            stocks_btn.Iconimage = Properties.Resources.ready_stock_white;
            stocks_btn.Iconimage_right = null;
            stocks_btn.Iconimage_right_Selected = null;
            stocks_btn.Iconimage_Selected = null;
            stocks_btn.IconMarginLeft = 15;
            stocks_btn.IconMarginRight = 0;
            stocks_btn.IconRightVisible = true;
            stocks_btn.IconRightZoom = 0D;
            stocks_btn.IconVisible = true;
            stocks_btn.IconZoom = 30D;
            stocks_btn.IsTab = false;
            stocks_btn.Location = new Point(0, 0);
            stocks_btn.Margin = new Padding(4, 3, 4, 3);
            stocks_btn.Name = "stocks_btn";
            stocks_btn.Normalcolor = Color.Transparent;
            stocks_btn.OnHovercolor = Color.FromArgb(250, 215, 100);
            stocks_btn.OnHoverTextColor = Color.Black;
            stocks_btn.Padding = new Padding(7, 6, 7, 6);
            stocks_btn.selected = false;
            stocks_btn.Size = new Size(195, 28);
            stocks_btn.TabIndex = 1;
            stocks_btn.Text = "    Stocks";
            stocks_btn.TextAlign = ContentAlignment.MiddleLeft;
            stocks_btn.Textcolor = Color.WhiteSmoke;
            stocks_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            stocks_btn.Click += stocks_btn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(monthly_report_btn);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(2, 98);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(195, 28);
            panel4.TabIndex = 3;
            // 
            // monthly_report_btn
            // 
            monthly_report_btn.Active = false;
            monthly_report_btn.Activecolor = Color.FromArgb(248, 195, 23);
            monthly_report_btn.BackColor = Color.Transparent;
            monthly_report_btn.BackgroundImageLayout = ImageLayout.Stretch;
            monthly_report_btn.BorderRadius = 0;
            monthly_report_btn.ButtonText = "    Monthly Report";
            monthly_report_btn.DisabledColor = Color.Gray;
            monthly_report_btn.Dock = DockStyle.Fill;
            monthly_report_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            monthly_report_btn.ForeColor = Color.WhiteSmoke;
            monthly_report_btn.Iconcolor = Color.Transparent;
            monthly_report_btn.Iconimage = Properties.Resources.profit_white;
            monthly_report_btn.Iconimage_right = null;
            monthly_report_btn.Iconimage_right_Selected = null;
            monthly_report_btn.Iconimage_Selected = null;
            monthly_report_btn.IconMarginLeft = 15;
            monthly_report_btn.IconMarginRight = 0;
            monthly_report_btn.IconRightVisible = true;
            monthly_report_btn.IconRightZoom = 0D;
            monthly_report_btn.IconVisible = true;
            monthly_report_btn.IconZoom = 30D;
            monthly_report_btn.IsTab = false;
            monthly_report_btn.Location = new Point(0, 0);
            monthly_report_btn.Margin = new Padding(4, 3, 4, 3);
            monthly_report_btn.Name = "monthly_report_btn";
            monthly_report_btn.Normalcolor = Color.Transparent;
            monthly_report_btn.OnHovercolor = Color.FromArgb(250, 215, 100);
            monthly_report_btn.OnHoverTextColor = Color.Black;
            monthly_report_btn.Padding = new Padding(7, 6, 7, 6);
            monthly_report_btn.selected = false;
            monthly_report_btn.Size = new Size(195, 28);
            monthly_report_btn.TabIndex = 1;
            monthly_report_btn.Text = "    Monthly Report";
            monthly_report_btn.TextAlign = ContentAlignment.MiddleLeft;
            monthly_report_btn.Textcolor = Color.WhiteSmoke;
            monthly_report_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            monthly_report_btn.Click += monthly_report_btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(inventory_btn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(2, 66);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 28);
            panel3.TabIndex = 2;
            // 
            // inventory_btn
            // 
            inventory_btn.Active = false;
            inventory_btn.Activecolor = Color.FromArgb(248, 195, 23);
            inventory_btn.BackColor = Color.Transparent;
            inventory_btn.BackgroundImageLayout = ImageLayout.Stretch;
            inventory_btn.BorderRadius = 0;
            inventory_btn.ButtonText = "    Inventory";
            inventory_btn.DisabledColor = Color.Gray;
            inventory_btn.Dock = DockStyle.Fill;
            inventory_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            inventory_btn.ForeColor = Color.WhiteSmoke;
            inventory_btn.Iconcolor = Color.Transparent;
            inventory_btn.Iconimage = Properties.Resources.inventory_white;
            inventory_btn.Iconimage_right = null;
            inventory_btn.Iconimage_right_Selected = null;
            inventory_btn.Iconimage_Selected = null;
            inventory_btn.IconMarginLeft = 15;
            inventory_btn.IconMarginRight = 0;
            inventory_btn.IconRightVisible = true;
            inventory_btn.IconRightZoom = 0D;
            inventory_btn.IconVisible = true;
            inventory_btn.IconZoom = 30D;
            inventory_btn.IsTab = false;
            inventory_btn.Location = new Point(0, 0);
            inventory_btn.Margin = new Padding(4, 3, 4, 3);
            inventory_btn.Name = "inventory_btn";
            inventory_btn.Normalcolor = Color.Transparent;
            inventory_btn.OnHovercolor = Color.FromArgb(250, 215, 100);
            inventory_btn.OnHoverTextColor = Color.Black;
            inventory_btn.Padding = new Padding(7, 6, 7, 6);
            inventory_btn.selected = false;
            inventory_btn.Size = new Size(195, 28);
            inventory_btn.TabIndex = 1;
            inventory_btn.Text = "    Inventory";
            inventory_btn.TextAlign = ContentAlignment.MiddleLeft;
            inventory_btn.Textcolor = Color.WhiteSmoke;
            inventory_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inventory_btn.Click += inventory_btn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(daily_sales_btn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 34);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 28);
            panel2.TabIndex = 1;
            // 
            // daily_sales_btn
            // 
            daily_sales_btn.Active = false;
            daily_sales_btn.Activecolor = Color.FromArgb(248, 195, 23);
            daily_sales_btn.BackColor = Color.Transparent;
            daily_sales_btn.BackgroundImageLayout = ImageLayout.Stretch;
            daily_sales_btn.BorderRadius = 0;
            daily_sales_btn.ButtonText = "    Daily Sales";
            daily_sales_btn.DisabledColor = Color.Gray;
            daily_sales_btn.Dock = DockStyle.Fill;
            daily_sales_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            daily_sales_btn.ForeColor = Color.WhiteSmoke;
            daily_sales_btn.Iconcolor = Color.Transparent;
            daily_sales_btn.Iconimage = Properties.Resources.money_graph_with_up_arrow_24px;
            daily_sales_btn.Iconimage_right = null;
            daily_sales_btn.Iconimage_right_Selected = null;
            daily_sales_btn.Iconimage_Selected = null;
            daily_sales_btn.IconMarginLeft = 15;
            daily_sales_btn.IconMarginRight = 0;
            daily_sales_btn.IconRightVisible = true;
            daily_sales_btn.IconRightZoom = 0D;
            daily_sales_btn.IconVisible = true;
            daily_sales_btn.IconZoom = 30D;
            daily_sales_btn.IsTab = false;
            daily_sales_btn.Location = new Point(0, 0);
            daily_sales_btn.Margin = new Padding(4, 3, 4, 3);
            daily_sales_btn.Name = "daily_sales_btn";
            daily_sales_btn.Normalcolor = Color.Transparent;
            daily_sales_btn.OnHovercolor = Color.FromArgb(250, 215, 100);
            daily_sales_btn.OnHoverTextColor = Color.Black;
            daily_sales_btn.Padding = new Padding(7, 6, 7, 6);
            daily_sales_btn.selected = false;
            daily_sales_btn.Size = new Size(195, 28);
            daily_sales_btn.TabIndex = 1;
            daily_sales_btn.Text = "    Daily Sales";
            daily_sales_btn.TextAlign = ContentAlignment.MiddleLeft;
            daily_sales_btn.Textcolor = Color.WhiteSmoke;
            daily_sales_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            daily_sales_btn.Click += daily_sales_btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dashboard_btn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 28);
            panel1.TabIndex = 0;
            // 
            // dashboard_btn
            // 
            dashboard_btn.Active = false;
            dashboard_btn.Activecolor = Color.FromArgb(248, 195, 23);
            dashboard_btn.BackColor = Color.Transparent;
            dashboard_btn.BackgroundImageLayout = ImageLayout.Stretch;
            dashboard_btn.BorderRadius = 0;
            dashboard_btn.ButtonText = "    Dashbooard";
            dashboard_btn.DisabledColor = Color.Gray;
            dashboard_btn.Dock = DockStyle.Fill;
            dashboard_btn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dashboard_btn.ForeColor = Color.WhiteSmoke;
            dashboard_btn.Iconcolor = Color.Transparent;
            dashboard_btn.Iconimage = Properties.Resources.dashboard_white;
            dashboard_btn.Iconimage_right = null;
            dashboard_btn.Iconimage_right_Selected = null;
            dashboard_btn.Iconimage_Selected = null;
            dashboard_btn.IconMarginLeft = 15;
            dashboard_btn.IconMarginRight = 0;
            dashboard_btn.IconRightVisible = true;
            dashboard_btn.IconRightZoom = 0D;
            dashboard_btn.IconVisible = true;
            dashboard_btn.IconZoom = 30D;
            dashboard_btn.IsTab = false;
            dashboard_btn.Location = new Point(0, 0);
            dashboard_btn.Margin = new Padding(4, 3, 4, 3);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Normalcolor = Color.Transparent;
            dashboard_btn.OnHovercolor = Color.FromArgb(250, 215, 100);
            dashboard_btn.OnHoverTextColor = Color.Black;
            dashboard_btn.Padding = new Padding(7, 6, 7, 6);
            dashboard_btn.selected = false;
            dashboard_btn.Size = new Size(195, 28);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.Text = "    Dashbooard";
            dashboard_btn.TextAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Textcolor = Color.WhiteSmoke;
            dashboard_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(49, 48);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // menu_btn
            // 
            menu_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menu_btn.Cursor = Cursors.Hand;
            menu_btn.Image = Properties.Resources.menu_burger_white;
            menu_btn.Location = new Point(170, 14);
            menu_btn.Margin = new Padding(2);
            menu_btn.Name = "menu_btn";
            menu_btn.Size = new Size(17, 14);
            menu_btn.SizeMode = PictureBoxSizeMode.Zoom;
            menu_btn.TabIndex = 1;
            menu_btn.TabStop = false;
            menu_btn.Click += menu_btn_Click;
            // 
            // header_panel
            // 
            header_panel.BackColor = Color.FromArgb(248, 195, 23);
            header_panel.Controls.Add(label1);
            header_panel.Dock = DockStyle.Top;
            header_panel.Location = new Point(203, 0);
            header_panel.Margin = new Padding(2);
            header_panel.Name = "header_panel";
            header_panel.Size = new Size(763, 44);
            header_panel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 0;
            label1.Text = "OMSC-MPC CANTEEN";
            // 
            // main_panel
            // 
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(203, 44);
            main_panel.Margin = new Padding(2);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(763, 560);
            main_panel.TabIndex = 3;
            // 
            // sidebar_timer
            // 
            sidebar_timer.Enabled = true;
            sidebar_timer.Interval = 1;
            sidebar_timer.Tick += sidebar_timer_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 604);
            Controls.Add(main_panel);
            Controls.Add(header_panel);
            Controls.Add(nav_panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OMSC-MPC CANTEEN";
            WindowState = FormWindowState.Maximized;
            FormClosed += Dashboard_FormClosed;
            Load += Dashboard_Load;
            nav_panel.ResumeLayout(false);
            nav_menu_panel.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu_btn).EndInit();
            header_panel.ResumeLayout(false);
            header_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards nav_panel;
        private PictureBox pictureBox2;
        private PictureBox menu_btn;
        private TableLayoutPanel nav_menu_panel;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton logout_btn;
        private Bunifu.Framework.UI.BunifuFlatButton dashboard_btn;
        private Bunifu.Framework.UI.BunifuFlatButton settings_btn;
        private Bunifu.Framework.UI.BunifuFlatButton purchase_btn;
        private Bunifu.Framework.UI.BunifuFlatButton stocks_btn;
        private Bunifu.Framework.UI.BunifuFlatButton monthly_report_btn;
        private Bunifu.Framework.UI.BunifuFlatButton inventory_btn;
        private Bunifu.Framework.UI.BunifuFlatButton daily_sales_btn;
        private Panel header_panel;
        private Label label1;
        private Panel main_panel;
        private System.Windows.Forms.Timer sidebar_timer;
    }
}