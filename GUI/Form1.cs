using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.Context;

namespace GUI
{

    public partial class Form1 : Form
    {
        Context Context = new Context();
        public Form1()
        {
            InitializeComponent();

        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            addRow("Имя", "name");
            addRow("Номер телефона", "number");
            addRow("Общая продолжительность", "dur");
            addRow("Кол-во принятых вызовов", "inpCount");
            addRow("Кол-во совершённых вызовов", "outCount");


            BindingList<viewContact> contacts;
            contacts = new BindingList<viewContact>(Context.Contacts.ToList().Select(contact => new viewContact(contact)).ToList());
            dataGridView1.DataSource = contacts;

        }
        private void addRow(string name, string codeName)
        {

            var column1 = new DataGridViewColumn();
            column1.HeaderText = name; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = codeName; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

        }

        private void callsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();


            BindingList<viewCall> calls;
            calls = new BindingList<viewCall>(Context.Calls.ToList().Select(call => new viewCall(call)).ToList());
            dataGridView1.DataSource = calls;
        }

        private void moreInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form moreInfo;
            var choseItem = dataGridView1.SelectedRows[0].DataBoundItem;
            if (choseItem is viewCall)
            {
                //moreInfo = new CallInfo(((viewCall)choseItem).GetData());
            }
            else
            {
                //moreInfo = new ContactInfo(((viewContact)choseItem).GetData());
            }
            //moreInfo.ShowDialog();
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            referContacts referContacts = new referContacts();
            referContacts.ShowDialog();
        }

        private void addContactToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCall addContact = new AddCall();
            Hide();
           DialogResult dResult=  addContact.ShowDialog();
            Show();
            if (dResult==DialogResult.OK)
            {
                //addContact.Contact
            }
        }

        private void addCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCallForm = new AddCall();
           var dResult=  addCallForm.ShowDialog();

        }
    }
    public class viewCall :IViewModel
    {
        public viewCall(Call call)
        {
            Call = call;
            Name = call.Caller.UsageName;
            Type = call.Type;
            Date = call.StartTimeToString;
            Duration = call.DurationToString;
        }
        [DisplayName("Имя контакта")]
        public string Name { get; set; }
        [DisplayName("Тип")]
        public string Type { get; set; }
        [DisplayName("Время начала")]
        public string Date { get; set; }
        [DisplayName("Продолжительность")]
        public string Duration { get; set; }
        private Call Call;

        public IViewModel GetData()
        {
            return (IViewModel)Call;
        }
    }
    public class viewContact: IViewModel
    {
        Context Context = new Context();
        public viewContact(Contact contact)
        {
            Contact = contact;
            Name = contact.UsageName;
            inCount = Context.Calls.Where(call => call.Caller == contact && call.IsInput == true).Count().ToString();
            outCount = Context.Calls.Where(call => call.Caller == contact && call.IsInput == false).Count().ToString();
            outCount = Context.Calls.Where(call => call.Caller == contact).Count().ToString();
        }
        [DisplayName("Имя контакта")]
        public string Name { get; set; }
        [DisplayName("Номер")]

        public string PhoneNumber { get; set; }
        [DisplayName("Количество входящих вызовов")]

        public string inCount { get; set; }
        [DisplayName("Кол-во принятых  вызовов")]

        public string outCount { get; set; }
        public Contact Contact;

        public IViewModel GetData()
        {
            return (IViewModel)Contact;
        }
    }
    public interface IViewModel
    {
        IViewModel GetData();
    }

}