using System;
using System.Numerics;

namespace Collatz
{
	internal class InvalidValueException : Exception
	{
		private BigInteger value;

		public InvalidValueException()
		{
		}

		public InvalidValueException(BigInteger value)
		{
			this.value = value;
		}

		public InvalidValueException(string message) : base(message)
		{
		}

		public InvalidValueException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}