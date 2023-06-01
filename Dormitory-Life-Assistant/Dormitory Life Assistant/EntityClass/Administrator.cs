using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class Administrator
    {
        public string AdministratorId { get; set; }
        public string AdministratorName { get; set; }
        //string Tele;
        //string Gender;
        //Blob Profile;//头像
        //string Password;
        //List<Payment> bill;
        //List<Repair> repair;
        //List<Complaint> complain;
        //List<Schedule> schedule;
        //List<Supervisor> supervisor; //管理的宿管员
        public List<SystemMessage> SystemMessages { get; set; }
        public void changeTele() { }
        public void changePassword(string pass) { }//修改密码
        public void changeProfile() { }//修改头像
        public Administrator() { }
        public Administrator(string administratorId, string name)
        {
            AdministratorId = administratorId;
            AdministratorName = name;
        }
    }
}
