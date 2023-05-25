using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class Dorm
    {
        String BuildingName; //楼栋名
        public String DormNumber; //宿舍号
        String ID;//每个宿舍的id
        String DormHead;//宿舍长
        public List<Student> Member;//宿舍成员
    }
}
