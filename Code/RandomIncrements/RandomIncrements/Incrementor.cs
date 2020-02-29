namespace RandomIncrements
{
	public sealed class Incrementor
	{
		private int value;

		public int Value => this.value++;
	}
}