using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class PaymentService
    {
        public void addBill(Payment p)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Payments.Add(p);
                ctx.SaveChanges();
            }
        }//添加后自动发布给学生

        public void deleteBill(string paymentDormID)
        {
            using (var ctx = new SystemContext())
            {
                var systemPayment = ctx.Payments
                    .SingleOrDefault(p => p.CallerDorm == paymentDormID);
                if (systemPayment == null)
                {
                    throw new Exception("不存在可删除对象");
                }
                ctx.Payments.Remove(systemPayment);
                ctx.SaveChanges();
            }
        }//添加错了之后删除

        public void modifyBill(string paymentDormID)
        {
            using (var ctx = new SystemContext())
            {
                var systemPayment = ctx.Payments
                    .SingleOrDefault(p => p.CallerDorm == paymentDormID);
                if (systemPayment == null)
                {
                    throw new Exception("不存在可修改对象");
                }
                systemPayment.Status = true;
                ctx.SaveChanges();
            }
        }//缴费之后修改状态

        public List<Payment> getPaymentList(Student stu)
        {
            using (var ctx = new SystemContext())
            {
                var result = ctx.Payments.Where(p => p.CallerID == stu.ID);
                return result.ToList<Payment>();
            }
        }

        public List<Payment> getPaymentListByDorm(string dormID)
        {
            using (var ctx = new SystemContext())
            {
                List<Payment> payments = new List<Payment>();
                List<Student> students = ctx.Students.Where(s => s.DormNumber == dormID).ToList();
                /*if (students.Count == 0)
                {
                    throw new Exception("未查到学生");
                }*/
                foreach (var stu in students)
                {
                    payments.AddRange(getPaymentList(stu));
                }

                return payments;
            }
        }

        public List<Payment> getAll()
        {
            using (var ctx = new SystemContext())
            {
                var payments = ctx.Payments;
                return payments.ToList<Payment>();
            }
        }


    }
}
