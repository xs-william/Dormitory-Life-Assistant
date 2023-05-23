namespace LifeHelper
{
    partial class TInformationForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            AddButton = new Sunny.UI.UIButton();
            DeleteButton = new Sunny.UI.UIButton();
            ChangeButton = new Sunny.UI.UIButton();
            SearchButton = new Sunny.UI.UIButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel1.Controls.Add(DeleteButton, 1, 0);
            tableLayoutPanel1.Controls.Add(ChangeButton, 0, 1);
            tableLayoutPanel1.Controls.Add(SearchButton, 1, 1);
            tableLayoutPanel1.Location = new Point(253, 32);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(528, 117);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Left;
            AddButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(3, 7);
            AddButton.MinimumSize = new Size(1, 1);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(186, 44);
            AddButton.TabIndex = 0;
            AddButton.Text = "发布宿舍通知";
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Left;
            DeleteButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(267, 7);
            DeleteButton.MinimumSize = new Size(1, 1);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(189, 44);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "删除宿舍信息";
            // 
            // ChangeButton
            // 
            ChangeButton.Anchor = AnchorStyles.Left;
            ChangeButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeButton.Location = new Point(3, 65);
            ChangeButton.MinimumSize = new Size(1, 1);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(186, 44);
            ChangeButton.TabIndex = 2;
            ChangeButton.Text = "修改宿舍信息";
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Left;
            SearchButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.Location = new Point(267, 65);
            SearchButton.MinimumSize = new Size(1, 1);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(186, 44);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "查询宿舍信息";
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(215, 192);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(538, 225);
            uiGroupBox1.TabIndex = 2;
            uiGroupBox1.Text = "宿舍通知";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // TInformationForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(uiGroupBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "TInformationForm";
            PageIndex = 1006;
            Text = "Message";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UIButton AddButton;
        private Sunny.UI.UIButton DeleteButton;
        private Sunny.UI.UIButton ChangeButton;
        private Sunny.UI.UIButton SearchButton;
        private Sunny.UI.UIGroupBox uiGroupBox1;
    }
}