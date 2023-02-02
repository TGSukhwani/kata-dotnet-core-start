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

    private static readonly Dictionary<int, List<int>> rows = new()
    {
        { 1, new List<int>() {1,2,3}},
        { 2, new List<int>() {4,5,6}},
        { 3, new List<int>() {7,8,9}}
    };

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
        return PlayerHasRow(player, 1) || PlayerHasRow(player, 2) || PlayerHasRow(player, 3);
    }

    private bool PlayerHasRow(string player, int rowNumber)
    {
        return rows[rowNumber].All(i => Board[i] == player);
    }
}