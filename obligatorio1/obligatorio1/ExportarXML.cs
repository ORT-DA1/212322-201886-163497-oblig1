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

        }
    }
}
