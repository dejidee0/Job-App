using Microsoft.EntityFrameworkCore;
using System;

namespace DATA.Model
{
    public class ProgramDetails
    {
        public int ProgramDetailsId { get; set; } 
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string KeySlides { get; set; }
        public string ProgramBenefits { get; set; }
        public string ApplicationCriteria { get; set; }
        public string ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplicationOpen { get; set; }
        public DateTime ApplicationClose { get; set; }
        public TimeSpan Duration { get; set; }
        public string ProgramLocation { get; set; }
        public string MinQualification { get; set; }
        public int MaxApplications { get; set; }
    }
}
