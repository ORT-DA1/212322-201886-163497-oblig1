using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class GastoRecuerrente : Gasto
    {
        private int fecha;
        private int num1 = 1;
        private int num28 = 28;
        [Display(Name = "Fecha_GastoRecurrente")]
        public int Fecha
        {
            get { return fecha; }
            set
            {
                if (value < num1 || value > num28)
                {
                    throw new IndexOutOfRangeException("Ingrese un dia entre el 1-28");
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
        public GastoRecuerrente(int unMonto, string unaDescripcion, Categoria unaCategoria , int unaFecha ,Moneda unaMoneda) :base(unMonto, unaDescripcion, unaCategoria ,unaMoneda)
        {
            Fecha = unaFecha;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}",base.ToString(),this.Fecha);
        }

    }

}


        
