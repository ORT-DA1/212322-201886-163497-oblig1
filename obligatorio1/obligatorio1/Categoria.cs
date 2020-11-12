using System;
using System.Collections.Generic;
using Excepciones;

namespace Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        public List<PalabraClave> PalabrasClave { get; set; }

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

            if (PalabraClaveInvalida(palabra))
            {

                throw new InvalidOperationException("Palabra clave invalida");
            }
            this.PalabrasClave.Add(palabra);
        }

        private bool PalabraClaveInvalida(PalabraClave palabra)
        {
            return CantPalabrasClave() == 10 || this.ExistePalabraClave(palabra);
        }

        public bool EsVacia()
        {
            return this.PalabrasClave.Count == 0;
        }

        public void BorrarPalabraClave(PalabraClave palabra)
        {
            this.PalabrasClave.Remove(palabra);
        }
        private int CantPalabrasClave()
        {
            return this.PalabrasClave.Count;
        }

        public bool ExistePalabraClave(PalabraClave unaPalabra)
        {
            return PalabrasClave.Contains((unaPalabra));
        }

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
