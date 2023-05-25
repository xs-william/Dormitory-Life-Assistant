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
    public partial class TComplaintForm : UIPage
    {
        public TComplaintForm()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            ComplaintChildForm ccf = new ComplaintChildForm();
            ccf.ShowDialog();
        }
    }
}
