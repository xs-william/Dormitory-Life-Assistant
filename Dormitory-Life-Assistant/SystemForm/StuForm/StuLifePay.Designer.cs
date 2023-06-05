namespace SystemForm
{
    partial class StuLifePay
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
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            payTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Confirm = new DataGridViewButtonColumn();
            paymentBindingSource = new BindingSource(components);
            uiButton1 = new Sunny.UI.UIButton();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiButton1);
            uiPanel1.Controls.Add(uiDataGridView1);
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
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { typeDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, payTimeDataGridViewTextBoxColumn, Status, Confirm });
            uiDataGridView1.DataSource = paymentBindingSource;
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
            uiDataGridView1.Location = new Point(0, 0);
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
            uiDataGridView1.Size = new Size(975, 490);
            uiDataGridView1.TabIndex = 3;
            uiDataGridView1.CellContentClick += uiDataGridView1_CellContentClick;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "缴费项目";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "需缴金额";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // payTimeDataGridViewTextBoxColumn
            // 
            payTimeDataGridViewTextBoxColumn.DataPropertyName = "PayTime";
            payTimeDataGridViewTextBoxColumn.HeaderText = "通知时间";
            payTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            payTimeDataGridViewTextBoxColumn.Name = "payTimeDataGridViewTextBoxColumn";
            payTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "状态";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
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
            // paymentBindingSource
            // 
            paymentBindingSource.DataSource = typeof(Dormitory_Life_Assistant.Payment);
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(891, 449);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(84, 41);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "刷新";
            uiButton1.Click += uiButton1_Click_1;
            // 
            // StuLifePay
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiPanel1);
            Name = "StuLifePay";
            PageIndex = 1002;
            Text = "LifePay";
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private BindingSource paymentBindingSource;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn payTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Confirm;
        private Sunny.UI.UIButton uiButton1;
    }
}