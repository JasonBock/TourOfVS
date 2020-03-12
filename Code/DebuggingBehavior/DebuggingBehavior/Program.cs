using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DebuggingBehavior
{
	public static class Program
	{
		static void Main()
		{
			var tasks = new List<Task>();
			var values = new int[Environment.ProcessorCount];
			Array.Fill(values, 3);

			for (var i = 0; i < Environment.ProcessorCount; i++)
			{
				tasks.Add(Task.Run(() => Console.Out.WriteLine($"{i} - {values[i]}")));
			}

			Task.WaitAll(tasks.ToArray());
		}
	}
}
