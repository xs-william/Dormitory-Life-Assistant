using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class RepairServicce
    {
        public void addRepair(Repair r) { }//添加后自动发布给宿管
        public void deleteBill(List<Repair> r) { }//添加错了之后删除
        public void searchBill(string id) { }//id代表不同身份，学生显示宿舍的所有报修，老师显示整栋楼的报修
        public void modifyBill(List<Repair> r) { }//缴费之后修改状态

    }
}
