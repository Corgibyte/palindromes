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

    public bool IsPalindromeHard(string strToTest)
    {
      string lowerCaseStr = strToTest.ToLower();
      char[] stringInChars = lowerCaseStr.ToCharArray();
      int endIndex = stringInChars.Length - 1;
      bool isPalindrome = true;
      for (int begIndex = 0; begIndex <= endIndex && isPalindrome; begIndex++)
      {
        isPalindrome = stringInChars[begIndex] == stringInChars[endIndex];
        endIndex -= 1;
      }
      return isPalindrome;
    }
  }
}