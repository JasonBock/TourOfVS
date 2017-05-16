using System.Numerics;

namespace Collatz
{
	public interface ISequenceGenerator
	{
		BigInteger[] Generate(BigInteger value);
	}
}