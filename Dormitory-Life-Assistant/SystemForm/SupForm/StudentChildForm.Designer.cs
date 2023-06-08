namespace SystemForm
{
    partial class StudentChildForm
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
            myself = new Sunny.UI.UIGroupBox();
            uiAvatar2 = new Sunny.UI.UIAvatar();
            tableLayoutPanel2 = new TableLayoutPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            uiLabel7 = new Sunny.UI.UILabel();
            classBox = new Sunny.UI.UITextBox();
            buildingBox = new Sunny.UI.UITextBox();
            dormNumberBox = new Sunny.UI.UITextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            idBox = new Sunny.UI.UITextBox();
            nameBox = new Sunny.UI.UITextBox();
            genderBox = new Sunny.UI.UITextBox();
            departmentBox = new Sunny.UI.UITextBox();
            uiNavBar1.SuspendLayout();
            MainContainer.SuspendLayout();
            tabPage1.SuspendLayout();
            myself.SuspendLayout();
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
            tabPage1.Controls.Add(myself);
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1136, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // myself
            // 
            myself.Controls.Add(uiAvatar2);
            myself.Controls.Add(tableLayoutPanel2);
            myself.Controls.Add(tableLayoutPanel1);
            myself.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            myself.Location = new Point(251, 26);
            myself.Margin = new Padding(4, 5, 4, 5);
            myself.MinimumSize = new Size(1, 1);
            myself.Name = "myself";
            myself.Padding = new Padding(0, 32, 0, 0);
            myself.Size = new Size(637, 359);
            myself.TabIndex = 2;
            myself.Text = "学生个人信息：";
            myself.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiAvatar2
            // 
            uiAvatar2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar2.Location = new Point(496, 47);
            uiAvatar2.MinimumSize = new Size(1, 1);
            uiAvatar2.Name = "uiAvatar2";
            uiAvatar2.Size = new Size(128, 133);
            uiAvatar2.TabIndex = 4;
            uiAvatar2.Text = "uiAvatar2";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel2.Controls.Add(uiLabel1, 0, 0);
            tableLayoutPanel2.Controls.Add(uiLabel6, 0, 1);
            tableLayoutPanel2.Controls.Add(uiLabel7, 0, 2);
            tableLayoutPanel2.Controls.Add(classBox, 1, 0);
            tableLayoutPanel2.Controls.Add(buildingBox, 1, 1);
            tableLayoutPanel2.Controls.Add(dormNumberBox, 1, 2);
            tableLayoutPanel2.Location = new Point(26, 193);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(455, 163);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(3, 12);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(198, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "所在班级：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel6.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel6.Location = new Point(3, 66);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(198, 29);
            uiLabel6.TabIndex = 1;
            uiLabel6.Text = "所在宿舍楼栋：";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            uiLabel7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel7.Location = new Point(3, 121);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(198, 29);
            uiLabel7.TabIndex = 2;
            uiLabel7.Text = "所在宿舍号：";
            uiLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // classBox
            // 
            classBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classBox.Location = new Point(208, 5);
            classBox.Margin = new Padding(4, 5, 4, 5);
            classBox.MinimumSize = new Size(1, 16);
            classBox.Name = "classBox";
            classBox.Padding = new Padding(5);
            classBox.ShowText = false;
            classBox.Size = new Size(243, 44);
            classBox.TabIndex = 3;
            classBox.Text = "uiTextBox1";
            classBox.TextAlignment = ContentAlignment.MiddleLeft;
            classBox.Watermark = "";
            // 
            // buildingBox
            // 
            buildingBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buildingBox.Location = new Point(208, 59);
            buildingBox.Margin = new Padding(4, 5, 4, 5);
            buildingBox.MinimumSize = new Size(1, 16);
            buildingBox.Name = "buildingBox";
            buildingBox.Padding = new Padding(5);
            buildingBox.ShowText = false;
            buildingBox.Size = new Size(243, 44);
            buildingBox.TabIndex = 4;
            buildingBox.Text = "uiTextBox1";
            buildingBox.TextAlignment = ContentAlignment.MiddleLeft;
            buildingBox.Watermark = "";
            // 
            // dormNumberBox
            // 
            dormNumberBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dormNumberBox.Location = new Point(208, 113);
            dormNumberBox.Margin = new Padding(4, 5, 4, 5);
            dormNumberBox.MinimumSize = new Size(1, 16);
            dormNumberBox.Name = "dormNumberBox";
            dormNumberBox.Padding = new Padding(5);
            dormNumberBox.ShowText = false;
            dormNumberBox.Size = new Size(243, 44);
            dormNumberBox.TabIndex = 5;
            dormNumberBox.Text = "uiTextBox1";
            dormNumberBox.TextAlignment = ContentAlignment.MiddleLeft;
            dormNumberBox.Watermark = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.9780216F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.0219784F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.8571434F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.1428566F));
            tableLayoutPanel1.Controls.Add(uiLabel3, 2, 0);
            tableLayoutPanel1.Controls.Add(uiLabel4, 0, 1);
            tableLayoutPanel1.Controls.Add(uiLabel2, 0, 0);
            tableLayoutPanel1.Controls.Add(uiLabel5, 2, 1);
            tableLayoutPanel1.Controls.Add(idBox, 3, 0);
            tableLayoutPanel1.Controls.Add(nameBox, 1, 0);
            tableLayoutPanel1.Controls.Add(genderBox, 1, 1);
            tableLayoutPanel1.Controls.Add(departmentBox, 3, 1);
            tableLayoutPanel1.Location = new Point(26, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(455, 152);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // uiLabel3
            // 
            uiLabel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel3.Location = new Point(185, 23);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(98, 29);
            uiLabel3.TabIndex = 1;
            uiLabel3.Text = "学号：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.Location = new Point(3, 99);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(94, 29);
            uiLabel4.TabIndex = 2;
            uiLabel4.Text = "性别：";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(3, 23);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(94, 29);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "姓名：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.Location = new Point(185, 99);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(98, 29);
            uiLabel5.TabIndex = 4;
            uiLabel5.Text = "院系：";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idBox
            // 
            idBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.Location = new Point(290, 5);
            idBox.Margin = new Padding(4, 5, 4, 5);
            idBox.MinimumSize = new Size(1, 16);
            idBox.Name = "idBox";
            idBox.Padding = new Padding(5);
            idBox.ShowText = false;
            idBox.Size = new Size(161, 60);
            idBox.TabIndex = 6;
            idBox.Text = "uiTextBox1";
            idBox.TextAlignment = ContentAlignment.MiddleLeft;
            idBox.Watermark = "";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(104, 5);
            nameBox.Margin = new Padding(4, 5, 4, 5);
            nameBox.MinimumSize = new Size(1, 16);
            nameBox.Name = "nameBox";
            nameBox.Padding = new Padding(5);
            nameBox.ShowText = false;
            nameBox.Size = new Size(74, 60);
            nameBox.TabIndex = 7;
            nameBox.Text = "uiTextBox1";
            nameBox.TextAlignment = ContentAlignment.MiddleLeft;
            nameBox.Watermark = "";
            // 
            // genderBox
            // 
            genderBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genderBox.Location = new Point(104, 81);
            genderBox.Margin = new Padding(4, 5, 4, 5);
            genderBox.MinimumSize = new Size(1, 16);
            genderBox.Name = "genderBox";
            genderBox.Padding = new Padding(5);
            genderBox.ShowText = false;
            genderBox.Size = new Size(74, 60);
            genderBox.TabIndex = 8;
            genderBox.Text = "uiTextBox1";
            genderBox.TextAlignment = ContentAlignment.MiddleLeft;
            genderBox.Watermark = "";
            // 
            // departmentBox
            // 
            departmentBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            departmentBox.Location = new Point(290, 81);
            departmentBox.Margin = new Padding(4, 5, 4, 5);
            departmentBox.MinimumSize = new Size(1, 16);
            departmentBox.Name = "departmentBox";
            departmentBox.Padding = new Padding(5);
            departmentBox.ShowText = false;
            departmentBox.Size = new Size(161, 60);
            departmentBox.TabIndex = 9;
            departmentBox.Text = "uiTextBox1";
            departmentBox.TextAlignment = ContentAlignment.MiddleLeft;
            departmentBox.Watermark = "";
            // 
            // StudentChildForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1140, 627);
            Controls.Add(MainContainer);
            Controls.Add(uiNavBar1);
            Name = "StudentChildForm";
            Padding = new Padding(2, 36, 2, 2);
            ShowDragStretch = true;
            ShowRadius = false;
            ShowTitleIcon = true;
            Text = "宿舍生活小助手";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            uiNavBar1.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            myself.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UINavBar uiNavBar1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UITabControl MainContainer;
        private TabPage tabPage1;
        private Sunny.UI.UIGroupBox myself;
        private TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UITextBox classBox;
        private Sunny.UI.UITextBox buildingBox;
        private Sunny.UI.UITextBox dormNumberBox;
        private Sunny.UI.UITextBox idBox;
        private Sunny.UI.UITextBox nameBox;
        private Sunny.UI.UITextBox genderBox;
        private Sunny.UI.UITextBox departmentBox;
    }
}