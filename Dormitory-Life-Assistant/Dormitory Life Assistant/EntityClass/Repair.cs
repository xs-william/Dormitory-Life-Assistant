using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;



namespace Dormitory_Life_Assistant
{
    internal class Repair
    {
        public Student stu;//增加一个添加维修信息的学生对象
        public Blob Picture;//图片
        public string Content;
        public DateTime RepairTime;//报修时间
        public bool Status;//是否已经解决
        public string ID;//id用来查询报修信息

        public Repair()
        {
            stu = this.stu;
        }
    }
}
