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
            RemindLabel.Text = "’À∫≈≤ª¥Ê‘⁄ªÚ’À∫≈”Î√‹¬Î≤ª∆•≈‰";
            RemindLabel.ForeColor = Color.Red;
        }
    }
}