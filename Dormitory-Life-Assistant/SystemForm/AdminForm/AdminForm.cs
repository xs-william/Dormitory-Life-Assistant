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
using Sunny.UI;

namespace SystemForm
{
    public partial class AdminForm : UIForm
    {
        //登录界面传来的administrator，为用户
        private Administrator administrator;
        public AdminForm(Administrator admin)
        {
            if (admin.AdministratorName == null)
            {
                AdminInformation adminInformation = new AdminInformation(admin);
                adminInformation.ShowDialog();
            }
            InitializeComponent();
            Choice.TabControl = MainContainer;
            this.administrator = admin;
            //增加页面到Main
            AddPage(new AdminMain(administrator), 2001);
            AddPage(new AdminStuManage(), 2002);
            AddPage(new AdminSuperManage(), 2003);
            AddPage(new AdminPunch(administrator), 2004);
            AddPage(new AdminNotice(administrator), 2005);
            AddPage(new AdminDorm(), 2006);


            //设置Header节点索引
            Choice.CreateNode("我的主页", 2001);
            Choice.CreateNode("学生管理", 2002);
            Choice.CreateNode("宿管管理", 2003);
            Choice.CreateNode("打卡管理", 2004);
            Choice.CreateNode("公告管理", 2005);
            Choice.CreateNode("宿舍楼管理", 2006);


            //显示默认界面
            Choice.SelectFirst();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            AdminInformation adminInformation = new AdminInformation(administrator);
            adminInformation.ShowDialog();
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
    }
}
