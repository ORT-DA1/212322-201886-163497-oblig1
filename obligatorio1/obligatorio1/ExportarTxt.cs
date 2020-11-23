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

        // public override void Exportar(List<GastoComun> listaGastosComunes, String direccion)
        public override void Exportar(List<GastoComun> listaGastosComunes, Stream fileStream)
        {

            StreamWriter sw = new StreamWriter(fileStream);
            
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
            fileStream.Close();

            /*
             // funciona
             using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Sara Vila\Desktop\ReporteGastos.txt"))
            
            //using (System.IO.StreamWriter file = new System.IO.StreamWriter(direccion + "\\ReporteGastos.txt"))
            {
                foreach (GastoComun gasto in listaGastosComunes)
                {
                    
                    file.WriteLine(gasto.Fecha.ToString("dd/MM/yyyy"));
                    file.WriteLine(gasto.Descripcion);
                    file.WriteLine(gasto.Categoria);
                    file.WriteLine(gasto.Moneda);
                    file.WriteLine(gasto.Monto);
                    file.WriteLine("######");
                   
                }
            }*/




        }

    }
}
