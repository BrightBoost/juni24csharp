using System;
namespace juni24
{
	public class Dog : Animal, IPredator
	{
		// implicitly static
		public const int defaultNrLegs = 3;
		
		// fields
		private int age;
		private string _name = "";
		private bool isGoodBoy = true;
		private readonly string sound;
		// properties
		public string Name {
			get
			{
				return _name;
			}
			set
			{
				Console.WriteLine("I'm here!");
				if(value != "")
				{
					_name = value;
				} 
			}
		}
		
		public Dog(bool isGoodBoy, string sound) : this("Bobbie", 2)
		{
			this.isGoodBoy = isGoodBoy;
			this.sound = sound;
            Console.WriteLine("in constr dog isGB, sound");

        }

        public Dog(string name, int age) 
		{
			this.age = age;
			Name = name;
            Console.WriteLine("in constr dog name, age");

        }

        // methods
        public void Bark()
		{
			Console.WriteLine("Woof woof");
        }

        public override void Breathe()
        {
            Console.WriteLine("dog adem in, adem uit");
        }

		public override void Eat()
		{
			Console.WriteLine("dog eating");
		}

		public void CatchPrey()
		{
            Console.WriteLine("catching rabbit");
        }

        public static void DogInfo()
		{
			Console.WriteLine("insert wiki about dog");
		}
		
	}
}

