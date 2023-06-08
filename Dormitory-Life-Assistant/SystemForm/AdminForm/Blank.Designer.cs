namespace SystemForm
{
    partial class Blank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label label1;

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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 149);
            label1.Name = "label1";
            label1.Size = new Size(400, 94);
            label1.TabIndex = 0;
            label1.Text = "发布成功！";
            label1.Click += label1_Click;
            // 
            // Blank
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "Blank";
            Text = "Blank";
            Load += Blank_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}