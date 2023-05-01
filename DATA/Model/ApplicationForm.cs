using DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Model
{
    public class ApplicationForm
    {
        public int ApplicationFormId { get; set; }
        public string UploadImage { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Place { get; set; }
        public string Nationality { get; set; }
        public string CurrentRecidence { get; set; }
        public string NumberId { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; }
        public string  Resume { get; set; }
        public string AboutYourself { get; set; }
        public string Question { get; set; }






    }
}
