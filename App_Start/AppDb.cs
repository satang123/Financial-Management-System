using Financial_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Financial_Management_System.App_Start
{
    public class AppDb:DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<TransferHistory> Transfers { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Regions> Regions { get; set; }

    }
}