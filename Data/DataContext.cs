using System;
using Express_Voiture.Models;
using Microsoft.EntityFrameworkCore;

namespace Express_Voiture.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Voiture> Voitures { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}

