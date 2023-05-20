using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;



namespace Dormitory_Life_Assistant
{
    internal class Repair
    {
        Blob Picture;//图片
        string Content;
        DateTime RepairTime;//报修时间
        bool Status;//是否已经解决
        string ID;//id用来查询报修信息
    }
}
