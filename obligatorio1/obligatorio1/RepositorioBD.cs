using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Dominio
{
    public class RepositorioBD : IRepositorio
    {
        //private Persistencia contexto;
        public RepositorioBD()
        {
            // PRUEBA LEO
            
            /*using (Persistencia persistencia = new Persistencia())
             {
                 List<PalabraClave> palabras = new List<PalabraClave>()
                 { new PalabraClave() { Palabra = "uno" } };
                 Categoria categoria = new Categoria()
                 { Nombre = "CategoríaTest", PalabrasClave = palabras }; persistencia.Categorias.Add(categoria); persistencia.SaveChanges();
             }*/

            //
        }
      
        /* public void ActualizarPalabrasEnBDLEO(Categoria unaCategoria)
       {
           using (var contexto = new Persistencia())
           {
               foreach (PalabraClave palabra in unaCategoria.PalabrasClave)
               {
                   if (palabra.Id == 0)
                   {
                       contexto.PalabraClaves.Add(palabra);
                   }
                   else
                   {
                       contexto.PalabraClaves.Attach(palabra);

                   }
               }
               contexto.Categorias.Attach(unaCategoria);
               contexto.Entry(unaCategoria).State = System.Data.Entity.EntityState.Modified;
               contexto.SaveChanges();
           }

       }*/



        //CATEGORIA
        public void AgregarPalabrasEnRepo(Categoria categoria, PalabraClave unaPalabra)
         {
              using (var contexto = new Persistencia())
              {
                  Categoria cat = contexto.Categorias.FirstOrDefault(x => x.Id == categoria.Id);
                  cat.PalabrasClave.Add(unaPalabra);
                  contexto.SaveChanges();
              }

         }

        public void EliminarPalabrasEnRepo(Categoria categoria, PalabraClave unaPalabra)
        { 
            using (var contexto = new Persistencia())
            {
                Categoria cat = contexto.Categorias.FirstOrDefault(x => x.Id == categoria.Id);
                cat.PalabrasClave.Remove(unaPalabra);
                PalabraClave palabra = contexto.PalabraClaves.FirstOrDefault(x => x.Id == unaPalabra.Id);
                contexto.PalabraClaves.Remove(palabra);
                contexto.SaveChanges();
            }

        }
        public List<PalabraClave> RetornarPalabrasClaveDeCategoriaDelRepo(Categoria unaCategoria)
         {
            using (var contexto = new Persistencia())
            {
                Categoria cat = contexto.Categorias.Include("PalabrasClave").FirstOrDefault(x=> x.Id == unaCategoria.Id);
                return cat.PalabrasClave.ToList();
            }
        }

        public void AgregarCategoria(Categoria unaCategoria)
        {
            using (var contexto = new Persistencia())
            {
                contexto.Categorias.Add(unaCategoria);
                contexto.SaveChanges();
            }

        }
        //NO USAMOS ESTE METODO.
        public void EliminarCategoria(Categoria unaCategoria)
        {
            using (var contexto = new Persistencia())
            {
                Categoria cat = contexto.Categorias.FirstOrDefault(x => x.Id == unaCategoria.Id);
                contexto.Categorias.Remove(cat);
                contexto.SaveChanges();
            }
        }

        public List<Categoria> RetornarListaCategorias()
        {
            using (var contexto = new Persistencia())
            {
                return contexto.Categorias.Include("PalabrasClave").ToList();
            }
        }
        public bool ExisteCategoria(Categoria unaCategoria)
        {
            using (var contexto = new Persistencia())
            {
                if (contexto.Categorias.FirstOrDefault(x => x.Nombre == unaCategoria.Nombre) != null)
                {
                    return true;
                }
                return false;
            }
        }
        public bool EsVaciaListaCategorias()
        {

            using (var contexto = new Persistencia())
            {
                return contexto.Categorias == null;

            }
        }

       

        //PRESUPUESTO
        public void AgregarPresupuesto(Presupuesto unPresupuesto)
        {
             using (var contexto = new Persistencia())
             {
                contexto.Presupuesto.Add(unPresupuesto);
                contexto.SaveChanges();
             }

        }

        public void AgregarCategoriaMonto(CategoriaMonto categoriaMonto, Presupuesto presupuesto)
        {
            using (var contexto = new Persistencia())
            {
                Presupuesto pre = contexto.Presupuesto.Include("ListaCategoriaMonto.Categoria").FirstOrDefault(x => x.Id == presupuesto.Id);
                contexto.Entry(categoriaMonto.Categoria).State = EntityState.Unchanged;
                pre.ListaCategoriaMonto.Add(categoriaMonto);
                contexto.SaveChanges();
            }

        }

        public bool ExisteUnPresupuesto(DateTime unaFecha)
        {
            using (var contexto = new Persistencia())
            {
                if (contexto.Presupuesto.FirstOrDefault(x => x.Fecha == unaFecha) != null)
                {
                    return true;
                }
                return false;
            }
        }
        public List<Presupuesto> RetornarListaPresupuestos()
        {
             using (var contexto = new Persistencia())
             {
                 return contexto.Presupuesto.Include("ListaCategoriaMonto.Categoria").ToList();
             }
        }
        public void AgregarCategoriaMontoAPresupuestos(CategoriaMonto catMonto)
        {
            using (var contexto = new Persistencia()) /////////////////////////////// verificar que sea gasto recurrente //////////////////////////////////////////////
            {
                foreach (Presupuesto p in contexto.Presupuesto.ToList())
                {
                    // p.AgregarCategoriaMonto(unaCategoria, 0);
                    // CategoriaMonto catMonto = new CategoriaMonto() { Categoria = unaCategoria, Monto = 0 };
                    this.AgregarCategoriaMonto(catMonto, p);

                   // p.ListaCategoriaMonto.Add(categoriaMonto);
                }
                

            }
        }
        public void ModificarMontoACategoria(Presupuesto unPresupuesto, Categoria unaCategoria, double unMonto) 
        {
            using (var contexto = new Persistencia())
            {
                Presupuesto pre = contexto.Presupuesto.Include("ListaCategoriaMonto.Categoria").FirstOrDefault(x => x.Id == unPresupuesto.Id);
                CategoriaMonto categoriaMonto = pre.ListaCategoriaMonto.FirstOrDefault(x => x.Categoria.Id == unaCategoria.Id);
                //contexto.Entry(categoriaMonto.Categoria).State = EntityState.Unchanged;
                categoriaMonto.Monto = unMonto;
                //contexto.CategoriaMonto.Add(categoriaMonto);
                contexto.SaveChanges();
            }

        }

        public List<CategoriaMonto> RetornarCategoriaMontoDelRepo(Presupuesto unPresupuesto)
        {
            using (var contexto = new Persistencia())
            {

                Presupuesto pre = contexto.Presupuesto.Include("ListaCategoriaMonto.Categoria").FirstOrDefault(x => x.Id == unPresupuesto.Id);
                return pre.ListaCategoriaMonto.ToList();

            }
        }
        public void EliminarCategoriaMontoEnRepo(Presupuesto unPresupuesto, CategoriaMonto categoriaMonto)
        {
          /*  using (var contexto = new Persistencia())
            {
                Presupuesto pre = contexto.Presupuesto.FirstOrDefault(x => x.Id == unPresupuesto.Id);
                pre.ListaCategoriaMonto.Remove(categoriaMonto);

                CategoriaMonto unaCatMonto = contexto.CategoriaMonto.FirstOrDefault(x => x.Id == categoriaMonto.Id);
                contexto.CategoriaMonto.Remove(unaCatMonto);
                contexto.SaveChanges();

            }*/

        }


        //MONEDA
        public void AgregarMoneda(Moneda unaMoneda)
        {
            using (var contexto = new Persistencia())
            {
                contexto.Monedas.Add(unaMoneda);
                contexto.SaveChanges();

            }
        }
        public List<Moneda> RetornarListaMonedas()
        {
            using (var contexto = new Persistencia())
            {
                return contexto.Monedas.ToList();
            }
        }
        public bool ExisteMoneda(Moneda unaMoneda)
        {
            using (var contexto = new Persistencia())
            {
                if (contexto.Monedas.FirstOrDefault(x => x.Id == unaMoneda.Id) != null)
                {
                    return true;
                }
                return false;
            }
        }

        public void BorrarMoneda(Moneda unaMoneda)
        {
            using (var contexto = new Persistencia())
            {
                Moneda mon = contexto.Monedas.FirstOrDefault(x => x.Id == unaMoneda.Id);
                contexto.Monedas.Remove(mon);
                contexto.SaveChanges();
            }
        }

        public void ModificarNombreAMoneda(Moneda unaMoneda, string unNombre)
        {

            using (var contexto = new Persistencia())
            {
                Moneda mon = contexto.Monedas.FirstOrDefault(x => x.Id == unaMoneda.Id);

               
                mon.Nombre = unNombre;
              
                contexto.SaveChanges();
            }
        }

        public void ModificarSimboloAMoneda(Moneda unaMoneda, string unSimbolo)
        {
            using (var contexto = new Persistencia())
            {
                Moneda mon = contexto.Monedas.FirstOrDefault(x => x.Id == unaMoneda.Id);
                mon.Simbolo = unSimbolo;
                contexto.SaveChanges();
            }
        }

        public void ModificarCotizacionAMoneda(Moneda unaMoneda, double unaCotizacion)
        {
            using (var contexto = new Persistencia())
            {
                Moneda mon = contexto.Monedas.FirstOrDefault(x => x.Id == unaMoneda.Id);
                mon.Cotizacion = unaCotizacion;
                contexto.SaveChanges();
            }
        }





        //GASTO RECURRENTE
        public void AgregarGastoRecurrente(GastoRecuerrente unGastoRecurrente)
        {
            using (var contexto = new Persistencia())
            {

                contexto.Entry(unGastoRecurrente.Moneda).State = EntityState.Unchanged;
                contexto.Entry(unGastoRecurrente.Categoria).State = EntityState.Unchanged;
                contexto.Gastoes.Add(unGastoRecurrente);
                contexto.SaveChanges();

            }
        }
        public void EliminarGastoRecuerrente(GastoRecuerrente unGastoRecurrente)
        {
            using (var contexto = new Persistencia())
            {
                Gasto gasto = contexto.Gastoes.FirstOrDefault(x => x.Id == unGastoRecurrente.Id);
                contexto.Gastoes.Remove(gasto);
                contexto.SaveChanges();
            }
        }
        public bool EsVaciaListaGastosRecurrentes()
        {
            using (var contexto = new Persistencia()) /////////////////////////////// verificar que sea gasto recurrente //////////////////////////////////////////////
            {
                foreach (Gasto g in contexto.Gastoes.ToList())
                {
                    if (g.GetType().ToString() == "Recurrente")
                    {
                        return false;
                    }
                }
                return true;

            }
        }
        public bool ExisteGastoRecurrente(GastoRecuerrente unGastoRecurrente)
        {
            using (var contexto = new Persistencia())
            {
                if (contexto.Gastoes.FirstOrDefault(x => x.Id == unGastoRecurrente.Id) != null)
                {
                    return true;
                }
                return false;
            }
        }
        public List<GastoRecuerrente> RetornarListaGastosRecurrentes()
        {
            using (var contexto = new Persistencia())
            {
                return contexto.Gastoes.Include("Categoria").Include("Moneda").OfType<GastoRecuerrente>().ToList(); //retorna una lista de gastos y no de gastos comunes
            }
        }

        public void ModificarDescripcionAGastoRecurrente(GastoRecuerrente unGastoRecuerrente, string unaDescripcion)
        {
            using (var contexto = new Persistencia())
            {
                Gasto gas = contexto.Gastoes.FirstOrDefault(x => x.Id == unGastoRecuerrente.Id);
                gas.Descripcion = unaDescripcion;
                contexto.SaveChanges();
            }
        }

        public void ModificarCategoriaAGastoRecurrente(GastoRecuerrente unGastoRecuerrente, Categoria otraCategoria)
        {//buscar esa categoria y asignarla
            using (var contexto = new Persistencia())
            {
                Gasto gas = contexto.Gastoes.FirstOrDefault(x => x.Id == unGastoRecuerrente.Id);
                Categoria cat = contexto.Categorias.FirstOrDefault(x => x.Id == otraCategoria.Id);
                gas.Categoria = cat;
                contexto.SaveChanges();
            }
        }
        
        public void ModificarDiaDelMesAGastoRecurrente(GastoRecuerrente unGastoRecuerrente, int dia)
        {
            throw new NotImplementedException();
            /*
            using (var contexto = new Persistencia())
            {
                Gasto gas = contexto.Gastoes.FirstOrDefault(x => x.Id == unGastoRecuerrente.Id);
                gas. = dia;
                contexto.SaveChanges();
            }*/
        }

        public void ModificarMontoAGastoRecurrente(GastoRecuerrente unGastoRecuerrente, int monto)
        {
            using (var contexto = new Persistencia())
            {
                Gasto gas = contexto.Gastoes.FirstOrDefault(x => x.Id == unGastoRecuerrente.Id);
                gas.Monto = monto;
                contexto.SaveChanges();
            }
        }

        public void ModificarMonedaAGastoRecurrente(GastoRecuerrente unGastoRecuerrente, Moneda otraMoneda)
        {
            using (var contexto = new Persistencia())
            {
                Gasto gas = contexto.Gastoes.FirstOrDefault(x => x.Id == unGastoRecuerrente.Id);
                Moneda mon = contexto.Monedas.FirstOrDefault(x => x.Id == unGastoRecuerrente.Id);
                gas.Moneda = mon;
                contexto.SaveChanges();
            }
        }
            //GASTO COMUN
        public void AgregarGastoComun(GastoComun unGastoComun)
        {
            using (var contexto = new Persistencia())
            {
                contexto.Entry(unGastoComun.Moneda).State = EntityState.Unchanged;
                contexto.Entry(unGastoComun.Categoria).State = EntityState.Unchanged;
                contexto.Gastoes.Add(unGastoComun);
                
                contexto.SaveChanges();

            }
        }
        public void EliminarGastoComun(GastoComun unGastoComun)
        {
            using (var contexto = new Persistencia())
            {
                Gasto gasto = contexto.Gastoes.FirstOrDefault(x => x.Id == unGastoComun.Id);
                contexto.Entry(unGastoComun.Categoria).State = EntityState.Unchanged;
                contexto.Entry(unGastoComun.Moneda).State = EntityState.Unchanged;
                contexto.Gastoes.Remove(gasto);
                contexto.SaveChanges();
            }
        }
        public bool EsVaciaListaGastosComunes()
        {
            using (var contexto = new Persistencia())
            {
                foreach (Gasto g in contexto.Gastoes.ToList())
                {
                    if (g.GetType().ToString() == "Comun")
                    {
                        return false;
                    }
                }
                return true;

            }
        }

        //METODO NO IMPLEMENTADO---------------------------
        public bool EsVaciaListaMesesDondeHayGastos()
        {
            throw new NotImplementedException();

        }
        //--------------------------------------------------
        public bool ExisteGastoComun(GastoComun unGastoComun)
        {
            using (var contexto = new Persistencia())
            {
                if (contexto.Gastoes.FirstOrDefault(x => x.Id == unGastoComun.Id) != null)
                {
                    return true;
                }
                return false;
            }
        }
        public List<GastoComun> RetornarListaGastosCoumnes()
        {
            using (var contexto = new Persistencia())
            {
                return contexto.Gastoes.Include("Categoria").Include("Moneda").OfType<GastoComun>().ToList(); //retorna una lista de gastos y no de gastos comunes
            }
        }
        public void ModificarGasto(GastoComun unGasto)
        {
            using (var contexto = new Persistencia())
            {
                Gasto gasto = contexto.Gastoes.FirstOrDefault(x => x.Id == unGasto.Id);

                contexto.Monedas.Attach(unGasto.Moneda);
                contexto.Categorias.Attach(unGasto.Categoria);
                contexto.Entry(gasto).CurrentValues.SetValues(unGasto);
                gasto.Categoria= unGasto.Categoria;
                gasto.Moneda= unGasto.Moneda;

                contexto.SaveChanges();
            }






}




/*
  public List<DateTime> RetornarListaMesesDondeHayGasto()
  {
      throw new NotImplementedException();
  }
  public void AgregarMesDondeHayGasto(DateTime unaFecha)
  {
      throw new NotImplementedException();
  }
  public int CantidadElementosEnListaMesesDondeHayGastos()
  {
      throw new NotImplementedException();
  }
  public bool ExisteMes(DateTime unaFecha)
  {
      throw new NotImplementedException();
  }*/




     }
}
