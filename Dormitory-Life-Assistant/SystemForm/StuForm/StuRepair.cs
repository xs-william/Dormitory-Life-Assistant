using Dormitory_Life_Assistant;
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
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity;

namespace SystemForm
{
    public partial class stuRepair : UIPage
    {
        RepairServicce repairServicce = new RepairServicce();
        Student stu;
        public stuRepair(Student stu)
        {
            InitializeComponent();
            this.stu = stu;
            uiDataGridView1.DataSource = repairServicce.getRepairList(stu);//数据绑定
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            StuRepairSon stuRepairSon = new StuRepairSon(stu);
            try
            {
                if (stuRepairSon.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uiDataGridView1.AutoGenerateColumns = false;
            if (e.ColumnIndex == uiDataGridView1.Columns["Confirm"].Index && e.RowIndex >= 0)
            {
                Repair repair = uiDataGridView1.Rows[e.RowIndex].DataBoundItem as Repair;

                if (repair != null)
                {
                    repair.Status = true;

                    using (var ctx = new SystemContext())
                    {
                        ctx.Entry(repair).State = EntityState.Modified;
                        ctx.SaveChanges();
                    }
                    uiDataGridView1.Refresh();
                }
            }
            /*RepairServicce repairServicce = new RepairServicce();
            List<Repair> repairs = new List<Repair>();
            repairs = repairServicce.searchBill(stu.DormNumber);
            if (repairs.Count == 0)
            {
                throw new Exception("未找到数据");
            }
            uiDataGridView1.DataSource = repairs;
            this.uiDataGridView1.AutoGenerateColumns = false;
            uiDataGridView1.Columns["报修内容"].DataPropertyName = "Content";
            uiDataGridView1.Columns["提交时间"].DataPropertyName = "RepairTime";
            uiDataGridView1.Columns["状态"].DataPropertyName = "Status";

            uiDataGridView1.Refresh();*/
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            uiDataGridView1.DataSource = repairServicce.getRepairList(stu);
            uiDataGridView1.Refresh();
        }
    }
}
