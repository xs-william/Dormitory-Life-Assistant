using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class StudentController
    {
        public Student stu;
        public MessageService mes;
        public PaymentService pas;
        public RepairServicce res;
        public ComplaintService cos;
        public ScheduleService scs;
        public ClockInService cls;

        public StudentController()
        {
            stu = new Student();
            res = new RepairServicce(stu, null, null);
        }
    }
}
