namespace SystemForm
{
    partial class MessageEdit2
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
            messageContent = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            pnlBtm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBtm
            // 
            pnlBtm.Size = new Size(798, 55);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(670, 12);
            // 
            // btnOK
            // 
            btnOK.Location = new Point(555, 12);
            // 
            // messageContent
            // 
            messageContent.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            messageContent.Location = new Point(232, 138);
            messageContent.Margin = new Padding(4, 5, 4, 5);
            messageContent.MinimumSize = new Size(1, 16);
            messageContent.Multiline = true;
            messageContent.Name = "messageContent";
            messageContent.ShowText = false;
            messageContent.Size = new Size(340, 160);
            messageContent.TabIndex = 3;
            messageContent.TextAlignment = ContentAlignment.MiddleLeft;
            messageContent.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(128, 138);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 29);
            uiLabel1.TabIndex = 4;
            uiLabel1.Text = "公告内容";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MessageEdit2
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(messageContent);
            Controls.Add(uiLabel1);
            Name = "MessageEdit2";
            Text = "MessageEdit2";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Controls.SetChildIndex(pnlBtm, 0);
            Controls.SetChildIndex(uiLabel1, 0);
            Controls.SetChildIndex(messageContent, 0);
            pnlBtm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Sunny.UI.UITextBox messageContent;
        public Sunny.UI.UILabel uiLabel1;
    }
}