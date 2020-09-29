using System;
class calculator
{
    static void Main(string[] args)
    {
        Console.Title = "catnips simple calculator";
        while (true)
        {
            try
            {
                Console.Write("[ ADD ] Value 1: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("[ ADD ] Value 2: ");
                int b = int.Parse(Console.ReadLine());
                int c = (a + b);
                Console.WriteLine(c);
            }
            catch
            {
                Console.WriteLine("error");
            }
        }
    }
}
