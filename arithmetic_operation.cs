using System;
class ArithmeticOperations
{
    public static void Main(string[] args)
    {
        int var1, var2, sum, difference, multiple;
        float division = 0;
        Console.Write("Enter var1: ");
        var1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter var2: ");
        var2 = Convert.ToInt32(Console.ReadLine());
        sum = var1 + var2;
        difference = var1 - var2;
        multiple = var1 * var2;
        if (var2 != 0)
        {
            division = (float)var1 / var2;
        }
        else
        {
            Console.WriteLine("Zero division is not allowed");
        }
        Console.WriteLine("Sum is: " + sum);
        Console.WriteLine("Difference is: " + difference);
        Console.WriteLine("Multiple is: " + multiple);
        Console.WriteLine("Division is: " + division);
    }
}
