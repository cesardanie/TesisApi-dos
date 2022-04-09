using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis2.Models;

namespace Tesis2.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {



        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Creacionderegistros> Creacionderegistros { get; set; }
        public DbSet<CuaadroMaestro> CuaadroMaestros { get; set; }
       

    }
}
