using System;

// ============================================
// Task 1.2 - C# Syntax Mapping
// Employee Evaluation Program
// ============================================

// 1. VARIABLES AND DATA TYPES

string employeeName = "Hari";
int employeeAge = 25;
double experienceYears = 2.5;
decimal monthlySalary = 45000.00m;
bool isActive = true;
char performanceGrade = 'A';

Console.WriteLine("=================================");
Console.WriteLine("     EMPLOYEE EVALUATION");
Console.WriteLine("=================================");


// 2. STRING INTERPOLATION

Console.WriteLine($"Name       : {employeeName}");
Console.WriteLine($"Age        : {employeeAge}");
Console.WriteLine($"Experience : {experienceYears} years");
Console.WriteLine($"Salary     : {monthlySalary}");
Console.WriteLine($"Active     : {isActive}");
Console.WriteLine($"Grade      : {performanceGrade}");


// 3. VAR

var department = "Engineering";
var yearsInCompany = 2;

Console.WriteLine($"Department : {department}");
Console.WriteLine($"Company Experience : {yearsInCompany} years");


// 4. ARITHMETIC OPERATORS

decimal annualSalary = monthlySalary * 12;
decimal yearlyBonus = monthlySalary * 2;

Console.WriteLine();
Console.WriteLine("Salary Information");
Console.WriteLine("------------------");
Console.WriteLine($"Monthly Salary : {monthlySalary}");
Console.WriteLine($"Annual Salary  : {annualSalary}");
Console.WriteLine($"Yearly Bonus   : {yearlyBonus}");


// 5. COMPARISON OPERATORS

bool isExperienced = experienceYears >= 2;
bool isHighEarner = monthlySalary > 40000;

Console.WriteLine();
Console.WriteLine("Employee Checks");
Console.WriteLine("----------------");
Console.WriteLine($"Experienced : {isExperienced}");
Console.WriteLine($"High Earner : {isHighEarner}");


// 6. LOGICAL OPERATORS

bool eligibleForPromotion =
    experienceYears >= 2 && performanceGrade == 'A';

bool needsTraining =
    performanceGrade == 'C' || performanceGrade == 'D';

Console.WriteLine($"Promotion Eligible : {eligibleForPromotion}");
Console.WriteLine($"Needs Training     : {needsTraining}");


// 7. IF / ELSE

Console.WriteLine();
Console.WriteLine("Performance");
Console.WriteLine("-----------");

if (performanceGrade == 'A')
{
    Console.WriteLine("Excellent performance.");
}
else if (performanceGrade == 'B')
{
    Console.WriteLine("Good performance.");
}
else
{
    Console.WriteLine("Performance needs improvement.");
}


// 8. SWITCH

Console.WriteLine();
Console.WriteLine("Department");

switch (department)
{
    case "Engineering":
        Console.WriteLine("Employee works in Engineering.");
        break;

    case "HR":
        Console.WriteLine("Employee works in Human Resources.");
        break;

    case "Finance":
        Console.WriteLine("Employee works in Finance.");
        break;

    default:
        Console.WriteLine("Unknown department.");
        break;
}


// 9. ARRAY

int[] monthlyScores = { 80, 85, 90, 88, 95 };


// 10. FOR LOOP

Console.WriteLine();
Console.WriteLine("Monthly Scores using FOR");
Console.WriteLine("------------------------");

for (int i = 0; i < monthlyScores.Length; i++)
{
    Console.WriteLine($"Month {i + 1}: {monthlyScores[i]}");
}


// 11. FOREACH LOOP

Console.WriteLine();
Console.WriteLine("Scores using FOREACH");
Console.WriteLine("--------------------");

foreach (int score in monthlyScores)
{
    Console.WriteLine($"Score: {score}");
}


// 12. WHILE LOOP

Console.WriteLine();
Console.WriteLine("WHILE Loop");

int count = 1;

while (count <= 3)
{
    Console.WriteLine($"Processing step {count}");
    count++;
}


Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("Evaluation completed.");
Console.WriteLine("=================================");
