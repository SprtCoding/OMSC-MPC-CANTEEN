namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    partial class DailySales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySales));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label3 = new Label();
            time_now = new Label();
            date_now = new Label();
            panel1 = new Panel();
            print_btn = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            add_panel = new Panel();
            add_new_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            total_sales_lbl = new Label();
            DAILY_SALES_DTG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            date_time_timer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            print_tooltip = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)print_btn).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            add_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DAILY_SALES_DTG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.IBeam;
            label1.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 34);
            label1.TabIndex = 1;
            label1.Text = "Daily Sales and Inventory";
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
            tableLayoutPanel1.Size = new Size(747, 114);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(time_now);
            panel2.Controls.Add(date_now);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(547, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 110);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Image = Properties.Resources.time_tick;
            label3.Location = new Point(92, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 96);
            label3.TabIndex = 4;
            // 
            // time_now
            // 
            time_now.AutoSize = true;
            time_now.Cursor = Cursors.IBeam;
            time_now.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            time_now.Location = new Point(9, 39);
            time_now.Margin = new Padding(2, 0, 2, 0);
            time_now.Name = "time_now";
            time_now.Size = new Size(41, 22);
            time_now.TabIndex = 3;
            time_now.Text = "Time";
            // 
            // date_now
            // 
            date_now.AutoSize = true;
            date_now.Cursor = Cursors.IBeam;
            date_now.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            date_now.Location = new Point(9, 8);
            date_now.Margin = new Padding(2, 0, 2, 0);
            date_now.Name = "date_now";
            date_now.Size = new Size(39, 22);
            date_now.TabIndex = 2;
            date_now.Text = "Date";
            // 
            // panel1
            // 
            panel1.Controls.Add(print_btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 110);
            panel1.TabIndex = 0;
            // 
            // print_btn
            // 
            print_btn.Image = (Image)resources.GetObject("print_btn.Image");
            print_btn.Location = new Point(16, 65);
            print_btn.Margin = new Padding(2);
            print_btn.Name = "print_btn";
            print_btn.Size = new Size(25, 25);
            print_btn.SizeMode = PictureBoxSizeMode.Zoom;
            print_btn.TabIndex = 8;
            print_btn.TabStop = false;
            print_btn.Click += print_btn_Click;
            print_btn.MouseEnter += print_btn_MouseEnter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(add_panel, 0, 0);
            tableLayoutPanel2.Location = new Point(45, 58);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(108, 35);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // add_panel
            // 
            add_panel.Controls.Add(add_new_btn);
            add_panel.Dock = DockStyle.Fill;
            add_panel.Location = new Point(4, 3);
            add_panel.Margin = new Padding(4, 3, 4, 3);
            add_panel.Name = "add_panel";
            add_panel.Size = new Size(100, 29);
            add_panel.TabIndex = 0;
            // 
            // add_new_btn
            // 
            add_new_btn.Active = false;
            add_new_btn.Activecolor = Color.FromArgb(46, 139, 87);
            add_new_btn.BackColor = Color.FromArgb(46, 139, 87);
            add_new_btn.BackgroundImageLayout = ImageLayout.Stretch;
            add_new_btn.BorderRadius = 5;
            add_new_btn.ButtonText = "Add New";
            add_new_btn.DisabledColor = Color.Gray;
            add_new_btn.Dock = DockStyle.Fill;
            add_new_btn.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            add_new_btn.Iconcolor = Color.Transparent;
            add_new_btn.Iconimage = null;
            add_new_btn.Iconimage_right = Properties.Resources.plus_small;
            add_new_btn.Iconimage_right_Selected = null;
            add_new_btn.Iconimage_Selected = null;
            add_new_btn.IconMarginLeft = 0;
            add_new_btn.IconMarginRight = 0;
            add_new_btn.IconRightVisible = true;
            add_new_btn.IconRightZoom = 0D;
            add_new_btn.IconVisible = true;
            add_new_btn.IconZoom = 35D;
            add_new_btn.IsTab = false;
            add_new_btn.Location = new Point(0, 0);
            add_new_btn.Margin = new Padding(3, 2, 3, 2);
            add_new_btn.Name = "add_new_btn";
            add_new_btn.Normalcolor = Color.FromArgb(46, 139, 87);
            add_new_btn.OnHovercolor = Color.FromArgb(36, 129, 77);
            add_new_btn.OnHoverTextColor = Color.White;
            add_new_btn.selected = false;
            add_new_btn.Size = new Size(100, 29);
            add_new_btn.TabIndex = 6;
            add_new_btn.Text = "Add New";
            add_new_btn.TextAlign = ContentAlignment.MiddleRight;
            add_new_btn.Textcolor = Color.White;
            add_new_btn.TextFont = new Font("Poppins", 8F, FontStyle.Bold, GraphicsUnit.Point);
            add_new_btn.Click += add_new_btn_Click;
            // 
            // total_sales_lbl
            // 
            total_sales_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            total_sales_lbl.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            total_sales_lbl.Location = new Point(598, 528);
            total_sales_lbl.Margin = new Padding(2, 0, 2, 0);
            total_sales_lbl.Name = "total_sales_lbl";
            total_sales_lbl.Size = new Size(151, 25);
            total_sales_lbl.TabIndex = 4;
            total_sales_lbl.Text = "0";
            total_sales_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DAILY_SALES_DTG
            // 
            DAILY_SALES_DTG.AllowUserToAddRows = false;
            DAILY_SALES_DTG.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            DAILY_SALES_DTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DAILY_SALES_DTG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DAILY_SALES_DTG.BackgroundColor = SystemColors.Control;
            DAILY_SALES_DTG.BorderStyle = BorderStyle.None;
            DAILY_SALES_DTG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 195, 23);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 215, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DAILY_SALES_DTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DAILY_SALES_DTG.ColumnHeadersHeight = 45;
            DAILY_SALES_DTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(250, 215, 100);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DAILY_SALES_DTG.DefaultCellStyle = dataGridViewCellStyle3;
            DAILY_SALES_DTG.DoubleBuffered = true;
            DAILY_SALES_DTG.EnableHeadersVisualStyles = false;
            DAILY_SALES_DTG.GridColor = Color.FromArgb(250, 215, 100);
            DAILY_SALES_DTG.HeaderBgColor = Color.FromArgb(248, 195, 23);
            DAILY_SALES_DTG.HeaderForeColor = SystemColors.ControlText;
            DAILY_SALES_DTG.Location = new Point(8, 125);
            DAILY_SALES_DTG.Margin = new Padding(2);
            DAILY_SALES_DTG.Name = "DAILY_SALES_DTG";
            DAILY_SALES_DTG.ReadOnly = true;
            DAILY_SALES_DTG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DAILY_SALES_DTG.RowHeadersVisible = false;
            DAILY_SALES_DTG.RowHeadersWidth = 62;
            DAILY_SALES_DTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DAILY_SALES_DTG.RowTemplate.Height = 33;
            DAILY_SALES_DTG.Size = new Size(747, 402);
            DAILY_SALES_DTG.TabIndex = 5;
            DAILY_SALES_DTG.CellContentClick += DAILY_SALES_DTG_CellContentClick;
            // 
            // date_time_timer
            // 
            date_time_timer.Tick += date_time_timer_Tick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(497, 529);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 7;
            label2.Text = "Total Sales:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DailySales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 560);
            Controls.Add(label2);
            Controls.Add(DAILY_SALES_DTG);
            Controls.Add(total_sales_lbl);
            Controls.Add(tableLayoutPanel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "DailySales";
            Text = "DailySales";
            Load += DailySales_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)print_btn).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            add_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DAILY_SALES_DTG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label date_now;
        private Bunifu.Framework.UI.BunifuCustomDataGrid INVENTORY_DTG;
        private Label total_sales_lbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DAILY_SALES_DTG;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel add_panel;
        private Label time_now;
        private System.Windows.Forms.Timer date_time_timer;
        private Bunifu.Framework.UI.BunifuFlatButton add_new_btn;
        private Label label2;
        private PictureBox print_btn;
        private ToolTip print_tooltip;
        private Label label3;
    }
}