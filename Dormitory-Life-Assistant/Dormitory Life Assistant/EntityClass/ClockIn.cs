using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class ClockIn
    {
        [Key]
        public Guid ClockInID { get; set; }

        public string? ID { get; set; }

        public DateTime publishtime { get; set; }

        public string publisher { get; set; }

        public string? Name { get; set; }

        public DateTime? Date { get; set; }

        public string? Status { get; set; }

        public ClockIn()
        {
            ClockInID = Guid.NewGuid();
        }
    }




}
