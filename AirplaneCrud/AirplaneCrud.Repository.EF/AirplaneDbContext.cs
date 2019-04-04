using AirplaneCrud.Repository.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AirplaneCrud.Repository.EF
{
    internal class AirplaneDbContext : DbContext
    {
        internal DbSet<Airplane> Airplanes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(($"Data Source={AppContext.BaseDirectory}airplane.db"));
        }
    }
}