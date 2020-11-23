using System;
using System.Collections.Generic;


namespace Dominio

{
    public class AdministradorReporteGastos
    {
        private IRepositorio Repositorio { get; }
        public AdministradorReporteGastos(IRepositorio unRepositorio)
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
                Monto = gastoRecurrente.MontoEnPesos,
                Descripcion = gastoRecurrente.Descripcion,
                Categoria = gastoRecurrente.Categoria,
                Fecha = new DateTime(anio, mes, dia)
            };
            return gasto;

        }


        public List<DateTime> CrearYRetornalListaDeMesesDondeHayGastoOrdenada()
        {
            List<DateTime> ListaMesesDondeHayGasto = new List<DateTime>();

            foreach (GastoComun gasto in Repositorio.RetornarListaGastosCoumnes())
            {
                DateTime fecha = ConvertirFechaDejarSoloAnioMes(gasto);

                if (!ListaMesesDondeHayGasto.Contains(fecha))
                {
                    ListaMesesDondeHayGasto.Add(fecha);
                }
            }
            ListaMesesDondeHayGasto.Sort();
            return ListaMesesDondeHayGasto;
        }

        public DateTime ConvertirFechaDejarSoloAnioMes(GastoComun gasto)
        {
            return new DateTime(gasto.Fecha.Year, gasto.Fecha.Month, 1);

        }

        public double CalcularMontoDeReporte(List<GastoComun> ListaDeGastosReporte)
        {
            double total = 0;
            foreach (GastoComun gasto in ListaDeGastosReporte)
            {
                total += gasto.MontoEnPesos;
            }
            return total;
        }

        public double CalcularGastoTotalDeCategoriaEnMes(int anio, int mes, Categoria unaCategoria)
        {
            List<GastoComun> listaGastosDelMes = this.UnirListaGastosDelMes(anio, mes);

            return SumaGastoTotal(unaCategoria, listaGastosDelMes);
        }

        private static double SumaGastoTotal(Categoria unaCategoria, List<GastoComun> listaGastosDelMes)
        {
            double gastoTotalDeCategoriaEnMes = 0;
            foreach (Gasto gasto in listaGastosDelMes)
            {
                if (GastoIgualACategoria(unaCategoria, gasto))
                {
                    gastoTotalDeCategoriaEnMes += gasto.Monto;
                }
            }
            return gastoTotalDeCategoriaEnMes;
        }

        private static bool GastoIgualACategoria(Categoria unaCategoria, Gasto gasto)
        {
            return gasto.Categoria == unaCategoria;
        }




    }
}