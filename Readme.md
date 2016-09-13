## Specs

Description | Input | Output
---|:---:|:---:
User can input two words | |
The user enters to letters that are the same returns true |input1: t input2: t | false
If the user enter a number, returns false | input1: 3 | "You must enter a word"
If the user inputs a non-anagram set of words, it returns false | input1: fun input2: fan | false
If the user inputs the same word twice, it returns true | input1: Racecar input2: Racecar | true
The user correct enters an Anagram, it returns true| input1: beard input2: bread| true
All letters in entered words become lower case | input1: beard input2: bread| true
The user enters several words seperated by a comma and the input tests against each word.

Take a set of words in a string  "THis, is, a, Set, of, words"
Turn into an array.
For (int i=1; i > string.length; i++ )
  {
   if (array[i-1] == ",")
   {
     for (int j = 1; j > i; j++ )
     {

     }
   }
  }
