using Sunny.UI;

using Dormitory_Life_Assistant;
namespace SystemForm
{

    public partial class StudentChildForm : UIForm
    {
        Student student;
        public StudentChildForm(Student s)
        {
            this.student = s;
            InitializeComponent();
            nameBox.Text = student.StudentName;
            genderBox.Text = student.Gender;
            departmentBox.Text = student.Department;
            dormNumberBox.Text = student.DormNumber;
            idBox.Text = student.StudentId;
            classBox.Text = student.Class;
            buildingBox.Text = student.BuildingName;
        }
    }
}