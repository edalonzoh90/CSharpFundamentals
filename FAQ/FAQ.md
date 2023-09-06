# POO 
**1. Differences between Override and Overload**  
- Method overloading is the process of defining multiple methods with the same name but with different parameters and/or return types.
- Method overriding is the process of defining a method in a subclass that has the same name, return type, and parameters as a method in its parent class.

# .NET/ .NET Core  
**1. Differences between .NET and .NET Core**  
- Cross-platform compatibility  
- Open-source
- Size and performance

# C#  

# MicroServices  
**1. What is the difference between micro-service and monolithic design?** <sub><sup><sub><sup>[NTD Software]</sup></sub></sup></sub>  
Monolithic design is an approach where an entire application is built as a single, self-contained unit. All components of the application are tightly coupled and interdependent, and the
application is deployed as a single unit.  
In Microservices approach, the application breaks down into smaller, independent services that communicate with each other over a network. Each service is responsible for a specific task or function, and can be developed, deployed, and scaled independently of other services.

**Monolithic design**  
**Advantages:**  
Simple to develop and deploy.  
Easier to test and debug.  
Tightly coupled components can lead to high performance.  
**Disadvantages:**  
Difficult to scale and maintain as the application grows.  
Any changes require the entire application to be redeployed.  
Can become monolithic and difficult to manage as the application grows.  

**Microservices design**  
**Advantages:**  
Highly scalable and resilient.  
Can be developed and deployed independently.  
Allows for greater flexibility in technology choices.  
Better fault isolation and recovery.  
**Disadvantages:**  
Introduces additional complexity, such as the need for service discovery and network  
communication.
More difficult to test and debug across distributed systems.
Requires more expertise in distributed systems and DevOps practices.

# Cloud  
**1. How does cloud infrastructure work?** <sub><sup><sub><sup>[NTD Software]</sup></sub></sup></sub>  
Cloud infrastructure refers to the collection of hardware and software resources used to deliver cloud computing services, such as computing power, storage, and networking capabilities, over the internet.

# Event-Driven architecture  
**1. What is event-driven architecture?** <sub><sup><sub><sup>[NTD Software]</sup></sub></sup></sub>  
It’s a programming paradigm that focuses on responding to events or messages in the system,
rather than executing instructions sequentially.

# Rest API  
**1. Describe the driving principles of the REST API structure** <sub><sup><sub><sup>[NTD Software]</sup></sub></sup></sub>  
- Client-Server architecture: RESTful APIs follow a client-server architecture where the client and server are separate, independent components.  
- Stateless: Each request to the server contains all the information necessary to complete that request. The server does not store any client state between requests.  
- Uniform interface: RESTful APIs have a uniform interface that standardizes how clients and servers interact with each other.  
- Resource-oriented: RESTful APIs are resource-oriented, meaning that resources are identified by a unique URI. Resources can be manipulated through the standard HTTP verbs.  
- Self-descriptive messages: RESTful APIs use self-descriptive messages, meaning that each message includes all the information necessary to understand how to process it.

# Clean code  
**1. Describe what clean coding means to you** <sub><sup><sub><sup>[NTD Software]</sup></sub></sup></sub>  
Write code that is easy to read, understand, and maintain. Not only functional but also readable, efficient, and elegant.

# Dependency Injection  
**1. Describe what Dependency Injection means** <sub><sup><sub><sup>[NTD Software]</sup></sub></sup></sub>  
Is a pattern that allows for loose coupling between classes and their dependencies. Dependency Injection involves injecting dependencies into a class rather than creating them within the class. This allows the class to be more flexible and reusable, as it can work with different dependencies without needing to be modified.

# Testing  
**1. Types of testing**
- Unit Test - Test a class without external dependencies
- Integration test - Test a class with external dependencies
- End to End - Drives and app through UI

  
