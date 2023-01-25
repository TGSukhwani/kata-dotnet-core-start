using System.Runtime.CompilerServices;

namespace kata_dotnet_core_start.Lib.Tests;

public class TicTacToeTests
{
    [Fact] 
    public void Get_InitialBoard()
    {
        //Arrange
        
        //Act
        var result = new TicTacToe();

        //Assert
        Assert.NotNull(result);
        Assert.Equal(9,result.Board.Count);
        Assert.False(result.Board.ContainsValue("X"));
        Assert.False(result.Board.ContainsValue("O"));
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