using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void CountScrabbleScore_CountScoreForInputWord_IntegerNumber()
    {
      string word = "queen";
      Assert.AreEqual(14, Score.CountScrabbleScore(word));
    }
  }
}