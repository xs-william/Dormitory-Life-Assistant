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
using Dormitory_Life_Assistant.Service;
using Microsoft.VisualBasic.Devices;
using Org.BouncyCastle.Asn1.X509;

namespace SystemForm
{
    public partial class AdminNotice : UIPage
    {

        private Administrator administrator;
        SystemMessageService systemMessageService;
        public AdminNotice(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            systemMessageService = new SystemMessageService();
            systemMessageBindingSource.DataSource = systemMessageService.SystemMessages;
            uiComboBox1.SelectedIndex = 0;
            uiDataGridView1.AllowUserToAddRows = false;
        }

        // 查询所有系统消息
        public void QueryAll()
        {
            systemMessageBindingSource.DataSource = systemMessageService.SystemMessages;
            systemMessageBindingSource.ResetBindings(false);
        }

        // 根据combobox里面的选项来进行查询
        private void queryButton_Click(object sender, EventArgs e)
        {
            switch (uiComboBox1.SelectedIndex)
            {
                case 0://所有消息
                    systemMessageBindingSource.DataSource = systemMessageService.SystemMessages;
                    break;
                case 1://根据日期查询
                    systemMessageBindingSource.DataSource = systemMessageService.QuerySystemMessagesByDate(queryText.Text);
                    break;
                case 2://根据内容查询
                    systemMessageBindingSource.DataSource = systemMessageService.QuerySystemMessagesByContent(queryText.Text);
                    break;
            }
            systemMessageBindingSource.ResetBindings(false);
        }

        // 修改信息
        private void EditSystemMessage()
        {
            SystemMessage systemMessage = systemMessageBindingSource.Current as SystemMessage;
            if (systemMessage == null)
            {
                MessageBox.Show("请选择一个系统消息进行修改");
                return;
            }
            MessageEdit me = new MessageEdit(administrator, systemMessage);
            me.Text = "修改公告";
            me.Render();
            me.ShowDialog();
            if (me.IsOK)
            {
                ShowSuccessDialog(me.SystemMessage.ToString());
                systemMessageService.ModifySystemMessage(me.SystemMessage);
            }
            me.Dispose();
            QueryAll();
        }
        // 添加信息
        private void addButton_Click(object sender, EventArgs e)
        {
            MessageEdit me = new MessageEdit(administrator);
            me.Text = "新增公告";
            me.Render();
            me.ShowDialog();
            if (me.IsOK)
            {
                ShowSuccessDialog(me.SystemMessage.ToString());
                systemMessageService.AddSystemMessage(me.SystemMessage);
            }
            me.Dispose();
            QueryAll();
        }

        // 修改信息
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            EditSystemMessage();
        }

        // 删除信息
        private void deleteButton_Click(object sender, EventArgs e)
        {
            SystemMessage systemMessage = systemMessageBindingSource.Current as SystemMessage;
            systemMessageService.DeleteSystemMessage(systemMessage.SystemMessageId);
            QueryAll();
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
