using Sunny.UI;
using Dormitory_Life_Assistant;
using MySql.Data.MySqlClient;
using System.Data;

namespace SystemForm
{
    public partial class StudentForm : UIForm
    {
        //Student me应该是登陆界面传递下来的对象，表示用户
        //该参数需要一直传递
        Student me;
        public static Color userColor = System.Drawing.ColorTranslator.FromHtml("-2461550");
        public StudentForm(Student stu)
        {
            if (stu.StudentName == null)
            {
                PersonalInformation personalInformation = new PersonalInformation(stu);
                personalInformation.ShowDialog();
            }
            InitializeComponent();
            //先创建一个学生对象用来测试,先往数据库里存一个宿舍用来测试
            //Student stu = new Student("2021302111113", "C4-308");
            /*using (var ctx = new SystemContext())
            {
                ctx.Dorms.Add(new Dorm("C4-308"));
                ctx.SaveChanges();
            }*/

            //创建一个student类用来测试
            //me = new Student("302"/*, "C4-308"*/);

            Choice.TabControl = MainContainer;
            this.me = stu;
            //增加页面到Main
            AddPage(new stuMain(me), 1001);
            AddPage(new StuLifePay(me), 1002);
            AddPage(new stuRepair(me), 1003);
            AddPage(new StuTreeHole(), 1004);
            AddPage(new StuPunch(me), 1005);
            AddPage(new StuMessage(me), 1006);
            AddPage(new StuComplaint(me), 1008);
            AddPage(new Setting(me, 1), 1009);


            //设置Header节点索引
            Choice.CreateNode("我的主页", 1001);
            Choice.CreateNode("生活缴费", 1002);
            Choice.CreateNode("故障报修", 1003);
            //Choice.CreateNode("树洞", 1004);
            Choice.CreateNode("打卡", 1005);
            Choice.CreateNode("消息", 1006);
            Choice.CreateNode("投诉举报", 1008);
            Choice.CreateNode("用户设置", 1009);


            //显示默认界面
            Choice.SelectFirst();



        }


        private void uiButton1_Click(object sender, EventArgs e)
        {
            PersonalInformation personalInformation = new PersonalInformation(me);
            personalInformation.ShowDialog();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm loginForm = new LogInForm();
            loginForm.Show();
        }

        private void uiHeaderButton1_Click(object sender, EventArgs e)
        {
            if (ShowAskDialog("提示！", $"是否确认退出程序？", UIStyle.Colorful))
            {
                Environment.Exit(0);
            }
            else
            {
                ShowSuccessTip("已取消");
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            string id = me.StudentId;
            List<user> list = user.QueryStudentByusername(me.StudentId);
            string color_string;
            if (list[0].usercolor == null) { color_string = null; }
            else color_string = list[0].usercolor;
            userColor = (color_string == null) ? (Color.FromArgb(80, 160, 255)) : System.Drawing.ColorTranslator.FromHtml(color_string);
            UIStyles.InitColorful(StudentForm.userColor, Color.White);
        }
    }
}