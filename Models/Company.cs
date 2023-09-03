using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financial_Management_System.Models
{
    public class Company
    {
        public string Name { get; set; }   
        public int Street_number { get; set; }
        public string Street_name { get; set; }
        public int Phone_number { get; set; }
        public int Po_box_number { get; set; }
        public string Town { get; set; }
    }
}