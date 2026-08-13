\# Module 02 — Object-Oriented Programming in C#



\## Progress



Module 2 has been completed through both theoretical learning and practical exercises.



The module focused on understanding how C# uses classes, objects, interfaces, inheritance, polymorphism, encapsulation, SOLID principles, and exception handling to structure applications.



Each practical task was created as a separate console application so that the code from each exercise remains available for reference.



\# Task 2.1 — Classes \& Objects



\## Goal



Understand how classes and objects are used to represent real-world entities in C#.



\## Concepts Covered



\### Class



A class is a blueprint that defines the data and behavior of an object.



\### Object



An object is an actual instance created from a class.



\### Constructor



A constructor is used to initialize an object when it is created.



\### Properties



Properties provide a controlled way to read and modify data belonging to an object.



Example:

public string AccountHolder { get; set; }



\### Auto-Properties



Auto-properties allow us to define properties without manually creating a backing field.



\### Access Modifiers



Access modifiers control where a class member can be accessed.



Common examples:





public

private

protected

internal



\### `get` and `set`



`get` is used to read a property value.



`set` is used to change a property value.



Example:

public string AccountHolder { get; set; }



\### Private Setter



A property can allow other code to read a value while allowing only the class itself to change it.



Example:



public decimal Balance { get; private set; }





This helps protect the internal state of the object.



\## Practical Exercise — BankAccount



Created a `BankAccount` class with:





AccountNumber

AccountHolder

Balance



Implemented:





Deposit()

Withdraw()

DisplayAccountDetails()





The application validates the balance before allowing withdrawals.



Example:





Initial Balance : ₹10000



Deposit ₹5000

&#x20;       ↓

Balance : ₹15000



Withdraw ₹3000

&#x20;       ↓

Balance : ₹12000



Withdraw ₹20000

&#x20;       ↓

Withdrawal rejected



\## Project





Task01-Classes/

└── BankAccount/

&#x20;   ├── BankAccount.csproj

&#x20;   └── Program.cs



\# Task 2.2 — Inheritance \& Polymorphism



\## Goal



Understand how different classes can follow the same interface and provide their own implementations.



\## Concepts Covered



\### Interface



An interface defines a contract that a class must implement.



Example:





interface IShape

{

&#x20;   string Name { get; }



&#x20;   double CalculateArea();



&#x20;   double CalculatePerimeter();

}



\### Inheritance



Inheritance allows a class to derive behavior or structure from another class or type.



\### Polymorphism



Polymorphism allows different objects to be handled through a common type while each object provides its own behavior.



In this task:





IShape

&#x20; │

&#x20; ├── Circle

&#x20; ├── Rectangle

&#x20; └── Triangle



Each shape implements:





CalculateArea()

CalculatePerimeter()





\## Practical Exercise — Shape Calculator



Created:

Circle

Rectangle

Triangle

All three implement:

IShape





The shapes are stored in:

List<IShape>



and processed using:



foreach (IShape shape in shapes)

{

&#x20;   Console.WriteLine(shape.CalculateArea());

&#x20;   Console.WriteLine(shape.CalculatePerimeter());

}





The same method calls produce different results depending on the actual shape object.



This demonstrates polymorphism in practice.



\## Project





Task02-Polymorphism/

└── Shapes/

&#x20;   ├── Shapes.csproj

&#x20;   └── Program.cs



\# Task 2.3 — Encapsulation \& SOLID Basics



\## Goal



Understand how encapsulation protects object data and how SOLID principles help make code easier to extend and maintain.



\## Encapsulation



Encapsulation means keeping an object's internal data controlled and allowing it to be changed through defined operations.



For example:





public double Radius { get; }





and validation inside the constructor prevents invalid values from being assigned.



\## Single Responsibility Principle



The Single Responsibility Principle means a class should have one main responsibility.



Keeping responsibilities separated makes the code easier to understand and maintain.



\## Open/Closed Principle



The Open/Closed Principle means existing code should be open for extension but closed for modification.



In simple terms:



> We should be able to add new functionality without unnecessarily changing existing working code.



\## Practical Exercise — Add Pentagon



The Task 2.2 shape system was extended by adding:





Pentagon



without modifying the existing:





Circle

Rectangle

Triangle





classes.



The new class implements the existing interface:





class Pentagon : IShape





The processing code remains unchanged:





foreach (IShape shape in shapes)

{

&#x20;   

}





The final structure is:





IShape

&#x20; │

&#x20; ├── Circle

&#x20; ├── Rectangle

&#x20; ├── Triangle

&#x20; └── Pentagon





This demonstrates the Open/Closed Principle through a practical example.



\## Project





Task03-SOLID/

└── ShapesSolid/

&#x20;   ├── ShapesSolid.csproj

&#x20;   └── Program.cs





\# Task 2.4 — Exception Handling



\## Goal



Understand how C# handles errors and unexpected situations during program execution.



\## Concepts Covered



\### `try`



Contains code that may produce an exception.





try

{

&#x20;   account.Withdraw(15000);

}





\### `catch`



Handles an exception when one occurs.





catch (InsufficientFundsException ex)

{

&#x20;   Console.WriteLine(ex.Message);

}





\### `finally`



Runs after the `try`/`catch` operation.





finally

{

&#x20;   Console.WriteLine("Operation completed.");

}





\### Custom Exception



A custom exception is an exception class created for a specific application scenario.



Example:





class InsufficientFundsException : Exception

{

}





\### `throw`



`throw` is used to create and raise an exception.



Example:





throw new InsufficientFundsException(

&#x20;   "Insufficient funds."

);





\### `using` and `IDisposable`



`using` helps manage objects that need cleanup.



A class implementing `IDisposable` provides a `Dispose()` method for releasing resources.



\## Practical Exercise — BankAccount Exception Handling



The BankAccount concept was extended with exception handling.



The application handles:





Successful withdrawal

Insufficient funds

Invalid deposit amount

Disposable resource



Example:





Balance : ₹7000



Withdraw ₹15000

&#x20;       ↓

InsufficientFundsException

&#x20;       ↓

catch

&#x20;       ↓

Display error message





The program also demonstrates:





try

catch

finally

throw

custom exception

using

IDisposable





\## Project





Task04-Exceptions/

└── BankAccountExceptions/

&#x20;   ├── BankAccountExceptions.csproj

&#x20;   └── Program.cs









\# Module 2 Practical Structure



The completed module contains four separate practical projects:





Module02-OOP/

│

├── README.md

│

├── Task01-Classes/

│   └── BankAccount/

│       ├── BankAccount.csproj

│       └── Program.cs

│

├── Task02-Polymorphism/

│   └── Shapes/

│       ├── Shapes.csproj

│       └── Program.cs

│

├── Task03-SOLID/

│   └── ShapesSolid/

│       ├── ShapesSolid.csproj

│       └── Program.cs

│

└── Task04-Exceptions/

&#x20;   └── BankAccountExceptions/

&#x20;       ├── BankAccountExceptions.csproj

&#x20;       └── Program.cs









\# Module 2 Execution Flow



The concepts covered in this module connect together:





Class

&#x20; ↓

Object

&#x20; ↓

Constructor

&#x20; ↓

Properties

&#x20; ↓

Encapsulation

&#x20; ↓

Interface

&#x20; ↓

Inheritance

&#x20; ↓

Polymorphism

&#x20; ↓

SOLID Principles

&#x20; ↓

Exception Handling









\# Practical Learning Outcome



After completing this module, I can understand and work with:



\* Classes and objects

\* Constructors

\* Properties

\* `get` and `set`

\* Access modifiers

\* Encapsulation

\* Interfaces

\* Inheritance

\* Polymorphism

\* `List<T>` with interfaces

\* Basic SOLID principles

\* Single Responsibility Principle

\* Open/Closed Principle

\* `try`

\* `catch`

\* `finally`

\* `throw`

\* Custom exceptions

\* `IDisposable`

\* `using`



The main goal was not just to memorize OOP syntax, but to understand why these concepts are used and how they help structure real C# applications.









