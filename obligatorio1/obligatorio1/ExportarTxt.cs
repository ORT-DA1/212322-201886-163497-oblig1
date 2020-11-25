using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ExportarTxt: ExportarReporteGasto
    {
        public ExportarTxt() { }

        public override void Exportar(List<GastoComun> listaGastosComunes, Stream unStream)
        {

            StreamWriter sw = new StreamWriter(unStream);
            foreach (GastoComun gasto in listaGastosComunes)
            {

                sw.WriteLine(gasto.Fecha.ToString("dd/MM/yyyy"));
                sw.WriteLine(gasto.Descripcion);
                sw.WriteLine(gasto.Categoria);
                sw.WriteLine(gasto.Moneda);
                sw.WriteLine(gasto.Monto);
                sw.WriteLine("####");

            }
            sw.Close();
            unStream.Close();

        }

    }
}
