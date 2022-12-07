using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeSieveTests
  {
    [TestMethod]
    public void PrimeSieveConstructor_CreatesInstanceOfPrimeSieve_PrimeSieve()
    {
      PrimeSieve newPrimeSieve = new PrimeSieve(1);
      Assert.AreEqual(typeof(PrimeSieve), newPrimeSieve.GetType());
    }

    [TestMethod]
    public void GetInput_ReturnsUserInput_Integer()
    {
      int userInput = 10;
      PrimeSieve newPrimeSieve = new PrimeSieve(userInput);
      Assert.AreEqual(userInput, newPrimeSieve.UserInput);
    }

  }
}