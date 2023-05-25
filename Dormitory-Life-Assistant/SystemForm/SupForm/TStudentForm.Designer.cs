namespace SystemForm
{
    partial class TStudentForm
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
            StudentIndex = new Sunny.UI.UITextBox();
            StudentButton = new Sunny.UI.UIButton();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            StudentDataGridView = new Sunny.UI.UIDataGridView();
            DormNum = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            uiButton1 = new Sunny.UI.UIButton();
            uiGroupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentDataGridView).BeginInit();
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
            uiGroupBox1.Text = "学生信息查询";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(uiComboBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(StudentIndex, 1, 0);
            tableLayoutPanel1.Controls.Add(StudentButton, 2, 0);
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
            uiComboBox1.Items.AddRange(new object[] { "按宿舍号查询", "按年级查询", "按学号查询", "按姓名查询" });
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
            // StudentIndex
            // 
            StudentIndex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StudentIndex.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentIndex.Location = new Point(209, 7);
            StudentIndex.Margin = new Padding(4, 5, 4, 5);
            StudentIndex.MinimumSize = new Size(1, 16);
            StudentIndex.Name = "StudentIndex";
            StudentIndex.ShowText = false;
            StudentIndex.Size = new Size(197, 36);
            StudentIndex.TabIndex = 1;
            StudentIndex.TextAlignment = ContentAlignment.MiddleLeft;
            StudentIndex.Watermark = "";
            // 
            // StudentButton
            // 
            StudentButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StudentButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentButton.Location = new Point(413, 5);
            StudentButton.MinimumSize = new Size(1, 1);
            StudentButton.Name = "StudentButton";
            StudentButton.Size = new Size(97, 41);
            StudentButton.TabIndex = 2;
            StudentButton.Text = "查询";
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(uiButton1);
            uiGroupBox2.Controls.Add(StudentDataGridView);
            uiGroupBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.Location = new Point(170, 170);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(610, 291);
            uiGroupBox2.TabIndex = 7;
            uiGroupBox2.Text = "学生信息";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // StudentDataGridView
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 249, 255);
            StudentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            StudentDataGridView.BackgroundColor = Color.FromArgb(243, 249, 255);
            StudentDataGridView.BorderStyle = BorderStyle.None;
            StudentDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            StudentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            StudentDataGridView.ColumnHeadersHeight = 32;
            StudentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            StudentDataGridView.Columns.AddRange(new DataGridViewColumn[] { DormNum, Grade, Id, NAME });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            StudentDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            StudentDataGridView.EnableHeadersVisualStyles = false;
            StudentDataGridView.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentDataGridView.GridColor = Color.FromArgb(104, 173, 255);
            StudentDataGridView.Location = new Point(27, 44);
            StudentDataGridView.Name = "StudentDataGridView";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            StudentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            StudentDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(48, 48, 48);
            StudentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            StudentDataGridView.RowTemplate.Height = 29;
            StudentDataGridView.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            StudentDataGridView.SelectedIndex = -1;
            StudentDataGridView.Size = new Size(559, 188);
            StudentDataGridView.TabIndex = 0;
            // 
            // DormNum
            // 
            DormNum.HeaderText = "宿舍号";
            DormNum.MinimumWidth = 6;
            DormNum.Name = "DormNum";
            DormNum.Width = 125;
            // 
            // Grade
            // 
            Grade.HeaderText = "年级";
            Grade.MinimumWidth = 6;
            Grade.Name = "Grade";
            Grade.Width = 125;
            // 
            // Id
            // 
            Id.HeaderText = "学号";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // NAME
            // 
            NAME.HeaderText = "姓名";
            NAME.MinimumWidth = 6;
            NAME.Name = "NAME";
            NAME.Width = 125;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(240, 230);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(175, 50);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "查看学生信息";
            uiButton1.Click += uiButton1_Click;
            // 
            // TStudentForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiGroupBox1);
            Name = "TStudentForm";
            PageIndex = 1006;
            Text = "Message";
            uiGroupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITextBox StudentIndex;
        private Sunny.UI.UIButton StudentButton;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIDataGridView StudentDataGridView;
        private DataGridViewTextBoxColumn DormNum;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NAME;
        private Sunny.UI.UIButton uiButton1;
    }
}