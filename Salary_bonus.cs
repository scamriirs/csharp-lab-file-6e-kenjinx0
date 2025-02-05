using System;
public class Emp_Bonus {
	public static void Main(string[] args) {
		int exp;
		int sal;
		double bonus;
		double final_sal;
		Console.Write("Enter the salry: ");
		sal = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the Experience: ");
		exp = Convert.ToInt32(Console.ReadLine());
		if (exp < 0)
			Console.Write("Enter valid experiece.");

		else if (exp < 5)
			Console.Write("No bonus take mithai.");

		else if (exp > 5 && exp <= 10)
		{
			bonus = 0.1;
			final_sal = sal + (sal * bonus);
			Console.Write($"bonus salary recieved is {final_sal}");
		}
		else if (exp > 10 && exp <= 20)
		{
			bonus = 0.2;
			final_sal = sal + (sal * bonus);
			Console.Write($"bonus salary recieved is {final_sal}");
		}
		else {
			bonus = 0.2;
			final_sal = sal + (sal * bonus);
			Console.Write($"bonus salary recieved is {final_sal}");

		}
	}
}