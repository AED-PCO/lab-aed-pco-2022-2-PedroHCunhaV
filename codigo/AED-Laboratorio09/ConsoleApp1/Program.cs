using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

char repetir;

do
{
    Console.WriteLine("\n-----------------------------------------------------------------------------------");
    Console.WriteLine("\nAED - Laboratório 09");
    Console.WriteLine("\nEscolha o Exercicio:");
    Console.WriteLine("\nDigite: \n (*1* Atividade Pilha) \t (*2* Atividade Fila) \t (*3* Atividade Lista)");
    int ex = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (ex)
    {
        case 1:
            AtividadePilha();
            break;
        case 2:
            AtividadeFila();
            break;
        case 3:
            AtividadeLista();
            break;
        case 0:
            break;
    }


//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void AtividadePilha()
    {
        Console.WriteLine("Atividade Referente a Copiar de uma Pilha para Outra");

        int[] PilhaOriginal = new int[5];
        int[] PilhaCopiada = new int[5];
        int tamanhomax = 5, tamanhomaxCopiada = 0;
        char copia;

       
        InserirNaPilha(PilhaOriginal, tamanhomax);

        Console.Write("\nPilha Original: ");
        VisualizarPilha(PilhaOriginal);

        Console.Write("\nPilha Copíada: ");
        VisualizarPilha(PilhaCopiada);

        Console.WriteLine("\nDeseja Copiar para outra Pilha? (S / N)");
        copia = char.Parse(Console.ReadLine());


        if (copia == 'S'||copia =='s')
        {
            for (int i = 0; i < PilhaOriginal.Length; i++)
            {
                PilhaCopiada[i] = PilhaOriginal[i];
            }
            Console.Write("\nPilha Original: ");
            VisualizarPilha(PilhaOriginal);
            Console.Write("\nPilha Copiada: ");
            VisualizarPilha(PilhaCopiada);
        }
    }

    static void InserirNaPilha(int[] PilhaOriginal,int aux)
    {
        Random rnd = new Random();
        for (int i = 0; i < aux; i++)
        {
            PilhaOriginal[i] = rnd.Next(0, 10);
        }
    }

    static void VisualizarPilha(int[] vet)
    {
        Console.WriteLine("\nVisualização da Pilha\n");

        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine("Posição {0}: \t Numero: {1}", i + 1, vet[i]);
        }
    }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void AtividadeFila()
    {
        Console.WriteLine("Atividade Referente a Copiar de uma Pilha para Outra Invertendo a Ordem");

        int[] FilaNormal = new int[5] { 1, 2, 3, 4, 5 };
        int[] FilaInversa = new int[5];
        char copiaivrt;

        Console.WriteLine("\nFila Original:");
        VisualizarFila(FilaNormal);

        Console.WriteLine("\nDeseja Copiar para e inverter para outra Fila? (S / N)");
        copiaivrt = char.Parse(Console.ReadLine());


        if (copiaivrt == 'S' || copiaivrt == 's')
        {
            FilaInversa = Inversao(FilaNormal, FilaNormal.Length);

            Console.WriteLine("\nFila Inversa:");
            VisualizarFila(FilaInversa);
        }

    }

    static void VisualizarFila(int[] vetor)
    {
        Console.WriteLine("\nVisualização da Fila:\n");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("Posição {0}: \t Numero: {1}", i + 1, vetor[i]);
        }
    }

    static void InserirNaFila(int[] vet, ref int pos, int num)
    {
        vet[pos] = num;
        pos++;
    }

    static int[] Inversao(int[] vet, int pos)
    {
        int[] Pilha = new int[pos];
        int[] aux = new int[pos];

        int i = 0;
        while (i < vet.Length)
            InserirNaFila(Pilha, ref i, RemoverDaFila(vet));


        int j = 0;
        while (j < vet.Length)
            InserirNaFila(aux, ref j, RemoverDaPilha(Pilha, ref pos));

        return aux;
    }

    static int RemoverDaFila(int[] vet)
    {
        int aux = vet[0];
        for (int i = 0; i < vet.Length - 1; i++)
            vet[i] = vet[i + 1];
        return aux;
    }

    static int RemoverDaPilha(int[] vet, ref int pos)
    {
        pos--;
        return vet[pos];
    }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void AtividadeLista()
    {
        Console.WriteLine("Atividade Referente a Copiar de uma Lista para Outra");

        int[] ListaOriginal = new int[5];
        int[] ListaCopiada = new int[5];
        int[] ListaCompleta = new int[10];
        int i, j = 0;

        int tamanhomaxOr = 5;
        int tamanhomaxCp = 5;

        InserirNaLista(ref ListaOriginal, tamanhomaxOr);
        Console.Write("\nLista Original: ");
        VisualizarLista(ListaOriginal);

        InserirNaLista(ref ListaCopiada, tamanhomaxCp);
        Console.Write("\nLista Copiada: ");
        VisualizarLista(ListaCopiada);

        for (i = 0; j < ListaCompleta.Length; i = (++i % ListaOriginal.Length))
        {
            if (j < ListaOriginal.Length)
            {
                ListaCompleta[j] = ListaOriginal[i];
            }
            else
            {
                ListaCompleta[j] = ListaCopiada[i];
            }

            j++;
        }

        Console.Write("\nLista Primeira Parte Normal e Segunda Parte Inversa Juntas: ");
        VisualizarLista(ListaCompleta);
    }


    static void InserirNaLista(ref int[] Lista, int aux)
    {
        Random rnd = new Random();
        for (int i = 0; i < aux; i++)
        {
            Lista[i] = rnd.Next(0, 10);
        }
    }

    static void VisualizarLista(int[] vetor)
    {
        Console.WriteLine("\nVisualização da Lista:\n");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("Posição {0}: \t Numero: {1}", i + 1, vetor[i]);
        }
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Console.WriteLine("\nDeseja Repetir o Programa? (S / N) ");
        repetir = Console.ReadKey().KeyChar;
    } while (repetir == 'S' || repetir == 's') ;