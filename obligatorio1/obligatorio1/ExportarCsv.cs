using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ExportarCsv : ExportarReporteGasto
    {
        public override void Exportar(List<GastoComun> listaGastosComunes, Stream fileStream)
        {
            StreamWriter sw = new StreamWriter(fileStream);
            foreach (GastoComun gasto in listaGastosComunes)
            {
                AplicarFormatoAlGasto(gasto);
                sw.WriteLine(string.Format("{0},{1},{2},{3},{4}",
                gasto.Fecha.ToString("dd/MM/yyyy"), gasto.Descripcion, " " + gasto.Categoria, " " + gasto.Moneda, " " + gasto.Monto));

            }
            sw.Close();
        }
        private static void AplicarFormatoAlGasto(GastoComun gasto)
        {
            if (gasto.Descripcion.Contains("\"") || gasto.Descripcion.Contains(","))
            {
                gasto.Descripcion = "'" + gasto.Descripcion + "'";
            }
        }
    }
}
