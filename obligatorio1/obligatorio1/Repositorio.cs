
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace Dominio

{
    public class Repositorio
    {

        private List<Categoria> ListaCategorias { get; }
        private List<GastoRecuerrente> ListaGastosRecurrentes { get; }

        public Repositorio()
        {
            ListaCategorias = new List<Categoria>();
            ListaGastosRecurrentes = new List<GastoRecuerrente>();

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

        // NUEVO

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





    }
}