using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Presupuesto
    {

        private int unAnio;
        public String Mes { get; set; }
        public List <CategoriaMonto> ListaCategoriaMonto { get; }



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

        public Presupuesto()
        {
            this.ListaCategoriaMonto = new List<CategoriaMonto>();
        }

        public bool EsVaciaListaCategoriaMonto()
        {
            return this.ListaCategoriaMonto.Count == 0;
        }

        public void AgregarCategoriaMonto(CategoriaMonto categoriaMonto)
        {
            this.ListaCategoriaMonto.Add(categoriaMonto);
        }
    }
}