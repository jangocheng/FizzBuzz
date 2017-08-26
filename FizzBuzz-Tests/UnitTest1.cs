using FizzBuzz;
using Xunit;

namespace TestApp
{
  public class Tests
  {
    [Fact]
    public void TestFirstItem() {
      var fizz = new FizzRunner(100);
      var third = fizz.results[3];

      Assert.Equal("fizz", third);
    }

    [Fact]
    public void TestFirstThree() {
      var fizz = new FizzRunner(100);

      Assert.Equal(null, fizz.results[1]);
      Assert.Equal(null, fizz.results[2]);
      Assert.Equal("fizz", fizz.results[3]);
    }

    [Fact]
    public void TestLastThree() {
      var fizz = new FizzRunner(100);

      Assert.Equal(null, fizz.results[98]);
      Assert.Equal("fizz", fizz.results[99]);
      Assert.Equal("buzz", fizz.results[100]);
    }
  }
}
