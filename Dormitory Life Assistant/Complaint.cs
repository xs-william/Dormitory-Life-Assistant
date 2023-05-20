using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant
{
    internal class Complaint
    {
        Blob Picture;
        bool status;
        String Content;
        DateTime ComplaintTime;
        String ID;
    }
}
