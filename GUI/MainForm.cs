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

    public partial class MainForm : Form
    {
        Context Context = new Context();
        public MainForm()
        {
            InitializeComponent();
            viewCalls = new BindingList<viewCall>(Context.Calls.ToList().Select(call=>new viewCall(call)).ToList());
            viewContacts = new BindingList<viewContact>(Context.Contacts.ToList().Select(contact=>new viewContact(contact)).ToList());
        }
        private BindingList<viewCall> viewCalls;
        private BindingList<viewContact> viewContacts;
        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = viewContacts;

        }


        private void addRow(IModel model)
        {
            if (model is Call)
                viewCalls.Add(new viewCall((Call)model));
            else
                viewContacts.Add(new viewContact((Contact)model));

        }

        private void callsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = viewCalls;

        }

        private void moreInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form moreInfo;
            var choseItem = dataGrid.SelectedRows[0].DataBoundItem;
            if (choseItem is viewCall)
            {
                moreInfo = new CallInfo((Call)((viewCall)choseItem).GetData());
            }
            else
            {
                moreInfo = new ContactInfo((Contact)((viewContact)choseItem).GetData());
            }
            moreInfo.ShowDialog();
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // referContacts = new referContacts();
            //referContacts.ShowDialog();
        }

        private void addContactToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var addContact = new ContactInfo();
            Hide();
            DialogResult dResult = addContact.ShowDialog();
            Show();


            if (dResult==DialogResult.OK)
            {
                addRow(addContact.GetContact);
            }

        }

        private void addCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCallForm = new AddCall();
            var dResult = addCallForm.ShowDialog();
            if (dResult==DialogResult.OK)
            {
                addRow(addCallForm.GetCall);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            contactsToolStripMenuItem_Click(sender, e);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count != 0)
            {
                moreInfoToolStripMenuItem.Enabled = true;
                moreInfoToolStripMenuItem.Visible = true;
            }
            else
            {
                moreInfoToolStripMenuItem.Enabled = false;
                moreInfoToolStripMenuItem.Visible = false;
            }

        }

        private void referenceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var refer= new MoreInfo();
            refer.ShowDialog();
        }
    }
}