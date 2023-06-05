using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant.Service
{
    public class SupervisorService
    {
        public SupervisorService() { }

        public List<Supervisor> getall()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Supervisors
                  .ToList<Supervisor>();
            }
        }

        public void AddSupervisor(Supervisor supervisor)
        {
            using (var ctx = new SystemContext())
            {
                if (supervisor == null) { return; }
                ctx.Supervisors.Add(supervisor);
                ctx.SaveChanges();
            }
        }

        public void DeleteSupervisor(Supervisor sup)
        {
            using (var ctx = new SystemContext())
            {
                var supervisor = ctx.Supervisors
                    .SingleOrDefault(s => s.SupervisorId ==sup.SupervisorId);

                if (supervisor== null) return;
                ctx.Supervisors.Remove(supervisor);
                ctx.SaveChanges();
            }
        }


        public void ModifySupervisor(Supervisor supervisor)
        {
            DeleteSupervisor(supervisor);
            AddSupervisor(supervisor);
        }

        public List<Supervisor> QuerySupervisorByName(string name)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Supervisors
                    .Where(s => s.SupervisorName.Contains( name))
                    .ToList<Supervisor>();
            }
        }
        public List<Supervisor> QuerySupervisorByBuildingName(string buildingName)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Supervisors
                    .Where(s => s.SupBuildingName.Contains(buildingName))
                    .ToList<Supervisor>();
            }
        }

        public List<Supervisor> QuerySupervisorByID(string id)
        {
            using (var ctx = new SystemContext())
            {
                var result = ctx.Supervisors
                    .Where(s => s.SupervisorId==id)
                    .ToList<Supervisor>();
                return result;
            }
        }
    }
}
