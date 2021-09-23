using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeShift.Models;
using System;
using System.Collections.Generic;

namespace PrimeShift.Tests
{
  [TestClass]
  public class PrimeNumTests
  {
  // [TestMethod]
  //   public void PrimeNum_ReturnsPrimeNumber_True()
  // {
  // PrimeNum testPrime = new PrimeNum();
  // Assert.AreEqual(true, testPrime.Prime(2));
  // }
  [TestMethod]
  public void Prime_ReturnsNumberList_List()
  {
    PrimeNum testPrime = new PrimeNum();
    List<int> newList = new List<int> {1,2};
    List<int> result = testPrime.Prime(2);
    CollectionAssert.AreEqual(newList, result);
  }
  }
}
