static void Menu()
{
    //Menu de Opções
    Console.WriteLine("\t\t\t*******Bem-vindo a Calculadora 1.1*******");
    Console.WriteLine("\t\t\t\tQual Operação Deseja Realizar?" +
       "\n1- Soma \n2- Subtração \n3- Multiplicação \n4- Divisão \n5- Potenciação" +
       "\n6- Raiz Quadrada \n7- Raiz Cúbica\n \n0 - Fechar calculadora");

    //Escolha das opções do menu
    Console.Write("Opção: ");
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 0: System.Environment.Exit(0); break;
        //Soma
        case 1:
            Soma();
            break;

        //Subtração
        case 2:
            Subtracao();
            break;

        //Multiplicação
        case 3:
            Multiplicacao();
            break;

        //Divisão
        case 4:
            double a, b;
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
            double a, b;
            Console.Write("\t\t\t\t\tBase: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\t\t\t\tExpoente: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\t\t\t\tPotência: {a}^{b} = {Math.Pow(a, b)}");
            break;

        //Raiz quadrada
        case 6:
            double a;
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
            double a;
            Console.Write("\t\t\t\t\tNúmero: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\t\t\t\tRaiz cúbica de: {a} = {Math.Cbrt(a)}");
            break;

        default:
            Console.WriteLine("\t\t\t\t\tEscolha uma opção válida de acordo com o menu!");
            break;
    }

}

static void Soma()
{
    double a, b;
    Console.Write("\t\t\t\t\tPrimeiro número: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("\t\t\t\t\tSegundo número: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\t\t\t\t\tSoma dos valores: {a} + {b} = {a + b}");
}
static void Subtracao()
{
    double a, b;
    Console.Write("\t\t\t\t\tPrimeiro número: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("\t\t\t\t\tSegundo número: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\t\t\t\tSubtração dos valores: {a} - {b} = {a - b}");
}

static void Multiplicacao()
{
    double a, b;
    Console.Write("\t\t\t\t\tPrimeiro número: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("\t\t\t\t\tSegundo número: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\t\t\t\tMultiplicação dos valores: {a} x {b} = {a * b}");
}