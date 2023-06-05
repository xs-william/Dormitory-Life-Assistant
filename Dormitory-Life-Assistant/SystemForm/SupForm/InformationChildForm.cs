using Dormitory_Life_Assistant;
using Sunny.UI;

namespace SystemForm
{
    public partial class InformationChildForm : UIForm
    {
        private DormMessage dormMessage;
        private DormMessageService dormMessageService = new DormMessageService();
        public InformationChildForm(DormMessage dormMessage)
        {
            InitializeComponent();
            this.dormMessage = dormMessage;
            nameLabel.Text = dormMessage.SupervisorName;
            timeLabel.Text = dormMessage.Time.ToString();
            contentLabel.Text = dormMessage.Content;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dormMessageService.DeleteDormMessage(dormMessage.DormMessageId);
            UIMessageBox.Show("É¾³ý³É¹¦");
            this.Close();
        }
    }
}