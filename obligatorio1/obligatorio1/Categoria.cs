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
       

        private List<String> palabrasClave;

        private String nombre;

        public String Nombre
        {

            get { return nombre; }

            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    nombre = value;
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
            
            String palabraMayuscula = palabra.ToUpper();
            if (this.palabrasClave.Count == 10)
            {
                throw new IndexOutOfRangeException();

            }

            this.palabrasClave.Add(palabraMayuscula);
        }
        
        public bool EsVacia()
        {
           return this.palabrasClave.Count == 0;
          
        }

        public List<string> GetListaPClave()
        {
            return this.palabrasClave;
        }


        public void BorrarPalabraClave(string palabra)
        {
            String palabraMayuscula = palabra.ToUpper();
            this.GetListaPClave().Remove(palabraMayuscula);
          
        }
        public int CantPalabraClave()
        {
            return this.GetListaPClave().Count;

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

        // SAQUE DE ACA LA INFO
        // https://docs.microsoft.com/en-us/dotnet/api/system.object.equals?view=netcore-3.1

        public override bool Equals(Object obj)
        {
            Categoria catObj = obj as Categoria;
            if (catObj == null)
                return false;
            else
                return Nombre.Equals(catObj.Nombre);
        }


    }
}
