class Program
{
static int Main(string[] args)
{
    if(int.Parse(args[0]) % 35 == 0)
    {
        Console.WriteLine("TRUE");
    }
    else
        Console.WriteLine("\n");
    return (0); 
}
}