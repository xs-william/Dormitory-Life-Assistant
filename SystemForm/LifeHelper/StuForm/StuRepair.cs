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

namespace LifeHelper
{
    public partial class stuRepair : UIPage
    {
        public stuRepair()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            StuRepairSon stuRepairSon = new StuRepairSon();
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
    }
}
