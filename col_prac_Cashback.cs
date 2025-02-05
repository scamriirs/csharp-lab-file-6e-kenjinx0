using System;
public class Cashback {
    public static void Main(string[] args) {
        int price;
        double cashback;
        double amt;
        Console.Write("Enter the price: ");
        price = Convert.ToInt32(Console.ReadLine());
        if (price < 0) {
            Console.Write("Enter valid price.");
        }
        else if (price < 1000) {
            Console.Write("No cashback.");
        }
        else if (price > 1000 && price <= 5000) {
            cashback = 0.05;
            amt = price * cashback;
            Console.Write($"cashback recieved is {amt}");
        }
        else if (price > 5000 && price <= 10000) {
            cashback = 0.1;
            amt = price * cashback;
            Console.Write($"cashback recieved is {amt}");
        }
        else {
            cashback = 0.15;
            amt = price * cashback;
            Console.Write($"cashback recieved is {amt}");
        }
    }
}