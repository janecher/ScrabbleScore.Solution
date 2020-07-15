using System;
using ScrabbleScore;

class Program
{
  static void Main()
  {
    Console.WriteLine("Input the word: ");
    string word = Console.ReadLine().Trim();
    Console.WriteLine("Scrabble word score: ");
    Console.WriteLine(Score.CountScrabbleScore(word));
    Main();
  }
}