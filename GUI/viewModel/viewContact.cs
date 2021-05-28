using System.ComponentModel;
using System.Data;
using System.Linq;

namespace GUI
{
    public class viewContact: IViewModel
    {
        Context Context = new Context();
        public viewContact(Contact contact)
        {
            Contact = contact;
            Name = contact.UsageName;
            PhoneNumber = contact.PhoneNumber;
            inCount = Context.Calls.Where(call => call.Id == contact.Id && call.IsInput == true).Count().ToString();
            outCount = Context.Calls.Where(call => call.Caller.Id == contact.Id && call.IsInput == false).Count().ToString();

        }
        [DisplayName("Имя контакта")]
        public string Name { get; set; }
        [DisplayName("Номер")]

        public string PhoneNumber { get; set; }
        [DisplayName("Кол-во входящих")]
        public string inCount { get; set; }

        [DisplayName("Кол-во исходящих")]
        public string outCount { get; set; }
        public Contact Contact;

        public IModel GetData()
        {
            return Contact;
        }
    }

}