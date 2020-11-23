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
             sw.WriteLine(string.Format("{0},{1},{2},{3},{4}",
                 gasto.Fecha.ToString("dd/MM/yyyy"), "'"+gasto.Descripcion+"'"," "+gasto.Categoria,
                 " " + gasto.Moneda," "+gasto.Monto));

         }

            sw.Close();
        }
        
     


        /*    //const string csvFilename = String(fileStream);
            const string csvFilename = "ReporteGastos.csv";
             var csvFile = new List<string>();
             foreach (GastoComun gasto in listaGastosComunes)
             {
                 csvFile.Add(string.Format("{0},{1},{2},{3},{4}",
                     gasto.Fecha.ToString("dd/MM/yyyy"), gasto.Descripcion, gasto.Categoria,
                     gasto.Moneda, gasto.Monto));


             }
          
            File.WriteAllLines(csvFilename, csvFile);*/


            /*  using (StreamWriter swOutputFile = new StreamWriter(new FileStream("C:\\Dev\\AppendedJobData.csv", FileMode.Create, FileAccess.Write, FileShare.Read)))
              {
                  //Get nodes from returned XML ticket
                  XmlNodeList xmlJobs = xdResults.SelectNodes("/Updates/Jobs/Job");
                  //Pull out data from XML attributes
                  foreach (XmlElement xeJobUpdate in xmlJobs)
                  {
                      List<String> lineItems = new List<String>();
                      lineItems.add(xeJobUpdate.GetAttribute("SharpOwlProjectID"));
                      //add all the other items

                      swOutputFile.WriteLine(String.Join(',', myLine.ToArray()));



                  }
                  //after the loop you close the writer
              }*/



            /*    StreamWriter sw = new StreamWriter(fileStream);

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
                fileStream.Close();*/

        




        

    }
}
