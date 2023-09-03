using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Financial_Management_System.Models
{
    public class Manager
    {
        public int Manager_code { get; set; }
        public string Br_mg_firstname { get; set;}
        public string Br_mg_middlename { get;set;}
        public string Br_mg_surname { get;set;}
        public string Gender { get; set; }
        public DateTime StartDate { get; set; }
        public int Br_mg_phone_1 { get; set;}
        public int Br_mg_phone_2 { get;set;}
        public string Br_mg_email { get; set;}

        // Define relationships
        public virtual Branch Branch { get; set; }
        public virtual ICollection<TransferHistory> Transfers { get; set; }

    }
}