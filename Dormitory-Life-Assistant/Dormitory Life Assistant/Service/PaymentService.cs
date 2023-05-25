using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class PaymentService
    {
        //创建三个与缴费相关功能的对象
        Student stu;
        Supervisor sup;
        Administrator adm;
        int judge = 0;//用来判断调用此方法的对象类型，0表示没有对象，1表示学生，2表示宿舍管理员，3表示系统管理员

        //构造函数
        public PaymentService(Student stu, Supervisor sup, Administrator adm)
        {
            //确定是谁调用了服务，并且将调用者信息导入
            if (stu != null)
            {
                judge = 1;
                stu = this.stu;
            }
            else if (sup != null)
            {
                judge = 2;
                sup = this.sup;
            }
            else if (adm != null)
            {
                judge = 3;
                adm = this.adm;
            }
            else throw new Exception("error:没有调用者调用报修服务");
        }

        //创建一个list对象来存储报修信息
        List<Payment> paymentsList = new List<Payment>();
        List<Message> messagesList = new List<Message>();


        public void addBill(Payment p)
        {
            paymentsList.Add(p);//添加报修信息
            DateTime now = DateTime.Now;
            //发送报修信息
            Message repairMessage = new Message(p.Content, p.ID, p.stu.Name, now);
            messagesList.Add(repairMessage);
            //再通过message将信息发送给宿舍管理员和系统管理员

        }//添加后自动发布给学生

        public void deleteBill(string id)
        {
            //循环遍历寻找删除，也可以用数据库直接删除
            foreach (Payment p in paymentsList)
            {
                if (!p.ID.Equals(id))
                {
                    paymentsList.Remove(p);
                }
            }
        }//添加错了之后删除,通过将要删除的账单的ID传入

        public void modifyBill(string id)
        {
            foreach (Payment p in paymentsList)
            {
                if (p.ID.Equals(id))
                {
                    p.Status = true;
                }
            }
        }//缴费之后修改状态

        public void searchBill()
        {
            switch (judge)
            {
                case 1:
                    List<Payment> temp1 = new List<Payment>();
                    foreach (Payment p in paymentsList)
                    {
                        if (p.stu.BuildingName.Equals(this.stu.BuildingName))
                        {
                            temp1.Add(p);
                        }
                    }
                    break;
                case 2:
                    List<Payment> temp2 = new List<Payment>();
                    foreach (Payment p in paymentsList)
                    {
                        Building build = new Building(p.stu.BuildingName);
                        if (this.sup.ManageBuilding.Contains(build))
                        {
                            temp2.Add(p);
                        }
                    }
                    break;
                default:
                    break;
            }
        }//用judge判断不同身份，学生显示宿舍的所有账单，老师显示整栋楼的账单
    }
}
