namespace SystemForm
{
    partial class BreakdownChildForm
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
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiTextBox1 = new Sunny.UI.UITextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            pictureBox1 = new PictureBox();
            uiNavBar1.SuspendLayout();
            MainContainer.SuspendLayout();
            tabPage1.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tabPage1.Controls.Add(uiGroupBox1);
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1136, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(pictureBox1);
            uiGroupBox1.Controls.Add(uiTextBox1);
            uiGroupBox1.Controls.Add(tableLayoutPanel1);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(289, 24);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(515, 410);
            uiGroupBox1.TabIndex = 0;
            uiGroupBox1.Text = "故障详情：";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(24, 129);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Multiline = true;
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(469, 83);
            uiTextBox1.TabIndex = 1;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(uiLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(uiLabel2, 0, 1);
            tableLayoutPanel1.Controls.Add(uiLabel3, 1, 0);
            tableLayoutPanel1.Location = new Point(24, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(469, 76);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(3, 4);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(134, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "报修宿舍号：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(3, 42);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(134, 29);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "故障内容：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.Location = new Point(143, 4);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(323, 29);
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "C4-101";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.picture;
            pictureBox1.Location = new Point(24, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // BreakdownChildForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1140, 627);
            Controls.Add(MainContainer);
            Controls.Add(uiNavBar1);
            Name = "BreakdownChildForm";
            Padding = new Padding(2, 36, 2, 2);
            ShowDragStretch = true;
            ShowRadius = false;
            ShowTitleIcon = true;
            Text = "宿舍生活小助手";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            uiNavBar1.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UINavBar uiNavBar1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UITabControl MainContainer;
        private TabPage tabPage1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITextBox uiTextBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private PictureBox pictureBox1;
    }
}