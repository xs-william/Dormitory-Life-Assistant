using Sunny.UI;
using Dormitory_Life_Assistant;

namespace SystemForm
{
    public partial class StudentForm : UIForm
    {
        public StudentForm()
        {
            InitializeComponent();
            //Student me应该是登陆界面传递下来的对象，表示用户
            //该参数需要一直传递
            Student me = new Student("1","蔡徐坤");
            Choice.TabControl = MainContainer;
            //增加页面到Main
            AddPage(new stuMain(), 1001);
            AddPage(new StuLifePay(), 1002);
            AddPage(new stuRepair(), 1003);
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
    }
}