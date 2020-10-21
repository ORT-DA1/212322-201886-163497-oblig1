using System;
using System.Runtime.InteropServices;

namespace Dominio
{
    public class GastoRecuerrente : Gasto
    {
        private int fecha;

        public int Fecha
        {
            get { return fecha; }

            set
            {
                if (value < 1 || value > 28)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    fecha = value;
                }


            }

        }

        public GastoRecuerrente()
        {
            this.Fecha = 1;
        }
        public GastoRecuerrente(int unMonto, string unaDescripcion, Categoria unaCategoria , int unaFecha):base(unMonto, unaDescripcion, unaCategoria)
        {
            Fecha = unaFecha;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}",base.ToString(),this.Fecha);
        }

    }

}


        
