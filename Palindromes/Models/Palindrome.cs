using System;
using System.Linq;

namespace Palindromes
{
  public class PalindromeTester
  {
    public bool IsPalindrome(string strToTest)
    {
      string lowerCaseStr = strToTest.ToLower();
      char[] stringInChars = lowerCaseStr.ToCharArray();
      Array.Reverse(stringInChars);
      return stringInChars.SequenceEqual(lowerCaseStr.ToCharArray());
    }
  }
}