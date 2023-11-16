namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    partial class InventoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            INVENTORY_DTG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            add_new_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            print_btn = new PictureBox();
            print_tooltip = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)INVENTORY_DTG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)print_btn).BeginInit();
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
            tableLayoutPanel1.TabIndex = 3;
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
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            // 
            // INVENTORY_DTG
            // 
            INVENTORY_DTG.AllowUserToAddRows = false;
            INVENTORY_DTG.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            INVENTORY_DTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            INVENTORY_DTG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            INVENTORY_DTG.BackgroundColor = SystemColors.Control;
            INVENTORY_DTG.BorderStyle = BorderStyle.None;
            INVENTORY_DTG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(248, 195, 23);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(250, 215, 100);
            dataGridViewCellStyle8.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            INVENTORY_DTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            INVENTORY_DTG.ColumnHeadersHeight = 45;
            INVENTORY_DTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(250, 215, 100);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            INVENTORY_DTG.DefaultCellStyle = dataGridViewCellStyle9;
            INVENTORY_DTG.DoubleBuffered = true;
            INVENTORY_DTG.EnableHeadersVisualStyles = false;
            INVENTORY_DTG.GridColor = Color.FromArgb(250, 215, 100);
            INVENTORY_DTG.HeaderBgColor = Color.FromArgb(248, 195, 23);
            INVENTORY_DTG.HeaderForeColor = SystemColors.ControlText;
            INVENTORY_DTG.Location = new Point(8, 112);
            INVENTORY_DTG.Margin = new Padding(2);
            INVENTORY_DTG.Name = "INVENTORY_DTG";
            INVENTORY_DTG.ReadOnly = true;
            INVENTORY_DTG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            INVENTORY_DTG.RowHeadersVisible = false;
            INVENTORY_DTG.RowHeadersWidth = 62;
            INVENTORY_DTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            INVENTORY_DTG.RowTemplate.Height = 33;
            INVENTORY_DTG.Size = new Size(747, 441);
            INVENTORY_DTG.TabIndex = 4;
            INVENTORY_DTG.CellContentClick += INVENTORY_DTG_CellContentClick;
            // 
            // add_new_btn
            // 
            add_new_btn.Active = false;
            add_new_btn.Activecolor = Color.FromArgb(46, 139, 87);
            add_new_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add_new_btn.BackColor = Color.FromArgb(46, 139, 87);
            add_new_btn.BackgroundImageLayout = ImageLayout.Stretch;
            add_new_btn.BorderRadius = 5;
            add_new_btn.ButtonText = "Add New";
            add_new_btn.DisabledColor = Color.Gray;
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
            add_new_btn.Location = new Point(658, 78);
            add_new_btn.Margin = new Padding(3, 2, 3, 2);
            add_new_btn.Name = "add_new_btn";
            add_new_btn.Normalcolor = Color.FromArgb(46, 139, 87);
            add_new_btn.OnHovercolor = Color.FromArgb(36, 129, 77);
            add_new_btn.OnHoverTextColor = Color.White;
            add_new_btn.selected = false;
            add_new_btn.Size = new Size(95, 29);
            add_new_btn.TabIndex = 9;
            add_new_btn.Text = "Add New";
            add_new_btn.TextAlign = ContentAlignment.MiddleRight;
            add_new_btn.Textcolor = Color.White;
            add_new_btn.TextFont = new Font("Poppins", 8F, FontStyle.Bold, GraphicsUnit.Point);
            add_new_btn.Click += add_new_btn_Click;
            // 
            // print_btn
            // 
            print_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            print_btn.Image = (Image)resources.GetObject("print_btn.Image");
            print_btn.Location = new Point(628, 82);
            print_btn.Margin = new Padding(2);
            print_btn.Name = "print_btn";
            print_btn.Size = new Size(25, 25);
            print_btn.SizeMode = PictureBoxSizeMode.Zoom;
            print_btn.TabIndex = 10;
            print_btn.TabStop = false;
            print_btn.Click += print_btn_Click;
            print_btn.MouseEnter += print_btn_MouseEnter;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 560);
            Controls.Add(print_btn);
            Controls.Add(add_new_btn);
            Controls.Add(INVENTORY_DTG);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "InventoryForm";
            Text = "/";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)INVENTORY_DTG).EndInit();
            ((System.ComponentModel.ISupportInitialize)print_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid INVENTORY_DTG;
        private Bunifu.Framework.UI.BunifuFlatButton add_new_btn;
        private PictureBox print_btn;
        private ToolTip print_tooltip;
    }
}