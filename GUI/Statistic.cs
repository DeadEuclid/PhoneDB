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
        List<Call> inCalls;
        List<Call> outCalls;
        public Statistic(Contact contact)
        {
            var context = new Context();
            inCalls = (List<Call>)GetInCall(context.Calls.ToList()) ;
             outCalls = (List<Call>)GetInCall(context.Calls.ToList());
            InitializeComponent();

            inCalls = (List<Call>)GetContactCall(inCalls, contact);
            outCalls = (List<Call>)GetContactCall(outCalls, contact);



                var sumInDuration= new TimeSpan(  inCalls.ToList().Select(call=>call.Duration.Ticks).Sum());
                var sumOutDuration= new TimeSpan(  outCalls.Select(call=>call.Duration.Ticks).Sum());

                CountIn.Text = inCalls.Count().ToString();
                CountOut.Text = outCalls.Count().ToString();
                DurationIn.Text = sumInDuration.ToString();
                DurationOut.Text = sumOutDuration.ToString();

        }
        public Statistic()
        {
                CountIn.Text = inCalls.Count().ToString();
                CountOut.Text = outCalls.Count().ToString();
                DurationIn.Text =GetSumDuration(inCalls).ToString();
                DurationOut.Text = GetSumDuration(outCalls).ToString();
        }
        private ICollection<Call> GetInCall(ICollection<Call> calls)
        { 
        return calls.ToList().Where(call => call.IsInput).ToList();
        }
        private ICollection<Call> GetContactCall(ICollection<Call> calls,Contact contact)
        {
            return calls.Where(call=>call.Caller==contact).ToList();
        }
        private TimeSpan GetSumDuration(ICollection<Call> calls)
        {
            return new TimeSpan( calls.Select(call => call.Duration.Ticks).Sum());
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
