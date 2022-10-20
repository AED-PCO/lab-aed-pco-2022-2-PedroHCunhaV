char repetir;

do
{
    Console.WriteLine("\n-----------------------------------------------------------------------------------");
    Console.WriteLine("\nAED - Laboratório 06");
    Console.WriteLine("\nEscolha o Exercicio:");
    Console.WriteLine("\nDigite: \n (*1* Bubble Sort) \t (*2* Selection Sort) \t (*3* Insertion Sort) \n (*4* QuickSort) \t (*5* ShellSort) \t (*6* Contagem)");
    int ex = int.Parse(Console.ReadLine());

    switch (ex)
    {
        case 1:
            Bubblesort();
            break;
        case 2:
            SelectionSort();
            break;
        case 3:
            InsertionSort();
            break;
        case 4:
            QuickSort();
            break ;
        case 5:
            ShellSort();
            break;
        case 6:
            ContagemSort();
            break;
        case 0:
            break;
    }

    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Bubblesort()
    {
        Console.WriteLine("\nUtilize o metodo do Bubblesort para organizar um array");

        int min = 0, max = 100;

        int[] vetor = new int[100];
        Random rand = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rand.Next(min, max);
        }

        Console.WriteLine("\nArray Desorganizado: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}", vetor[i]);
        }

        int aux;

        for (int a = 0; a < vetor.Length - 1; a++)
        {
            for (int b = 0; b < vetor.Length - 1; b++)
            {
                if (vetor[b] > vetor[b + 1])
                {
                    aux = vetor[b + 1];
                    vetor[b + 1] = vetor[b];
                    vetor[b] = aux;
                }
            }
        }

        Console.WriteLine("\n\nArray Organizado: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}", vetor[i]);
        }
    }

    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void SelectionSort()
    {
        Console.WriteLine("\nUtilize o metodo do SelectionSort para organizar um array");

        int min = 0, max = 50;

        int[] vetor = new int[100];
        Random rand = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rand.Next(min, max);
        }

        Console.WriteLine("\nArray Desorganizado: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}", vetor[i]);
        }

        int aux, menor;

        for (int a = 0; a < vetor.Length - 1; a++)
        {
            menor = a;

            for (int b = a + 1; b < vetor.Length; b++)
            {
                if (vetor[b] < vetor[menor])
                {
                    menor = b;
                }
            }

            aux = vetor[menor];
            vetor[menor] = vetor[a];
            vetor[a] = aux;
        }

        Console.WriteLine("\n\nArray Organizado: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}", vetor[i]);
        }

    }

    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void InsertionSort()
    {
        Console.WriteLine("\nUtilize o metodo do InsertionSort para organizar um array");

        int min = 0, max = 50;

        int[] vetor = new int[100];
        Random rand = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rand.Next(min, max);
        }

        Console.WriteLine("\nArray Desorganizado: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}", vetor[i]);
        }

        int aux, flag;

        for (int a = 0; a < vetor.Length; a++)
        {
            aux = vetor[a];
            flag = 0;

            for (int b = a - 1; b >= 0 && flag != 1;)
            {
                if (aux < vetor[b])
                {
                    vetor[b + 1] = vetor[b];
                    b--;
                    vetor[b + 1] = aux;
                }
                else
                {
                    flag = 1;
                }
            }
        }

        Console.WriteLine("\n\nArray Organizado: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}", vetor[i]);
        }
    }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void QuickSort()
    {
        Console.WriteLine("\nUtilize o metodo do QuickSort para organizar um array");

        //array random criação e imprimir

        int min = 0, max = 10;

        int[] vetor = new int[10];
        Random rand = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rand.Next(min, max);
        }

        Console.WriteLine("\nArray Desorganizado: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}", vetor[i]);
        }
      
        //array organizado imprimir

        Quick(vetor, 0, vetor.Length - 1);

        Console.WriteLine("\n\nArray Organizado: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}",vetor[i]);
        }
    }

    static void Quick(int[] vetor, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int pivo = Particao(vetor, inicio, fim);

            if (pivo > 1)
            {
                Quick(vetor, inicio, pivo - 1);
            }
            if (pivo + 1 < fim)
            {
                Quick(vetor, pivo + 1, fim);
            }
        }
    }

    static int Particao(int[] vetor, int inicio, int fim)
    {
        int pivo = vetor[inicio];
        while (true)
        {
            while (vetor[inicio] < pivo)
            {
                inicio++;
            }
            while (vetor[fim] > pivo)
            {
                fim--;
            }
            if (inicio < fim)
            {
                if (vetor[inicio] == vetor[fim]) return fim;
                int temp = vetor[inicio];
                vetor[inicio] = vetor[fim];
                vetor[fim] = temp;
            }
            else
                return fim;
        }
    }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void ShellSort()
    {
        Console.WriteLine("\nUtilize o metodo do ShellSort para organizar um array");

        //array random criação e imprimir

        int min = 0, max = 10;

        int[] vetor = new int[10];
        Random rand = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rand.Next(min, max);
        }

        Console.WriteLine("\nArray Desorganizado: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}", vetor[i]);
        }

        Shell(vetor);

        Console.WriteLine("\n\nArray Organizado: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}",vetor[i]);
        }
    }

    static void Shell(int[] vetor)
    {
        int i, j, Ref, temp;
        Ref = 3;
        while (Ref > 0)
        {
            for (i = 0; i < vetor.Length; i++)
            {
                j = i;
                temp = vetor[i];
                while ((j >= Ref) && (vetor[j - Ref] > temp))
                {
                    vetor[j] = vetor[j - Ref];
                    j = j - Ref;
                }
                vetor[j] = temp;
            }
            if (Ref / 2 != 0)
                Ref = Ref / 2;
            else if (Ref == 1)
                Ref = 0;
            else
                Ref = 1;
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void ContagemSort()
    {
        Console.WriteLine("\nUtilize o metodo do ContagemSort para organizar um array");

        //array random criação e imprimir

        int min = 0, max = 10;

        int[] vetor = new int[10];
        Random rand = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rand.Next(min, max);
        }

        Console.WriteLine("\nArray Desorganizado: ");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}", vetor[i]);
        }

        Contagem(vetor);

        Console.WriteLine("\n\nArray Organizado: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("\t {0}",vetor[i]);
        }
    }

    static void Contagem(int[] vetor)
    {
        var max = MaxVal(vetor);
        var repet = new int[max + 1];
        for (int i = 0; i < max + 1; i++)
        {
            repet[i] = 0;
        }
        for (int i = 0; i < vetor.Length; i++)
        {
            repet[vetor[i]]++;
        }
        for (int i = 0, j = 0; i <= max; i++)
        {
            while (repet[i] > 0)
            {
                vetor[j] = i;
                j++;
                repet[i]--;
            }
        }
    }


    static int MaxVal(int[] vetor)
    {
        var MaximoValor = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
            if (vetor[i] > MaximoValor)
                MaximoValor = vetor[i];
        return MaximoValor;
    }

    Console.WriteLine("\nDeseja Repetir o Programa? (S / N) ");
    repetir = Console.ReadKey().KeyChar;
} while (repetir == 'S' || repetir == 's');
