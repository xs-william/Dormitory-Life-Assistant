using Org.BouncyCastle.Asn1.X509;
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
using Dormitory_Life_Assistant.Service;


namespace SystemForm
{
    public partial class AdminPunch : UIPage
    {
        public static ClockInService clockInService = new ClockInService();
        public static ClockIn? clockIn;
        public static List<DateTime> dates = new List<DateTime>();
        public event Action<Blank> ShowEditForm;
        Administrator Administrator { get; set; }
        public AdminPunch(Administrator administrator)
        {
            InitializeComponent();
            ShowEditForm += (f => { });
            this.Administrator = administrator;
        }
        public List<Student> Students
        {
            get
            {
                using (var ctx = new SystemContext())
                {
                    return ctx.Students
                      .ToList<Student>();
                }
            }
        }
        private void uiButton2_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            string publisher = Administrator.AdministratorName; // 姓名参数
            string status = "否";
            List<Student> students = this.Students;
            for(int i = 0; i < students.Count; i++)
            {
                clockInService.pubilshClock(students[i].StudentId, students[i].StudentName, localDate, publisher, status); // 调用发布打卡信息的方法
            }
            
            clockIn = clockInService.context.ClockIns.OrderByDescending(c => c.ClockInID).FirstOrDefault();

            Blank formEdit = new Blank();
            
            formEdit.ShowDialog();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            switch (uiComboBox2.SelectedIndex)
            {
                case 0://根据学号查询
                    clockInBindingSource.DataSource = clockInService.QueryClockInsByID(uiTextBox2.Text);
                    break;
                case 1://根据姓名查询
                    clockInBindingSource.DataSource = clockInService.QueryClockInsByName(uiTextBox2.Text);
                    break;
                case 2://根据日期查询
                    clockInBindingSource.DataSource = clockInService.QueryClockInsByPublishtime(uiTextBox2.Text);
                    break;
            }
            clockInBindingSource.ResetBindings(false);
        }
    }
}
