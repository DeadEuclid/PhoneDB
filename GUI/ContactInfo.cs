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
    public partial class ContactInfo : Form
    {
        private bool isAddForm;
        private Contact InputContact;
        public ContactInfo(Contact contact)
        {
            InitializeComponent();
            isAddForm = false;
            InputContact = contact;
            Text = "Информация о контакте " + contact.UsageName;
            secondName.Text = contact.SecondName;
            midleName.Text = contact.MidleName;
            firstName.Text = contact.FirstName;
            nickName.Text = contact.Nick;
            coment.Text = contact.Comment;
            phoneNum.Text = contact.PhoneNumber.ToString();
            statisticPanel.Controls.Clear();
            statisticPanel.Controls.Add(new Statistic(contact));

        }


        public ContactInfo()
        {
            InitializeComponent();
            isAddForm = true;
            statisticPanel.Size = new Size(0, 0);

            Text = "Добавление контакта";
            EditOrAdd.Text = "Добавить";
            Delete.Enabled = false;
            Delete.Visible = false;


        }

        private void ContactInfo_Load(object sender, EventArgs e)
        {

        }

        private void Cansel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Contact AssemblyContact(Contact modifingContact)
        {

            modifingContact.SecondName = secondName.Text;
            modifingContact.FirstName = firstName.Text;
            modifingContact.MidleName = midleName.Text;
            modifingContact.Nick = nickName.Text;
            modifingContact.Comment = coment.Text;
            modifingContact.PhoneNumber =phoneNum.Text;
            return modifingContact;
        }
        private Contact AssemblyContact()
        {
            var result = new Contact();
            AssemblyContact(result);

            return result;
        }

        private void EditOrAdd_Click(object sender, EventArgs e)
        {
            var context = new Context();

            if (isAddForm)
            {

                GetContact=AssemblyContact();
                context.Contacts.Add(GetContact);
                context.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                if (context.Contacts.Any())
                {
                var contact = context.Contacts.Where(cont => cont.Id == InputContact.Id).First();
                AssemblyContact(contact);
                context.SaveChanges();

                }

            }
            Close();

        }
        public Contact GetContact { get; private set; }
        private void contactGroup_Enter(object sender, EventArgs e)
        {

        }

        private void butonsGroup_Enter(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}

