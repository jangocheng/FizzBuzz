using System;


namespace FizzBuzz
{
  /// <summary>
  ///  FizzRunner
  /// </summary>
  public class FizzRunner 
  {

    /// <summary>
    ///  The amount of rounds you want to run the Fizz Buzz.
    /// </summary>
    public int rounds;
    public string[] results;

    /// <summary>
    ///  Constructor for the FizzRunner
    /// </summary>
    /// <param name="_rounds">Takes the number of rounds you want the FizzRunner to use</param>
    public FizzRunner(int _rounds) {
      rounds = _rounds;
      results = Generate();
    }

    /// <summary>
    ///  The function which generates the Fizz Buzz
    /// </summary>
    private string[] Generate() {
      var fizzResults = new string[rounds + 1];
      for (int i = 1; i <= rounds; i++) {
        if (i % 15 == 0) {
          fizzResults[i] = "fizzBuzz";
        }

        if (i  % 5 == 0) {
          fizzResults[i] = "buzz"; 
        }

        if (i % 3 == 0) {
          fizzResults[i] = "fizz";
        }
      }
      return fizzResults;
    }

    public void PrintAll () {
      for (int i = 1; i <= rounds; i++) {
        Console.WriteLine(i + " " + results[i]);
      }
    }
  }
}
