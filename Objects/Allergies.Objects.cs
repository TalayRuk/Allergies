using System;
using System.Collections.Generic;

namespace CoreAllergies.Objects
{
  public class Allergies
  {
    private int _score;
    private List<string> allergyList = new List<string> {};

    //Setters
    public Allergies (int score)
    {
      _score = score;
    }
    //Getters
    public int GetScore()
    {
      return _score;
    }
    public List<string> GetAllergyList()
    {
      return allergyList;
    }

    public void AllergyCalculater()
    {
      int value = _score;
      if (value >= 128 )
      {
        value = value - 128;
        allergyList.Add("Cats");
      }
      if ( value >= 64 )
      {
        value = value - 64;
        allergyList.Add("Pollen");
      }
      if ( value >= 32 )
      {
        value = value - 32;
        allergyList.Add("chocolate");
      }
      if ( value >= 16 )
      {
        value = value - 16;
        allergyList.Add("tomatoes");
      }
      if ( value >= 8 )
      {
        value = value - 8;
        allergyList.Add("strawberries");
      }
      if ( value >= 4 )
      {
        value = value - 4;
        allergyList.Add("shellfish");
      }
      if ( value >= 2 )
      {
        value = value - 2;
        allergyList.Add("Peanuts");
      }
      if ( value >= 1 )
      {
        allergyList.Add("eggs");
      }
    }
  }
}
