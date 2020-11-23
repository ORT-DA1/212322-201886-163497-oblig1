using System;
using System.Collections.Generic;

namespace Dominio
{
    public interface IRepositorio
    {
        void AgregarCategoria(Categoria unaCategoria);
        List<Categoria> RetornarListaCategorias();
        bool EsVaciaListaCategorias();
        bool ExisteCategoria(Categoria unaCategoria);
        void EliminarCategoria(Categoria unaCategoria);
        void AgregarGastoRecurrente(GastoRecuerrente unGastoRecurrente);
        List<GastoRecuerrente> RetornarListaGastosRecurrentes();
        bool ExisteMoneda(Moneda unaMoneda);
        void BorrarMoneda(Moneda unaMoneda);
        bool EsVaciaListaGastosRecurrentes();
        bool ExisteGastoRecurrente(GastoRecuerrente unGastoRecurrente);
        void EliminarGastoRecuerrente(GastoRecuerrente unGastoRecurrente);
        void AgregarMoneda(Moneda unaMoneda);
        void AgregarGastoComun(GastoComun unGastoComun);
        List<GastoComun> RetornarListaGastosCoumnes();
        List<Moneda> RetornarListaMonedas();
        bool EsVaciaListaGastosComunes();
        bool ExisteGastoComun(GastoComun unGastoComun);
        void EliminarGastoComun(GastoComun unGastoComun);
        void ModificarNombreAMoneda(Moneda unaMoneda, string unNombre);
        void AgregarPresupuesto(Presupuesto unPresupuesto);
        void ModificarSimboloAMoneda(Moneda unaMoneda, string unSimbolo);
        void ModificarCotizacionAMoneda(Moneda unaMoneda, double unaCotizacion);

        /*List<DateTime> RetornarListaMesesDondeHayGasto();
void AgregarMesDondeHayGasto(DateTime unaFecha);
bool EsVaciaListaMesesDondeHayGastos();
bool ExisteMes(DateTime unaFecha);
int CantidadElementosEnListaMesesDondeHayGastos();*/
        List<Presupuesto> RetornarListaPresupuestos();
       // List<DateTime> RetornarListaMesesDondeHayPresupuesto();
        //void AgregarMesDondeHayPresupuesto(DateTime unaFecha);
        bool ExisteUnPresupuesto(DateTime unaFecha);
        void ModificarDescripcionAGastoRecurrente(GastoRecuerrente unGastoRecuerrente, string unaDescripcion);
        void AgregarPalabrasEnRepo(Categoria categoria, PalabraClave unaPalabra);

        List<PalabraClave> RetornarPalabrasClaveDeCategoriaDelRepo(Categoria unaCategoria);
        void ModificarCategoriaAGastoRecurrente(GastoRecuerrente unGastoRecuerrente, Categoria otraCategoria);
        void EliminarPalabrasEnRepo(Categoria categoria, PalabraClave unaPalabra);
        void ModificarDiaDelMesAGastoRecurrente(GastoRecuerrente unGastoRecuerrente, int dia);
        void AgregarCategoriaMonto(CategoriaMonto catMonto, Presupuesto presupuesto);
        void ModificarMontoAGastoRecurrente(GastoRecuerrente unGastoRecuerrente, int monto);
        List<CategoriaMonto> RetornarCategoriaMontoDelRepo(Presupuesto unPresupuesto);
        void ModificarMonedaAGastoRecurrente(GastoRecuerrente unGastoRecuerrente, Moneda otraMoneda);
        void ModificarMontoACategoria(Presupuesto unPresupuesto, Categoria unaCategoria, double unMonto);
        void ModificarGasto(GastoComun unGasto);
    }
}
