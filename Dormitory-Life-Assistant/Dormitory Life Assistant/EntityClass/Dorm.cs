using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class Dorm
    {
        [Key]
        public String ID { get; set; }//每个宿舍的id,就是宿舍号
        public String BuildingName { get; set; } //楼栋名
        //public String DormNumber { get; set; } //宿舍号
        public String DormHead { get; set; }//宿舍长
        public List<Student> Member;//宿舍成员

        public Dorm() { }

        public Dorm(string dormNumber)
        {
            ID = dormNumber;
            /*//查询数据库找出本宿舍成员
            using (var ctx = new SystemContext())
            {
                var systemStudent = from s in ctx.Students
                                    where s.DormNumber == dormNumber
                                    select s;
                if (systemStudent == null)
                {
                    throw new Exception("本宿舍没有成员");
                }
                foreach (var stu in systemStudent)
                {
                    this.Member.Add(stu);
                }
            }*/
        }
    }
}
