using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class ExchangeMessage
    {
        [Key]
        public string MessageID { get; set; }//主键
        public string Content { get; set; }
        public DateTime time { get; set; }
        public string SupervisorId { get; set; }//发送信息的宿管ID，外键
        public Supervisor Supervisor { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public string SupervisorName
        {
            get
            {
                // return Supervisor.SupervisorName;
                return "123";
            }
        }

        public ExchangeMessage() { }



    }
}
