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
    
    
    [Fact]
    public void When_X_Played_Then_Turn_Goes_To_O()
    {
        //Arrange
        var game = new TicTacToe();
        game.Move(2, "X");
        
        //Act
        var result = game.Move(1, "O");
        
        //Assert
        Assert.NotNull(game.Board);
        Assert.Equal( "X", game.Board[2]);
        Assert.Equal( "O", game.Board[1]);
        Assert.Equal("Next Turn", result);
    }
    
    [Fact]
    public void When_AllFieldsTaken_Then_GameOver()
    {
        //Arrange
        var game = new TicTacToe();
        game.Move(1, "X");
        game.Move(2, "O");
        game.Move(3, "X");
        game.Move(4, "O");
        game.Move(5, "X");
        game.Move(6, "O");
        game.Move(7, "X");
        game.Move(8, "O");

        //Act
        var result = game.Move(9, "X");
        
        //Assert
        Assert.NotNull(game.Board);
        Assert.Equal("Game Over!!", result);
    }
    
    [Fact]
    public void When_PlayerTakesRow_Then_PlayerWins()
    {
        //Arrange
        var game = new TicTacToe();
        game.Move(1, "X");
        game.Move(4, "O");
        game.Move(2, "X");
        game.Move(5, "O");

        //Act
        var result = game.Move(3, "X");
        
        //Assert
        Assert.NotNull(game.Board);
        Assert.Equal("Player X Wins!!", result);
    }
}