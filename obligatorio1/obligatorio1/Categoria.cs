using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        // PREGUNTAR SI ES PUBLIC O PRIVATE Y COMO HACER EL GET
        private List<String> palabrasClave;


        private String nomb;

        public String Nombre
        {

            get { return nomb; }

            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    nomb = value;
                }

            }

        }



        public Categoria()
        {
            this.palabrasClave = new List<string>();
            this.Nombre = "No hay nombre";
        }
        
     
        
        public void AgregarPalabraClave(string palabra)
        {
            if (this.palabrasClave.Count == 10)
            {
                throw new IndexOutOfRangeException();

            }

            this.palabrasClave.Add(palabra);
        }
        
        public bool EsVacia()
        {
           return this.palabrasClave.Count == 0;
          
        }

        public List<string> GetListaPC()
        {
            return this.palabrasClave;
        }


        public void BorrarPalabraClave(string palabra)
        {
            this.GetListaPC().Remove(palabra);
          
        }
        public int CantPalabraClave()
        {
            return this.GetListaPC().Count;

        }


        public String BuscarPClave(String unaPalabra)
        {
            foreach (String Palabra in this.palabrasClave)
            {
                if (Palabra == unaPalabra)
                {
                    return unaPalabra;
                }
                
            }
            throw new InvalidOperationException();
        }
    }
}
