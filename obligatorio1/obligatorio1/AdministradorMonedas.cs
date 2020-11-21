using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{

    public class AdministradorMonedas
    {
        private IRepositorio Repositorio { get;  }
        public AdministradorMonedas(IRepositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;
        }

        
          public void AgregarMoneda(Moneda unaMoneda)
          {
               if (Repositorio.ExisteMoneda(unaMoneda))
              {
                  throw new ExcepcionElementoRepetido("Moneda ya existente");
              }
              else
              { 
                    
                  Repositorio.AgregarMoneda(unaMoneda);
              }
          }

        public List<Moneda> RetornarListaMonedas()
        {
            return Repositorio.RetornarListaMonedas();
        }

        public void BorrarMoneda(Moneda unaMoneda)
        {
            Repositorio.BorrarMoneda(unaMoneda);
        }
        public void ModificarNombreAMoneda(Moneda unaMoneda, string unNombre)
        {
            Repositorio.ModificarNombreAMoneda(unaMoneda, unNombre);
        }
    }
}
