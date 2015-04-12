/*
http://www.careercup.com/question?id=5681702473039872

Given an array Of integers build a new array of integers such that every
2nd element of the array is greater than its left rigth element.

eg:
[1, 4, 5, 2, 3]

o/p:
[1, 4, 2, 5, 3]

*/
using System;

class Google1
{
  static void Main()
  {
    int[] array = new int[]{
      1, 4, 5, 2, 3, 6
    };

    int[] result = SecondIsGreaterLeftRight(array);

    PrintResult(result);
  }

static int[] SecondIsGreaterLeftRight(int[] array)
{
  int[] arrayOut = new int[array.Length];
  int rightIndex = (int)(((double)array.Length / (double)2) + 0.5);
  int leftIndex = 0;

  Array.Sort(array);
  bool left = true;
  for (int i = 0; i < array.Length; i++) {
    if (left)
    {
      arrayOut[i] = array[leftIndex];
      leftIndex++;
      left = false;
    }
    else
    {
      arrayOut[i] = array[rightIndex];
      rightIndex++;
      left = true;
    }
  }
  return arrayOut;
}

  static void PrintResult(int[] array)
  {
    for(int y = 0; y < array.Length; y++)
    {
      Console.Write(array[y]);
    }
  }
}
