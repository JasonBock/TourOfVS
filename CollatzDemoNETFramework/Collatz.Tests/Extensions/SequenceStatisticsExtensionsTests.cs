using Collatz.Extensions;
using System;
using System.Numerics;
using Xunit;

namespace Collatz.Tests.Extensions
{
	public sealed class SequenceStatisticsExtensionsTests
	{
		[Fact]
		public void Create()
		{
			var start = new BigInteger(12);
			var generator = new SequenceGenerator();
			var statistics = generator.Generate(start).GetStatistics();
			Assert.Equal(5, statistics.Even);
			Assert.Equal(3, statistics.Odd);
			Assert.Equal(12, statistics.Maximum);
		}

		[Fact]
		public void CreateWithNullSequence()
		{
			Assert.Throws<ArgumentNullException>(() => (null as BigInteger[]).GetStatistics());
		}
	}
}