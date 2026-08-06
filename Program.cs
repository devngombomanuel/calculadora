Menu();
static void Menu()
{
    //Menu de Opções
    Console.Clear();
    Console.WriteLine("\t\t\t*******Bem-vindo a Calculadora 1.1*******");
    Console.WriteLine("\t\t\t\tQual Operação Deseja Realizar?" +
       "\n1- Soma \n2- Subtração \n3- Multiplicação \n4- Divisão \n5- Potenciação" +
       "\n6- Raiz Quadrada \n7- Raiz Cúbica\n \n0 - Fechar calculadora");

    Console.Write("Opção: ");
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3:Multiplicacao(); break;
        case 4:Divisao();break;
        case 5:Potenciacao();break;
        case 6:RaizQuadrada();break;
        case 7:RaizCubica();break;
        default:
            Console.WriteLine("\t\t\tEscolha uma opção válida de acordo com o menu!");
            Thread.Sleep(2000);
            Menu();
            break;
    }

}

//Função Soma
static void Soma()
{
    Console.Clear();
    double a, b;
    Console.Write("\t\t\t\t\tPrimeiro número: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("\t\t\t\t\tSegundo número: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\t\t\t\t\tSoma dos valores: {a} + {b} = {a + b}");
    Thread.Sleep(4000);
    Menu();
}
//Função Subtração
static void Subtracao()
{
    Console.Clear();
    double a, b;
    Console.Write("\t\t\t\t\tPrimeiro número: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("\t\t\t\t\tSegundo número: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\t\t\t\tSubtração dos valores: {a} - {b} = {a - b}");
    Thread.Sleep(4000);
    Menu();
}
//Função Multiplicação
static void Multiplicacao()
{
    Console.Clear();
    double a, b;
    Console.Write("\t\t\t\t\tPrimeiro número: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("\t\t\t\t\tSegundo número: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\t\t\t\tMultiplicação dos valores: {a} x {b} = {a * b}");
    Thread.Sleep(4000);
    Menu();
}

//Função Divisão
static void Divisao()
{
    Console.Clear();
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
    Thread.Sleep(4000);
    Menu();
}

//Função Potenciação
static void Potenciacao()
{
    Console.Clear();
    double a, b;
    Console.Write("\t\t\t\t\tBase: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("\t\t\t\t\tExpoente: ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\t\t\t\tPotência: {a}^{b} = {Math.Pow(a, b)}");
    Thread.Sleep(4000);
    Menu();
}

//Função Raiz Quadrada
static void RaizQuadrada()
{
    Console.Clear();
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
    Thread.Sleep(4000);
    Menu();
}
//Função Raiz Cubica
static void RaizCubica()
{
    Console.Clear();
    double a;
    Console.Write("\t\t\t\t\tNúmero: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"\t\t\t\tRaiz cúbica de: {a} = {Math.Cbrt(a)}");
    Thread.Sleep(4000);
    Menu();
}