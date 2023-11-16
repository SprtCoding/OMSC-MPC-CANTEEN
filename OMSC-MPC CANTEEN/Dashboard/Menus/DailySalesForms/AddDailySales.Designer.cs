namespace OMSC_MPC_CANTEEN.Dashboard.Menus.DailySalesForms
{
    partial class AddDailySales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDailySales));
            label1 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            quantity_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label4 = new Label();
            panel2 = new Panel();
            price_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label3 = new Label();
            panel1 = new Panel();
            item_name_cbx = new ComboBox();
            label2 = new Label();
            save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 34);
            label1.TabIndex = 2;
            label1.Text = "Daily Sales";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(18, 51);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(685, 200);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add new daily sales";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 22);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(681, 176);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(quantity_tb);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(2, 90);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 84);
            panel3.TabIndex = 2;
            // 
            // quantity_tb
            // 
            quantity_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quantity_tb.AutoCompleteMode = AutoCompleteMode.None;
            quantity_tb.AutoCompleteSource = AutoCompleteSource.None;
            quantity_tb.characterCasing = CharacterCasing.Normal;
            quantity_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            quantity_tb.ForeColor = Color.FromArgb(64, 64, 64);
            quantity_tb.HintForeColor = Color.Empty;
            quantity_tb.HintText = "";
            quantity_tb.isPassword = false;
            quantity_tb.LineFocusedColor = Color.FromArgb(250, 215, 100);
            quantity_tb.LineIdleColor = Color.Gray;
            quantity_tb.LineMouseHoverColor = Color.FromArgb(250, 215, 100);
            quantity_tb.LineThickness = 2;
            quantity_tb.Location = new Point(9, 44);
            quantity_tb.Margin = new Padding(4);
            quantity_tb.MaxLength = 32767;
            quantity_tb.Name = "quantity_tb";
            quantity_tb.Size = new Size(318, 31);
            quantity_tb.TabIndex = 4;
            quantity_tb.TextAlign = HorizontalAlignment.Left;
            quantity_tb.KeyDown += quantity_tb_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 12);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // panel2
            // 
            panel2.Controls.Add(price_tb);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(342, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 84);
            panel2.TabIndex = 1;
            // 
            // price_tb
            // 
            price_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            price_tb.AutoCompleteMode = AutoCompleteMode.None;
            price_tb.AutoCompleteSource = AutoCompleteSource.None;
            price_tb.characterCasing = CharacterCasing.Normal;
            price_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            price_tb.ForeColor = Color.FromArgb(64, 64, 64);
            price_tb.HintForeColor = Color.Empty;
            price_tb.HintText = "";
            price_tb.isPassword = false;
            price_tb.LineFocusedColor = Color.FromArgb(250, 215, 100);
            price_tb.LineIdleColor = Color.Gray;
            price_tb.LineMouseHoverColor = Color.FromArgb(250, 215, 100);
            price_tb.LineThickness = 2;
            price_tb.Location = new Point(9, 42);
            price_tb.Margin = new Padding(4);
            price_tb.MaxLength = 32767;
            price_tb.Name = "price_tb";
            price_tb.Size = new Size(318, 31);
            price_tb.TabIndex = 4;
            price_tb.TextAlign = HorizontalAlignment.Left;
            price_tb.Leave += price_tb_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 12);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 3;
            label3.Text = "Selling Price";
            // 
            // panel1
            // 
            panel1.Controls.Add(item_name_cbx);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 84);
            panel1.TabIndex = 0;
            // 
            // item_name_cbx
            // 
            item_name_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            item_name_cbx.FlatStyle = FlatStyle.Flat;
            item_name_cbx.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            item_name_cbx.FormattingEnabled = true;
            item_name_cbx.Location = new Point(9, 42);
            item_name_cbx.Margin = new Padding(2);
            item_name_cbx.Name = "item_name_cbx";
            item_name_cbx.Size = new Size(318, 31);
            item_name_cbx.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 3;
            label2.Text = "Item Name";
            // 
            // save_btn
            // 
            save_btn.Active = false;
            save_btn.Activecolor = Color.FromArgb(46, 139, 87);
            save_btn.BackColor = Color.FromArgb(46, 139, 87);
            save_btn.BackgroundImageLayout = ImageLayout.Stretch;
            save_btn.BorderRadius = 5;
            save_btn.ButtonText = "Save";
            save_btn.DisabledColor = Color.Gray;
            save_btn.Iconcolor = Color.Transparent;
            save_btn.Iconimage = null;
            save_btn.Iconimage_right = null;
            save_btn.Iconimage_right_Selected = null;
            save_btn.Iconimage_Selected = null;
            save_btn.IconMarginLeft = 0;
            save_btn.IconMarginRight = 0;
            save_btn.IconRightVisible = true;
            save_btn.IconRightZoom = 0D;
            save_btn.IconVisible = true;
            save_btn.IconZoom = 90D;
            save_btn.IsTab = false;
            save_btn.Location = new Point(18, 266);
            save_btn.Margin = new Padding(4);
            save_btn.Name = "save_btn";
            save_btn.Normalcolor = Color.FromArgb(46, 139, 87);
            save_btn.OnHovercolor = Color.FromArgb(36, 129, 77);
            save_btn.OnHoverTextColor = Color.White;
            save_btn.selected = false;
            save_btn.Size = new Size(175, 38);
            save_btn.TabIndex = 4;
            save_btn.Text = "Save";
            save_btn.TextAlign = ContentAlignment.MiddleCenter;
            save_btn.Textcolor = Color.White;
            save_btn.TextFont = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            save_btn.Click += save_btn_Click;
            // 
            // AddDailySales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 327);
            Controls.Add(save_btn);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "AddDailySales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Daily Sales";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox quantity_tb;
        private Label label4;
        private Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox price_tb;
        private Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
        private ComboBox item_name_cbx;
    }
}