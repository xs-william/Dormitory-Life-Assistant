using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class Building
    {
        public String BuildingName { get; set; }//楼栋名
        public List<Dorm> DormContent;//包含宿舍
    }
}
