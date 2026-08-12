
# Module 01 — Environment & C# Fundamentals

## Progress

Module 1 has been completed through practical exercises.

The module started with understanding the .NET development environment and how a .NET application is created, built, and executed. It then moved into C# syntax, control flow, methods, value and reference types, nullable types, arrays, and collections.

Each task was implemented as a separate console application so the code from each exercise remains available in the repository.

# Task 1.1 — Environment & Console Application

## Topics Covered

### C#

C# is the programming language used to write applications that run on the .NET platform.

### .NET

.NET is the platform that provides the runtime, libraries, tools, and frameworks needed to build and run applications.

### .NET SDK

The .NET SDK provides the tools required to create, build, test, and publish .NET applications.

### .NET Runtime

The .NET Runtime provides the environment required to run a compiled .NET application.

### ASP.NET Core

ASP.NET Core is the web framework built on .NET. It is used to build Web APIs, web applications, MVC applications, and other web services.

### .NET CLI

The .NET CLI is the command-line tool used to work with .NET projects.

dotnet new
dotnet build
dotnet run
dotnet test
dotnet publish

### `Program.cs`

`Program.cs` contains the application code. In modern .NET console applications, top-level statements can be used instead of writing the traditional `Main()` method manually.

### `.csproj`

The `.csproj` file contains the project configuration. It defines information such as the target framework and build-related settings.

### `bin/`

The `bin` folder contains generated build output such as the `.dll`, `.exe`, `.pdb`, and runtime configuration files.

These are generated files and should normally not be committed to Git.

### `obj/`

The `obj` folder contains intermediate files generated during restore and build operations.

These files are also generated and should normally not be committed to Git.

### `dotnet build`

`dotnet build` restores dependencies when required, compiles the source code, and creates the build output.

### MSBuild

MSBuild is the build system used by .NET. It reads the project configuration from the `.csproj` file and coordinates the build process.

### C# Compiler

The C# compiler converts C# source code into Intermediate Language (IL) and metadata.


C# Code
   ↓
C# Compiler
   ↓
IL + Metadata


### Intermediate Language (IL)

IL is the code produced when C# source code is compiled. It is not native CPU machine code. IL is stored inside the .NET assembly and is converted to native machine code when the application runs.

### .NET Assembly (`.dll`)

A .NET `.dll` is an assembly. It contains compiled IL, metadata, and other information required by the .NET runtime.

### CLR

CLR stands for Common Language Runtime. It is the execution engine inside the .NET Runtime.

The CLR provides services required while the application is running, including:

* Memory management
* Garbage collection
* Exception handling
* Type safety
* JIT compilation
* Runtime execution services

### JIT

JIT stands for Just-In-Time compiler.

The JIT takes IL from the assembly and converts the required code into native machine code while the application is running.


IL
 ↓
JIT
 ↓
Native Machine Code
 ↓
CPU

### Native Machine Code

Native machine code is processor-specific code that the CPU can directly execute.

### Assembly Metadata

Metadata describes information about the types and members contained in an assembly, such as:

* Classes
* Methods
* Properties
* Fields
* Parameters
* Types

### Assembly Manifest

The assembly manifest contains information that identifies the assembly and describes information such as its name, version, and referenced assemblies.

### Reflection

Reflection allows a .NET application to inspect information about assemblies and types while the application is running.



## .NET Execution Pipeline


C# Source Code
      ↓
C# Compiler
      ↓
IL + Metadata
      ↓
.NET Assembly (.dll)
      ↓
.NET Runtime
      ↓
CLR
      ↓
JIT
      ↓
Native Machine Code
      ↓
CPU


## Build Flow

When:
dotnet build
is executed:


.NET CLI
   ↓
MSBuild
   ↓
C# Compiler
   ↓
IL + Metadata
   ↓
.NET Assembly (.dll)


## Run Flow

When:
dotnet run
is executed:
.NET Runtime
      ↓
CLR
      ↓
JIT
      ↓
Native Machine Code
      ↓
CPU


## Project Created

Created the first .NET Console application:

dotnet new console -n HelloDotnet

Project structure:


HelloDotnet/
├── HelloDotnet.csproj
└── Program.cs


The application was successfully built and executed using:

dotnet build
dotnet run
# Task 1.2 — C# Syntax Mapping

## Project

Task02-Syntax/
└── SyntaxPractice/
    ├── SyntaxPractice.csproj
    └── Program.cs


## Topics Covered

* Variables
* Data types
* `var`
* String interpolation
* Arithmetic operators
* Comparison operators
* Logical operators
* `if / else`
* `switch`
* Arrays
* `for`
* `foreach`
* `while`

## Program Written — Employee Evaluation

A practical Employee Evaluation program was created to combine the C# fundamentals learned in this task.

### Variables and Data Types

The program stores employee information using different C# types:

string employeeName = "Hari";
int employeeAge = 25;
double experienceYears = 2.5;
decimal monthlySalary = 45000.00m;
bool isActive = true;
char performanceGrade = 'A';


### `var`

The program uses `var` where the compiler can determine the type from the assigned value:


var department = "Engineering";
var yearsInCompany = 2;


`var` is still strongly typed. The compiler determines the type at compile time.

### String Interpolation

Employee information is displayed using string interpolation:

Console.WriteLine($"Name: {employeeName}");

### Arithmetic Operators

The program calculates annual salary and yearly bonus:


decimal annualSalary = monthlySalary * 12;
decimal yearlyBonus = monthlySalary * 2;

### Comparison Operators

The program checks employee conditions:


bool isExperienced = experienceYears >= 2;
bool isHighEarner = monthlySalary > 40000;


### Logical Operators

Multiple conditions are combined:

bool eligibleForPromotion =
    experienceYears >= 2 && performanceGrade == 'A';


### `if / else`

The employee performance grade is evaluated using conditional statements.

### `switch`

The employee department is selected using a `switch` statement.

### Array

Monthly performance scores are stored in an array:


int[] monthlyScores = { 80, 85, 90, 88, 95 };


### `for`

The array is processed using a `for` loop.

### `foreach`

The scores are also processed using `foreach`.

### `while`

A `while` loop is used to perform repeated processing while a condition remains true.

## Result

The Employee Evaluation application was successfully built and executed.

The program demonstrated how variables, data types, operators, conditions, arrays, and loops work together in a practical C# application.

# Task 1.3 — Methods & Value vs Reference Types

## Project


Task03-Methods/
└── MethodsPractice/
    ├── MethodsPractice.csproj
    └── Program.cs


## Topics Covered

* Methods
* Parameters
* Return values
* `ref`
* `out`
* `in`
* Tuples
* Value types
* Reference types
* Nullable value types
* Nullable reference types
* Null-forgiving operator `!`

## Program Written — Employee Processing

A practical Employee Processing program was created to understand methods and parameter passing in C#.

### Method with Parameters


static void PrintEmployee(string name, int age)
{
    Console.WriteLine($"Employee: {name}");
    Console.WriteLine($"Age: {age}");
}


### Method Returning a Value


static decimal CalculateAnnualSalary(decimal monthlySalary)
{
    return monthlySalary * 12;
}


### `ref`

The program modifies the original performance score using `ref`.


static void IncreaseScore(ref int score)
{
    score += 10;
}


Result:


Score before ref method: 90
Score after ref method:  100


### `out`

The program uses `out` to return multiple values from a method:

```csharp
static void GetEmployeeDetails(
    out string department,
    out int experience)
{
    department = "Engineering";
    experience = 3;
}


Result:


Department: Engineering
Experience: 3 years

### `in`

The salary is passed to a method using `in`:


static void PrintSalary(in decimal salary)
{
    Console.WriteLine($"Monthly Salary: {salary}");
}


### Tuple

The program returns multiple related values using a tuple:


static (string Name, int Age) GetEmployeeInfo()
{
    return ("Hari", 25);
}


Result:


Tuple Name: Hari
Tuple Age:  25


### Value Type

The program demonstrates that changing a copied value inside a method does not change the original variable:


Inside value-type method: 100
Original age after method: 25


### Reference Type

An `Employee` class is used to demonstrate reference-type behavior:


Employee name after method: Changed
Employee age after method:  30


### Nullable Value Type


int? optionalAge = null;


The value can contain either an integer or `null`.

### Nullable Reference Type


string? optionalName = null;


The reference is allowed to contain `null`.

### Null-Forgiving Operator


string? knownName = "Dotnet";

Console.WriteLine(knownName!.Length);


Result:


Name length: 6


The `!` operator tells the compiler that the value is expected to be non-null at that point. It does not provide runtime protection if the value is actually `null`.

## Result

The Employee Processing application was successfully built and executed.

The program demonstrated methods, parameter passing, return values, `ref`, `out`, `in`, tuples, value types, reference types, and nullable types.



# Task 1.4 — Arrays & Collections

## Project


Task04-Collections/
└── CollectionsPractice/
    ├── CollectionsPractice.csproj
    └── Program.cs


## Topics Covered

* Arrays
* `List<T>`
* `Dictionary<TKey,TValue>`
* `HashSet<T>`
* Adding items
* Removing items
* Collection indexing
* Key-value lookup
* `Contains()`
* String splitting
* Sorting
* `OrderByDescending()`
* `ThenBy()`

## Program Written — Collections Practice

A practical Collections Practice program was created to understand the main collection types in C#.

### Array

An array stores multiple values of the same type with a fixed size.


int[] scores = { 80, 85, 90, 95, 88 };


Elements can be accessed using an index:


scores[0]
scores[2]


### `List<T>`

A `List<T>` is dynamically sized.


List<int> scoresList = new List<int>();

scoresList.Add(80);
scoresList.Add(85);
scoresList.Add(90);


Items can be added and removed:


scoresList.Add(95);
scoresList.Remove(85);


### `Dictionary<TKey,TValue>`

A dictionary stores data as key-value pairs.


Dictionary<string, int> employeeScores =
    new Dictionary<string, int>();

employeeScores["Hari"] = 90;
employeeScores["Ravi"] = 85;
employeeScores["John"] = 95;

A value can be retrieved using its key:

employeeScores["Hari"]


### `HashSet<T>`

A `HashSet<T>` stores unique values.


HashSet<string> departments =
    new HashSet<string>();

departments.Add("Engineering");
departments.Add("HR");
departments.Add("Finance");
departments.Add("Engineering");


Adding the same value again does not create a duplicate entry.

### `Contains()`

Used to check whether a value exists:


departments.Contains("Engineering")


## Practical Exercise — Word Frequency Counter

The main practical exercise was a Word Frequency Counter.

The program takes a paragraph and:

1. Splits the paragraph into individual words.
2. Stores the words in a collection.
3. Finds unique words using a `HashSet`.
4. Counts occurrences using a `Dictionary<string, int>`.
5. Sorts the results by frequency.
6. Displays the final word-frequency report.

The main processing flow:


Paragraph
    ↓
Split()
    ↓
Array
    ↓
List<string>
    ↓
HashSet<string>
    ↓
Dictionary<string, int>
    ↓
OrderByDescending()
    ↓
Word Frequency Report


### Collection Selection

| Collection                | Main Use                     |
| ------------------------- | ---------------------------- |
| Array                     | Fixed-size collection        |
| `List<T>`                 | Dynamically sized collection |
| `Dictionary<TKey,TValue>` | Key-value lookup             |
| `HashSet<T>`              | Unique values                |

## Result

The Collections Practice application was successfully built and executed.

The exercise demonstrated why different collection types exist and how they can be combined to solve a practical problem.



# Completed Project Structure

Each task has its own project so that the code from completed tasks remains available and is not overwritten by later exercises.


Module01-CSharp/
│
├── README.md
│
├── HelloDotnet/
│   ├── HelloDotnet.csproj
│   └── Program.cs
│
├── Task02-Syntax/
│   └── SyntaxPractice/
│       ├── SyntaxPractice.csproj
│       └── Program.cs
│
├── Task03-Methods/
│   └── MethodsPractice/
│       ├── MethodsPractice.csproj
│       └── Program.cs
│
└── Task04-Collections/
    └── CollectionsPractice/
        ├── CollectionsPractice.csproj
        └── Program.cs


Generated folders such as `bin/` and `obj/` are excluded from Git because they are generated during restore and build operations.



# Module 1 Summary

The module covered the basic C# and .NET concepts required before moving into object-oriented programming.


.NET Environment
      ↓
C# Syntax
      ↓
Variables & Data Types
      ↓
Operators
      ↓
Control Flow
      ↓
Methods
      ↓
Parameters & Return Values
      ↓
ref / out / in
      ↓
Value & Reference Types
      ↓
Nullable Types
      ↓
Arrays
      ↓
List<T>
      ↓
Dictionary<TKey,TValue>
      ↓
HashSet<T>
      ↓
Sorting
      ↓
Practical Applications


## Module 1 Outcome

Module 1 is completed.

The concepts were studied theoretically and then implemented through separate .NET console applications.

The completed exercises provide the foundation for the next module, which will focus on object-oriented programming in C#.

The next module will cover:

* Classes and objects
* Constructors
* Properties
* Access modifiers
* Inheritance
* Polymorphism
* Interfaces
* Encapsulation
* SOLID basics
* Exception handling






