using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Dominio
{
    public class RepositorioBD : IRepositorio
    {
        private Persistencia contexto;
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

         public void AgregarPalabrasEnRepo(Categoria categoria, PalabraClave unaPalabra)
          {
              using (var contextoo = new Persistencia())
              {
                  Categoria cat = contextoo.Categorias.FirstOrDefault(x => x.Id == categoria.Id);
                  cat.PalabrasClave.Add(unaPalabra);
                  contextoo.SaveChanges();
              }

          }

        public void EliminarPalabrasEnRepo(Categoria categoria, PalabraClave unaPalabra)
        {
            using (var contextoo = new Persistencia())
            {
                Categoria cat = contextoo.Categorias.FirstOrDefault(x => x.Id == categoria.Id);
                cat.PalabrasClave.Remove(unaPalabra);
               
                PalabraClave palabra = contextoo.PalabraClaves.FirstOrDefault(x => x.Id == unaPalabra.Id);
                contextoo.PalabraClaves.Remove(palabra);
                contextoo.SaveChanges();
            }

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
            
            using (var contexto = new Persistencia())
            {
               return contexto.Categorias == null;
                
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

      

     
    }
}
