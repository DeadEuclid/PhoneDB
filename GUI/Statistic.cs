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
    public partial class Statistic : UserControl
    {
        public Statistic(Contact contact)
        {
            var context = new Context();
            var inCall = GetInCall(context.Calls);
            var outCall = GetInCall(context.Calls);
            InitializeComponent();
            if (contact!=null)
            {
                inCall = GetContactCall(inCall, contact);
                outCall = GetContactCall(outCall, contact);


                var sumInDuration= new TimeSpan(  inCall.Select(call=>call.Duration.Ticks).Sum());
                var sumOutDuration= new TimeSpan(  outCall.Select(call=>call.Duration.Ticks).Sum());

                CountIn.Text = inCall.Count().ToString();
                CountOut.Text = outCall.Count().ToString();
                DurationIn.Text = sumInDuration.ToString();
                DurationOut.Text = sumOutDuration.ToString();
            }
            else
            {
                CountIn.Text = inCall.Count().ToString();
                CountOut.Text = outCall.Count().ToString();
                DurationIn.Text =GetSumDuration(inCall).ToString();
                DurationOut.Text = GetSumDuration(outCall).ToString();
            }
        }
        private IQueryable<Call> GetInCall(IQueryable<Call> calls)
        { 
        return calls.Where(call => call.IsInput);
        }
        private IQueryable<Call> GetContactCall(IQueryable<Call> calls,Contact contact)
        {
            return calls.Where(call=>call.Caller==contact);
        }
        private TimeSpan GetSumDuration(IQueryable<Call> calls)
        {
            return new TimeSpan( calls.Select(call => call.Duration.Ticks).Sum());
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
