using System.Collections.Generic;

namespace ScrabbleScore
{
  public class Score
  {
    private static List<char> _onePointLettersArray = new List<char>{'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
    private static List<char> _threePointLettersArray = new List<char>{'B', 'C', 'M', 'P'};
    private static List<char> _fourPointLettersArray = new List<char>{'F', 'H', 'V', 'W', 'Y'};

    public static int CountScrabbleScore(string word)
    {
      string wordUpperCase = word.ToUpper();
      int score = 0;
      for(int i=0; i<wordUpperCase.Length; i++)
      {
        if(_onePointLettersArray.Contains(wordUpperCase[i]))
        {
          score ++;
        } 
        else if (wordUpperCase[i] == 'D' || wordUpperCase[i] == 'G')
        {
          score +=2;
        }
        else if(_threePointLettersArray.Contains(wordUpperCase[i]))
        {
          score +=3;
        }
        else if(_fourPointLettersArray.Contains(wordUpperCase[i]))
        {
          score +=4;
        }
        else if (wordUpperCase[i] == 'K')
        {
          score +=5;
        }
        else if (wordUpperCase[i] == 'J' || wordUpperCase[i] == 'X')
        {
          score +=8;
        }
        else if (wordUpperCase[i] == 'Q' || wordUpperCase[i] == 'Z')
        {
          score +=10;
        }
        else
        {
          score += 0;
        }
      }
      return score;
    }
  }
}