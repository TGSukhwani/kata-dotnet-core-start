namespace kata_dotnet_core_start.Lib.Tests;

public class TicTacToeTests
{
    [Fact] 
    public void InitializeBoard()
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
    
    [Theory]
    [InlineData(5, "X")]
    [InlineData(9, "O")]
    public void When_X_Moves_Then_X_Takes_The_Field(int position, string player)
    {
        //Arrange
        var game = new TicTacToe();
        
        //Act
        var result = game.Move(position, player);
        
        //Assert
        Assert.NotNull(game.Board);
        Assert.Equal(player, game.Board[position]);
        Assert.Equal("Next Turn", result);
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(9)]
    public void Position_Already_Taken_When_Move_Then_Return_Error(int position)
    {
        //Arrange
        var game = new TicTacToe();
        game.Move(position, "X");
        
        //Act
        var result = game.Move(position, "O");
        
        //Assert
        Assert.NotNull(game.Board);
        Assert.Equal("a player can take a field if not already taken", result);
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