using System;
using System.Collections.Generic;
using Excepciones;

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
                    throw new ExcepcionFueraDeFecha();
                }
                else
                {
                    unAnio = value;
                }

            }

        }

        public Presupuesto()
        {
            this.Anio = 2019;
            this.Mes = "Setiembre";
            this.ListaCategoriaMonto = new List<CategoriaMonto>();
        }

        public bool EsVaciaListaCategoriaMonto()
        {
            return this.ListaCategoriaMonto.Count == 0;
        }

        public void AgregarCategoriaMonto(Categoria categoria, int monto)
        {
            CategoriaMonto catMonto = new CategoriaMonto { Categoria = categoria, Monto = monto };
            this.ListaCategoriaMonto.Add(catMonto);
        }

        //CONSTRUCTOR CON PARAMETROS QUE NO LE PASO LA LISTA DE CATEGORIA MONTO PORQ NO SE COMO HACERLO.
       /* public Presupuesto(int unAnio, String unMes)
        {
            Anio = unAnio;
            Mes = unMes;
            this.ListaCategoriaMonto = new List<CategoriaMonto>();
        }*/

        public override string ToString()
        {
            return String.Format("{0},{1}", this.Anio,this.Mes);
        }

        public void ModificarMontoACategoria(Categoria unaCategoria, int unMonto)
        {
            foreach(CategoriaMonto catMonto in this.ListaCategoriaMonto)
            {
                if(catMonto.Categoria == unaCategoria)
                {
                    catMonto.Monto = unMonto;
                }
            }
        }
    }
}