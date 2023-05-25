using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class Building
    {
        public string BuildingName//楼栋名
        {
            get; set;
        }
        List<Dorm> DormContent;//包含宿舍

        //构造函数
        public Building(String BuildingName)
        {
            this.BuildingName = BuildingName;
        }
    }
}
