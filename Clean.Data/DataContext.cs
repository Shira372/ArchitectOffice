using ArchitectsOffice.Entities;
using Clean.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clean.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Architect> Architects { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Meeting> Meetings { get; set; }

        //connection string
        //Server=(localdb)\mssqllocaldb;Database=my_db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //לפי מה שהתקנתי על הפרויקט שלי
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=my_db");
            optionsBuilder.LogTo(message=>Debug.WriteLine(message));

        }

    }
}





















