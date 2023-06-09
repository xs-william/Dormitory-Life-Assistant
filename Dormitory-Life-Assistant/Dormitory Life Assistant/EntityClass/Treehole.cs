using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class Treehole
    {
        [Key]
        public DateTime time { get; set; }
        public string studentid { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public Treehole() 
        {
            
        }
     
    }
   
}
