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
using Dormitory_Life_Assistant;

namespace SystemForm
{
    public partial class Supinformation : UIForm
    {
        Supervisor Supervisor;
        public Supinformation(Supervisor supervisor)
        {
            InitializeComponent();
            this.Supervisor = supervisor;
            if (supervisor.SupervisorName != null) uiTextBox1.Text = supervisor.SupervisorName;
            if (supervisor.Gender != null) uiTextBox2.Text = supervisor.Gender;
            
            if (supervisor.Tele != null) uiTextBox4.Text = supervisor.Tele;
            if (supervisor.SupBuildingName != null) uiTextBox5.Text = supervisor.SupBuildingName;

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Supervisor.SupervisorName = uiTextBox1.Text;

            Supervisor.Gender = uiTextBox2.Text;
        
            Supervisor.Tele = uiTextBox4.Text;
            Supervisor.SupBuildingName = uiTextBox5.Text;


            using (var ctx = new SystemContext())
            {
                var supervisor = ctx.Supervisors
                    .SingleOrDefault(s => s.SupervisorId == Supervisor.SupervisorId);
                if (supervisor == null) return;
                ctx.Supervisors.Remove(supervisor);
                ctx.SaveChanges();
            }

            using (var ctx = new SystemContext())
            {
                ctx.Entry(Supervisor).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
            }
            this.Close();
        }
    }
}
