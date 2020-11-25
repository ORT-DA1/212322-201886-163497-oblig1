using System;

namespace Dominio
{
    public class CategoriaMonto
    {
        public int Id { get; set; }
        public virtual Categoria Categoria { get; set; }
        
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