using System;

namespace RandomIncrements
{
	public static class Program
	{
		static void Main()
		{
			var pool = new IncrementorPool(10);

			for(var i = 0; i < 5 * pool.Size; i++)
			{
				var incrementor = pool.GetIncrementor();
				Console.Out.WriteLine(incrementor.Value);
			}
		}
	}
}