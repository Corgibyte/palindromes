using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTesterTests
  {
    [TestMethod]
    public void IsPalindrome_StringIsPalindrome_True()
    {
      PalindromeTester tester = new();
      Assert.AreEqual(true, tester.IsPalindrome("hannah"));
    }

    [TestMethod]
    public void IsPalindrome_StringIsPalindromeMixedCase_True()
    {
      PalindromeTester tester = new();
      Assert.AreEqual(true, tester.IsPalindrome("HannAh"));
    }

    [TestMethod]
    public void IsPalindrome_StringIsNotPalindrome_True()
    {
      PalindromeTester tester = new();
      Assert.AreEqual(false, tester.IsPalindrome("testing"));
    }

    [TestMethod]
    public void IsPalindromeHard_StringIsPalindrome_True()
    {
      PalindromeTester tester = new();
      Assert.AreEqual(true, tester.IsPalindromeHard("hannah"));
    }

    [TestMethod]
    public void IsPalindromeHard_StringIsPalindromeMixedCase_True()
    {
      PalindromeTester tester = new();
      Assert.AreEqual(true, tester.IsPalindromeHard("HannAh"));
    }

    [TestMethod]
    public void IsPalindromeHard_StringIsNotPalindrome_True()
    {
      PalindromeTester tester = new();
      Assert.AreEqual(false, tester.IsPalindromeHard("testing"));
    }
  }
}