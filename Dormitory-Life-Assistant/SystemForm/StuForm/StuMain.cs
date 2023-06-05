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
using Dormitory_Life_Assistant.Service;
using Sunny.UI;

namespace SystemForm
{
    public partial class stuMain : UIPage
    {
        private SystemMessageService systemMessageService = new SystemMessageService();
        private DormMessageService dormMessageService = new DormMessageService();

        public stuMain()
        {
            InitializeComponent();
            systemMessageBindingSource.DataSource = systemMessageService.SystemMessages;
            uiDataGridView1.AllowUserToAddRows = false;
        }

        private void dorm_Click(object sender, EventArgs e)
        {

        }

        private void panel_Click(object sender, EventArgs e)
        {

            dormMessageBindingSource.DataSource = dormMessageService.DormMessages;
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView2.AllowUserToAddRows = false;
            uiCalendar1.Date = Convert.ToDateTime(DateTime.Now.ToString("D"));

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Schedule form = new Schedule();

            form.ShowDialog();
        }
    }
}
