namespace juni24;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Dog d = new Dog(true, "waf");
        d.Name = "Vicky";
        Dog d1 = new Dog("Max", 1);
        d1.Bark();

        string name = "blabla";
        // object initializer syntax
        Dog d2 = new Dog(false, "woof")
        {
            Name = name
        };

        List<Animal> animals = new List<Animal>();
        //animals.Add(new Animal("blauw"));
        animals.Add(new Dog("maria", 9));

        // dit geeft een invalid cast exception als het niet kan, alternatief: gebruik as
        //Dog d3 = (Dog) animals[0];

        // as, cast alleen als het kan, anders null
        Dog d3 = animals[0] as Dog;
        if(d3 != null)
        {
            d3.Bark();
        }
        else
        {
            Console.WriteLine("dat is geen Dog!");
        }

        IPredator ip = new Dog("nacho", 2);
        (ip as Dog)?.Bark();

        Bag<Laptop> laptopBag = new Bag<Laptop>(new Laptop("Acer"));
        Console.WriteLine(laptopBag.Content.Model);
        Bag<Chihuahua> chihuahuaBag = new Bag<Chihuahua>(new Chihuahua());
        chihuahuaBag.Content.Bark();

    }
}

