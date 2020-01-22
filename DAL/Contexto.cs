using GenerosBlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerosBlazorApp.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Genero> Genero { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server = (local); Database = Tarea2Generos; Trusted_Connection = True;");
        }
    }
}
