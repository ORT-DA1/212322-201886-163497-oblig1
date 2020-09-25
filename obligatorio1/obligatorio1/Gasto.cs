using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio1
{
    public class Gasto
    {
        public int Monto { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public Categoria  Categoria { get; set; }

        public Gasto()
        {
            this.Monto = 0;
            this.Descripcion = "No hay descripcion";
            this.Fecha = "xx/xx/xxxx";
        }

        public bool ValidarDescripcion(string descripcion)
        {
            return true;
        }
    }
}
