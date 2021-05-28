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
            secondName.Text =   call.Caller.SecondName;
            midleName.Text = call.Caller.MidleName;
            firstName.Text = call.Caller.FirstName;
            nickName.Text = call.Caller.Nick;
            description.Text =      call.Description;
            phoneNum.Text = call.Caller.ToString();
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
            var call = context.Calls.Where(c => c == InputCall).First();
            GetCall(call);
            context.SaveChanges();
        }

        private Call GetCall(Call modyfingCall)
        {
            modyfingCall.Description = description.Text;
            modyfingCall.Topic = topic.Text;
            return modyfingCall;
        }
    }
}
