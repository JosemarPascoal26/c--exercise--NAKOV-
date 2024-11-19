class Program
{
static int Main(string[] argv)
{
    Console.WriteLine("Insira um numero: ");
    int n = 0;
    n = int.Parse(argv[0]);
    if (n % 2 == 0)
    {
        Console.WriteLine($"{n} é um número primo.");
    }
    else
    {
        Console.WriteLine($"{n} não é um número primo.");
    }
    return (0);
}
}