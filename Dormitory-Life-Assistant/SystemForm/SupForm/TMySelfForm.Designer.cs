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
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
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
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiDataGridView2 = new Sunny.UI.UIDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            SupervisorName = new DataGridViewTextBoxColumn();
            dormMessageBindingSource = new BindingSource(components);
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            contentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            administratorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            systemMessageBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            myself.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dormMessageBindingSource).BeginInit();
            uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)systemMessageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            TDorID.Click += TDorID_Click;
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
            uiLabel3.Click += uiLabel3_Click;
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
            TName.Click += TName_Click;
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
            TID.Click += TID_Click;
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
            TSex.Click += TSex_Click;
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
            TNumber.Click += TNumber_Click;
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
            // uiDataGridView2
            // 
            dataGridViewCellStyle41.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            uiDataGridView2.AutoGenerateColumns = false;
            uiDataGridView2.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle42.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle42.ForeColor = Color.White;
            dataGridViewCellStyle42.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle42.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
            uiDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            uiDataGridView2.ColumnHeadersHeight = 32;
            uiDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView2.ColumnHeadersVisible = false;
            uiDataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, SupervisorName });
            uiDataGridView2.DataSource = dormMessageBindingSource;
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = Color.White;
            dataGridViewCellStyle43.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle43.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle43.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle43.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle43.WrapMode = DataGridViewTriState.False;
            uiDataGridView2.DefaultCellStyle = dataGridViewCellStyle43;
            uiDataGridView2.Dock = DockStyle.Fill;
            uiDataGridView2.EnableHeadersVisualStyles = false;
            uiDataGridView2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView2.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView2.Location = new Point(0, 32);
            uiDataGridView2.Name = "uiDataGridView2";
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle44.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle44.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle44.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle44.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle44.WrapMode = DataGridViewTriState.True;
            uiDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            uiDataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle45.BackColor = Color.White;
            dataGridViewCellStyle45.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle45.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle45.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle45.SelectionForeColor = Color.FromArgb(48, 48, 48);
            uiDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle45;
            uiDataGridView2.RowTemplate.Height = 29;
            uiDataGridView2.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            uiDataGridView2.SelectedIndex = -1;
            uiDataGridView2.Size = new Size(580, 98);
            uiDataGridView2.TabIndex = 2;
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
            // dormMessageBindingSource
            // 
            dormMessageBindingSource.DataSource = typeof(Dormitory_Life_Assistant.DormMessage);
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
            dataGridViewCellStyle46.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            uiDataGridView1.AutoGenerateColumns = false;
            uiDataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle47.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle47.ForeColor = Color.White;
            dataGridViewCellStyle47.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle47.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.ColumnHeadersVisible = false;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { contentDataGridViewTextBoxColumn, administratorNameDataGridViewTextBoxColumn });
            uiDataGridView1.DataSource = systemMessageBindingSource;
            dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = Color.White;
            dataGridViewCellStyle48.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle48.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle48.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle48.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle48.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle48;
            uiDataGridView1.Dock = DockStyle.Fill;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView1.Location = new Point(0, 32);
            uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle49.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle49.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle49.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle49.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle49.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle49;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle50.BackColor = Color.White;
            dataGridViewCellStyle50.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle50.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle50.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle50.SelectionForeColor = Color.FromArgb(48, 48, 48);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle50;
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(480, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TMySelfForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(947, 490);
            Controls.Add(pictureBox1);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiGroupBox1);
            Controls.Add(uiCalendar1);
            Controls.Add(myself);
            Name = "TMySelfForm";
            PageIndex = 1006;
            Text = "Message";
            myself.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dormMessageBindingSource).EndInit();
            uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)systemMessageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}