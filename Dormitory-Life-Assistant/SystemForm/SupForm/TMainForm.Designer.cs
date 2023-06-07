namespace SystemForm
{
    partial class TMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TMainForm));
            uiNavBar1 = new Sunny.UI.UINavBar();
            uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            Choice = new Sunny.UI.UINavMenu();
            MainContainer = new Sunny.UI.UITabControl();
            tabPage1 = new TabPage();
            uiHeaderButton1 = new Sunny.UI.UIHeaderButton();
            uiNavBar1.SuspendLayout();
            MainContainer.SuspendLayout();
            SuspendLayout();
            // 
            // uiNavBar1
            // 
            uiNavBar1.BackColor = SystemColors.ActiveCaption;
            uiNavBar1.Controls.Add(uiHeaderButton1);
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
            uiAvatar1.Image = (Image)resources.GetObject("uiAvatar1.Image");
            uiAvatar1.Location = new Point(0, 0);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Size = new Size(195, 99);
            uiAvatar1.TabIndex = 0;
            uiAvatar1.Text = "uiAvatar1";
            // 
            // Choice
            // 
            Choice.BorderStyle = BorderStyle.None;
            Choice.Dock = DockStyle.Left;
            Choice.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            Choice.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Choice.FullRowSelect = true;
            Choice.ItemHeight = 50;
            Choice.Location = new Point(2, 135);
            Choice.Name = "Choice";
            Choice.ShowLines = false;
            Choice.Size = new Size(161, 490);
            Choice.TabIndex = 2;
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(tabPage1);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.DrawMode = TabDrawMode.OwnerDrawFixed;
            MainContainer.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainContainer.ItemSize = new Size(0, 1);
            MainContainer.Location = new Point(163, 135);
            MainContainer.MainPage = "";
            MainContainer.Name = "MainContainer";
            MainContainer.SelectedIndex = 0;
            MainContainer.Size = new Size(975, 490);
            MainContainer.SizeMode = TabSizeMode.Fixed;
            MainContainer.TabIndex = 3;
            MainContainer.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            MainContainer.TabVisible = false;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(975, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
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
            // TMainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1140, 627);
            Controls.Add(MainContainer);
            Controls.Add(Choice);
            Controls.Add(uiNavBar1);
            Name = "TMainForm";
            Padding = new Padding(2, 36, 2, 2);
            ShowDragStretch = true;
            ShowRadius = false;
            ShowTitleIcon = true;
            Text = "宿舍生活小助手";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += TMainForm_Load;
            uiNavBar1.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UINavBar uiNavBar1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UINavMenu Choice;
        private Sunny.UI.UITabControl MainContainer;
        private TabPage tabPage1;
        private Sunny.UI.UIHeaderButton uiHeaderButton1;
    }
}