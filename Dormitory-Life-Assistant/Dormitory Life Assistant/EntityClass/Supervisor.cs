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
        String SupervisorName;
        String ID;
        String Tele;
        String Gender;
        Blob Profile;//头像
        String Password;
        List<Payment> bill;
        List<Repair> repair;
        public List<Complaint> complain;
        List<Schedule> schedule;
        public List<Building> ManageBuilding; //管理的楼栋
        //List<ExchangeMessage> myMessage;
        List<ExchangeMessage> systemMessage;

        public void changeTele() { }
        public void changePassword(string pass) { }//修改密码
        public void changeProfile() { }//修改头像

    }
}
