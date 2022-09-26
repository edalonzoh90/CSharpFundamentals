# Object Oriented Programming Concepts

### Principles
- ***Abstraction*** Modeling the relevant attributes and interactions of entities as classes to define an abstract representation of a system.  
- ***Encapsulation*** Hiding the internal state and functionality of an object and only allowing access through a public set of functions.  
- ***Inheritance*** Ability to create new abstractions based on existing abstractions.  
- ***Polymorphism*** Ability to implement inherited properties or methods in different ways across multiple abstractions.  

### Key Concepts
- ***Override*** Modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
- ***Overload*** Is the common way of implementing polymorphism. It is the ability to redefine a function in more than one form 
- ***ReadOnly*** Indicates that assignment to the field can only occur as part of the declaration or in a constructor in the same class.
- ***Constructor chaining*** Constructor Chaining is an approach where a constructor calls another constructor in the same or base class.
- ***Sealed Class*** Prevents other classes from inheriting from it. 
- ***Abstact Class*** It serves as a template that defines the members that each derived class must implement.
- ***Interface*** Contains definitions for a group of related functionalities that a non-abstract class or a struct must implement.

### Access Level
- ***Private*** members are visible only in derived classes that are nested in their base class. 
- ***Protected*** members are visible only in derived classes.
- ***Internal*** members are visible only in derived classes that are located in the same assembly as the base class
- ***Public*** members are visible in derived classes and are part of the derived class public interface.

[Documentation](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/tutorials/classes)
