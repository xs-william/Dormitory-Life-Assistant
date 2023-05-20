namespace LifeHelper
{
    partial class AdminPunch
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
            uiPanel1 = new Sunny.UI.UIPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            uiButton1 = new Sunny.UI.UIButton();
            uiTextBox2 = new Sunny.UI.UITextBox();
            uiComboBox2 = new Sunny.UI.UIComboBox();
            uiButton2 = new Sunny.UI.UIButton();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiTableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiPanel2);
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
            // uiPanel2
            // 
            uiPanel2.Controls.Add(uiTableLayoutPanel3);
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel2.Location = new Point(0, 0);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(975, 490);
            uiPanel2.TabIndex = 0;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel3
            // 
            uiTableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            uiTableLayoutPanel3.ColumnCount = 5;
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.77551F));
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.22449F));
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            uiTableLayoutPanel3.Controls.Add(uiButton1, 2, 0);
            uiTableLayoutPanel3.Controls.Add(uiTextBox2, 1, 0);
            uiTableLayoutPanel3.Controls.Add(uiComboBox2, 0, 0);
            uiTableLayoutPanel3.Controls.Add(uiButton2, 3, 0);
            uiTableLayoutPanel3.Dock = DockStyle.Top;
            uiTableLayoutPanel3.Location = new Point(0, 0);
            uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            uiTableLayoutPanel3.RowCount = 1;
            uiTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel3.Size = new Size(975, 44);
            uiTableLayoutPanel3.TabIndex = 6;
            uiTableLayoutPanel3.TagString = null;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(372, 4);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(105, 36);
            uiButton1.TabIndex = 0;
            uiButton1.Text = "查询";
            // 
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox2.Location = new Point(148, 6);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(216, 32);
            uiTextBox2.TabIndex = 1;
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "";
            // 
            // uiComboBox2
            // 
            uiComboBox2.DataSource = null;
            uiComboBox2.FillColor = Color.White;
            uiComboBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiComboBox2.Items.AddRange(new object[] { "学号", "姓名", "专业", "班级", "日期" });
            uiComboBox2.Location = new Point(5, 6);
            uiComboBox2.Margin = new Padding(4, 5, 4, 5);
            uiComboBox2.MinimumSize = new Size(63, 0);
            uiComboBox2.Name = "uiComboBox2";
            uiComboBox2.Padding = new Padding(0, 0, 30, 2);
            uiComboBox2.Size = new Size(134, 32);
            uiComboBox2.TabIndex = 2;
            uiComboBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox2.Watermark = "";
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(484, 4);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(125, 36);
            uiButton2.TabIndex = 3;
            uiButton2.Text = "发布打卡";
            // 
            // AdminPunch
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiPanel1);
            Name = "AdminPunch";
            PageIndex = 2004;
            Text = "AdminPunch";
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            uiTableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UIButton uiButton2;
    }
}