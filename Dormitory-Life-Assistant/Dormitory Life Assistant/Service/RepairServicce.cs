using Org.BouncyCastle.Crypto.Signers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class RepairServicce
    {
        public void addRepair(Repair r)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Repairs.Add(r);
                ctx.SaveChanges();
            }
        }//添加后自动发布给宿管

        public void deleteBill(int repairID)
        {
            using (var ctx = new SystemContext())
            {
                var systemRepair = ctx.Repairs
                    .SingleOrDefault(s => s.ID == repairID);
                if (systemRepair == null)
                {
                    throw new Exception("不存在可删除的对象");
                }
                ctx.Repairs.Remove(systemRepair);
                ctx.SaveChanges();

            }
        }//添加错了之后删除

        //通过学生对象查询
        public List<Repair> getRepairList(Student stu)
        {
            using (var ctx = new SystemContext())
            {
                var result = ctx.Repairs.Where(s => s.CallerID == stu.ID);
                return result.ToList<Repair>();
            }
        }

        //通过宿舍管理员对象查询
        /*public List<Repair> getRepairListBySup(Supervisor sup)
        {
            using (var ctx = new SystemContext())
            {
                var bud = ctx.Buildings
                    .SingleOrDefault(b => sup.ManageBuilding.Contains(b));
            }
        }*/

        public List<Repair> getRepairListByDormID(string dromID)
        {
            //dromID = "C4-308";

            using (var ctx = new SystemContext())
            {
                List<Repair> repairs = new List<Repair>();
                List<Student> students = ctx.Students.Where(s => s.DormNumber == dromID).ToList();
                /*if (students.Count == 0)
                {
                    throw new Exception("未查到学生");
                }*/
                foreach (Student stu in students)
                {
                    repairs.AddRange(getRepairList(stu));
                }

                return repairs;


            }
        }//id代表不同身份，学生显示宿舍的所有报修，老师显示整栋楼的报修

        public List<Repair> getAll()
        {
            using (var ctx = new SystemContext())
            {
                var repairs = ctx.Repairs;
                return repairs.ToList<Repair>();
            }
        }

        public void modifyBill(int repairID)
        {
            using (var ctx = new SystemContext())
            {
                var systemRepair = ctx.Repairs
                    .SingleOrDefault(s => s.ID == repairID);
                if (systemRepair == null)
                {
                    throw new Exception("不存在可修改的对象");
                }
                systemRepair.Status = true;
                ctx.SaveChanges();

            }
        }//缴费之后修改状态

    }
}
