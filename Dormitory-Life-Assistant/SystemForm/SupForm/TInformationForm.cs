using Dormitory_Life_Assistant;
using Dormitory_Life_Assistant.Service;
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
    public partial class TInformationForm : UIPage
    {
        private Supervisor supervisor;
        private DormMessageService messageService = new DormMessageService();
        public TInformationForm(Supervisor supervisor)
        {
            InitializeComponent();
            dormMessageBindingSource.DataSource = messageService.DormMessages;
            this.supervisor = supervisor;
            uiComboBox1.SelectedIndex = 0;
            CostDataGridView.AllowUserToAddRows = false;
        }

        public void QueryAll()
        {
            dormMessageBindingSource.DataSource = messageService.DormMessages;
            dormMessageBindingSource.ResetBindings(false);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MessageEdit2 me = new MessageEdit2(supervisor);
            me.uiLabel1.Text = "通知内容";
            me.ShowDialog();
            messageService.AddDormMessage(me.DormMessage);
            QueryAll();
        }
        private void DetailButton_Click(object sender, EventArgs e)
        {
            DormMessage dm = dormMessageBindingSource.Current as DormMessage;
            if (dm == null)
            {
                UIMessageBox.Show("请选择一个消息.");
                return;
            }
            InformationChildForm icf = new InformationChildForm(dm);
            icf.ShowDialog();
            QueryAll();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            switch (uiComboBox1.SelectedIndex)
            {
                case 0://所有消息
                    dormMessageBindingSource.DataSource = messageService.DormMessages;
                    break;
                case 1://根据内容
                    dormMessageBindingSource.DataSource = messageService.QueryDormMessagesByContent(BreakdownIndex.Text);
                    break;
                case 2://根据日期
                    dormMessageBindingSource.DataSource = messageService.QueryDormMessagesByDate(BreakdownIndex.Text);
                    break;
                case 3:
                    dormMessageBindingSource.DataSource = messageService.QueryDormMessagesByPerson(BreakdownIndex.Text);
                    break;
            }
            dormMessageBindingSource.ResetBindings(false);
        }
    }
}
