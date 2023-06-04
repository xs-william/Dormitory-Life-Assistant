using Dormitory_Life_Assistant;
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
using Dormitory_Life_Assistant;

namespace SystemForm
{
    public partial class StuRepairSon : UIForm
    {
        Student stu;
        public StuRepairSon(Student stu)
        {
            InitializeComponent();
            this.stu = stu;
            uiAvatar1.FillColor = Color.Transparent;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Repair r = new Repair(0, uiTextBox1.Text, stu.StudentId);
            if (r != null)
            {
                RepairServicce repairServicce = new RepairServicce();
                repairServicce.addRepair(r);
            }
            this.Close();//点击提交后关闭界面
        }
    }
}
