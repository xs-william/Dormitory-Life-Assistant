using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class MessageService
    {
        public List<Message> getAllMessage();
        public void addMessage(Message m);
        public void deleteMessage();
        public void searchMessage();
    }
}
