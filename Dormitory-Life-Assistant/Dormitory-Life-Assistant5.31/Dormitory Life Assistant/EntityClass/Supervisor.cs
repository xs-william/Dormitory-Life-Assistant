using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class Supervisor
    {
        public String SupervisorName { get; set; }
        public String SupervisorID { get; set; }
        public String Tele { get; set; }
        public String Gender { get; set; }
        Blob Profile; //头像
        public String Password { get; set; }
        public String SupBuildingName { get; set; }
        List<Payment> bill;
        List<Repair> repair;
        List<Complaint> complain;
        List<Schedule> schedule;
        List<ExchangeMessage> systemMessage;

        public Supervisor()
        {
            SupervisorID = Guid.NewGuid().ToString();
        }
        public Supervisor(string supervisorName, string supervisorID, string tele, string gender, string password, string buildingName)
        {
            SupervisorName = supervisorName;
            SupervisorID = supervisorID;
            Tele = tele;
            Gender = gender;
            Password = password;
            Profile = new Blob();
            SupBuildingName = buildingName;

        }


        public void changeTele() { }
        public void changePassword(string pass) { }//修改密码
        public void changeProfile() { }//修改头像

    }
}
