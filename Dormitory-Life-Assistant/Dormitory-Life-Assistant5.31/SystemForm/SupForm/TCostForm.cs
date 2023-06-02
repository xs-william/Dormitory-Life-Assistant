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
    public partial class TCostForm : UIPage
    {
        public TCostForm()
        {
            InitializeComponent();
        }

        private void CostDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            CostChildForm ccf = new CostChildForm();
            ccf.ShowDialog();
        }
    }
}
