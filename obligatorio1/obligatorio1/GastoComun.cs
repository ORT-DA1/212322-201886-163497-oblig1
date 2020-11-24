using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class GastoComun : Gasto
    {
        private DateTime unaFecha;
        public DateTime Fecha
        {
            get { return unaFecha; }

            set
            {
                DateTime fechaAntigua = new DateTime(2018, 1, 1);

                DateTime fechaFuturo = new DateTime(2030, 12, 31);

                int resultado = DateTime.Compare(value, fechaAntigua);
                int resultado2 = DateTime.Compare(value, fechaFuturo);

                if (resultado < 0 || resultado2 > 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    unaFecha = value;
                }
            }
        }
        public GastoComun()
        {
            this.Fecha = new DateTime(2020, 5, 1);
        }
        public GastoComun(int unMonto, string unaDescripcion, Categoria unaCategoria, DateTime fecha , Moneda unaMoneda):base(unMonto, unaDescripcion, unaCategoria , unaMoneda)
        {
            Fecha = fecha;
        }
        public override string ToString()
        {
            return String.Format("{0}, Fecha: {1}", base.ToString(),this.Fecha.ToShortDateString());
        }
    }
}