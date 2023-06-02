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
using Dormitory_Life_Assistant;

namespace SystemForm
{
    public partial class TCostForm : UIPage
    {
        Supervisor sup = new Supervisor();
        PaymentService paymentService = new PaymentService();
        string selectedData;//用来作为选定的行的值

        public TCostForm(Supervisor sup)
        {
            InitializeComponent();
            this.sup = sup;
            CostDataGridView.DataSource = paymentService.getAll();
        }

        private void CostDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 检查是否点击的是行头
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = CostDataGridView.Rows[e.RowIndex];
                selectedData = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            CostChildForm ccf = new CostChildForm(selectedData);
            ccf.ShowDialog();
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CostButton_Click(object sender, EventArgs e)
        {
            PaymentService paymentService = new PaymentService();
            List<Payment> result = paymentService.getPaymentListByDorm(CostIndex.Text);
            /*if (result.Count != 0)
            {
                CostDataGridView.DataSource = result;
            }
            //如果未查询到，则仍然显示所有缴费信息
            else { CostDataGridView.DataSource = paymentService.getAll(); }*/

            //如果未查询到，则仍然显示所有缴费信息
            CostDataGridView.DataSource = (result.Count == 0) ? CostDataGridView.DataSource = paymentService.getAll() : CostDataGridView.DataSource = result;

            CostDataGridView.Refresh();
        }

        private void CostIndex_TextChanged(object sender, EventArgs e)
        {

        }

        //刷新按钮
        private void uiButton2_Click(object sender, EventArgs e)
        {
            CostDataGridView.DataSource = paymentService.getAll();
            CostDataGridView.Refresh();
        }
    }
}
