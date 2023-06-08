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

namespace SystemForm.SupForm
{
    public partial class SubmitCostForm : UIForm
    {
        Supervisor supervisor;

        public SubmitCostForm(Supervisor supervisor)
        {
            InitializeComponent();
            this.supervisor = supervisor;
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string selectDormId = uiTextBox1.Text;
            string selectMoney = uiTextBox2.Text;
            double selectMoney1 = double.Parse(selectMoney);
            string selectType = uiTextBox3.Text;

            StudentService studentService = new StudentService();
            List<Student> stu = studentService.QueryStudentByDormId(selectDormId);
            PaymentService paymentService = new PaymentService();

            foreach (Student student in stu)
            {
                paymentService.addBill(new Payment(0, selectMoney1, student.StudentId, selectType));
            }

            this.Close();
        }
    }
}
