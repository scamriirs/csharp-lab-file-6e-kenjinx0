// Create a program to find the sum of all the elements of 2D matrix
using System;
class Array_Sum {
    public static void Main() {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] arr1 = new int[rows, cols];
        int sumArray = 0;

        Console.WriteLine("Enter elements for first array:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write($"Element [{i},{j}]: ");
                arr1[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Sum of elements is: ");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                sumArray += arr1[i, j];
            }
        }
        Console.WriteLine(sumArray);
    }
}