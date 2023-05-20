using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class Payment
    {
        double Amount;
        DateTime PayTime;
        bool Status;//是否缴费
        String type;
        String ID;//id用来查询账单
    }
}
