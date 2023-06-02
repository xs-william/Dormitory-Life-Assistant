
﻿using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class Complaint
    {
        [Key]
        public string ID { get; set; }
        public Blob Picture { get; set; }
        public bool status { get; set; }
        public string Content { get; set; }
        public DateTime ComplaintTime { get; set; }
        public override bool Equals(object obj)//重写equals，利用ID判断对象是否相等
        {
            Complaint c = obj as Complaint;
            return c.ID == ID;
        }
    }

}
