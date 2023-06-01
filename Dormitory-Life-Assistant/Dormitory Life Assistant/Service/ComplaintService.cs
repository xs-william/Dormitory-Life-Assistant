using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class ComplaintService
    {

        public ComplaintService()
        {
        }
        public void addComplaint(Complaint complaint)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Complaints.Add(complaint);
                ctx.SaveChanges();
            }         
        }
        public List<Complaint> getComplaint(Student student) 
        {
            using (var ctx = new SystemContext())
            {
                var result = ctx.Complaints.Where(c => c.informer == student.Name);
                return result.ToList<Complaint>();
            }
        }
        public List<Complaint> getAll()
        {
            using (var ctx = new SystemContext())
            {
                var result = ctx.Complaints;
                return result.ToList<Complaint>();
            }
        }
        public List<Complaint> QueryByID(string ID)
        {
            if (ID != "")
            {
                int id = int.Parse(ID);
                using (var ctx = new SystemContext())
                {
                    var result = ctx.Complaints.Where(c => c.ID == id);
                    return result.ToList<Complaint>();
                }
            }
            else
            {
                using (var ctx = new SystemContext())
                {
                    var result = ctx.Complaints;
                    return result.ToList<Complaint>();
                }
            }
        }
        public List<Complaint> QueryByInformer(string informer)
        {
            if (informer != "")
            {
                using (var ctx = new SystemContext())
                {
                    var result = ctx.Complaints.Where(c => c.informer.Contains(informer));
                    return result.ToList<Complaint>();
                }
            }
            else
            {
                using (var ctx = new SystemContext())
                {
                    var result = ctx.Complaints;
                    return result.ToList<Complaint>();
                }
            }
        }
        public List<Complaint> QueryByStatus(string status)
        {
            if (status != "")
            {
                using (var ctx = new SystemContext())
                {
                    var result = ctx.Complaints.Where(c=>c.status.Contains(status));
                    return result.ToList<Complaint>();
                }
            }
            else
            {
                using (var ctx = new SystemContext())
                {
                    var result = ctx.Complaints;
                    return result.ToList<Complaint>();
                }
            }
        }
        public void RemoveComplaint(Complaint c)
        {
            using (var ctx = new SystemContext())
            {
                var complaint = ctx.Complaints
                  .SingleOrDefault(o => o.ID == c.ID);
                if (complaint == null) return;
                ctx.Complaints.Remove(complaint);
                ctx.SaveChanges();
            }
        }
        public void UpdateComplaint(Complaint newComplaint)
        {
            RemoveComplaint(newComplaint);
            addComplaint(newComplaint);
        }
    }
}
