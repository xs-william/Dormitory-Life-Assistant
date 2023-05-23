namespace LifeHelper
{
    partial class LogInForm
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
            uiAvatar1 = new Sunny.UI.UIAvatar();
            MainContainer = new Sunny.UI.UITabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            StudentRadioButton = new Sunny.UI.UIRadioButton();
            TeacherRadioButton = new Sunny.UI.UIRadioButton();
            ManagerRadioButton3 = new Sunny.UI.UIRadioButton();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            RemindLabel = new Sunny.UI.UILabel();
            RegisterButton = new Sunny.UI.UIButton();
            LogInButton = new Sunny.UI.UIButton();
            PasswordCheckBox = new Sunny.UI.UICheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            IDTextBox = new Sunny.UI.UITextBox();
            PasswordTextBox = new Sunny.UI.UITextBox();
            uiNavBar1.SuspendLayout();
            MainContainer.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uiGroupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiNavBar1
            // 
            uiNavBar1.BackColor = SystemColors.ActiveCaption;
            uiNavBar1.Controls.Add(uiSmoothLabel1);
            uiNavBar1.Controls.Add(uiAvatar1);
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
            // uiAvatar1
            // 
            uiAvatar1.AvatarSize = 90;
            uiAvatar1.Dock = DockStyle.Left;
            uiAvatar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar1.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            uiAvatar1.Image = Properties.Resources.QQ图片20230512221501;
            uiAvatar1.Location = new Point(0, 0);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(195, 99);
            uiAvatar1.TabIndex = 0;
            uiAvatar1.Text = "uiAvatar1";
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
            MainContainer.Size = new Size(1136, 657);
            MainContainer.SizeMode = TabSizeMode.Fixed;
            MainContainer.TabIndex = 3;
            MainContainer.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            MainContainer.TabVisible = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1136, 657);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(uiGroupBox1);
            panel1.Controls.Add(uiGroupBox2);
            panel1.Location = new Point(316, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 629);
            panel1.TabIndex = 2;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(tableLayoutPanel1);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(4, 25);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(474, 209);
            uiGroupBox1.TabIndex = 0;
            uiGroupBox1.Text = "请选择您的登录身份";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(StudentRadioButton, 0, 0);
            tableLayoutPanel1.Controls.Add(TeacherRadioButton, 1, 0);
            tableLayoutPanel1.Controls.Add(ManagerRadioButton3, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox3, 2, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Location = new Point(42, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Size = new Size(396, 161);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // StudentRadioButton
            // 
            StudentRadioButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StudentRadioButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StudentRadioButton.Location = new Point(3, 3);
            StudentRadioButton.MinimumSize = new Size(1, 1);
            StudentRadioButton.Name = "StudentRadioButton";
            StudentRadioButton.Padding = new Padding(22, 0, 0, 0);
            StudentRadioButton.Size = new Size(125, 34);
            StudentRadioButton.TabIndex = 0;
            StudentRadioButton.Text = "学生";
            // 
            // TeacherRadioButton
            // 
            TeacherRadioButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TeacherRadioButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TeacherRadioButton.Location = new Point(134, 5);
            TeacherRadioButton.MinimumSize = new Size(1, 1);
            TeacherRadioButton.Name = "TeacherRadioButton";
            TeacherRadioButton.Padding = new Padding(22, 0, 0, 0);
            TeacherRadioButton.Size = new Size(126, 30);
            TeacherRadioButton.TabIndex = 1;
            TeacherRadioButton.Text = "宿管";
            // 
            // ManagerRadioButton3
            // 
            ManagerRadioButton3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ManagerRadioButton3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ManagerRadioButton3.Location = new Point(266, 3);
            ManagerRadioButton3.MinimumSize = new Size(1, 1);
            ManagerRadioButton3.Name = "ManagerRadioButton3";
            ManagerRadioButton3.Padding = new Padding(22, 0, 0, 0);
            ManagerRadioButton3.Size = new Size(127, 34);
            ManagerRadioButton3.TabIndex = 2;
            ManagerRadioButton3.Text = "管理员";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.teacher;
            pictureBox2.Location = new Point(134, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.manager;
            pictureBox3.Location = new Point(266, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(127, 115);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.student;
            pictureBox1.Location = new Point(3, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(RemindLabel);
            uiGroupBox2.Controls.Add(RegisterButton);
            uiGroupBox2.Controls.Add(LogInButton);
            uiGroupBox2.Controls.Add(PasswordCheckBox);
            uiGroupBox2.Controls.Add(tableLayoutPanel2);
            uiGroupBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.Location = new Point(4, 254);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(474, 364);
            uiGroupBox2.TabIndex = 1;
            uiGroupBox2.Text = "登录";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // RemindLabel
            // 
            RemindLabel.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemindLabel.Location = new Point(124, 194);
            RemindLabel.Name = "RemindLabel";
            RemindLabel.Size = new Size(244, 29);
            RemindLabel.TabIndex = 4;
            RemindLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterButton.Location = new Point(176, 299);
            RegisterButton.MinimumSize = new Size(1, 1);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(133, 44);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "注册";
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogInButton.Location = new Point(176, 239);
            LogInButton.MinimumSize = new Size(1, 1);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(133, 44);
            LogInButton.TabIndex = 2;
            LogInButton.Text = "登录";
            LogInButton.TipsForeColor = SystemColors.WindowText;
            LogInButton.Click += LogInButton_Click;
            // 
            // PasswordCheckBox
            // 
            PasswordCheckBox.Font = new Font("微软雅黑", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordCheckBox.Location = new Point(376, 134);
            PasswordCheckBox.MinimumSize = new Size(1, 1);
            PasswordCheckBox.Name = "PasswordCheckBox";
            PasswordCheckBox.Padding = new Padding(22, 0, 0, 0);
            PasswordCheckBox.Size = new Size(86, 36);
            PasswordCheckBox.TabIndex = 1;
            PasswordCheckBox.Text = "显示密码";
            PasswordCheckBox.CheckedChanged += PasswordCheckBox_CheckedChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.Controls.Add(uiLabel1, 0, 0);
            tableLayoutPanel2.Controls.Add(uiLabel2, 0, 1);
            tableLayoutPanel2.Controls.Add(IDTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(PasswordTextBox, 1, 1);
            tableLayoutPanel2.Location = new Point(42, 60);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(326, 115);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(3, 14);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(75, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "账号：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(3, 71);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(75, 29);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "密码：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IDTextBox.DoubleValue = 2021302111999D;
            IDTextBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDTextBox.Location = new Point(85, 10);
            IDTextBox.Margin = new Padding(4, 5, 4, 5);
            IDTextBox.MinimumSize = new Size(1, 16);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ShowText = false;
            IDTextBox.Size = new Size(237, 36);
            IDTextBox.TabIndex = 2;
            IDTextBox.Text = "2021302111999";
            IDTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            IDTextBox.Watermark = "";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.DoubleValue = 88888888D;
            PasswordTextBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.IntValue = 88888888;
            PasswordTextBox.Location = new Point(85, 68);
            PasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            PasswordTextBox.MinimumSize = new Size(1, 16);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.ShowText = false;
            PasswordTextBox.Size = new Size(237, 36);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.Text = "88888888";
            PasswordTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            PasswordTextBox.Watermark = "";
            // 
            // LogInForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1140, 794);
            Controls.Add(MainContainer);
            Controls.Add(uiNavBar1);
            Name = "LogInForm";
            Padding = new Padding(2, 36, 2, 2);
            ShowDragStretch = true;
            ShowRadius = false;
            ShowTitleIcon = true;
            Text = "宿舍生活小助手";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            uiNavBar1.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uiGroupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UINavBar uiNavBar1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UITabControl MainContainer;
        private TabPage tabPage1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UIRadioButton StudentRadioButton;
        private Sunny.UI.UIRadioButton TeacherRadioButton;
        private Sunny.UI.UIRadioButton ManagerRadioButton3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UICheckBox PasswordCheckBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox IDTextBox;
        private Sunny.UI.UITextBox PasswordTextBox;
        private Sunny.UI.UIButton LogInButton;
        private Sunny.UI.UIButton RegisterButton;
        private Sunny.UI.UILabel RemindLabel;
    }
}