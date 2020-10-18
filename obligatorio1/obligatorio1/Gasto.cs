using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
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



        public Categoria Categoria { get; set; }


        public Gasto()
        {
            this.Monto = 0;
            this.Descripcion = "No hay descripcion";
            //this.Fecha = new DateTime(2020, 5, 1, 8, 30, 52);
            this.Categoria = new Categoria();

        }

        public Gasto(int unMonto, string unaDescripcion, Categoria unaCategoria)
        {
            Monto = unMonto;
            Descripcion = unaDescripcion;
            Categoria = unaCategoria;
        }
    }

    public override string ToString()
    {

    }


}
