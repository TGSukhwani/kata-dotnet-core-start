namespace kata_dotnet_core_start.Lib;

public class TicTacToe
{
    public TicTacToe()
    {
        for (var i = 0; i < 9; i++)
        {
            Board.Add(i+1, (i + 1).ToString());
        }
    }
    
    public Dictionary<int, string> Board { get; } = new Dictionary<int, string>();

    public void PrintBoard()
    {
        var arr = Board;
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
        Console.WriteLine("     |     |      ");
    }

    public string Move(int position, string player)
    {
        if (GameOver(out var gameOver)) return gameOver;

        if(Board[position] != position.ToString())
            return "a player can take a field if not already taken";
        
        Board[position] = player;
        
        return "Next Turn";
    }

    private bool GameOver(out string gameOver)
    {
        var fields = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        gameOver = string.Empty;
        
        var isGameOver = Board.Values.Any(x => fields.Contains(Convert.ToInt32(x)));

        if (!isGameOver) return false;
        
        gameOver = "Game Over!!";
        return true;
    }
}