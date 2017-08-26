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
    /// <summary>
    /// The actual results
    /// </summary>
    public string[] results;

    /// <summary>
    ///  Constructor for the FizzRunner
    /// </summary>
    /// <param name="_rounds">Takes the number of rounds you want the FizzRunner to use</param>
    public FizzRunner(int _rounds) {
      // Set the rounds
      rounds = _rounds;
      // Set the results by generating them
      results = Generate();
    }

    /// <summary>
    ///  The function which generates the Fizz Buzz
    /// </summary>
    /// <returns>Returns an array of results</returns>
    private string[] Generate() {
      string[] fizzResults = new string[rounds + 1];

      for (int i = 1; i <= rounds; i++) {
        string result =
          i % 15 == 0 ? "FizzBuzz" :
          i % 5  == 0 ? "Buzz" :
          i % 3  == 0 ? "Fizz" :
          null;

          fizzResults[i] = result;
      }
      return fizzResults;
    }

    /// <summary>
    ///  Print all results
    /// </summary>
    public void PrintAll () {
      for (int i = 1; i <= rounds; i++) {
        Console.WriteLine(i + " " + results[i]);
      }
    }
  }
}
