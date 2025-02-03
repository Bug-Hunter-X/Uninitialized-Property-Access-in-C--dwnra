# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property of a class before it has been assigned a value.  This can lead to unexpected behavior and exceptions.  The `bug.cs` file shows the problematic code, while `bugSolution.cs` provides a corrected version.

## Problem

In the `bug.cs` file, the `MyProperty` property is accessed within the `MyMethod` function without first assigning it a value.  If the property is a reference type (like a string or custom class), accessing it without initialization may result in a `NullReferenceException`. If it's a value type, it will contain a default value which might not be the intended behavior.

## Solution

The `bugSolution.cs` file corrects the issue by initializing `MyProperty` either in the constructor or in `MyMethod` before accessing it.