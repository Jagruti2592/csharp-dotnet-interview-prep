# Async API Aggregator Service (C# Async / Await)

## Overview

This project demonstrates **asynchronous programming in C# using `async` / `await` and `Task`** by implementing a **backend-style API Aggregator Service**.

The system simulates a backend service that fetches data from multiple independent services — such as **User Service, Order Service, and Recommendation Service** — and combines the results into a single aggregated response.

This pattern is commonly used in **microservices architectures, API gateways, and Backend-for-Frontend (BFF) systems**.

---

## Problem Scenario

Modern applications often need to gather data from multiple services.

Example:

```text
User Dashboard Request
        │
        ▼
User Profile Aggregator
        │
        ├── User Service
        ├── Order Service
        └── Recommendation Service
```

If these services are called **sequentially**, response time increases significantly.

Example:

```
User API → 1s
Orders API → 1.2s
Recommendations API → 0.9s

Total ≈ 3.1 seconds
```

By using **parallel asynchronous calls**, the services execute simultaneously:

```
Total ≈ 1.2 seconds
```

---

## Concepts Demonstrated

### 1. Asynchronous Programming

The project uses the **Task-based Asynchronous Pattern (TAP)**.

Example:

```csharp
public async Task<User> GetUserAsync(int userId)
{
    await Task.Delay(1000);
}
```

Benefits:

* Non-blocking execution
* Improved scalability
* Better performance for I/O operations

---

### 2. `async` and `await`

`async` enables asynchronous execution inside a method.

`await` pauses execution until the task completes **without blocking the thread**.

Example:

```csharp
var user = await userService.GetUserAsync(userId);
```

---

### 3. Parallel Task Execution

The project uses `Task.WhenAll()` to run multiple asynchronous operations concurrently.

Example:

```csharp
var userTask = userService.GetUserAsync(userId);
var ordersTask = orderService.GetOrdersAsync(userId);
var recommendationsTask = recommendationService.GetRecommendationsAsync(userId);

await Task.WhenAll(userTask, ordersTask, recommendationsTask);
```

This allows the services to execute **in parallel**, improving response time.

---

### 4. Aggregator Pattern

The **Aggregator Service** combines responses from multiple services into a single unified object.

Example aggregated model:

```csharp
public class UserProfile
{
    public User User { get; set; }
    public List<Order> Orders { get; set; }
    public List<Recommendation> Recommendations { get; set; }
}
```

---

### 5. Dependency Injection in Console Applications

The project uses **`ServiceCollection`** from `Microsoft.Extensions.DependencyInjection` to register and resolve services.

Example:

```csharp
var services = new ServiceCollection();

services.AddSingleton<UserService>();
services.AddSingleton<OrderService>();
services.AddSingleton<RecommendationService>();
services.AddSingleton<UserProfileAggregatorService>();
```

This mirrors the **dependency injection model used in ASP.NET Core applications**.

---

## Project Architecture

```
AsyncApiAggregator
│
├── Application
│   └── DemoRunner.cs
│
├── Models
│   ├── User.cs
│   ├── Order.cs
│   ├── Recommendation.cs
│   └── UserProfile.cs
│
├── Services
│   ├── UserService.cs
│   ├── OrderService.cs
│   ├── RecommendationService.cs
│   └── UserProfileAggregatorService.cs
│
└── Program.cs
```

---

## Layer Explanation

### Models

Defines domain entities used in the system.

Examples:

* `User`
* `Order`
* `Recommendation`
* `UserProfile`

---

### Services

Each service simulates a backend service call.

Examples:

```
UserService
OrderService
RecommendationService
```

These services represent **external APIs or microservices**.

---

### Aggregator Service

`UserProfileAggregatorService` orchestrates multiple services and aggregates the data.

Responsibilities:

* Call multiple services asynchronously
* Execute tasks in parallel
* Combine responses into a single result

---

### Application Layer

`DemoRunner` executes the aggregation workflow and prints the final result.

---

## Example Execution Flow

```
Client Request
      │
      ▼
UserProfileAggregatorService
      │
      ├── GetUserAsync()
      ├── GetOrdersAsync()
      └── GetRecommendationsAsync()
             │
             ▼
        Task.WhenAll()
             │
             ▼
        Aggregated UserProfile
```

---

## Sample Console Output

```
Fetching user data...
Fetching user orders...
Fetching recommendations...

User Profile Aggregated

User: Jagruti
Orders: 2
Recommendations: 2
```

All services run **concurrently**, reducing overall execution time.

---

## Key Learnings

This project demonstrates several important backend development concepts:

* Asynchronous programming in C#
* `async` / `await`
* Task-based asynchronous pattern
* Parallel execution using `Task.WhenAll`
* Dependency Injection in console applications
* Aggregator pattern for microservices

---

## Real-World Applications

The architecture demonstrated here is similar to systems used in:

* API Gateway services
* Backend-for-Frontend (BFF) architectures
* Microservice orchestration layers
* Data aggregation services

Examples include platforms like:

```
Amazon product pages
Netflix dashboards
Uber rider apps
```

---

## Technologies Used

* C#
* .NET
* Async / Await
* Task Parallelism
* Dependency Injection
* Console Application

---

## Author

Jagruti Chitte
MS Computer Science – Worcester Polytechnic Institute

This project is part of a **.NET Backend Interview Preparation Series** focused on mastering core C# concepts through practical backend-oriented implementations.
