using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {


        public List<String> PalabrasClave { get; }

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
            this.PalabrasClave = new List<string>();
            this.Nombre = "No hay nombre";
        }
        
     
        //hacer refactor para que este metodo haga solo una cosa.
        public void AgregarPalabraClave(string palabra)
        {
            
            String palabraMayuscula = PasarAMayuscula(palabra);
            if (CantPalabrasClave() == 10 || this.ExistePalabraClave(palabraMayuscula) )           
            {

                throw new InvalidOperationException();
            }

            this.PalabrasClave.Add(palabraMayuscula);
        }
        
        public bool EsVacia()
        {
           return this.PalabrasClave.Count == 0;
          
        }

     


        public void BorrarPalabraClave(string palabra)
        {
            String palabraMayuscula = palabra.ToUpper();
            this.PalabrasClave.Remove(palabraMayuscula);
          
        }
        private int CantPalabrasClave()
        {
            return this.PalabrasClave.Count;

        }

        public bool ExistePalabraClave(string unaPalabra)
        {
            
            return PalabrasClave.Contains(PasarAMayuscula(unaPalabra));
        }


        private string PasarAMayuscula(string unaPalabra)
        {
            return unaPalabra.ToUpper();
        }

        // este metodo es al pedo que hace?
        /*  public String BuscarPClave(String unaPalabra)
          {
              foreach (String Palabra in this.palabrasClave)
              {
                  if (Palabra == unaPalabra)
                  {
                      return unaPalabra;
                  }

              }
              throw new InvalidOperationException();
          }*/

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
