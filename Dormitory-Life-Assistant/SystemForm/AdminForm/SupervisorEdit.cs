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
                IDBox.Text = supervisor.SupervisorId;
                nameBox.Text = supervisor.SupervisorName;
                genderBox.Text = supervisor.Gender;
                teleBox.Text = supervisor.Tele;
                passwordBox.Text = supervisor.Password;
                buildingNameBox.Text = supervisor.SupBuildingName;
            }
        }

        public bool checkSupervisor(Supervisor sup)
        {
            if (sup.SupervisorId != "" && sup.Password!= "" && sup.SupervisorName != "" && sup.Gender != "" &&
                sup.SupBuildingName != "" && sup.Tele != "" ) { return true; }
            return false;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Supervisor newSup = new Supervisor(nameBox.Text, IDBox.Text, teleBox.Text, genderBox.Text, passwordBox.Text, buildingNameBox.Text);

            UIMessageBox.Show("是否确认您的操作");

            int count = 0;
            using (var ctx = new SystemContext())
            {
                var supervisor = ctx.Supervisors
                    .Where(s => s.SupervisorId == newSup.SupervisorId)
                    .ToList();
                count=supervisor.Count;

            }
            if (count==0)
            {
                if (checkSupervisor(newSup))
                {
                    supervisorService.AddSupervisor(newSup);
                    UIMessageBox.Show("添加成功");
                    this.Close();
                }
                else
                {
                    UIMessageBox.Show("宿管信息不允许有空值，请重新输入");
                }
            }
            else
            {
                UIMessageBox.Show("该宿管已存在，请重新输入");
            }
        }
    }
}