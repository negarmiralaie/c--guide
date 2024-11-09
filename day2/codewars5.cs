// *https://www.codewars.com/kata/57f609022f4d534f05000024/train/csharp
// ^ Find the stray number

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int FindShort(string s)
  {
    // & approach1
    // for (int i=0; i < numbers.Length-2; i++){
    //   if (numbers[i] != numbers[i+1] && numbers[i] == numbers[i+2]) {
    //     return numbers[i+1]
    //   }
    //   if (numbers[i] != numbers[i+1] && numbers[i] != numbers[i+2]) {
    //     return numbers[i];
    //   }
    //   if (numbers[i] == number[i+1] && numbers[i] != numbers[i+2]) {
    //     return numbers[i+2];
    //   }
      
    // }
    
    // & approach2
    // Array.Sort(numbers);
    // return numbers[0] == numbers[1] ? numbers.Last() : numbers.First();
  }
}

