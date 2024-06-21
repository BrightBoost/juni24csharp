using System;
namespace juni24
{
	public class Bag<T> //where T : Dog
	{
		public T Content { get; set; }
		public Bag(T content)
		{
			Content = content;
		}
	}
}

