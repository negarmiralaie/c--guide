// * https://www.codewars.com/kata/554b4ac871d6813a03000035/train/csharp
// ^ Highest and Lowest

using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    // & approach1
    // var stringArr = numbers.Split(" ");
    // var max = Convert.ToInt32(stringArr[0]);
    // var min = Convert.ToInt32(stringArr[0]);
    // for (var i = 0; i< stringArr.Length; i++) {
    //   if (Convert.ToInt32(stringArr[i]) < Convert.ToInt32(min)) {
    //     min = Convert.ToInt32(stringArr[i]);
    //   } else if (Convert.ToInt32(stringArr[i]) > Convert.ToInt32(max)) {
    //     max = Convert.ToInt32(stringArr[i]);
    //   }
    // }
    // return Convert.ToString(max) + " " + Convert.ToString(min);

    // & approach2
    // var numsList = numbers.split(" ").Select(int.parse);
    // return $"{nums.Max()} {nums.Min()}"
  }
}


