using BlazorMatchGame.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMatchGame.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\DBMatchGame.db");
        }
    }
}
