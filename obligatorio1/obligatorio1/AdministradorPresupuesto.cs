using Dominio;
using Excepciones;
using System;
using System.Collections.Generic;

namespace obligatorio1
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
        public AdministradorPresupuesto()
        {
            this.Repositorio = new Repositorio();
        }
        public List<Presupuesto> RetornarListaPresupuestos()
        {
            return Repositorio.RetornarListaPresupuestos();
        }

        public void AgregarPresupuesto(Presupuesto unPresupuesto)
        {
            Repositorio.AgregarPresupuesto(unPresupuesto);
        }

        public void ActualizarPresupuestosConNuevaCategoria(Categoria unaCategoria)
        {
            foreach(Presupuesto pres in Repositorio.RetornarListaPresupuestos())
            {
                pres.AgregarCategoriaMonto(unaCategoria, 0);
            }
        }

        public void ModificarMontoACategoria(Presupuesto unPresupuesto, Categoria unaCategoria, int unMonto)
        {
            unPresupuesto.ModificarMontoACategoria(unaCategoria, unMonto);
        }

        public Presupuesto RetornarPresupuestoSegunMes(String unMes, int unAnio)
        {
            foreach(Presupuesto p in this.RetornarListaPresupuestos())
            {
                if(p.Mes == unMes && p.Anio == unAnio)
                {
                    return p;
                }
            }
            throw new ExcepcionElementoNoExistente("No hay un presupuesto para el mes elegido");

        }


        /*
public bool EsVaciaListaPresupuestos()
{
   return Repositorio.EsVaciaListaPresupuestos();
}
*/
    }
}