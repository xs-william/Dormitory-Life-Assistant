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
        public string ID { get; set; }
        public String Content { get; set; }
        public DateTime Date { get; set; }//提醒时间
    }
}
