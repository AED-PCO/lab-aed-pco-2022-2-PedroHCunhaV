char repetir;

do
{
    Console.WriteLine("\n-----------------------------------------------------------------------------------");
    Console.WriteLine("\nAED - Laboratório 08");
    Console.WriteLine("\nEscolha o Exercicio:");
    Console.WriteLine("\nDigite: \n (*1* Fila) \t (*2* Pilha) \t (*3* Lista)");
    int ex = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (ex)
    {
        case 1:
            AtividadeFila();
            break;
        case 2:
            AtividadePilha();
            break;
        case 3:
            AtividadeLista();
            break;
        case 0:
            break;
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void AtividadeFila()
    {
        Console.WriteLine("Atividade Referente a utilização de Fila");

        int[] vtfila = new int[5];
        int tamanhomax = 0; // fim do vetor
        char repetição;

        do
        {
            Console.WriteLine("\nEscolha a Função que deseja ser Realizada:");
            Console.WriteLine("\nDigite: \n (*1* Inserir na Fila) \t (*2* Remover da Fila) \t (*3* Visualizar a Fila)");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    InserirNaFila(vtfila, ref tamanhomax);
                    break;
                case 2:
                    RemoverDaFila(vtfila, ref tamanhomax);
                    break;
                case 3:
                    Visualizar(vtfila, ref tamanhomax);
                    break;
                case 0:
                    break;
            }

            Console.WriteLine("\nDeseja Realizar outra Função? (S / N) ");
            repetição = Console.ReadKey().KeyChar;
            Console.Clear();
        } while (repetição == 'S' || repetição == 's');
    }

    static void InserirNaFila(int[] vtfila, ref int tamanhomax)
    {
        if (tamanhomax != vtfila.Length)
        {
            Console.WriteLine("\nDigite o Valor que Deseja Inserir na Posição: {0}", tamanhomax + 1);
            vtfila[tamanhomax] = int.Parse(Console.ReadLine());
            tamanhomax++;
        }
        else
        {
            Console.WriteLine("Sua Fila já foi completamente Preenchida");
        }
    }

    static void RemoverDaFila(int[] vtfila, ref int tamanhomax)
    {

        int aux = vtfila[0];

        for (int i = 0; i < vtfila.Length - 1; i++)
        {
            vtfila[i] = vtfila[i + 1];
        }

        tamanhomax--;

        Console.WriteLine("\nRemovido o Primeiro Item da Fila : {0}", aux);
    }

    static void Visualizar(int[] vtfila, ref int tamanhomax)
    {
        Console.WriteLine("\nVisualização da Lista:\n");

        for (int i = 0; i < vtfila.Length; i++)
        {
            if (i < tamanhomax)
            {
                Console.WriteLine("Posição {0}: \n\t Numero: {1}\n", i + 1, vtfila[i]);
            }
            else
            {
                Console.WriteLine("Posição {0}  \n\t Vazia\n", i + 1);
            }
        }
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void AtividadePilha()
    {
        Console.WriteLine("Atividade Referente a utilização de Pilha");

        int[] vtpilha = new int[5];
        int tamanhomax = 0; // fim do vetor
        char repetição;

        do
        {
            Console.WriteLine("\nEscolha a Função que deseja ser Realizada:");
            Console.WriteLine("\nDigite: \n (*1* Inserir na Pilha) \t (*2* Remover da Pilha) \t (*3* Visualizar a Pilha)");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    InserirNaPilha(vtpilha, ref tamanhomax);
                    break;
                case 2:
                    RemoverDaPilha(vtpilha, ref tamanhomax);
                    break;
                case 3:
                    VisualizarPilha(vtpilha, ref tamanhomax);
                    break;
                case 0:
                    break;
            }

            Console.WriteLine("\nDeseja Realizar outra Função? (S / N) ");
            repetição = Console.ReadKey().KeyChar;
            Console.Clear();
        } while (repetição == 'S' || repetição == 's');
    }

    static void InserirNaPilha(int[] vtpilha, ref int tamanhomax)
    {
        if (tamanhomax != vtpilha.Length)
        {
            Console.WriteLine("\nDigite o Valor que Deseja Inserir na Posição: {0}", tamanhomax + 1);
            vtpilha[tamanhomax] = int.Parse(Console.ReadLine());
            tamanhomax++;
        }
        else
        {
            Console.WriteLine("Sua Pilha já foi completamente Preenchida");
        }
    }

    static void RemoverDaPilha(int[] vtpilha, ref int tamanhomax)
    {
        int aux = vtpilha[tamanhomax - 1];
        tamanhomax--;
        Console.WriteLine("\nRemovido o Último item da pilha: {0}", aux);
    }

    static void VisualizarPilha(int[] vtpilha, ref int tamanhomax)
    {
        Console.WriteLine("\nVisualização da Lista:\n");

        for (int i = 0; i < vtpilha.Length; i++)
        {
            if (i < tamanhomax)
            {
                Console.WriteLine("Posição {0}: \n\t Numero: {1}\n", i + 1, vtpilha[i]);
            }
            else
            {
                Console.WriteLine("Posição {0}  \n\t Vazia\n", i + 1);
            }
        }
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void AtividadeLista()
    {
        Console.WriteLine("Atividade Referente a utilização de Lista");

        int[] vtlista = new int[5];
        int tamanhomax = 0; // fim do vetor
        char repetição;

        do
        {
            Console.WriteLine("\nEscolha a Função que deseja ser Realizada:");
            Console.WriteLine("\nDigite: \n (*1* Inserir na Lista) \t (*2* Remover da Lista) \t (*3* Visualizar a Lista)");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    InserirNaLista(vtlista, ref tamanhomax);
                    break;
                case 2:
                    RemoverDaLista(vtlista, ref tamanhomax);
                    break;
                case 3:
                    VisualizarLista(vtlista, ref tamanhomax);
                    break;
                case 0:
                    break;
            }

            Console.WriteLine("\nDeseja Realizar outra Função? (S / N) ");
            repetição = Console.ReadKey().KeyChar;
            Console.Clear();
        } while (repetição == 'S' || repetição == 's');
    }

    static void InserirNaLista(int[] vtlista, ref int tamanhomax)
    {
        int posicao = 0;

        if (tamanhomax != vtlista.Length)
        {
            Console.Write("\nDeseja selecionar uma posição para Inserir o Valor Desejado? (S / N)  ");
            char PosInserir = char.Parse(Console.ReadLine());
            if (PosInserir == 's' || PosInserir == 'S')
            {
                do
                {
                    Console.WriteLine("\nSelecione uma posição entre 1 e {0}", vtlista.Length);
                    posicao = int.Parse(Console.ReadLine());
                }
                while (posicao < 1 || posicao > vtlista.Length);

                Console.Write("\nDigite o Número desejado para inserir na posição {0} da lista: ", posicao);
                int NumDesejado = int.Parse(Console.ReadLine());

                if (posicao == 0 && tamanhomax == 0)
                {
                    vtlista[0] = NumDesejado;
                }

                else
                {
                    for (int i = tamanhomax; i > posicao - 1; i--)
                    {
                        vtlista[i] = vtlista[i - 1];
                    }
                    vtlista[posicao - 1] = NumDesejado;
                }
                tamanhomax++;
            }
            else
            {
                Console.Write("\nDigite o Número Desejado para inserir na Posição {0} da lista: ", tamanhomax + 1);
                int Numdesejado = int.Parse(Console.ReadLine());
                vtlista[tamanhomax] = Numdesejado;
                tamanhomax++;
            }
        }
        else
        {
            Console.WriteLine("Sua Lista já foi completamente Preenchida");
        }
    }

    static void RemoverDaLista(int[] vtlista, ref int tamanhomax)
    {
        if (tamanhomax > 0)
        {
            if (tamanhomax > 0)
            {
                Console.Write("\nSelecione uma posição de 1 a 5 que deseja remover: ");
                int PosRemover = int.Parse(Console.ReadLine());
                if (PosRemover < 1 || PosRemover > tamanhomax)
                {
                    Console.WriteLine("Valor invalido!");
                }
                int AuxRemover = vtlista[PosRemover - 1];
                for (int i = PosRemover - 1; i < vtlista.Length - 1; i++)
                {
                    vtlista[i] = vtlista[i + 1];
                }

                tamanhomax--;
                Console.WriteLine("Removido o item da posição: {0}; \n\t item {1}", PosRemover, AuxRemover);
            }
            else
            {
                Console.WriteLine("A Lista esta Vazia\n");
            }
        }
    }

    static void VisualizarLista(int[] vtlista, ref int tamanhomax)
    {
        Console.WriteLine("\nVisualização da Lista:\n");

        for (int i = 0; i < vtlista.Length; i++)
        {
            if (i < tamanhomax)
            {
                Console.WriteLine("Posição {0}: \n\t Numero: {1}\n", i + 1, vtlista[i]);
            }
            else
            {
                Console.WriteLine("Posição {0}  \n\t Vazia\n", i + 1);
            }
        }
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Console.WriteLine("\nDeseja Repetir o Programa? (S / N) ");
    repetir = Console.ReadKey().KeyChar;
} while (repetir == 'S' || repetir == 's');