﻿namespace OMSC_MPC_CANTEEN.Dashboard.Menus.InventoryForms
{
    partial class AddInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInventory));
            label1 = new Label();
            products_gb = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            price_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label7 = new Label();
            panel5 = new Panel();
            unit_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label6 = new Label();
            panel4 = new Panel();
            expiration_dtp = new DateTimePicker();
            label5 = new Label();
            panel1 = new Panel();
            item_name_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label2 = new Label();
            panel2 = new Panel();
            current_stocks_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label3 = new Label();
            panel3 = new Panel();
            category_cbx = new ComboBox();
            label4 = new Label();
            save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            products_gb.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 50);
            label1.TabIndex = 3;
            label1.Text = "Inventory";
            // 
            // products_gb
            // 
            products_gb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            products_gb.Controls.Add(tableLayoutPanel1);
            products_gb.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            products_gb.Location = new Point(34, 72);
            products_gb.Margin = new Padding(4, 3, 4, 3);
            products_gb.Name = "products_gb";
            products_gb.Padding = new Padding(4, 3, 4, 3);
            products_gb.Size = new Size(983, 360);
            products_gb.TabIndex = 4;
            products_gb.TabStop = false;
            products_gb.Text = "Add Product/s";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 2);
            tableLayoutPanel1.Controls.Add(panel5, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 33);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Size = new Size(975, 324);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(price_tb);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(4, 219);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(479, 102);
            panel6.TabIndex = 7;
            // 
            // price_tb
            // 
            price_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            price_tb.AutoCompleteMode = AutoCompleteMode.None;
            price_tb.AutoCompleteSource = AutoCompleteSource.None;
            price_tb.characterCasing = CharacterCasing.Normal;
            price_tb.Enabled = false;
            price_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            price_tb.ForeColor = Color.FromArgb(64, 64, 64);
            price_tb.HintForeColor = Color.Empty;
            price_tb.HintText = "";
            price_tb.isPassword = false;
            price_tb.LineFocusedColor = Color.FromArgb(250, 215, 100);
            price_tb.LineIdleColor = Color.Gray;
            price_tb.LineMouseHoverColor = Color.FromArgb(250, 215, 100);
            price_tb.LineThickness = 3;
            price_tb.Location = new Point(16, 41);
            price_tb.Margin = new Padding(6, 7, 6, 7);
            price_tb.MaxLength = 32767;
            price_tb.Name = "price_tb";
            price_tb.Size = new Size(445, 45);
            price_tb.TabIndex = 4;
            price_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 12);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 36);
            label7.TabIndex = 3;
            label7.Text = "Price";
            // 
            // panel5
            // 
            panel5.Controls.Add(unit_price);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(491, 219);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(479, 102);
            panel5.TabIndex = 6;
            // 
            // unit_price
            // 
            unit_price.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            unit_price.AutoCompleteMode = AutoCompleteMode.None;
            unit_price.AutoCompleteSource = AutoCompleteSource.None;
            unit_price.characterCasing = CharacterCasing.Normal;
            unit_price.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            unit_price.ForeColor = Color.FromArgb(64, 64, 64);
            unit_price.HintForeColor = Color.Empty;
            unit_price.HintText = "";
            unit_price.isPassword = false;
            unit_price.LineFocusedColor = Color.FromArgb(250, 215, 100);
            unit_price.LineIdleColor = Color.Gray;
            unit_price.LineMouseHoverColor = Color.FromArgb(250, 215, 100);
            unit_price.LineThickness = 3;
            unit_price.Location = new Point(16, 41);
            unit_price.Margin = new Padding(6, 7, 6, 7);
            unit_price.MaxLength = 32767;
            unit_price.Name = "unit_price";
            unit_price.Size = new Size(445, 45);
            unit_price.TabIndex = 4;
            unit_price.TextAlign = HorizontalAlignment.Left;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 12);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 36);
            label6.TabIndex = 3;
            label6.Text = "Unit Price";
            // 
            // panel4
            // 
            panel4.Controls.Add(expiration_dtp);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(491, 111);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 102);
            panel4.TabIndex = 5;
            // 
            // expiration_dtp
            // 
            expiration_dtp.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expiration_dtp.Location = new Point(16, 55);
            expiration_dtp.Name = "expiration_dtp";
            expiration_dtp.Size = new Size(445, 37);
            expiration_dtp.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 20);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(174, 36);
            label5.TabIndex = 3;
            label5.Text = "Expiration Date";
            // 
            // panel1
            // 
            panel1.Controls.Add(item_name_tb);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 102);
            panel1.TabIndex = 1;
            // 
            // item_name_tb
            // 
            item_name_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            item_name_tb.AutoCompleteMode = AutoCompleteMode.None;
            item_name_tb.AutoCompleteSource = AutoCompleteSource.None;
            item_name_tb.characterCasing = CharacterCasing.Normal;
            item_name_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            item_name_tb.ForeColor = Color.FromArgb(64, 64, 64);
            item_name_tb.HintForeColor = Color.Empty;
            item_name_tb.HintText = "";
            item_name_tb.isPassword = false;
            item_name_tb.LineFocusedColor = Color.FromArgb(250, 215, 100);
            item_name_tb.LineIdleColor = Color.Gray;
            item_name_tb.LineMouseHoverColor = Color.FromArgb(250, 215, 100);
            item_name_tb.LineThickness = 2;
            item_name_tb.Location = new Point(17, 54);
            item_name_tb.Margin = new Padding(6, 7, 6, 7);
            item_name_tb.MaxLength = 32767;
            item_name_tb.Name = "item_name_tb";
            item_name_tb.Size = new Size(445, 35);
            item_name_tb.TabIndex = 5;
            item_name_tb.TextAlign = HorizontalAlignment.Left;
            item_name_tb.OnValueChanged += item_name_tb_OnValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 36);
            label2.TabIndex = 3;
            label2.Text = "Item";
            // 
            // panel2
            // 
            panel2.Controls.Add(current_stocks_tb);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(491, 3);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 102);
            panel2.TabIndex = 2;
            // 
            // current_stocks_tb
            // 
            current_stocks_tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            current_stocks_tb.AutoCompleteMode = AutoCompleteMode.None;
            current_stocks_tb.AutoCompleteSource = AutoCompleteSource.None;
            current_stocks_tb.characterCasing = CharacterCasing.Normal;
            current_stocks_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            current_stocks_tb.ForeColor = Color.FromArgb(64, 64, 64);
            current_stocks_tb.HintForeColor = Color.Empty;
            current_stocks_tb.HintText = "";
            current_stocks_tb.isPassword = false;
            current_stocks_tb.LineFocusedColor = Color.FromArgb(250, 215, 100);
            current_stocks_tb.LineIdleColor = Color.Gray;
            current_stocks_tb.LineMouseHoverColor = Color.FromArgb(250, 215, 100);
            current_stocks_tb.LineThickness = 2;
            current_stocks_tb.Location = new Point(16, 54);
            current_stocks_tb.Margin = new Padding(6, 7, 6, 7);
            current_stocks_tb.MaxLength = 32767;
            current_stocks_tb.Name = "current_stocks_tb";
            current_stocks_tb.Size = new Size(445, 35);
            current_stocks_tb.TabIndex = 4;
            current_stocks_tb.TextAlign = HorizontalAlignment.Left;
            current_stocks_tb.OnValueChanged += current_stocks_tb_OnValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 36);
            label3.TabIndex = 3;
            label3.Text = "Current Stocks";
            // 
            // panel3
            // 
            panel3.Controls.Add(category_cbx);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(4, 111);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(479, 102);
            panel3.TabIndex = 3;
            // 
            // category_cbx
            // 
            category_cbx.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            category_cbx.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            category_cbx.FormattingEnabled = true;
            category_cbx.Items.AddRange(new object[] { "School Supplies", "Ice Cream", "Drinks", "Groceries" });
            category_cbx.Location = new Point(17, 49);
            category_cbx.Name = "category_cbx";
            category_cbx.Size = new Size(444, 44);
            category_cbx.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 20);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 36);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // save_btn
            // 
            save_btn.Active = false;
            save_btn.Activecolor = Color.FromArgb(46, 139, 87);
            save_btn.BackColor = Color.FromArgb(46, 139, 87);
            save_btn.BackgroundImageLayout = ImageLayout.Stretch;
            save_btn.BorderRadius = 5;
            save_btn.ButtonText = "Save";
            save_btn.Cursor = Cursors.Hand;
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
            save_btn.Location = new Point(34, 477);
            save_btn.Margin = new Padding(5, 7, 5, 7);
            save_btn.Name = "save_btn";
            save_btn.Normalcolor = Color.FromArgb(46, 139, 87);
            save_btn.OnHovercolor = Color.FromArgb(36, 129, 77);
            save_btn.OnHoverTextColor = Color.White;
            save_btn.selected = false;
            save_btn.Size = new Size(223, 41);
            save_btn.TabIndex = 5;
            save_btn.Text = "Save";
            save_btn.TextAlign = ContentAlignment.MiddleCenter;
            save_btn.Textcolor = Color.White;
            save_btn.TextFont = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            save_btn.Click += save_btn_Click;
            // 
            // AddInventory
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 559);
            Controls.Add(save_btn);
            Controls.Add(products_gb);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddInventory";
            Padding = new Padding(4, 22, 4, 3);
            StartPosition = FormStartPosition.CenterScreen;
            products_gb.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox products_gb;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Panel panel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox unit_price;
        private Label label6;
        private Panel panel4;
        private Label label5;
        private Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox current_stocks_tb;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
        private ComboBox category_cbx;
        private DateTimePicker expiration_dtp;
        private Panel panel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox price_tb;
        private Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox item_name_tb;
    }
}