char repetir;

do
{
    Console.WriteLine("\n-----------------------------------------------------------------------------------");
    Console.WriteLine("\nAED - Laboratório 09");
    Console.WriteLine("\nEscolha o Exercicio:");
    Console.WriteLine("\nDigite: \n (*1* ListaCircular) \t (*2* ListaEncadeada) ");
    int ex = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (ex)
    {
        case 1:
            ListaCircular();
            break;
        case 2:
            ListaEncadeada();
            break;
        case 0:
            break;
    }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void ListaCircular()
    {
        Console.WriteLine("Atividade Referente a Lista Circular");

        Console.WriteLine("AINDA EM DESENVOLVIMENTO");

        // --------------------------- AINDA EM DESENVOLVIMENTO ---------------------------------------
    }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void ListaEncadeada()
    {
        Console.WriteLine("Atividade Referente a Lista Encadeada");

        Console.WriteLine("AINDA EM DESENVOLVIMENTO");

        // --------------------------- AINDA EM DESENVOLVIMENTO ---------------------------------------
    }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Console.WriteLine("\nDeseja Repetir o Programa? (S / N) ");
    repetir = Console.ReadKey().KeyChar;
} while (repetir == 'S' || repetir == 's');