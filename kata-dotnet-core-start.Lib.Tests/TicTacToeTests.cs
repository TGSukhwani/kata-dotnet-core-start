using System.Runtime.CompilerServices;

namespace kata_dotnet_core_start.Lib.Tests;

public class TicTacToeTests
{
    [Fact] 
    public void Get_InitialBoard()
    {
        //Arrange
        
        //Act
        var result = TicTacToe.GetInitialBoard();

        //Assert
        Assert.NotNull(result);
        Assert.Equal(9,result.Count);
        Assert.False(result.ContainsValue("X"));
        Assert.False(result.ContainsValue("O"));
    }
    
    // [Fact] 
    // public void Get_GameOverMessage_When_All_Fields_are_taken()
    // {
    //     //Arrange
    //     
    //     //Act
    //     var result = TicTacToe.GetInitialBoard();
    //
    //     //Assert
    //     Assert.NotNull(result);
    //     Assert.Equal(9,result.Count);
    //     Assert.Equal(9, result.Count(x => x.Value is "X" or "O"));
    // }
}