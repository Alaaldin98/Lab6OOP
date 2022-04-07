# Lab6OOP - OOP Principles
### Description
This is a console application made to simulate a zoo in order to showcase the principles of OOP.
#### Getting Started
Clone this repository to your local machine.

#### To run the program from Visual Studio:
Select File -> Open -> Project/Solution

Next navigate to the location you cloned the Repository.

Double click on the Lab06-OOPPrinciples directory.

Then select and open Lab06-OOPPrinciples.sln

#### Visuals
UML


### OOP Principles
##### Inheritance
- Expresses a Parent/Child relationship between two classes wherein one class can inherit the methods and properties of another. In this code, inheritance is shown by the Concrete animal classes applying properties from their parent classes as well as using methods defined in the parent classes.
##### Abstraction
- The act of taking a real world example and breaking it down into fundamental parts or abstracting it to a more basic form. In the code, this is shown by the concrete examples of animals like giraffes being abstracted to herbivores, which is further abstracted to mammals, and even further to animals.
##### Encapsulation
- Encapsulation is the act of "wrapping" data up so that it can only be accessed in specific, predefined ways and it's actual data holds integrity. In the code, we only use public because we needed to write XUnit tests for all the methods, but private methods should be applied only on the concrete level, protected methods would exist in the parents of the concrete animals and internal methods could exist anywhere in the application.
##### Polymorphism
- Polymorphism is the ability for certain inherited traits to be changed or overridden by deriving classes. In our code, polymorphism is shown in the method sleep which is overridden and changed several times in different levels of inheritance.