# Composite Design Pattern

The **Composite Design Pattern** is a structural pattern that allows you to compose objects into tree structures to represent part-whole hierarchies. It enables clients to treat individual objects and groups of objects uniformly, simplifying code that deals with recursive or hierarchical structures such as file systems, graphical user interfaces, or organizational charts.

This pattern is particularly useful when you want to manipulate a hierarchy of objects using a common interface, where both leaf nodes (simple elements) and composite nodes (groups of elements) share the same behavior.

## Real-World Analogy

Think of a company. A company has many employees, some of whom are regular staff, while others are managers who oversee teams. A manager can have one or more direct reports these could be individual contributors or other managers. Whether you're calculating total salary, printing a team chart, or sending a company-wide message, you want to treat all employees the same regardless of whether they're individuals or groups.

This is the essence of the Composite Pattern: **treating part and whole objects in the same way.**

## Structure

The pattern forms a **tree-like structure**:

```txt
IEmployee (Component)
├── Staff (Leaf)
└── Manager (Composite)
      ├── Staff
      └── Manager
            └── Staff
```

### Components

* **Component (`IEmployee`)**:
  This is a shared interface that declares a common operation (`GetDetails`) used by both individual employees and groups.

* **Leaf (`Staff`)**:
  A simple object that implements the `IEmployee` interface. It represents individual employees who do not manage others. The `GetDetails` method returns their own details with optional indentation for display purposes.

* **Composite (`Manager`)**:
  A complex object that also implements `IEmployee`. In addition to storing its own information, it maintains a list of subordinates, which can be other `Manager` or `Staff` objects. It implements `Add` and `Remove` operations to manage this list, and its `GetDetails` method recursively collects details of itself and all its subordinates.

## When to Use

* When your system must support a tree-like structure such as file directories, menus, or organization charts.
* When you want to treat individual and group elements the same way through a shared interface.
* When recursive behavior is needed for a collection of similar elements.

## Benefits

* **Uniformity**: Clients can treat composite and leaf nodes uniformly.
* **Simplified client code**: Client logic does not need to distinguish between individual and composite objects.
* **Extensibility**: Easy to add new types of components (e.g., new kinds of employees).

## Drawbacks

* **Over-generalization**: Sometimes, methods like `Add` or `Remove` don't apply to leaf nodes, which may lead to awkward or empty implementations.
* **Tree traversal complexity**: Can be tricky to debug or trace when dealing with deep or complex hierarchies.

## Resources

Generated by ChatGPT
