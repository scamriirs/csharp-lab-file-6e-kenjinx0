using System;
class Array_Sum {
    public static void Main() {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] arr1 = new int[rows, cols];
        int[,] arr2 = new int[rows, cols];
        int[,] sumArray = new int[rows, cols];

        Console.WriteLine("Enter elements for first array:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write($"Element [{i},{j}]: ");
                arr1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements for second array:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write($"Element [{i},{j}]: ");
                arr2[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                sumArray[i, j] = arr1[i, j] + arr2[i, j];
            }
        }

        Console.WriteLine("Sum of the two arrays:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write(sumArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}