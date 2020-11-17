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
        void AgregarPresupuesto(Presupuesto unPresupuesto);
        List<DateTime> RetornarListaMesesDondeHayGasto();
        void AgregarMesDondeHayGasto(DateTime unaFecha);
        bool EsVaciaListaMesesDondeHayGastos();
        bool ExisteMes(DateTime unaFecha);
        int CantidadElementosEnListaMesesDondeHayGastos();
        List<Presupuesto> RetornarListaPresupuestos();
        List<DateTime> RetornarListaMesesDondeHayPresupuesto();
        void AgregarMesDondeHayPresupuesto(DateTime unaFecha);
        bool ExisteUnPresupuesto(DateTime unaFecha);
        
        void AgregarPalabrasEnRepo(Categoria categoria, PalabraClave unaPalabra);

        List<PalabraClave> RetornarPalabrasClaveDeCategoriaDelRepo(Categoria unaCategoria);

        void EliminarPalabrasEnRepo(Categoria categoria, PalabraClave unaPalabra);
    }
}
