using System.Collections.Generic;
using System.Linq;
using System;

namespace Dominio
{
    public class RepositorioMemoria : IRepositorio
    {
        private List<Categoria> ListaCategorias { get; }
        private List<GastoRecuerrente> ListaGastosRecurrentes { get; }
        private List<Presupuesto> ListaPresupuestos { get; }
        private List<GastoComun> ListaGastosComunes { get; }
       // private List<DateTime> ListaMesesDondeHayGastos { get; set; }
        //private List<DateTime> ListaMesesDondeHayPresupuestos { get; set; }
        private List<Moneda> ListaMonedas { get; set; }

        public RepositorioMemoria()
        {
            ListaCategorias = new List<Categoria>();
            ListaGastosRecurrentes = new List<GastoRecuerrente>();
            ListaGastosComunes = new List<GastoComun>();
            ListaPresupuestos = new List<Presupuesto>();
           // ListaMesesDondeHayGastos = new List<DateTime>();
           // ListaMesesDondeHayPresupuestos = new List<DateTime>();
            ListaMonedas = new List<Moneda>();


        }

         public void AgregarPalabrasEnRepo(Categoria categoria, PalabraClave unaPalabra){}

        public void EliminarPalabrasEnRepo(Categoria categoria, PalabraClave unaPalabra) {}

        public void AgregarCategoriaMonto(CategoriaMonto catMonto,Presupuesto presupuesto){}

        public List<PalabraClave> RetornarPalabrasClaveDeCategoriaDelRepo(Categoria unaCategoria)
        {
            return unaCategoria.PalabrasClave;
        }



        public void AgregarCategoria(Categoria unaCategoria)
        {
            this.ListaCategorias.Add(unaCategoria);
        }
        public List<Categoria> RetornarListaCategorias()
        {
            return this.ListaCategorias;
        }
        public bool EsVaciaListaCategorias()
        {
            return this.ListaCategorias.Count == 0;
        }
        public bool ExisteCategoria(Categoria unaCategoria)
        {
            return this.ListaCategorias.Contains(unaCategoria);
        }
        public void EliminarCategoria(Categoria unaCategoria)
        {
            this.ListaCategorias.Remove(unaCategoria);
        }



        public void AgregarGastoRecurrente(GastoRecuerrente unGastoRecurrente)
        {
            ListaGastosRecurrentes.Add(unGastoRecurrente);
        }
        public List<GastoRecuerrente> RetornarListaGastosRecurrentes()
        {
            return this.ListaGastosRecurrentes;
        }
        public bool EsVaciaListaGastosRecurrentes()
        {
            return this.ListaGastosRecurrentes.Count == 0;
        }
        public bool ExisteGastoRecurrente(GastoRecuerrente unGastoRecurrente)
        {
            return this.ListaGastosRecurrentes.Contains(unGastoRecurrente);
        }
        public void EliminarGastoRecuerrente(GastoRecuerrente unGastoRecurrente)
        {
            this.ListaGastosRecurrentes.Remove(unGastoRecurrente);
        }



        public void AgregarGastoComun(GastoComun unGastoComun)
        {
            ListaGastosComunes.Add(unGastoComun);
        }
        public List<GastoComun> RetornarListaGastosCoumnes()
        {
            return this.ListaGastosComunes;
        }
        public bool EsVaciaListaGastosComunes()
        {
            return this.ListaGastosComunes.Count == 0;
        }
        public bool ExisteGastoComun(GastoComun unGastoComun)
        {
            return this.ListaGastosComunes.Contains(unGastoComun);
        }
        public void EliminarGastoComun(GastoComun unGastoComun)
        {
            this.ListaGastosComunes.Remove(unGastoComun);
        }




        /*public List<DateTime> RetornarListaMesesDondeHayGasto()
        {
            return this.ListaMesesDondeHayGastos;
        }
        public void AgregarMesDondeHayGasto(DateTime unaFecha)
        {
            this.ListaMesesDondeHayGastos.Add(unaFecha);
        }
        public bool EsVaciaListaMesesDondeHayGastos()
        {
            return this.ListaMesesDondeHayGastos.Count == 0;
        }
        public bool ExisteMes(DateTime unaFecha)
        {
            return this.ListaMesesDondeHayGastos.Contains(unaFecha);
        }

        public int CantidadElementosEnListaMesesDondeHayGastos()
        {
            return this.ListaMesesDondeHayGastos.Count();
        }*/

        public void AgregarPresupuesto(Presupuesto unPresupuesto)
        {
            this.ListaPresupuestos.Add(unPresupuesto);
        }
        public List<Presupuesto> RetornarListaPresupuestos()
        {
            return this.ListaPresupuestos;
        }
   
        public bool ExisteUnPresupuesto(DateTime unaFecha)
        {
            foreach (Presupuesto presupuesto in this.ListaPresupuestos)
            {
                if (presupuesto.Fecha == unaFecha) return true;
            }
            return false;
        }

        public void AgregarMoneda(Moneda unaMoneda)
        {
            this.ListaMonedas.Add(unaMoneda);
        }

        public List<Moneda> RetornarListaMonedas()
        {
            return this.ListaMonedas;
        }

        public bool ExisteMoneda(Moneda unaMoneda)
        {
            return this.ListaMonedas.Contains(unaMoneda);
        }

       
    }
}