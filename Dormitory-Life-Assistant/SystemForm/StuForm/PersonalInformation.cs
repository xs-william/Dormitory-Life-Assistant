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
using Sunny.UI;

namespace SystemForm
{
    public partial class PersonalInformation : UIForm
    {
        Student stu;
        public PersonalInformation(Student stu)
        {
            InitializeComponent();
            this.stu = stu;
            if (stu.StudentName != null) uiTextBox1.Text = stu.StudentName;
            if (stu.Gender != null) uiTextBox2.Text = stu.Gender;
<<<<<<< HEAD
            if (stu.Grade != null) uiTextBox3.Text = stu.Grade.ToString();
=======
            if (stu.Grade != null) uiTextBox3.Text = stu.Grade;
>>>>>>> 412f730d5833914260fa72274ff6d8c62f4fd9c8
            if (stu.Class != null) uiTextBox4.Text = stu.Class;
            if (stu.Department != null) uiTextBox5.Text = stu.Department;
            if (stu.BuildingName != null) uiTextBox6.Text = stu.BuildingName;
            if (stu.DormNumber != null) uiTextBox7.Text = stu.DormNumber;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (uiTextBox1.Text.Length != 0)
            {
                stu.StudentName = uiTextBox1.Text;

                stu.Gender = uiTextBox2.Text;
<<<<<<< HEAD
                stu.Grade = uiTextBox3.Text.ToInt();
=======
                stu.Grade = uiTextBox3.Text;
>>>>>>> 412f730d5833914260fa72274ff6d8c62f4fd9c8
                stu.Class = uiTextBox4.Text;
                stu.Department = uiTextBox5.Text;
                stu.BuildingName = uiTextBox6.Text;
                stu.DormNumber = uiTextBox7.Text;

                using (var ctx = new SystemContext())
                {
                    var student = ctx.Students
                        .SingleOrDefault(s => s.StudentId == stu.StudentId);
                    if (student == null) return;
                    ctx.Students.Remove(student);
                    ctx.SaveChanges();
                }

                using (var ctx = new SystemContext())
                {
                    ctx.Entry(stu).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();
                }
                this.Close();
            }
            else
            {
                uiLabel1.ForeColor = Color.Red;
            }

        }
    }
}
