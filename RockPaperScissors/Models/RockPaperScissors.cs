namespace RockPaperScissors
{
  public class Player
  {


    public string Play { get; set; }
    public string Name { get; set; }

    public Player(string name)
    {
      Play = "rock";
      Name = name;
    }
    
    public string Outcome(string playerTwoPlay)
    {
      string playerOnePlay = Play;
      
      //compare them - branching
      return "Tied";
    }

    public static string Outcome(string playerOnePlay, string playerTwoPlay)
    {
      //compare them - branching
      return "Tied";
    }

    // Player.Outcome()
  }
}
// Options for public string Play: "rock", "paper", "scissors"
// Instance of Player = public Player()