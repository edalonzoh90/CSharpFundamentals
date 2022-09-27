# C# Fundamentals
### Object Oriented Programming Principles
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
- ***Virtual*** Is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class

### Access Level
- ***Private*** members are visible only in derived classes that are nested in their base class. 
- ***Protected*** members are visible only in derived classes.
- ***Internal*** members are visible only in derived classes that are located in the same assembly as the base class
- ***Public*** members are visible in derived classes and are part of the derived class public interface.

### C# Basic Concepts
- ***Static constructors*** Initialize the static data of a class.
- ***Instance constructors***  Create a new instance of the class
- ***Finalizer*** Are called by the runtime's garbage collector to destroy instances of a class.
- ***Generic Types*** Classes, structs, and records can be defined with one or more type parameters. 
- ***Static Types*** A static class can contain only static members and can't be instantiated with the new keyword. One copy of the class is loaded into memory when the program loads, and its members are accessed through the class name. 
- ***Nested Types*** A class, struct, or record can be nested within another class, struct, or record.
- ***Partial Types*** You can define part of a class, struct, or method in one code file and another part in a separate code file.
- ***Anonymous Types*** Anonymous types are defined by their named data members.
- ***Extension Methods*** You can "extend" a class without creating a derived class by creating a separate type. That type contains methods that can be called as if they belonged to the original type.
- ***Implicitly Typed Local Variables*** Use implicit typing to instruct the compiler to determine a variable's type at compile time. 
- ***Struct type*** is a value type that can encapsulate data and related functionality. Typically, you use structure types to design small data-centric types that provide little or no behavior.
- ***Enum*** Is a value type defined by a set of named constants of the underlying integral numeric type. 

[Documentation](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/tutorials/classes)
