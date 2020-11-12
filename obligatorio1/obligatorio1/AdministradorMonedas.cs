using Dominio;
using System;

namespace obligatorio1
{
    public class AdministradorMonedas
    {
        private Repositorio Repositorio { get; }
        public AdministradorMonedas(Repositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;
        }

        public static void AgregarMoneda(Moneda unaMoneda)
        {
            if (this.Repositorio.ExisteMoneda(unaMoneda))
            {
                throw new ExcepcionElementoRepetido("Moneda ya existente");
            }
            else
            {
                Repositorio.AgregarMoneda(unaMoneda);
            }
        }
    }
}