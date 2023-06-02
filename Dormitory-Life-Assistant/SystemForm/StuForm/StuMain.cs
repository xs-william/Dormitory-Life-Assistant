using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dormitory_Life_Assistant.Service;
using Sunny.UI;

namespace SystemForm
{
    public partial class stuMain : UIPage
    {
        private SystemMessageService systemMessageService = new SystemMessageService();
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

        }
    }
}
