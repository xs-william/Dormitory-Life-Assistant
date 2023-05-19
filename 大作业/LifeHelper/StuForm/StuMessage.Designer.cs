namespace LifeHelper
{
    partial class StuMessage
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
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            SuspendLayout();
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Dock = DockStyle.Fill;
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(0, 0);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(975, 490);
            uiGroupBox1.TabIndex = 2;
            uiGroupBox1.Text = "我的消息";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // StuMessage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiGroupBox1);
            Name = "StuMessage";
            PageIndex = 1006;
            Text = "Message";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
    }
}