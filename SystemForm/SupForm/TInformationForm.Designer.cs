namespace SystemForm
{
    partial class TInformationForm
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
            AddButton = new Sunny.UI.UIButton();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            BreakdownIndex = new Sunny.UI.UITextBox();
            InformationButton = new Sunny.UI.UIButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            CostDataGridView = new Sunny.UI.UIDataGridView();
            IName = new DataGridViewTextBoxColumn();
            ITime = new DataGridViewTextBoxColumn();
            IPeople = new DataGridViewTextBoxColumn();
            DetailButton = new Sunny.UI.UIButton();
            uiGroupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CostDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Left;
            AddButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(124, 246);
            AddButton.MinimumSize = new Size(1, 1);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(195, 44);
            AddButton.TabIndex = 0;
            AddButton.Text = "发布新的宿舍通知";
            AddButton.Click += AddButton_Click;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(tableLayoutPanel2);
            uiGroupBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.Location = new Point(200, 40);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(548, 123);
            uiGroupBox2.TabIndex = 5;
            uiGroupBox2.Text = "宿舍通知查询";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(uiComboBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(BreakdownIndex, 1, 0);
            tableLayoutPanel2.Controls.Add(InformationButton, 2, 0);
            tableLayoutPanel2.Location = new Point(20, 51);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(513, 51);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // uiComboBox1
            // 
            uiComboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiComboBox1.Items.AddRange(new object[] { "按通知名查询", "按通知发送时间查询", "按发送人查询" });
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
            // BreakdownIndex
            // 
            BreakdownIndex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BreakdownIndex.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BreakdownIndex.Location = new Point(209, 7);
            BreakdownIndex.Margin = new Padding(4, 5, 4, 5);
            BreakdownIndex.MinimumSize = new Size(1, 16);
            BreakdownIndex.Name = "BreakdownIndex";
            BreakdownIndex.ShowText = false;
            BreakdownIndex.Size = new Size(197, 36);
            BreakdownIndex.TabIndex = 1;
            BreakdownIndex.TextAlignment = ContentAlignment.MiddleLeft;
            BreakdownIndex.Watermark = "";
            // 
            // InformationButton
            // 
            InformationButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            InformationButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InformationButton.Location = new Point(413, 5);
            InformationButton.MinimumSize = new Size(1, 1);
            InformationButton.Name = "InformationButton";
            InformationButton.Size = new Size(97, 41);
            InformationButton.TabIndex = 2;
            InformationButton.Text = "查询";
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(DetailButton);
            uiGroupBox1.Controls.Add(AddButton);
            uiGroupBox1.Controls.Add(CostDataGridView);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(170, 170);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(610, 311);
            uiGroupBox1.TabIndex = 6;
            uiGroupBox1.Text = "通知信息";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
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
            CostDataGridView.Columns.AddRange(new DataGridViewColumn[] { IName, ITime, IPeople });
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
            // 
            // IName
            // 
            IName.HeaderText = "通知名";
            IName.MinimumWidth = 6;
            IName.Name = "IName";
            IName.Width = 125;
            // 
            // ITime
            // 
            ITime.HeaderText = "通知时间";
            ITime.MinimumWidth = 6;
            ITime.Name = "ITime";
            ITime.Width = 125;
            // 
            // IPeople
            // 
            IPeople.HeaderText = "发布者";
            IPeople.MinimumWidth = 6;
            IPeople.Name = "IPeople";
            IPeople.Width = 125;
            // 
            // DetailButton
            // 
            DetailButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DetailButton.Location = new Point(356, 246);
            DetailButton.MinimumSize = new Size(1, 1);
            DetailButton.Name = "DetailButton";
            DetailButton.Size = new Size(162, 47);
            DetailButton.TabIndex = 2;
            DetailButton.Text = "查看通知详情";
            DetailButton.Click += DetailButton_Click;
            // 
            // TInformationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 586);
            Controls.Add(uiGroupBox1);
            Controls.Add(uiGroupBox2);
            Name = "TInformationForm";
            PageIndex = 1006;
            Text = "Message";
            uiGroupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CostDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIButton AddButton;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITextBox BreakdownIndex;
        private Sunny.UI.UIButton InformationButton;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIDataGridView CostDataGridView;
        private DataGridViewTextBoxColumn IName;
        private DataGridViewTextBoxColumn ITime;
        private DataGridViewTextBoxColumn IPeople;
        private Sunny.UI.UIButton DetailButton;
    }
}