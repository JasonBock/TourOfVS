using System.Collections.Generic;

namespace Collatz
{
	public sealed class Int32SequenceGenerator
		: ISequenceGenerator<int>
	{
		public int[] Generate(int value)
		{
			if(value < 1)
			{
				throw new InvalidValueException<int>(value);
			}

			var sequence = new List<int>();

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
