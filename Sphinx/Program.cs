using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Sphinx
{
 public class Program
 {
  public static void Main()
  {
    Console.WriteLine("Welcome to Sphinx World");
    Console.WriteLine(riddles.ElementAt(0).Value);
    Console.WriteLine("What is your answer?");
    string answer = Console.ReadLine();
    if (answer == riddles.ElementAt(0).Key)
    {
      Console.WriteLine("You are correct!");
    }
    else
    {
      Main();
    }
  }
 } 
}