namespace SystemForm
{
    partial class TMySelfForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            myself = new Sunny.UI.UIGroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            uiLabel6 = new Sunny.UI.UILabel();
            TDorID = new Sunny.UI.UILabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            TName = new Sunny.UI.UILabel();
            TID = new Sunny.UI.UILabel();
            TSex = new Sunny.UI.UILabel();
            TNumber = new Sunny.UI.UILabel();
            uiCalendar1 = new Sunny.UI.UICalendar();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            contentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            administratorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            systemMessageBindingSource = new BindingSource(components);
            uiDataGridView2 = new Sunny.UI.UIDataGridView();
            dormMessageBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            SupervisorName = new DataGridViewTextBoxColumn();
            myself.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)systemMessageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dormMessageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // myself
            // 
            myself.Controls.Add(tableLayoutPanel2);
            myself.Controls.Add(tableLayoutPanel1);
            myself.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            myself.Location = new Point(25, 28);
            myself.Margin = new Padding(4, 5, 4, 5);
            myself.MinimumSize = new Size(1, 1);
            myself.Name = "myself";
            myself.Padding = new Padding(0, 32, 0, 0);
            myself.Size = new Size(437, 155);
            myself.TabIndex = 1;
            myself.Text = "个人信息";
            myself.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(uiLabel6, 0, 0);
            tableLayoutPanel2.Controls.Add(TDorID, 1, 0);
            tableLayoutPanel2.Location = new Point(26, 109);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(397, 41);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // uiLabel6
            // 
            uiLabel6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel6.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel6.Location = new Point(3, 6);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(152, 29);
            uiLabel6.TabIndex = 0;
            uiLabel6.Text = "管理楼栋号：";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TDorID
            // 
            TDorID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TDorID.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TDorID.Location = new Point(161, 6);
            TDorID.Name = "TDorID";
            TDorID.Size = new Size(233, 29);
            TDorID.TabIndex = 1;
            TDorID.Text = "国软C3、C4";
            TDorID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(uiLabel3, 2, 0);
            tableLayoutPanel1.Controls.Add(uiLabel4, 0, 1);
            tableLayoutPanel1.Controls.Add(uiLabel2, 0, 0);
            tableLayoutPanel1.Controls.Add(uiLabel5, 2, 1);
            tableLayoutPanel1.Controls.Add(TName, 1, 0);
            tableLayoutPanel1.Controls.Add(TID, 3, 0);
            tableLayoutPanel1.Controls.Add(TSex, 1, 1);
            tableLayoutPanel1.Controls.Add(TNumber, 3, 1);
            tableLayoutPanel1.Location = new Point(26, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(397, 76);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // uiLabel3
            // 
            uiLabel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel3.Location = new Point(161, 4);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(73, 29);
            uiLabel3.TabIndex = 1;
            uiLabel3.Text = "工号：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.Location = new Point(3, 42);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(73, 29);
            uiLabel4.TabIndex = 2;
            uiLabel4.Text = "性别：";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(3, 4);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(73, 29);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "姓名：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.Location = new Point(161, 42);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(73, 29);
            uiLabel5.TabIndex = 4;
            uiLabel5.Text = "电话：";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TName
            // 
            TName.Anchor = AnchorStyles.None;
            TName.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TName.Location = new Point(82, 4);
            TName.Name = "TName";
            TName.Size = new Size(73, 29);
            TName.TabIndex = 5;
            TName.Text = "张三";
            TName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TID
            // 
            TID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TID.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TID.Location = new Point(240, 4);
            TID.Name = "TID";
            TID.Size = new Size(154, 29);
            TID.TabIndex = 6;
            TID.Text = "20210921";
            TID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TSex
            // 
            TSex.Anchor = AnchorStyles.None;
            TSex.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSex.Location = new Point(82, 42);
            TSex.Name = "TSex";
            TSex.Size = new Size(73, 29);
            TSex.TabIndex = 7;
            TSex.Text = "男";
            TSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TNumber
            // 
            TNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TNumber.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TNumber.Location = new Point(240, 42);
            TNumber.Name = "TNumber";
            TNumber.Size = new Size(154, 29);
            TNumber.TabIndex = 8;
            TNumber.Text = "12345678901";
            TNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiCalendar1
            // 
            uiCalendar1.Date = new DateTime(2023, 5, 17, 0, 0, 0, 0);
            uiCalendar1.FillColor = Color.White;
            uiCalendar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiCalendar1.Location = new Point(636, 28);
            uiCalendar1.MinimumSize = new Size(240, 180);
            uiCalendar1.Name = "uiCalendar1";
            uiCalendar1.PrimaryColor = Color.FromArgb(80, 160, 255);
            uiCalendar1.Size = new Size(299, 268);
            uiCalendar1.TabIndex = 2;
            uiCalendar1.Text = "uiCalendar1";
            uiCalendar1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiAvatar1
            // 
            uiAvatar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar1.Location = new Point(469, 28);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(147, 155);
            uiAvatar1.TabIndex = 3;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(uiDataGridView2);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(25, 193);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(580, 130);
            uiGroupBox1.TabIndex = 4;
            uiGroupBox1.Text = "宿舍通知";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(uiDataGridView1);
            uiGroupBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.Location = new Point(25, 337);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(580, 130);
            uiGroupBox2.TabIndex = 5;
            uiGroupBox2.Text = "系统消息";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView1.AutoGenerateColumns = false;
            uiDataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.ColumnHeadersVisible = false;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { contentDataGridViewTextBoxColumn, administratorNameDataGridViewTextBoxColumn });
            uiDataGridView1.DataSource = systemMessageBindingSource;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.Dock = DockStyle.Fill;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView1.Location = new Point(0, 32);
            uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(48, 48, 48);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView1.RowTemplate.Height = 29;
            uiDataGridView1.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(580, 98);
            uiDataGridView1.TabIndex = 1;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            contentDataGridViewTextBoxColumn.HeaderText = "Content";
            contentDataGridViewTextBoxColumn.MinimumWidth = 6;
            contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            contentDataGridViewTextBoxColumn.Width = 400;
            // 
            // administratorNameDataGridViewTextBoxColumn
            // 
            administratorNameDataGridViewTextBoxColumn.DataPropertyName = "AdministratorName";
            administratorNameDataGridViewTextBoxColumn.HeaderText = "AdministratorName";
            administratorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            administratorNameDataGridViewTextBoxColumn.Name = "administratorNameDataGridViewTextBoxColumn";
            administratorNameDataGridViewTextBoxColumn.ReadOnly = true;
            administratorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // systemMessageBindingSource
            // 
            systemMessageBindingSource.DataSource = typeof(Dormitory_Life_Assistant.SystemMessage);
            // 
            // uiDataGridView2
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView2.AutoGenerateColumns = false;
            uiDataGridView2.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView2.ColumnHeadersHeight = 32;
            uiDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView2.ColumnHeadersVisible = false;
            uiDataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, SupervisorName });
            uiDataGridView2.DataSource = dormMessageBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView2.Dock = DockStyle.Fill;
            uiDataGridView2.EnableHeadersVisualStyles = false;
            uiDataGridView2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView2.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView2.Location = new Point(0, 32);
            uiDataGridView2.Name = "uiDataGridView2";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            uiDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView2.RowTemplate.Height = 29;
            uiDataGridView2.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            uiDataGridView2.SelectedIndex = -1;
            uiDataGridView2.Size = new Size(580, 98);
            uiDataGridView2.TabIndex = 2;
            // 
            // dormMessageBindingSource
            // 
            dormMessageBindingSource.DataSource = typeof(Dormitory_Life_Assistant.DormMessage);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Content";
            dataGridViewTextBoxColumn1.HeaderText = "Content";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 400;
            // 
            // SupervisorName
            // 
            SupervisorName.DataPropertyName = "SupervisorName";
            SupervisorName.HeaderText = "SupervisorName";
            SupervisorName.MinimumWidth = 6;
            SupervisorName.Name = "SupervisorName";
            SupervisorName.ReadOnly = true;
            SupervisorName.Width = 125;
            // 
            // TMySelfForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(947, 490);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiGroupBox1);
            Controls.Add(uiAvatar1);
            Controls.Add(uiCalendar1);
            Controls.Add(myself);
            Name = "TMySelfForm";
            PageIndex = 1006;
            Text = "Message";
            myself.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)systemMessageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dormMessageBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIGroupBox myself;
        private TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel TDorID;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel TName;
        private Sunny.UI.UILabel TID;
        private Sunny.UI.UILabel TSex;
        private Sunny.UI.UILabel TNumber;
        private Sunny.UI.UICalendar uiCalendar1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn administratorNameDataGridViewTextBoxColumn;
        private BindingSource systemMessageBindingSource;
        private Sunny.UI.UIDataGridView uiDataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn SupervisorName;
        private BindingSource dormMessageBindingSource;
    }
}