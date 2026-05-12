using System; 

namespace OurCompany.LearningCoding.OOP.Static;
public class StaticApp
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Player Count: {Player.PlayerCount}");
        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");
        Player player3 = new Player("Player 3");
        Player player4 = new Player("Player 4");
        Player player5 = new Player("Player 5");
        Console.WriteLine($"Player Count: {Player.PlayerCount}");
    }
}


public class Player
{
    private static int _playerCount;
    public static int PlayerCount
    {
        get
        {
            return _playerCount;
        }
    }

    public string? Name {get; set;}

    public Player(string? name)
    {
        Name = name;
        _playerCount++;
    }

    static Player()
    {
        _playerCount = 0;
    }
}