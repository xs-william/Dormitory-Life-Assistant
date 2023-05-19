namespace LifeHelper
{
    partial class StuComplaint
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
            complaint = new Sunny.UI.UITextBox();
            uiLine1 = new Sunny.UI.UILine();
            uiButton1 = new Sunny.UI.UIButton();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            uiLabel1 = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // complaint
            // 
            complaint.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            complaint.Location = new Point(242, 139);
            complaint.Margin = new Padding(4, 5, 4, 5);
            complaint.MinimumSize = new Size(1, 16);
            complaint.Multiline = true;
            complaint.Name = "complaint";
            complaint.ShowText = false;
            complaint.Size = new Size(450, 121);
            complaint.StyleCustomMode = true;
            complaint.TabIndex = 0;
            complaint.TextAlignment = ContentAlignment.MiddleLeft;
            complaint.Watermark = "";
            // 
            // uiLine1
            // 
            uiLine1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLine1.Location = new Point(242, 95);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(450, 36);
            uiLine1.TabIndex = 1;
            uiLine1.Text = "投诉/举报内容";
            uiLine1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(378, 401);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(169, 36);
            uiButton1.TabIndex = 2;
            uiButton1.Text = "提交";
            // 
            // uiAvatar1
            // 
            uiAvatar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar1.Location = new Point(332, 268);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Shape = Sunny.UI.UIShape.Square;
            uiAvatar1.Size = new Size(110, 110);
            uiAvatar1.Symbol = 61846;
            uiAvatar1.SymbolSize = 110;
            uiAvatar1.TabIndex = 3;
            uiAvatar1.Text = "uiAvatar1";
            uiAvatar1.Click += uiAvatar1_Click;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(242, 323);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 29);
            uiLabel1.TabIndex = 4;
            uiLabel1.Text = "添加图片";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StuComplaint
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiAvatar1);
            Controls.Add(uiLabel1);
            Controls.Add(uiButton1);
            Controls.Add(uiLine1);
            Controls.Add(complaint);
            Name = "StuComplaint";
            PageIndex = 1008;
            Text = "Complaint";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITextBox complaint;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
    }
}