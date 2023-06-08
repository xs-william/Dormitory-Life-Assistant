namespace SystemForm.SupForm
{
    partial class SubmitCostForm
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
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiTextBox2 = new Sunny.UI.UITextBox();
            uiTextBox3 = new Sunny.UI.UITextBox();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiButton1 = new Sunny.UI.UIButton();
            uiTableLayoutPanel1.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(3, 6);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(137, 47);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "待缴宿舍：";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            uiLabel1.Click += uiLabel1_Click;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(3, 69);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(137, 41);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "待缴金额：";
            uiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            uiLabel2.Click += uiLabel2_Click;
            // 
            // uiLabel3
            // 
            uiLabel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.Location = new Point(3, 132);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(137, 36);
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "缴费类型：";
            uiLabel3.TextAlign = ContentAlignment.MiddleCenter;
            uiLabel3.Click += uiLabel3_Click;
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 2;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            uiTableLayoutPanel1.Controls.Add(uiTextBox1, 1, 0);
            uiTableLayoutPanel1.Controls.Add(uiTextBox2, 1, 1);
            uiTableLayoutPanel1.Controls.Add(uiTextBox3, 1, 2);
            uiTableLayoutPanel1.Controls.Add(uiLabel1, 0, 0);
            uiTableLayoutPanel1.Controls.Add(uiLabel2, 0, 1);
            uiTableLayoutPanel1.Controls.Add(uiLabel3, 0, 2);
            uiTableLayoutPanel1.Location = new Point(109, 50);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 3;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            uiTableLayoutPanel1.Size = new Size(411, 181);
            uiTableLayoutPanel1.TabIndex = 3;
            uiTableLayoutPanel1.TagString = null;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(147, 5);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(260, 48);
            uiTextBox1.TabIndex = 3;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            uiTextBox1.TextChanged += uiTextBox1_TextChanged;
            // 
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox2.Location = new Point(147, 65);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(260, 50);
            uiTextBox2.TabIndex = 4;
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "";
            uiTextBox2.TextChanged += uiTextBox2_TextChanged;
            // 
            // uiTextBox3
            // 
            uiTextBox3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox3.Location = new Point(147, 125);
            uiTextBox3.Margin = new Padding(4, 5, 4, 5);
            uiTextBox3.MinimumSize = new Size(1, 16);
            uiTextBox3.Name = "uiTextBox3";
            uiTextBox3.Padding = new Padding(5);
            uiTextBox3.ShowText = false;
            uiTextBox3.Size = new Size(260, 51);
            uiTextBox3.TabIndex = 5;
            uiTextBox3.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox3.Watermark = "";
            uiTextBox3.TextChanged += uiTextBox3_TextChanged;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(uiButton1);
            uiGroupBox1.Controls.Add(uiTableLayoutPanel1);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(89, 57);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(624, 388);
            uiGroupBox1.TabIndex = 4;
            uiGroupBox1.Text = "缴费信息";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(238, 293);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(156, 52);
            uiButton1.TabIndex = 4;
            uiButton1.Text = "提交缴费信息";
            uiButton1.Click += uiButton1_Click;
            // 
            // SubmitCostForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(uiGroupBox1);
            Name = "SubmitCostForm";
            Text = "SubmitCostForm";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            uiTableLayoutPanel1.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton uiButton1;
    }
}