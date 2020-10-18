using System;

namespace Dominio
{
    public class GastoComun : Gasto
    {

        private DateTime fechaMin;

   

        public DateTime Fecha
        {
            get { return fechaMin; }


            set
            {
                DateTime fechaAntigua = new DateTime(2018, 1, 1, 0, 0, 0);

                DateTime fechaFuturo = new DateTime(2030, 12, 31, 0, 0, 0);

                int resultado = DateTime.Compare(value, fechaAntigua);
                int resultado2 = DateTime.Compare(value, fechaFuturo);

                if (resultado < 0 || resultado2 > 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    fechaMin = value;
                }
            }


        }
        public GastoComun()
        {
        }
        public GastoComun(int unMonto, string unaDescripcion, Categoria unaCategoria, DateTime fecha):base(unMonto, unaDescripcion, unaCategoria)
        {
            Fecha = fecha;
        }

        
    }
}