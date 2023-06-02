namespace SystemForm
{
    partial class StuRepairSon
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
            uiLabel2 = new Sunny.UI.UILabel();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // uiAvatar1
            // 
            uiAvatar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar1.Location = new Point(273, 277);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Shape = Sunny.UI.UIShape.Square;
            uiAvatar1.Size = new Size(75, 75);
            uiAvatar1.Symbol = 61846;
            uiAvatar1.SymbolSize = 80;
            uiAvatar1.TabIndex = 13;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(174, 295);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 29);
            uiLabel2.TabIndex = 12;
            uiLabel2.Text = "添加图片";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(300, 376);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(93, 38);
            uiButton2.TabIndex = 11;
            uiButton2.Text = "提交";
            uiButton2.Click += uiButton2_Click;
            // 
            // uiButton1
            // 
            uiButton1.BackColor = Color.Transparent;
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(483, 376);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(93, 38);
            uiButton1.TabIndex = 10;
            uiButton1.Text = "返回";
            uiButton1.Click += uiButton1_Click;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(273, 68);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Multiline = true;
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(339, 181);
            uiTextBox1.TabIndex = 9;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            uiTextBox1.TextChanged += uiTextBox1_TextChanged;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(174, 68);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(160, 29);
            uiLabel1.TabIndex = 8;
            uiLabel1.Text = "报修内容";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StuRepairSon
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(uiAvatar1);
            Controls.Add(uiLabel2);
            Controls.Add(uiButton2);
            Controls.Add(uiButton1);
            Controls.Add(uiTextBox1);
            Controls.Add(uiLabel1);
            Name = "StuRepairSon";
            Text = "报修";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel1;
    }
}