using System.Numerics;
using Xunit;

namespace Collatz.Tests
{
	public sealed class BigIntegerSequenceGeneratorTests
	{
		[Fact]
		public void Create()
		{
			var start = new BigInteger(12);
			var generator = new BigIntegerSequenceGenerator();
			var sequence = generator.Generate(start);

			Assert.Equal(new BigInteger[] { 12, 6, 3, 10, 5, 16, 8, 4, 2, 1 }, sequence);
		}

		//Assert.Equal(new BigInteger[] { 12, 6, 3, 5, 8, 4, 2, 1 }, sequence);

		// The original sequence I grabbed 
		// (from https://en.wikipedia.org/wiki/Collatz_conjecture)
		// was this:

		[Fact]
		public void CreateWithValueLessThan1()
		{
			var start = BigInteger.Zero;
			var generator = new BigIntegerSequenceGenerator();
			Assert.Throws<InvalidValueException<BigInteger>>(() => generator.Generate(start));
		}
	}
}
