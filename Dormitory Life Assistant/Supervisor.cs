using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class Supervisor
    {
        String Name;
        String ID;
        String Tele;
        String Gender;
        MEDIUMBLOB Profile;//头像
        String Password;
        List<Payment> bill;
        List<Repair> repair;
        List<Complaint> complain;
        List<Schedule> schedule;
        List<Building> ManageBuilding; //管理的楼栋
        List<Message> myMessage;
        List<Message> systemMessage;

        public void changeTele();
        public void changePassword(string pass);//修改密码
        public void changeProfile();//修改头像

    }
}
