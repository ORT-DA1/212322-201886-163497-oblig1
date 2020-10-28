using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Excepciones;


namespace Dominio
{
    public class AdministradorCategorias
    {
        private const char SEPARADOR = ' ';

        private Repositorio Repositorio { get; }
        private AdministradorPresupuesto AdminPresupuesto { get; }

        public AdministradorCategorias(Repositorio unRepositorio)
        {

            this.Repositorio = unRepositorio;
            this.AdminPresupuesto = new AdministradorPresupuesto(unRepositorio);

        }

        public List<Categoria> RetornarListaCategorias()
        {
            return Repositorio.RetornarListaCategorias();
        }

        public void AgregarCategoria(Categoria unaCategoria)
        {

            if (this.Repositorio.ExisteCategoria(unaCategoria))
            {
                throw new ExcepcionElementoRepetido("Categoria ya existente");

            }
            else
            {
                Repositorio.AgregarCategoria(unaCategoria);

                foreach (Presupuesto pres in Repositorio.RetornarListaPresupuestos())
                {
                    pres.AgregarCategoriaMonto(unaCategoria, 0);
                }
            }

        }


        public bool EsVaciaListaCategorias()
        {
            return Repositorio.EsVaciaListaCategorias();
        }

        public Categoria CategoriaDePalabraClave(String palabraClave)
        {

            foreach (Categoria unaCategoria in Repositorio.RetornarListaCategorias())
            {

                if (unaCategoria.ExistePalabraClave(palabraClave))
                {
                    return unaCategoria;
                }

            }

            throw new ExcepcionElementoNoExistente("No esta la palabra clave");

        }

        public bool PalabraClaveYaIngresadaEnAlgunaLista(string palabreClave)
        {
            foreach (Categoria unaCategoria in Repositorio.RetornarListaCategorias())
            {
                if (unaCategoria.ExistePalabraClave(palabreClave))
                {
                    return true;
                }
            }
            return false;
        }


        public Categoria RetornarCategoriaDeDescripcion(string descripcion)
        {
            if (CantDeCategoriasDistintasDondeApareceLaDescripcion(descripcion) > 1)
            {
                throw new InvalidOperationException("No se ha encontrado una categoria para sugerirle, seleccione una.");
            }
            else
            {
                string[] palabras = SepararPalabras(descripcion);
                return this.BuscarCategoriaPorPalabras(palabras);

            }

        }

        private string[] SepararPalabras(string descripcion)
        {
            return descripcion.Split(SEPARADOR);
        }

        private Categoria BuscarCategoriaPorPalabras(string[] algunasPalabras)
        {
            foreach (string unaPalabra in algunasPalabras)
            {
                foreach (Categoria unaCategoria in Repositorio.RetornarListaCategorias())
                {
                    if (unaCategoria.ExistePalabraClave(unaPalabra))
                    {
                        return unaCategoria;
                    }

                }
            }
            throw new ExcepcionElementoNoExistente("No se ha encontrado una categoria para sugerirle, seleccione una.");
        }


        public int CantDeCategoriasDistintasDondeApareceLaDescripcion(string descripcion)
        {
            int cantDeCategoriasDistintas = 0;
            string[] palabras = SepararPalabras(descripcion);
            Categoria categoriaYaContada = new Categoria();

            foreach (String palabra in palabras)
            {
                foreach (Categoria unaCategoria in Repositorio.RetornarListaCategorias())
                {
                    if (unaCategoria.ExistePalabraClave(palabra))
                    {
                       
                        if (LaCategoriaEsDistinta(unaCategoria, categoriaYaContada))
                        {
                            cantDeCategoriasDistintas++;
                            categoriaYaContada = unaCategoria;

                        }

                    }
                }
            }

            return cantDeCategoriasDistintas;

        }


        private bool LaCategoriaEsDistinta(Categoria unaCategoria, Categoria otraCategoria)
        {
            return !unaCategoria.Equals(otraCategoria);

        }

        public void AgregarPalabraClaveACategoria(Categoria categoria, string unaPalabra)
        {
            categoria.AgregarPalabraClave(unaPalabra);

        }

        public void BorrarPalabraClaveACategoria(Categoria categoria, String palabra)
        {
            categoria.BorrarPalabraClave(palabra);

        }

       
        public List<String> RetornarPalabrasClaveDeCategoria(Categoria unaCategoria)
        {
            return unaCategoria.PalabrasClave;
        }

      
        public Categoria RetornarCategoriaSegunString(string unNombre)
        {

            foreach (Categoria categoria in Repositorio.RetornarListaCategorias())
            {
                if (categoria.Nombre == unNombre) return categoria;
            }

            throw new ExcepcionElementoNoExistente("Categoria no existente");

        }

        public void EliminarCategoria(Categoria unaCategoria)
        {
            Repositorio.EliminarCategoria(unaCategoria);
        }


    }
}