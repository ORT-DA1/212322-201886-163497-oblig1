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

                Categoria cat = contexto.Categorias.FirstOrDefault(x=> x.Id == unaCategoria.Id);
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
                 contexto.Presupuestos.Add(unPresupuesto);
                 contexto.SaveChanges();
             }

        }
        public bool ExisteUnPresupuesto(DateTime unaFecha)
        {
             using (var contexto = new Persistencia())
            {
                if (contexto.Presupuestos.FirstOrDefault(x => x.Fecha == unaFecha) != null)
                {
                    return true;
                }
                return false;
            }
            
        }
        public List<Presupuesto> RetornarListaPresupuestos()
        {
            /*using (var contexto = new Persistencia())
             {
                 return contexto.Presupuestos.ToList();
             }*/
            List<Presupuesto> fake = new List<Presupuesto>();
            return fake;
        }
        public void AgregarCategoriaMonto(CategoriaMonto categoriaMonto, Presupuesto presupuesto)
        {
           /* using (var contexto = new Persistencia())
            {
                Presupuesto pre = contexto.Presupuestos.FirstOrDefault(x => x.Id == presupuesto.Id);
                pre.ListaCategoriaMonto.Add(categoriaMonto);
                contexto.SaveChanges();
            }*/

        }
        public List<CategoriaMonto> RetornarCategoriaMontoDelRepo(CategoriaMonto unaCategoriaMonto)
        {
            /*  using (var contexto = new Persistencia())
              {

                  Presupuesto pre = contexto.Presupuestos.FirstOrDefault(x => x.Id == unaCategoriaMonto.Id);
                  return pre.ListaCategoriaMonto.ToList();

              }*/
            List<CategoriaMonto> fake = new List<CategoriaMonto>();
            return fake;
        }
        public void EliminarCategoriaMontoEnRepo(Presupuesto unPresupuesto, CategoriaMonto categoriaMonto)
        {
          /*  using (var contexto = new Persistencia())
            {
                Presupuesto pre = contexto.Presupuestos.FirstOrDefault(x => x.Id == unPresupuesto.Id);
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


       


        //GASTO RECURRENTE
        public void AgregarGastoRecurrente(GastoRecuerrente unGastoRecurrente)
        {
           
        }
        public void EliminarGastoRecuerrente(GastoRecuerrente unGastoRecurrente)
        {
            
        }
        public bool EsVaciaListaGastosRecurrentes()
        {
            return true;

        }
        public bool ExisteGastoRecurrente(GastoRecuerrente unGastoRecurrente)
        {
            return true;
        }
        public List<GastoRecuerrente> RetornarListaGastosRecurrentes()
        {
            List<GastoRecuerrente> fake = new List<GastoRecuerrente>();
            return fake;
        }




        //GASTO COMUN
        public void AgregarGastoComun(GastoComun unGastoComun)
        {
            
        }
        public void EliminarGastoComun(GastoComun unGastoComun)
        {
            
        }
        public bool EsVaciaListaGastosComunes()
        {
            return true;
        }
        public bool EsVaciaListaMesesDondeHayGastos()
        {
            return true;
        }
        public bool ExisteGastoComun(GastoComun unGastoComun)
        {
            return true;
        }
        public List<GastoComun> RetornarListaGastosCoumnes()
        {
            List<GastoComun> fake = new List<GastoComun>();
            return fake;
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
