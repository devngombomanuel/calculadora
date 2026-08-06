double a, b;
int opcao;
string? resp;

do
{
    //Menu de Operações
    Console.WriteLine("\t\t\t*******Bem-vindo a Calculadora 1.0*******");
    Console.WriteLine("\t\t\t\tQual Operação Deseja Realizar?" +
       "\n1- Soma \n2- Subtração \n3- Multiplicação \n4- Divisão \n5- Potenciação" +
       "\n6- Raiz Quadrada \n7- Raiz Cúbica\n");


    //Escolha das operações
    {
        case 0: System.Environment.Exit(0); break;
        //Soma
        case 1:
            Console.Write("\t\t\t\t\tPrimeiro número: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\t\t\t\tSegundo número: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\t\t\t\t\tSoma dos valores: {a} + {b} = {a + b}");
            break;

        //Subtração
        case 2:
            Console.Write("\t\t\t\t\tPrimeiro número: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\t\t\t\tSegundo número: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\t\t\t\tSubtração dos valores: {a} - {b} = {a - b}");
            break;

        //Multiplicação
        case 3:
            Console.Write("\t\t\t\t\tPrimeiro número: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\t\t\t\tSegundo número: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\t\t\t\tMultiplicação dos valores: {a} x {b} = {a * b}");
            break;

        //Divisão
        case 4:
            Console.Write("\t\t\t\t\tPrimeiro número: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\t\t\t\tSegundo número: ");
            b = Convert.ToDouble(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("\t\t\t\tO divisor não pode ser 0!");
            }
            else
            {
                Console.WriteLine($"\t\t\t\tDivisão entre os valores: {a} / {b} = {a / b}");
            }
            break;

        //Potenciação
        case 5:
            Console.Write("\t\t\t\t\tBase: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\t\t\t\tExpoente: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\t\t\t\tPotência: {a}^{b} = {Math.Pow(a, b)}");
            break;

        //Raiz quadrada
        case 6:
            Console.Write("\t\t\t\t\tNúmero: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine($"\t\t\t\tRaiz quadrada de: {a} = {Math.Sqrt(a)}");
            }
            else
            {
                Console.WriteLine("\t\t\t\tO número não pode ser negativo!");
            }

            break;

        //Raiz cúbica
        case 7:
            Console.Write("\t\t\t\t\tNúmero: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\t\t\t\tRaiz cúbica de: {a} = {Math.Cbrt(a)}");
        break;

        default:
            Console.WriteLine("\t\t\t\t\tEscolha uma opção válida! \n1 pra Soma, " +
            "\n2 pra subtração, 3 pra multiplicação, 4 pra divisão," +
            "\n5 pra potenciação, 6 pra raiz quadrada, e 7 pra raiz cubica");
        break;
    }

    Console.WriteLine("\n\t\t\t\t\tDeseja Continuar[S/N]?");
    resp = Console.ReadLine();
    Console.Clear();

    if (resp.Equals("n", StringComparison.OrdinalIgnoreCase))
    {
        Console.Clear();
        Console.WriteLine("Programa fechado com sucesso!");
        break;
    }
    else if (resp.Equals("s", StringComparison.OrdinalIgnoreCase) == false)
    {
            Console.WriteLine("Escolha uma das opções: S ou N");
    }
    else
    {
        Console.Clear();
    }


    

} while (resp.Equals("s", StringComparison.OrdinalIgnoreCase));
