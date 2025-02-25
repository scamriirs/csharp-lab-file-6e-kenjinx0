// Exception handling - Try with multiple catches
using System;
class ExceptionHandling
{
    static void Main()
    {
        /*    try {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); 
            } */
        try
        {
            int a = 5, b = 0;
            int c;
            c = a / b;
            Console.WriteLine(c);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index out of range: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
