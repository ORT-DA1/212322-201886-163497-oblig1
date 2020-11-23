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

            public string Root = "";
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
            }



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
