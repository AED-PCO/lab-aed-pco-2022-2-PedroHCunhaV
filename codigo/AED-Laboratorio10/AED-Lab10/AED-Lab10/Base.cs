using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamicaATV
{
    class InformaçõesBase
    {
        public int elemento;
        public InformaçõesBase marcado;

        public InformaçõesBase() { }
        public InformaçõesBase(int elemento)
        {
            this.elemento = elemento;
            this.marcado = null;
        }
    }
}
