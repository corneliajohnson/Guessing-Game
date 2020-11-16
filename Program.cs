using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Guess a number a number: ");
      string userGuess = Console.ReadLine();
      Console.WriteLine($"User guess is {userGuess}");
    }
  }
}
