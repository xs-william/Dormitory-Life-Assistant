namespace SystemForm
{
    partial class StudentEdit
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
            titleBox = new Sunny.UI.UISmoothLabel();
            MainContainer = new Sunny.UI.UITabControl();
            tabPage1 = new TabPage();
            confirmButton = new Sunny.UI.UIButton();
            uiAvatar2 = new Sunny.UI.UIAvatar();
            myself = new Sunny.UI.UIGroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            uiLabel6 = new Sunny.UI.UILabel();
            uiLabel7 = new Sunny.UI.UILabel();
            uiLabel8 = new Sunny.UI.UILabel();
            buildingNameBox = new Sunny.UI.UITextBox();
            dormBox = new Sunny.UI.UITextBox();
            passwordBox = new Sunny.UI.UITextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            uiLabel9 = new Sunny.UI.UILabel();
            nameBox = new Sunny.UI.UITextBox();
            IdBox = new Sunny.UI.UITextBox();
            genderBox = new Sunny.UI.UITextBox();
            departmentBox = new Sunny.UI.UITextBox();
            gradeBox = new Sunny.UI.UITextBox();
            classBox = new Sunny.UI.UITextBox();
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
            uiNavBar1.Controls.Add(titleBox);
            uiNavBar1.Dock = DockStyle.Top;
            uiNavBar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiNavBar1.Location = new Point(2, 36);
            uiNavBar1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiNavBar1.Name = "uiNavBar1";
            uiNavBar1.Size = new Size(1136, 99);
            uiNavBar1.TabIndex = 1;
            uiNavBar1.Text = "uiNavBar1";
            // 
            // titleBox
            // 
            titleBox.AccessibleRole = AccessibleRole.TitleBar;
            titleBox.BackColor = SystemColors.ActiveCaption;
            titleBox.Font = new Font("新宋体", 36F, FontStyle.Regular, GraphicsUnit.Point);
            titleBox.Location = new Point(459, 16);
            titleBox.Name = "titleBox";
            titleBox.RectColor = Color.White;
            titleBox.Size = new Size(441, 80);
            titleBox.Style = Sunny.UI.UIStyle.Custom;
            titleBox.TabIndex = 1;
            titleBox.Text = "修改学生";
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
            tabPage1.Controls.Add(confirmButton);
            tabPage1.Controls.Add(uiAvatar2);
            tabPage1.Controls.Add(myself);
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1136, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(878, 192);
            confirmButton.MinimumSize = new Size(1, 1);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(125, 44);
            confirmButton.TabIndex = 5;
            confirmButton.Text = "确认";
            confirmButton.Click += confirmButton_Click;
            // 
            // uiAvatar2
            // 
            uiAvatar2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar2.Location = new Point(889, 93);
            uiAvatar2.MinimumSize = new Size(1, 1);
            uiAvatar2.Name = "uiAvatar2";
            uiAvatar2.Size = new Size(98, 76);
            uiAvatar2.TabIndex = 4;
            uiAvatar2.Text = "uiAvatar2";
            // 
            // myself
            // 
            myself.Controls.Add(tableLayoutPanel2);
            myself.Controls.Add(tableLayoutPanel1);
            myself.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            myself.Location = new Point(251, 26);
            myself.Margin = new Padding(4, 5, 4, 5);
            myself.MinimumSize = new Size(1, 1);
            myself.Name = "myself";
            myself.Padding = new Padding(0, 32, 0, 0);
            myself.Size = new Size(591, 303);
            myself.TabIndex = 2;
            myself.Text = "学生个人信息：";
            myself.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel2.Controls.Add(uiLabel6, 0, 0);
            tableLayoutPanel2.Controls.Add(uiLabel7, 0, 1);
            tableLayoutPanel2.Controls.Add(uiLabel8, 0, 2);
            tableLayoutPanel2.Controls.Add(buildingNameBox, 1, 0);
            tableLayoutPanel2.Controls.Add(dormBox, 1, 1);
            tableLayoutPanel2.Controls.Add(passwordBox, 1, 2);
            tableLayoutPanel2.Location = new Point(17, 175);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(571, 125);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // uiLabel6
            // 
            uiLabel6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel6.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel6.Location = new Point(3, 6);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(250, 29);
            uiLabel6.TabIndex = 1;
            uiLabel6.Text = "所在宿舍楼栋：";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            uiLabel7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel7.Location = new Point(3, 47);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(250, 29);
            uiLabel7.TabIndex = 2;
            uiLabel7.Text = "所在宿舍号：";
            uiLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            uiLabel8.Anchor = AnchorStyles.Left;
            uiLabel8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel8.Location = new Point(3, 89);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(125, 29);
            uiLabel8.TabIndex = 5;
            uiLabel8.Text = "密码：";
            uiLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buildingNameBox
            // 
            buildingNameBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buildingNameBox.Location = new Point(260, 5);
            buildingNameBox.Margin = new Padding(4, 5, 4, 5);
            buildingNameBox.MinimumSize = new Size(1, 16);
            buildingNameBox.Name = "buildingNameBox";
            buildingNameBox.ShowText = false;
            buildingNameBox.Size = new Size(307, 31);
            buildingNameBox.TabIndex = 6;
            buildingNameBox.Text = "uiTextBox1";
            buildingNameBox.TextAlignment = ContentAlignment.MiddleLeft;
            buildingNameBox.Watermark = "";
            // 
            // dormBox
            // 
            dormBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dormBox.Location = new Point(260, 46);
            dormBox.Margin = new Padding(4, 5, 4, 5);
            dormBox.MinimumSize = new Size(1, 16);
            dormBox.Name = "dormBox";
            dormBox.ShowText = false;
            dormBox.Size = new Size(307, 31);
            dormBox.TabIndex = 7;
            dormBox.Text = "uiTextBox1";
            dormBox.TextAlignment = ContentAlignment.MiddleLeft;
            dormBox.Watermark = "";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(260, 87);
            passwordBox.Margin = new Padding(4, 5, 4, 5);
            passwordBox.MinimumSize = new Size(1, 16);
            passwordBox.Name = "passwordBox";
            passwordBox.ShowText = false;
            passwordBox.Size = new Size(307, 33);
            passwordBox.TabIndex = 8;
            passwordBox.Text = "uiTextBox1";
            passwordBox.TextAlignment = ContentAlignment.MiddleLeft;
            passwordBox.Watermark = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(uiLabel1, 2, 2);
            tableLayoutPanel1.Controls.Add(uiLabel3, 2, 0);
            tableLayoutPanel1.Controls.Add(uiLabel4, 0, 1);
            tableLayoutPanel1.Controls.Add(uiLabel2, 0, 0);
            tableLayoutPanel1.Controls.Add(uiLabel5, 2, 1);
            tableLayoutPanel1.Controls.Add(uiLabel9, 0, 2);
            tableLayoutPanel1.Controls.Add(nameBox, 1, 0);
            tableLayoutPanel1.Controls.Add(IdBox, 3, 0);
            tableLayoutPanel1.Controls.Add(genderBox, 1, 1);
            tableLayoutPanel1.Controls.Add(departmentBox, 3, 1);
            tableLayoutPanel1.Controls.Add(gradeBox, 1, 2);
            tableLayoutPanel1.Controls.Add(classBox, 3, 2);
            tableLayoutPanel1.Location = new Point(26, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(565, 134);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(229, 99);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(107, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "班级：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel3.Location = new Point(229, 9);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(107, 29);
            uiLabel3.TabIndex = 1;
            uiLabel3.Text = "学号：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.Location = new Point(3, 56);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(107, 29);
            uiLabel4.TabIndex = 2;
            uiLabel4.Text = "性别：";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(3, 9);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(107, 29);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "姓名：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.Location = new Point(229, 56);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(107, 29);
            uiLabel5.TabIndex = 4;
            uiLabel5.Text = "院系：";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            uiLabel9.Anchor = AnchorStyles.Left;
            uiLabel9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel9.Location = new Point(3, 99);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(107, 29);
            uiLabel9.TabIndex = 6;
            uiLabel9.Text = "年级：";
            uiLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(117, 5);
            nameBox.Margin = new Padding(4, 5, 4, 5);
            nameBox.MinimumSize = new Size(1, 16);
            nameBox.Name = "nameBox";
            nameBox.ShowText = false;
            nameBox.Size = new Size(105, 36);
            nameBox.TabIndex = 7;
            nameBox.Text = "uiTextBox1";
            nameBox.TextAlignment = ContentAlignment.MiddleLeft;
            nameBox.Watermark = "";
            // 
            // IdBox
            // 
            IdBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdBox.Location = new Point(343, 5);
            IdBox.Margin = new Padding(4, 5, 4, 5);
            IdBox.MinimumSize = new Size(1, 16);
            IdBox.Name = "IdBox";
            IdBox.ShowText = false;
            IdBox.Size = new Size(218, 36);
            IdBox.TabIndex = 8;
            IdBox.Text = "uiTextBox1";
            IdBox.TextAlignment = ContentAlignment.MiddleLeft;
            IdBox.Watermark = "";
            // 
            // genderBox
            // 
            genderBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genderBox.Location = new Point(117, 52);
            genderBox.Margin = new Padding(4, 5, 4, 5);
            genderBox.MinimumSize = new Size(1, 16);
            genderBox.Name = "genderBox";
            genderBox.ShowText = false;
            genderBox.Size = new Size(105, 36);
            genderBox.TabIndex = 9;
            genderBox.Text = "uiTextBox1";
            genderBox.TextAlignment = ContentAlignment.MiddleLeft;
            genderBox.Watermark = "";
            // 
            // departmentBox
            // 
            departmentBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            departmentBox.Location = new Point(343, 52);
            departmentBox.Margin = new Padding(4, 5, 4, 5);
            departmentBox.MinimumSize = new Size(1, 16);
            departmentBox.Name = "departmentBox";
            departmentBox.ShowText = false;
            departmentBox.Size = new Size(218, 36);
            departmentBox.TabIndex = 10;
            departmentBox.Text = "uiTextBox1";
            departmentBox.TextAlignment = ContentAlignment.MiddleLeft;
            departmentBox.Watermark = "";
            // 
            // gradeBox
            // 
            gradeBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gradeBox.Location = new Point(117, 99);
            gradeBox.Margin = new Padding(4, 5, 4, 5);
            gradeBox.MinimumSize = new Size(1, 16);
            gradeBox.Name = "gradeBox";
            gradeBox.ShowText = false;
            gradeBox.Size = new Size(105, 30);
            gradeBox.TabIndex = 11;
            gradeBox.Text = "uiTextBox1";
            gradeBox.TextAlignment = ContentAlignment.MiddleLeft;
            gradeBox.Watermark = "";
            // 
            // classBox
            // 
            classBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classBox.Location = new Point(343, 99);
            classBox.Margin = new Padding(4, 5, 4, 5);
            classBox.MinimumSize = new Size(1, 16);
            classBox.Name = "classBox";
            classBox.ShowText = false;
            classBox.Size = new Size(218, 30);
            classBox.TabIndex = 12;
            classBox.Text = "uiTextBox1";
            classBox.TextAlignment = ContentAlignment.MiddleLeft;
            classBox.Watermark = "";
            // 
            // StudentEdit
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1140, 627);
            Controls.Add(MainContainer);
            Controls.Add(uiNavBar1);
            Name = "StudentEdit";
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
        private Sunny.UI.UITabControl MainContainer;
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
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox buildingNameBox;
        private Sunny.UI.UITextBox dormBox;
        private Sunny.UI.UITextBox passwordBox;
        private Sunny.UI.UITextBox nameBox;
        private Sunny.UI.UITextBox genderBox;
        private Sunny.UI.UITextBox departmentBox;
        private Sunny.UI.UITextBox gradeBox;
        private Sunny.UI.UITextBox classBox;
        private Sunny.UI.UIButton confirmButton;
        public Sunny.UI.UISmoothLabel titleBox;
        public TabPage tabPage1;
        public Sunny.UI.UITextBox IdBox;
    }
}