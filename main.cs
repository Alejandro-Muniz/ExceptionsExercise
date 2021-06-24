using System;
using System.Collections.Generic;
using System.Linq;

class MainClass 
{
static int Divide (int x, int y)
{
  return x / y;
}

  public static void Main (string[] args) 
  {
    Console.WriteLine ("Hello World");
    
    int x = 567;
    int y = 6;
    
    Console.WriteLine(Divide (x,y));

  }
}