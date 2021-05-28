using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GUI
{

        public class Contact:IModel
        {
            public Contact()
            {
            }
            public int Id { get; set; }

            public string SecondName { get; set; }

            public string FirstName { get; set; }

            public string MidleName { get; set; }

            public string PhoneNumber { get; set; }

            public string Nick { get; set; }

            public string Comment { get; set; }
        [NotMapped]
        public string Title { get { return UsageName + " (" + PhoneNumber + ")"; } }
        [NotMapped]
            private string usageName { get; set; }
            [NotMapped]
            public string UsageName
            {
                get
                {
                    if (Tools.Nulable(Nick) == "")
                        return Tools.Nulable(FirstName) + " " + Tools.Nulable(SecondName) == null ? "" : Tools.Nulable(SecondName);
                    return Nick;
                }
                set { usageName = value; }
            }
        }
    
}
