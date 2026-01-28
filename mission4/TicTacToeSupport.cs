namespace mission4;

public class TicTacToeSupport
{
    public void PrintBoard(string[] board)
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]}");
    }
    /* Rows
       0, 1, 2
       3, 4, 5
       6, 7, 8
       Columns
       0, 3, 6
       1, 4, 7
       2, 5, 8
       Diagonals
       0, 4, 8
       2, 4, 6 */
    public string CheckWinner(string[] board)
    {
        // Rows
        if (board[0] == board[1] && board[1] == board[2]) return board[0];
        if (board[3] == board[4] && board[4] == board[5]) return board[3];
        if (board[6] == board[7] && board[7] == board[8]) return board[6];

        // Columns
        if (board[0] == board[3] && board[3] == board[6]) return board[0];
        if (board[1] == board[4] && board[4] == board[7]) return board[1];
        if (board[2] == board[5] && board[5] == board[8]) return board[2];

        // Diagonals
        if (board[0] == board[4] && board[4] == board[8]) return board[0];
        if (board[2] == board[4] && board[4] == board[6]) return board[2];
        
        //GameBoard full
        if (IsBoardFull(board))
        {
            return "Draw";
        }

        return ""; // no winner yet
    }
    private bool IsBoardFull(string[] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i] != "X" && board[i] != "O")
            {
                return false; // still a number → empty
            }
        }
        return true;
    }
    
    
    
    
}

