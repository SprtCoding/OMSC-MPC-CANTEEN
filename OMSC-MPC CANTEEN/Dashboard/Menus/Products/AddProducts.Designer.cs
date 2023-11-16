namespace OMSC_MPC_CANTEEN.Dashboard.Menus.Products
{
    partial class AddProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts));
            rad = new Bunifu.Framework.UI.BunifuElipse(components);
            close_btn = new PictureBox();
            titleLbl = new Label();
            label2 = new Label();
            panel1 = new Panel();
            save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            price_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label9 = new Label();
            total_amount_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label8 = new Label();
            q_level_cbx = new ComboBox();
            quantity_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label7 = new Label();
            category_cbx = new ComboBox();
            label6 = new Label();
            product_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label5 = new Label();
            expiration_date_dtp = new DateTimePicker();
            label4 = new Label();
            suplier_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label3 = new Label();
            date_dtp = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rad
            // 
            rad.ElipseRadius = 15;
            rad.TargetControl = this;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = (Image)resources.GetObject("close_btn.Image");
            close_btn.Location = new Point(525, 7);
            close_btn.Margin = new Padding(2);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(17, 14);
            close_btn.SizeMode = PictureBoxSizeMode.Zoom;
            close_btn.TabIndex = 0;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.Location = new Point(8, 7);
            titleLbl.Margin = new Padding(2, 0, 2, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(147, 34);
            titleLbl.TabIndex = 2;
            titleLbl.Text = "Add Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(save_btn);
            panel1.Controls.Add(price_tb);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(total_amount_tb);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(q_level_cbx);
            panel1.Controls.Add(quantity_tb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(category_cbx);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(product_tb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(expiration_date_dtp);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(suplier_tb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(date_dtp);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(8, 38);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 399);
            panel1.TabIndex = 4;
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
            save_btn.Location = new Point(353, 329);
            save_btn.Margin = new Padding(4);
            save_btn.Name = "save_btn";
            save_btn.Normalcolor = Color.FromArgb(46, 139, 87);
            save_btn.OnHovercolor = Color.FromArgb(36, 129, 77);
            save_btn.OnHoverTextColor = Color.White;
            save_btn.selected = false;
            save_btn.Size = new Size(156, 38);
            save_btn.TabIndex = 21;
            save_btn.Text = "Save";
            save_btn.TextAlign = ContentAlignment.MiddleCenter;
            save_btn.Textcolor = Color.White;
            save_btn.TextFont = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            save_btn.Click += save_btn_Click;
            // 
            // price_tb
            // 
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
            price_tb.Location = new Point(9, 180);
            price_tb.Margin = new Padding(4);
            price_tb.MaxLength = 32767;
            price_tb.Name = "price_tb";
            price_tb.Size = new Size(224, 35);
            price_tb.TabIndex = 20;
            price_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(285, 154);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(97, 17);
            label9.TabIndex = 19;
            label9.Text = "Total Amount";
            // 
            // total_amount_tb
            // 
            total_amount_tb.AutoCompleteMode = AutoCompleteMode.None;
            total_amount_tb.AutoCompleteSource = AutoCompleteSource.None;
            total_amount_tb.characterCasing = CharacterCasing.Normal;
            total_amount_tb.Enabled = false;
            total_amount_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            total_amount_tb.ForeColor = Color.FromArgb(64, 64, 64);
            total_amount_tb.HintForeColor = Color.Empty;
            total_amount_tb.HintText = "";
            total_amount_tb.isPassword = false;
            total_amount_tb.LineFocusedColor = Color.FromArgb(250, 215, 100);
            total_amount_tb.LineIdleColor = Color.Gray;
            total_amount_tb.LineMouseHoverColor = Color.FromArgb(250, 215, 100);
            total_amount_tb.LineThickness = 2;
            total_amount_tb.Location = new Point(285, 184);
            total_amount_tb.Margin = new Padding(4);
            total_amount_tb.MaxLength = 32767;
            total_amount_tb.Name = "total_amount_tb";
            total_amount_tb.Size = new Size(223, 31);
            total_amount_tb.TabIndex = 18;
            total_amount_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(9, 154);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 17);
            label8.TabIndex = 17;
            label8.Text = "Cost Price";
            // 
            // q_level_cbx
            // 
            q_level_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            q_level_cbx.FlatStyle = FlatStyle.Flat;
            q_level_cbx.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            q_level_cbx.FormattingEnabled = true;
            q_level_cbx.Items.AddRange(new object[] { "pcs", "pack" });
            q_level_cbx.Location = new Point(443, 256);
            q_level_cbx.Margin = new Padding(2);
            q_level_cbx.Name = "q_level_cbx";
            q_level_cbx.Size = new Size(66, 30);
            q_level_cbx.TabIndex = 16;
            // 
            // quantity_tb
            // 
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
            quantity_tb.Location = new Point(285, 256);
            quantity_tb.Margin = new Padding(4);
            quantity_tb.MaxLength = 32767;
            quantity_tb.Name = "quantity_tb";
            quantity_tb.Size = new Size(152, 30);
            quantity_tb.TabIndex = 15;
            quantity_tb.TextAlign = HorizontalAlignment.Left;
            quantity_tb.OnValueChanged += quantity_tb_OnValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(285, 227);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 14;
            label7.Text = "Quantity";
            // 
            // category_cbx
            // 
            category_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            category_cbx.FlatStyle = FlatStyle.Flat;
            category_cbx.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            category_cbx.FormattingEnabled = true;
            category_cbx.Items.AddRange(new object[] { "School Supplies", "Ice Cream", "Drinks", "Groceries" });
            category_cbx.Location = new Point(10, 256);
            category_cbx.Margin = new Padding(2);
            category_cbx.Name = "category_cbx";
            category_cbx.Size = new Size(224, 30);
            category_cbx.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(9, 227);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 12;
            label6.Text = "Category";
            // 
            // product_tb
            // 
            product_tb.AutoCompleteMode = AutoCompleteMode.None;
            product_tb.AutoCompleteSource = AutoCompleteSource.None;
            product_tb.characterCasing = CharacterCasing.Normal;
            product_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            product_tb.ForeColor = Color.FromArgb(64, 64, 64);
            product_tb.HintForeColor = Color.Empty;
            product_tb.HintText = "";
            product_tb.isPassword = false;
            product_tb.LineFocusedColor = Color.FromArgb(250, 215, 100);
            product_tb.LineIdleColor = Color.Gray;
            product_tb.LineMouseHoverColor = Color.FromArgb(250, 215, 100);
            product_tb.LineThickness = 2;
            product_tb.Location = new Point(9, 104);
            product_tb.Margin = new Padding(4);
            product_tb.MaxLength = 32767;
            product_tb.Name = "product_tb";
            product_tb.Size = new Size(223, 35);
            product_tb.TabIndex = 11;
            product_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 81);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 10;
            label5.Text = "Product";
            // 
            // expiration_date_dtp
            // 
            expiration_date_dtp.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            expiration_date_dtp.Location = new Point(285, 36);
            expiration_date_dtp.Margin = new Padding(2);
            expiration_date_dtp.Name = "expiration_date_dtp";
            expiration_date_dtp.Size = new Size(224, 27);
            expiration_date_dtp.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(285, 8);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 17);
            label4.TabIndex = 8;
            label4.Text = "Expiration Date";
            // 
            // suplier_tb
            // 
            suplier_tb.AutoCompleteMode = AutoCompleteMode.None;
            suplier_tb.AutoCompleteSource = AutoCompleteSource.None;
            suplier_tb.characterCasing = CharacterCasing.Normal;
            suplier_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            suplier_tb.ForeColor = Color.FromArgb(64, 64, 64);
            suplier_tb.HintForeColor = Color.Empty;
            suplier_tb.HintText = "";
            suplier_tb.isPassword = false;
            suplier_tb.LineFocusedColor = Color.FromArgb(250, 215, 100);
            suplier_tb.LineIdleColor = Color.Gray;
            suplier_tb.LineMouseHoverColor = Color.FromArgb(250, 215, 100);
            suplier_tb.LineThickness = 2;
            suplier_tb.Location = new Point(285, 104);
            suplier_tb.Margin = new Padding(4);
            suplier_tb.MaxLength = 32767;
            suplier_tb.Name = "suplier_tb";
            suplier_tb.Size = new Size(223, 35);
            suplier_tb.TabIndex = 7;
            suplier_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(285, 81);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 6;
            label3.Text = "Suplier";
            // 
            // date_dtp
            // 
            date_dtp.CalendarFont = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_dtp.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            date_dtp.Location = new Point(9, 36);
            date_dtp.Margin = new Padding(2);
            date_dtp.Name = "date_dtp";
            date_dtp.Size = new Size(224, 27);
            date_dtp.TabIndex = 5;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(550, 454);
            Controls.Add(panel1);
            Controls.Add(titleLbl);
            Controls.Add(close_btn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AddProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProducts";
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse rad;
        private PictureBox close_btn;
        private Label titleLbl;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private DateTimePicker date_dtp;
        private Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox product_tb;
        private Label label5;
        private DateTimePicker expiration_date_dtp;
        private Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox suplier_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox price_tb;
        private Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox total_amount_tb;
        private Label label8;
        private ComboBox q_level_cbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox quantity_tb;
        private Label label7;
        private ComboBox category_cbx;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
    }
}