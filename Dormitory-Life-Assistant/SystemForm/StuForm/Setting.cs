using Sunny.UI;
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
    public partial class Setting : UIPage
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定更改？", "更改密码", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //执行更改密码
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定注销？", "注销账户", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //执行注销操作
            }
        }
    }
}
