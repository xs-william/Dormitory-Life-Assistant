using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class PaymentService
    {
        public void addBill(Payment p);//添加后自动发布给学生
        public void deleteBill(list<Payment> p);//添加错了之后删除
        public void modifyBill(list<Payment> p);//缴费之后修改状态
        public void searchBill(list<Payment> p);//id代表不同身份，学生显示宿舍的所有账单，老师显示整栋楼的账单
    }
}
