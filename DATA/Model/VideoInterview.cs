using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Model
{
    public class VideoInterview
    {
        public int Id { get; set; }
        public string InterviewQuestions { get; set; }
        public string AdditionalInfo { get; set; }
        public TimeSpan MaxDuration { get; set; }
        public int SecondsMinute { get; set; }
        public DateTime Deadline { get; set; }
        
    }
}




