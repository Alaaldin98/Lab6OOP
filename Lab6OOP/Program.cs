using System.Collections;
using System;

namespace Zoo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayList Animals = new ArrayList();

            // Instatiate animals from concrete classes
            PolarBear Branson = new PolarBear("Branson the Polar Bear", "Male");
            BarnOwl Otah = new BarnOwl("Otah the Barn Owl", "Female");
            Tiger Tiaga = new Tiger("Tiaga the Tiger", "Female");
            BaldEagle Glory = new BaldEagle("Glory the Bald Eagle", "Female");
            BoaConstrictor Balthazar = new BoaConstrictor("Balthazar the Boa Constrictor", "Male");

            // Add animals to list
            Animals.Add(Branson);
            Animals.Add(Otah);
            Animals.Add(Tiaga);
            Animals.Add(Glory);
            Animals.Add(Balthazar);

            foreach (Animal animal in Animals) // Have each animal identify itself and then speak
            {
                Console.WriteLine($"{animal.Identity}:");
                animal.Speak();
            }
            Console.ReadKey();

        }
    }


    public abstract class Animal                                // Parent - Super - Base class                       
    {
        public abstract string Identity { get; set; }
        public abstract string Sex { get; set; }
        public virtual string Habitat { get; set; } = "None";
        public virtual string Diet { get; set; } = "Any";
        public virtual bool Nocturnal { get; set; } = false;
        public virtual bool ColdBlooded { get; set; } = false;

        abstract public void Speak();

        virtual public void Rest()
        {
            Console.WriteLine($"{Identity} falls asleep.");
        }

    }
    public abstract class Bear : Mammal
    {

        public virtual void Hibernate()
        {
            Console.WriteLine($"{Identity} settles down to hibernate for the winter.");
        }
    }
    public abstract class Bird : Animal
    {
        virtual public bool CanFly { get; set; } = true;
        abstract public string FeatherPattern { get; set; }

    }
    public class BoaConstrictor : Snake
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore, small and medium-sized mammals";
        public override string Habitat { get; set; } = "Jungle";
        public override string ScalePattern { get; set; } = "Brown, gray, or cream base color with brown or reddish-brown saddle patterns";
        public BoaConstrictor(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }

        public override void Speak()
        {
            Console.WriteLine("HSSSSSSSSSSSSsssss");
        }
        public override void Slither()
        {
            Console.WriteLine($"{Identity} slithers across the ground.");
        }
    }

    public abstract class Cat : Mammal
    {
        public string Prey { get => Diet; }
        virtual public void Pounce(string targetId)
        {
            Console.WriteLine($"{Identity} pounces at {targetId}");
        }
        public bool SmellForPrey()
        {
            return false;
        }
        public bool CatchPrey()
        {
            return false;
        }
    }

    public class EmperorPenguin : Penguin
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore, fish";
        public override string Habitat { get; set; } = "Mountains near bodies of water";
        public override string FeatherPattern { get; set; } = "White head with dark brown body";
        public EmperorPenguin(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }

        public override void Speak()
        {
            Console.WriteLine("MraaAAW");
        }
    }


    public abstract class Mammal : Animal
    {
        public abstract string FurColor { get; set; }
        virtual public void Bite(string target)
        {
            Console.WriteLine($"{Identity} bites {target}");
        }
    }

    public abstract class Owl : Bird
    {
        override public bool Nocturnal { get; set; } = true;
        public string Prey { get => Diet; }
        public bool SmellForPrey()
        {
            return false;
        }
        public bool CatchPrey()
        {
            return false;
        }
        public int TopFlySpeed { get; set; }
        public int TakeOff()
        {
            Console.WriteLine($"{Identity} flaps their wings and takes flight.");
            return TopFlySpeed;
        }
        public bool Land()
        {
            Console.WriteLine($"{Identity} lands.");
            return true;
        }


    }

    public abstract class Penguin : Bird
    {

    }
    public class PolarBear : Bear
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore, medium-sized mammals";
        public override string Habitat { get; set; } = "Arctic";
        public override string FurColor { get; set; } = "White";
        public string Prey { get => Diet; }
        public PolarBear(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }
        public override void Speak()
        {
            Console.WriteLine("RAhr RAhr");
        }

        public bool SmellForPrey()
        {
            return false;
        }
        public bool CatchPrey()
        {
            return false;
        }


    }

    public abstract class Reptile : Animal
    {
        abstract public string ScalePattern { get; set; }
        public override bool ColdBlooded { get; set; } = true;
    }

    public abstract class Snake : Reptile
    {
        public string Prey { get => Diet; }
        public abstract void Slither();
        public bool SmellForPrey()
        {
            return false;
        }
        public bool CatchPrey()
        {
            return false;
        }
    }

    public class Tiger : Cat
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore";
        public override string Habitat { get; set; } = "Jungle";
        public override string FurColor { get; set; } = "Orange and black stripes";
        public Tiger(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }

        public override void Speak()
        {
            Console.WriteLine("Grrr...RAWR!");
        }
    }

    public abstract class Eagle : Bird
    {
        public string Prey { get => Diet; }
        public bool SmellForPrey()
        {
            return false;
        }
        public bool CatchPrey()
        {
            return false;
        }

        public int TopFlySpeed { get; set; }
        public int TakeOff()
        {
            Console.WriteLine($"{Identity} flaps their wings and takes flight.");
            return TopFlySpeed;
        }
        public bool Land()
        {
            Console.WriteLine($"{Identity} lands.");
            return true;
        }
    }
    public class BarnOwl : Owl
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore, small mammals";
        public override string Habitat { get; set; } = "Forest";
        public override string FeatherPattern { get; set; } = "White, heart-shaped face with mottled brown ";
        public BarnOwl(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }

        public override void Speak()
        {
            Console.WriteLine("EEEEEEEK");
        }
    }

    public class BaldEagle : Eagle
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore, fish";
        public override string Habitat { get; set; } = "Mountains near bodies of water";
        public override string FeatherPattern { get; set; } = "White head with dark brown body";
        public BaldEagle(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }

        public override void Speak()
        {
            Console.WriteLine("EEE ee E eeee");
        }
    }
    

}