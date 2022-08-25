char repetir;

do
{
    Console.WriteLine("\n\nAED - Laboratório 01");
    Console.WriteLine("Escolha o Exercicio:");
    int ex = int.Parse(Console.ReadLine());

    switch (ex)
    {

        case 1:
            Atividade1();
            break;
        case 2:
            Atividade2();
            break;
        case 3:
            Atividade3();
            break;
        case 4:
            Atividade4();
            break;
        case 5:
            Atividade5();
            break;
        case 6:
            Atividade6();
            break;
        case 0:
            break;

    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade1()
    {
        Console.WriteLine("\nExercício 1");
        Console.WriteLine("\nExercício divir o número em duas partes e ver se o quadrado da o número (1000 a 9999)");

        int resto, resultado, quantidade = 9999, soma, quadrado;

        for (int i = 1000; i < quantidade; i++)
        {
            resto = i % 100;
            resultado = i / 100;
            soma = resultado + resto;
            quadrado = soma * soma;

            if (quadrado == i)
            {
                Console.WriteLine("Resultado: " + quadrado);
            }

        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade2()
    {
        Console.WriteLine("\nExercício 2 - Primeira Parte");
        Console.WriteLine("\nExercício descobrir se o valor digitado é primo");

        Console.WriteLine("\nDigite o Valor Desejado: ");
        int num = int.Parse(Console.ReadLine());
        int cont = 1, i = 0;

        for (i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                cont++;
            }
        }

        if (cont == 2)
        {
            Console.WriteLine("O numero {0} é primo", num);
        }
        else
        {
            Console.WriteLine("O numero {0} não é primo", num);
        }

        Console.WriteLine("\n--------------------------------------------------------------------");
        Console.WriteLine("\nExercício 2 - Segunda Parte");
        Console.WriteLine("\nExercício para listar todos números perfeitos de 1 a 1000");

        int valor = 1, quantidade = 1000, soma = 0, j;

        while (valor <= quantidade)
        {
            for (j = 1; j < valor; j++)
            {
                if (valor % j == 0)
                {
                    soma = soma + j;
                }
            }

            j = 0;

            if (soma == valor)
            {
                Console.WriteLine("Números Perfeitos: " + valor);
            }
            soma = 0;
            valor++;
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade3()
    {
        Console.WriteLine("\nExercício 3");
        Console.WriteLine("\nExercício sobre Vetores");

        int[] A = new int[5] { 8, 4, 3, 9, 5 };
        int[] B = new int[5] { 8, 4, 7, 9, 1 };
        int[] C = new int[5];
        int[] D = new int[5];

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == B[i])
            {
                C[i] = A[i];
            }
            if(A[i] != B[i])
            {
                D[i] = A[i];
            }
        }

        for (int i = 0; i < C.Length; i++)
        {
            Console.WriteLine("Conjunto C:" + C[i] + "\t");
        }

        Console.WriteLine("\n");

        for(int j=0;j<D.Length; j++)
        {
            Console.WriteLine("Conjunto D:" + D[j] + "\t");
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade4()
    {
        Console.WriteLine("\nExercício 4");
        Console.WriteLine("\nExercício sobre Matriz");

        int soma;
        int[,] A = { { 1, 2, 3 }, { 2, 3, 5 }, { 4, 6, 5 }, { 9, 0, 5 }, { 1, 2, 3 } };
        int[] SomaLinhas = new int[5];
        int[] SomaColunas = new int[5];

        for (int l = 0; l < 5; l++)
        {
            soma = 0;
            for(int c = 0; c < 3; c++)
            {
                soma += A[l, c];
            }
            SomaLinhas[l] = soma;   
        }

        for(int c = 0; c < 3; c++)
        {
            soma = 0;
            for(int l = 0; l < 5; l++)
            {
                soma += A[l, c];
            }
            SomaColunas[c] = soma;
        }

        for (int l = 0; l < 5; l++)
        {
            Console.WriteLine("\nLinha: {0} \tSoma da Linha: {1}",l, SomaLinhas[l]);
        }

        for (int c = 0; c < 3; c++)
        {
            Console.WriteLine("\nColuna: {0} \tSoma da Coluna: {1}", c, SomaColunas[c]);
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade5()
    {
        Console.WriteLine("\nExercício 5");
        Console.WriteLine("\nExercício com função capaz de calcular o fatorial de um número inteiro");

        int num;

        Console.WriteLine("Digite o Número");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("O fatorial do {1} é: {0}", Fatorial(num), num);
    }

    static int Fatorial(int fat)
    {
        int resultado = 1;
        while (fat != 1)
        {
            resultado = resultado * fat;
            fat = fat - 1;
        }
        return resultado;
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade6()
    {
        Console.WriteLine("\nExercício 6");
        Console.WriteLine("\nExercício com função capaz de calcular o número desejado com a elevação desejada");

        double num, elev, result = 0;

        Console.WriteLine("\nDigite o Valor Desejado: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite a Elevação Desejada: ");
        elev = int.Parse(Console.ReadLine());

        result = Elevacao(ref num, ref elev, ref result);
        Console.WriteLine("\nO valor base é: {0} \nO valor de elevação é: {1} \nO resultado é: {2}", num, elev, result);
    }

    static double Elevacao(ref double x, ref double y, ref double resul)
    {
        resul = Math.Pow(x, y);
        return resul;
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------



    Console.WriteLine("\nDeseja Repetir o Programa? (S / N) ");
    repetir = Console.ReadKey().KeyChar;
} while (repetir == 'S' || repetir == 's');
