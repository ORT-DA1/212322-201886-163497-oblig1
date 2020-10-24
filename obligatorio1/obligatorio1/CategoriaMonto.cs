using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
 *  
Si se agrega una categoría luego de haber creado el
presupuesto, el valor para la categoría nueva será inicialmente cero,
pudiendo el usuario cambiarlo después. Los montos por categoría son
números positivos positivos, con dos decimales
        }*/

namespace Dominio
{
    public class CategoriaMonto
    {

        public Categoria Categoria { get; set; }

        private float unMonto;
        public float Monto
        {

            get { return unMonto; }

            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    unMonto = value;
                }

            }

        }
        public CategoriaMonto()
        {
            this.Monto = 0;
        }


    }
}