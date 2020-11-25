using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class ExportarUnTXTPrueba
    {
        private ExportarTxt exportarTxt;
        private Gasto unGastoComun;
        private Categoria categoria;
        private Moneda moneda;
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorReporteGastos adminReporteGastos;
        private IRepositorio miRepositorio;

        [TestInitialize]
        public void InitTests()
        {
            miRepositorio = new RepositorioMemoria();
            exportarTxt = new ExportarTxt();
            moneda = new Moneda { Simbolo = "UYU" };
            categoria = new Categoria() { Nombre = "Entretenimiento" };
            unGastoComun = new GastoComun() { Categoria = categoria, Moneda = moneda, Fecha = new DateTime(2020, 5, 1) };
            adminReporteGastos = new AdministradorReporteGastos(miRepositorio);
            adminGastosComunes = new AdministradorGastosComunes(miRepositorio);

        }
    /*    [TestMethod]
        public void ExportarTXTPrueba()
        {
            adminGastosComunes.AgregarGastoComun(unGastoComun);
            List<GastoComun> ListaLocal = new List<GastoComun>();
            ListaLocal.Add(unGastoComun);
            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream))

            {
                exportarTxt.Exportar(ListaLocal, stream);
                string actual = Encoding.UTF8.GetString(stream.ToArray());
                Assert.AreEqual("01/05/2020\nNo hay descripcion\nEntretenimiento\nUYU\n0\n####\n", actual);

            }
        }*/



    }

}
