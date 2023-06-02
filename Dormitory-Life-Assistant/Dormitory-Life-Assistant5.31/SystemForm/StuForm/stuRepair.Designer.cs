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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            RepairContent = new DataGridViewTextBoxColumn();
            SubmitTime = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Confirm = new DataGridViewButtonColumn();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            uiButton1 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
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
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { RepairContent, SubmitTime, Status, Confirm });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.Dock = DockStyle.Bottom;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView1.Location = new Point(0, 41);
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
            uiDataGridView1.Size = new Size(975, 449);
            uiDataGridView1.TabIndex = 3;
            // 
            // RepairContent
            // 
            RepairContent.HeaderText = "报修内容";
            RepairContent.MinimumWidth = 10;
            RepairContent.Name = "RepairContent";
            RepairContent.ReadOnly = true;
            RepairContent.Width = 600;
            // 
            // SubmitTime
            // 
            SubmitTime.HeaderText = "提交时间";
            SubmitTime.MinimumWidth = 6;
            SubmitTime.Name = "SubmitTime";
            SubmitTime.ReadOnly = true;
            SubmitTime.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "状态";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 75;
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
            uiTableLayoutPanel1.Size = new Size(975, 41);
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
            // stuRepair
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiTableLayoutPanel1);
            Controls.Add(uiDataGridView1);
            Name = "stuRepair";
            PageIndex = 1003;
            Text = "Repair";
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView1;
        private DataGridViewTextBoxColumn RepairContent;
        private DataGridViewTextBoxColumn SubmitTime;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Confirm;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIButton uiButton1;
    }
}