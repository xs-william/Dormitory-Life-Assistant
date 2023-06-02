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
    public partial class AdminSuperManage : UIPage
    {
        SupervisorService supervisorService;
        public AdminSuperManage()
        {
            InitializeComponent();
            supervisorService = new SupervisorService();
            using (var ctx = new SystemContext())
            {
                if (ctx.Supervisors.Count() == 0)
                {
                    ctx.Supervisors.Add(new Supervisor("86978", "周华琼", "13518956282", "女", "86978", "信息学部国软C3"));
                    ctx.Supervisors.Add(new Supervisor("95423", "田子欣", "13645289563", "女", "95423", "信息学部国软C3"));
                    ctx.SaveChanges();
                }
            }
            supervisorBindingSource.DataSource = supervisorService.getall();
            uiComboBox1.SelectedIndex = 0;
            uiDataGridView1.AllowUserToAddRows = false;
        }

        public void QueryAll()
        {
            supervisorBindingSource.DataSource = supervisorService.getall();
            supervisorBindingSource.ResetBindings(false);
        }

        private void supQueryBotton_Click(object sender, EventArgs e)
        {
            switch (uiComboBox2.SelectedIndex)
            {

                case 1://根据工号查询
                    supervisorBindingSource.DataSource = supervisorService.QuerySupervisorByID(supQueryBox.Text);
                    break;

                case 2://根据宿舍名查询
                    supervisorBindingSource.DataSource = supervisorService.QuerySupervisorByBuildingName(supQueryBox.Text);
                    break;
                case 0://根据姓名查询
                    supervisorBindingSource.DataSource = supervisorService.QuerySupervisorByName(supQueryBox.Text);
                    break;
                default:
                    QueryAll();
                    break;
            }
            supervisorBindingSource.ResetBindings(false);
        }

        private void supDeleteButton_Click(object sender, EventArgs e)
        {
            Supervisor supervisor = supervisorBindingSource.Current as Supervisor;
            if (supervisor == null)
            {
                UIMessageBox.Show("请选择要修改的宿管");
            }
            if (supervisor != null)
            {
                UIMessageBox.Show("是否确认删除");
                supervisorService.DeleteSupervisor(supervisor);
                supervisorBindingSource.DataSource = supervisorService.getall();
            }
        }

        private void addSupButton_Click(object sender, EventArgs e)
        {

            SupervisorEdit supervisorEdit = new SupervisorEdit(new Supervisor(), supervisorService);
            supervisorEdit.titleBox.Text = "添加宿管";
            supervisorEdit.IDBox.Text = "";
            supervisorEdit.ShowDialog();
            QueryAll();
        }

        private void modifySupButton_Click(object sender, EventArgs e)
        {
            Supervisor supervisor=supervisorBindingSource.Current as Supervisor;

            if (supervisor == null)
            {
                UIMessageBox.Show("请选择一个宿管进行修改");
                return;
            }
            SupervisorEdit supervisorEdit = new SupervisorEdit(supervisor, supervisorService);
            supervisorEdit.titleBox.Text = "修改宿管信息";
            supervisorService.DeleteSupervisor(supervisor);
            supervisorEdit.ShowDialog();
            supervisorBindingSource.DataSource = supervisorService.getall();
        }
    }
}
