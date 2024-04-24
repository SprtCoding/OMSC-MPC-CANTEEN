namespace OMSC_MPC_CANTEEN.Dashboard.Menus.PrintData
{
    partial class PrintPreview
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
            printPanel = new Panel();
            DTG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dateNow = new Label();
            itemType = new Label();
            title_lbl = new Label();
            print_btn = new PictureBox();
            printPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)print_btn).BeginInit();
            SuspendLayout();
            // 
            // printPanel
            // 
            printPanel.Controls.Add(DTG);
            printPanel.Controls.Add(dateNow);
            printPanel.Controls.Add(itemType);
            printPanel.Controls.Add(title_lbl);
            printPanel.Location = new Point(12, 57);
            printPanel.Name = "printPanel";
            printPanel.Size = new Size(1279, 953);
            printPanel.TabIndex = 0;
            // 
            // DTG
            // 
            DTG.AllowUserToAddRows = false;
            DTG.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            DTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DTG.BackgroundColor = Color.White;
            DTG.BorderStyle = BorderStyle.None;
            DTG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(248, 195, 23);
            dataGridViewCellStyle5.Font = new Font("Poppins", 6F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(250, 215, 100);
            dataGridViewCellStyle5.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Poppins", 6F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DTG.DefaultCellStyle = dataGridViewCellStyle6;
            DTG.DoubleBuffered = true;
            DTG.EditMode = DataGridViewEditMode.EditOnEnter;
            DTG.EnableHeadersVisualStyles = false;
            DTG.GridColor = Color.FromArgb(250, 215, 100);
            DTG.HeaderBgColor = Color.FromArgb(248, 195, 23);
            DTG.HeaderForeColor = SystemColors.ControlText;
            DTG.Location = new Point(13, 210);
            DTG.Name = "DTG";
            DTG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DTG.RowHeadersVisible = false;
            DTG.RowHeadersWidth = 62;
            DTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DTG.RowTemplate.Height = 33;
            DTG.Size = new Size(1249, 726);
            DTG.TabIndex = 16;
            // 
            // dateNow
            // 
            dateNow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateNow.Location = new Point(253, 117);
            dateNow.Name = "dateNow";
            dateNow.Size = new Size(773, 70);
            dateNow.TabIndex = 2;
            dateNow.Text = "date now";
            dateNow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // itemType
            // 
            itemType.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            itemType.Location = new Point(253, 61);
            itemType.Name = "itemType";
            itemType.Size = new Size(773, 56);
            itemType.TabIndex = 1;
            itemType.Text = "type";
            itemType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            title_lbl.Location = new Point(549, 16);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(180, 45);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Daily Sales";
            // 
            // print_btn
            // 
            print_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            print_btn.Image = Properties.Resources.print;
            print_btn.Location = new Point(1262, 12);
            print_btn.Name = "print_btn";
            print_btn.Size = new Size(29, 33);
            print_btn.SizeMode = PictureBoxSizeMode.Zoom;
            print_btn.TabIndex = 15;
            print_btn.TabStop = false;
            print_btn.Click += print_btn_Click;
            // 
            // PrintPreview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1303, 1022);
            Controls.Add(print_btn);
            Controls.Add(printPanel);
            Name = "PrintPreview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintPreview";
            printPanel.ResumeLayout(false);
            printPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTG).EndInit();
            ((System.ComponentModel.ISupportInitialize)print_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel printPanel;
        private Label title_lbl;
        private Label itemType;
        private Label dateNow;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DTG;
        private PictureBox print_btn;
    }
}