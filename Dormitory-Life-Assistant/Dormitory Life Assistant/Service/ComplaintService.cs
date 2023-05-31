using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class ComplaintService
    {
        List<Complaint> complain;//可能要添加所有投诉的表，方便查找
        List<Supervisor> supervisors;//可能要添加所有宿管的表，方便查找
        List<Student> students;//可能要添加所有学生的表，方便查找
        //public bool addcomplaint(complaint c, student stu)
        //{//添加投诉信息，默认仅有学生能发布投诉                                                                     
        //    var query = from com in complain//在总表中查找对应的投诉信息
        //                where com == c
        //                select com;
        //    if (query.count() > 0)//若找到，说明此投诉已存在，则发生错误，添加失败
        //    {
        //        return false;
        //    }

        //    complain.add(c);//在总投诉表中添加此投诉

        //    stu.complain.add(c);//在此学生对象的投诉表中添加此投诉

        //    string bn = stu.buildingname;
        //    building b = new building(bn);//挑选这样的宿管，他们管理的楼栋包含提交投诉的学生所在的楼栋，即他们管理该学生
        //    var query1 = from sup in supervisors
        //                 where sup.managebuilding.contains(b)
        //                 select sup;
        //    foreach (var v1 in query1)//给查找到的所有宿管推送这条投诉
        //    {
        //        v1.complain.add(c);
        //    }

        //    return true;//添加成功
        //}
        //public bool deletecomplaint(complaint c)
        //{//删除投诉信息
        //    var query = from com in complain//在总表中查找对应的投诉信息
        //                where com == c
        //                select com;
        //    if (query.count() == 0) //若没找到，说明还不存在此投诉，则发生错误，删除失败
        //    {
        //        return false;
        //    }

        //    complain.remove(c);//在总投诉表中删除此投诉

        //    var query1 = from sup in supervisors//查找这样的宿管，他们的投诉表中有这条投诉
        //                 where sup.complain.contains(c)
        //                 select sup;
        //    foreach (var v1 in query1)//查找到的所有宿管删除这条投诉信息
        //    {
        //        v1.complain.remove(c);
        //    }

        //    var query2 = from stu in students//查找这样的学生，他们的投诉表中有这条投诉
        //                 where stu.complain.contains(c)
        //                 select stu;
        //    foreach (var v2 in query2)//查找到的所有学生删除这条投诉
        //    {
        //        v2.complain.remove(c);
        //    }
        //    return true;//删除成功
        //}
        //public complaint searchcomplaint(list<complaint> complaints, string id)
        //{//通过id匹配查询投诉信息
        //    foreach (complaint c in complaints)//也可通过总表查
        //    {
        //        if (c.id == id)
        //        {
        //            return c;
        //        }
        //    }
        //    return null;
        //}
        //public bool modifycomplaint(complaint oldc, complaint newc)
        //{//修改投诉信息 根据id，也可以根据其他
        //    var query = from com in complain//在总表中查找对应的投诉信息
        //                where com == oldc
        //                select com;
        //    if (query.count() == 0) //若没找到，说明还不存在此投诉，则发生错误，修改失败
        //    {
        //        return false;
        //    }

        //    complain.remove(oldc);//在总投诉表中删除旧投诉
        //    complain.add(newc);//在总投诉表中添加投诉

        //    var query1 = from sup in supervisors//查找这样的宿管，他们的投诉表中有旧投诉
        //                 where sup.complain.contains(oldc)
        //                 select sup;
        //    foreach (var v1 in query1)//查找到的所有宿管更新这条投诉信息
        //    {
        //        v1.complain.remove(oldc);
        //        v1.complain.add(newc);
        //    }

        //    var query2 = from stu in students//查找这样的学生，他们的投诉表中有旧投诉
        //                 where stu.complain.contains(oldc)
        //                 select stu;
        //    foreach (var v2 in query2)//查找到的所有学生更新这条投诉
        //    {
        //        v2.complain.remove(oldc);
        //        v2.complain.add(newc);
        //    }

        //    return true;//修改成功
        //}
    }
}
