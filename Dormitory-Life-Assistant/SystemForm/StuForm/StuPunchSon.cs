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
    public partial class StuPunchSon : UIForm
    {
        public StuPunchSon()
        {
            InitializeComponent();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
        public static DateTime nowtime;
        private async void uiButton2_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            // 将当前时间设置到DataGridView的特定单元格（第一行第四列）
            nowtime = currentTime;
            Blank2 formEdit = new Blank2();
            formEdit.Show();

            await Task.Delay(1000); // 等待1秒钟

            formEdit.Close();

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            uiTextBox1.Text = "在校";
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}