namespace LifeHelper
{
    partial class Setting
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
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            uiButton2 = new Sunny.UI.UIButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiButton1 = new Sunny.UI.UIButton();
            confirmpassword = new Sunny.UI.UITextBox();
            newpassword = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiGroupBox2.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(uiButton2);
            uiGroupBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.Location = new Point(198, 283);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(578, 132);
            uiGroupBox2.TabIndex = 7;
            uiGroupBox2.Text = "注销用户";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(229, 53);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(125, 44);
            uiButton2.TabIndex = 0;
            uiButton2.Text = "确认注销";
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(uiButton1);
            uiGroupBox1.Controls.Add(confirmpassword);
            uiGroupBox1.Controls.Add(newpassword);
            uiGroupBox1.Controls.Add(uiLabel2);
            uiGroupBox1.Controls.Add(uiLabel1);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(198, 75);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(578, 189);
            uiGroupBox1.TabIndex = 6;
            uiGroupBox1.Text = "更改密码";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(229, 133);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(125, 44);
            uiButton1.TabIndex = 4;
            uiButton1.Text = "确认更改";
            // 
            // confirmpassword
            // 
            confirmpassword.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmpassword.Location = new Point(121, 89);
            confirmpassword.Margin = new Padding(4, 5, 4, 5);
            confirmpassword.MinimumSize = new Size(1, 16);
            confirmpassword.Name = "confirmpassword";
            confirmpassword.ShowText = false;
            confirmpassword.Size = new Size(254, 36);
            confirmpassword.TabIndex = 3;
            confirmpassword.TextAlignment = ContentAlignment.MiddleLeft;
            confirmpassword.Watermark = "";
            // 
            // newpassword
            // 
            newpassword.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newpassword.Location = new Point(121, 40);
            newpassword.Margin = new Padding(4, 5, 4, 5);
            newpassword.MinimumSize = new Size(1, 16);
            newpassword.Name = "newpassword";
            newpassword.ShowText = false;
            newpassword.Size = new Size(254, 36);
            newpassword.TabIndex = 2;
            newpassword.TextAlignment = ContentAlignment.MiddleLeft;
            newpassword.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(19, 89);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 29);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "确认密码";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(19, 47);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "新密码";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Setting
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiGroupBox1);
            Name = "Setting";
            PageIndex = 1008;
            Text = "Setting";
            uiGroupBox2.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox confirmpassword;
        private Sunny.UI.UITextBox newpassword;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
    }
}