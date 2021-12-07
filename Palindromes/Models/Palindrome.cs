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


// Code for how Array.Reverse somewhat works
// char[] oldArray
// char[] newArray = new char[oldArray.length]
// int endIndex = oldArray.length - 1
// for (int begIndex = 0; begIndex < newArray.Length -1; begIndex++)
// {
//   newArray[begIndex] = oldArray[endIndex]
//   endIndex -= 1;
// }
// oldArray = newArray;