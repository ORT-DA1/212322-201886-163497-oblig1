using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dominio
{
    public class ExportarXML : ExportarReporteGasto
    {
        public override void Exportar(List<GastoComun> listaGastosComunes, Stream fileStream)
        {

            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<GastoComun>));

            var file = new StreamWriter(fileStream);
            writer.Serialize(file, listaGastosComunes);
            file.Close();


            /*     FileInfo file = new FileInfo(fileStream);

                 //StreamWriter sw = new StreamWriter(fileStream);
                 StreamWriter sw = file.AppendText();
                 System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Gasto));
                 foreach (Gasto e in listaGastosComunes)
                 {
                     writer.Serialize(sw, e as Gasto);
                 }
                 sw.Close();*/


            /*       System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Gasto));
                   var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
                   //var path = Environment.GetFolderPath("C:\Users\Sara Vila\Desktop\SerializationOverview.xml");

                   foreach (GastoComun gasto in listaGastosComunes)
                   {
                       writer.Serialize(file, gasto);
                   }

                   System.IO.FileStream file = System.IO.File.Create(path);

                   file.Close();*/


            /*
             * GUARDA UN XML
             * Gasto overview = new Gasto() { Descripcion = "SoySara" };
            overview.Descripcion = "Serialization Overview";
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Gasto));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            //var path = Environment.GetFolderPath("C:\Users\Sara Vila\Desktop\SerializationOverview.xml");


            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, overview);
            file.Close();*/



            /*  public string Root = "";
              public string Filename = string.Empty;

              XmlTextWriter xml = new XmlTextWriter(fileStream, Encoding.UTF8);
              var cml = xmlTextWriter;
              {
                  xml.WriteStartDocument(true);
                  xml.WriteStartElement(Root);
                  xml.WriteEndElement();
                  xml.WriteEndDocument();
                  xml.Flush();
                  xml.Close();
              }*/



            /* XmlWriterSettings settings = new XmlWriterSettings();
             settings.Async = true;*/


            /*        async Task TestWriter(Stream stream)
                    {
                        XmlWriterSettings settings = new XmlWriterSettings();
                        settings.Async = true;

                        using (XmlWriter writer = XmlWriter.Create(fileStream, settings))
                        {
                            await writer.WriteStartElementAsync("pf", "root", "http://ns");
                            await writer.WriteStartElementAsync(null, "sub", null);
                            await writer.WriteAttributeStringAsync(null, "att", null, "val");
                            await writer.WriteStringAsync("text");
                            await writer.WriteEndElementAsync();
                            await writer.WriteProcessingInstructionAsync("pName", "pValue");
                            await writer.WriteCommentAsync("cValue");
                            await writer.WriteCDataAsync("cdata value");
                            await writer.WriteEndElementAsync();
                            await writer.FlushAsync();
                        }
                    }*/

        }
    }
}
