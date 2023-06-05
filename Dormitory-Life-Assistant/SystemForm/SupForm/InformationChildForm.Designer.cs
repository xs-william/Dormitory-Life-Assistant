namespace SystemForm
{
    partial class InformationChildForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            DeleteButton = new Sunny.UI.UIButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            contentLabel = new Sunny.UI.UILabel();
            timeLabel = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            nameLabel = new Sunny.UI.UILabel();
            uiNavBar1.SuspendLayout();
            MainContainer.SuspendLayout();
            tabPage1.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            uiGroupBox1.Controls.Add(tableLayoutPanel1);
            uiGroupBox1.Controls.Add(tableLayoutPanel2);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(294, 28);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(457, 352);
            uiGroupBox1.TabIndex = 2;
            uiGroupBox1.Text = "通知详情：";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(DeleteButton, 0, 0);
            tableLayoutPanel2.Location = new Point(156, 284);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(132, 56);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Left;
            DeleteButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(3, 6);
            DeleteButton.MinimumSize = new Size(1, 1);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(125, 44);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "删除通知";
            DeleteButton.Click += DeleteButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(contentLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(timeLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(uiLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(uiLabel2, 0, 1);
            tableLayoutPanel1.Controls.Add(uiLabel3, 0, 2);
            tableLayoutPanel1.Controls.Add(nameLabel, 1, 0);
            tableLayoutPanel1.Location = new Point(44, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(371, 225);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // contentLabel
            // 
            contentLabel.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contentLabel.ImageAlign = ContentAlignment.MiddleLeft;
            contentLabel.Location = new Point(152, 113);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new Size(215, 111);
            contentLabel.TabIndex = 5;
            contentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            timeLabel.Anchor = AnchorStyles.None;
            timeLabel.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.ImageAlign = ContentAlignment.MiddleLeft;
            timeLabel.Location = new Point(197, 70);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(125, 29);
            timeLabel.TabIndex = 4;
            timeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(4, 14);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(141, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "发布者：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(4, 70);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(141, 29);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "发布时间：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.Location = new Point(4, 154);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(141, 29);
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "通知内容：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            nameLabel.Location = new Point(197, 14);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(125, 29);
            nameLabel.TabIndex = 3;
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InformationChildForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1140, 627);
            Controls.Add(MainContainer);
            Controls.Add(uiNavBar1);
            Name = "InformationChildForm";
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UINavBar uiNavBar1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UITabControl MainContainer;
        private TabPage tabPage1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UIButton DeleteButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel contentLabel;
        private Sunny.UI.UILabel timeLabel;
        private Sunny.UI.UILabel nameLabel;
    }
}