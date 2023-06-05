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
using Dormitory_Life_Assistant;

namespace SystemForm
{
    public partial class StuComplaintSon : UIForm
    {
        public Complaint complaint { get; set; }
        public Student student { get; set; }
        public ComplaintService complaintService { get; set; } = new ComplaintService();
        public Complaint CurrentComplaint { get; set; }
        public StuComplaint stuComplaint { get; set; }

        public StuComplaintSon(Student student, StuComplaint stuComplaint)
        {
            InitializeComponent();
            uiAvatar1.FillColor = Color.Transparent;
            this.student = student;
            this.stuComplaint = stuComplaint;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            int index = 0;
            complaint = new Complaint(index, uiTextBox1.Text, student.StudentName, DateTime.Now, "未解决");
            complaintService.addComplaint(complaint);
            this.Close();
            stuComplaint.uiDataGridView1.DataSource = complaintService.getComplaint(student);
        }
    }
}
