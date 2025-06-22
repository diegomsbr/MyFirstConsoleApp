


internal class Program
{
    private static void Main(string[] args)
    {
        TryAndIf();
        TrySomeLoops();
        TryAnIfElse();
    }

    private static void TryAnIfElse()
    {
        int someValue = 4;
        string name = "Bobbo Jrs.";
        if ((someValue == 3) && (name == "Joe"))
        {
            Console.WriteLine("The value is 3 and the name is Joe.");
        }
        else
        {
            Console.WriteLine("Neither condition was met.");
        }
    }

    private static void TrySomeLoops()
    {
        int count = 0;

        while (count <10)
        {
            count++;
        }

        for (int i = 0; i < 5; i++)
        {
            count--;
        }

        Console.WriteLine($"Final count: {count}");
    }

    private static void TryAndIf()
    {
        int x = 5;
        if (x == 10)
        {
            Console.WriteLine("x is 10.");
        }
        else
        {
            Console.WriteLine("x is not 10.");
        }
    }
}