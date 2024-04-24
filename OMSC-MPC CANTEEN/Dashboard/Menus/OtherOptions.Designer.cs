namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    partial class OtherOptions
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherOptions));
            account_tab = new TabControl();
            userLogs = new TabPage();
            userLogsPanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            Login_time_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            panel1 = new Panel();
            label5 = new Label();
            overview = new TabPage();
            overviewPanel = new Panel();
            details_panel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            tabPage1 = new TabPage();
            account_main_panel = new Panel();
            save_username_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            edit_btn = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            pass_panel = new Panel();
            check_pic = new PictureBox();
            label8 = new Label();
            new_pass_tb = new TextBox();
            label7 = new Label();
            label4 = new Label();
            old_pass_tb = new TextBox();
            save_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            change_pass_btn = new Label();
            username_tb = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            account_tab.SuspendLayout();
            userLogs.SuspendLayout();
            userLogsPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Login_time_dtg).BeginInit();
            panel1.SuspendLayout();
            overview.SuspendLayout();
            overviewPanel.SuspendLayout();
            details_panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage1.SuspendLayout();
            account_main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edit_btn).BeginInit();
            panel4.SuspendLayout();
            pass_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)check_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // account_tab
            // 
            account_tab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            account_tab.Controls.Add(userLogs);
            account_tab.Controls.Add(overview);
            account_tab.Controls.Add(tabPage1);
            account_tab.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            account_tab.Location = new Point(17, 20);
            account_tab.Margin = new Padding(4, 5, 4, 5);
            account_tab.Name = "account_tab";
            account_tab.SelectedIndex = 0;
            account_tab.Size = new Size(1056, 893);
            account_tab.TabIndex = 0;
            // 
            // userLogs
            // 
            userLogs.Controls.Add(userLogsPanel);
            userLogs.Location = new Point(4, 40);
            userLogs.Margin = new Padding(4, 5, 4, 5);
            userLogs.Name = "userLogs";
            userLogs.Padding = new Padding(4, 5, 4, 5);
            userLogs.Size = new Size(1048, 849);
            userLogs.TabIndex = 0;
            userLogs.Text = "User logs";
            userLogs.UseVisualStyleBackColor = true;
            // 
            // userLogsPanel
            // 
            userLogsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userLogsPanel.Controls.Add(tableLayoutPanel2);
            userLogsPanel.Controls.Add(panel1);
            userLogsPanel.Location = new Point(9, 10);
            userLogsPanel.Margin = new Padding(4, 5, 4, 5);
            userLogsPanel.Name = "userLogsPanel";
            userLogsPanel.Size = new Size(1027, 815);
            userLogsPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 85);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1027, 730);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(Login_time_dtg);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 5);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1019, 720);
            panel3.TabIndex = 0;
            // 
            // Login_time_dtg
            // 
            Login_time_dtg.AllowUserToAddRows = false;
            Login_time_dtg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            Login_time_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            Login_time_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Login_time_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Login_time_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Login_time_dtg.BackgroundColor = SystemColors.Control;
            Login_time_dtg.BorderStyle = BorderStyle.None;
            Login_time_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(248, 195, 23);
            dataGridViewCellStyle5.Font = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(250, 215, 100);
            dataGridViewCellStyle5.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            Login_time_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            Login_time_dtg.ColumnHeadersHeight = 45;
            Login_time_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            Login_time_dtg.DefaultCellStyle = dataGridViewCellStyle6;
            Login_time_dtg.DoubleBuffered = true;
            Login_time_dtg.EditMode = DataGridViewEditMode.EditOnEnter;
            Login_time_dtg.EnableHeadersVisualStyles = false;
            Login_time_dtg.GridColor = Color.FromArgb(250, 215, 100);
            Login_time_dtg.HeaderBgColor = Color.FromArgb(248, 195, 23);
            Login_time_dtg.HeaderForeColor = SystemColors.ControlText;
            Login_time_dtg.Location = new Point(13, 20);
            Login_time_dtg.Name = "Login_time_dtg";
            Login_time_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Login_time_dtg.RowHeadersVisible = false;
            Login_time_dtg.RowHeadersWidth = 62;
            Login_time_dtg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Login_time_dtg.RowTemplate.Height = 33;
            Login_time_dtg.Size = new Size(993, 683);
            Login_time_dtg.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 85);
            panel1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 22);
            label5.Name = "label5";
            label5.Size = new Size(109, 36);
            label5.TabIndex = 9;
            label5.Text = "User Logs";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // overview
            // 
            overview.Controls.Add(pictureBox2);
            overview.Controls.Add(overviewPanel);
            overview.Location = new Point(4, 40);
            overview.Margin = new Padding(4, 5, 4, 5);
            overview.Name = "overview";
            overview.Padding = new Padding(4, 5, 4, 5);
            overview.Size = new Size(1048, 849);
            overview.TabIndex = 1;
            overview.Text = "Overview";
            overview.UseVisualStyleBackColor = true;
            // 
            // overviewPanel
            // 
            overviewPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            overviewPanel.Controls.Add(details_panel);
            overviewPanel.Location = new Point(9, 232);
            overviewPanel.Margin = new Padding(4, 5, 4, 5);
            overviewPanel.Name = "overviewPanel";
            overviewPanel.Size = new Size(1027, 607);
            overviewPanel.TabIndex = 1;
            // 
            // details_panel
            // 
            details_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            details_panel.AutoScroll = true;
            details_panel.Controls.Add(tableLayoutPanel1);
            details_panel.Location = new Point(4, 5);
            details_panel.Margin = new Padding(4, 5, 4, 5);
            details_panel.Name = "details_panel";
            details_panel.Size = new Size(1019, 597);
            details_panel.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 1667F));
            tableLayoutPanel1.Size = new Size(1019, 597);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1011, 1657);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(7, 8, 7, 8);
            label2.Size = new Size(1011, 1657);
            label2.TabIndex = 10;
            label2.Text = resources.GetString("label2.Text");
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(account_main_panel);
            tabPage1.Location = new Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1048, 849);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // account_main_panel
            // 
            account_main_panel.BackgroundImageLayout = ImageLayout.None;
            account_main_panel.Controls.Add(save_username_btn);
            account_main_panel.Controls.Add(edit_btn);
            account_main_panel.Controls.Add(panel4);
            account_main_panel.Controls.Add(pass_panel);
            account_main_panel.Controls.Add(change_pass_btn);
            account_main_panel.Controls.Add(username_tb);
            account_main_panel.Controls.Add(label3);
            account_main_panel.Controls.Add(label1);
            account_main_panel.Dock = DockStyle.Fill;
            account_main_panel.Location = new Point(3, 3);
            account_main_panel.Name = "account_main_panel";
            account_main_panel.Size = new Size(1042, 843);
            account_main_panel.TabIndex = 0;
            // 
            // save_username_btn
            // 
            save_username_btn.Active = false;
            save_username_btn.Activecolor = Color.FromArgb(46, 139, 87);
            save_username_btn.BackColor = Color.SeaGreen;
            save_username_btn.BackgroundImageLayout = ImageLayout.Stretch;
            save_username_btn.BorderRadius = 5;
            save_username_btn.ButtonText = "Save";
            save_username_btn.DisabledColor = Color.Gray;
            save_username_btn.Enabled = false;
            save_username_btn.Iconcolor = Color.Transparent;
            save_username_btn.Iconimage = null;
            save_username_btn.Iconimage_right = null;
            save_username_btn.Iconimage_right_Selected = null;
            save_username_btn.Iconimage_Selected = null;
            save_username_btn.IconMarginLeft = 0;
            save_username_btn.IconMarginRight = 0;
            save_username_btn.IconRightVisible = false;
            save_username_btn.IconRightZoom = 0D;
            save_username_btn.IconVisible = false;
            save_username_btn.IconZoom = 90D;
            save_username_btn.IsTab = false;
            save_username_btn.Location = new Point(16, 161);
            save_username_btn.Margin = new Padding(6, 7, 6, 7);
            save_username_btn.Name = "save_username_btn";
            save_username_btn.Normalcolor = Color.SeaGreen;
            save_username_btn.OnHovercolor = Color.FromArgb(115, 177, 143);
            save_username_btn.OnHoverTextColor = Color.DimGray;
            save_username_btn.selected = false;
            save_username_btn.Size = new Size(126, 46);
            save_username_btn.TabIndex = 14;
            save_username_btn.Text = "Save";
            save_username_btn.TextAlign = ContentAlignment.MiddleCenter;
            save_username_btn.Textcolor = Color.White;
            save_username_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            save_username_btn.Visible = false;
            save_username_btn.Click += save_username_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.Image = Properties.Resources.edit_small;
            edit_btn.Location = new Point(433, 106);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(45, 45);
            edit_btn.SizeMode = PictureBoxSizeMode.CenterImage;
            edit_btn.TabIndex = 13;
            edit_btn.TabStop = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(498, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 812);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BackgroundImage = Properties.Resources.logo;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(531, 812);
            panel5.TabIndex = 1;
            // 
            // pass_panel
            // 
            pass_panel.Controls.Add(check_pic);
            pass_panel.Controls.Add(label8);
            pass_panel.Controls.Add(new_pass_tb);
            pass_panel.Controls.Add(label7);
            pass_panel.Controls.Add(label4);
            pass_panel.Controls.Add(old_pass_tb);
            pass_panel.Controls.Add(save_btn);
            pass_panel.Location = new Point(16, 229);
            pass_panel.Name = "pass_panel";
            pass_panel.Size = new Size(462, 431);
            pass_panel.TabIndex = 9;
            pass_panel.Visible = false;
            // 
            // check_pic
            // 
            check_pic.Image = Properties.Resources.badge_check;
            check_pic.Location = new Point(419, 129);
            check_pic.Name = "check_pic";
            check_pic.Size = new Size(25, 25);
            check_pic.SizeMode = PictureBoxSizeMode.CenterImage;
            check_pic.TabIndex = 12;
            check_pic.TabStop = false;
            check_pic.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(25, 188);
            label8.Name = "label8";
            label8.Size = new Size(146, 31);
            label8.TabIndex = 10;
            label8.Text = "New Password";
            // 
            // new_pass_tb
            // 
            new_pass_tb.BorderStyle = BorderStyle.FixedSingle;
            new_pass_tb.Enabled = false;
            new_pass_tb.Location = new Point(25, 222);
            new_pass_tb.Multiline = true;
            new_pass_tb.Name = "new_pass_tb";
            new_pass_tb.PasswordChar = '#';
            new_pass_tb.Size = new Size(388, 46);
            new_pass_tb.TabIndex = 11;
            new_pass_tb.WordWrap = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins SemiBold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 26);
            label7.Name = "label7";
            label7.Size = new Size(254, 36);
            label7.TabIndex = 9;
            label7.Text = "Change your password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 84);
            label4.Name = "label4";
            label4.Size = new Size(138, 31);
            label4.TabIndex = 3;
            label4.Text = "Old Password";
            // 
            // old_pass_tb
            // 
            old_pass_tb.BorderStyle = BorderStyle.FixedSingle;
            old_pass_tb.Location = new Point(25, 118);
            old_pass_tb.Multiline = true;
            old_pass_tb.Name = "old_pass_tb";
            old_pass_tb.PasswordChar = '#';
            old_pass_tb.Size = new Size(388, 46);
            old_pass_tb.TabIndex = 4;
            old_pass_tb.WordWrap = false;
            old_pass_tb.TextChanged += old_pass_tb_TextChanged;
            // 
            // save_btn
            // 
            save_btn.Active = false;
            save_btn.Activecolor = Color.FromArgb(46, 139, 87);
            save_btn.BackColor = Color.SeaGreen;
            save_btn.BackgroundImageLayout = ImageLayout.Stretch;
            save_btn.BorderRadius = 5;
            save_btn.ButtonText = "Save";
            save_btn.DisabledColor = Color.Gray;
            save_btn.Enabled = false;
            save_btn.Iconcolor = Color.Transparent;
            save_btn.Iconimage = null;
            save_btn.Iconimage_right = null;
            save_btn.Iconimage_right_Selected = null;
            save_btn.Iconimage_Selected = null;
            save_btn.IconMarginLeft = 0;
            save_btn.IconMarginRight = 0;
            save_btn.IconRightVisible = false;
            save_btn.IconRightZoom = 0D;
            save_btn.IconVisible = false;
            save_btn.IconZoom = 90D;
            save_btn.IsTab = false;
            save_btn.Location = new Point(287, 297);
            save_btn.Margin = new Padding(6, 7, 6, 7);
            save_btn.Name = "save_btn";
            save_btn.Normalcolor = Color.SeaGreen;
            save_btn.OnHovercolor = Color.FromArgb(115, 177, 143);
            save_btn.OnHoverTextColor = Color.DimGray;
            save_btn.selected = false;
            save_btn.Size = new Size(126, 46);
            save_btn.TabIndex = 7;
            save_btn.Text = "Save";
            save_btn.TextAlign = ContentAlignment.MiddleCenter;
            save_btn.Textcolor = Color.White;
            save_btn.TextFont = new Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Click += save_btn_Click;
            // 
            // change_pass_btn
            // 
            change_pass_btn.AutoSize = true;
            change_pass_btn.Cursor = Cursors.Hand;
            change_pass_btn.Font = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            change_pass_btn.Location = new Point(287, 173);
            change_pass_btn.Name = "change_pass_btn";
            change_pass_btn.Size = new Size(191, 31);
            change_pass_btn.TabIndex = 8;
            change_pass_btn.Text = "Change password?";
            change_pass_btn.Click += change_pass_btn_Click;
            // 
            // username_tb
            // 
            username_tb.BorderStyle = BorderStyle.FixedSingle;
            username_tb.Enabled = false;
            username_tb.Location = new Point(16, 105);
            username_tb.Multiline = true;
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(413, 46);
            username_tb.TabIndex = 2;
            username_tb.TextChanged += username_tb_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 71);
            label3.Name = "label3";
            label3.Size = new Size(108, 31);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(223, 42);
            label1.TabIndex = 0;
            label1.Text = "Account Settings";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(378, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(292, 216);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // OtherOptions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 933);
            Controls.Add(account_tab);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "OtherOptions";
            Text = "OtherOptions";
            account_tab.ResumeLayout(false);
            userLogs.ResumeLayout(false);
            userLogsPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Login_time_dtg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            overview.ResumeLayout(false);
            overviewPanel.ResumeLayout(false);
            details_panel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            account_main_panel.ResumeLayout(false);
            account_main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edit_btn).EndInit();
            panel4.ResumeLayout(false);
            pass_panel.ResumeLayout(false);
            pass_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)check_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl account_tab;
        private TabPage userLogs;
        private TabPage overview;
        private Panel userLogsPanel;
        private Panel panel1;
        private Label label5;
        private Panel overviewPanel;
        private Panel details_panel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Login_time_dtg;
        private TabPage tabPage1;
        private Panel account_main_panel;
        private Label label1;
        private TextBox username_tb;
        private Label label3;
        private TextBox old_pass_tb;
        private Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton save_btn;
        private Label change_pass_btn;
        private Panel pass_panel;
        private PictureBox check_pic;
        private Label label8;
        private TextBox new_pass_tb;
        private Label label7;
        private Panel panel4;
        private Panel panel5;
        private PictureBox edit_btn;
        private Bunifu.Framework.UI.BunifuFlatButton save_username_btn;
        private PictureBox pictureBox2;
    }
}