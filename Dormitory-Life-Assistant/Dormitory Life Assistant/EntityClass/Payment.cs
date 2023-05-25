using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class Payment
    {
        public Student stu;//添加一个缴费对象
        public double Amount;
        public DateTime PayTime;
        public bool Status;//是否缴费
        public string type;
        public string ID;//id用来查询账单
        public string Content;//用于生成缴费信息

        //构造函数
        public Payment()
        {
            this.Content = $"缴费金额为：{this.Amount}";
        }
    }
}
