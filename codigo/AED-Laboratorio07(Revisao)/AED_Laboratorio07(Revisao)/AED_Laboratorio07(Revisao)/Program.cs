using System.IO;

char repetir;

do
{
    Console.WriteLine("\n-----------------------------------------------------------------------------------");
    Console.WriteLine("\nAED - Laboratório 07 (Revisão Prova)");
    Console.WriteLine("\nEscolha o Exercicio:");
    Console.WriteLine("\nDigite: \n (*1* Questão01) \t (*2* Questão0) \t (*3* Questão03) \n (*4* Questão04) \t (*5* Questão05) ");
    int ex = int.Parse(Console.ReadLine());

    switch (ex)
    {
        case 1:
            Questao01();
            break;
        case 2:
            Questao02();
            break;
        case 3:
            Questao03();
            break;
        case 4:
            Questao04();
            break;
        case 5:
            Questao05();
            break;
        case 0:
            break;
    }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Questao01()
    {
        Console.WriteLine("\nQuestão 01:\n");

        StreamReader arq1 = new StreamReader("C:\\Users\\1396015\\Downloads\\AED_Laboratorio07(Revisao)\\AED_Laboratorio07(Revisao)\\textos para questoes\\arq1.txt");
        string arquivo = arq1.ReadLine();
        while (arquivo != null)
        {
            Console.WriteLine(arquivo);
            arquivo = arq1.ReadLine();
        }


        Console.WriteLine("Digite o texto desejado:");
        string texto = Console.ReadLine();
    }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Questao02()
    {
    //    Console.WriteLine("\nQuestão 02:\n");
    //    Console.WriteLine("\nA questão irá dar um loop infinito\n");

    //    int a = 6;
    //    //Console.WriteLine("Resultado: {0}",funcaoQ2(a));
    //}

    ////static int funcaoQ2(int a)
    ////{
    ////    //if (a <= 1)
    ////    //{
    ////    //    return 0;
    ////    //}
    ////    //else
    ////    //{
    ////    //    return funcaoQ2((a - 2) + 5);
    ////    //}
    }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Questao03()
    {
        Console.WriteLine("\nQuestão 03:\n");

        StreamReader arq2 = new StreamReader("C:\\Users\\1396015\\Downloads\\AED_Laboratorio07(Revisao)\\AED_Laboratorio07(Revisao)\\textos para questoes\\arq2.txt");
        string arquivo = arq2.ReadLine();
        if (arquivo != null)
        {
            Console.WriteLine("Texto antes de ser Invertido: {0}",arquivo);
        }
        string invertido = new string(arquivo.Reverse().ToArray());
        Console.WriteLine("Texto Invertido: {0}",invertido);
    }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Questao04()
    {
        Console.WriteLine("\nQuestão 04:\n");

        Console.WriteLine("Gerador de CPF");     
        int[] cpf = new int[11];
        int decimo = 0; int decimoprimeiro = 0; int cont = 100;
        while (cont > 0)
        {
            cpf = random();
            decimo = Decimo(cpf);
            cpf[9] = decimo;
            decimoprimeiro = DecimoPrimeiro(cpf);
            cpf[10] = decimoprimeiro;
            for (int i = 0; i < cpf.Length; i++)
            {
                Console.Write(Cpf[i]);
            }
            Console.Write(" ");
            cont--;
        }
    }

    static int Decimo(int[] vet)
    {
        int ultimo = 0;
        int Ref = 10;
        int n = 0;
        for (int i = 0; i < 9; i++)
        {
            n += vet[i] * Ref;
            Ref--;
        }
        int resto = n % 11;
        if (resto == 0 || resto == 1)
        {
            ultimo = 0;
        }
        else
            ultimo = 11 - resto;
        return ultimo;
    }

    static int DecimoPrimeiro(int[] vet)
    {
        int ultimo = 0;
        int Ref = 10;
        int n = 0;
        for (int i = 1; i < 10; i++)
        {
            n += vet[i] * Ref;
            Ref--;
        }
        int resto = n % 11;
        if (resto == 0 || resto == 1)
        {
            ultimo = 0;
        }
        else
            ultimo = 11 - resto;
        return ultimo;
    }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void Questao05()
    {
        Console.WriteLine("\nQuestão 05:\n");

        int[] v = new int[7] {10,5,7,15,22,9,30};
        int a = 6;

        Console.WriteLine("\nResultado: {0}", Q5(a, v));
    }

    static int Q5(int a, int[] v)
    {
        if (a == 1)
        {
            return v[0];
        }              
        else
        {
            int x;
            x = Q5(a - 1, v);

            if(x > v[a - 1])
            {
                return x;
            }
            else
            {
                return v[a-1];  
            }
        }
        
    }

    Console.WriteLine("\nDeseja Repetir o Programa? (S / N) ");
    repetir = Console.ReadKey().KeyChar;
} while (repetir == 'S' || repetir == 's');
