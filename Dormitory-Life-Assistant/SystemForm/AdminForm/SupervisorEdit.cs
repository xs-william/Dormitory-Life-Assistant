using Sunny.UI;
using Dormitory_Life_Assistant;
using Dormitory_Life_Assistant.Service;

namespace SystemForm
{
    public partial class SupervisorEdit : UIForm
    {
        public Supervisor supervisor { get; set; }
        public SupervisorService supervisorService { get; set; }
        public SupervisorEdit(Supervisor supervisor, SupervisorService supervisorService)
        {
            InitializeComponent();
            this.supervisor = supervisor;
            this.supervisorService = supervisorService;
            if (supervisor != null)
            {
                IDBox.Text = supervisor.SupervisorID;
                nameBox.Text = supervisor.SupervisorName;
                genderBox.Text = supervisor.Gender;
                teleBox.Text = supervisor.Tele;
                passwordBox.Text = supervisor.Password;
                buildingNameBox.Text = supervisor.SupBuildingName;
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Supervisor newSup = new Supervisor(nameBox.Text, IDBox.Text, teleBox.Text, genderBox.Text, passwordBox.Text, buildingNameBox.Text);

            UIMessageBox.Show("是否确认您的操作");

            using (var ctx = new SystemContext())
            {
                var supervisor = ctx.Supervisors
                    .SingleOrDefault(s => s.SupervisorID == newSup.SupervisorID);

                if (supervisor == null)
                {

                    supervisorService.AddSupervisor(newSup);
                    UIMessageBox.Show("添加成功");
                    this.Close();
                }
                else
                {
                    UIMessageBox.Show("该学生已存在，请重新输入");
                }
            }
        }
    }
}