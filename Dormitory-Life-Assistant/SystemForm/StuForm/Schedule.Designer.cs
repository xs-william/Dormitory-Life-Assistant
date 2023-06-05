namespace SystemForm
{
    partial class Schedule
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
            memoTextBox = new TextBox();
            deadlineTextBox = new TextBox();
            addButton = new Button();
            memoListView = new ListView();
            deleteButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // memoTextBox
            // 
            memoTextBox.Location = new Point(152, 6);
            memoTextBox.Name = "memoTextBox";
            memoTextBox.Size = new Size(603, 30);
            memoTextBox.TabIndex = 0;
            // 
            // deadlineTextBox
            // 
            deadlineTextBox.Location = new Point(152, 40);
            deadlineTextBox.Name = "deadlineTextBox";
            deadlineTextBox.Size = new Size(300, 30);
            deadlineTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(10, 92);
            addButton.Name = "addButton";
            addButton.Size = new Size(156, 36);
            addButton.TabIndex = 2;
            addButton.Text = "添加备忘信息";
            addButton.Click += AddButton_Click;
            // 
            // memoListView
            // 
            memoListView.Location = new Point(10, 145);
            memoListView.Name = "memoListView";
            memoListView.Size = new Size(761, 231);
            memoListView.TabIndex = 3;
            memoListView.UseCompatibleStateImageBehavior = false;
            memoListView.View = View.Details;
            memoListView.Columns.Add("备忘信息", 400);
            memoListView.Columns.Add("截止时间", 200);
            memoListView.Columns.Add("是否过期", 100);
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(10, 382);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(154, 40);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "删除备忘信息";
            deleteButton.Click += DeleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 5;
            label1.Text = "备忘信息";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 43);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 6;
            label2.Text = "截止时间";
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(memoTextBox);
            Controls.Add(deadlineTextBox);
            Controls.Add(addButton);
            Controls.Add(memoListView);
            Controls.Add(deleteButton);
            Name = "Schedule";
            Text = "Schedule";
            Load += Schedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox memoTextBox;
        private TextBox deadlineTextBox;
        private Button addButton;
        private ListView memoListView;
        private Button deleteButton;
        private Label label1;
        private Label label2;
    }
}