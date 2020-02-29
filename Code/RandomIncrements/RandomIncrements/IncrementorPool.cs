using System;
using System.Collections.Immutable;

namespace RandomIncrements
{
	public sealed class IncrementorPool
	{
		private readonly ImmutableArray<Incrementor> pool;

		public IncrementorPool(uint size)
		{
			this.Size = size;

			var poolBuilder = ImmutableArray.CreateBuilder<Incrementor>();

			for (var i = 0; i < this.Size; i++)
			{
				poolBuilder.Add(new Incrementor());
			}

			this.pool = poolBuilder.ToImmutable();
		}

		public uint Size { get; }

		public Incrementor GetIncrementor() =>
			this.pool[new Random().Next(this.pool.Length)];
	}
}