using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CallInfo : Form
    {
        private Call InputCall;
        public CallInfo(Call call)
        {
            InputCall = call;
            InitializeComponent();
            secondName.Text =   call.Caller==null?"":call.Caller.SecondName;
            midleName.Text = call.Caller == null ? "" : call.Caller.MidleName;
            firstName.Text = call.Caller == null ? "" : call.Caller.FirstName;
            nickName.Text = call.Caller == null ? "" : call.Caller.Nick;
            description.Text =      call.Description;
            phoneNum.Text = call.Caller== null ? "" : call.Caller.PhoneNumber;
            topic.Text = call.Topic;
            timeStart.Text = call.StartTimeToString;
            duration.Text = call.DurationToString;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var context = new Context();
            var call = context.Calls.Where(c => c.Id == InputCall.Id).First();
            GetCall(call);
            context.SaveChanges();

            Close();
        }

        private Call GetCall(Call modyfingCall)
        {
            modyfingCall.Description = description.Text;
            modyfingCall.Topic = topic.Text;
            return modyfingCall;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
