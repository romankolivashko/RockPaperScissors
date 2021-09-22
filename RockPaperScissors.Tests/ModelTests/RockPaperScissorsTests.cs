using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class PlayerTests
  {
    [TestMethod]
    public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
    {
      Player newPlayer = new Player("bob");
      Assert.AreEqual(typeof(Player), newPlayer.GetType());
    }

    [TestMethod]
    public void RockPaperScissors_ReturnUserName_Player()
    {
      //Arrange
      string userInputName = "Bob";
      //Act
      Player bob = new Player(userInputName);

      //Assert
      Assert.AreEqual(userInputName, bob.Name);
    }

    [TestMethod]
    public void Outcome_ReturnsOutcome_Tied()
    {
      //Arrange
      Player playerOne = new Player("bob");
      Player playerTwo = new Player("jill");
      //Act
      string result = Player.Outcome(playerOne.Play, playerTwo.Play);
      //Assert
      Assert.AreEqual("Tied", result);
    }

  }
}

// namespace PrimeSifter.Models
// {
//   public class Numbers
//   {
//     public int InputNumber {get; set;}
//     public Numbers(int inputNumber)
//     {
//       InputNumber = inputNumber;
//       GetPrimes = new List<int> ();
//     }
//   }
// }

// namespace PrimeSifter.Tests
// {
//   [TestClass]
//   public class NumbersTests
//   {
//     [TestMethod]
//     public void NumbersConstructor_ReturnSingleNumber_Numbers()
//     {
//     //Arrange
//     int testNumber = 5;

//     //Act
//     Numbers newNumber = new Numbers(testNumber);
//     //Assert
//     Assert.AreEqual(newNumber.InputNumber, testNumber);
//     }