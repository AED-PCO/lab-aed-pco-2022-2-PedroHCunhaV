char repetir;

do
{
    Console.WriteLine("\n-----------------------------------------------------------------------------------");
    Console.WriteLine("\nAED - Laboratório 03");
    Console.WriteLine("\nEscolha o Exercicio:");
    Console.WriteLine("\nDigite: \n (*1* Pesquisa Binaria com POS) \t (*2* Pesquisa Binaria sem Pos) \t (*3* Ordenação Binaria)");
    int ex = int.Parse(Console.ReadLine());

    switch (ex)
    {
        case 1:
            PesquisaPOS();
            break;
        case 2:
            PesquisaSEM();
            break;
        case 3:
            Ordenacao();
            break;
        case 0:
            break;
    }

    static void PesquisaPOS()
    {
        Console.WriteLine("\nRealizar uma Pesquisa Binária utilizando POS");

        int[] vetor = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int pos = 0;
        int desejado = 7;


        pos = POS(vetor, desejado);
        if (pos == -1)
        {
            Console.Write("O valor não pode ser encontrado ");
        }
        else
        {
            Console.WriteLine("O valor encontrado esta na posição desejada é: {0}", pos);
        }
    }

    static int POS(int[] vetor, int desejado)
    {
        int meio, inicio, fim;
        inicio = 0;
        fim = vetor.Length - 1;
        int pos = -1;
        do
        {
            meio = (inicio + fim) / 2;

            if (vetor[meio] == desejado)
            {
                pos = meio;
                break;
            }
            else if (vetor[meio] < desejado)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        } while (inicio <= fim);
        return pos;

    }

    // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void PesquisaSEM()
    {
        Console.WriteLine("\nRealizar uma Pesquisa Binária SEM utilizar POS");

        int[] vetor = new int[10] { 1, 22, 55, 42, 4, 6, 8, 10, 9, 5 };

        int desejado = 10, inicio = 0, fim;
        fim = vetor.Length - 1;

        int result = SEM(vetor, desejado, inicio, fim);

        if (result == -1)
        {
            Console.Write("O valor não existe");
        }
        else
        {
            Console.Write("O valor esta na posição: {0}", result);
        }

    }

    static int SEM(int[] vetor, int valor, int inicio, int fim)
    {
        int meio = (inicio + fim) / 2;
        if (inicio > fim)
        {
            return -1;
        }
        else if (vetor[meio] == valor)
        {
            return meio;
        }
        else if (vetor[meio] > valor)
        {
            return SEM(vetor, valor, inicio, meio - 1);
        }
        else
        {
            return SEM(vetor, valor, meio + 1, fim);
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Ordenacao()
    {
        Console.WriteLine("\nAinda em Desenvolvimento (Não Conseguir o Resultado 100% mas ainda estou realizando");
    }


        Console.WriteLine("\nDeseja Repetir o Programa? (S / N) ");
    repetir = Console.ReadKey().KeyChar;
} while (repetir == 'S' || repetir == 's');
