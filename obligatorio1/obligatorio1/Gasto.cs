using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio1
{
    public class Gasto
    {

        private string desc;
        public int Monto { get; set; }
        public string Descripcion
        {

            get { return desc; }

            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    desc = value;
                }
               
            }

        }

        public string Fecha { get; set; }
        public Categoria  Categoria { get; set; }

        public Gasto()
        {
            this.Monto = 0;
            this.Descripcion = "No hay descripcion";
            this.Fecha = "xx/xx/xxxx";
            this.Categoria = new Categoria();
        }



    }
}
