using System;
using System.Collections.Generic;

namespace WeekdayFinder.Objects
{
  public class Finder
  {
    private string _dayOfTheWeek;
    private string _userInput;
    private List<string> _weekDays = new List<string> {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
    private int _epochDate = 2001;
    private string[] _parsedInput;
    private Dictionary<int, int> _months = new Dictionary<int, int>
    {
      {1, 0},
      {2, 31},
      {3, 59},
      {4, 90},
      {5, 120},
      {6, 151},
      {7, 181},
      {8, 212},
      {9, 243},
      {10, 273},
      {11, 304},
      {12, 334}
    };

    public Finder(string UserInput)
    {
      _userInput = UserInput;
    }

    public List<int> ParsedInput()
    {
      _parsedInput = _userInput.Split('/');
      List<int> intList = new List<int> ();
      for(int i = 0; i < _parsedInput.Length; i++)
      {
        intList.Add(int.Parse(_parsedInput[i]));
      }
      return intList;
    }

    public int DateConverter()
    {
        List<int> intList = ParsedInput();
        int yearCount = (intList[2] - _epochDate) * 365;
        int dayCount = intList[1];
        int monthCount = _months[intList[0]];

        int total = yearCount + dayCount + monthCount;
        int number = total % 7;
        Console.WriteLine(number);
        return number;
    }
  }
}
