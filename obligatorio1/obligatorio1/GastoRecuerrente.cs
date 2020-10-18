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

            this.Monto = 0;
            this.Descripcion = "No hay descripcion";
            this.Fecha = 1;

        }
        public GastoRecuerrente(int unMonto, string unaDescripcion, Categoria unaCategoria , int unaFecha):base(unMonto, unaDescripcion, unaCategoria)
        {

            Fecha = unaFecha;
        }

    }

}


        
