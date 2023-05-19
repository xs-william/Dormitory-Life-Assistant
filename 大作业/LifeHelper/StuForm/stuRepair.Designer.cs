namespace LifeHelper
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
            uiAvatar1 = new Sunny.UI.UIAvatar();
            uiLabel1 = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            uiLine1 = new Sunny.UI.UILine();
            complaint = new Sunny.UI.UITextBox();
            uiLine2 = new Sunny.UI.UILine();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            SuspendLayout();
            // 
            // uiAvatar1
            // 
            uiAvatar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar1.Location = new Point(352, 247);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Shape = Sunny.UI.UIShape.Square;
            uiAvatar1.Size = new Size(110, 110);
            uiAvatar1.Symbol = 61846;
            uiAvatar1.SymbolSize = 110;
            uiAvatar1.TabIndex = 8;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(262, 302);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 29);
            uiLabel1.TabIndex = 9;
            uiLabel1.Text = "添加图片";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(398, 380);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(169, 36);
            uiButton1.TabIndex = 7;
            uiButton1.Text = "提交";
            // 
            // uiLine1
            // 
            uiLine1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLine1.Location = new Point(262, 112);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(450, 36);
            uiLine1.TabIndex = 6;
            uiLine1.Text = "保修内容";
            uiLine1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // complaint
            // 
            complaint.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            complaint.Location = new Point(262, 156);
            complaint.Margin = new Padding(4, 5, 4, 5);
            complaint.MinimumSize = new Size(1, 16);
            complaint.Multiline = true;
            complaint.Name = "complaint";
            complaint.ShowText = false;
            complaint.Size = new Size(450, 83);
            complaint.StyleCustomMode = true;
            complaint.TabIndex = 5;
            complaint.TextAlignment = ContentAlignment.MiddleLeft;
            complaint.Watermark = "";
            // 
            // uiLine2
            // 
            uiLine2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLine2.Location = new Point(262, 21);
            uiLine2.MinimumSize = new Size(1, 1);
            uiLine2.Name = "uiLine2";
            uiLine2.Size = new Size(450, 36);
            uiLine2.TabIndex = 10;
            uiLine2.Text = "保修项目";
            uiLine2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiComboBox1.Items.AddRange(new object[] { "水", "电", "空调", "油漆" });
            uiComboBox1.Location = new Point(262, 68);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Size = new Size(211, 36);
            uiComboBox1.TabIndex = 11;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "";
            // 
            // stuRepair
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiComboBox1);
            Controls.Add(uiLine2);
            Controls.Add(uiAvatar1);
            Controls.Add(uiLabel1);
            Controls.Add(uiButton1);
            Controls.Add(uiLine1);
            Controls.Add(complaint);
            Name = "stuRepair";
            PageIndex = 1003;
            Text = "Repair";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UITextBox complaint;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UIComboBox uiComboBox1;
    }
}