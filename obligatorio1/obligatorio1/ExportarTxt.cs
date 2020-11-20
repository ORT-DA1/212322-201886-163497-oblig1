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
           /* using(TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
            {
                foreach(GastoComun item in listaGastosComunes)
                {
                    await tw.WriteLineAsync(item.Fecha.Text + item.Categoria.Text);
                }
            }*/
        }
    }
}
