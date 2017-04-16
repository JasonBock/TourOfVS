using System.Collections.Generic;
using System.Numerics;

namespace Collatz
{
	public sealed class BigIntegerSequenceGenerator 
		: ISequenceGenerator<BigInteger>
	{
		public BigInteger[] Generate(BigInteger value)
		{
			if (value < 1)
			{
				throw new InvalidValueException<BigInteger>(value);
			}

			var sequence = new List<BigInteger>();

			sequence.Add(value);

			while(value != 1)
			{
				value = value % 2 == 0 ? value / 2 :
					(3 * value + 1) / 2;
				sequence.Add(value);
			}

			return sequence.ToArray();
		}
	}
}
