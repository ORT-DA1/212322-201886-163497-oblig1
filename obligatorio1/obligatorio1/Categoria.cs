using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio1
{
    public class Categoria
    {
        private List<String> palabrasClave;
        public string Nombre { get; set; }

        public void AgregarPalabraClave(string palabra, List<string> palabrasClave)
        {
            this.palabrasClave.Add(palabra);
        }

        public bool esVacia()
        {
           return this.palabrasClave.Count == 0;
          
        }
    }
}
