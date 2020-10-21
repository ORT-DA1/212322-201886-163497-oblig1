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
            this.Fecha = new DateTime(2020, 5, 1, 8, 30, 52);
        }
        public GastoComun(int unMonto, string unaDescripcion, Categoria unaCategoria, DateTime fecha):base(unMonto, unaDescripcion, unaCategoria)
        {
            Fecha = fecha;
        }

        public override string ToString()
        {
            return String.Format("{0},{1}", base.ToString(),this.Fecha);
        }
    }
}