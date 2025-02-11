// Write a program to find the integer and fractional part of a number using "out" keyword.
using System;
class Split {
	public static void SplitNumber(double number, out int integerPart, out double fractionalPart) {
		integerPart = (int)number;
		fractionalPart = number - integerPart;
	}
	public static void Main() {
		double number;
		int integerPart;
		double fractionalPart;
		Console.Write("Enter a number: ");
		number = Convert.ToDouble(Console.ReadLine());
		SplitNumber(number, out integerPart, out fractionalPart);
		Console.WriteLine("Integer part: " + integerPart);
		Console.WriteLine("Fractional part: " + fractionalPart);
	}
}