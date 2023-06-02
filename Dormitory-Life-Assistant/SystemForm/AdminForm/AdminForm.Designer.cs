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
            uiSmoothLabel2 = new Sunny.UI.UISmoothLabel();
            uiAvatar2 = new Sunny.UI.UIAvatar();
            uiButton1 = new Sunny.UI.UIButton();
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
            // uiSmoothLabel2
            // 
            uiSmoothLabel2.AccessibleRole = AccessibleRole.TitleBar;
            uiSmoothLabel2.BackColor = SystemColors.ActiveCaption;
            uiSmoothLabel2.Font = new Font("新宋体", 36F, FontStyle.Regular, GraphicsUnit.Point);
            uiSmoothLabel2.Location = new Point(341, 15);
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
            uiAvatar2.Size = new Size(195, 99);
            uiAvatar2.TabIndex = 0;
            uiAvatar2.Text = "uiAvatar2";
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(922, 29);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(150, 52);
            uiButton1.TabIndex = 2;
            uiButton1.Text = "返回";
            uiButton1.Click += uiButton1_Click;
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
    }
}