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
        public string Name { get; set; }
        public string ID { get; set; }
        int Grade;
        String Department;//所在系
        public String BuildingName//所在宿舍楼栋
        {
            get;
            set;
        }
        String DormNumber;//所在宿舍号
        String Class; //所在班级
        String Gender;
        List<Payment> bill;
        List<Repair> repair;
        //public List<Complaint> complain;
        List<ClockIn> clockIn;//打卡信息及历史打卡信息
        List<Schedule> schedule;
        String Password;//密码
        Blob Profile;//头像
        List<ExchangeMessage> myMessage;
        
        public Student()
        {

        }
        public Student(string ID,string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public void changePassword(string pass) { }//修改密码
        public void changeProfile() { }//修改头像
        
    }
}
