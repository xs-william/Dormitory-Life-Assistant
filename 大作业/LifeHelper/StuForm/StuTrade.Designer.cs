namespace LifeHelper
{
    partial class StuTrade
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
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton3 = new Sunny.UI.UIButton();
            uiButton4 = new Sunny.UI.UIButton();
            uiTitlePanel1.SuspendLayout();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(uiTableLayoutPanel1);
            uiTitlePanel1.Dock = DockStyle.Fill;
            uiTitlePanel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(0, 0);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.Padding = new Padding(0, 35, 0, 0);
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(975, 490);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "供需交易";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 5;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.54185F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.45815F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 461F));
            uiTableLayoutPanel1.Controls.Add(uiButton1, 0, 0);
            uiTableLayoutPanel1.Controls.Add(uiButton2, 1, 0);
            uiTableLayoutPanel1.Controls.Add(uiButton3, 2, 0);
            uiTableLayoutPanel1.Controls.Add(uiButton4, 3, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Top;
            uiTableLayoutPanel1.Location = new Point(0, 35);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Size = new Size(975, 50);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(3, 3);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(125, 44);
            uiButton1.TabIndex = 0;
            uiButton1.Text = "添加需求";
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(134, 3);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(117, 44);
            uiButton2.TabIndex = 1;
            uiButton2.Text = "删除需求";
            // 
            // uiButton3
            // 
            uiButton3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton3.Location = new Point(257, 3);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(120, 44);
            uiButton3.TabIndex = 2;
            uiButton3.Text = "添加供应";
            // 
            // uiButton4
            // 
            uiButton4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton4.Location = new Point(383, 3);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.Size = new Size(125, 44);
            uiButton4.TabIndex = 3;
            uiButton4.Text = "删除供应";
            // 
            // StuTrade
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiTitlePanel1);
            Name = "StuTrade";
            PageIndex = 1007;
            Text = "StuTrade";
            uiTitlePanel1.ResumeLayout(false);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton4;
    }
}