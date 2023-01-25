namespace kata_dotnet_core_start.Lib;

public class TicTacToe
{
    private static Dictionary<int, string> Board { get; } = new Dictionary<int, string>();
    
    public static Dictionary<int, string> GetInitialBoard()
    {
        for (var i = 0; i < 9; i++)
        {
            Board.Add(i+1, (i + 1).ToString());
        }
        
        return Board;
    }
    
    public static void PrintBoard()
    {
        var arr = GetInitialBoard();
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
}