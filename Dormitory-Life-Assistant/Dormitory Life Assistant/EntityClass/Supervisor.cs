using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Dormitory_Life_Assistant
{
    public class Supervisor
    {
        public string SupervisorId { get; set; }
        public string SupervisorName { get; set; }
        public List<ExchangeMessage> ExchangeMessages { get; set; }
        String Tele;
        String Gender;
        Blob Profile;//头像
        String Password;
        public List<Payment> bill;
        public List<Repair> repair;
        public List<Complaint> complain;
        List<Schedule> schedule;
        public List<Building> ManageBuilding; //管理的楼栋
        public Supervisor() { }
        public Supervisor(string supervisorId,string supervisorName)
        {
            SupervisorId = supervisorId;
            SupervisorName = supervisorName;
        }
        public void changeTele() { }
        public void changePassword(string pass) { }//修改密码
        public void changeProfile() { }//修改头像
    }
}
