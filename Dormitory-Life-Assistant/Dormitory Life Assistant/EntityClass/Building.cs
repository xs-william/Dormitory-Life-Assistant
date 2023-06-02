using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    public class Building
    {
        public string BuildingName//楼栋名
        {
            get; set;
        }
        List<Dorm> DormContent;//包含宿舍
        public Building(string buildingName)
        {
            this.BuildingName = buildingName;
        }        
        public override bool Equals(object obj)//重写equals，利用楼栋号判断对象是否相等
        {
            Building b = obj as Building;
            return b.BuildingName==BuildingName;
        }

    }


}
