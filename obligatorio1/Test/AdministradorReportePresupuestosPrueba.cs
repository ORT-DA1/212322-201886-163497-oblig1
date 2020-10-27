using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]

    public class AdministradorReportePresupuestosPrueba
    {

        private AdministradorGastosRecurrentes adminGastosRecurrentes;
        private GastoRecuerrente unGastoRecuerrente;
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorReporteGastos adminReporteGastos;
        private Categoria unaCategoria;
        private Repositorio miRepositorio;
        private GastoComun unGastoComun;

        [TestInitialize]
        public void InitTest()
        {
            miRepositorio = new Repositorio();
            adminGastosRecurrentes = new AdministradorGastosRecurrentes(miRepositorio);
            adminGastosComunes = new AdministradorGastosComunes(miRepositorio);
            unaCategoria = new Categoria() { Nombre = "Entretenimiento" };
            unGastoRecuerrente = new GastoRecuerrente() { Categoria = unaCategoria };
            unGastoComun = new GastoComun() { Categoria = unaCategoria };
            adminReporteGastos = new AdministradorReporteGastos(miRepositorio);

        }

        [TestMethod]
        public void voidcalcularDiferenciaDeMontoRealYPlanificadoPrueba()
        {

        }
    }
}
