using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class Context : DbContext,IModel
    {
        public Context() : base("PhoneDb")
        {
        }
        public DbSet<Contact> Contacts { get; set; }  
        public DbSet<Call> Calls { get; set; }
    }
    static public class Tools
    {
        static public string Nulable(string str)
        {
            return str == null ? "" : str;
        }

    }
}
