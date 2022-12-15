using FilaDinamicaATV;

char repetir;

do
{
    Console.WriteLine("\n-----------------------------------------------------------------------------------");
    Console.WriteLine("\nAED - Laboratório ");
    Console.WriteLine("\nEscolha o Exercicio:");
    Console.WriteLine("\nDigite: \n (*1* Fila Dinâmica) \t (*2* Pilha Dinâmica) \t (*3* Lista Dinâmica)");
    int ex = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (ex)
    {
        case 1:
            FilaDinâmicaFunc();
            break;
        case 2:
            PilhaDinâmicaFunc();
            break;
        case 3:
            ListaDinâmicaFunc();
            break;
        case 0:
            break;
    }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void FilaDinâmicaFunc()
    {
        FilaDinamica fd = new FilaDinamica();

        char repetição;

        do
        {
            Console.WriteLine("\nEscolha a Função que deseja ser Realizada:");
            Console.WriteLine("\nDigite: \n (*1* Inserir na Fila) \t (*2* Remover da Fila) \t (*3* Visualizar a Fila)");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:             
                    Console.WriteLine("Informe o valor que deseja Inserir na Fila: ");
                    int ValorIns = int.Parse(Console.ReadLine());
                    fd.InserirNaFila(ValorIns);
                    break;
                case 2:
                    Console.WriteLine("O valor Removido da Fila foi: " + fd.RemoverDaFila());
                    break;
                case 3:
                    fd.Visualizar();
                    break;
                case 0:
                    break;
            }

            Console.WriteLine("\nDeseja Realizar outra Função? (S / N) ");
            repetição = Console.ReadKey().KeyChar;
            Console.Clear();
        } while (repetição == 'S' || repetição == 's');
    }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void PilhaDinâmicaFunc()
    {

    }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    static void ListaDinâmicaFunc()
    {

    }

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Console.WriteLine("\nDeseja Repetir o Programa? (S / N) ");
    repetir = Console.ReadKey().KeyChar;
} while (repetir == 'S' || repetir == 's');