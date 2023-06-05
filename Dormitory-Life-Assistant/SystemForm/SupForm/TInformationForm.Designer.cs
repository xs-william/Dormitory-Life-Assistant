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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            AddButton = new Sunny.UI.UIButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            DetailButton = new Sunny.UI.UIButton();
            CostDataGridView = new Sunny.UI.UIDataGridView();
            IName = new DataGridViewTextBoxColumn();
            IPeople = new DataGridViewTextBoxColumn();
            ITime = new DataGridViewTextBoxColumn();
            dormMessageBindingSource = new BindingSource(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            BreakdownIndex = new Sunny.UI.UITextBox();
            queryButton = new Sunny.UI.UIButton();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CostDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dormMessageBindingSource).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Left;
            AddButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(255, 385);
            AddButton.MinimumSize = new Size(1, 1);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(170, 44);
            AddButton.TabIndex = 0;
            AddButton.Text = "发布宿舍通知";
            AddButton.Click += AddButton_Click;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(DetailButton);
            uiGroupBox1.Controls.Add(AddButton);
            uiGroupBox1.Controls.Add(CostDataGridView);
            uiGroupBox1.Dock = DockStyle.Bottom;
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(0, 49);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(975, 441);
            uiGroupBox1.TabIndex = 6;
            uiGroupBox1.Text = "通知信息";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // DetailButton
            // 
            DetailButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DetailButton.Location = new Point(506, 385);
            DetailButton.MinimumSize = new Size(1, 1);
            DetailButton.Name = "DetailButton";
            DetailButton.Size = new Size(170, 44);
            DetailButton.TabIndex = 2;
            DetailButton.Text = "查看通知详情";
            DetailButton.Click += DetailButton_Click;
            // 
            // CostDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            CostDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CostDataGridView.AutoGenerateColumns = false;
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
            CostDataGridView.Columns.AddRange(new DataGridViewColumn[] { IName, IPeople, ITime });
            CostDataGridView.DataSource = dormMessageBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CostDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            CostDataGridView.Dock = DockStyle.Top;
            CostDataGridView.EnableHeadersVisualStyles = false;
            CostDataGridView.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CostDataGridView.GridColor = Color.FromArgb(104, 173, 255);
            CostDataGridView.Location = new Point(0, 32);
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
            CostDataGridView.Size = new Size(975, 349);
            CostDataGridView.TabIndex = 1;
            // 
            // IName
            // 
            IName.DataPropertyName = "Content";
            IName.HeaderText = "通知内容";
            IName.MinimumWidth = 6;
            IName.Name = "IName";
            IName.Width = 600;
            // 
            // IPeople
            // 
            IPeople.DataPropertyName = "SupervisorName";
            IPeople.HeaderText = "发布者";
            IPeople.MinimumWidth = 6;
            IPeople.Name = "IPeople";
            IPeople.ReadOnly = true;
            IPeople.Width = 125;
            // 
            // ITime
            // 
            ITime.DataPropertyName = "Time";
            ITime.HeaderText = "通知时间";
            ITime.MinimumWidth = 6;
            ITime.Name = "ITime";
            ITime.Width = 200;
            // 
            // dormMessageBindingSource
            // 
            dormMessageBindingSource.DataSource = typeof(Dormitory_Life_Assistant.DormMessage);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(uiComboBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(BreakdownIndex, 1, 0);
            tableLayoutPanel2.Controls.Add(queryButton, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(595, 49);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // uiComboBox1
            // 
            uiComboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiComboBox1.Items.AddRange(new object[] { "", "通知内容", "通知时间", "发送人" });
            uiComboBox1.Location = new Point(4, 6);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Radius = 2;
            uiComboBox1.Size = new Size(230, 36);
            uiComboBox1.TabIndex = 0;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "";
            // 
            // BreakdownIndex
            // 
            BreakdownIndex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BreakdownIndex.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BreakdownIndex.Location = new Point(242, 5);
            BreakdownIndex.Margin = new Padding(4, 5, 4, 5);
            BreakdownIndex.MinimumSize = new Size(1, 16);
            BreakdownIndex.Name = "BreakdownIndex";
            BreakdownIndex.ShowText = false;
            BreakdownIndex.Size = new Size(230, 38);
            BreakdownIndex.TabIndex = 1;
            BreakdownIndex.TextAlignment = ContentAlignment.MiddleLeft;
            BreakdownIndex.Watermark = "";
            // 
            // queryButton
            // 
            queryButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            queryButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            queryButton.Location = new Point(479, 7);
            queryButton.MinimumSize = new Size(1, 1);
            queryButton.Name = "queryButton";
            queryButton.Size = new Size(113, 34);
            queryButton.TabIndex = 2;
            queryButton.Text = "查询";
            queryButton.Click += queryButton_Click;
            // 
            // TInformationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(uiGroupBox1);
            Name = "TInformationForm";
            PageIndex = 1006;
            Text = "Message";
            uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CostDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dormMessageBindingSource).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIButton AddButton;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIDataGridView CostDataGridView;
        private Sunny.UI.UIButton DetailButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITextBox BreakdownIndex;
        private Sunny.UI.UIButton queryButton;
        private DataGridViewTextBoxColumn IName;
        private DataGridViewTextBoxColumn IPeople;
        private DataGridViewTextBoxColumn ITime;
        private BindingSource dormMessageBindingSource;
    }
}