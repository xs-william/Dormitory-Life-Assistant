using Dormitory_Life_Assistant;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dormitory_Life_Assistant;
using MySql.Data.MySqlClient;
using System.Configuration;
using Dormitory_Life_Assistant.EntityClass;
using Org.BouncyCastle.Crypto.Engines;

namespace SystemForm
{
    public partial class StuRepairSon : UIForm
    {

        Student stu;
        SaveImage thisImage;//用来接收用户提交的图像

        public StuRepairSon(Student stu)
        {
            InitializeComponent();
            this.stu = stu;
            uiAvatar1.FillColor = Color.Transparent;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            RepairServicce repairServicce = new RepairServicce();
            if (thisImage == null)
            {
                Repair r = new Repair(0, uiTextBox1.Text, stu.StudentId, "NULL");
                repairServicce.addRepair(r);
            }
            else
            {
                Repair r = new Repair(0, uiTextBox1.Text, stu.StudentId, thisImage.ImageId);
                repairServicce.addRepair(r);

            }
            this.Close();//点击提交后关闭界面

        }

        //保存图片函数
        private void SaveImageToDatabase(string imagePath, string uploadDorm, string uploader)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(imagePath);
                    img.Save(ms, img.RawFormat);
                    imageData = ms.ToArray();
                }

                //创建一个图像对象用来存放选择的图像
                SaveImage image = new SaveImage()
                {
                    ImageData = imageData,
                    UploadDorm = uploadDorm,
                    Uploader = uploader
                };

                thisImage = image;//将创建的图像传给thisImage

                string connectionString = ConfigurationManager.ConnectionStrings["DLADataBase"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    //选择要插入的表和属性
                    string insertQuery = "INSERT INTO SaveImages (ImageId,ImageData, UploadDorm,Uploader) VALUES (@imageId,@imageData, @uploadDorm,@uploader)";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    //添加各个属性对应的值
                    command.Parameters.AddWithValue("@imageData", image.ImageData);
                    command.Parameters.AddWithValue("@uploadDorm", image.UploadDorm);
                    command.Parameters.AddWithValue("@uploader", image.Uploader);
                    command.Parameters.AddWithValue("@imageId", image.ImageId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("图片已上传并保存到数据库。");
            }
        }




        //选择图片并保存
        private void uiAvatar1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                uiAvatar1.Image = Image.FromFile(imagePath);
                SaveImageToDatabase(imagePath, stu.DormNumber, stu.StudentId);
            }

        }
    }
}
