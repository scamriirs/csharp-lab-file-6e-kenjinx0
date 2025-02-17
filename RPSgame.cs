/* write a program to implement Rock, Paper, and Scissors played between two players
    1 - Rock
    2 - Paper
    3 - Scissors
    any other character - exit */

using System;
class RPSgame {
    private Random random = new Random();
    public void Start() {
        Console.Write("Do you want to play with another person or computer? (1 - Person, 2 - Computer): ");
        string mode = Console.ReadLine();

        if (mode != "1" && mode != "2") {
            Console.Write("Invalid mode. Exiting game.");
            return;
        }

        bool isComputer = mode == "2";
        while (true) {
            Console.Write("Player 1: Enter your choice (1 - Rock, 2 - Paper, 3 - Scissors): ");
            string player1Input = Console.ReadLine();

            if (!IsValidChoice(player1Input)) {
                Console.Write("Invalid input. Exiting game.");
                break;
            }

            int player1Choice = int.Parse(player1Input);
            int player2Choice;

            if (isComputer) {
                player2Choice = random.Next(1, 4);
                Console.WriteLine($"Computer chose: {player2Choice}");
            }
            else {
                Console.Write("Player 2: Enter your choice (1 - Rock, 2 - Paper, 3 - Scissors): ");
                string player2Input = Console.ReadLine();

                if (!IsValidChoice(player2Input)) {
                    Console.Write("Invalid input. Exiting game.");
                    break;
                }
                player2Choice = int.Parse(player2Input);
            }

            string result = DetermineWinner(player1Choice, player2Choice);
            Console.WriteLine(result);
        }
    }

    private bool IsValidChoice(string input) {
        return input == "1" || input == "2" || input == "3";
    }

    private string DetermineWinner(int choice1, int choice2) {
        if (choice1 == choice2)
            return "It's a draw!";

        if ((choice1 == 1 && choice2 == 3) || (choice1 == 2 && choice2 == 1) || (choice1 == 3 && choice2 == 2))
            return "Player 1 wins!";
        else
            return "Player 2 wins!";
    }
}

class RockPaperScissors {
    static void Main()
    {
        RPSgame choice = new RPSgame();
        choice.Start();
    }
}
