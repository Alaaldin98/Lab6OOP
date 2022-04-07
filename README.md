# Lab: 06 - I built a Zoo!
# Lab: 07 - Interfaces
This is a console application made to simulate a zoo in order to showcase the principles of OOP.
#### Getting Started
Clone this repository to your local machine.

#### To run the program from Visual Studio:
Select File -> Open -> Project/Solution

Next navigate to the location you cloned the Repository.

Double click on the Lab06-OOPPrinciples directory.

Then select and open Lab06-OOPPrinciples.sln

#### Visuals
###### UML
![Screenshot (44)](https://user-images.githubusercontent.com/98964675/162163170-80c1c4da-236f-4d4d-a1e3-db930c0dca79.png)

### OOP Principles
##### Inheritance
- Expresses a Parent/Child relationship between two classes wherein one class can inherit the methods and properties of another. In this code, inheritance is shown by the Concrete animal classes applying properties from their parent classes as well as using methods defined in the parent classes.
##### Abstraction
- The act of taking a real world example and breaking it down into fundamental parts or abstracting it to a more basic form. In the code, this is shown by the concrete examples of animals like giraffes being abstracted to herbivores, which is further abstracted to mammals, and even further to animals.
##### Encapsulation
- Encapsulation is the act of "wrapping" data up so that it can only be accessed in specific, predefined ways and it's actual data holds integrity. In the code, we only use public because we needed to write XUnit tests for all the methods, but private methods should be applied only on the concrete level, protected methods would exist in the parents of the concrete animals and internal methods could exist anywhere in the application.
##### Polymorphism
- Polymorphism is the ability for certain inherited traits to be changed or overridden by deriving classes. In our code, polymorphism is shown in the method sleep which is overridden and changed several times in different levels of inheritance.

### Interfaces
*An interface is a reusable group of related class methods and properties which can be added to any class.*

The interfaces implemented here are IHunt and IFly:
- IHunt's purpose is to group properties and methods that simulates carnivores hunting prey. It includes a prey property to define the animals that are prey for that class, a SmellForPrey method for finding that prey, and a CatchPrey method for chasing down that prey.
- IHunt is included in the Tiger, Polar Bear, Owl, Eagle, and Snake classes. All of these classes represent carnivores. Most bears are not carnivores, but the polar bear is. So IHunt is added to the PolarBear class, rather than the bear class.
- IFly's purpose is to group properties and methods that simulate an animal's ability to fly using its wings. It includes a TopFlySpeed property to quantify how fast an animal can fly at its fastest. It also includes the TakeOff method for starting flight, which is intended to return the animal's speed after takeoff, and the Land method for landing, which is intended to return whether the creature successfully lands.
- IFly is part of the Owl and Eagle classes, because we expect that all the sub-categories of animals within those categories can fly. Most birds can fly but not all, so IFly is not included in the Bird class.

#### Tests
![Screenshot (45)](https://user-images.githubusercontent.com/98964675/162166480-d99408c6-8bae-4078-8652-0b028a2f54b9.png)
