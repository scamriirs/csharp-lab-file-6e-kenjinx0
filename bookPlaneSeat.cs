/* Write a menu driven program for seat booking management system using 2D array (5x5): 
    Booking Options:
    1. view the seats
    2. Books the seat(provide row and column)
    3. cancel the seat
    4. check the availability of a particular seat. 
    5. exit
    let 0 be the available seat and 1 be the occupied seat in the matrix. */

using System;
abstract class bookPlaneSeatMenu {
    protected int[,] seats = new int[5, 5];
    public abstract void ViewSeats();
    public abstract void BookSeat();
    public abstract void CancelSeat();
    public abstract void CheckAvailability();
}

class SeatBookingSystem : bookPlaneSeatMenu {
    public override void ViewSeats() {
        Console.WriteLine("\nSeat Layout (0 = Available, 1 = Occupied):");
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Console.Write(seats[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public override void BookSeat() {
        Console.Write("Enter row (0-4): ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter column (0-4): ");
        int col = int.Parse(Console.ReadLine());

        if (row < 0 || row >= 5 || col < 0 || col >= 5) {
            Console.WriteLine("Invalid seat position!");
        }
        else if (seats[row, col] == 1) {
            Console.WriteLine("Seat already booked!");
        }
        else {
            seats[row, col] = 1;
            Console.WriteLine("Seat booked successfully!");
        }
    }

    public override void CancelSeat() {
        Console.Write("Enter row (0-4): ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter column (0-4): ");
        int col = int.Parse(Console.ReadLine());

        if (row < 0 || row >= 5 || col < 0 || col >= 5) {
            Console.WriteLine("Invalid seat position!");
        }
        else if (seats[row, col] == 0) {
            Console.WriteLine("Seat is already available!");
        }
        else {
            seats[row, col] = 0;
            Console.WriteLine("Seat booking cancelled!");
        }
    }

    public override void CheckAvailability() {
        Console.Write("Enter row (0-4): ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter column (0-4): ");
        int col = int.Parse(Console.ReadLine());

        if (row < 0 || row >= 5 || col < 0 || col >= 5) {
            Console.WriteLine("Invalid seat position!");
        }
        else if (seats[row, col] == 0) {
            Console.WriteLine("Seat is available.");
        }
        else {
            Console.WriteLine("Seat is occupied.");
        }
    }

    static void Main() {
        SeatBookingSystem system = new SeatBookingSystem();
        int choice;
        do {
            Console.WriteLine("\nSeat Booking Management System");
            Console.WriteLine("1. View the seats");
            Console.WriteLine("2. Book a seat");
            Console.WriteLine("3. Cancel a seat");
            Console.WriteLine("4. Check availability");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    system.ViewSeats();
                    break;
                case 2:
                    system.BookSeat();
                    break;
                case 3:
                    system.CancelSeat();
                    break;
                case 4:
                    system.CheckAvailability();
                    break;
                case 5:
                    Console.WriteLine("Exiting the system...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 5);
    }
}