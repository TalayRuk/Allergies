using System;
using System.Collections.Generic;

using Anagrams.Objects;
using Xunit;

namespace AnagramTests
{
  public class Tests
  {
    [Fact]
    public void CheckAnagrams_DiffereInputsAre_false()
    {
      AnaWord aTest = new AnaWord();
      aTest.SetBothUserInputs("like", "lamp");
      bool testResult = aTest.CheckAnagrams();
      Assert.Equal(false, testResult);
    }
    [Fact]
    public void CheckAnagrams_InputsAreSame_true()
    {
      AnaWord aTest = new AnaWord();
      aTest.SetBothUserInputs("fun", "fun");
      //bool testResult = aTest.CheckAnagrams();
      Assert.Equal( true, aTest.CheckAnagrams() );
    }
    [Fact]
    public void CheckAnagrams_AreTheyEqual_true()
    {
      AnaWord aTest = new AnaWord();
      aTest.SetUserInput1("beard");
      aTest.SetUserInput2("bread");
      Assert.Equal( true, aTest.CheckAnagrams() );
    }
    [Fact]
    public void Input2ToStringList_AreTheyadded_true()
    {
      AnaWord aTest = new AnaWord();
      aTest.SetUserInput2("bread, heard, fun,");
      aTest.Input2ToStringList();
      List<string> result = aTest.GetInput2Strings();
      int resultCount = result.Count;
      System.Console.WriteLine(aTest.GetInput2Strings());
      Assert.Equal(3, resultCount );

    }

  }
}
