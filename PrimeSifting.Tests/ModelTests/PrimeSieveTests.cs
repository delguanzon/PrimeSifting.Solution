using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;
using System;
using System.Collections.Generic;

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

    [TestMethod]
    public void GetAllNumbers_ReturnsListOfNumbersUpToInput_List()
    {
      int userInput = 10;
      PrimeSieve newPrimeSieve = new PrimeSieve(userInput);
      List<int> expected = new List<int> {2,3,4,5,6,7,8,9,10};
      CollectionAssert.AreEqual(expected, newPrimeSieve.GetAllNumbers());
    }

    [TestMethod]
    public void RemovePrimeMultiples_ReturnsListOfPrimeNumbers_List()
    {
      int userInput = 10;
      PrimeSieve newPrimeSieve = new PrimeSieve(userInput);
      List<int> expected = new List<int> {2,3,5,7};
      CollectionAssert.AreEqual(expected, newPrimeSieve.RemovePrimeMultiples());
    }

  }
}