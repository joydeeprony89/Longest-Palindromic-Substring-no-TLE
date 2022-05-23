using System;

namespace Longest_Palindromic_Substring
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "cbbd";
      Solution s = new Solution();
      var result = s.LongestPalindrome(str);
      Console.WriteLine(result);
    }
  }

  public class Solution
  {
    public string LongestPalindrome(string s)
    {
      string longest = string.Empty;
      for (int i = 0; i < s.Length; i++)
      {
        //odd length
        string odd = Helper(s, i, i);
        //even length
        string even = Helper(s, i, i + 1);
        string currentlongest = odd.Length > even.Length ? odd : even;
        longest = currentlongest.Length > longest.Length ? currentlongest : longest;
      }

      return longest;
    }

    private string Helper(string s, int i, int j)
    {
      bool isPalindrome = false;
      while (i >= 0 && j < s.Length && s[i] == s[j])
      {
        if (!isPalindrome) isPalindrome = true;
        i--; j++;
      }
      if (!isPalindrome) return "";
      int length = j - i - 1;
      return s.Substring(i+1, length);
    }
  }
}
