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
using Sunny.UI;

namespace SystemForm
{
    public partial class ScheduleForm : UIForm
    {
        Student Student { get; set; }
        public ScheduleForm(Student student)
        {
            InitializeComponent();
            this.Student = student;
            scheduleBindingSource.DataSource = QueryScheduleByID(student.StudentId);
            uiDataGridView1.AllowUserToAddRows = false;
        }
        //查询备忘录
        public List<Schedule> QueryScheduleByID(string id)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Schedules
                  .Where(message => message.ID.Contains(id))
                  .OrderByDescending(schedule => schedule.Date)
                  .ToList();
            }
        }
        //添加备忘录
        public void AddScheduleIn(Schedule schedule)
        {

            using (var ctx = new SystemContext())
            {
                ctx.Entry(schedule).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
            }
        }
        //删除备忘录
        public void DeleteSchedule(Guid scheduleID)
        {
            using (var ctx = new SystemContext())
            {
                var schedule = ctx.Schedules
                  .SingleOrDefault(s => s.scheduleid == scheduleID);
                if (schedule == null) return;
                ctx.Schedules.Remove(schedule);
                ctx.SaveChanges();
            }
        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
            string memo = uiTextBox1.Text;
            DateTime deadline = uiTextBox2.Text.ToDateTime();
            string isoutdate = "未过期";
            Schedule schedule = new Schedule() { ID = Student.StudentId, Content = memo, Date = deadline, status = isoutdate };
            AddScheduleIn(schedule);
            // 创建新的备忘信息项
            scheduleBindingSource.DataSource = QueryScheduleByID(Student.StudentId);

            // 检查截止时间是否已过期
            //DateTime deadlineDateTime;
            //if (DateTime.TryParse(deadline < DateTime.Now))
            //{
            //    item.BackColor = Color.Red; // 设置已过期项的背景色为红色
            //    item.SubItems[2].Text = "已过期";
            //}

            //// 添加备忘信息项到列表
            //DataGridView.Items.Add(item);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Schedule schedule = scheduleBindingSource.Current as Schedule;
            if (schedule != null) DeleteSchedule(schedule.scheduleid);
            scheduleBindingSource.DataSource = QueryScheduleByID(Student.StudentId);

        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) // 假设截止时间列的索引为2
            {
                DateTime deadlineDateTime;
                if (DateTime.TryParse(e.Value.ToString(), out deadlineDateTime) && deadlineDateTime < DateTime.Now)
                {
                    e.CellStyle.BackColor = Color.Red; // 设置已过期项的背景色为红色
                    uiDataGridView1.Rows[e.RowIndex].Cells[2].Value = "已过期";
                }
            }
        }
    }
}
