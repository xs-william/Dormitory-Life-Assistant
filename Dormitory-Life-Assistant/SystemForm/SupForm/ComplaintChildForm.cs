using Sunny.UI;
using Dormitory_Life_Assistant;
namespace SystemForm
{
    public partial class ComplaintChildForm : UIForm
    {
        Complaint complaint { get; set; }
        ComplaintService complaintservice { get; set; } = new ComplaintService();
        TComplaintForm tComplaintForm { get; set; }
        public ComplaintChildForm()
        {
            InitializeComponent();
        }
        public ComplaintChildForm(Complaint complaint, TComplaintForm tComplaintForm)
        {
            InitializeComponent();
            this.complaint = complaint;
            informerLabel.Text = complaint.informer;
            TimeLabel.Text = complaint.ComplaintTime.ToString();
            statusLabel.Text = complaint.status;
            contentTextBox.Text = complaint.Content;
            this.tComplaintForm = tComplaintForm;
        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            complaintservice.RemoveComplaint(complaint);
            this.Close();
            tComplaintForm.ComplaintDataGridView.DataSource = complaintservice.getAll();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Complaint newcomplaint = new Complaint(complaint.ComplaintID, contentTextBox.Text, complaint.informer, complaint.ComplaintTime, complaint.status);
            complaintservice.UpdateComplaint(newcomplaint);
            this.Close();
            tComplaintForm.ComplaintDataGridView.DataSource = complaintservice.getAll();
        }
    }
}