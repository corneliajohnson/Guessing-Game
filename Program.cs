using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      AskUser();
    }

    static void AskUser()
    {
      int sercetNumber = RandomNumber();
      int tries = 0;
      //set difficulty.
      int difficultyLevel = Difficulty();
      while (tries < difficultyLevel)
      {
        tries++;
        Console.Write($"Guess a number a number (Your guess {tries}): ");
        string userGuess = Console.ReadLine();
        CheckGuess(sercetNumber, userGuess);
      }
    }

    static void CheckGuess(int secrectNum, string userNum)
    {
      int userNumInt = int.Parse(userNum);
      if (userNumInt == secrectNum)
      {
        Console.WriteLine("You Guessed RIGHT");
        Environment.Exit(-1);
      }
      else
      {
        if (userNumInt > secrectNum)
        {
          Console.WriteLine("WRONG: You guessed too high");
        }
        else
        {
          Console.WriteLine("WRONG: You guessed too low");
        }
      }
    }

    static int RandomNumber()
    {
      Random randomNum = new Random();
      int generateRandomNum = randomNum.Next(1, 100);
      return generateRandomNum;
    }

    static int Difficulty()
    {
      Console.WriteLine(@"
             Difficulty Level
             Enter 1, 2 or 3
             1) Easy - this gives the user eight guesses
             2) Medium - this gives the user six guesses
             3) Hard - this gives the user four guesses
        ");
      string level = Console.ReadLine();
      switch (level)
      {
        case "1": return 8;
        case "2": return 6;
        case "3": return 4;
        default: return 8;
      }
    }
  }
}
