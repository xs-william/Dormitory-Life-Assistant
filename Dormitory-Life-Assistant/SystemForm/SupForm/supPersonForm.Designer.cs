namespace SystemForm
{
    partial class supPersonForm
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
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            nameBox = new Sunny.UI.UITextBox();
            idBox = new Sunny.UI.UITextBox();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            teleBox = new Sunny.UI.UITextBox();
            genderBox = new Sunny.UI.UITextBox();
            buildingBox = new Sunny.UI.UITextBox();
            uiButton1 = new Sunny.UI.UIButton();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(3, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(138, 51);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "姓名：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(3, 51);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(138, 51);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "工号：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.Location = new Point(3, 102);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(138, 51);
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "电话：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.Location = new Point(3, 153);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(138, 51);
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "性别：";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.Location = new Point(3, 204);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(138, 51);
            uiLabel5.TabIndex = 4;
            uiLabel5.Text = "管理楼栋：";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(148, 5);
            nameBox.Margin = new Padding(4, 5, 4, 5);
            nameBox.MinimumSize = new Size(1, 16);
            nameBox.Name = "nameBox";
            nameBox.Padding = new Padding(5);
            nameBox.ShowText = false;
            nameBox.Size = new Size(221, 41);
            nameBox.TabIndex = 5;
            nameBox.TextAlignment = ContentAlignment.MiddleLeft;
            nameBox.Watermark = "";
            // 
            // idBox
            // 
            idBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.Location = new Point(148, 56);
            idBox.Margin = new Padding(4, 5, 4, 5);
            idBox.MinimumSize = new Size(1, 16);
            idBox.Name = "idBox";
            idBox.Padding = new Padding(5);
            idBox.ShowText = false;
            idBox.Size = new Size(221, 41);
            idBox.TabIndex = 6;
            idBox.TextAlignment = ContentAlignment.MiddleLeft;
            idBox.Watermark = "";
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 2;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.8739929F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.1260071F));
            uiTableLayoutPanel1.Controls.Add(uiLabel5, 0, 4);
            uiTableLayoutPanel1.Controls.Add(idBox, 1, 1);
            uiTableLayoutPanel1.Controls.Add(nameBox, 1, 0);
            uiTableLayoutPanel1.Controls.Add(uiLabel3, 0, 2);
            uiTableLayoutPanel1.Controls.Add(uiLabel2, 0, 1);
            uiTableLayoutPanel1.Controls.Add(uiLabel1, 0, 0);
            uiTableLayoutPanel1.Controls.Add(uiLabel4, 0, 3);
            uiTableLayoutPanel1.Controls.Add(teleBox, 1, 2);
            uiTableLayoutPanel1.Controls.Add(genderBox, 1, 3);
            uiTableLayoutPanel1.Controls.Add(buildingBox, 1, 4);
            uiTableLayoutPanel1.Location = new Point(66, 83);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 5;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            uiTableLayoutPanel1.Size = new Size(373, 255);
            uiTableLayoutPanel1.TabIndex = 7;
            uiTableLayoutPanel1.TagString = null;
            // 
            // teleBox
            // 
            teleBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teleBox.Location = new Point(148, 107);
            teleBox.Margin = new Padding(4, 5, 4, 5);
            teleBox.MinimumSize = new Size(1, 16);
            teleBox.Name = "teleBox";
            teleBox.Padding = new Padding(5);
            teleBox.ShowText = false;
            teleBox.Size = new Size(221, 41);
            teleBox.TabIndex = 7;
            teleBox.TextAlignment = ContentAlignment.MiddleLeft;
            teleBox.Watermark = "";
            // 
            // genderBox
            // 
            genderBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genderBox.Location = new Point(148, 158);
            genderBox.Margin = new Padding(4, 5, 4, 5);
            genderBox.MinimumSize = new Size(1, 16);
            genderBox.Name = "genderBox";
            genderBox.Padding = new Padding(5);
            genderBox.ShowText = false;
            genderBox.Size = new Size(221, 41);
            genderBox.TabIndex = 8;
            genderBox.TextAlignment = ContentAlignment.MiddleLeft;
            genderBox.Watermark = "";
            // 
            // buildingBox
            // 
            buildingBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buildingBox.Location = new Point(148, 209);
            buildingBox.Margin = new Padding(4, 5, 4, 5);
            buildingBox.MinimumSize = new Size(1, 16);
            buildingBox.Name = "buildingBox";
            buildingBox.Padding = new Padding(5);
            buildingBox.ShowText = false;
            buildingBox.Size = new Size(221, 41);
            buildingBox.TabIndex = 9;
            buildingBox.TextAlignment = ContentAlignment.MiddleLeft;
            buildingBox.Watermark = "";
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(285, 364);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(150, 52);
            uiButton1.TabIndex = 8;
            uiButton1.Text = "确认修改";
            // 
            // supPersonForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(uiButton1);
            Controls.Add(uiTableLayoutPanel1);
            Name = "supPersonForm";
            Text = "完善信息";
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox nameBox;
        private Sunny.UI.UITextBox idBox;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UITextBox teleBox;
        private Sunny.UI.UITextBox genderBox;
        private Sunny.UI.UITextBox buildingBox;
        private Sunny.UI.UIButton uiButton1;
    }
}