using System;
using System.Linq;
using Sphinx.Models;

namespace Sphinx
{
 public class Program
 {
  public static void Main()
  {
    Random rnd = new Random();
    int i = rnd.Next(13);
    Console.WriteLine("=======================");
    Console.WriteLine("Welcome to Sphinx World");
    Console.WriteLine(Riddle.riddles.ElementAt(i).Value);
    Console.WriteLine("What is your answer?");
    string answer = Console.ReadLine();
    if (answer.ToLower() == Riddle.riddles.ElementAt(i).Key.ToLower())
    {
      Console.WriteLine("You are corret!")
      Main();
    }
    else
    {
      Console.WriteLine("Game Over!");
    }
  }
 } 
}