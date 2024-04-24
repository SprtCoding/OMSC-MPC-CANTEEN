namespace OMSC_MPC_CANTEEN.Dashboard.Menus
{
    partial class Stocks
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stocks));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            STOCKS_DTG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            print_tooltip = new ToolTip(components);
            print_btn = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)STOCKS_DTG).BeginInit();
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
            tableLayoutPanel1.TabIndex = 5;
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
            label1.Size = new Size(81, 34);
            label1.TabIndex = 1;
            label1.Text = "Stocks";
            // 
            // STOCKS_DTG
            // 
            STOCKS_DTG.AllowUserToAddRows = false;
            STOCKS_DTG.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            STOCKS_DTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            STOCKS_DTG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            STOCKS_DTG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            STOCKS_DTG.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            STOCKS_DTG.BackgroundColor = SystemColors.Control;
            STOCKS_DTG.BorderStyle = BorderStyle.None;
            STOCKS_DTG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 195, 23);
            dataGridViewCellStyle2.Font = new Font("Poppins Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 215, 100);
            dataGridViewCellStyle2.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            STOCKS_DTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            STOCKS_DTG.ColumnHeadersHeight = 45;
            STOCKS_DTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(250, 215, 100);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            STOCKS_DTG.DefaultCellStyle = dataGridViewCellStyle3;
            STOCKS_DTG.DoubleBuffered = true;
            STOCKS_DTG.EnableHeadersVisualStyles = false;
            STOCKS_DTG.GridColor = Color.FromArgb(250, 215, 100);
            STOCKS_DTG.HeaderBgColor = Color.FromArgb(248, 195, 23);
            STOCKS_DTG.HeaderForeColor = SystemColors.ControlText;
            STOCKS_DTG.Location = new Point(8, 106);
            STOCKS_DTG.Margin = new Padding(2);
            STOCKS_DTG.Name = "STOCKS_DTG";
            STOCKS_DTG.ReadOnly = true;
            STOCKS_DTG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            STOCKS_DTG.RowHeadersVisible = false;
            STOCKS_DTG.RowHeadersWidth = 62;
            STOCKS_DTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            STOCKS_DTG.RowTemplate.Height = 33;
            STOCKS_DTG.Size = new Size(747, 447);
            STOCKS_DTG.TabIndex = 8;
            STOCKS_DTG.CellContentClick += STOCKS_DTG_CellContentClick;
            // 
            // print_btn
            // 
            print_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            print_btn.Image = (Image)resources.GetObject("print_btn.Image");
            print_btn.Location = new Point(730, 77);
            print_btn.Margin = new Padding(2);
            print_btn.Name = "print_btn";
            print_btn.Size = new Size(25, 25);
            print_btn.SizeMode = PictureBoxSizeMode.Zoom;
            print_btn.TabIndex = 11;
            print_btn.TabStop = false;
            print_btn.Click += print_btn_Click;
            print_btn.MouseEnter += print_btn_MouseEnter;
            // 
            // Stocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 560);
            Controls.Add(print_btn);
            Controls.Add(STOCKS_DTG);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Stocks";
            Text = "Stocks";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)STOCKS_DTG).EndInit();
            ((System.ComponentModel.ISupportInitialize)print_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid STOCKS_DTG;
        private ToolTip print_tooltip;
        private PictureBox print_btn;
    }
}