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
        StudentService studentService;
        private Supervisor supervisor;
        MessageService messageService = new MessageService();
        public TStudentForm(Supervisor supervisor)
        {
            InitializeComponent();
            studentService = new StudentService();
            studentBindingSource.DataSource = studentService.getall();
            this.supervisor = supervisor;
            //绑定数据
        }
        // 查看学生详细信息
        public void QueryAll()
        {
            studentBindingSource.DataSource = studentService.getall();
            studentBindingSource.ResetBindings(false);
        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
            Student student = studentBindingSource.Current as Student;
            StudentChildForm scf = new StudentChildForm(student);
            scf.ShowDialog();
        }
        // 选择学生弹出提示框发送消息
        private void uiButton2_Click(object sender, EventArgs e)
        {
            Student student = studentBindingSource.Current as Student;
            if (student == null)
            {
                UIMessageBox.Show("请选择一个学生");
                return;
            }
            MessageEdit2 me = new MessageEdit2(supervisor, student);
            me.Text = "发送消息";
            me.uiLabel1.Text = "信息内容";
            me.ShowDialog();
            if (me.ExchangeMessage.Content != "")
            {
                messageService.SendExchangeMessage(me.ExchangeMessage);
            }
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {

            switch (uiComboBox1.SelectedIndex)
            {

                case 2://根据学号查询
                    studentBindingSource.DataSource = studentService.QueryStudentByID(StudentIndex.Text);
                    break;
                case 1://根据年级查询
                    studentBindingSource.DataSource = studentService.QueryStudentByGrade(StudentIndex.Text);
                    break;
                case 0://根据宿舍号查询
                    studentBindingSource.DataSource = studentService.QueryStudentByDorm(StudentIndex.Text);
                    break;
                case 3://根据姓名查询
                    studentBindingSource.DataSource = studentService.QueryStudentByName(StudentIndex.Text);
                    break;
                default:
                    QueryAll();
                    break;
            }
            studentBindingSource.ResetBindings(false);
        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentDataGridView.AutoGenerateColumns = false;
        }
    }
}
