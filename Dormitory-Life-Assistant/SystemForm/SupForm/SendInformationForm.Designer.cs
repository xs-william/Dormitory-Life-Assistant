namespace SystemForm
{
    partial class SendInformationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiNavBar1 = new Sunny.UI.UINavBar();
            uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            MainContainer = new Sunny.UI.UITabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            okbutton = new Sunny.UI.UIButton();
            uiNavBar1.SuspendLayout();
            MainContainer.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiNavBar1
            // 
            uiNavBar1.BackColor = SystemColors.ActiveCaption;
            uiNavBar1.Controls.Add(uiSmoothLabel1);
            uiNavBar1.Dock = DockStyle.Top;
            uiNavBar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiNavBar1.Location = new Point(2, 36);
            uiNavBar1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiNavBar1.Name = "uiNavBar1";
            uiNavBar1.Size = new Size(1136, 99);
            uiNavBar1.TabIndex = 1;
            uiNavBar1.Text = "uiNavBar1";
            // 
            // uiSmoothLabel1
            // 
            uiSmoothLabel1.AccessibleRole = AccessibleRole.TitleBar;
            uiSmoothLabel1.BackColor = SystemColors.ActiveCaption;
            uiSmoothLabel1.Font = new Font("新宋体", 36F, FontStyle.Regular, GraphicsUnit.Point);
            uiSmoothLabel1.Location = new Point(341, 15);
            uiSmoothLabel1.Name = "uiSmoothLabel1";
            uiSmoothLabel1.RectColor = Color.White;
            uiSmoothLabel1.Size = new Size(441, 80);
            uiSmoothLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiSmoothLabel1.TabIndex = 1;
            uiSmoothLabel1.Text = "宿舍生活小助手";
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(tabPage1);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.DrawMode = TabDrawMode.OwnerDrawFixed;
            MainContainer.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainContainer.ItemSize = new Size(0, 1);
            MainContainer.Location = new Point(2, 135);
            MainContainer.MainPage = "";
            MainContainer.Name = "MainContainer";
            MainContainer.SelectedIndex = 0;
            MainContainer.Size = new Size(1136, 490);
            MainContainer.SizeMode = TabSizeMode.Fixed;
            MainContainer.TabIndex = 3;
            MainContainer.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            MainContainer.TabVisible = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1136, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(uiTextBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(uiLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(okbutton, 0, 2);
            tableLayoutPanel1.Location = new Point(325, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(492, 339);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiTextBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(4, 55);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Multiline = true;
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(484, 227);
            uiTextBox1.TabIndex = 0;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Left;
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(3, 10);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(214, 29);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "请输入通知内容：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // okbutton
            // 
            okbutton.Anchor = AnchorStyles.None;
            okbutton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            okbutton.Location = new Point(183, 291);
            okbutton.MinimumSize = new Size(1, 1);
            okbutton.Name = "okbutton";
            okbutton.Size = new Size(125, 44);
            okbutton.TabIndex = 2;
            okbutton.Text = "发布通知";
            okbutton.Click += okbutton_Click;
            // 
            // SendInformationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1140, 627);
            Controls.Add(MainContainer);
            Controls.Add(uiNavBar1);
            Name = "SendInformationForm";
            Padding = new Padding(2, 36, 2, 2);
            ShowDragStretch = true;
            ShowRadius = false;
            ShowTitleIcon = true;
            Text = "宿舍生活小助手";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            uiNavBar1.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UINavBar uiNavBar1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UITabControl MainContainer;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UITextBox uiTextBox1;
        public Sunny.UI.UILabel uiLabel1;
        public Sunny.UI.UIButton okbutton;
    }
}