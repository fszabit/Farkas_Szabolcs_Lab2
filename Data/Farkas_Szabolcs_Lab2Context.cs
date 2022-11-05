using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Farkas_Szabolcs_Lab2.Models;

namespace Farkas_Szabolcs_Lab2.Data
{
    public class Farkas_Szabolcs_Lab2Context : DbContext
    {
        public Farkas_Szabolcs_Lab2Context (DbContextOptions<Farkas_Szabolcs_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Farkas_Szabolcs_Lab2.Models.Book> Book { get; set; } = default!;



        public DbSet<Farkas_Szabolcs_Lab2.Models.Publisher> Publisher { get; set; }


        public DbSet<Farkas_Szabolcs_Lab2.Models.Category> Category { get; set; }


       
    }
}
