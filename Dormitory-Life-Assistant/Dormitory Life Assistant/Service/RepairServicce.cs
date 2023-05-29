using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//先将数据存储在内存中（list)，后面一次性上传

namespace Dormitory_Life_Assistant
{
    internal class RepairServicce
    {
        //创建三个有报修相关功能的对象
        Student stu;
        Supervisor sup;
        Administrator adm;
        int judge = 0;//用来判断调用此方法的对象类型，0表示没有对象，1表示学生，2表示宿舍管理员，3表示系统管理员

        //构造函数
        public RepairServicce(Student stu, Supervisor sup, Administrator adm)
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
        List<Repair> repairsList = new List<Repair>();
        List<Message> messagesList = new List<Message>();

        public void addRepair(Repair r)//看exchangemessage如何将填入信息打包
        {
            repairsList.Add(r);//添加报修信息
            DateTime now = DateTime.Now;
            //发送报修信息
            Message repairMessage = new Message(r.Content, r.ID, r.stu.Name, now);
            messagesList.Add(repairMessage);
            //再通过message将信息发送给宿舍管理员和系统管理员

        }//添加后自动发布给宿管

        public void deleteBill(string id)
        {
            //循环遍历寻找删除，也可以用数据库直接删除
            foreach (var repair in repairsList)
            {
                if (!repair.ID.Equals(id))
                {
                    repairsList.Remove(repair);
                }
            }
        }//添加错了之后删除,通过将要删除的维修账单的ID传入

        public void searchBill()
        {
            switch (judge)
            {
                case 1:
                    List<Repair> temp1 = new List<Repair>();
                    foreach (var repair in repairsList)
                    {
                        if (repair.stu.BuildingName.Equals(stu.BuildingName) && repair.stu.DormNumber.Equals(stu.DormNumber))
                        {
                            temp1.Add(repair);
                        }
                    }
                    break;
                case 2:
                    List<Repair> temp2 = new List<Repair>();
                    foreach (var repair in repairsList)
                    {
                        Building build = new Building(repair.stu.BuildingName);
                        if (sup.ManageBuilding.Contains(build))
                        {
                            temp2.Add(repair);
                        }
                    }
                    break;
                default:
                    break;

            }
        }//用judge判断不同身份，学生显示宿舍的所有报修，老师显示整栋楼的报修


        public void modifyBill(string id)
        {
            foreach (var repair in repairsList)
            {
                if (repair.ID == id)
                {
                    repair.Status = true;
                }
            }
        }//解决之后修改状态,将学生修改报修记录的ID传入

    }
}
