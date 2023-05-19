using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class ComplaintServicce
    {
        public void addComplaint(Complaint c);//添加后自动发布给宿管
        public void deleteComplaint(list<Complaint> c);//添加错了之后删除
        public void searchComplaint(list<Complaint> c);//通过id匹配查询
        public void modifyComplaint(list<Complaint> c);//缴费之后修改状态

    }
}
