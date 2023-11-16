namespace OMSC_MPC_CANTEEN.Auth
{
    partial class ResgisterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResgisterUser));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            login_btn = new Label();
            register_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            password_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label4 = new Label();
            username_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label3 = new Label();
            name_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            close_btn = new PictureBox();
            form_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(964, 566);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(register_btn);
            panel1.Controls.Add(password_tb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(username_tb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(name_tb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 562);
            panel1.TabIndex = 0;
            // 
            // login_btn
            // 
            login_btn.Anchor = AnchorStyles.Left;
            login_btn.AutoSize = true;
            login_btn.Font = new Font("Poppins", 10F, FontStyle.Underline, GraphicsUnit.Point);
            login_btn.Location = new Point(391, 480);
            login_btn.Margin = new Padding(2, 0, 2, 0);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(52, 25);
            login_btn.TabIndex = 10;
            login_btn.Text = "Log In";
            login_btn.Click += login_btn_Click;
            // 
            // register_btn
            // 
            register_btn.Active = false;
            register_btn.Activecolor = Color.FromArgb(46, 139, 87);
            register_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            register_btn.BackColor = Color.FromArgb(46, 139, 87);
            register_btn.BackgroundImageLayout = ImageLayout.Stretch;
            register_btn.BorderRadius = 5;
            register_btn.ButtonText = "Register";
            register_btn.DisabledColor = Color.Gray;
            register_btn.Iconcolor = Color.Transparent;
            register_btn.Iconimage = null;
            register_btn.Iconimage_right = null;
            register_btn.Iconimage_right_Selected = null;
            register_btn.Iconimage_Selected = null;
            register_btn.IconMarginLeft = 0;
            register_btn.IconMarginRight = 0;
            register_btn.IconRightVisible = true;
            register_btn.IconRightZoom = 0D;
            register_btn.IconVisible = true;
            register_btn.IconZoom = 90D;
            register_btn.IsTab = false;
            register_btn.Location = new Point(39, 424);
            register_btn.Margin = new Padding(4);
            register_btn.Name = "register_btn";
            register_btn.Normalcolor = Color.FromArgb(46, 139, 87);
            register_btn.OnHovercolor = Color.FromArgb(36, 129, 77);
            register_btn.OnHoverTextColor = Color.White;
            register_btn.selected = false;
            register_btn.Size = new Size(401, 42);
            register_btn.TabIndex = 9;
            register_btn.Text = "Register";
            register_btn.TextAlign = ContentAlignment.MiddleCenter;
            register_btn.Textcolor = Color.White;
            register_btn.TextFont = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            register_btn.Click += register_btn_Click;
            // 
            // password_tb
            // 
            password_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password_tb.AutoCompleteMode = AutoCompleteMode.None;
            password_tb.AutoCompleteSource = AutoCompleteSource.None;
            password_tb.characterCasing = CharacterCasing.Normal;
            password_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            password_tb.ForeColor = Color.FromArgb(64, 64, 64);
            password_tb.HintForeColor = Color.Empty;
            password_tb.HintText = "";
            password_tb.isPassword = true;
            password_tb.LineFocusedColor = Color.FromArgb(248, 195, 23);
            password_tb.LineIdleColor = Color.Gray;
            password_tb.LineMouseHoverColor = Color.FromArgb(248, 195, 23);
            password_tb.LineThickness = 2;
            password_tb.Location = new Point(39, 367);
            password_tb.Margin = new Padding(4, 4, 4, 4);
            password_tb.MaxLength = 32767;
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(401, 37);
            password_tb.TabIndex = 8;
            password_tb.TextAlign = HorizontalAlignment.Left;
            password_tb.KeyDown += password_tb_KeyDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 328);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // username_tb
            // 
            username_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username_tb.AutoCompleteMode = AutoCompleteMode.None;
            username_tb.AutoCompleteSource = AutoCompleteSource.None;
            username_tb.characterCasing = CharacterCasing.Normal;
            username_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            username_tb.ForeColor = Color.FromArgb(64, 64, 64);
            username_tb.HintForeColor = Color.Empty;
            username_tb.HintText = "";
            username_tb.isPassword = false;
            username_tb.LineFocusedColor = Color.FromArgb(248, 195, 23);
            username_tb.LineIdleColor = Color.Gray;
            username_tb.LineMouseHoverColor = Color.FromArgb(248, 195, 23);
            username_tb.LineThickness = 2;
            username_tb.Location = new Point(39, 280);
            username_tb.Margin = new Padding(4, 4, 4, 4);
            username_tb.MaxLength = 32767;
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(401, 37);
            username_tb.TabIndex = 6;
            username_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 246);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // name_tb
            // 
            name_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            name_tb.AutoCompleteMode = AutoCompleteMode.None;
            name_tb.AutoCompleteSource = AutoCompleteSource.None;
            name_tb.characterCasing = CharacterCasing.Normal;
            name_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            name_tb.ForeColor = Color.FromArgb(64, 64, 64);
            name_tb.HintForeColor = Color.Empty;
            name_tb.HintText = "";
            name_tb.isPassword = false;
            name_tb.LineFocusedColor = Color.FromArgb(248, 195, 23);
            name_tb.LineIdleColor = Color.Gray;
            name_tb.LineMouseHoverColor = Color.FromArgb(248, 195, 23);
            name_tb.LineThickness = 2;
            name_tb.Location = new Point(39, 193);
            name_tb.Margin = new Padding(4, 4, 4, 4);
            name_tb.MaxLength = 32767;
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(401, 37);
            name_tb.TabIndex = 4;
            name_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 164);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 84);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 42);
            label1.TabIndex = 1;
            label1.Text = "Create new account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BackgroundImage = Properties.Resources.logo;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(close_btn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(484, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 562);
            panel2.TabIndex = 1;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = Properties.Resources.circle_xmark;
            close_btn.Location = new Point(455, 5);
            close_btn.Margin = new Padding(2);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(17, 14);
            close_btn.SizeMode = PictureBoxSizeMode.Zoom;
            close_btn.TabIndex = 9;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // form_rad
            // 
            form_rad.ElipseRadius = 25;
            form_rad.TargetControl = this;
            // 
            // ResgisterUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(964, 566);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ResgisterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create new account";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_tb;
        private Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username_tb;
        private Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name_tb;
        private Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton register_btn;
        private Label login_btn;
        private Bunifu.Framework.UI.BunifuElipse form_rad;
        private PictureBox close_btn;
    }
}