using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class Complaint
    {
        public int ID { get; set; }
        Blob Picture;
        public string status { get; set; }
        public string Content { get; set; }
        public string informer { get; set; }
        public DateTime ComplaintTime { get; set; }
        
        public override bool Equals(object obj)//重写equals，利用ID判断对象是否相等
        {
            Complaint c = obj as Complaint;
            return c.ID == ID;
        }
        public Complaint()
        {

        }
        public Complaint(int ID,string Content,string informer,DateTime ComplaintTime,string status)
        {
            this.ID = ID;
            this.Content = Content;
            this.informer = informer;
            this.ComplaintTime = ComplaintTime;
            this.status = status;
        }
    }

}
