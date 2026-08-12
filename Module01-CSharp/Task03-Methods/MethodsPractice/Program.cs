// ============================================
// Task 1.3 - Methods & Value vs Reference Types
// ============================================

Console.WriteLine("======================================");
Console.WriteLine("       EMPLOYEE PROCESSING");
Console.WriteLine("======================================");

// 1. METHOD WITH PARAMETERS

string employeeName = "Hari";
int employeeAge = 25;

PrintEmployee(employeeName, employeeAge);


// 2. METHOD RETURNING A VALUE

decimal monthlySalary = 45000;

decimal annualSalary = CalculateAnnualSalary(monthlySalary);

Console.WriteLine($"Annual Salary: {annualSalary}");


// 3. REF PARAMETER

int performanceScore = 90;

Console.WriteLine();
Console.WriteLine($"Score before ref method: {performanceScore}");

IncreaseScore(ref performanceScore);

Console.WriteLine($"Score after ref method:  {performanceScore}");


// 4. OUT PARAMETER

GetEmployeeDetails(out string department, out int experience);

Console.WriteLine();
Console.WriteLine($"Department: {department}");
Console.WriteLine($"Experience: {experience} years");


// 5. IN PARAMETER

Console.WriteLine();
PrintSalary(in monthlySalary);


// 6. TUPLE RETURN VALUE

var employeeInfo = GetEmployeeInfo();

Console.WriteLine();
Console.WriteLine($"Tuple Name: {employeeInfo.Name}");
Console.WriteLine($"Tuple Age:  {employeeInfo.Age}");


// 7. VALUE TYPE EXAMPLE

int originalAge = 25;

ChangeValueType(originalAge);

Console.WriteLine();
Console.WriteLine($"Original age after method: {originalAge}");


// 8. REFERENCE TYPE EXAMPLE

Employee employee = new Employee();

employee.Name = "Hari";
employee.Age = 25;

ChangeReferenceType(employee);

Console.WriteLine();
Console.WriteLine($"Employee name after method: {employee.Name}");
Console.WriteLine($"Employee age after method:  {employee.Age}");


// 9. NULLABLE VALUE TYPE

int? optionalAge = 30;

Console.WriteLine();

if (optionalAge.HasValue)
{
    Console.WriteLine($"Optional age: {optionalAge.Value}");
}
else
{
    Console.WriteLine("Optional age was not provided.");
}


// 10. NULLABLE REFERENCE TYPE

string? optionalName = null;

if (optionalName is not null)
{
    Console.WriteLine($"Optional name: {optionalName}");
}
else
{
    Console.WriteLine("Optional name was not provided.");
}


// 11. NULL-FORGIVING OPERATOR

string? knownName = "Dotnet";

Console.WriteLine($"Name length: {knownName!.Length}");


// ============================================
// METHODS
// ============================================

static void PrintEmployee(string name, int age)
{
    Console.WriteLine();
    Console.WriteLine($"Employee: {name}");
    Console.WriteLine($"Age: {age}");
}


static decimal CalculateAnnualSalary(decimal monthlySalary)
{
    return monthlySalary * 12;
}


static void IncreaseScore(ref int score)
{
    score += 10;
}


static void GetEmployeeDetails(
    out string department,
    out int experience)
{
    department = "Engineering";
    experience = 3;
}


static void PrintSalary(in decimal salary)
{
    Console.WriteLine($"Monthly Salary: {salary}");
}


static (string Name, int Age) GetEmployeeInfo()
{
    return ("Hari", 25);
}


static void ChangeValueType(int age)
{
    age = 100;

    Console.WriteLine($"Inside value-type method: {age}");
}


static void ChangeReferenceType(Employee employee)
{
    employee.Name = "Changed";
    employee.Age = 30;
}


// ============================================
// EMPLOYEE CLASS
// ============================================

class Employee
{
    public string Name = "";
    public int Age;
}