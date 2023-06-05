using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class ClockInService
    {
        public SystemContext context;
        public ClockInService()
        {
            this.context = new SystemContext();
            //using ()
            //{

            //    //ctx.ClockIns.Add(new ClockIn(publishtime, publisher));

            //}
        }
        public List<ClockIn> clockIns
        {
            get
            {
                using (var ctx = new SystemContext())
                {
                    return ctx.ClockIns
                      .ToList<ClockIn>();
                }
            }
        }
        public void DeleteClockIn(Guid clockInID)
        {
            using (var ctx = new SystemContext())
            {
                var clockIn = ctx.ClockIns
                  .SingleOrDefault(s => s.ClockInID == clockInID);
                if (clockIn == null) return;
                ctx.ClockIns.Remove(clockIn);
                ctx.SaveChanges();
            }
        }
        public void AddClockIn(ClockIn clockIn)
        {

            using (var ctx = new SystemContext())
            {
                ctx.Entry(clockIn).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
            }
        }
        public void ModifyClockIn(ClockIn clockIn)
        {
            DeleteClockIn(clockIn.ClockInID);
            AddClockIn(clockIn);
        }
        public ClockIn submitClock(ClockIn clockin, DateTime date)
        {
            clockin.ClockInID = clockin.ClockInID;
            clockin.publishtime = clockin.publishtime;
            clockin.publisher = clockin.publisher;
            clockin.Status = "是";
            clockin.Date = date;
            clockin.ID = "2021302111145";
            clockin.Name = "周树东";
            return clockin;
        }//添加、提交打卡信息
        public void searchClock(List<ClockIn> c) { }
        public void pubilshClock(DateTime publishtime, string publisher, string status)
        {
            ClockIn clock = new ClockIn() { publishtime = publishtime, publisher = publisher, Status = status };

            using (var ctx = new SystemContext())
            {
                ctx.Entry(clock).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
            }


            context.ClockIns.Add(new ClockIn() { publishtime = publishtime, publisher = publisher });
        }//发布信息
        public List<ClockIn> QueryClockInsByPublishtime(string date)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.ClockIns
                 .Where(message => message.publishtime.ToString().Contains(date))
                 .ToList();
            }
        }

        public List<ClockIn> QueryClockInsByName(string name)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.ClockIns
                  .Where(message => message.Name.Contains(name))
                  .ToList();
            }
        }
        public List<ClockIn> QueryClockInsByID(string id)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.ClockIns
                  .Where(message => message.ID.Contains(id))
                  .ToList();
            }
        }

    }
}

