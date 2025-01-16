# C# Constructor Shadowing Bug

This repository demonstrates a common, yet subtle bug in C# related to constructor parameter shadowing. The issue arises when a constructor parameter has the same name as an instance variable, leading to the parameter inadvertently shadowing the instance variable.  This results in the instance variable not being correctly initialized.

**Bug:** The `ExampleClass` constructor incorrectly assigns the value to a local variable which shadows the instance member `MyProperty`, instead of assigning the value to the `MyProperty` instance variable.