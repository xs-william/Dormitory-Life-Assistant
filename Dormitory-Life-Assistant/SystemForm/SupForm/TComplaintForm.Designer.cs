namespace SystemForm
{
    partial class TComplaintForm
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
            ComplaintIndex = new Sunny.UI.UITextBox();
            ComplaintButton = new Sunny.UI.UIButton();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            ComplaintDataGridView = new Sunny.UI.UIDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Content = new DataGridViewTextBoxColumn();
            informer = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            uiGroupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ComplaintDataGridView).BeginInit();
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
            uiGroupBox1.TabIndex = 5;
            uiGroupBox1.Text = "举报信息查询";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(uiComboBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(ComplaintIndex, 1, 0);
            tableLayoutPanel1.Controls.Add(ComplaintButton, 2, 0);
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
            uiComboBox1.Items.AddRange(new object[] { "全部投诉", "按ID查询", "按举报人查询", "按状态查询" });
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
            // ComplaintIndex
            // 
            ComplaintIndex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComplaintIndex.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComplaintIndex.Location = new Point(209, 7);
            ComplaintIndex.Margin = new Padding(4, 5, 4, 5);
            ComplaintIndex.MinimumSize = new Size(1, 16);
            ComplaintIndex.Name = "ComplaintIndex";
            ComplaintIndex.ShowText = false;
            ComplaintIndex.Size = new Size(197, 36);
            ComplaintIndex.TabIndex = 1;
            ComplaintIndex.TextAlignment = ContentAlignment.MiddleRight;
            ComplaintIndex.Watermark = "";
            // 
            // ComplaintButton
            // 
            ComplaintButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComplaintButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComplaintButton.Location = new Point(413, 5);
            ComplaintButton.MinimumSize = new Size(1, 1);
            ComplaintButton.Name = "ComplaintButton";
            ComplaintButton.Size = new Size(97, 41);
            ComplaintButton.TabIndex = 2;
            ComplaintButton.Text = "查询";
            ComplaintButton.Click += ComplaintButton_Click;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(ComplaintDataGridView);
            uiGroupBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.Location = new Point(72, 173);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(849, 291);
            uiGroupBox2.TabIndex = 6;
            uiGroupBox2.Text = "举报信息";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ComplaintDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            ComplaintDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ComplaintDataGridView.BackgroundColor = Color.FromArgb(243, 249, 255);
            ComplaintDataGridView.BorderStyle = BorderStyle.None;
            ComplaintDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ComplaintDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ComplaintDataGridView.ColumnHeadersHeight = 32;
            ComplaintDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ComplaintDataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, Content, informer, Time, status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ComplaintDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            ComplaintDataGridView.EnableHeadersVisualStyles = false;
            ComplaintDataGridView.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComplaintDataGridView.GridColor = Color.FromArgb(104, 173, 255);
            ComplaintDataGridView.Location = new Point(27, 44);
            ComplaintDataGridView.Name = "ComplaintDataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ComplaintDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ComplaintDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            ComplaintDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            ComplaintDataGridView.RowTemplate.Height = 29;
            ComplaintDataGridView.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            ComplaintDataGridView.SelectedIndex = -1;
            ComplaintDataGridView.Size = new Size(805, 229);
            ComplaintDataGridView.TabIndex = 1;
            ComplaintDataGridView.CellContentClick += ComplaintDataGridView_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ComplaintID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // Content
            // 
            Content.DataPropertyName = "Content";
            Content.HeaderText = "举报内容";
            Content.MinimumWidth = 6;
            Content.Name = "Content";
            Content.Width = 175;
            // 
            // informer
            // 
            informer.DataPropertyName = "informer";
            informer.HeaderText = "举报人";
            informer.MinimumWidth = 6;
            informer.Name = "informer";
            informer.Width = 125;
            // 
            // Time
            // 
            Time.DataPropertyName = "ComplaintTime";
            Time.HeaderText = "举报时间";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 200;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "状态";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 75;
            // 
            // TComplaintForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiGroupBox1);
            Name = "TComplaintForm";
            PageIndex = 1006;
            Text = "Message";
            uiGroupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ComplaintDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITextBox ComplaintIndex;
        private Sunny.UI.UIButton ComplaintButton;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        public Sunny.UI.UIDataGridView ComplaintDataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn informer;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn status;
    }
}