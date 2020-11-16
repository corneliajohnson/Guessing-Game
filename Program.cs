using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      int sercetNumber = 42;
      Console.Write("Guess a number a number: ");
      string userGuess = Console.ReadLine();
      CheckGuess(sercetNumber, userGuess);
    }

    static void CheckGuess(int secrectNum, string userNum)
    {
      int userNumInt = int.Parse(userNum);
      if (userNumInt == secrectNum)
      {
        Console.WriteLine("You Guessed RIGHT");
      }
      else
      {
        Console.WriteLine("WRONG");
      }
    }
  }
}
