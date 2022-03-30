
using System;

namespace Lab6OOP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Zoo animal = new Zoo(8, 5, 1);
            Animals Kangaroo = new Animals(9, 5, 1, 2);
            Animals Lion = new Animals(10, 5, 1, 2);
            Animals Cat = new Animals(11, 5, 1, 2);
            Animals Bear = new Animals(12, 5, 1, 2);
            Birds Parrot = new Birds();
            Birds Woodpecker = new Birds();
            Birds Eagle = new Birds();
            Reptiles Crocodile = new Reptiles();
            Reptiles Snake = new Reptiles();
            Reptiles turtles = new Reptiles();
            //p.DoSomeThingVirtual();
            //c.DoSomeThingVirtual();
            //sc.DoSomeThingVirtual();
            
            //// The magic begins here ...  (the logic)
            //Parent parentTypeChildInstance = new Child(8, 7, 4, 5);
            //parentTypeChildInstance.DoSomeThingVirtual();
            DoSomething(animal, "animal","debend on type",0);
            DoSomething(Kangaroo, "Kangaroo", "plants and vegetables",7);
            DoSomething(Parrot, "Parrot", "fresh vegetables, fruit and pellets or seeds",12);
            DoSomething(Crocodile, "Crocodile", "insects, fish, small frogs, lizards, crustaceans and small mammals",17);

        }

        static void DoSomething(Zoo P,string name,string eat, int sleep )
        {
            P.DoSomeThingVirtual();
            P.DoSomeThingNormal(name);
            P.eat(eat);
            P.sleep(sleep);
            Console.WriteLine();
        }
    }


    class Zoo                                // Parent - Super - Base class                       
    {
        protected int ProtectedVarInParent;     // can only be accessed from the same class or children classes  
        public int PublicVarInParent;           // can be accessed from anywhere
        private int PrivateVarInParent;         // can be accessed only from inside the class

        public Zoo(int PrivateVarInParent)
        {
            this.PrivateVarInParent = PrivateVarInParent;
        }

        public Zoo(int ProtectedVarInParent, int PublicVarInParent, int PrivateVarInParent)
        {
            this.ProtectedVarInParent = ProtectedVarInParent;
            this.PublicVarInParent = PublicVarInParent;
            this.PrivateVarInParent = PrivateVarInParent;
        }

        public virtual void DoSomeThingVirtual()
        {
            Console.WriteLine("This was done by the Zoo virtual function");
        }

        public void DoSomeThingNormal(string anm)
        {
            Console.WriteLine($"This was {anm} in my  Zoo ");
        }
        public void eat(string anm)
        {
            Console.WriteLine($"This was eat of {anm} ");
        }
        public void sleep(int anm)
        {
            Console.WriteLine($"This animals was sleep : {anm} Hr ");
        }


    }

    class Animals : Zoo                        // Child inherits Parent - Child - Sub - Derived          
    {
        private int PrivateVarInChild;

        // As we don't have a parameterless constructor in parent, then we *Have To* call the construcor with parameters 
        public Animals(int ProtectedVarInParent, int PublicVarInParent, int PrivateVarInParent, int PrivateVarInChild) : base(ProtectedVarInParent, PublicVarInParent, PrivateVarInParent)
        {
            this.PrivateVarInChild = PrivateVarInChild;
        }

        public Animals(int PrivateVarInParent, int PrivateVarInChild) : base(PrivateVarInParent)
        {
            this.PrivateVarInChild = PrivateVarInChild;
        }

        public override void DoSomeThingVirtual()
        {
            Console.WriteLine("This was done by the child class");
        }

        public new void DoSomeThingNormal()
        {
            Console.WriteLine("This was done by the child function");
        }

        public void ThisIsOnlyInFirstChild()
        {
            Console.WriteLine("This is the child's own function");
        }
        
    }

    class Birds : Zoo
    {
        public Birds() : base(5)
        {

        }

        public override void DoSomeThingVirtual()
        {
            Console.WriteLine("This was done by the Birds class");
        }
       

    }
    class Reptiles : Zoo
    {
        public Reptiles() : base(5)
        {

        }

        public override void DoSomeThingVirtual()
        {
            Console.WriteLine("This was done by the Reptiles class");
        }

    }

}




//using System;

//namespace Lab6OOP
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            Zoo animals = new Zoo("crocodais", "any");

//        }
//    }

//    class Zoo
//    {
//        public string MyProperty { get; set; }
//        public string MyValue;
//        public string MyValue2;
//        string[] content;

//        public void Eat()
//        {
//            string allData = MyValue + "value1" + MyValue2 + "value2";
//            Console.WriteLine(allData);

//        }

//        public Zoo(string myvalue, string myvalue2, string[] content)
//        {

//           this.MyValue = myvalue;
//            this.MyValue2 = myvalue2;
//            this.content = content;
//        }



//    }
//    class animals : Zoo
//    {
//        string foot;
//        string foot2;
//        public animals() : base()

//        {

//           this.foot = "test";
//            this.foot2 = "test";


//        }
//    }
//}
