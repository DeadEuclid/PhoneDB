using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace PhoneDB
{
    public class Context : DbContext
    {
        protected Context() : base("PhoneDb")
        {
        }
        public class Person
        {
            public Person()
            {
            }
            public int Id { get; set; }

            public string SecondName { get; set; }

            public string FirstName { get; set; }

            public string MidleName { get; set; }
            [DisplayName("Номер телефона")]
            public int PhoneNumber { get; set; }

            public string Nick { get; set; }

            public string Comment { get; set; }
            private string usageName { get; set; }
            [NotMapped]
            [DisplayName("Имя")]
            public string UsageName
            {
                get
                { 
                    if (Tools.Nulable(Nick) == "")
                        return Tools.Nulable(FirstName) + " " + Tools.Nulable(SecondName) == null ? "" : Tools.Nulable(SecondName);
                    return Nick;
                }
                set { usageName= value; }
            }
        }
        public class Call
        {
            public Call()
            {
            }
            public int Id { get; set; }
            public virtual Person Caller { get; set; }
            public bool Input { get; set; }
            public string Type => Input ? "Входящий" : "Исходящий";
            public DateTime StartTime { get; set; }
            [NotMapped]
            [DisplayName("Начало звонка")]
            public string StartTimeToString => StartTime.ToString("hh:mm:ss d MMM yyyy");
            public TimeSpan Duration { get; set; }
            [NotMapped]
            [DisplayName("Продолжительность")]
            public string DurationToString => Duration.ToString("hh:mm:ss");
            [DisplayName("Тема звонка")]
            public string Topic { get; set; }
            [DisplayName("Описание звонка")]
            public string Description { get; set; }
            
        }
    }
    static public class Tools
    {
        static public string Nulable(string str)
        {
            return str == null ? "" : str;
        }
    }
}
