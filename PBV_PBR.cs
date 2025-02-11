/* Write a program to find the square of a number:
    - using pass by value
    - using pass by reference */
using System;
class SquareByPBV_PBR {
    public static int SquareByValue(int num) {
        num = num * num;
        return num;
    }
    public static void SquareByRef(ref int num) {
        num = num * num;
    }
    public static void Main(string[] args) {
        int num1 = 5;
        Console.WriteLine($"Original value: {num1}");
        // Using pass by value
        int resultByValue = SquareByValue(num1);
        Console.WriteLine($"Square (pass by value): {resultByValue}");
        Console.WriteLine($"Value of num1 after pass by value: {num1}\n");
        // Using pass by reference
        SquareByRef(ref num1);
        Console.WriteLine($"Square (pass by reference): {num1}");
        Console.WriteLine($"Value of num1 after pass by value: {num1}");
    }
}