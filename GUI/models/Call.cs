using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GUI
{

    public class Call
    {
        public Call()
        {
        }

        public Call(Contact caller, bool input, DateTime startTime, TimeSpan duration, string topic, string description)
        {
            Caller = caller;
            IsInput = input;
            StartTime = startTime;
            Duration = duration;
            Topic = topic;
            Description = description;
        }

        public int Id { get; set; }
        public virtual Contact Caller { get; set; }
        public bool IsInput { get; set; }
        public string Type => IsInput ? "Входящий" : "Исходящий";
        public DateTime StartTime { get; set; }
        [NotMapped]

        public string StartTimeToString => StartTime.ToString("hh:mm:ss d MMM yyyy");
        public TimeSpan Duration { get; set; }
        [NotMapped]

        public string DurationToString => Duration.ToString("hh:mm:ss");

        public string Topic { get; set; }
        
        public string Description { get; set; }

    }
}

