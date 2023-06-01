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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            BreakdownIndex = new Sunny.UI.UITextBox();
            BreakdownButton = new Sunny.UI.UIButton();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            DetailButton = new Sunny.UI.UIButton();
            BreakdownDataGridView = new Sunny.UI.UIDataGridView();
            DormNum = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Style = new DataGridViewTextBoxColumn();
            Or = new DataGridViewTextBoxColumn();
            uiGroupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BreakdownDataGridView).BeginInit();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(uiComboBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(BreakdownIndex, 1, 0);
            tableLayoutPanel1.Controls.Add(BreakdownButton, 2, 0);
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
            uiComboBox1.Items.AddRange(new object[] { "按报修宿舍号查询", "按报修时间查询", "按故障类型查询", "按是否维修查询" });
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
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(DetailButton);
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
            // DetailButton
            // 
            DetailButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DetailButton.Location = new Point(240, 230);
            DetailButton.MinimumSize = new Size(1, 1);
            DetailButton.Name = "DetailButton";
            DetailButton.Size = new Size(175, 50);
            DetailButton.TabIndex = 2;
            DetailButton.Text = "查看故障详情";
            DetailButton.Click += DetailButton_Click;
            // 
            // BreakdownDataGridView
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 249, 255);
            BreakdownDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            BreakdownDataGridView.BackgroundColor = Color.FromArgb(243, 249, 255);
            BreakdownDataGridView.BorderStyle = BorderStyle.None;
            BreakdownDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            BreakdownDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            BreakdownDataGridView.ColumnHeadersHeight = 32;
            BreakdownDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BreakdownDataGridView.Columns.AddRange(new DataGridViewColumn[] { DormNum, Time, Style, Or });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            BreakdownDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            BreakdownDataGridView.EnableHeadersVisualStyles = false;
            BreakdownDataGridView.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BreakdownDataGridView.GridColor = Color.FromArgb(104, 173, 255);
            BreakdownDataGridView.Location = new Point(27, 44);
            BreakdownDataGridView.Name = "BreakdownDataGridView";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            BreakdownDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            BreakdownDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(48, 48, 48);
            BreakdownDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            BreakdownDataGridView.RowTemplate.Height = 29;
            BreakdownDataGridView.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            BreakdownDataGridView.SelectedIndex = -1;
            BreakdownDataGridView.Size = new Size(557, 229);
            BreakdownDataGridView.TabIndex = 1;
            BreakdownDataGridView.CellContentClick += BreakdownDataGridView_CellContentClick;
            // 
            // DormNum
            // 
            DormNum.HeaderText = "报修宿舍号";
            DormNum.MinimumWidth = 6;
            DormNum.Name = "DormNum";
            DormNum.Width = 125;
            // 
            // Time
            // 
            Time.HeaderText = "报修时间";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 125;
            // 
            // Style
            // 
            Style.HeaderText = "故障类型";
            Style.MinimumWidth = 6;
            Style.Name = "Style";
            Style.Width = 125;
            // 
            // Or
            // 
            Or.HeaderText = "是否维修";
            Or.MinimumWidth = 6;
            Or.Name = "Or";
            Or.Width = 125;
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
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITextBox BreakdownIndex;
        private Sunny.UI.UIButton BreakdownButton;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIDataGridView BreakdownDataGridView;
        private DataGridViewTextBoxColumn DormNum;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Style;
        private DataGridViewTextBoxColumn Or;
        private Sunny.UI.UIButton DetailButton;
    }
}