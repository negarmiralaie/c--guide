// * https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9/train/csharp
// ^ Shortest Word

using System;
using System.Linq;
public class Kata
{
  public static int FindShort(string s)
  {
    // & approach1
    // var arr = s.Split(" ");
    // var maxLength = s.Length;
    // foreach(var item in arr) {
    //   if (item.Length < maxLength) {
    //     maxLength = item.Length;
    //   }
    // }
    // return maxLength;

    // & approach2
    // return s.Split(' ').Min(x => x.Length);
  }
}
