using System;
using System.Collections;
using System.Collections.Generic;
namespace Anagrams.Objects
{
  public class AnaWord
  {
    //properties
    private string _userInput1;
    private string _userInput2;
    private string _errorReport;
    private List<string> _input2Strings = new List<string> {};

    // Setters
    public void SetBothUserInputs (string userInput1, string userInput2)
    {
      _userInput1 = userInput1;
      _userInput2 = userInput2;
      _errorReport = "";

    }
    public void SetUserInput1(string userInput1)
    {
      _userInput1 = userInput1;
    }
    public void SetUserInput2(string userInput2)
    {
      _userInput2 = userInput2;
    }
    //Getters
    public string GetUserInput1()
    {
      return _userInput1;
    }
    public string GetUserInput2()
    {
      return _userInput2;
    }
    public List<string> GetInput2Strings()
    {
      return _input2Strings;
    }
    //Checkers
    public bool CheckAnagrams()
    {
      char[] arrayInput1 = _userInput1.ToCharArray();
      char[] arrayInput2 = _userInput2.ToCharArray();
      Array.Sort(arrayInput1);
      Array.Sort(arrayInput2);
      bool returnValue = true;
      if (arrayInput1.Length <= 1 || arrayInput2.Length <= 1)
      {
        returnValue = false;
        _errorReport = "Inputs must be at least two characters long";
      }
      if (arrayInput1.Length != arrayInput2.Length)
      {
        returnValue = false;
      }
      for (int i = 1; i <= arrayInput1.Length; i++)
      {
        if (arrayInput1[i-1] != arrayInput2[i-1])
        {
         returnValue = false;
        }
      }
      return returnValue;
    }
    public void Input2ToStringList()
    {
      Char[] arrayInput2 = _userInput2.ToCharArray();
      int j = 1;
      for (int i = 1 ; i <= arrayInput2.Length; i++ )
      {
        string check1 = string.Join("", arrayInput2[i-1]);
        if (check1 == ",")
        {
          string tempString = "";
          while ( j < i )
          {
            tempString = tempString + string.Join("", arrayInput2[j-1]);
            j++;
          }
          _input2Strings.Add(tempString);
        }
      }
    }
  }
}
