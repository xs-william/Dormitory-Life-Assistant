namespace LifeHelper
{
    partial class TCostForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            CostIndex = new Sunny.UI.UITextBox();
            CostButton = new Sunny.UI.UIButton();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            CostDataGridView = new Sunny.UI.UIDataGridView();
            DormNum = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Money = new DataGridViewTextBoxColumn();
            Or = new DataGridViewTextBoxColumn();
            uiGroupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CostDataGridView).BeginInit();
            SuspendLayout();
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(tableLayoutPanel1);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(200, 40);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(548, 123);
            uiGroupBox1.TabIndex = 3;
            uiGroupBox1.Text = "欠费信息查询";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(uiComboBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(CostIndex, 1, 0);
            tableLayoutPanel1.Controls.Add(CostButton, 2, 0);
            tableLayoutPanel1.Location = new Point(20, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(513, 51);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // uiComboBox1
            // 
            uiComboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiComboBox1.Items.AddRange(new object[] { "按欠费宿舍号查询", "按欠费时间查询", "按欠费金额查询", "按是否缴费查询" });
            uiComboBox1.Location = new Point(4, 7);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Size = new Size(197, 36);
            uiComboBox1.TabIndex = 0;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "";
            // 
            // CostIndex
            // 
            CostIndex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CostIndex.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CostIndex.Location = new Point(209, 7);
            CostIndex.Margin = new Padding(4, 5, 4, 5);
            CostIndex.MinimumSize = new Size(1, 16);
            CostIndex.Name = "CostIndex";
            CostIndex.ShowText = false;
            CostIndex.Size = new Size(197, 36);
            CostIndex.TabIndex = 1;
            CostIndex.TextAlignment = ContentAlignment.MiddleLeft;
            CostIndex.Watermark = "";
            // 
            // CostButton
            // 
            CostButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CostButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CostButton.Location = new Point(413, 5);
            CostButton.MinimumSize = new Size(1, 1);
            CostButton.Name = "CostButton";
            CostButton.Size = new Size(97, 41);
            CostButton.TabIndex = 2;
            CostButton.Text = "查询";
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(CostDataGridView);
            uiGroupBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.Location = new Point(170, 170);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(610, 291);
            uiGroupBox2.TabIndex = 4;
            uiGroupBox2.Text = "欠费信息";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // CostDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            CostDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CostDataGridView.BackgroundColor = Color.FromArgb(243, 249, 255);
            CostDataGridView.BorderStyle = BorderStyle.None;
            CostDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CostDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CostDataGridView.ColumnHeadersHeight = 32;
            CostDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CostDataGridView.Columns.AddRange(new DataGridViewColumn[] { DormNum, Time, Money, Or });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CostDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            CostDataGridView.EnableHeadersVisualStyles = false;
            CostDataGridView.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CostDataGridView.GridColor = Color.FromArgb(104, 173, 255);
            CostDataGridView.Location = new Point(27, 44);
            CostDataGridView.Name = "CostDataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CostDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CostDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            CostDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            CostDataGridView.RowTemplate.Height = 29;
            CostDataGridView.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            CostDataGridView.SelectedIndex = -1;
            CostDataGridView.Size = new Size(557, 229);
            CostDataGridView.TabIndex = 1;
            CostDataGridView.CellContentClick += CostDataGridView_CellContentClick;
            // 
            // DormNum
            // 
            DormNum.HeaderText = "欠费宿舍号";
            DormNum.MinimumWidth = 6;
            DormNum.Name = "DormNum";
            DormNum.Width = 125;
            // 
            // Time
            // 
            Time.HeaderText = "欠费时间";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 125;
            // 
            // Money
            // 
            Money.HeaderText = "欠费金额";
            Money.MinimumWidth = 6;
            Money.Name = "Money";
            Money.Width = 125;
            // 
            // Or
            // 
            Or.HeaderText = "是否缴费";
            Or.MinimumWidth = 6;
            Or.Name = "Or";
            Or.Width = 125;
            // 
            // TCostForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiGroupBox1);
            Name = "TCostForm";
            PageIndex = 1006;
            Text = "Message";
            uiGroupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CostDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITextBox CostIndex;
        private Sunny.UI.UIButton CostButton;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIDataGridView CostDataGridView;
        private DataGridViewTextBoxColumn DormNum;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Money;
        private DataGridViewTextBoxColumn Or;
    }
}