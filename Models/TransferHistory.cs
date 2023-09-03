using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financial_Management_System.Models
{
    public class TransferHistory
    {
        public int Manager_code { get; set; }
        public int Br_code { get; set;}
        public DateTime Posting_date { get; set; }
        public DateTime Transfer_date { get; set; }
        public string Remarks { get; set; }
        // Define relationships
        public virtual Manager Manager { get; set; }
        public virtual Branch FromBranch { get; set; }
        public virtual Branch ToBranch { get; set; }
    }
}