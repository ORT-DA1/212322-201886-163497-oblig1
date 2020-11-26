using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PalabraClave
    {
        public int Id { get; set; }

        private String palabra;
        public String Palabra
        {
            get { return palabra; }

            set
            {
                palabra = value.ToUpper();
            }
        }
        public PalabraClave()
        {
            
        }
        public override bool Equals(Object obj)
        {
            PalabraClave catObj = obj as PalabraClave;
            if (catObj == null)
            {
                return false;
            }
            else
            {
                return Palabra.Equals(catObj.Palabra);
            }
        }
        public override string ToString()
        {
            return String.Format("{0}",this.Palabra);
        }
    }
}
