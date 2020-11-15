using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Dominio
{
    public class RepositorioBD : IRepositorio
    {
        private Persistencia context;
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



        /*  public void ActualizarPalabrasEnBD(Categoria categoria, PalabraClave unaPalabra)
          {
              using (var context = new Persistencia())
              {
                  Categoria cat = context.Categorias.FirstOrDefault(x => x.Id == categoria.Id);
                  cat.PalabrasClave.Add(unaPalabra);
                  context.SaveChanges();
              }

          }*/

        // prueba 
        public void ActualizarPalabrasEnBD(Categoria unaCategoria)
        {
            using (var context = new Persistencia())
            {
                foreach (PalabraClave palabra in unaCategoria.PalabrasClave)
                {
                    if (palabra.Id == 0)
                    {
                        context.PalabraClaves.Add(palabra);
                    }
                    else
                    {
                        context.PalabraClaves.Attach(palabra);
                       
                    }
                }
                context.Categorias.Attach(unaCategoria);
                context.Entry(unaCategoria).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }

        }
        public List<PalabraClave> RetornarPalabrasClaveDeCategoriaDelRepo(Categoria unaCategoria)
         {
            using (var context = new Persistencia())
            {

                Categoria cat = context.Categorias.FirstOrDefault(x=> x.Id == unaCategoria.Id);
                return cat.PalabrasClave.ToList();

            }
        }

        public void AgregarCategoria(Categoria unaCategoria)
        {
            using (var context = new Persistencia())
            {
                context.Categorias.Add(unaCategoria);
                context.SaveChanges();

            }

        }
        public bool ExisteCategoria(Categoria unaCategoria)
        {

            using (var context = new Persistencia())
            {
                if (context.Categorias.FirstOrDefault(x => x.Nombre == unaCategoria.Nombre) != null)
                {
                    return true;
                }
                return false;
            }


        }

        public void EliminarCategoria(Categoria unaCategoria)
        {
            using (var context = new Persistencia())
            {
                context.Categorias.Remove(unaCategoria);
                context.SaveChanges();
            }

        }

        public List<Categoria> RetornarListaCategorias()
        {
            using (var context = new Persistencia())
            {
                return context.Categorias.Include("PalabrasClave").ToList();
            }

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
            
            using (var context = new Persistencia())
            {
               return context.Categorias == null;
                
            }
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

        public void AgregarMoneda(Moneda unaMoneda)
        {
            //throw new NotImplementedException();
        }
        public List<Moneda> RetornarListaMonedas()
        {
            throw new NotImplementedException();
        }
        public bool ExisteMoneda(Moneda unaMoneda)
        {
            throw new NotImplementedException();
        }


    }
}
