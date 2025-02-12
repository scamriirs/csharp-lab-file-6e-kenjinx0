/* Create a program to find the sum of longest sequence of positive in 1D array :
    {1, 2, 3, -4, 2, 3, 4, 5, -6, -7, 1, 2, 3} */
using System;
class LongestSum {
    static int SumOfLongestPositiveSequence(int[] arr) {
        int maxSum = 0, currentSum = 0;
        int maxLength = 0, currentLength = 0;
        foreach (int num in arr) {
            if (num > 0) {
                currentSum += num;
                currentLength++;
            }
            else {
                if (currentLength > maxLength) {
                    maxLength = currentLength;
                    maxSum = currentSum;
                }
                currentSum = 0;
                currentLength = 0;
            }
        }
        if (currentLength > maxLength) {
            maxSum = currentSum;
        }

        return maxSum;
    }
    static void Main() {
        int[] arr = { 1, 2, 3, -4, 2, 3, 4, 5, -6, -7, 1, 2, 3 };
        Console.WriteLine("Sum of longest sequence of positive numbers: " + SumOfLongestPositiveSequence(arr));
    }
}
