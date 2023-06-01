using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class Student
    {
        public String StudentId { get; set; }
        public String Name { get; set; }
        public string Grade { get; set; }
        public String Department { get; set; }//所在系
        public String BuildingName { get; set; }//所在宿舍楼栋
        public String DormNumber { get; set; }//所在宿舍号
        public String Class { get; set; } //所在班级
        public String Gender { get; set; }
        List<Payment> bill { get; set; }
        List<Repair> repair { get; set; }
        public List<Complaint> complain;
        List<ClockIn> clockIn;//打卡信息及历史打卡信息
        List<Schedule> schedule;
        public String Password { get; set; }//密码
        Blob Profile;//头像
        List<ExchangeMessage> myMessage;

        public void changePassword(string pass) { }//修改密码
        public void changeProfile() { }//修改头像

        public Student(String id, string name, string grade, string department, string dormnumber, string classes, string gender, string password, string buildingid)
        {
            StudentId = id;
            Name = name;
            Grade = grade;
            Department = department;
            DormNumber = dormnumber;
            Gender = gender;
            Password = password;
            Class = classes;
            Profile = new Blob();
            myMessage = new List<ExchangeMessage>();
            bill = new List<Payment>();
            repair = new List<Repair>();
            complain = new List<Complaint>();
            clockIn = new List<ClockIn>();
            schedule = new List<Schedule>();
            BuildingName = buildingid;
        }
        public Student()
        {
            StudentId = Guid.NewGuid().ToString();
        }

    }
}
