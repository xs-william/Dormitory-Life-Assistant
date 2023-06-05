namespace SystemForm
{
    partial class Blank2
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
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 48F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(195, 93);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(444, 267);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "发布成功";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Blank2
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(uiLabel1);
            Name = "Blank2";
            Text = "Blank2";
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
    }
}