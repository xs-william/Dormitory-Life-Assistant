using Dormitory_Life_Assistant;
using Dormitory_Life_Assistant.Service;
using Microsoft.VisualBasic.Devices;
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
    public partial class StuPunch : UIPage
    {
        public ClockInService clockInService = new ClockInService();
        public StuPunch()
        {
            InitializeComponent();
            clockInBindingSource.DataSource = clockInService.clockIns;
            uiDataGridView1.AllowUserToAddRows = false;
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //uiDataGridView1.Rows.Add(AdminPunch.clockIn.publishtime, AdminPunch.clockIn.publisher, "是", null, null);


            //点击button按钮事件
            if (uiDataGridView1.Columns[e.ColumnIndex].Name == "Punch" && e.RowIndex >= 0)
            {
                StuPunchSon stuPunchSon = new StuPunchSon();
                try
                {
                    if (stuPunchSon.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }

                ClockIn clockIn = clockInBindingSource.Current as ClockIn;
                if (clockIn == null)
                {
                    MessageBox.Show("请选择一个系统消息进行修改");
                    return;
                }
                clockInService.ModifyClockIn(clockInService.submitClock(clockIn, StuPunchSon.nowtime));
                clockInBindingSource.DataSource = clockInService.clockIns;
                clockInBindingSource.ResetBindings(true);

                //uiDataGridView1.Rows[0].Cells[3].Value = StuPunchSon.nowtime.ToString();
                //uiDataGridView1.Rows[0].Cells[2].Value = "是".ToString();
            }
        }
    }
}
