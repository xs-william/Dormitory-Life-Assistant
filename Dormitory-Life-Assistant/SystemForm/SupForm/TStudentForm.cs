using Dormitory_Life_Assistant;
using Dormitory_Life_Assistant.Service;
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
    public partial class TStudentForm : UIPage
    {
        private Supervisor supervisor;
        MessageService messageService = new MessageService();
        public TStudentForm(Supervisor supervisor)
        {
            InitializeComponent();
            this.supervisor = supervisor;
            //绑定数据
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            StudentChildForm scf = new StudentChildForm();
            scf.ShowDialog();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Student student = studentBindingSource.Current as Student;
            if (student == null)
            {
                UIMessageBox.Show("请选择一个学生");
                return;
            }
            MessageEdit2 me = new MessageEdit2(supervisor, student);
            me.uiLabel1.Text = "信息内容";
            me.ShowDialog();
            messageService.SendExchangeMessage(me.ExchangeMessage);
        }
    }
}
