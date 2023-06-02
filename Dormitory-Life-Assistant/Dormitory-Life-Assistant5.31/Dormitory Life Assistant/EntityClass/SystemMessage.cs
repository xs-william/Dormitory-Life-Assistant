using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class SystemMessage
    {
        public string SystemMessageId { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public string AdministratorId { get; set; }
        public string AdministratorName 
        {
            get
            {
                return Administrator.AdministratorName;
            }
        }
        public Administrator Administrator { get; set; }
        public SystemMessage() 
        {
            SystemMessageId = Guid.NewGuid().ToString();
        }
        public SystemMessage(string Content, Administrator ad)
        {
            SystemMessageId = Guid.NewGuid().ToString();
            this.Content = Content;
            this.Administrator = ad;
            this.Time = DateTime.Now;
        }
        public override string ToString()
        {
            return Content + "  " + Administrator.AdministratorName + ", " + Time.ToString();
        }
    }
}
