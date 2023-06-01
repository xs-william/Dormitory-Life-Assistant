namespace SystemForm
{
    partial class MessageEdit
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
            uiLabel2 = new Sunny.UI.UILabel();
            TimeNow = new Sunny.UI.UILabel();
            pnlBtm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBtm
            // 
            pnlBtm.Location = new Point(1, 330);
            pnlBtm.Size = new Size(703, 55);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(575, 12);
            // 
            // btnOK
            // 
            btnOK.Location = new Point(460, 12);
           
            // 
            // messageContent
            // 
            messageContent.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            messageContent.Location = new Point(222, 121);
            messageContent.Margin = new Padding(4, 5, 4, 5);
            messageContent.MinimumSize = new Size(1, 16);
            messageContent.Multiline = true;
            messageContent.Name = "messageContent";
            messageContent.ShowText = false;
            messageContent.Size = new Size(327, 145);
            messageContent.TabIndex = 2;
            messageContent.TextAlignment = ContentAlignment.MiddleLeft;
            messageContent.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(112, 121);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 29);
            uiLabel1.TabIndex = 3;
            uiLabel1.Text = "公告内容";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(156, 74);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 29);
            uiLabel2.TabIndex = 4;
            uiLabel2.Text = "时间";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TimeNow
            // 
            TimeNow.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimeNow.Location = new Point(222, 74);
            TimeNow.Name = "TimeNow";
            TimeNow.Size = new Size(327, 29);
            TimeNow.TabIndex = 5;
            TimeNow.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MessageEdit
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(705, 388);
            Controls.Add(TimeNow);
            Controls.Add(uiLabel2);
            Controls.Add(messageContent);
            Controls.Add(uiLabel1);
            Name = "MessageEdit";
            Text = "新增公告";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Controls.SetChildIndex(pnlBtm, 0);
            Controls.SetChildIndex(uiLabel1, 0);
            Controls.SetChildIndex(messageContent, 0);
            Controls.SetChildIndex(uiLabel2, 0);
            Controls.SetChildIndex(TimeNow, 0);
            pnlBtm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Sunny.UI.UITextBox messageContent;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel TimeNow;
    }
}