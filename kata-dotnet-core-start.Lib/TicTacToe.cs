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
        if(Board[position] != position.ToString())
            return "a player can take a field if not already taken";
        
        Board[position] = player;
        
        if(CheckPlayerWins(player)) 
            return $"Player {player} Wins!!" ;
        
        return GameOver() ? "Game Over!!" : "Next Turn";
    }

    private bool GameOver()
    {
        var fields = new List<string>() { "X", "O" };
        return Board.Values.All(value => fields.Contains(value));
    }
    
    private bool CheckPlayerWins(string player)
    {
        var rows = new Dictionary<int, List<int>>()
        {
            { 1, new List<int>() {1,2,3}}
        };

        var isWins = true;
        foreach (var i in rows[1])
        {
            if (Board[i] != player)
            {
                isWins = false;
                break;
            }
        }

        return isWins;
        
        // foreach (var row in rows)
        // {
        //     foreach (var i in row.Value)
        //     {
        //         if(Board[i] != player)
        //             break;
        //     }
        // }
    }
}