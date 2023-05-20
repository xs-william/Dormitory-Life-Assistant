using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class AdministratorController
    {
        Administrator adm;
        MessageService mes;
        PaymentService pas;
        RepairServicce res;
        ComplaintServicce cos;
        ScheduleService scs;
        ClockInService cls;
        BuildingService bds;

        public AdministratorController();
        public void allocate();//分配、修改宿管管理的内容
        public void deleteSup();

    }
}
