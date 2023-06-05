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
    public partial class TBreakdownForm : UIPage
    {
        Supervisor sup = new Supervisor();
        RepairServicce repairServicce = new RepairServicce();
        int selectedRepairId;//用来作为选定的宿舍号

        public TBreakdownForm(Supervisor sup)
        {
            InitializeComponent();
            this.sup = sup;
            BreakdownDataGridView.DataSource = repairServicce.getAll();
        }

        private void BreakdownDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BreakdownDataGridView.AutoGenerateColumns = false;
            // 检查是否点击的是行头
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = BreakdownDataGridView.Rows[e.RowIndex];
                selectedRepairId = selectedRow.Cells[4].Value.ToString().ToInt();

            }
        }

        /*private void DetailButton_Click(object sender, EventArgs e)
        {
            BreakdownChildForm bcf = new BreakdownChildForm();
            bcf.ShowDialog();
        }*/

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BreakdownIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BreakdownButton_Click(object sender, EventArgs e)
        {
            RepairServicce repairServicce = new RepairServicce();
            List<Repair> result = repairServicce.getRepairListByDormID(BreakdownIndex.Text);
            /*if (result.Count == 0)
            {
                throw new Exception("cuowu");
            }*/
            BreakdownDataGridView.DataSource = result;
            BreakdownDataGridView.Refresh();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            BreakdownChildForm breakdownChildForm = new BreakdownChildForm(selectedRepairId);
            try
            {
                if (breakdownChildForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
