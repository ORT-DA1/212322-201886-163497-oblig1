using System;

namespace obligatorio1
{
    public class Presupuesto
    {
        public String mes { get; set; }
        public int monto { get; set; }
        
        public int Año
        {

            get { return Año; }

            set
            {
                if (value < 2018 || value > 2030)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    Año = value;
                }

            }

        }
    }
}