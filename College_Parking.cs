using System;
class College_parking
{
    static int vipFacultyCount = 0;
    static int studentCarCount = 0;
    static int digitalCarCount = 0;
    static int totalRevenue = 0;
    static void Main()
    {
        while (true)
        {
            Console.Write("\n==== College Campus Parking System ====\n" +
            "1. Register Vehicle Entry\n" +
            "2. Exit & Show Summary\n" +
            "Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    RegisterVehicle();
                    break;
                case 2:
                    ShowSummary();
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
    static void RegisterVehicle()
    {
        Console.Write("Select Vehicle Type: \n" +
        "2. VIP/Faculty Car (No Charge)\n" +
        "3. Student Car (Rs 10 Charge)\n" +
        "4. Digital Car (Rs 20 Charge)\n" +
        "Enter your choice: ");
        int vehicleType;
        if (!int.TryParse(Console.ReadLine(), out vehicleType))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }
        switch (vehicleType)
        {
            case 2:
                vipFacultyCount++;
                Console.WriteLine("VIP/Faculty Car Registered (No Charge)");
                break;
            case 3:
                studentCarCount++;
                totalRevenue += 10;
                Console.WriteLine("Student Car Registered (Rs 10 Charged)");
                break;
            case 4:
                digitalCarCount++;
                totalRevenue += 20;
                Console.WriteLine("Digital Car Registered (Rs 20 Charged)");
                break;
            default:
                Console.WriteLine("Invalid choice! Please select a valid vehicle type.");
                break;
        }
    }
    static void ShowSummary()
    {
        Console.WriteLine("\n==== Parking Summary ====\n" +
        $"VIP/Faculty Cars: {vipFacultyCount}\n" +
        $"Student Cars: {studentCarCount}\n" +
        $"Digital Cars: {digitalCarCount}\n" +
        $"Total Revenue Collected: Rs {totalRevenue}\n" +
        "Thank you for using the Parking System!");
    }
}
