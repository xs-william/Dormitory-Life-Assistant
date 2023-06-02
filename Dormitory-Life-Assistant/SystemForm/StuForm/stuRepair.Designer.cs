namespace SystemForm
{
    partial class stuRepair
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
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            contentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            repairTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewCheckBoxColumn = new DataGridViewTextBoxColumn();
            Confirm = new DataGridViewButtonColumn();
            repairBindingSource = new BindingSource(components);
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repairBindingSource).BeginInit();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { contentDataGridViewTextBoxColumn, repairTimeDataGridViewTextBoxColumn, statusDataGridViewCheckBoxColumn, Confirm });
            uiDataGridView1.DataSource = repairBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.Dock = DockStyle.Bottom;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView1.Location = new Point(0, 44);
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
            uiDataGridView1.Size = new Size(975, 446);
            uiDataGridView1.TabIndex = 3;
            uiDataGridView1.CellContentClick += uiDataGridView1_CellContentClick;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            contentDataGridViewTextBoxColumn.HeaderText = "报修内容";
            contentDataGridViewTextBoxColumn.MinimumWidth = 6;
            contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            contentDataGridViewTextBoxColumn.Width = 125;
            // 
            // repairTimeDataGridViewTextBoxColumn
            // 
            repairTimeDataGridViewTextBoxColumn.DataPropertyName = "RepairTime";
            repairTimeDataGridViewTextBoxColumn.HeaderText = "提交时间";
            repairTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            repairTimeDataGridViewTextBoxColumn.Name = "repairTimeDataGridViewTextBoxColumn";
            repairTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            statusDataGridViewCheckBoxColumn.HeaderText = "状态";
            statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            statusDataGridViewCheckBoxColumn.Resizable = DataGridViewTriState.True;
            statusDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            statusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Confirm
            // 
            Confirm.HeaderText = "确认完成";
            Confirm.MinimumWidth = 6;
            Confirm.Name = "Confirm";
            Confirm.Text = "完成";
            Confirm.UseColumnTextForButtonValue = true;
            Confirm.Width = 125;
            // 
            // repairBindingSource
            // 
            repairBindingSource.DataSource = typeof(Dormitory_Life_Assistant.Repair);
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 1;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Controls.Add(uiButton1, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Size = new Size(975, 44);
            uiTableLayoutPanel1.TabIndex = 4;
            uiTableLayoutPanel1.TagString = null;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(3, 3);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(159, 35);
            uiButton1.TabIndex = 0;
            uiButton1.Text = "提交报修";
            uiButton1.Click += uiButton1_Click;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(899, 451);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(76, 39);
            uiButton2.TabIndex = 5;
            uiButton2.Text = "刷新";
            uiButton2.Click += uiButton2_Click;
            // 
            // stuRepair
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiButton2);
            Controls.Add(uiTableLayoutPanel1);
            Controls.Add(uiDataGridView1);
            Name = "stuRepair";
            PageIndex = 1003;
            Text = "Repair";
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repairBindingSource).EndInit();
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIButton uiButton1;
        private BindingSource repairBindingSource;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn repairTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewCheckBoxColumn;
        private DataGridViewButtonColumn Confirm;
        private Sunny.UI.UIButton uiButton2;
    }
}