using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant.Service
{
    public class AdministratorService
    {
        public AdministratorService() { }

        //查询是否存在该用户的头像
        public bool IsExistImage(string uploderId)
        {
            using (var ctx = new SystemContext())
            {
                var image = ctx.SaveImages
                    .SingleOrDefault(s => s.Uploader == uploderId);
                if (image == null) { return false; }
                return true;
            }
        }

        //删除学生的旧头像
        public void DeleteAdmImage(string uploderId)
        {
            using (var ctx = new SystemContext())
            {
                var image = ctx.SaveImages
                    .SingleOrDefault(s => s.Uploader == uploderId);
                ctx.SaveImages.Remove(image);
                ctx.SaveChanges();
            }
        }
    }
}
