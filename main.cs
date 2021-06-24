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
    Console.WriteLine ("\n");

    int x = 567;
    int y = 0;
    Console.WriteLine ($"Your x value is {x} and your y value is {y}");

    try 
    {
      if (y == 0) throw new ArgumentOutOfRangeException("y cannot equal zero");
    }
    
    catch (ArgumentOutOfRangeException e) 
    {      
      Console.Write($"Enter your y value: {y = 6} \n");
      //if you want user input add: y = Int32.Parse(Console.ReadLine());
      Console.WriteLine(e);      
    }
    finally
    {
      Console.WriteLine($"\n The score is {Divide (x,y)}.\n");
    }
    

  }
}