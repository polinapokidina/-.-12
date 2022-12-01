using System;
class demo
{
    static void Main()
    {
        Console.Write("n : ");
        int n = Int32.Parse(Console.ReadLine()), min = int.MaxValue, val = -1;
        for (; n > 0; n--)
        {
            val = Int32.Parse(Console.ReadLine());
            min = min > val ? val : min;
        }
        Console.WriteLine("min : " + min);
        Console.ReadKey(true);
    }
}
