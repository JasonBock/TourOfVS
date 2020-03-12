using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CodeSnippetsAndINotifyPropertyChanged
{
	public class Customer
		: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private uint age;

		private Guid identifier;
		private string name;

		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		public uint Age
		{
			get => this.age;
			set
			{
				if (value != this.age)
				{
					this.age = value;
					this.NotifyPropertyChanged();
				}
			}
		}

		public Guid Identifier
		{
			get => this.identifier;
			set
			{
				if (value != this.identifier)
				{
					this.identifier = value;
					this.NotifyPropertyChanged();
				}
			}
		}

		public string Name
		{
			get => this.name;
			set
			{
				if (value != this.name)
				{
					this.name = value;
					this.NotifyPropertyChanged();
				}
			}
		}
	}
}