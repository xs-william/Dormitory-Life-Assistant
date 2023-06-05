using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class ClockIn
    {
        [Key]
        public String ID { get; set; }
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }//在校或者不在校
    }
}
