using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class SystemMessage
    {
        [Key]
        public string SystemMessageId { get; set; }// 主键
        public string Content { get; set; }// 内容
        public DateTime Time { get; set; }// 发送时间
        public string AdministratorId { get; set; }// 系统管理员id，外键
        public string AdministratorName // 系统管理员名字
        {
            get
            {
                return Administrator.AdministratorName;
            }
        }
        public Administrator Administrator { get; set; }// 系统管理员，发送者
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
