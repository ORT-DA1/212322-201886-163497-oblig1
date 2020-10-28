using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dominio
{
    public class CategoriaMonto
    {

        public Categoria Categoria { get; set; }

        private double unMonto;
        public double Monto
        {
            get { return unMonto; }
            set
            {
                unMonto = Math.Round(value, 2);
                if (unMonto < 0.00)
                {
                    throw new IndexOutOfRangeException("Monto debe ser positivo.");
                }
                
            }
        }
        public CategoriaMonto()
        {
            this.unMonto = 0;
        }


    }
}