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
            if (isAddForm= (contact!=null))
            {
                InputContact = contact;
                Text = "Информация и контакте "+contact.UsageName;
                secondName.Text = contact.SecondName;
                midleName.Text = contact.MidleName;
                firstName.Text = contact.FirstName;
                nickName.Text = contact.Nick;
                coment.Text = contact.Comment;
                statisticPanel.Controls.Clear();
                statisticPanel.Controls.Add( new Statistic(contact));

            }
            else
            {
            statisticPanel.Size =new Size(0, 0);

                Text = "Добавление контакта";
                EditOrAdd.Text = "Добавить";
                Delete.Enabled = false;
                Delete.Visible = false;
            }

        }

        private void ContactInfo_Load(object sender, EventArgs e)
        {

        }

        private void Cansel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Contact GetContact(Contact modifingContact)
        {

            modifingContact.SecondName = secondName.Text;
            modifingContact.FirstName = firstName.Text;
            modifingContact.MidleName = midleName.Text;
            modifingContact.Nick = nickName.Text;
            modifingContact.Comment = coment.Text;
            return modifingContact;
        }
        private Contact GetContact()
        {
            var result = new Contact();
            GetContact(result);

            return result;
        }

        private void EditOrAdd_Click(object sender, EventArgs e)
        {
            var context = new Context();

            if (isAddForm)
            {
                context.Contacts.Add(GetContact());
                context.SaveChanges();
            }
            else
            {
                var contact= context.Contacts.Where(cont => cont == InputContact).First();
                GetContact(contact);
                context.SaveChanges();
            }

        }
    }
}
