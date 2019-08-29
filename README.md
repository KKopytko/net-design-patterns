# Net Design Patterns

This project contains examples of some of the most commonly used design patterns in .NET:
* Abstract factory
* Adapter
* Decorator
* Facade
* Observer
* Singleton
* State
* Strategy

### Requirements
Project written using **.NET Core 2.2**.
Once you clone this repository, open terminal, enter the directory with `Patterns.csproj` file and type:
```
dotnet run
```

### Example selection
After executing the application you should see the following menu:
```
1) Abstract factory
2) Adapter
3) Decorator
4) Facade
5) Observer
6) Singleton
7) State
8) Strategy
ESC) Exit

Select example:
```

You can pick any of the above numbers to run the example. Escape key exits the program.

Examples are detected in the code automatically at the start of the program. Reflection detects all classes that implement `IRunnableExample` interface. It's easy to quickly add new examples.
