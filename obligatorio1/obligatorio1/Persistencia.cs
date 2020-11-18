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

    }
}
