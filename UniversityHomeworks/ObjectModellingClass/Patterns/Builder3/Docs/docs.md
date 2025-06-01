# Pizza Builder Design Pattern Example

## Overview

This Pizza example demonstrates a classic implementation of the Builder Design Pattern.
The pattern is used to construct a complex object step-by-step and allows for the construction process
to create different representations of that object.

In this case, the `Pizza` object is the complex product,
which can be constructed in different variations (like Hawaiian or Spicy)
using different `PizzaBuilder` subclasses.

## Real-World Analogy

Imagine you go to a restaurant and ask a **waiter** for a pizza.
You don't tell the kitchen staff how to make it - you just say "I want a Hawaiian" or "a spicy pizza."

The **waiter (Director)** knows the steps to make a pizza and delegates those steps to a **specific pizza builder (ConcreteBuilder)**,
which then constructs a pizza following a recipe.

You get your pizza at the end without worrying about the internals.

## Roles in This Example

| Role                | Class                                       | Description                                                                                 |
| ------------------- | ------------------------------------------- | ------------------------------------------------------------------------------------------- |
| **Product**         | `Pizza`                                     | The complex object being built. It has multiple configurable parts (dough, sauce, topping). |
| **Builder**         | `PizzaBuilder` (abstract)                   | Declares the steps to build the product.                                                    |
| **ConcreteBuilder** | `HawaiianPizzaBuilder`, `SpicyPizzaBuilder` | Implement the building steps to assemble the product in different ways.                     |
| **Director**        | `Waiter`                                    | Controls the building process by calling the steps in a specific sequence.                  |

## Strengths of This Example

* Each builder constructs a different variation of the `Pizza`.
* `Waiter` encapsulates the construction logic and enforces consistent creation flow.
* `PizzaBuilder` uses method calls to isolate each construction step.
* Builders follow **step-by-step object construction**.
