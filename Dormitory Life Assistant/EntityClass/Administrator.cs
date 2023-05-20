using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class Administrator
    {
        string Name;
        string ID;
        string Tele;
        string Gender;
        Blob Profile;//头像
        string Password;
        List<Payment> bill;
        List<Repair> repair;
        List<Complaint> complain;
        List<Schedule> schedule;
        List<Supervisor> supervisor; //管理的宿管员
        List<Message> myMessage;
        List<Message> systemMessage;
        public void changeTele();
        public void changePassword(string pass);//修改密码
        public void changeProfile();//修改头像

    }
}
