using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;



namespace Dormitory_Life_Assistant
{
    public class Repair
    {
        [Key]
        public int ID { get; set; }//id用来查询报修信息
        public string CallerID { get; set; }//创建维修账单者的ID
        public string CallerDorm { get; set; }//创建维修宿舍号
        public Blob Picture { get; set; }//图片
        public string Content { get; set; }
        public DateTime RepairTime { get; set; }//报修时间
        public bool Status { get; set; }//是否已经解决

        public Repair() { }

        public Repair(int id, string content, string callerID)
        {
            Content = content;
            ID = id;
            CallerID = callerID;
            this.RepairTime = DateTime.Now;
            using (var ctx = new SystemContext())
            {
                this.CallerDorm = ctx.Students.FirstOrDefault(s => s.ID == callerID)?.DormNumber;

            }
        }

    }
}
