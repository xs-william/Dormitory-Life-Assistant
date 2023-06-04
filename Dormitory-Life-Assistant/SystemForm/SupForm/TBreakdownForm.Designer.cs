namespace SystemForm
{
    partial class TBreakdownForm
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
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            BreakdownButton = new Sunny.UI.UIButton();
            BreakdownIndex = new Sunny.UI.UITextBox();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            uiButton1 = new Sunny.UI.UIButton();
            BreakdownDataGridView = new Sunny.UI.UIDataGridView();
            repairBindingSource = new BindingSource(components);
            DormNum = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Style = new DataGridViewTextBoxColumn();
            Or = new DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uiGroupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BreakdownDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repairBindingSource).BeginInit();
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
            uiGroupBox1.TabIndex = 4;
            uiGroupBox1.Text = "故障信息查询";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.36257F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.5594542F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(BreakdownButton, 2, 0);
            tableLayoutPanel1.Controls.Add(BreakdownIndex, 0, 0);
            tableLayoutPanel1.Location = new Point(20, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(513, 51);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // BreakdownButton
            // 
            BreakdownButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BreakdownButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BreakdownButton.Location = new Point(413, 5);
            BreakdownButton.MinimumSize = new Size(1, 1);
            BreakdownButton.Name = "BreakdownButton";
            BreakdownButton.Size = new Size(97, 41);
            BreakdownButton.TabIndex = 2;
            BreakdownButton.Text = "查询";
            BreakdownButton.Click += BreakdownButton_Click;
            // 
            // BreakdownIndex
            // 
            BreakdownIndex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BreakdownIndex.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BreakdownIndex.Location = new Point(4, 7);
            BreakdownIndex.Margin = new Padding(4, 5, 4, 5);
            BreakdownIndex.MinimumSize = new Size(1, 16);
            BreakdownIndex.Name = "BreakdownIndex";
            BreakdownIndex.ShowText = false;
            BreakdownIndex.Size = new Size(394, 36);
            BreakdownIndex.TabIndex = 1;
            BreakdownIndex.TextAlignment = ContentAlignment.MiddleLeft;
            BreakdownIndex.Watermark = "";
            BreakdownIndex.TextChanged += BreakdownIndex_TextChanged;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(uiButton1);
            uiGroupBox2.Controls.Add(BreakdownDataGridView);
            uiGroupBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.Location = new Point(170, 170);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(610, 291);
            uiGroupBox2.TabIndex = 5;
            uiGroupBox2.Text = "故障信息";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(237, 234);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(137, 39);
            uiButton1.TabIndex = 6;
            uiButton1.Text = "查看故障详情";
            uiButton1.Click += uiButton1_Click;
            // 
            // BreakdownDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            BreakdownDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            BreakdownDataGridView.AutoGenerateColumns = false;
            BreakdownDataGridView.BackgroundColor = Color.FromArgb(243, 249, 255);
            BreakdownDataGridView.BorderStyle = BorderStyle.None;
            BreakdownDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BreakdownDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BreakdownDataGridView.ColumnHeadersHeight = 32;
            BreakdownDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BreakdownDataGridView.Columns.AddRange(new DataGridViewColumn[] { DormNum, Time, Style, Or, iDDataGridViewTextBoxColumn });
            BreakdownDataGridView.DataSource = repairBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BreakdownDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            BreakdownDataGridView.EnableHeadersVisualStyles = false;
            BreakdownDataGridView.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BreakdownDataGridView.GridColor = Color.FromArgb(104, 173, 255);
            BreakdownDataGridView.Location = new Point(28, 44);
            BreakdownDataGridView.Name = "BreakdownDataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            BreakdownDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            BreakdownDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            BreakdownDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            BreakdownDataGridView.RowTemplate.Height = 29;
            BreakdownDataGridView.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            BreakdownDataGridView.SelectedIndex = -1;
            BreakdownDataGridView.Size = new Size(557, 229);
            BreakdownDataGridView.TabIndex = 1;
            BreakdownDataGridView.CellContentClick += BreakdownDataGridView_CellContentClick;
            // 
            // repairBindingSource
            // 
            repairBindingSource.DataSource = typeof(Dormitory_Life_Assistant.Repair);
            // 
            // DormNum
            // 
            DormNum.DataPropertyName = "CallerDorm";
            DormNum.HeaderText = "报修宿舍号";
            DormNum.MinimumWidth = 6;
            DormNum.Name = "DormNum";
            DormNum.Width = 125;
            // 
            // Time
            // 
            Time.DataPropertyName = "RepairTime";
            Time.HeaderText = "报修时间";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 125;
            // 
            // Style
            // 
            Style.DataPropertyName = "Content";
            Style.HeaderText = "故障信息";
            Style.MinimumWidth = 6;
            Style.Name = "Style";
            Style.Width = 125;
            // 
            // Or
            // 
            Or.DataPropertyName = "Status";
            Or.HeaderText = "维修状态";
            Or.MinimumWidth = 6;
            Or.Name = "Or";
            Or.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "故障编号";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // TBreakdownForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(911, 490);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiGroupBox1);
            Name = "TBreakdownForm";
            PageIndex = 1006;
            Text = "Message";
            uiGroupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BreakdownDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)repairBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIDataGridView BreakdownDataGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UITextBox BreakdownIndex;
        private Sunny.UI.UIButton BreakdownButton;
        private BindingSource repairBindingSource;
        private Sunny.UI.UIButton uiButton1;
        private DataGridViewTextBoxColumn DormNum;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Style;
        private DataGridViewTextBoxColumn Or;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}