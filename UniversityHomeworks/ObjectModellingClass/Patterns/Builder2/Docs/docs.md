# Computer Builder Pattern

This is **considered a valid implementation of the Builder Design Pattern**.
It follows a variation of the pattern known as the **"Telescoping Constructor Builder"**,
and it's commonly used in modern object-oriented programming when you want to construct complex objects step-by-step,
especially when some parameters are optional.

## Why This Is a Builder Pattern

The Builder Pattern is used to:

* Construct complex objects step-by-step.
* Allow optional parameters to be set in a readable way.
* Separate the construction logic from the representation of the object.

In the example:

| Element                   | Pattern Role                                      |
| ------------------------- | ------------------------------------------------- |
| `ComputerBuilder`         | **Builder**                                       |
| `Comp`                    | **Product**                                       |
| `ComputerBuilder.Build()` | **build method** that constructs the final object |

It allows this kind of fluent usage:

```csharp
Comp computer = new ComputerBuilder("1TB", "16GB")
                    .SetBluetoothEnabled(true)
                    .SetGraphicsCardEnabled(false)
                    .Build();
```

This approach enhances **readability**, **maintainability**, and **clarity** when working with objects
that have many optional fields.
