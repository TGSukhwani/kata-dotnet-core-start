using System.Runtime.CompilerServices;

namespace kata_dotnet_core_start.Lib.Tests;

public class TicTacToeTests
{
    [Fact] 
    public void InitialBoard()
    {
        //Arrange
        
        //Act
        var result = TicTacToe.GetInitialBoard();

        //Assert
        Assert.NotNull(result);
        Assert.Equal(9,result.Count);
    }
}