using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class Supervisor
    {
        public String Name;
        public String ID;
        public String Tele;
        public String Gender;
        public Blob Profile;//头像
        public String Password;
        public List<Payment> bill;
        public List<Repair> repair;
        public List<Complaint> complain;
        public List<Schedule> schedule;
        public List<Building> ManageBuilding; //管理的楼栋
        public List<Message> myMessage;
        public List<Message> systemMessage;

        public void changeTele() { }
        public void changePassword(string pass) { }//修改密码
        public void changeProfile() { }//修改头像

    }
}
