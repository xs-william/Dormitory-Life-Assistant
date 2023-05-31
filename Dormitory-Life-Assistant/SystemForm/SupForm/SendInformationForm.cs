using Dormitory_Life_Assistant;
using Sunny.UI;

namespace SystemForm
{
    public partial class SendInformationForm : UIForm
    {
        private ExchangeMessage exchangeMessage;
        private DormMessage dormMessage;
        private Supervisor supervisor;
        private Student student;
        public SendInformationForm(Supervisor supervisor, Student student = null)
        {
            InitializeComponent();
            this.supervisor = supervisor;
            this.student = student;
        }
        public ExchangeMessage ExchangeMessage
        {
            get
            {
                if (exchangeMessage == null)
                {
                    exchangeMessage = new ExchangeMessage();
                }
                exchangeMessage.Content = uiTextBox1.Text;
                exchangeMessage.Time = DateTime.Now;
                exchangeMessage.SupervisorId = supervisor.SupervisorId;
                exchangeMessage.Supervisor = supervisor;
                exchangeMessage.StudentId = student.StudentId;
                exchangeMessage.Student = student;
                return exchangeMessage;
            }
        }
        public DormMessage DormMessage
        {
            get
            {
                if (dormMessage == null)
                {
                    dormMessage = new DormMessage();
                }
                dormMessage.Content = uiTextBox1.Text;
                dormMessage.Time = DateTime.Now;
                dormMessage.SupervisorId = supervisor.SupervisorId;
                dormMessage.Supervisor = supervisor;
                return dormMessage;
            }
        }
        private void okbutton_Click(object sender, EventArgs e)
        {
            ShowSuccessDialog("·¢ËÍ³É¹¦");
            this.Dispose();
        }
    }
}