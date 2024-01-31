using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public decimal CFee { get; set; }
        public string Technology { get; set; }
        public DateTime CStartDate { get; set; }
        public DateTime CEndDate { get; set; }

    }

}