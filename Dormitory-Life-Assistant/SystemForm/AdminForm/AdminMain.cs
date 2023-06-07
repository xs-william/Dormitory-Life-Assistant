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

namespace SystemForm
{
    public partial class AdminMain : UIPage
    {
        public AdminMain(Administrator administrator)
        {
            InitializeComponent();
            uiLabel1.Text = administrator.AdministratorName;
            phone.Text = administrator.Administratorphone;
            ID.Text = administrator.AdministratorId;
            major.Text = administrator.Administratorpost;
            sex.Text = administrator.Administratorgender;
        }
    }
}
