namespace Homework02;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput first integer:");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int a2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input third integer:");
        int a3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input third integer:");
        int a4 = Convert.ToInt32(Console.ReadLine());

        double max, min;

        if (a1 >= a2 && a1 >= a3 && a1 >= a4)
            max = a1;
        else if (a2 >= a1 && a2 >= a3 && a2 >= a4)
            max = a2;
        else if (a3 >= a1 && a3 >= a2 && a3 >= a4)
            max = a3;
        else
            max = a4;
        if (a1 <= a2 && a1 <= a3 && a1 <= a4)
            min = a1;
        else if (a2 <= a1 && a2 <= a3 && a2 <= a4)
            min = a2;
        else if (a3 <= a1 && a3 <= a2 && a3 <= a4)
            min = a3;
        else
            min = a4;
        Console.WriteLine($"max: {max}");
        Console.WriteLine($"min: {min}");

        Console.ReadLine();
    }
}

