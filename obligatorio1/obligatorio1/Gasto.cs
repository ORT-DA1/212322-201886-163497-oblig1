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

        /*private DateTime fecha;

        public DateTime Fecha
        {
            get { return fechaMin; }


            set
            {
                DateTime fechaAntigua = new DateTime(2018, 1, 1, 0, 0, 0);
                
                DateTime fechaFuturo = new DateTime(2030, 12, 31, 0, 0, 0);

               int resultado = DateTime.Compare(value, fechaAntigua);
               int resultado2 = DateTime.Compare(value, fechaFuturo);

                if (resultado<0 || resultado2 >0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    fechaMin = value;
                }
            }
        }*/

    public Categoria  Categoria { get; set; }
        

        public Gasto()
        {
            this.Monto = 0;
            this.Descripcion = "No hay descripcion";
            //this.Fecha = new DateTime(2020, 5, 1, 8, 30, 52);
            this.Categoria = new Categoria();
            
        }


        public void AsignarCategoriaSegunDescripcion(Repositorio listaABuscar, string descripcion)
        {

            //PREGUNTAR QUE PASA SI NO TE DEVUELVE NADA, PORQUE HAY UNA EXCEPCION
            //si hay una palabra clave que esta en dos lugares, es decir hay dos categorias, por lo tanto queda vacia.

            Categoria catrgoria = listaABuscar.RetornarCategoriaDeDescripcion(descripcion);
            this.Categoria = catrgoria;


        }




    }




}
