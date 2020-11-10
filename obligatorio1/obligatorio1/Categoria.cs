using System;
using System.Collections.Generic;
using Excepciones;
using obligatorio1;

namespace Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        public List<PalabraClave> PalabrasClave { get; }
        public List<string> PalabrasYaUsadas { get; }

        private String nombre;

        public String Nombre
        {

            get { return nombre; }

            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ExcepcionPalabraLarga("La palabra es demasiado corta o larga");
                }
                else
                {
                    nombre = value;
                }

            }

        }

        public Categoria()
        {
            this.PalabrasClave = new List<PalabraClave>();
            this.Nombre = "No hay nombre";
        }

        public void AgregarPalabraClave(PalabraClave palabra)
        {
            //string palabraMayuscula = PasarAMayuscula(palabra);
            if (PalabraClaveInvalida(palabra/*palabraMayuscula*/))
            {
                throw new InvalidOperationException("Palabra clave invalida");
            }
            this.PalabrasClave.Add(palabra/*palabraMayuscula*/);
        }

        private bool PalabraClaveInvalida(PalabraClave palabraMayuscula)
        {
            return CantPalabrasClave() == 10 || this.ExistePalabraClave(palabraMayuscula);
        }

        public bool EsVacia()
        {
            return this.PalabrasClave.Count == 0;
        }

        public void BorrarPalabraClave(PalabraClave palabra)
        {
            //string palabraMayuscula = palabra.ToUpper();
            this.PalabrasClave.Remove(palabra/*palabraMayuscula*/);
        }
        private int CantPalabrasClave()
        {
            return this.PalabrasClave.Count;
        }

        public bool ExistePalabraClave(PalabraClave unaPalabra)
        {
            string palabra = unaPalabra.ToString();
            return PalabrasClave.Contains(palabra /*unaPalabra*//*PasarAMayuscula(unaPalabra)*/);
        }

       /* private string PasarAMayuscula(string unaPalabra)
        {
            return unaPalabra.ToUpper();
        }*/
     

        public override bool Equals(Object obj)
        {
            Categoria catObj = obj as Categoria;
            if (catObj == null)
            {
                return false;
            }
            else
            {
                return Nombre.Equals(catObj.Nombre);
            }
        }

        public override string ToString()
        {
            return String.Format(this.Nombre);
        }

    }
}
