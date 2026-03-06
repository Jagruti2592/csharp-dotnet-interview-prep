# Generic Inventory System (C#)

## Overview

This project demonstrates core **C# Generics and Collection Framework concepts** through a simple **Inventory Management System**.
The system manages **Products, Customers, and Orders** using a **Generic Repository Pattern** and showcases how different .NET collections such as **List, Dictionary, and HashSet** can be used effectively.

The goal of this project is to strengthen understanding of **C# fundamentals commonly asked in .NET developer interviews**.

---

## Concepts Demonstrated

### 1. Generics

A **Generic Repository** is implemented so the same code can manage different entity types such as:

* Product
* Customer
* Order

This improves:

* Code reusability
* Type safety
* Maintainability

Example:

```csharp
GenericRepository<Product>
GenericRepository<Customer>
GenericRepository<Order>
```

---

### 2. Repository Pattern

The repository abstracts data access logic and provides common operations such as:

* Add
* GetAll
* GetById
* Update
* Remove

Interface:

```csharp
IRepository<T>
```

Implementation:

```csharp
GenericRepository<T>
```

---

### 3. Generic Constraints

To ensure that all entities contain an `Id`, a base interface is used.

```csharp
IEntity
```

This allows the repository to safely access entity identifiers.

Example:

```csharp
public class GenericRepository<T> where T : IEntity
```

---

### 4. C# Collection Classes

This project demonstrates three important .NET collections.

#### List<T>

Used for ordered storage and iteration.

Operations demonstrated:

* Add items
* Remove items
* Search items
* Sort items
* Iterate items

Example class:

```
ListManager
```

---

#### Dictionary<TKey, TValue>

Used for **fast lookups using keys**.

Operations demonstrated:

* Add key-value pairs
* Retrieve by key
* Remove items
* Iterate dictionary

Example class:

```
DictionaryManager
```

Dictionary lookup time complexity:

```
O(1)
```

---

#### HashSet<T>

Used to maintain **unique elements only**.

Operations demonstrated:

* Add unique values
* Prevent duplicates
* Remove items
* Check existence

Example class:

```
HashSetManager
```

---

## Project Architecture

```
GenericInventorySystem
│
├── Application
│   └── DemoRunner.cs
│
├── Models
│   ├── IEntity.cs
│   ├── Product.cs
│   ├── Customer.cs
│   └── Order.cs
│
├── Repository
│   ├── IRepository.cs
│   └── GenericRepository.cs
│
├── Services
│   └── InventoryService.cs
│
├── CollectionsDemo
│   ├── ListManager.cs
│   ├── DictionaryManager.cs
│   └── HashSetManager.cs
│
└── Program.cs
```

---

## Layers Explained

### Models

Defines the domain entities used in the system.

Examples:

* Product
* Customer
* Order

---

### Repository Layer

Handles generic data operations using:

```
GenericRepository<T>
```

This layer provides reusable CRUD functionality.

---

### Service Layer

`InventoryService` acts as a business logic layer and manages repositories for different entities.

Responsibilities include:

* Managing products
* Managing customers
* Managing orders

---

### Collections Demo

Demonstrates the behavior and usage of common C# collections:

* List
* Dictionary
* HashSet

---

### Application Layer

`DemoRunner` executes demonstrations for:

* Inventory management
* List operations
* Dictionary operations
* HashSet operations

---

## Sample Console Output

Inventory Service Demo:
1 - Laptop - 1200
2 - Phone - 800

List Demo:
1 - Laptop - 1200
2 - Phone - 800

Dictionary Demo:
1 - Laptop - 1200
2 - Phone - 800

HashSet Demo:
Electronics
Accessories


---

## Key Learnings

This project helped reinforce several important C# and .NET concepts:

* Generic programming
* Repository pattern
* Interface constraints
* Collection usage in .NET
* Layered architecture
* Clean project structure

---

## Technologies Used

* C#
* .NET
* Console Application
* Visual Studio

---

## Author

Jagruti Chitte
MS Computer Science – Worcester Polytechnic Institute

This project is part of a **.NET developer interview preparation series** focusing on mastering fundamental C# concepts through practical coding exercises.
