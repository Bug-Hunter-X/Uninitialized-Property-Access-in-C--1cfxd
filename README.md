# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property that hasn't been explicitly initialized.  Uninitialized properties have default values (0 for integers, null for references etc.) but accessing them without setting a specific value can result in unexpected behavior and make debugging difficult.

**The Problem:**

The `bug.cs` file shows an example where `MyProperty` is used before any value is assigned.  This might lead to using the default value of 0 instead of any value provided by the user which is likely not the intended behavior.

**The Solution:**

The `bugSolution.cs` demonstrates the correct way to initialize `MyProperty`, ensuring that a value is assigned before it's accessed. This leads to more predictable and robust code.

## How to Run

1. Clone the repository.
2. Open the solution file in your preferred C# IDE (e.g., Visual Studio).
3. Build and run the code to observe the difference in behavior between the buggy and the corrected version.