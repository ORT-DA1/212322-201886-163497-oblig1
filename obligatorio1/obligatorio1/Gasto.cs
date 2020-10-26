using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Gasto
    {
       

        private string desc;
        private double monto;
        public double Monto 
        {
            get {return monto; }
            set

            {
                 monto = Math.Round(value,2);
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
                    throw new IndexOutOfRangeException("Descripcion invalida");
                }
                else
                {
                    desc = value;
                }

            }

        }



        public Categoria Categoria { get; set; }


        public Gasto()
        {
            this.Monto = 0.00;
            this.Descripcion = "No hay descripcion";
            this.Categoria = new Categoria();

        }
        public Gasto(double unMonto, string unaDescripcion, Categoria unaCategoria)
        {
            Monto = unMonto;
            Descripcion = unaDescripcion;
            Categoria = unaCategoria;
        }
        public override string ToString()
        {
            return String.Format("{0},{1},{2}",this.Monto, this.Descripcion ,this.Categoria);
        }
    }

}
