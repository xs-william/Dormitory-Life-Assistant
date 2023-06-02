using System.Drawing;
using Sunny.UI;

namespace SystemForm
{
    public partial class LogInForm : UIForm
    {
        public LogInForm()
        {
            InitializeComponent();


        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            char c = new char();
            if (PasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = c;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {


            if (StudentRadioButton.Checked)
            {
                this.Hide();
                StudentForm studentForm = new StudentForm();


                studentForm.ShowDialog();

                this.Dispose();
            }
            else if (TeacherRadioButton.Checked)
            {
                TMainForm tmain = new TMainForm();
                this.Hide();
                tmain.ShowDialog();

                //this.Hide();

            }
            else if (ManagerRadioButton3.Checked)
            {
                AdminForm admin = new AdminForm();
                this.Hide();
                admin.ShowDialog();
                //this.Hide();

            }
            else
            {
                //remindLabel.text = "’À∫≈≤ª¥Ê‘⁄ªÚ’À∫≈”Î√‹¬Î≤ª∆•≈‰";
                //remindlabel.forecolor = color.red;
                this.Close();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
    }
}