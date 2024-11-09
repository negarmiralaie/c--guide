// * https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/csharp
// ^ Vowel Count

using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
      // & approach1
      // int vowelCount = 0;
      // char[] vowelsArr = new char[] { 'a', 'e', 'o', 'i', 'u' };
      // foreach (var item in str.ToLower()) {
      //   if (Array.IndexOf(vowelsArr, item) > -1) {
      //     vowelCount++;
      //   }
      // }

      // return vowelCount;

      // & approach2
      // int vowelCount = 0;
      // string vowels = "aeiou";
      
      // foreach (char letter in str)
      // {
      //   if (vowels.IndexOf(letter) != -1)
      //     vowelCount++;
      // }

      // return vowelCount;

      // & approach3
      // char[] vowels = new[] {'a', 'e', 'i', 'o', 'u' };

      // return str
      //   .ToCharArray()
      //   .Where(c => vowels.Contains(c))
      //   .Count();
    }
}
