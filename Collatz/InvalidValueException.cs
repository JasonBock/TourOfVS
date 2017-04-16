using System;
using System.Numerics;
#if !NETCOREAPP1_1
using System.Runtime.Serialization;
#endif

namespace Collatz
{
#if !NETCOREAPP1_1
	[Serializable]
#endif
	public sealed class InvalidValueException<T>
		: Exception
		where T : struct
	{
		public InvalidValueException()
		{
		}

		public InvalidValueException(T value)
		{
			this.Value = value;
		}

		public InvalidValueException(string message) : base(message)
		{
		}

		public InvalidValueException(string message, Exception innerException) : base(message, innerException)
		{
		}

#if !NETCOREAPP1_1
		private InvalidValueException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
#endif

		public T Value { get; }
	}
}