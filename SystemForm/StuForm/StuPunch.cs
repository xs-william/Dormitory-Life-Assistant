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
        public StuPunch()
        {
            InitializeComponent();
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
            }
        }
    }
}
