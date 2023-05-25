using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class StudentController
    {
        Student stu;
        MessageService mes;
        PaymentService pas;
        RepairServicce res;
        ComplaintService cos;
        ScheduleService scs;
        ClockInService cls;

        List<Supervisor> supervisors;//可能要添加所有宿管的表，方便查找
        public StudentController() { }
    }
}
