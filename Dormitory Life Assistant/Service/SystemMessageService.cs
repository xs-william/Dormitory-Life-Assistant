using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Dormitory_Life_Assistant.Service
{
    public class SystemMessageService
    {
        Administrator ad1 = new Administrator("1", "高珺");
        Administrator ad2 = new Administrator("2", "小达");
        public SystemMessageService()
        {
            using (var ctx = new SystemContext())
            {
                if (ctx.Administrators.Count() == 0)
                {
                    ctx.Administrators.Add(ad1);
                    ctx.Administrators.Add(ad2);
                    ctx.SaveChanges();
                }
                if (ctx.SystemMessages.Count() == 0)
                {
                    ctx.SystemMessages.Add(new SystemMessage("这件事情太酷啦！",ad1));
                    ctx.SystemMessages.Add(new SystemMessage("哇真的是你鸭",ad2));
                    ctx.SaveChanges();
                }
            }
        }
        public List<SystemMessage> SystemMessages
        {
            get
            {
                using (var ctx = new SystemContext())
                {
                    return ctx.SystemMessages
                      .Include(s => s.Administrator)
                      .ToList<SystemMessage>();
                }
            }
        }
        public SystemMessage GetSystemMessage(string id)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.SystemMessages
                  .Include(s => s.Administrator)
                  .SingleOrDefault(s => s.SystemMessageId == id);
            }
        }
        public void AddSystemMessage(SystemMessage systemMessage)
        {
            FixSystemMessage(systemMessage);
            using (var ctx = new SystemContext())
            {
                ctx.Entry(systemMessage).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }
        //避免级联添加或修改Customer和Goods
        private static void FixSystemMessage(SystemMessage newSystemMessage)
        {
            newSystemMessage.AdministratorId = newSystemMessage.Administrator.AdministratorId;
            newSystemMessage.Administrator = null;
        }
        public void DeleteSystemMessage(string systemMessageId)
        {
            using (var ctx = new SystemContext())
            {
                var systemMessage = ctx.SystemMessages
                  .SingleOrDefault(s => s.SystemMessageId == systemMessageId);
                if (systemMessage == null) return;
                ctx.SystemMessages.Remove(systemMessage);
                ctx.SaveChanges();
            }
        }
        public void ModifySystemMessage(SystemMessage systemMessage)
        {
            DeleteSystemMessage(systemMessage.SystemMessageId);
            AddSystemMessage(systemMessage);
        }
        public List<SystemMessage> QuerySystemMessagesByContent(string content)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.SystemMessages
                  .Include(s => s.Administrator)
                  .Where(message => message.Content.Contains(content))
                  .ToList();
            }
        }
        public List<SystemMessage> QuerySystemMessagesByDate(string date)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.SystemMessages
                  .Include(s => s.Administrator)
                  .Where(message => message.Time.ToString().Contains(date))
                  .ToList();
            }
        }
    }
}
