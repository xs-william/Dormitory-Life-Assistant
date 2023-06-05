namespace SystemForm
{
    partial class AdminNotice
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
            uiPanel1 = new Sunny.UI.UIPanel();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            contentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            administratorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            systemMessageBindingSource = new BindingSource(components);
            uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            queryButton = new Sunny.UI.UIButton();
            queryText = new Sunny.UI.UITextBox();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            addButton = new Sunny.UI.UIButton();
            ModifyButton = new Sunny.UI.UIButton();
            deleteButton = new Sunny.UI.UIButton();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)systemMessageBindingSource).BeginInit();
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
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { contentDataGridViewTextBoxColumn, timeDataGridViewTextBoxColumn, administratorNameDataGridViewTextBoxColumn });
            uiDataGridView1.DataSource = systemMessageBindingSource;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView1.Location = new Point(0, 83);
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
            uiDataGridView1.Size = new Size(975, 395);
            uiDataGridView1.TabIndex = 6;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            contentDataGridViewTextBoxColumn.HeaderText = "内容";
            contentDataGridViewTextBoxColumn.MinimumWidth = 6;
            contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            contentDataGridViewTextBoxColumn.Width = 600;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "时间";
            timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.Width = 200;
            // 
            // administratorNameDataGridViewTextBoxColumn
            // 
            administratorNameDataGridViewTextBoxColumn.DataPropertyName = "AdministratorName";
            administratorNameDataGridViewTextBoxColumn.HeaderText = "推送人";
            administratorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            administratorNameDataGridViewTextBoxColumn.Name = "administratorNameDataGridViewTextBoxColumn";
            administratorNameDataGridViewTextBoxColumn.ReadOnly = true;
            administratorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // systemMessageBindingSource
            // 
            systemMessageBindingSource.DataSource = typeof(Dormitory_Life_Assistant.SystemMessage);
            // 
            // uiTableLayoutPanel2
            // 
            uiTableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            uiTableLayoutPanel2.ColumnCount = 4;
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.304348F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.695652F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 471F));
            uiTableLayoutPanel2.Controls.Add(queryButton, 2, 0);
            uiTableLayoutPanel2.Controls.Add(queryText, 1, 0);
            uiTableLayoutPanel2.Controls.Add(uiComboBox1, 0, 0);
            uiTableLayoutPanel2.Dock = DockStyle.Top;
            uiTableLayoutPanel2.Location = new Point(0, 0);
            uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            uiTableLayoutPanel2.RowCount = 1;
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel2.Size = new Size(975, 42);
            uiTableLayoutPanel2.TabIndex = 5;
            uiTableLayoutPanel2.TagString = null;
            // 
            // queryButton
            // 
            queryButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            queryButton.Location = new Point(392, 4);
            queryButton.MinimumSize = new Size(1, 1);
            queryButton.Name = "queryButton";
            queryButton.Radius = 1;
            queryButton.Size = new Size(105, 34);
            queryButton.TabIndex = 0;
            queryButton.Text = "查询";
            queryButton.Click += queryButton_Click;
            // 
            // queryText
            // 
            queryText.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            queryText.Location = new Point(165, 6);
            queryText.Margin = new Padding(4, 5, 4, 5);
            queryText.MinimumSize = new Size(1, 16);
            queryText.Name = "queryText";
            queryText.ShowText = false;
            queryText.Size = new Size(219, 30);
            queryText.TabIndex = 1;
            queryText.TextAlignment = ContentAlignment.MiddleLeft;
            queryText.Watermark = "";
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.Dock = DockStyle.Fill;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiComboBox1.Items.AddRange(new object[] { "", "日期", "内容" });
            uiComboBox1.Location = new Point(5, 6);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Radius = 1;
            uiComboBox1.Size = new Size(151, 30);
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
            uiTableLayoutPanel1.Controls.Add(ModifyButton, 1, 0);
            uiTableLayoutPanel1.Controls.Add(deleteButton, 2, 0);
            uiTableLayoutPanel1.Location = new Point(3, 44);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Size = new Size(987, 37);
            uiTableLayoutPanel1.TabIndex = 4;
            uiTableLayoutPanel1.TagString = null;
            // 
            // addButton
            // 
            addButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(4, 4);
            addButton.MinimumSize = new Size(1, 1);
            addButton.Name = "addButton";
            addButton.Size = new Size(119, 29);
            addButton.TabIndex = 0;
            addButton.Text = "添加公告";
            addButton.Click += addButton_Click;
            // 
            // ModifyButton
            // 
            ModifyButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyButton.Location = new Point(136, 4);
            ModifyButton.MinimumSize = new Size(1, 1);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(119, 29);
            ModifyButton.TabIndex = 1;
            ModifyButton.Text = "修改公告";
            ModifyButton.Click += ModifyButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(268, 4);
            deleteButton.MinimumSize = new Size(1, 1);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 29);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "删除公告";
            deleteButton.Click += deleteButton_Click;
            // 
            // AdminNotice
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiPanel1);
            Name = "AdminNotice";
            PageIndex = 2005;
            Text = "AdminNotice";
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)systemMessageBindingSource).EndInit();
            uiTableLayoutPanel2.ResumeLayout(false);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIButton queryButton;
        private Sunny.UI.UITextBox queryText;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIButton addButton;
        private Sunny.UI.UIButton ModifyButton;
        private Sunny.UI.UIButton deleteButton;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn administratorNameDataGridViewTextBoxColumn;
        private BindingSource systemMessageBindingSource;
    }
}