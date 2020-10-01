using System;
using System.Collections.Generic;
using System.Linq;
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

        //public DateTime Fecha { get; set; }

        private DateTime fechaMin;

        public DateTime Fecha
        {
            get { return fechaMin; }


            set
            {
                DateTime d1 = new DateTime(2018, 1, 1, 0, 0, 0);
                //DateTime d2 = value;
            
               int resultado = DateTime.Compare(value, d1);

                if (resultado<0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    fechaMin = value;
                }
            }
        }

    public Categoria  Categoria { get; set; }

        public Gasto()
        {
            this.Monto = 0;
            this.Descripcion = "No hay descripcion";
            this.Fecha = new DateTime(2020, 5, 1, 8, 30, 52);
            this.Categoria = new Categoria();
        }

    }




}
