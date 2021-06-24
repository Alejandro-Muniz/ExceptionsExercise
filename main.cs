using System;
using System.Collections.Generic;
using System.Linq;

class MainClass 
{
  static int Divide (int x, int y)
  {
    return x / y;
  }

  static int CheckFileExtension(string studentFile)
  {
    if (studentFile.Contains(".cs")) return 1;
    else return 0;
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
    
    //************************************************************************

    int score = 0;
    Dictionary<string, int> studentPoints = new Dictionary<string, int>();
    Dictionary<string, string> studentFiles = new Dictionary<string, string>
    {
      {"Jim", "Program.cs"},
      {"Joe", "accounts.ps1"},
      {"Jef", "homework.cs"},
      {"Jay", "my_file.cpp"},
      {"Jon", "final.bat"},
      {"Joy", "myAssignment.cs"},
      {"Jes", "theFile.com"},
      {"Jen", "jenFile.cs"},
      {"Jeb", "forTurnIn.js"},
      {"Jud", "programOne.cs"}
    };

    foreach (KeyValuePair<string, string> student in studentFiles)
    {
      score = CheckFileExtension(student.Value);
      studentPoints.Add(student.Key, score);
      Console.WriteLine (student);
    }
    Console.WriteLine("\n");
    foreach (KeyValuePair<string, int> student in studentPoints)
    {
      Console.WriteLine(student);
    }
  }
}