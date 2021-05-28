using System.ComponentModel;

namespace GUI
{
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

        public IModel GetData()
        {
            return (IModel)Call;
        }
    }

}