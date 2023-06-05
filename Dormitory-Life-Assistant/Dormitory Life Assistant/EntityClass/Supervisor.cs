using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Dormitory_Life_Assistant
{
    public class Supervisor
    {
        [Key]
        public String SupervisorId { get; set; }
        public String SupervisorName { get; set; }

        public String Tele { get; set; }
        public String Gender { get; set; }
        public Blob Profile { get; set; }//头像
        public String Password { get; set; }
        List<Payment> bill;
        List<Repair> repair;
        public List<Complaint> complain;
        List<Schedule> schedule;
        public List<Building> ManageBuilding; //管理的楼栋
        //List<ExchangeMessage> myMessage;
        public List<ExchangeMessage> ExchangeMessages { get; set; }

        public void changeTele() { }
        public void changePassword(string pass) { }//修改密码
        public void changeProfile() { }//修改头像

        public Supervisor() { }
        public String SupBuildingName { get; set; }
        public Supervisor(string supervisorId,string supervisorName)
        {
            SupervisorId = supervisorId;
            SupervisorName = supervisorName;
        }
        public Supervisor(string supervisorName, string supervisorID, string tele, string gender, string password, string buildingName)
        {
            SupervisorName = supervisorName;
            SupervisorId = supervisorID;
            Tele = tele;
            Gender = gender;
            Password = password;
            Profile = new Blob();
            SupBuildingName = buildingName;

        }
    }
}
