using Dormitory_Life_Assistant;
using Sunny.UI;

namespace SystemForm

{
    public partial class TMainForm : UIForm
    {
        // supervisor是登录进来的supervisor需要一直作为参数传给所有界面
        private Supervisor supervisor;
        public static Color userColor = System.Drawing.ColorTranslator.FromHtml("-2461550");
        public TMainForm(Supervisor supervisor)
        {
            InitializeComponent();
            this.supervisor = supervisor;
            Choice.TabControl = MainContainer;
            //增加页面到Main
            AddPage(new TMySelfForm(), 1001);
            AddPage(new TStudentForm(supervisor), 1002);
            AddPage(new TBreakdownForm(supervisor), 1003);
            AddPage(new TCostForm(supervisor), 1004);
            AddPage(new TComplaintForm(), 1005);
            AddPage(new TInformationForm(supervisor), 1006);
            AddPage(new Setting(supervisor, 2), 1007);



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

        private void TMainForm_Load(object sender, EventArgs e)
        {
            string id = supervisor.SupervisorId;
            List<user> list = user.QuerySupervisorByusername(supervisor.SupervisorId);
            string color_string;
            if (list[0].usercolor == null) { color_string = null; }
            else color_string = list[0].usercolor;
            userColor = (color_string == null) ? (Color.FromArgb(80, 160, 255)) : System.Drawing.ColorTranslator.FromHtml(color_string);
            UIStyles.InitColorful(TMainForm.userColor, Color.White);
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
    }
}