using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemForm
{
    public partial class StuComplaintSon : UIForm
    {
        public StuComplaintSon()
        {
            InitializeComponent();
            uiAvatar1.FillColor = Color.Transparent;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
