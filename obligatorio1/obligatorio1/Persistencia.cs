using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Persistencia : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet <PalabraClave> PalabraClaves { get; set; }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Presupuesto> Presupuesto { get; set; }
        public DbSet<CategoriaMonto> CategoriaMonto { get; set; }
        public DbSet<Gasto> Gastoes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gasto>()
                        .Map<GastoComun>(m => m.Requires("TipoGasto").HasValue("Comun"))
                        .Map<GastoRecuerrente>(m => m.Requires("TipoGasto").HasValue("Recurrente"));
        }
    }
}
