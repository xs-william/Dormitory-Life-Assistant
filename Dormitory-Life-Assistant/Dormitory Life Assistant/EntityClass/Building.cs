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
=======
>>>>>>> a2c85046356632145c3f23b0c30627ff501a74cf
}
