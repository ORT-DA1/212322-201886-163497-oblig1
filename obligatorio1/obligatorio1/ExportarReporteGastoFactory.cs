namespace Dominio
{
    public abstract class ExportarReporteGastoFactory 
    {
        public static ExportarReporteGasto CrearExportacion(string tipo)
        {
            if (tipo == "TXT")
            {
                return new ExportarTxt();
            }
            else if(tipo == "CSV")
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
