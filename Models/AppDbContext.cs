using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteModalMVC.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<OrcamentoDespesa> OrcamentoDespesa { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
