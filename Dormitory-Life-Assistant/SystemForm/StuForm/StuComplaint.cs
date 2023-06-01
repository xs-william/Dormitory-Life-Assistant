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
    public partial class StuComplaint : UIPage
    {
        public Student CurrentStudent { get; set; }
        public ComplaintService complaintService { get; set; } = new ComplaintService();
        public StuComplaint(Student student)
        {
            InitializeComponent();
            CurrentStudent = student;
            uiDataGridView1.DataSource = complaintService.getComplaint(student);
            uiDataGridView1.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            //在datagridview中添加button按钮
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnComplete";
            btn.HeaderText = "是否完成";
            btn.DefaultCellStyle.NullValue = "已完成";
            uiDataGridView1.Columns.Add(btn);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            StuComplaintSon stuComplaintSon = new StuComplaintSon(CurrentStudent, this);

            try
            {
                if (stuComplaintSon.ShowDialog() == DialogResult.OK)
                {

                    //bdsComplaints.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (uiDataGridView1.Columns[e.ColumnIndex].Name == "btnComplete" && e.RowIndex >= 0)
            {
                    Complaint complaint=new Complaint();
                    string id = Convert.ToString(uiDataGridView1.CurrentRow.Cells[1].Value);
                    int ID = int.Parse(id);
                    complaint.ID = ID;
                    complaint.Content= Convert.ToString(uiDataGridView1.CurrentRow.Cells[3].Value);
                    complaint.informer = Convert.ToString(uiDataGridView1.CurrentRow.Cells[4].Value);
                    complaint.ComplaintTime = Convert.ToDateTime(uiDataGridView1.CurrentRow.Cells[5].Value);
                    complaintService.RemoveComplaint(complaint);
                    uiDataGridView1.DataSource = complaintService.getComplaint(CurrentStudent);
            }
            
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            uiDataGridView1.DataSource = complaintService.getComplaint(CurrentStudent);
        }
    }
}
