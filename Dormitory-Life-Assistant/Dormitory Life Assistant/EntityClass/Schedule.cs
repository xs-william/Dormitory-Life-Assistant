using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class Schedule
    {
        [Key]
        public Guid scheduleid { get; set; }
        public string ID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }//提醒时间
        public string status { get; set; }
        public Schedule()
        {
            scheduleid = Guid.NewGuid();
        }
    }
}
