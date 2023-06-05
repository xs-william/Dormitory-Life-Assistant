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
using System.Data.Entity;

namespace SystemForm
{
    public partial class StuLifePay : UIPage
    {
        Student stu = new Student();
        PaymentService paymentService = new PaymentService();

        public StuLifePay(Student stu)
        {
            InitializeComponent();
            this.stu = stu;
            uiDataGridView1.DataSource = paymentService.getPaymentList(stu);//数据绑定
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uiDataGridView1.AutoGenerateColumns = false;
            if (e.ColumnIndex == uiDataGridView1.Columns["Confirm"].Index && e.RowIndex >= 0)
            {
                Payment payment = uiDataGridView1.Rows[e.RowIndex].DataBoundItem as Payment;

                if (payment != null)
                {
                    payment.Status = true;

                    using (var ctx = new SystemContext())
                    {
                        ctx.Entry(payment).State = EntityState.Modified;
                        ctx.SaveChanges();
                    }
                    uiDataGridView1.Refresh();
                }
            }
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            uiDataGridView1.DataSource = paymentService.getPaymentList(stu);
            uiDataGridView1.Refresh();
        }
    }
}
