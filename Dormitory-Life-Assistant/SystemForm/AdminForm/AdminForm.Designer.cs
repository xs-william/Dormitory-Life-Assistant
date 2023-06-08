namespace SystemForm
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            MainContainer = new Sunny.UI.UITabControl();
            tabPage1 = new TabPage();
            Choice = new Sunny.UI.UINavMenu();
            uiNavBar2 = new Sunny.UI.UINavBar();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            uiSmoothLabel2 = new Sunny.UI.UISmoothLabel();
            uiAvatar2 = new Sunny.UI.UIAvatar();
            uiHeaderButton1 = new Sunny.UI.UIHeaderButton();
            MainContainer.SuspendLayout();
            uiNavBar2.SuspendLayout();
            SuspendLayout();
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(tabPage1);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.DrawMode = TabDrawMode.OwnerDrawFixed;
            MainContainer.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainContainer.ItemSize = new Size(0, 1);
            MainContainer.Location = new Point(161, 134);
            MainContainer.MainPage = "";
            MainContainer.Name = "MainContainer";
            MainContainer.SelectedIndex = 0;
            MainContainer.Size = new Size(979, 493);
            MainContainer.SizeMode = TabSizeMode.Fixed;
            MainContainer.TabIndex = 6;
            MainContainer.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            MainContainer.TabVisible = false;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(979, 493);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Choice
            // 
            Choice.BorderStyle = BorderStyle.None;
            Choice.Dock = DockStyle.Left;
            Choice.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            Choice.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Choice.FullRowSelect = true;
            Choice.ItemHeight = 50;
            Choice.Location = new Point(0, 134);
            Choice.Name = "Choice";
            Choice.ShowLines = false;
            Choice.Size = new Size(161, 493);
            Choice.TabIndex = 5;
            // 
            // uiNavBar2
            // 
            uiNavBar2.BackColor = SystemColors.ActiveCaption;
            uiNavBar2.Controls.Add(uiHeaderButton1);
            uiNavBar2.Controls.Add(uiButton2);
            uiNavBar2.Controls.Add(uiButton1);
            uiNavBar2.Controls.Add(uiSmoothLabel2);
            uiNavBar2.Controls.Add(uiAvatar2);
            uiNavBar2.Dock = DockStyle.Top;
            uiNavBar2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiNavBar2.Location = new Point(0, 35);
            uiNavBar2.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiNavBar2.Name = "uiNavBar2";
            uiNavBar2.Size = new Size(1140, 99);
            uiNavBar2.TabIndex = 4;
            uiNavBar2.Text = "uiNavBar2";
            // 
            // uiButton2
            // 
            uiButton2.BackColor = Color.Transparent;
            uiButton2.FillColor = Color.Transparent;
            uiButton2.Font = new Font("微软雅黑", 22F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.ForeColor = Color.FromArgb(255, 128, 0);
            uiButton2.Location = new Point(902, 16);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.RectColor = Color.Transparent;
            uiButton2.Size = new Size(100, 77);
            uiButton2.Style = Sunny.UI.UIStyle.Custom;
            uiButton2.TabIndex = 3;
            uiButton2.Text = "返回";
            uiButton2.Click += uiButton2_Click;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(134, 28);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(163, 54);
            uiButton1.TabIndex = 2;
            uiButton1.Text = "完善个人信息";
            uiButton1.Click += uiButton1_Click;
            // 
            // uiSmoothLabel2
            // 
            uiSmoothLabel2.AccessibleRole = AccessibleRole.TitleBar;
            uiSmoothLabel2.BackColor = SystemColors.ActiveCaption;
            uiSmoothLabel2.Font = new Font("新宋体", 36F, FontStyle.Regular, GraphicsUnit.Point);
            uiSmoothLabel2.Location = new Point(431, 16);
            uiSmoothLabel2.Name = "uiSmoothLabel2";
            uiSmoothLabel2.RectColor = Color.White;
            uiSmoothLabel2.Size = new Size(441, 80);
            uiSmoothLabel2.Style = Sunny.UI.UIStyle.Custom;
            uiSmoothLabel2.TabIndex = 1;
            uiSmoothLabel2.Text = "宿舍生活小助手";
            // 
            // uiAvatar2
            // 
            uiAvatar2.AvatarSize = 90;
            uiAvatar2.Dock = DockStyle.Left;
            uiAvatar2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar2.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            uiAvatar2.Image = (Image)resources.GetObject("uiAvatar2.Image");
            uiAvatar2.Location = new Point(0, 0);
            uiAvatar2.MinimumSize = new Size(1, 1);
            uiAvatar2.Name = "uiAvatar2";
            uiAvatar2.Size = new Size(128, 99);
            uiAvatar2.TabIndex = 0;
            uiAvatar2.Text = "uiAvatar2";
            // 
            // uiHeaderButton1
            // 
            uiHeaderButton1.BackColor = Color.Transparent;
            uiHeaderButton1.CircleColor = Color.Red;
            uiHeaderButton1.FillColor = Color.Transparent;
            uiHeaderButton1.FillDisableColor = Color.Transparent;
            uiHeaderButton1.FillHoverColor = SystemColors.ButtonFace;
            uiHeaderButton1.FillPressColor = SystemColors.ButtonShadow;
            uiHeaderButton1.FillSelectedColor = Color.Transparent;
            uiHeaderButton1.Font = new Font("华文中宋", 13F, FontStyle.Regular, GraphicsUnit.Point);
            uiHeaderButton1.ForeColor = Color.Black;
            uiHeaderButton1.ForeDisableColor = Color.Black;
            uiHeaderButton1.ForeHoverColor = Color.Gray;
            uiHeaderButton1.ForePressColor = Color.Silver;
            uiHeaderButton1.ForeSelectedColor = Color.Black;
            uiHeaderButton1.Location = new Point(1008, 2);
            uiHeaderButton1.MinimumSize = new Size(1, 1);
            uiHeaderButton1.Name = "uiHeaderButton1";
            uiHeaderButton1.Padding = new Padding(0, 8, 0, 3);
            uiHeaderButton1.Radius = 0;
            uiHeaderButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiHeaderButton1.RectSides = ToolStripStatusLabelBorderSides.None;
            uiHeaderButton1.Size = new Size(107, 91);
            uiHeaderButton1.Style = Sunny.UI.UIStyle.Custom;
            uiHeaderButton1.StyleCustomMode = true;
            uiHeaderButton1.Symbol = 61457;
            uiHeaderButton1.TabIndex = 4;
            uiHeaderButton1.Text = "退出程序";
            uiHeaderButton1.Click += uiHeaderButton1_Click;
            // 
            // AdminForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1140, 627);
            Controls.Add(MainContainer);
            Controls.Add(Choice);
            Controls.Add(uiNavBar2);
            Name = "AdminForm";
            Text = "宿舍生活小助手";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            MainContainer.ResumeLayout(false);
            uiNavBar2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControl MainContainer;
        private TabPage tabPage1;
        private Sunny.UI.UINavMenu Choice;
        private Sunny.UI.UINavBar uiNavBar2;
        private Sunny.UI.UISmoothLabel uiSmoothLabel2;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIHeaderButton uiHeaderButton1;
    }
}