using Dormitory_Life_Assistant;
using Google.Protobuf.WellKnownTypes;
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

namespace SystemForm
{
    public partial class StuTreeHole : UIPage
    {
        Student Student { get; set; }
        public StuTreeHole(Student student)
        {

            InitializeComponent();
            uiButton3.Visible = true;
            this.Student = student;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string message = uiTextBox1.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                AddMessage(Student.StudentName, message);
                uiTextBox1.Clear();
            }
        }
        public List<Treehole> treeholes()
        {

            using (var ctx = new SystemContext())
            {
                return ctx.Treeholes
                .ToList<Treehole>();
            }

        }

        public void AddTreehole(Treehole treehole)
        {

            using (var ctx = new SystemContext())
            {
                ctx.Entry(treehole).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
            }
        }
        private void AddMessage(string sender, string message)
        {
            Treehole treehole = new Treehole();
            treehole.time = DateTime.Now;
            treehole.name = Student.StudentName;
            treehole.studentid = Student.StudentId;
            treehole.content = message;
            AddTreehole(treehole);
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            string formattedMessage = $"[{timestamp}] {sender}: {message}";
            uiRichTextBox1.AppendText(formattedMessage + Environment.NewLine);
        }



        private void uiButton3_Click(object sender, EventArgs e)
        {
            List<Treehole> listtreehole = treeholes();

            for (int i = 0; i < listtreehole.Count; i++)
            {
                string formattedMessage = $"[{listtreehole[i].time.ToString("HH:mm:ss")}] {listtreehole[i].name}: {listtreehole[i].content}";
                if (listtreehole[i].content == "已撤回")
                {
                    uiRichTextBox1.SelectionStart = uiRichTextBox1.TextLength;
                    // 插入文本
                    uiRichTextBox1.AppendText(formattedMessage + Environment.NewLine);

                    // 设置要标红的文本范围
                    uiRichTextBox1.SelectionStart = uiRichTextBox1.Text.Length - (formattedMessage.Length + Environment.NewLine.Length);
                    uiRichTextBox1.SelectionLength = formattedMessage.Length + 1;

                    // 将文本设置为红色
                    uiRichTextBox1.SelectionColor = Color.Red;

                    // 恢复选择范围
                    uiRichTextBox1.SelectionLength = 0;
                }
                else
                    uiRichTextBox1.AppendText(formattedMessage + Environment.NewLine);
            }
            uiButton3.Visible = false;
        }
        public Treehole GetlastTreehole()
        {

            using (var ctx = new SystemContext())
            {
                var treehole = ctx.Treeholes
                    .OrderByDescending(t => t.time) // 按时间属性降序排序
                    .FirstOrDefault();
                if (treehole == null) return null;
                else return treehole;

            }
        }
        private void uiButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Treehole treehole1 = GetlastTreehole();
                Treehole treehole2 = treehole1;
                treehole2.content = "已撤回";
                if (treehole1.name == Student.StudentName)
                {
                    if (treehole1.time < DateTime.Now && treehole1.time > DateTime.Now.AddSeconds(-30))
                    {
                        using (var ctx = new SystemContext())
                        {
                            var treehole = ctx.Treeholes
                                .OrderByDescending(t => t.time) // 按时间属性降序排序
                                .FirstOrDefault();
                            if (treehole == null) return;
                            ctx.Treeholes.Remove(treehole);
                            ctx.SaveChanges();
                        }
                        AddTreehole(treehole2);

                        if (uiRichTextBox1.Lines.Length >= 2)
                        {
                            int lastLineIndex = uiRichTextBox1.Lines.Length - 1;
                            int secondLastLineIndex = uiRichTextBox1.Lines.Length - 2;

                            // Join all lines except the last two
                            string remainingText = string.Join(Environment.NewLine, uiRichTextBox1.Lines.Take(secondLastLineIndex));

                            // Set the remaining text as the new content of the RichTextBox
                            uiRichTextBox1.Text = remainingText + Environment.NewLine;
                            string formattedMessage = $"[{treehole2.time.ToString("HH:mm:ss")}] {treehole2.name}: {treehole2.content}";

                            // 将光标定位到要标红的文本开始位置
                            uiRichTextBox1.SelectionStart = uiRichTextBox1.TextLength;
                            // 插入文本
                            uiRichTextBox1.AppendText(formattedMessage + Environment.NewLine);

                            // 设置要标红的文本范围
                            uiRichTextBox1.SelectionStart = uiRichTextBox1.Text.Length - (formattedMessage.Length + Environment.NewLine.Length);
                            uiRichTextBox1.SelectionLength = formattedMessage.Length + 1;

                            // 将文本设置为红色
                            uiRichTextBox1.SelectionColor = Color.Red;

                            // 恢复选择范围
                            uiRichTextBox1.SelectionLength = 0;

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }


        }


    }
}
