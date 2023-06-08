using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dormitory_Life_Assistant;
using Dormitory_Life_Assistant.EntityClass;
using Dormitory_Life_Assistant.Service;
using MySql.Data.MySqlClient;
using Sunny.UI;

namespace SystemForm
{
    public partial class stuMain : UIPage
    {
        private SystemMessageService systemMessageService = new SystemMessageService();
        private DormMessageService dormMessageService = new DormMessageService();
        //SaveImage thisImage;//用来接收用户提交的图像
        string imageID;
        Student stu;
        public stuMain(Student student)
        {
            InitializeComponent();
            this.stu = student;
            systemMessageBindingSource.DataSource = systemMessageService.SystemMessages;
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView2.AllowUserToAddRows = false;
            uiLabel1.Text = student.StudentName;
            sex.Text = student.Gender;
            myclass.Text = student.Class;
            ID.Text = student.StudentId;
            grade.Text = student.Grade.ToString();
            dorm.Text = student.DormNumber;
            departName.Text = student.Department;
            buildingno.Text = student.BuildingName;
            //pictureBox1.Image == null ? pictureBox1.Image = Image.FromFile("../image/默认头像.png") : DisPlayImage('u' + stu.StudentId)
            if (pictureBox1.Image != null)
            {
                DisPlayImage('u' + stu.StudentId);
            }
            else
            {
                pictureBox1.Image = Image.FromFile("../../../image/默认头像.png");

            }

        }



        private void panel_Click(object sender, EventArgs e)
        {

            dormMessageBindingSource.DataSource = dormMessageService.DormMessages;
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView2.AllowUserToAddRows = false;
            uiCalendar1.Date = Convert.ToDateTime(DateTime.Now.ToString("D"));

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            ScheduleForm form = new ScheduleForm(stu);

            form.ShowDialog();
        }

        private void uiLabel6_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel8_Click(object sender, EventArgs e)
        {

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

                //thisImage = image;//将创建的图像传给thisImage

                string connectionString = ConfigurationManager.ConnectionStrings["DLADataBase"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    //选择要插入的表和属性
                    string insertQuery = "INSERT INTO SaveImages (ImageId,ImageData, UploadDorm,Uploader) VALUES (@imageId,@imageData, @uploadDorm,@uploader)";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    //添加各个属性对应的值
                    command.Parameters.AddWithValue("@imageData", image.ImageData);
                    command.Parameters.AddWithValue("@uploadDorm", image.UploadDorm);
                    command.Parameters.AddWithValue("@uploader", 'u' + image.Uploader);//利用前面加u标识是否是用户的头像
                    command.Parameters.AddWithValue("@imageId", image.ImageId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                imageID = image.ImageId;

                MessageBox.Show("图片已上传并保存到数据库。");
            }
        }

        private void DisPlayImage(string imageID)
        {
            byte[] imageData = null;
            using (var ctx = new SystemContext())
            {
                var result = ctx.SaveImages
                        .SingleOrDefault(s => s.Uploader == imageID);
                if (result != null)
                {
                    imageData = result.ImageData;
                }

            }

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox1.Image = image;
                }
            }
            else
            {
                // 如果未找到对应的图片数据，可以显示默认的占位图像或给出提示信息
                pictureBox1.Image = null;
                MessageBox.Show("请点击设置头像");
            }

        }

        private void uiAvatar1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StudentService studentService = new StudentService();

            if (studentService.IsExistImage('u' + stu.StudentId))
            {
                studentService.DeleteStuImage('u' + stu.StudentId);
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
                SaveImageToDatabase(imagePath, stu.DormNumber, stu.StudentId);
            }
            this.Invalidate();
        }
    }
}
