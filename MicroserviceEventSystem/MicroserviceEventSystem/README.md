# Order Processing Notification System (C# Events)

## Overview

This project demonstrates **C# Events and the Publisher–Subscriber pattern** by building a simplified **Order Processing Notification System**.
When an order is placed, multiple independent services react to the event, such as sending notifications, updating inventory, scheduling shipping, and recording analytics.

The goal of this project is to understand how **events enable loose coupling between components**, which is a common pattern used in **backend systems and event-driven architectures**.

---

## Concepts Demonstrated

### 1. Events in C#

An **event** allows a class to notify other classes when something important happens.

Example:

```csharp
public event EventHandler<OrderPlacedEventArgs> OrderPlaced;
```

Events are based on **delegates** but provide additional **encapsulation and safety**, ensuring that only the declaring class can raise the event.

---

### 2. Publisher–Subscriber Pattern

The project follows the **publisher–subscriber design pattern**.

Publisher:

```text
OrderService
```

Subscribers:

```text
EmailService
InventoryService
ShippingService
AnalyticsService
```

Flow:

```text
Order Placed
     ↓
OrderPlaced Event Raised
     ↓
Subscribers React
```

This design promotes **loose coupling**, meaning services do not directly depend on each other.

---

### 3. EventHandler<T> Pattern

The project uses the standard **.NET event pattern**:

```csharp
EventHandler<TEventArgs>
```

Example:

```csharp
public event EventHandler<OrderPlacedEventArgs> OrderPlaced;
```

This is the recommended way to implement events in modern .NET applications.

---

### 4. EventArgs Pattern

Events pass data using an **EventArgs class**.

Example:

```csharp
public class OrderPlacedEventArgs : EventArgs
{
    public Order Order { get; }
}
```

This ensures event data is:

* strongly typed
* extensible
* structured

---

## Project Architecture

```text
OrderProcessingSystem
│
├── Application
│   └── DemoRunner.cs
│
├── Models
│   └── Order.cs
│
├── Events
│   └── OrderPlacedEventArgs.cs
│
├── Services
│   ├── OrderService.cs
│   ├── EmailService.cs
│   ├── InventoryService.cs
│   ├── ShippingService.cs
│   └── AnalyticsService.cs
│
└── Program.cs
```

---

## Layer Explanation

### Models

Contains domain entities used by the system.

Example:

```
Order
```

---

### Events

Contains classes that define **event data**.

Example:

```
OrderPlacedEventArgs
```

---

### Services

Contains the core business services.

Publisher:

```
OrderService
```

Subscribers:

```
EmailService
InventoryService
ShippingService
AnalyticsService
```

Each subscriber reacts independently to the **OrderPlaced event**.

---

### Application Layer

`DemoRunner` wires together the publisher and subscribers and triggers the workflow.

---

## Example Event Flow

1. Order is placed.
2. `OrderService` raises the `OrderPlaced` event.
3. Multiple services respond to the event.

```text
Order Placed
     ↓
OrderPlaced Event
     ↓
EmailService → Send confirmation email
InventoryService → Update stock
ShippingService → Schedule shipment
AnalyticsService → Record order metrics
```

---

## Sample Output

```text
Order 101 placed.
Email sent to customer@email.com for order 101
Inventory updated for order 101
Shipping scheduled for order 101
Analytics recorded for order 101
```

---

## Key Learnings

This project reinforces several important C# and backend development concepts:

* Events in C#
* Publisher–Subscriber pattern
* EventHandler<T> pattern
* EventArgs usage
* Loose coupling between services
* Event-driven architecture fundamentals

---

## Technologies Used

* C#
* .NET
* Console Application
* Events & Delegates
* Visual Studio

---

## Real-World Applications

The event-driven design used in this project is similar to architectures used in:

* E-commerce platforms
* Microservices systems
* Messaging pipelines
* Workflow automation
* Distributed systems

Examples of real technologies using similar patterns:

```text
Kafka
RabbitMQ
Azure Service Bus
AWS SNS / SQS
```

---

## Author

Jagruti Chitte
MS Computer Science – Worcester Polytechnic Institute

This project is part of a **C# / .NET interview preparation series**, focusing on mastering core language features through practical backend-style implementations.
