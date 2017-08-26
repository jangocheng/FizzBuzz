using System;
using FizzBuzz;

namespace cli
{
  /// <summary>
  ///  This class is only used to start the init the FizzRunner and run it.
  /// </summary>
  class Program 
  {
    static void Main(string[] args)
    {
      FizzRunner fz = new FizzRunner(100);
      fz.PrintAll();
    }
  }
}
