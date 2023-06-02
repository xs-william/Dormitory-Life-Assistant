using Sunny.UI;
using Dormitory_Life_Assistant;

namespace SystemForm
{
    public partial class StudentForm : UIForm
    {
        //Student me应该是登陆界面传递下来的对象，表示用户
        //该参数需要一直传递
        Student me;
        public StudentForm(Student stu)
        {
            InitializeComponent();
            //先创建一个学生对象用来测试,先往数据库里存一个宿舍用来测试
            //Student stu = new Student("2021302111113", "C4-308");
            /*using (var ctx = new SystemContext())
            {
                ctx.Dorms.Add(new Dorm("C4-308"));
                ctx.SaveChanges();
            }*/

            Choice.TabControl = MainContainer;
            me = stu;
            //增加页面到Main
            AddPage(new stuMain(), 1001);
            AddPage(new StuLifePay(stu), 1002);
            AddPage(new stuRepair(stu), 1003);
            AddPage(new StuTreeHole(), 1004);
            AddPage(new StuPunch(), 1005);
            AddPage(new StuMessage(me), 1006);
            AddPage(new StuComplaint(), 1008);
            AddPage(new Setting(), 1009);


            //设置Header节点索引
            Choice.CreateNode("我的主页", 1001);
            Choice.CreateNode("生活缴费", 1002);
            Choice.CreateNode("故障报修", 1003);
            Choice.CreateNode("树洞", 1004);
            Choice.CreateNode("打卡", 1005);
            Choice.CreateNode("消息", 1006);
            Choice.CreateNode("投诉举报", 1008);
            Choice.CreateNode("用户设置", 1009);


            //显示默认界面
            Choice.SelectFirst();
        }


        private void uiButton1_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.ShowDialog();



        }
    }
}