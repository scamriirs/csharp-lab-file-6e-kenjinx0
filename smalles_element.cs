// Write a program to find the smallest element in an array
using System;
class MinArray {
    public static void Main(string[] args) {
        int[] arr = new int[] { 4, 47, 85, 2, 29 };
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++) {
            if (min > arr[i]) {
                min = arr[i];
            }
        }
        Console.WriteLine($"smallest integer in the array is: {min}");
    }
}