using Sunny.UI;

namespace SystemForm

{
    public partial class TMainForm : UIForm
    {
        public TMainForm()
        {
            InitializeComponent();

            Choice.TabControl = MainContainer;
            //增加页面到Main
            AddPage(new TMySelfForm(), 1001);
            AddPage(new TStudentForm(), 1002);
            AddPage(new TBreakdownForm(), 1003);
            AddPage(new TCostForm(), 1004);
            AddPage(new TComplaintForm(), 1005);
            AddPage(new TInformationForm(), 1006);
            AddPage(new Setting(), 1007);



            //设置Header节点索引
            Choice.CreateNode("我的信息", 1001);
            Choice.CreateNode("学生信息", 1002);
            Choice.CreateNode("故障信息", 1003);
            Choice.CreateNode("欠费信息", 1004);
            Choice.CreateNode("举报信息", 1005);
            Choice.CreateNode("通知管理", 1006);
            Choice.CreateNode("用户设置", 1007);



            //显示默认界面
            Choice.SelectFirst();
        }
    }
}