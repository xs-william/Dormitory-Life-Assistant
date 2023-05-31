using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Dormitory_Life_Assistant
{
    public class MessageService
    {
        //Student st1 = new Student("2","范丞丞");
        //Supervisor supervisor = new Supervisor("2", "王琳凯");
        public MessageService()
        {
            //using (var ctx = new SystemContext())
            //{
            //    if (ctx.Students.Count() == 0)
            //    {
            //        ctx.Students.Add(st1);
            //        ctx.SaveChanges();
            //    }
            //    if (ctx.Supervisors.Count() == 0)
            //    {
            //        ctx.Supervisors.Add(supervisor);
            //        ctx.SaveChanges();
            //    }
            //    if (ctx.ExchangeMessages.Count() == 0)
            //    {
            //        ctx.ExchangeMessages.Add(new ExchangeMessage("真的是你呀", st1, supervisor));
            //        ctx.SaveChanges();
            //    }
            //}
        }
        //根据学生id返回学生的信息
        public List<ExchangeMessage> getAllMessage(string studentid)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.ExchangeMessages
                    .Include(e => e.Supervisor)
                    .Include(e => e.Student)
                    .Where(e => e.StudentId == studentid)
                    .ToList<ExchangeMessage>();
            }
        }
        public void SendExchangeMessage(ExchangeMessage m) 
        {
            FixExchangeMessage(m);
            using (var ctx = new SystemContext())
            {
                ctx.Entry(m).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }
        //避免级联添加或修改Student和Supervisor
        private static void FixExchangeMessage(ExchangeMessage exchangeMessage)
        {
            exchangeMessage.StudentId = exchangeMessage.Student.StudentId;
            exchangeMessage.Student = null;
            exchangeMessage.SupervisorId = exchangeMessage.Supervisor.SupervisorId;
            exchangeMessage.Supervisor = null;
        }
        //删除消息
        public void deleteExchangeMessage(ExchangeMessage m) 
        {
            using (var ctx = new SystemContext())
            {
                ctx.ExchangeMessages.Remove(m);
                ctx.SaveChanges();
            }
        }
        //根据内容寻找消息
        public List<ExchangeMessage> QueryExchangeMessagesByContent(string content)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.ExchangeMessages
                  .Include(e => e.Supervisor)
                  .Include(e => e.Student)
                  .Where(message => message.Content.Contains(content))
                  .ToList();
            }
        }
        //根据日期寻找消息
        public List<ExchangeMessage> QueryExchangeMessagesByDate(string date)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.ExchangeMessages
                  .Include(e => e.Supervisor)
                  .Include(e => e.Student)
                  .Where(message => message.Time.ToString().Contains(date))
                  .ToList();
            }
        }
        //根据发信人寻找消息
        public List<ExchangeMessage> QueryExchangeMessagesBySupervisorName(string name)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.ExchangeMessages
                  .Include(e => e.Supervisor)
                  .Include(e => e.Student)
                  .Where(message => message.SupervisorName == name)
                  .ToList();
            }
        }
    }
}
