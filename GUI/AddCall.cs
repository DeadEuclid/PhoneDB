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
    public partial class AddCall : Form
    {
        public AddCall()
        {
            var context = new Context();
            InitializeComponent();
           
            timer1.Start();
           
            var time = DateTime.Now;

            minuteStart.Value = time.Minute;
            hourStart.Value = time.Hour;

            caller.DataSource = context.Contacts.ToList();
            caller.ValueMember="Id";
            caller.DisplayMember = "Title";

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            second.Value++;
            second.Update();

        }

        private void secund_ValueChanged(object sender, EventArgs e)
        {
            if (second.Value == 60)
            {
                second.Value = 0;
                second.Update();
                minute.Value++;


            }
        }

        private void minute_ValueChanged(object sender, EventArgs e)
        {
            if (minute.Value == 60)
            {
                second.Value = 0;
                second.Update();
                minute.Value++;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCall_Load(object sender, EventArgs e)
        {

        }
        public Call GetCall{get;set;}

        private void button3_Click(object sender, EventArgs e)
        {
            var context = new Context();
            var result = new Call();

            result.Caller = context.Contacts.ToList().First(c=>c.Id==(int)caller.SelectedValue);
            result.Description = Description.Text;
            result.Topic = Topic.Text;

            var dateStartValue = dateStart.Value;

            result.StartTime =
                new DateTime(dateStartValue.Year, dateStartValue.Month, dateStartValue.Day,
                (int)hourStart.Value, (int)minuteStart.Value,0);

            result.IsInput = Type.Text == "Входящий" ? true : false;
            result.Duration = new TimeSpan((int)hour.Value, (int)minute.Value, (int)second.Value);

            context.Calls.Add(result);
            GetCall = result;
            DialogResult = DialogResult.OK;
            context.SaveChanges();

        }
    }
}
