using System;

namespace Dominio
{
    public  class Gasto
    {
        private string desc;
        private double monto;
        public int Id { get; set; }

        public double Monto
        {
            get { return monto; }
            set
            {
                monto = Math.Round(value, 2);
                if (monto < 0.00)
                {
                    throw new IndexOutOfRangeException("Monto debe ser positivo.");
                }
            }
        }
        public string Descripcion
        {
            get { return desc; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new IndexOutOfRangeException("Descripción demasiado corta o larga");
                }
                else
                {
                    desc = value;
                }
            }

        }
        public Categoria Categoria { get; set; }
        public Moneda Moneda { get; set; }
        public double MontoEnPesos { get; set; }
        

        public Gasto()
        {
            this.Monto = 0.00;
            this.Descripcion = "No hay descripcion";
            this.MontoEnPesos = 0.00;
        }
        public Gasto(double unMonto, string unaDescripcion, Categoria unaCategoria, Moneda moneda)
        {
            Monto = unMonto;
            Descripcion = unaDescripcion;
            Categoria = unaCategoria;
            Moneda = moneda;
        }
        
        public override string ToString()
        {

            return String.Format("Monto: {0}, Descripcion: {1}, Categoria: {2}, Moneda: {3}", this.Monto, this.Descripcion, this.Categoria, this.Moneda.Simbolo);

        }
    }

}
