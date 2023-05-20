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
    public partial class StuComplaint : UIPage
    {
        public StuComplaint()
        {
            InitializeComponent();

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            StuComplaintSon stuComplaintSon = new StuComplaintSon();
            try
            {
                if (stuComplaintSon.ShowDialog() == DialogResult.OK)
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
