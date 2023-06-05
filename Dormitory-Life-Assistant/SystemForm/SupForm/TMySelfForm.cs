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
    public partial class TMySelfForm : UIPage
    {
        private SystemMessageService systemMessageService = new SystemMessageService();
        private DormMessageService dormMessageService = new DormMessageService();
        public TMySelfForm()
        {
            InitializeComponent();
            systemMessageBindingSource.DataSource = systemMessageService.SystemMessages;
            dormMessageBindingSource.DataSource = dormMessageService.DormMessages;
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView2.AllowUserToAddRows = false;
            uiCalendar1.Date = Convert.ToDateTime(DateTime.Now.ToString("D"));
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
