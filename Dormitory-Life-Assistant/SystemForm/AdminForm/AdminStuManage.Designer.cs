namespace SystemForm
{
    partial class AdminStuManage
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
            uiPanel1 = new Sunny.UI.UIPanel();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            studentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gradeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            buildingNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dormNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            uiButton4 = new Sunny.UI.UIButton();
            queryText = new Sunny.UI.UITextBox();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            addButton = new Sunny.UI.UIButton();
            modifyButton = new Sunny.UI.UIButton();
            deleteButton = new Sunny.UI.UIButton();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            uiTableLayoutPanel2.SuspendLayout();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiDataGridView1);
            uiPanel1.Controls.Add(uiTableLayoutPanel2);
            uiPanel1.Controls.Add(uiTableLayoutPanel1);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(975, 490);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiDataGridView1.AutoGenerateColumns = false;
            uiDataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentIdDataGridViewTextBoxColumn, StudentName, genderDataGridViewTextBoxColumn, gradeDataGridViewTextBoxColumn, departmentDataGridViewTextBoxColumn, Class, buildingNameDataGridViewTextBoxColumn, dormNumberDataGridViewTextBoxColumn });
            uiDataGridView1.DataSource = studentBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView1.Location = new Point(0, 98);
            uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.RowTemplate.Height = 29;
            uiDataGridView1.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(975, 392);
            uiDataGridView1.TabIndex = 4;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            studentIdDataGridViewTextBoxColumn.HeaderText = "学号";
            studentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            studentIdDataGridViewTextBoxColumn.Width = 175;
            // 
            // StudentName
            // 
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "姓名";
            StudentName.MinimumWidth = 8;
            StudentName.Name = "StudentName";
            StudentName.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "性别";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            gradeDataGridViewTextBoxColumn.HeaderText = "年级";
            gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            gradeDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            departmentDataGridViewTextBoxColumn.HeaderText = "专业";
            departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // Class
            // 
            Class.DataPropertyName = "Class";
            Class.HeaderText = "班级";
            Class.MinimumWidth = 6;
            Class.Name = "Class";
            Class.Width = 125;
            // 
            // buildingNameDataGridViewTextBoxColumn
            // 
            buildingNameDataGridViewTextBoxColumn.DataPropertyName = "BuildingName";
            buildingNameDataGridViewTextBoxColumn.HeaderText = "所在楼栋";
            buildingNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            buildingNameDataGridViewTextBoxColumn.Name = "buildingNameDataGridViewTextBoxColumn";
            buildingNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // dormNumberDataGridViewTextBoxColumn
            // 
            dormNumberDataGridViewTextBoxColumn.DataPropertyName = "DormNumber";
            dormNumberDataGridViewTextBoxColumn.HeaderText = "宿舍号";
            dormNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            dormNumberDataGridViewTextBoxColumn.Name = "dormNumberDataGridViewTextBoxColumn";
            dormNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Dormitory_Life_Assistant.Student);
            // 
            // uiTableLayoutPanel2
            // 
            uiTableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            uiTableLayoutPanel2.ColumnCount = 4;
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.304348F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.695652F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 471F));
            uiTableLayoutPanel2.Controls.Add(uiButton4, 2, 0);
            uiTableLayoutPanel2.Controls.Add(queryText, 1, 0);
            uiTableLayoutPanel2.Controls.Add(uiComboBox1, 0, 0);
            uiTableLayoutPanel2.Dock = DockStyle.Top;
            uiTableLayoutPanel2.Location = new Point(0, 0);
            uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            uiTableLayoutPanel2.RowCount = 1;
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel2.Size = new Size(975, 43);
            uiTableLayoutPanel2.TabIndex = 3;
            uiTableLayoutPanel2.TagString = null;
            // 
            // uiButton4
            // 
            uiButton4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton4.Location = new Point(392, 4);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.Radius = 1;
            uiButton4.Size = new Size(105, 34);
            uiButton4.TabIndex = 0;
            uiButton4.Text = "查询";
            uiButton4.Click += uiButton4_Click;
            // 
            // queryText
            // 
            queryText.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            queryText.Location = new Point(165, 6);
            queryText.Margin = new Padding(4, 5, 4, 5);
            queryText.MinimumSize = new Size(1, 16);
            queryText.Name = "queryText";
            queryText.Padding = new Padding(5);
            queryText.ShowText = false;
            queryText.Size = new Size(219, 31);
            queryText.TabIndex = 1;
            queryText.TextAlignment = ContentAlignment.MiddleLeft;
            queryText.Watermark = "";
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiComboBox1.Items.AddRange(new object[] { "学号", "姓名", "专业", "班级" });
            uiComboBox1.Location = new Point(5, 6);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Radius = 1;
            uiComboBox1.Size = new Size(142, 31);
            uiComboBox1.TabIndex = 2;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "";
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            uiTableLayoutPanel1.ColumnCount = 4;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 590F));
            uiTableLayoutPanel1.Controls.Add(addButton, 0, 0);
            uiTableLayoutPanel1.Controls.Add(modifyButton, 1, 0);
            uiTableLayoutPanel1.Controls.Add(deleteButton, 2, 0);
            uiTableLayoutPanel1.Location = new Point(0, 44);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Size = new Size(987, 52);
            uiTableLayoutPanel1.TabIndex = 2;
            uiTableLayoutPanel1.TagString = null;
            // 
            // addButton
            // 
            addButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(4, 4);
            addButton.MinimumSize = new Size(1, 1);
            addButton.Name = "addButton";
            addButton.Size = new Size(119, 44);
            addButton.TabIndex = 0;
            addButton.Text = "添加学生";
            addButton.Click += addButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modifyButton.Location = new Point(136, 4);
            modifyButton.MinimumSize = new Size(1, 1);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(119, 44);
            modifyButton.TabIndex = 1;
            modifyButton.Text = "修改学生";
            modifyButton.Click += modifyButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(268, 4);
            deleteButton.MinimumSize = new Size(1, 1);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 44);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "删除学生";
            deleteButton.Click += deleteButton_Click_1;
            // 
            // AdminStuManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiPanel1);
            Name = "AdminStuManage";
            PageIndex = 2002;
            Text = "AdminStuManage";
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            uiTableLayoutPanel2.ResumeLayout(false);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UITextBox queryText;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIButton modifyButton;
        private Sunny.UI.UIButton deleteButton;
        private Sunny.UI.UIButton addButton;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn buildingNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dormNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn StudentName;
    }
}