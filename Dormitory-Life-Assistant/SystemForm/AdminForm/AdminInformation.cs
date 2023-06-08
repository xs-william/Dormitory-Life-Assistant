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
    public partial class AdminInformation : UIForm
    {
        Administrator Administrator;
        public AdminInformation(Administrator administrator)
        {
            InitializeComponent();
            this.Administrator = administrator;
            if (administrator.AdministratorName != null) { uiTextBox1.Text = administrator.AdministratorName; }
            if (administrator.Administratorgender != null) { uiTextBox2.Text = administrator.Administratorgender; }
            if (administrator.Administratorphone != null) uiTextBox3.Text = administrator.Administratorphone;
            if (administrator.Administratorpost != null) uiTextBox4.Text = administrator.Administratorpost;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

            if (uiTextBox1.Text.Length != 0)
            {
                Administrator.AdministratorName = uiTextBox1.Text;

                Administrator.Administratorgender = uiTextBox2.Text;
                Administrator.Administratorphone = uiTextBox3.Text;
                Administrator.Administratorpost = uiTextBox4.Text;


                using (var ctx = new SystemContext())
                {
                    var administrator = ctx.Administrators
                        .SingleOrDefault(s => s.AdministratorId == Administrator.AdministratorId);
                    if (administrator == null) return;
                    ctx.Administrators.Remove(administrator);
                    ctx.SaveChanges();
                }

                using (var ctx = new SystemContext())
                {
                    ctx.Entry(Administrator).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();
                }
                this.Close();
            }
            else
            {
                uiLabel1.ForeColor = Color.Red;
            }

        }
    }

}
