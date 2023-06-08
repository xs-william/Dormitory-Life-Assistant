namespace SystemForm
{
    partial class AdminSuperManage
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
            uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            uiButton4 = new Sunny.UI.UIButton();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton3 = new Sunny.UI.UIButton();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            supervisorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supervisorBindingSource = new BindingSource(components);
            uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            supQueryBotton = new Sunny.UI.UIButton();
            supQueryBox = new Sunny.UI.UITextBox();
            uiComboBox2 = new Sunny.UI.UIComboBox();
            uiTableLayoutPanel4 = new Sunny.UI.UITableLayoutPanel();
            modifySupButton = new Sunny.UI.UIButton();
            supDeleteButton = new Sunny.UI.UIButton();
            addSupButton = new Sunny.UI.UIButton();
            supervisorBindingSource3 = new BindingSource(components);
            supervisorBindingSource1 = new BindingSource(components);
            supervisorBindingSource2 = new BindingSource(components);
            uiTableLayoutPanel2.SuspendLayout();
            uiTableLayoutPanel1.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supervisorBindingSource).BeginInit();
            uiTableLayoutPanel3.SuspendLayout();
            uiTableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supervisorBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supervisorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supervisorBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // uiTableLayoutPanel2
            // 
            uiTableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            uiTableLayoutPanel2.ColumnCount = 4;
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.77551F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.22449F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 471F));
            uiTableLayoutPanel2.Controls.Add(uiButton4, 2, 0);
            uiTableLayoutPanel2.Controls.Add(uiTextBox1, 1, 0);
            uiTableLayoutPanel2.Controls.Add(uiComboBox1, 0, 0);
            uiTableLayoutPanel2.Dock = DockStyle.Top;
            uiTableLayoutPanel2.Location = new Point(0, 0);
            uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            uiTableLayoutPanel2.RowCount = 1;
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel2.Size = new Size(975, 44);
            uiTableLayoutPanel2.TabIndex = 5;
            uiTableLayoutPanel2.TagString = null;
            // 
            // uiButton4
            // 
            uiButton4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton4.Location = new Point(393, 4);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.Size = new Size(105, 36);
            uiButton4.TabIndex = 0;
            uiButton4.Text = "查询";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(156, 6);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(229, 32);
            uiTextBox1.TabIndex = 1;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
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
            uiComboBox1.Size = new Size(142, 32);
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
            uiTableLayoutPanel1.Controls.Add(uiButton2, 1, 0);
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.Size = new Size(200, 100);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(-257, 4);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(1, 44);
            uiButton2.TabIndex = 1;
            uiButton2.Text = "修改学生";
            // 
            // uiButton3
            // 
            uiButton3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton3.Location = new Point(-518, 4);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(123, 44);
            uiButton3.TabIndex = 2;
            uiButton3.Text = "删除学生";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiDataGridView1);
            uiPanel1.Controls.Add(uiTableLayoutPanel3);
            uiPanel1.Controls.Add(uiTableLayoutPanel4);
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
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { supervisorNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, teleDataGridViewTextBoxColumn });
            uiDataGridView1.DataSource = supervisorBindingSource;
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
            uiDataGridView1.Location = new Point(0, 100);
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
            uiDataGridView1.Size = new Size(975, 387);
            uiDataGridView1.TabIndex = 6;
            // 
            // supervisorNameDataGridViewTextBoxColumn
            // 
            supervisorNameDataGridViewTextBoxColumn.DataPropertyName = "SupervisorName";
            supervisorNameDataGridViewTextBoxColumn.HeaderText = "工号";
            supervisorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            supervisorNameDataGridViewTextBoxColumn.Name = "supervisorNameDataGridViewTextBoxColumn";
            supervisorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "性别";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // teleDataGridViewTextBoxColumn
            // 
            teleDataGridViewTextBoxColumn.DataPropertyName = "Tele";
            teleDataGridViewTextBoxColumn.HeaderText = "电话";
            teleDataGridViewTextBoxColumn.MinimumWidth = 6;
            teleDataGridViewTextBoxColumn.Name = "teleDataGridViewTextBoxColumn";
            teleDataGridViewTextBoxColumn.Width = 200;
            // 
            // supervisorBindingSource
            // 
            supervisorBindingSource.DataSource = typeof(Dormitory_Life_Assistant.Supervisor);
            // 
            // uiTableLayoutPanel3
            // 
            uiTableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            uiTableLayoutPanel3.ColumnCount = 4;
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.77551F));
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.22449F));
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 471F));
            uiTableLayoutPanel3.Controls.Add(supQueryBotton, 2, 0);
            uiTableLayoutPanel3.Controls.Add(supQueryBox, 1, 0);
            uiTableLayoutPanel3.Controls.Add(uiComboBox2, 0, 0);
            uiTableLayoutPanel3.Dock = DockStyle.Top;
            uiTableLayoutPanel3.Location = new Point(0, 0);
            uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            uiTableLayoutPanel3.RowCount = 1;
            uiTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel3.Size = new Size(975, 44);
            uiTableLayoutPanel3.TabIndex = 5;
            uiTableLayoutPanel3.TagString = null;
            // 
            // supQueryBotton
            // 
            supQueryBotton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            supQueryBotton.Location = new Point(393, 4);
            supQueryBotton.MinimumSize = new Size(1, 1);
            supQueryBotton.Name = "supQueryBotton";
            supQueryBotton.Size = new Size(105, 36);
            supQueryBotton.TabIndex = 0;
            supQueryBotton.Text = "查询";
            supQueryBotton.Click += supQueryBotton_Click;
            // 
            // supQueryBox
            // 
            supQueryBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            supQueryBox.Location = new Point(156, 6);
            supQueryBox.Margin = new Padding(4, 5, 4, 5);
            supQueryBox.MinimumSize = new Size(1, 16);
            supQueryBox.Name = "supQueryBox";
            supQueryBox.Padding = new Padding(5);
            supQueryBox.ShowText = false;
            supQueryBox.Size = new Size(229, 32);
            supQueryBox.TabIndex = 1;
            supQueryBox.TextAlignment = ContentAlignment.MiddleLeft;
            supQueryBox.Watermark = "";
            // 
            // uiComboBox2
            // 
            uiComboBox2.DataSource = null;
            uiComboBox2.FillColor = Color.White;
            uiComboBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiComboBox2.Items.AddRange(new object[] { "工号", "姓名", "宿舍名" });
            uiComboBox2.Location = new Point(5, 6);
            uiComboBox2.Margin = new Padding(4, 5, 4, 5);
            uiComboBox2.MinimumSize = new Size(63, 0);
            uiComboBox2.Name = "uiComboBox2";
            uiComboBox2.Padding = new Padding(0, 0, 30, 2);
            uiComboBox2.Size = new Size(142, 32);
            uiComboBox2.TabIndex = 2;
            uiComboBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox2.Watermark = "";
            // 
            // uiTableLayoutPanel4
            // 
            uiTableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            uiTableLayoutPanel4.ColumnCount = 4;
            uiTableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            uiTableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 590F));
            uiTableLayoutPanel4.Controls.Add(modifySupButton, 1, 0);
            uiTableLayoutPanel4.Controls.Add(supDeleteButton, 2, 0);
            uiTableLayoutPanel4.Controls.Add(addSupButton, 0, 0);
            uiTableLayoutPanel4.Location = new Point(0, 46);
            uiTableLayoutPanel4.Name = "uiTableLayoutPanel4";
            uiTableLayoutPanel4.RowCount = 1;
            uiTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel4.Size = new Size(980, 52);
            uiTableLayoutPanel4.TabIndex = 4;
            uiTableLayoutPanel4.TagString = null;
            // 
            // modifySupButton
            // 
            modifySupButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modifySupButton.Location = new Point(133, 4);
            modifySupButton.MinimumSize = new Size(1, 1);
            modifySupButton.Name = "modifySupButton";
            modifySupButton.Size = new Size(119, 44);
            modifySupButton.TabIndex = 1;
            modifySupButton.Text = "修改宿管";
            modifySupButton.Click += modifySupButton_Click;
            // 
            // supDeleteButton
            // 
            supDeleteButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            supDeleteButton.Location = new Point(262, 4);
            supDeleteButton.MinimumSize = new Size(1, 1);
            supDeleteButton.Name = "supDeleteButton";
            supDeleteButton.Size = new Size(123, 44);
            supDeleteButton.TabIndex = 2;
            supDeleteButton.Text = "删除宿管";
            supDeleteButton.Click += supDeleteButton_Click;
            // 
            // addSupButton
            // 
            addSupButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addSupButton.Location = new Point(4, 4);
            addSupButton.MinimumSize = new Size(1, 1);
            addSupButton.Name = "addSupButton";
            addSupButton.Size = new Size(119, 44);
            addSupButton.TabIndex = 0;
            addSupButton.Text = "添加宿管";
            addSupButton.Click += addSupButton_Click;
            // 
            // supervisorBindingSource3
            // 
            supervisorBindingSource3.DataSource = typeof(Dormitory_Life_Assistant.Supervisor);
            // 
            // supervisorBindingSource1
            // 
            supervisorBindingSource1.DataSource = typeof(Dormitory_Life_Assistant.Supervisor);
            // 
            // supervisorBindingSource2
            // 
            supervisorBindingSource2.DataSource = typeof(Dormitory_Life_Assistant.Supervisor);
            // 
            // AdminSuperManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiPanel1);
            Name = "AdminSuperManage";
            PageIndex = 2003;
            Text = "AdminSuperManage";
            uiTableLayoutPanel2.ResumeLayout(false);
            uiTableLayoutPanel1.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supervisorBindingSource).EndInit();
            uiTableLayoutPanel3.ResumeLayout(false);
            uiTableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)supervisorBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)supervisorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supervisorBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UIButton supQueryBotton;
        private Sunny.UI.UITextBox supQueryBox;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel4;
        private Sunny.UI.UIButton modifySupButton;
        private Sunny.UI.UIButton supDeleteButton;
        private Sunny.UI.UIButton addSupButton;
        private BindingSource supervisorBindingSource;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private BindingSource supervisorBindingSource1;
        private BindingSource supervisorBindingSource3;
        private BindingSource supervisorBindingSource2;
        private DataGridViewTextBoxColumn supervisorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supervisorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teleDataGridViewTextBoxColumn;
    }
}