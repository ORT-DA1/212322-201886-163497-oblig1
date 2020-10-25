using Dominio;
using Excepciones;
using System;
using System.Collections.Generic;

namespace Dominio
{
    // UN PRESUPUESTO PLANIFICADO PARA CADA MES.
    /* UN MONTO PARA CADA CATEGORIA.
     * 
     * . se crea: se le asignan todas las categorias que existen en CategoriaMonto
 *  si se crea una categoria, se le agrega a la lista de CategoriasMonto con Monto 0.
     * 
    */

    public class AdministradorPresupuesto
    {
        private Repositorio Repositorio { get; }
        public AdministradorPresupuesto(Repositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;
        }
        public List<Presupuesto> RetornarListaPresupuestos()
        {
            return Repositorio.RetornarListaPresupuestos();
        }

        public void AgregarPresupuesto(Presupuesto unPresupuesto)
        {
            
            foreach (Categoria cat in Repositorio.RetornarListaCategorias())
            {
                unPresupuesto.AgregarCategoriaMonto(cat, 0);
            }
            Repositorio.AgregarPresupuesto(unPresupuesto);
        }

        public void ModificarMontoACategoria(Presupuesto unPresupuesto, Categoria unaCategoria, int unMonto)
        {
            unPresupuesto.ModificarMontoACategoria(unaCategoria, unMonto);
        } //HACER PRUEBA!!!!!!!!!!!!

        public Presupuesto RetornarPresupuestoSegunMes(String unMes, int unAnio)
        {
            foreach (Presupuesto p in this.RetornarListaPresupuestos())
            {
                if (p.Mes == unMes && p.Anio == unAnio)
                {
                    return p;
                }
            }
            throw new ExcepcionElementoNoExistente("No hay un presupuesto para el mes elegido");

        } //HACER PRUEBA!!!


        /* public void ActualizarPresupuestosConNuevaCategoria(Categoria unaCategoria)
         {
             foreach(Presupuesto pres in Repositorio.RetornarListaPresupuestos())
             {
                 pres.AgregarCategoriaMonto(unaCategoria, 0);
             }
         }

        

         


         
 public bool EsVaciaListaPresupuestos()
 {
    return Repositorio.EsVaciaListaPresupuestos();
 }*/

    }
}