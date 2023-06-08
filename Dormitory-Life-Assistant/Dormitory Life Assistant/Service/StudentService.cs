using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant.Service
{
    public class StudentService
    {
        public StudentService()
        {
        }
        public List<Student> getall()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Students

                  .ToList<Student>();
            }

        }

        public void AddStudent(Student student)
        {
            using (var ctx = new SystemContext())
            {
                if (student == null) { return; }
                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }

        //查询是否存在该用户的头像
        public bool IsExistImage(string uploderId)
        {
            using (var ctx = new SystemContext())
            {
                var image = ctx.SaveImages
                    .SingleOrDefault(s => s.Uploader == uploderId);
                if (image == null) { return false; }
                return true;
            }
        }

        //删除学生的旧头像
        public void DeleteStuImage(string uploderId)
        {
            using (var ctx = new SystemContext())
            {
                var image = ctx.SaveImages
                    .SingleOrDefault(s => s.Uploader == uploderId);
                if (image != null)
                {
                    ctx.SaveImages.Remove(image);
                    ctx.SaveChanges();
                }
            }
        }

        public void DeleteStudent(Student stu)
        {
            using (var ctx = new SystemContext())
            {
                var student = ctx.Students
                    // .Include(s => s.Building) // 加载关联的宿舍楼栋
                    .SingleOrDefault(s => s.StudentId == stu.StudentId);

                if (student == null) return;
                // 从数据库中删除学生
                ctx.Students.Remove(student);

                ctx.SaveChanges();
            }
        }


        public void ModifyStudent(Student student)
        {
            DeleteStudent(student);
            AddStudent(student);
        }

        //通过宿舍号找所有学生
        public List<Student> QueryStudentByDormId(string dormId)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Students
                    .Where(s => s.DormNumber == dormId)
                    .ToList();
            }
        }

        public List<Student> QueryStudentByName(string name)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Students
                    .Where(s => s.StudentName == name)

                    .ToList<Student>();
            }
        }
        public List<Student> QueryStudentByClass(string classes)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Students
                    .Where(s => s.Class == classes)
                    .ToList<Student>();
            }
        }
        public List<Student> QueryStudentByDepartment(string department)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Students
                    .Where(s => s.Department == department)
                    .ToList<Student>();
            }
        }
        public List<Student> QueryStudentByID(string id)
        {
            using (var ctx = new SystemContext())
            {
                var result = ctx.Students
                    .Where(s => s.StudentId == id)
                    .ToList<Student>();
                return result;
            }
        }
    }
}
