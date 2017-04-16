namespace Collatz
{
	public interface ISequenceGenerator<T>
	{
		T[] Generate(T value);
	}
}