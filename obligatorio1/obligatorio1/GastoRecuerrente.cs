using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class GastoRecuerrente : Gasto
    {
        //public int Id { get; set; }
        private int fecha;
        [Display(Name = "Fecha_GastoRecurrente")]
        public int Fecha
        {
            get { return fecha; }
            set
            {
                if (value < 1 || value > 28)
                {
                    throw new IndexOutOfRangeException("Ingrese un dia entre el 1-28");
                }
                else
                {
                    fecha = value;
                }

            }

        }
        public double CotizacionOriginalDeMoneda { get; set; }
        
        public GastoRecuerrente()
        {
            this.Fecha = 1;
            this.CotizacionOriginalDeMoneda = 0;
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


        
