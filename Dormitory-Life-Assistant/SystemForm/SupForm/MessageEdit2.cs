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
/*
 * 该窗口用于给学生发送消息与发送宿舍消息
 */
namespace SystemForm
{
    public partial class MessageEdit2 : UIEditForm
    {
        private ExchangeMessage exchangeMessage;
        private DormMessage dormMessage;
        private Supervisor supervisor;
        private Student student;
        public MessageEdit2(Supervisor supervisor, Student student = null)
        {
            InitializeComponent();
            this.supervisor = supervisor;
            this.student = student;
        }
        // 判断内容是否为空
        protected override bool CheckData()
        {
            return CheckEmpty(messageContent, "请输入公告内容");
        }
        // 只提供get，因为只需要得到不需要修改
        public ExchangeMessage ExchangeMessage
        {
            get
            {
                if (exchangeMessage == null)
                {
                    exchangeMessage = new ExchangeMessage();
                }
                exchangeMessage.Content = messageContent.Text;
                exchangeMessage.Time = DateTime.Now;
                exchangeMessage.SupervisorId = supervisor.SupervisorId;
                exchangeMessage.Supervisor = supervisor;
                exchangeMessage.StudentId = student.StudentId;
                exchangeMessage.Student = student;
                return exchangeMessage;
            }
        }
        public DormMessage DormMessage
        {
            get
            {
                if (dormMessage == null)
                {
                    dormMessage = new DormMessage();
                }
                dormMessage.Content = messageContent.Text;
                dormMessage.Time = DateTime.Now;
                dormMessage.SupervisorId = supervisor.SupervisorId;
                dormMessage.Supervisor = supervisor;
                return dormMessage;
            }
        }
    }
}
