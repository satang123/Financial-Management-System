using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financial_Management_System.Models
{
    public class Branch
    {
        public int Region_code { get; set; }
        public int Br_code { get; set; }
        public string Br_name { get; set; }
        public int Manager_code { get; set; }
        public DateTime Posting_date { get; set; }
    }
}