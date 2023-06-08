using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class user
    {
        [Key]
        public Guid Id { get; set; }
       
        public string studentusername { get; set; }
        public string studentpassword { get; set; }
        public string adminusername { get; set; }
        public string adminpassword { get; set; }
        public string tmainusername { get; set; }
        public string tmainpassword { get; set; }
        public string usercolor { get; set; }



        public static List<user> QueryStudentByusername(string ausername)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Users
                  .Where(message => message.studentusername.Equals(ausername))
                  .ToList();
            }
        }

        public static List<user> QuerySupervisorByusername(string ausername)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Users
                  .Where(message => message.tmainusername.Equals(ausername))
                  .ToList();
            }
        }
        public static List<user> QueryAdministratorByusername(string ausername)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Users
                  .Where(message => message.adminusername.Equals(ausername))
                  .ToList();
            }
        }
        public user()
        {
            // 无参数构造函数
        }
        //用户注册
        public user(int number,string username, string password)
        {
            Id= Guid.NewGuid();
            if (number == 1)
            {
                List<user> students =QueryStudentByusername(username);
                if (students.Count == 0) {
                    this.studentusername = username;
                    this.studentpassword = password;
                }
                else
                    throw new ArgumentException("该用户名已经存在，请输入一个唯一的用户名。");
            }
                
                
            else if (number == 2)
            {
                List<user> supervisors = QuerySupervisorByusername(username);
                if (supervisors.Count == 0)
                {
                    this.tmainusername = username;
                    this.tmainpassword = password;
                }
                else
                    throw new ArgumentException("该用户名已经存在，请输入一个唯一的用户名。");
            }
            else 
            {
                List<user> administrators = QueryAdministratorByusername(username);
                if (administrators.Count == 0)
                {
                    this.adminusername = username;
                    this.adminpassword = password;
                }
                else
                    throw new ArgumentException("该用户名已经存在，请输入一个唯一的用户名。");
                
            }
        }

    }
}

