using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace SystemForm
{
    public partial class AdminForm : UIForm
    {
        public AdminForm()
        {
            InitializeComponent();
            Choice.TabControl = MainContainer;
            //增加页面到Main
            AddPage(new AdminMain(), 2001);
            AddPage(new AdminStuManage(), 2002);
            AddPage(new AdminSuperManage(), 2003);
            AddPage(new AdminPunch(), 2004);
            AddPage(new AdminNotice(), 2005);
            AddPage(new AdminDorm(), 2006);


            //设置Header节点索引
            Choice.CreateNode("我的主页", 1001);
            Choice.CreateNode("学生管理", 2002);
            Choice.CreateNode("宿管管理", 2003);
            Choice.CreateNode("打卡管理", 2004);
            Choice.CreateNode("公告管理", 2005);
            Choice.CreateNode("宿舍楼管理", 2006);


            //显示默认界面
            Choice.SelectFirst();
        }
    }
}
