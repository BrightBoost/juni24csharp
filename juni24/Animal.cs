using System;
namespace juni24
{
	public abstract class Animal
	{
		public string Color { get; set; }

		public Animal() : this("doorzichtig")
		{
			Console.WriteLine("in constr animal no args");
		}

		public Animal(string color)
        {
			Color = color;
            Console.WriteLine("in constr animal color");

        }

        public virtual void Breathe()
		{
			Console.WriteLine("adem in, adem uit");
		}

		public abstract void Eat();
	}
}

