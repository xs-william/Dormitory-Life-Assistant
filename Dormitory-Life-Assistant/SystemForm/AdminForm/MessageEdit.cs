using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Dormitory_Life_Assistant;

/*
    系统消息编辑窗口，用于添加信息和修改信息
 */

namespace SystemForm
{
    public partial class MessageEdit : UIEditForm
    {
        private SystemMessage systemMessage;
        private Administrator admin;
        public MessageEdit(Administrator admin, SystemMessage systemMessage = null)
        {
            InitializeComponent();
            TimeNow.Text = DateTime.Now.ToString();
            this.admin = admin;
            this.systemMessage = systemMessage;
            if (systemMessage != null)
            {
                messageContent.Text = systemMessage.Content;
            }
        }
        protected override bool CheckData()
        {
            return CheckEmpty(messageContent, "请输入公告内容");
        }


        private void messageContent_TextChanged(object sender, EventArgs e)
        {

        }


        public SystemMessage SystemMessage
        {
            get
            {
                if (systemMessage == null)
                {
                    systemMessage = new SystemMessage();
                }
                systemMessage.Content = messageContent.Text;
                systemMessage.Time = Convert.ToDateTime(TimeNow.Text);
                systemMessage.AdministratorId = admin.AdministratorId;
                systemMessage.Administrator = admin;
                return systemMessage;
            }
            set
            {
                systemMessage = value;
                systemMessage.Time = Convert.ToDateTime(TimeNow.Text);
                messageContent.Text = value.Content;
            }
        }
    }
}
