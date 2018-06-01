using System;

namespace Example
{
    class Program
    {
    static (int, int) GetTwoNumbers()
    {
        // Return 2 numbers in a ValueTuple.
        return (10, 20);
    }

    static void Main()
    {
        var result = GetTwoNumbers();
        Console.WriteLine(result.Item1);
        Console.WriteLine(result.Item2);
        }
    }
}
