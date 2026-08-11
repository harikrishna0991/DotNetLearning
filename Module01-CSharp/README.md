# Module 01 — Environment & C# Fundamentals

## Progress

Started learning the .NET environment and understanding how a .NET application is created, built, and executed.

## Topics Covered

### C#

C# is the programming language we use to write applications that run on the .NET platform.

### .NET

.NET is the platform that provides the runtime, libraries, tools, and frameworks needed to build and run applications.

### .NET SDK

The .NET SDK gives us the tools needed to create, build, test, and publish .NET applications.

### .NET Runtime

The .NET Runtime provides the environment needed to run a compiled .NET application.

### ASP.NET Core

ASP.NET Core is the web framework built on .NET. It is used to build Web APIs, web applications, MVC applications, and other web services.

### .NET CLI

The .NET CLI is the command-line tool we use to work with .NET projects.

Examples:

```powershell
dotnet new
dotnet build
dotnet run
dotnet test
dotnet publish
```

### `Program.cs`

`Program.cs` contains the main application code. In modern .NET console applications, we can use top-level statements instead of writing the traditional `Main()` method ourselves.

### `.csproj`

The `.csproj` file contains the configuration of a .NET project. It tells .NET things like which framework the project targets and how the project should be built.

### `bin/`

The `bin` folder contains the files generated after building the application, such as the `.dll`, `.exe`, `.pdb`, and runtime configuration files.

These are generated files and normally should not be committed to Git.

### `obj/`

The `obj` folder contains temporary and intermediate files created while .NET is restoring and building the project.

These files are also generated and should normally not be committed to Git.

### `dotnet build`

`dotnet build` builds the project. It restores the required dependencies if needed, compiles the C# code, and creates the build output.

### MSBuild

MSBuild is the build system used by .NET. It takes the project configuration from the `.csproj` file and coordinates the different steps required to build the application.

### C# Compiler

The C# compiler takes our C# source code and converts it into IL and metadata.

```text
C# Code
   ↓
C# Compiler
   ↓
IL + Metadata
```

### Intermediate Language (IL)

IL is the code produced after compiling C#. It is not the machine code that the CPU directly understands. The IL is stored in the .NET assembly and is converted to machine code when the application runs.

### .NET Assembly (`.dll`)

A `.dll` produced by a .NET project is an assembly. It contains the compiled IL along with metadata and other information needed by the .NET runtime.

### CLR

The CLR is the main execution engine inside the .NET Runtime. It provides the environment and services needed while the application is running, such as memory management, garbage collection, exception handling, and JIT compilation.

### JIT

JIT stands for Just-In-Time compiler. It takes the IL from the assembly and converts it into native machine code while the application is running.

```text
IL
 ↓
JIT
 ↓
Native Machine Code
 ↓
CPU
```

### Native Machine Code

Native machine code is the processor-specific code that the CPU can directly execute.

### Assembly Metadata

Metadata is information about the code inside the assembly. It describes things such as classes, methods, properties, parameters, and their types.

### Assembly Manifest

The manifest contains information that identifies the assembly and describes things such as its name, version, and referenced assemblies.

### Reflection

Reflection allows a .NET application to look at information about types, classes, methods, properties, and assemblies while the application is running.

---

## .NET Execution Pipeline

The overall execution flow learned so far:

```text
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
```

## Build Flow

When we run:

```powershell
dotnet build
```

the basic flow is:

```text
.NET CLI
   ↓
MSBuild
   ↓
C# Compiler
   ↓
IL + Metadata
   ↓
Assembly (.dll)
```

## Run Flow

When the application runs:

```powershell
dotnet run
```

the runtime takes over:

```text
.NET Runtime
      ↓
CLR
      ↓
JIT
      ↓
Native Machine Code
      ↓
CPU
```

## Project Created

Created the first .NET Console application:

```powershell
dotnet new console -n HelloDotnet
```

Project structure:

```text
HelloDotnet/
├── HelloDotnet.csproj
└── Program.cs
```

The application was successfully built and run using:

```powershell
dotnet build
dotnet run
```

## Current Focus

Next topics to learn:

* Variables and data types
* `var`
* String interpolation
* Operators
* `if` / `else`
* `switch`
* `for`
* `foreach`
* `while`
* Methods
* Value types and reference types
* Arrays and collections

## Learning Goal

The main goal is to understand what the code is doing and why it is written that way, so that I can confidently read, modify, debug, and work with .NET code in future projects.
