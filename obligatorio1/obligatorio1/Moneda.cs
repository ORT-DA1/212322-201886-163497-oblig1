using Excepciones;
using System;

namespace Dominio
{
    public class Moneda
    {
        public int Id { get; set; }

        private String nombre;
        public String Nombre
        {

            get { return nombre; }

            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ExcepcionPalabraLarga("La palabra es demasiado corta o larga");
                }
                else
                {
                    nombre = value;
                }

            }

        }
        public String simbolo;
        public String Simbolo
        {

            get { return simbolo; }

            set
            {
                if (value.Length < 1 || value.Length > 3)
                {
                    throw new ExcepcionPalabraLarga("El simbolo es demasiado corto o largo");
                }
                else
                {
                    simbolo = value;
                }

            }

        }
        private double cotizacion;
        public double Cotizacion
        {
            get { return cotizacion; }
            set
            {
                cotizacion = Math.Round(value, 2);
                if (cotizacion < 0.00)
                {
                    throw new IndexOutOfRangeException("La cotizacion debe ser positivo.");
                }
            }
        }

        public Moneda()
        {
            this.Nombre = "Peso Uruguayo";
            this.Simbolo = "UYU";
        }
        public override bool Equals(Object obj)
        {
            Moneda monedaObj = obj as Moneda;
            if (monedaObj == null)
            {
                return false;
            }
            else
            {
                return Simbolo.Equals(monedaObj.Simbolo);
            }
        }
        public override string ToString()
        {
            return String.Format(this.Simbolo);
        }
    }
}
