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
        public override void Exportar(List<GastoComun> listaGastosComunes)
        {
            //ver como hacerlo.
            //string[] lineas= { };
            using(StreamWriter outputFile = new StreamWriter("c:\\Users\\knowledgeattic\\Desktop\\ReporteGastos.txt"))
            {
                foreach(GastoComun gasto in listaGastosComunes)
                {
                    outputFile.WriteLine(gasto);
                }
            }

        }
  /*     public override void Exportar(List<GastoComun> listaGastosComunes) 
        {
            using(TextWriter tw = new StreamWriter(new FileStream(  .FileName, FileMode.Create), Encoding.UTF8))
            {
                foreach(GastoComun item in listaGastosComunes)
                {
                    await tw.WriteLineAsync(item.Fecha.Text + item.Categoria.Text);
                }
            }
        }*/
    }
}
