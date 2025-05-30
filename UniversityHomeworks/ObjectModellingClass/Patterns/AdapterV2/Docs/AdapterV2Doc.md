# Difference between ChefAdapterByInheritance and ChefAdapterByComposition

## Purpose of Each

### 1. `ChefAdapterByInheritance` – **Class Adapter**

* Inherits from the **adaptee** class (`Plumber`) and implements the **target** interface (`Chief`).
* Uses **inheritance** to adapt functionality.

```csharp
public class ChefAdapterByInheritance : Plumber, Chief
```

-> This means `ChefAdapterByInheritance` becomes both a `Chief` and a `Plumber`.

### 2. `ChefAdapterByComposition` – **Object Adapter**

* Implements the **target** interface (`Chief`).
* **Composes** an instance of the adaptee (`Plumber`) inside.
* Uses **composition** to adapt functionality.

```csharp
public class ChefAdapterByComposition : Chief
{
    private Plumber plumber = new Plumber();
}
```

-> This means `ChefAdapterByComposition` is a `Chief`, but **has a** `Plumber`.

## Why Both Exist?

They serve the same functional purpose but follow different **design trade-offs**.

| Feature              | `ChefAdapterByInheritance` (Class)                    | `ChefAdapterByComposition` (Object)     |
| -------------------- | ----------------------------------------- | --------------------------------- |
| Type of relationship | Inheritance                               | Composition                       |
| Flexibility          | ❌ Tightly coupled to `Plumber`            | ✅ More flexible                   |
| Extensibility        | ❌ Can't adapt multiple classes            | ✅ Can wrap different adaptees     |
| Single inheritance   | ❌ C# doesn't support multiple inheritance | ✅ No problem (can wrap any class) |
| Reusability          | ❌ Less reusable                           | ✅ More reusable                   |

## When to Use Each

* Use **class adapter** (`ChefAdapterByInheritance`) when:

  * You can inherit from the adaptee (`Plumber`).
  * You don't need to adapt multiple different classes.
  * Simpler and slightly faster access to adaptee methods.

* Use **object adapter** (`ChefAdapterByComposition`) when:

  * You want to adapt multiple types or inject the adaptee at runtime.
  * You want better encapsulation and flexibility.
  * You’re working in a language like C# that restricts multiple inheritance.

## Analogy

* **Class Adapter**: “I *am also* a plumber (inherit).”
* **Object Adapter**: “I *have* a plumber to do the work (wrap).”

## Summary

| Term                       | Role                                              |
| -------------------------- | ------------------------------------------------- |
| `Chief`                    | Target interface                                  |
| `Plumber`                  | Adaptee (the existing incompatible class)         |
| `ChefAdapterByInheritance` | Class Adapter                                     |
| `ChefAdapterByComposition` | Object Adapter                                    |
| `Client`                   | Anything that uses `Chief` (e.g., kitchen system) |
