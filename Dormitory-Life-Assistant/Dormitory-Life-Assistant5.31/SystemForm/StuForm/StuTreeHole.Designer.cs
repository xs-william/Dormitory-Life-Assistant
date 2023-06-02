namespace SystemForm
{
    partial class StuTreeHole
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
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiTitlePanel1.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(uiPanel1);
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
            uiTitlePanel1.Text = "树洞";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(4, 5);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Multiline = true;
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(766, 123);
            uiTextBox1.TabIndex = 0;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(777, 84);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(93, 44);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "发送";
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(876, 84);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(92, 44);
            uiButton2.TabIndex = 2;
            uiButton2.Text = "取消";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiButton2);
            uiPanel1.Controls.Add(uiButton1);
            uiPanel1.Controls.Add(uiTextBox1);
            uiPanel1.Dock = DockStyle.Bottom;
            uiPanel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(0, 355);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(975, 135);
            uiPanel1.TabIndex = 0;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // StuTreeHole
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiTitlePanel1);
            Name = "StuTreeHole";
            PageIndex = 1004;
            Text = "TreeHole";
            uiTitlePanel1.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton uiButton2;
    }
}