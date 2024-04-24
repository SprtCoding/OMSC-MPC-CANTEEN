namespace OMSC_MPC_CANTEEN.Auth
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            close_btn = new PictureBox();
            login_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            show_pass_cb = new CheckBox();
            password_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label3 = new Label();
            username_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label2 = new Label();
            label1 = new Label();
            form_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1377, 943);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackgroundImage = Properties.Resources.logo;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 937);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(close_btn);
            panel2.Controls.Add(login_btn);
            panel2.Controls.Add(show_pass_cb);
            panel2.Controls.Add(password_tb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(username_tb);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(691, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 937);
            panel2.TabIndex = 1;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = Properties.Resources.circle_xmark;
            close_btn.Location = new Point(650, 8);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(24, 23);
            close_btn.SizeMode = PictureBoxSizeMode.Zoom;
            close_btn.TabIndex = 8;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // login_btn
            // 
            login_btn.Active = false;
            login_btn.Activecolor = Color.FromArgb(46, 139, 87);
            login_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            login_btn.BackColor = Color.FromArgb(46, 139, 87);
            login_btn.BackgroundImageLayout = ImageLayout.Stretch;
            login_btn.BorderRadius = 5;
            login_btn.ButtonText = "Login";
            login_btn.DisabledColor = Color.Gray;
            login_btn.Iconcolor = Color.Transparent;
            login_btn.Iconimage = null;
            login_btn.Iconimage_right = null;
            login_btn.Iconimage_right_Selected = null;
            login_btn.Iconimage_Selected = null;
            login_btn.IconMarginLeft = 0;
            login_btn.IconMarginRight = 0;
            login_btn.IconRightVisible = true;
            login_btn.IconRightZoom = 0D;
            login_btn.IconVisible = true;
            login_btn.IconZoom = 90D;
            login_btn.IsTab = false;
            login_btn.Location = new Point(56, 655);
            login_btn.Margin = new Padding(6, 7, 6, 7);
            login_btn.Name = "login_btn";
            login_btn.Normalcolor = Color.FromArgb(46, 139, 87);
            login_btn.OnHovercolor = Color.FromArgb(36, 129, 77);
            login_btn.OnHoverTextColor = Color.White;
            login_btn.selected = false;
            login_btn.Size = new Size(571, 70);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.TextAlign = ContentAlignment.MiddleCenter;
            login_btn.Textcolor = Color.White;
            login_btn.TextFont = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login_btn.Click += login_btn_Click;
            // 
            // show_pass_cb
            // 
            show_pass_cb.Anchor = AnchorStyles.Left;
            show_pass_cb.AutoSize = true;
            show_pass_cb.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            show_pass_cb.Location = new Point(56, 583);
            show_pass_cb.Name = "show_pass_cb";
            show_pass_cb.Size = new Size(196, 40);
            show_pass_cb.TabIndex = 5;
            show_pass_cb.Text = "Show Password";
            show_pass_cb.UseVisualStyleBackColor = true;
            show_pass_cb.CheckedChanged += show_pass_cb_CheckedChanged;
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
            password_tb.Location = new Point(56, 487);
            password_tb.Margin = new Padding(6, 7, 6, 7);
            password_tb.MaxLength = 32767;
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(571, 72);
            password_tb.TabIndex = 4;
            password_tb.TextAlign = HorizontalAlignment.Left;
            password_tb.KeyDown += password_tb_KeyDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(56, 438);
            label3.Name = "label3";
            label3.Size = new Size(116, 36);
            label3.TabIndex = 3;
            label3.Text = "Password";
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
            username_tb.Location = new Point(56, 347);
            username_tb.Margin = new Padding(6, 7, 6, 7);
            username_tb.MaxLength = 32767;
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(571, 68);
            username_tb.TabIndex = 2;
            username_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 298);
            label2.Name = "label2";
            label2.Size = new Size(121, 36);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(170, 167);
            label1.Name = "label1";
            label1.Size = new Size(361, 64);
            label1.TabIndex = 0;
            label1.Text = "Log In to Continue";
            // 
            // form_rad
            // 
            form_rad.ElipseRadius = 25;
            form_rad.TargetControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1377, 943);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_tb;
        private Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username_tb;
        private Bunifu.Framework.UI.BunifuFlatButton login_btn;
        private CheckBox show_pass_cb;
        private Bunifu.Framework.UI.BunifuElipse form_rad;
        private PictureBox close_btn;
    }
}