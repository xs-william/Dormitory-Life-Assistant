namespace LifeHelper
{
    partial class StuComplaintSon
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
            uiAvatar1 = new Sunny.UI.UIAvatar();
            uiLabel2 = new Sunny.UI.UILabel();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiAvatar1);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiButton2);
            uiPanel1.Controls.Add(uiButton1);
            uiPanel1.Controls.Add(uiTextBox1);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(0, 35);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(820, 428);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiAvatar1
            // 
            uiAvatar1.FillColor = Color.Transparent;
            uiAvatar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar1.Location = new Point(244, 251);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Shape = Sunny.UI.UIShape.Square;
            uiAvatar1.Size = new Size(75, 75);
            uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            uiAvatar1.Symbol = 61846;
            uiAvatar1.SymbolSize = 80;
            uiAvatar1.TabIndex = 7;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(145, 269);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 29);
            uiLabel2.TabIndex = 6;
            uiLabel2.Text = "添加图片";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(271, 350);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(93, 38);
            uiButton2.TabIndex = 5;
            uiButton2.Text = "提交";
            // 
            // uiButton1
            // 
            uiButton1.BackColor = Color.Transparent;
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(454, 350);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(93, 38);
            uiButton1.TabIndex = 4;
            uiButton1.Text = "返回";
            uiButton1.Click += uiButton1_Click;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(244, 42);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Multiline = true;
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(339, 181);
            uiTextBox1.TabIndex = 3;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(97, 42);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(160, 29);
            uiLabel1.TabIndex = 2;
            uiLabel1.Text = "投诉/举报内容";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StuComplaintSon
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(820, 463);
            Controls.Add(uiPanel1);
            Name = "StuComplaintSon";
            Text = "投诉/举报提交";
            ZoomScaleRect = new Rectangle(19, 19, 975, 490);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
    }
}