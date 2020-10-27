using Excepciones;
using System;
using System.Collections.Generic;


namespace Dominio
{
    public class AdministradorReporteGastos
    {
        private Repositorio Repositorio { get; }
        public AdministradorReporteGastos(Repositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;
           
        }

        public List<GastoComun> UnirListaGastosDelMes(int anio, int mes)
        {
            List<GastoComun> listaTotal = new List<GastoComun>();
            foreach (GastoComun gasto in DevolverListaDeGastosComunesSegunFecha(anio, mes))
            {
                listaTotal.Add(gasto);
            }

            foreach (GastoComun gasto in RetornarListaGastosRecurrentesConFechaAdecuada(anio, mes))
            {
                listaTotal.Add(gasto);
            }

            return listaTotal;

        }

        public List<GastoComun> DevolverListaDeGastosComunesSegunFecha(int anio, int mes)
        {
            List<GastoComun> listaDeGastosDelMes = new List<GastoComun>();
            foreach (GastoComun unGasto in Repositorio.RetornarListaGastosCoumnes())
            {
                if (CoincideMesAnioDeFechaRecibidaConGasto(anio, mes, unGasto))
                {
                    listaDeGastosDelMes.Add(unGasto);
                }
            }

            return listaDeGastosDelMes;

        }

        private bool CoincideMesAnioDeFechaRecibidaConGasto(int anio, int mes, GastoComun unGasto)
        {
            return unGasto.Fecha.Month == mes && unGasto.Fecha.Year == anio;
        }


        public List<GastoComun> RetornarListaGastosRecurrentesConFechaAdecuada(int anio, int mes)
        {
            List<GastoComun> listaGastosRecurrentesConFechaAdecuada = new List<GastoComun>();
            foreach (GastoRecuerrente unGasto in Repositorio.RetornarListaGastosRecurrentes())
            {
                listaGastosRecurrentesConFechaAdecuada.Add(ConvertirGastoRecurrente(unGasto, anio, mes));
            }

            return listaGastosRecurrentesConFechaAdecuada;
        }


        public GastoComun ConvertirGastoRecurrente(GastoRecuerrente gastoRecurrente, int anio, int mes)
        {
            int dia = gastoRecurrente.Fecha;
            GastoComun gasto = new GastoComun()
            {
                Monto = gastoRecurrente.Monto,
                Descripcion = gastoRecurrente.Descripcion,
                Categoria = gastoRecurrente.Categoria,
                Fecha = new DateTime(anio, mes, dia)
            };
            return gasto;

        }

        public List<DateTime> AgregarYRetornalListaDeMesesDondeHayGastoOrdenada()
        {
            this.AgregarMesesAnioDondeHayGasto();
            Repositorio.RetornarListaMesesDondeHayGasto().Sort();
            return Repositorio.RetornarListaMesesDondeHayGasto();
        }

        public double CalcularMontoDeReporte(List<GastoComun> ListaDeGastosReporte)
        {
            double total = 0;
            foreach (GastoComun gasto in ListaDeGastosReporte)
            {
                total += gasto.Monto;
            }
            return total;
        }

        public void AgregarMesesAnioDondeHayGasto()
        {
            foreach (GastoComun gasto in Repositorio.RetornarListaGastosCoumnes())
            {
                DateTime fecha = ConvertirFechaDejarSoloAnioMes(gasto);
                if (!Repositorio.RetornarListaMesesDondeHayGasto().Contains(fecha))
                {
                  Repositorio.AgregarMesDondeHayGasto(fecha);
                }
            }

        }

        public DateTime ConvertirFechaDejarSoloAnioMes(GastoComun gasto)
        {
           return new DateTime(gasto.Fecha.Year, gasto.Fecha.Month, 1);
          
        }

      



    }
}