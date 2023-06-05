using Dormitory_Life_Assistant;
using MySqlX.XDevAPI.Common;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemForm
{
    public partial class TComplaintForm : UIPage
    {
        public event Action<ComplaintChildForm> ShowChildForm;
        public ComplaintService complaintService { get; set; } = new ComplaintService();
        public TComplaintForm()
        {
            InitializeComponent();
            ComplaintDataGridView.DataSource = complaintService.getAll();
            ComplaintDataGridView.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            //在datagridview中添加button按钮
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnDetails";
            btn.HeaderText = "详情";
            btn.DefaultCellStyle.NullValue = "查看详情";
            ComplaintDataGridView.Columns.Add(btn);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
        }

        private void ComplaintButton_Click(object sender, EventArgs e)
        {
            switch (uiComboBox1.SelectedIndex)
            {
                case 0://所有投诉
                    ComplaintDataGridView.DataSource = complaintService.getAll();
                    break;
                case 1://按ID查询
                    ComplaintDataGridView.DataSource = complaintService.QueryByID(ComplaintIndex.Text);
                    break;
                case 2://按举报人查询
                    ComplaintDataGridView.DataSource = complaintService.QueryByInformer(ComplaintIndex.Text);
                    break;
                case 3://按状态查询
                    ComplaintDataGridView.DataSource = complaintService.QueryByStatus(ComplaintIndex.Text);
                    break;
            }
        }
        private void ComplaintDataGridView_DoubleClick(object sender, EventArgs e)
        {
        }

        private void ComplaintDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ComplaintDataGridView.Columns[e.ColumnIndex].Name == "btnDetails" && e.RowIndex >= 0)
            {
                using (var ctx = new SystemContext())
                {
                    string id = Convert.ToString(ComplaintDataGridView.CurrentRow.Cells[1].Value);
                    int ID = int.Parse(id);
                    var result = ctx.Complaints.SingleOrDefault(c => c.ComplaintID == ID);
                    ComplaintChildForm ccf = new ComplaintChildForm(result, this);
                    ccf.ShowDialog();
                }

            }
        }
    }
}
