using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio
{
    public class RepositorioBD : IRepositorio
    {
        private Persistencia context;
        public RepositorioBD()
        {

            context = new Persistencia();
        }

        public void AgregarCategoria(Categoria unaCategoria)
        {
            context.Categorias.Add(unaCategoria);
            context.SaveChanges();
        }

        public void AgregarGastoComun(GastoComun unGastoComun)
        {
            throw new NotImplementedException();
        }

        public void AgregarGastoRecurrente(GastoRecuerrente unGastoRecurrente)
        {
            throw new NotImplementedException();
        }

        public void AgregarMesDondeHayGasto(DateTime unaFecha)
        {
            throw new NotImplementedException();
        }

        public void AgregarMesDondeHayPresupuesto(DateTime unaFecha)
        {
            throw new NotImplementedException();
        }

        public void AgregarPresupuesto(Presupuesto unPresupuesto)
        {
            throw new NotImplementedException();
        }



        public int CantidadElementosEnListaMesesDondeHayGastos()
        {
            throw new NotImplementedException();
        }



        public void EliminarCategoria(Categoria unaCategoria)
        {

            context.Categorias.Remove(unaCategoria);
            context.SaveChanges();
        }

        public void EliminarGastoComun(GastoComun unGastoComun)
        {
            throw new NotImplementedException();
        }

        public void EliminarGastoRecuerrente(GastoRecuerrente unGastoRecurrente)
        {
            throw new NotImplementedException();
        }

        public bool EsVaciaListaCategorias()
        {
            //return context.Categorias.Any();
            //return context.PalabraClave.HasRows();
            return false;
        }

        public bool EsVaciaListaGastosComunes()
        {
            throw new NotImplementedException();
        }

        public bool EsVaciaListaGastosRecurrentes()
        {
            throw new NotImplementedException();
        }

        public bool EsVaciaListaMesesDondeHayGastos()
        {
            throw new NotImplementedException();
        }



        public bool ExisteCategoria(Categoria unaCategoria)
        {
            /* if (context.Categorias.FirstOrDefault(x => x.Equals(unaCategoria)) != null)
             {
                 return true;
             }
             else return false;*/
            return false;
        }

        public bool ExisteGastoComun(GastoComun unGastoComun)
        {
            throw new NotImplementedException();
        }

        public bool ExisteGastoRecurrente(GastoRecuerrente unGastoRecurrente)
        {
            throw new NotImplementedException();
        }

        public bool ExisteMes(DateTime unaFecha)
        {
            throw new NotImplementedException();
        }

        public bool ExisteUnPresupuesto(DateTime unaFecha)
        {
            throw new NotImplementedException();
        }



        public List<Categoria> RetornarListaCategorias()
        {
            return context.Categorias.ToList();
        }

        public List<GastoComun> RetornarListaGastosCoumnes()
        {
            throw new NotImplementedException();
        }

        public List<GastoRecuerrente> RetornarListaGastosRecurrentes()
        {
            throw new NotImplementedException();
        }

        public List<DateTime> RetornarListaMesesDondeHayGasto()
        {
            throw new NotImplementedException();
        }

        public List<DateTime> RetornarListaMesesDondeHayPresupuesto()
        {
            throw new NotImplementedException();
        }

        public List<Presupuesto> RetornarListaPresupuestos()
        {
            List<Presupuesto> fake = new List<Presupuesto>();
             return fake;
        }


    }
}
