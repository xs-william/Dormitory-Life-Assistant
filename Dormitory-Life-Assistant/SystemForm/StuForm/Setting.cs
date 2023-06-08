using MySql.Data.MySqlClient;
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
using Microsoft.VisualBasic.Devices;

namespace SystemForm
{
    public partial class Setting : UIPage
    {
        int select;
        Student Student;
        Supervisor Supervisor;
        public Setting(Student student, int select = 1)
        {
            InitializeComponent();
            this.Student = student;
            this.select = select;
        }
        public Setting(Supervisor supervisor, int select = 2)
        {
            InitializeComponent();
            this.Supervisor = supervisor;
            this.select = select;
        }
        private void confirmpassword_TextChanged(object sender, EventArgs e)
        {
            if (newpassword.Text != null)
            {
                if (confirmpassword.Text != newpassword.Text)
                {
                    RemindLabel.Text = "两次输入的密码不相等，请重新输入";
                    RemindLabel.ForeColor = Color.Red;
                }
                else
                {
                    RemindLabel.Text = " ";
                }
            }

        }
        private void uiButton1_Click(object sender, EventArgs e)
        {

            if (newpassword.Text.Length == 0)
            {
                RemindLabel.Text = "请输入新密码";
                RemindLabel.ForeColor = Color.Red;
            }
            else if (confirmpassword.Text.Length == 0)
            {
                RemindLabel.Text = "请输入确认密码";
                RemindLabel.ForeColor = Color.Red;
            }
            else if (confirmpassword.Text != newpassword.Text)
            {
                RemindLabel.Text = "两次输入的密码不相等，请重新输入";
                RemindLabel.ForeColor = Color.Red;
            }
            else if (MessageBox.Show("确定更改？", "更改密码", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (select == 1)
                {
                    List<user> users = user.QueryStudentByusername(Student.StudentId);
                    users[0].studentpassword = newpassword.Text;
                    ModifyuserByusername(users[0]);
                }
                else
                {
                    List<user> users = user.QueryStudentByusername(Supervisor.SupervisorId);
                    users[0].tmainpassword = newpassword.Text;
                    ModifyuserByusername(users[0]);
                }
                RemindLabel.Text = "修改成功";
                RemindLabel.ForeColor = Color.Green;
            }

        }

        private async void uiButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定注销？", "注销账户", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (select == 1)
                {
                    using (var ctx = new SystemContext())
                    {
                        var auser = ctx.Users
                          .SingleOrDefault(s => s.studentusername == Student.StudentId);
                        if (auser == null) return;
                        ctx.Users.Remove(auser);
                        ctx.SaveChanges();
                    }
                }
                else
                {
                    using (var ctx = new SystemContext())
                    {
                        var auser = ctx.Users
                          .SingleOrDefault(s => s.tmainusername == Supervisor.SupervisorId);
                        if (auser == null) return;
                        ctx.Users.Remove(auser);
                        ctx.SaveChanges();
                    }
                }
                uiLabel4.Text = "注销成功";
                uiLabel4.ForeColor = Color.Green;
                await Task.Delay(1000);
                LogInForm logInForm = new LogInForm();
                logInForm.ShowDialog();
                //执行注销操作
            }
        }
        private void uiColorPicker1_Click(object sender, EventArgs e)
        {
            UIStyles.InitColorful(uiColorPicker1.Value, Color.White);
        }
        public void ModifyuserByusername(user users)
        {
            if (select == 1)
            {
                using (var ctx = new SystemContext())
                {
                    var auser = ctx.Users
                      .SingleOrDefault(s => s.studentusername == users.studentusername);
                    if (auser == null) return;
                    ctx.Users.Remove(auser);
                    ctx.SaveChanges();
                }
                using (var ctx = new SystemContext())
                {
                    ctx.Entry(users).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();
                }
            }
            else
            {
                using (var ctx = new SystemContext())
                {
                    var auser = ctx.Users
                      .SingleOrDefault(s => s.tmainusername == users.tmainusername);
                    if (auser == null) return;
                    ctx.Users.Remove(auser);
                    ctx.SaveChanges();
                }
                using (var ctx = new SystemContext())
                {
                    ctx.Entry(users).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();
                }
            }

        }
        private void uiButton3_Click(object sender, EventArgs e)
        {
            UIStyles.InitColorful(uiColorPicker1.Value, Color.White);
            uiButton3.Visible = true;
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                if (uiColorPicker1.Value == StudentForm.userColor)
                {
                    ShowInfoTip("主题颜色还没有更改！");
                    return;
                }
                UIStyles.InitColorful(StudentForm.userColor, Color.White);
                uiButton4.Visible = true;
            }
            else
            {
                if (uiColorPicker1.Value == StudentForm.userColor)
                {
                    ShowInfoTip("主题颜色还没有更改！");
                    return;
                }
                UIStyles.InitColorful(TMainForm.userColor, Color.White);
                uiButton4.Visible = true;
            }

        }
        private void uiButton5_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                List<user> users = user.QueryStudentByusername(Student.StudentId);
                if (users.Count > 0)
                {
                    users[0].usercolor = uiColorPicker1.Value.ToArgb().ToString();
                    ModifyuserByusername(users[0]);
                    StudentForm.userColor = uiColorPicker1.Value;
                    ShowSuccessDialog("提示", "颜色保存成功！", UIStyle.Colorful);
                }
                else
                {
                    ShowErrorDialog("找不到该用户！");
                }
            }
            else
            {
                List<user> users = user.QuerySupervisorByusername(Supervisor.SupervisorId);
                if (users.Count > 0)
                {
                    users[0].usercolor = uiColorPicker1.Value.ToArgb().ToString();
                    ModifyuserByusername(users[0]);
                    TMainForm.userColor = uiColorPicker1.Value;
                    ShowSuccessDialog("提示", "颜色保存成功！", UIStyle.Colorful);
                }
                else
                {
                    ShowErrorDialog("找不到该用户！");
                }
            }

        }
    }
}
