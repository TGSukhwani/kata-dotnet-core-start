namespace kata_dotnet_core_start.Lib;

public class TicTacToe
{
    public static Dictionary<int, string> board { get; set; } = new Dictionary<int, string>();
    
    public static Dictionary<int, string> GetInitialBoard()
    {
        for (var i = 0; i < 9; i++)
        {
            board.Add(i+1,"");
        }
        
        return board;
    }
}