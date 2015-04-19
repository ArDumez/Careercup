/*
Given 1 byte. Write a function that checks that it have exactly 3 bits which equal to 1.


*/
using System;

class google2
{
  static void Main()
  {
    Console.WriteLine(HasThreeBit(7));
  }

  static bool HasThreeBit(byte value)
  {
    byte compare = 1;
    int nbBit = 0;

    for (int i=0; i < 8; i++) {
      if((value & compare)> 0)
          nbBit++;
      compare <<= 1;
    }
    return nbBit == 3;
  }
}
