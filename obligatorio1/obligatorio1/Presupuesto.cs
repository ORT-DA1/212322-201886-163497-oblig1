using System;
using System.Collections.Generic;


namespace Dominio
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public virtual List <CategoriaMonto> ListaCategoriaMonto { get; }
        
        private DateTime unaFecha;
        public DateTime Fecha
        {
            get { return unaFecha; }
            set
            {
                DateTime fechaAntigua = new DateTime(2018, 1, 1);
                DateTime fechaFuturo = new DateTime(2030, 12, 31);
                int resultado = DateTime.Compare(value, fechaAntigua);
                int resultado2 = DateTime.Compare(value, fechaFuturo);

                if (resultado < 0 || resultado2 > 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    unaFecha = value;
                }
            }
        }

        public Presupuesto()
        {
            this.ListaCategoriaMonto = new List<CategoriaMonto>();
            this.Fecha = new DateTime(2020, 5, 1);
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
        public override string ToString()
        {
            return String.Format("{0},{1}", this.Fecha.Year, this.Fecha.Month);
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