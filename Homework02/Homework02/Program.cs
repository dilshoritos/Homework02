namespace Homework02;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a real number:");
        int number = int.Parse(Console.ReadLine());
        int n1 = number;

        int m = 0;
        for (; number>0; m++)
        {
            number /= 10;
        }

        double s1 = 0;
        double s2 = 0;
        for(int i=0;i<m; i++)
        {
            s1 = n1 % 2;
            n1 = (int)(n1 - s1) / 2;
            s2 += s1 * Math.Pow(10, i);
            
        }
        Console.WriteLine(s2);





        Console.ReadLine();
    }
}

