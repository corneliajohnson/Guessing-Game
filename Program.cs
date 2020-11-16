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
      //Give the user four chances to guess the number.
      while (tries < 4)
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
  }
}
