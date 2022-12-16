using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamicaATV
{
    internal class PilhaDinamica
    {
        public int elemento;
        public PilhaDinamica prox;
        public PilhaDinamica() { }
        public PilhaDinamica(int elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
    }

    internal class RealizaPilha
    {
        public PilhaDinamica marcado;

        public RealizaPilha()
        {
            marcado = null;
        }

        public void Inserir(int aux2)
        {
            PilhaDinamica aux1 = new PilhaDinamica(aux2);
            aux1.prox = marcado;
            marcado = aux1;
            aux1 = null;
        }

        public void remove()
        {
            int elemento = marcado.elemento;
            PilhaDinamica aux = marcado;
            marcado = marcado.prox;
            aux = null;
        }
    }
}
