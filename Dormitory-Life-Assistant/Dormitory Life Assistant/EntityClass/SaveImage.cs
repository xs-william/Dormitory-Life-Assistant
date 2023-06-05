using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory_Life_Assistant.EntityClass
{
    //用来保存图像,不要用Image类，会与.NET的Image类冲突
    public class SaveImage
    {
        [Key]
        public string ImageId { get; set; }
        public byte[] ImageData { get; set; }
        public string UploadDorm { get; set; }//上传者的宿舍号
        public string Uploader { get; set; }//上传者的ID
        //public ICollection<Repair> Repairs { get; set; } // 导航属性,通过导航属性实现Repair类和SaveImage类中对应属性绑定

        public SaveImage()
        {
            ImageId = Guid.NewGuid().ToString();//每创建一个图像就给它传一个唯一的ID
        }

        public SaveImage(byte[] imageData, string uploadDorm, string uploader)
        {
            ImageId = Guid.NewGuid().ToString();//每创建一个图像就给它传一个唯一的ID
            ImageData = imageData;
            UploadDorm = uploadDorm;
            Uploader = uploader;
        }
    }
}
