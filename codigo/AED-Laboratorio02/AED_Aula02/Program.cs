char repetir;

do
{
    Console.WriteLine("\n-----------------------------------------------------------------------------------");
    Console.WriteLine("\nAED - Laboratório 02");
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
        case 7:
            Atividade7();
            break;
        case 0:
            break;
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade1()
    {
        Console.WriteLine("\nEscreva um método recursivo que retorne o fatorial de um número.");

        int num;

        Console.WriteLine("\nInsira o número desejado");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("Fatorial de {0} é igual: {1}", num, Fatorial(num));
    }

    static int Fatorial(int num)
    {
        if(num == 1)
        {
            return 1;
        }

        return num * Fatorial(num - 1);
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade2()
    {
        Console.WriteLine("\nEscreva um método recursivo que realize a multiplicação de doisnúmeros inteiros, A e B, recebidos por parâmetro.");

        int valor1, valor2, result;

        Console.WriteLine("\nInsira o primeiro valor desejado:");
        valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nInsira o segundo valor desejado:");
        valor2 = int.Parse(Console.ReadLine());

        result = Multiplicacao(valor1,valor2);
        Console.WriteLine("A multiplicação de {0} X {1} é: {2}", valor1, valor2, result);
    }

    static int Multiplicacao(int valor1,int valor2)
    {
        if (valor2 == 0)
        {
            return valor2;
        }
        else
        {
            return valor1 + Multiplicacao(valor1, valor2 - 1);
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade3()
    {
        Console.WriteLine("\nEscreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro.Seu método deve, portanto, retornar o resultado de AB");

        int A, B, result;

        Console.WriteLine("\nInsira o primeiro valor desejado(base):");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("\nInsira o segundo valor desejado(potência):");
        B = int.Parse(Console.ReadLine());

        result = Potencia(A, B);
        Console.WriteLine("A Potenciação de {0} por {1} é: {2}", A, B, result);
    }

    static int Potencia(int A,int B)
    {
        if(B == 0)
        {
            return 1;
        }
        else
        {
            return A * Potencia(A, B - 1);
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade4()
    {
        Console.WriteLine("\nEscreva um método recursivo que receba na frase e uma letra como parâmetros.Este método deve retornar a quantidade de ocorrências desta letra nesta frase.");

        string frase;
        int repeticao;

        Console.WriteLine("\nDigite o texto ou frase desejado: ");
        frase = (Console.ReadLine());
        Console.WriteLine("\nDigite a letra desejada:");
        char letra = Console.ReadKey().KeyChar;
        frase.ToLower();

        repeticao = texto(frase, letra);
        Console.WriteLine("\nA quantidade de vezes da palavra desejada repetida é: {0}",repeticao);
    }

    static int texto(string frase, char letra)
    {
        int n = 0;

        if (frase.Length < 1)
        {
            return 0;
        }
        else
        {
            if (frase[0] == letra)
            {
                return texto(frase.Substring(1), letra) + n + 1;
            }
            else
            {
                return texto(frase.Substring(1), letra);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade5()
    {
        Console.WriteLine("Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.");

        int[] vetor = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        Console.WriteLine("\nA soma dos números pares de um vetor de inteiro de 1 a 10 é: {0}", SomaPar(vetor, 10));
    }

    static int SomaPar(int[]vetor,int tam)
    {
        if(tam == 0)
        {
            return 0;
        }
        else
        {
            return vetor[tam-1] + SomaPar(vetor,tam-2);
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------
    
    static void Atividade6()
    {
        Console.WriteLine("\nRetirar as Vogais de uma Frase ou palavra mostrando somente suas consoantes");

        string frase;
        Console.WriteLine("\nDigite a frase desejada: ");
        RetiraVogal(Console.ReadLine());
    }

    static string RetiraVogal(string frase)
    {
        if(frase.Length == 0)
        {
            return "";
        }
        
        char[] cont = frase.ToCharArray();

        if (cont[cont.Length-1]=='a'|| cont[cont.Length - 1] == 'e' || cont[cont.Length - 1] == 'i' || cont[cont.Length - 1] == 'o'|| cont[cont.Length - 1] == 'u')
        {
            Array.Resize(ref cont, cont.Length-1);
        }
        else
        {
            Console.WriteLine(cont[cont.Length-1]);
            Array.Resize(ref cont, cont.Length-1);
        }
        
        frase = new string(cont);
        return RetiraVogal(frase);
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Atividade7()
    {
        Console.WriteLine("Definição recursiva da série de Fibonacci");

        Console.WriteLine("Digite um número: ");
        int valor = int.Parse(Console.ReadLine());

        for(int i=0;i<= valor; i++)
        {
            Console.WriteLine("A Sequência de Ficonacci é: {0}",Fibonacci(i+1));
        }
    }

    static int Fibonacci(int valor)
    {
        if(valor <= 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(valor - 1) + Fibonacci(valor - 2);
        }
    }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------

    Console.WriteLine("\nDeseja Repetir o Programa? (S / N) ");
    repetir = Console.ReadKey().KeyChar;
} while (repetir == 'S' || repetir == 's');