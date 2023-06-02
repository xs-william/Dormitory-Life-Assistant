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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            NoticeTime = new DataGridViewTextBoxColumn();
            PayType = new DataGridViewTextBoxColumn();
            Money = new DataGridViewTextBoxColumn();
            SubmitTime = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Confirm = new DataGridViewButtonColumn();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { NoticeTime, PayType, Money, SubmitTime, Status, Confirm });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.Dock = DockStyle.Fill;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView1.Location = new Point(0, 0);
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
            uiDataGridView1.Size = new Size(975, 490);
            uiDataGridView1.TabIndex = 3;
            // 
            // NoticeTime
            // 
            NoticeTime.HeaderText = "通知时间";
            NoticeTime.MinimumWidth = 6;
            NoticeTime.Name = "NoticeTime";
            NoticeTime.ReadOnly = true;
            NoticeTime.Width = 200;
            // 
            // PayType
            // 
            PayType.HeaderText = "缴费项目";
            PayType.MinimumWidth = 10;
            PayType.Name = "PayType";
            PayType.ReadOnly = true;
            PayType.Width = 125;
            // 
            // Money
            // 
            Money.HeaderText = "需缴金额";
            Money.MinimumWidth = 6;
            Money.Name = "Money";
            Money.ReadOnly = true;
            Money.Width = 150;
            // 
            // SubmitTime
            // 
            SubmitTime.HeaderText = "提交时间";
            SubmitTime.MinimumWidth = 6;
            SubmitTime.Name = "SubmitTime";
            SubmitTime.ReadOnly = true;
            SubmitTime.Width = 200;
            // 
            // Status
            // 
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
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private DataGridViewTextBoxColumn NoticeTime;
        private DataGridViewTextBoxColumn PayType;
        private DataGridViewTextBoxColumn Money;
        private DataGridViewTextBoxColumn SubmitTime;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Confirm;
    }
}