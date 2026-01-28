using System;

class Driver
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // Create the game board (9 positions)
        string[] board = new string[9];

        // Initialize board with numbers 1–9
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = (i + 1).ToString();
        }

        string currentPlayer = "X";
        bool gameWon = false;

        // Game loop
        while (!gameWon)
        {
            // Ask player for move
            Console.WriteLine($"Player {currentPlayer}, choose a position (1-9):");
            int choice = int.Parse(Console.ReadLine()) - 1;

            // Update board
            board[choice] = currentPlayer;

            // Print board (supporting class)
            BoardHelper.PrintBoard(board);

            // Check for winner (supporting class)
            gameWon = BoardHelper.CheckWinner(board);

            // Switch players
            currentPlayer = (currentPlayer == "X") ? "O" : "X";
        }

        Console.WriteLine("Game over!");
    }
}
