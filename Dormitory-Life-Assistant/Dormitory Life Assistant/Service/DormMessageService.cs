using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Dormitory_Life_Assistant
{
    public class DormMessageService
    {
        //测试代码，之后去掉
        //Supervisor supervisor = new Supervisor("1", "BBT的王子异");
        public DormMessageService()
        {
            //using (var ctx = new SystemContext())
            //{
            //    if (ctx.Supervisors.Count() == 0)
            //    {
            //        ctx.Supervisors.Add(supervisor);
            //        ctx.SaveChanges();
            //    }
            //    if(ctx.DormMessages.Count() == 0)
            //    {
            //        ctx.DormMessages.Add(new DormMessage("8848钛金手机", supervisor));
            //    }
            //}
        }
        //查看所有消息
        public List<DormMessage> DormMessages
        {
            get
            {
                using (var ctx = new SystemContext())
                {
                    return ctx.DormMessages
                      .Include(d => d.Supervisor)
                      .ToList<DormMessage>();
                }
            }
        }
        //添加宿舍消息
        public void AddDormMessage(DormMessage dormMessage)
        {
            FixDormMessage(dormMessage);
            using (var ctx = new SystemContext())
            {
                ctx.Entry(dormMessage).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }
        //避免级联添加或修改Supervisor
        private static void FixDormMessage(DormMessage newDormMessage)
        {
            newDormMessage.SupervisorId = newDormMessage.Supervisor.SupervisorId;
            newDormMessage.Supervisor = null;
        }
        //删除宿舍消息
        public void DeleteDormMessage(string dormMessageId)
        {
            using (var ctx = new SystemContext())
            {
                var dormMessage = ctx.DormMessages.
                    Include(d => d.Supervisor)
                    .SingleOrDefault(d => d.DormMessageId == dormMessageId);
                if (dormMessage == null) return;
                ctx.DormMessages.Remove(dormMessage);
                ctx.SaveChanges();
            }
        }
        //根据内容查询
        public List<DormMessage> QueryDormMessagesByContent(string content)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.DormMessages
                  .Include(d => d.Supervisor)
                  .Where(message => message.Content.Contains(content))
                  .ToList();
            }
        }
        //根据日期查询
        public List<DormMessage> QueryDormMessagesByDate(string date)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.DormMessages
                  .Include(d => d.Supervisor)
                  .Where(message => message.Time.ToString().Contains(date))
                  .ToList();
            }
        }
        //根据发送人查询
        public List<DormMessage> QueryDormMessagesByPerson(string name)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.DormMessages
                  .Include(d => d.Supervisor)
                  .Where(message => message.Supervisor.SupervisorName.Contains(name))
                  .ToList();
            }
        }
    }
}

