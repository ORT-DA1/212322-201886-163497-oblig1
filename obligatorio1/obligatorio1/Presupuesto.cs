using System;

namespace Dominio
{
    public class Presupuesto
    {

        private int unAnio;
        public String mes { get; set; }
        public int monto { get; set; }


       
        public int Anio
        {

            get { return unAnio; }

            set
            {
                if (value < 2018 || value > 2030)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    unAnio = value;
                }

            }

        }
    }
}