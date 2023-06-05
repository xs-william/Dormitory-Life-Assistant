using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemForm
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            // 获取备忘信息和截止时间
            string memo = memoTextBox.Text;
            string deadline = deadlineTextBox.Text;
            string isoutdate = "未过期";

            // 创建新的备忘信息项
            ListViewItem item = new ListViewItem(new string[] { memo, deadline, isoutdate });

            // 检查截止时间是否已过期
            DateTime deadlineDateTime;
            if (DateTime.TryParse(deadline, out deadlineDateTime) && deadlineDateTime < DateTime.Now)
            {
                item.BackColor = Color.Red; // 设置已过期项的背景色为红色
                item.SubItems[2].Text = "已过期";
            }

            // 添加备忘信息项到列表
            memoListView.Items.Add(item);

        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // 检查是否有选中的备忘信息项
            if (memoListView.SelectedItems.Count > 0)
            {
                // 删除选中的备忘信息项
                memoListView.SelectedItems[0].Remove();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
