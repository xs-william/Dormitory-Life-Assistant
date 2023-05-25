using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class Message
    {
        public String Content;
        public String ID;//发送人ID（主码）
        public String Name;
        public DateTime Time;

        //构造函数
        public Message(String content, String id, String name, DateTime time)
        {
            this.Content = content;
            this.ID = id;
            this.Name = name;
            this.Time = time;
        }
    }
}
