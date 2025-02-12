// Create a program to show the concept of method overloading.
using System;
class MethodOverload
{
    public static void Method()
    {   // Method without any arguments
        Console.WriteLine("This is first method.\n");
    }
    public static void Method(int n)
    {   // Overloaded method with int argument
        Console.WriteLine("This is overloaded method.");
    }

    public static void Main()
    {
        int a = 5;
        Method();   // calling without arguments will call normal Method()
        Method(a);  // calling the Method() with arguments will call overloaded method
    }
}