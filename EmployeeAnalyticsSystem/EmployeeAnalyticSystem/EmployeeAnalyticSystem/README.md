# Employee Analytics Engine (C# LINQ & Lambda Expressions)

## Overview

This project demonstrates **LINQ (Language Integrated Query) and Lambda Expressions** in C# by building a small **Employee Analytics Engine**.
The system processes employee data and performs analytics such as filtering, grouping, sorting, and aggregation.

The goal of this project is to practice **LINQ query pipelines and lambda expressions** in a way similar to how they are used in **real backend services and APIs**.

---

## Concepts Demonstrated

### 1. Lambda Expressions

Lambda expressions provide a concise way to define **inline functions**.

Example:

```csharp
e => e.Salary > 80000
```

Used in LINQ operations such as:

```csharp
employees.Where(e => e.Salary > 80000)
```

Benefits:

* Cleaner code
* Functional programming style
* Enables LINQ query pipelines

---

### 2. LINQ (Language Integrated Query)

LINQ allows querying collections in a **SQL-like style** directly in C#.

Example:

```csharp
var highSalaryEmployees =
    employees.Where(e => e.Salary > 80000);
```

Without LINQ this would require:

* manual loops
* conditional checks
* additional lists

LINQ makes data manipulation **more expressive and readable**.

---

## LINQ Operators Used

This project demonstrates several commonly used LINQ operators.

### Filtering

```csharp
Where()
```

Example:

```csharp
employees.Where(e => e.Department == "Engineering")
```

---

### Projection

```csharp
Select()
```

Example:

```csharp
employees.Select(e => e.Name)
```

Projection transforms data into **new shapes such as DTOs**.

---

### Sorting

```csharp
OrderBy()
OrderByDescending()
```

Example:

```csharp
employees.OrderByDescending(e => e.Salary)
```

---

### Aggregation

```csharp
Count()
Average()
Max()
Min()
```

Example:

```csharp
employees.Average(e => e.Salary)
```

These are commonly used for **analytics and reporting**.

---

### Grouping

```csharp
GroupBy()
```

Example:

```csharp
employees.GroupBy(e => e.Department)
```

Grouping enables building **analytics dashboards and summaries**.

---

### Limiting Results

```csharp
Take()
Skip()
```

Example:

```csharp
employees.OrderByDescending(e => e.Salary)
         .Take(3)
```

This pattern is commonly used for **pagination in APIs**.

---

## Project Architecture

```
EmployeeAnalyticsSystem
│
├── Application
│   └── DemoRunner.cs
│
├── Models
│   ├── Employee.cs
│   └── DepartmentSalaryStats.cs
│
├── DTOs
│   └── EmployeeSummaryDTO.cs
│
├── Data
│   └── EmployeeRepository.cs
│
├── Services
│   ├── EmployeeAnalyticsService.cs
│   └── ReportingService.cs
│
└── Program.cs
```

---

## Layer Explanation

### Models

Represents core domain entities such as:

* Employee
* DepartmentSalaryStats

---

### Data Layer

`EmployeeRepository` simulates a data source and returns employee records.

---

### Services Layer

Contains business logic for analytics operations.

Examples:

* High salary employee filtering
* Department salary statistics
* Top-paid employee queries

---

### DTO Layer

DTOs (Data Transfer Objects) provide **lightweight objects used for data projection**.

Example:

```
EmployeeSummaryDTO
```

Used when returning only specific fields such as:

* Name
* Salary

---

### Reporting Layer

`ReportingService` generates analytics reports such as:

* Department salary statistics
* Employee counts per department

---

### Application Layer

`DemoRunner` orchestrates the system by:

* loading employee data
* executing analytics queries
* printing results

---

## Example Analytics Queries

### Top Paid Employees

```csharp
employees
    .OrderByDescending(e => e.Salary)
    .Take(3);
```

---

### Employees by Department

```csharp
employees
    .Where(e => e.Department == "Engineering");
```

---

### Department Salary Analytics

```csharp
employees
    .GroupBy(e => e.Department)
    .Select(g => new DepartmentSalaryStats
    {
        Department = g.Key,
        AverageSalary = g.Average(e => e.Salary),
        EmployeeCount = g.Count()
    });
```

---

## Sample Output

```
Top Paid Employees
Eva - 120000
Alice - 90000
David - 80000

Department Salary Report
Engineering → Avg Salary: 95000 | Employees: 3
HR → Avg Salary: 65000 | Employees: 1
Finance → Avg Salary: 80000 | Employees: 1
```

---

## Key Learnings

This project reinforces several important C# and LINQ concepts:

* Lambda expressions
* LINQ query pipelines
* Data filtering and projection
* Aggregation operations
* Grouping and analytics queries
* DTO-based data transformation
* Layered architecture

---

## Technologies Used

* C#
* .NET
* LINQ
* Console Application
* Visual Studio

---

## Author

Jagruti Chitte
MS Computer Science – Worcester Polytechnic Institute

This project is part of a **C# / .NET interview preparation series** focused on mastering core language features through practical backend-style implementations.
