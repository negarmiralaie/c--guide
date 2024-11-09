// * https://www.codewars.com/kata/5467e4d82edf8bbf40000155/train/csharp
// ^ Descending Order

using System;
using System.Linq;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    // & approach1
    // string newArr = "";
    // string stringNum = Convert.ToString(num);
    // while (stringNum.Length > 0) {
    //   for (int i = 0; i < stringNum.Length; i++) {
    //     var max = stringNum[0];
    //     for (int j = 0; j < stringNum.Length; j++) {
    //       if (stringNum[j] > max && !(newArr.Contains(max))) {
    //         max = stringNum[j];
    //       }
    //     }
    //     newArr += max;
    //     int maxIndex = stringNum.IndexOf(max);
    //     stringNum = stringNum.Remove(maxIndex, 1);
    //   }
    // }
    // return Convert.ToInt32(newArr);

    // & approach2
    // return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));

    // & approach3
    //  char[] descending = num.ToString().OrderByDescending(x => x).ToArray();
    // return int.Parse(new string(descending));
  }
}
