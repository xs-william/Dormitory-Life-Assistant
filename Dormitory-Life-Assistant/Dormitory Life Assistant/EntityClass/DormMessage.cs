using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class DormMessage
    {
        public string DormMessageId { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public string SupervisorId { get; set; }// 发送宿舍消息的宿管的id，外键
        public string SupervisorName
        {
            get
            {
                return Supervisor.SupervisorName;
            }
        }
        public Supervisor Supervisor { get; set; }
        public DormMessage()
        {
            DormMessageId = Guid.NewGuid().ToString();
        }
        public DormMessage(string Content, Supervisor supervisor)
        {
            SupervisorId = Guid.NewGuid().ToString();
            this.Content = Content;
            this.Supervisor = supervisor;
            this.Time = DateTime.Now;
        }
    }
}
