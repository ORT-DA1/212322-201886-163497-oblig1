using System;

namespace Dominio
{
    public abstract class ExportarReporteGastoFabrica 
    {
        public ExportarReporteGastoFabrica()
        {

        }
        public static ExportarReporteGasto CrearExportacion(String tipo)
        {
            if (tipo == "txt")
            {
                return new ExportarTxt();
            }
            else if(tipo == "csv")
            {
                return new ExportarCsv();
            }
            else
            {
                return new ExportarXML();
            }
        }
    }
}
