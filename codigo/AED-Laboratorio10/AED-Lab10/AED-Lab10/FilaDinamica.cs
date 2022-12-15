using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilaDinamicaATV
{
    class FilaDinamica
    {

        private InformaçõesBase primeiro, ultimo;

        public FilaDinamica()
        {
            primeiro = new InformaçõesBase();
            ultimo = primeiro;
        }

        public void InserirNaFila(int vl)
        {
            ultimo.marcado = new InformaçõesBase(vl);
            ultimo = ultimo.marcado;
        }

        public int RemoverDaFila()
        {
            if (primeiro == ultimo)
                return 0;

            primeiro = primeiro.marcado;
            int RemoverDaFila = primeiro.elemento;

            return RemoverDaFila;
        }

        public void Visualizar()
        {
            InformaçõesBase Vz = primeiro.marcado;

            Console.WriteLine("Visualização da Fila: ");

            while (Vz != null)
            {
                Console.Write(Vz.elemento + "\n");
                Vz = Vz.marcado;
            }
        }
    }
}
