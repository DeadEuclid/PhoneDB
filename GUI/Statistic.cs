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
            inCalls = (List<Call>)GetCallOfType(context.Calls.ToList(),true) ;
             outCalls = (List<Call>)GetCallOfType(context.Calls.ToList(),false);
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

        private ICollection<Call> GetCallOfType(ICollection<Call> calls,bool isInput)
        { 
        return calls.ToList().Where(call => call.IsInput==isInput).ToList();
        }
        private ICollection<Call> GetContactCall(ICollection<Call> calls,Contact contact)
        {
            return calls.Where(call=>call.Caller.Id==contact.Id).ToList();
        }


        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
