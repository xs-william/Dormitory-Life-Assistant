using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }//id用来查询账单
        public double Amount { get; set; }
        public DateTime PayTime { get; set; }
        public bool Status { get; set; }//是否缴费
        public string Type { get; set; }
        public string CallerID { get; set; }//创建缴费者ID
        public string CallerDorm { set; get; }//创建缴费寝室号

        public Payment() { }

        public Payment(int id, double amount, string callerID, string type)
        {
            ID = id;
            Amount = amount;
            CallerID = callerID;
            Type = type;
            this.PayTime = DateTime.Now;
            using (var ctx = new SystemContext())
            {
                this.CallerDorm = ctx.Students.FirstOrDefault(s => s.StudentId == callerID)?.DormNumber;
            }
        }

    }
}
