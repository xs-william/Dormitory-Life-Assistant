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

namespace SystemForm
{
    public partial class StuMessage : UIPage
    {
        MessageService messageService = new MessageService();
        private Student student;
        public StuMessage(Student me)
        {
            InitializeComponent();
            student = me;
            uiDataGridView1.DataSource = messageService.getAllMessage(student.StudentId);
        }
        //双击某单元可以查看该消息的详细数据
        private void uiDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string CellValue = this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "\n" +
                "\t\t\t\t" + this.uiDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "\n" +
                "\t\t\t" + this.uiDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            UIMessageDialog.ShowMessageDialog(CellValue, "消息详细", false, Style);
        }
    }
}
