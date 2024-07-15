namespace Number05;

using System;

class RockPaperScissorsGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to a Game of Rock-Paper-Scissors!");
        
        Console.Write("Player 1, enter your choice (Rock, Paper, or Scissors): ");
        string player1 = Console.ReadLine();
        
        Console.Write("Player 2, enter your choice (Rock, Paper, or Scissors): ");
        string player2 = Console.ReadLine();
        
        string result = PlayRockPaperScissors(player1, player2);
        
        Console.WriteLine(result);
    }

    static string PlayRockPaperScissors(string player1, string player2)
    {
        player1 = player1.ToLower();
        player2 = player2.ToLower();
        
        if (player1 == player2)
        {
            return "It's a tie!";
        }
        
        if ((player1 == "rock" && player2 == "scissors") ||
            (player1 == "scissors" && player2 == "paper") ||
            (player1 == "paper" && player2 == "rock"))
        {
            return "Player 1 wins!";
        }
        else
        {
            return "Player 2 wins!";
        }
    }
}
