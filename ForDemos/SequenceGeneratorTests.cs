using System.Numerics;
using Xunit;

namespace Collatz.Tests
{
	public sealed class SequenceGeneratorTests
	{
		[Fact]
		public void Create()
		{
			var start = new BigInteger(12);
			var generator = new SequenceGenerator();
			var sequence = generator.Generate(start);

			// The original sequence I grabbed 
			// (from https://en.wikipedia.org/wiki/Collatz_conjecture)
			// was this:
			Assert.Equal(new BigInteger[] { 12, 6, 3, 10, 5, 16, 8, 4, 2, 1 }, sequence);
			//Assert.Equal(new BigInteger[] { 12, 6, 3, 5, 8, 4, 2, 1 }, sequence);
		}

		[Fact]
		public void CreateWithValueLessThan1()
		{
			var start = BigInteger.Zero;
			var generator = new SequenceGenerator();
			Assert.Throws<InvalidValueException<BigInteger>>(() => generator.Generate(start));
		}
	}
}
