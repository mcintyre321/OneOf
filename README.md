# OneOf

> "Ah! It's like a compile time checked switch statement!" - Mike Giorgaras

## Getting Started

> install-package OneOf


This library provides F# style discriminated unions for C#, using a custom type `OneOf<T0, ... Tn>`. An instance of this type holds a single value, which is one of the types in its generic argument list.

I can't encourage you enough to give it a try! Due to exhaustive matching DUs provide an alternative to polymorphism when you want to have a method with guaranteed behaviour-per-type (i.e. adding an abstract method on a base type, and then implementing that method in each type). It's a really powerful tool, ask any f#/Scala dev! :)

PS If you like OneOf, you might want to check out [ValueOf](https://github.com/mcintyre321/valueof), for one-line Value Object Type definitions.

## Use cases

### As a method return value

The most frequent use case is as a return value, when you need to return different results from a method. Here's how you might use it in an MVC controller action:

```csharp
public OneOf<User, InvalidName, NameTaken> CreateUser(string username)
{
    if (!IsValid(username)) return new InvalidName();
    var user = _repo.FindByUsername(username);
    if(user != null) return new NameTaken();
    var user = new User(username);
    _repo.Save(user);
    return user;
}

[HttpPost]
public IActionResult Register(string username)
{
    OneOf<User, InvalidName, NameTaken> createUserResult = CreateUser(username);
    return createUserResult.Match(
        user => new RedirectResult("/dashboard"),
        invalidName => { 
            ModelState.AddModelError(nameof(username), $"Sorry, that is not a valid username.");
            return View("Register");
        },
        nameTaken => {
            ModelState.AddModelError(nameof(username), "Sorry, that name is already in use.");
            return View("Register");
        }
    );            
}

```
#### As an 'Option' Type

It's simple to use OneOf as an `Option` type - just declare a `OneOf<Something, None>`. OneOf comes with a variety of useful Types in the `OneOf.Types` namespace, including  `Yes`, `No`, `Maybe`, `Unknown`, `True`, `False`, `All`, `Some`, and `None`.



#### Benefits

  - True strongly typed method signature
    - No need to return a custom result base type e.g `IActionResult`, or even worse, a non-descriptive type (e.g. object)   
    - The method signature accurately describes all the potential outcomes, making it easier for consumers to understand the code
    - Method consumer HAS to handle all cases (see 'Matching', below)
  - You can avoid using ["Exceptions for control flow"](http://softwareengineering.stackexchange.com/questions/189222/are-exceptions-as-control-flow-considered-a-serious-antipattern-if-so-why) antipattern by returning custom Typed error objects
  
### As a method parameter value

You can use also use `OneOf` as a parameter type, allowing a caller to pass different types without requiring additional overloads. This might not seem that useful for a single parameter, but if you have multiple parameters, the number of overloads required increases rapidly.

```csharp

public void SetBackground(OneOf<string, ColorName, Color> backgroundColor) { ... }

//The method above can be called with either a string, a ColorName enum value or a Color instance.

```


## Matching

You use the `TOut Match(Func<T0, TOut> f0, ... Func<Tn,TOut> fn)` method to get a value out. Note how the number of handlers matches the number of generic arguments.


### Advantages over `switch` or `if` or `exception` based control flow:

This has a major advantage over a switch statement, as it
  - requires every parameter to be handled
  - No fallback - if you add another generic parameter, you HAVE to update all the calling code to handle your changes.
    In brown-field code-bases this is incredibly useful, as the default handler is often a runtime `throw NotImplementedException`, or behaviour that wouldn't suit the new result type.


E.g.

```csharp
   OneOf<string, ColorName, Color> backgroundColor = ...;
   Color c = backgroundColor.Match(
     str => CssHelper.GetColorFromString(str),
     name => new Color(name),
     col => col 
   );
   _window.BackgroundColor = c;
}

```
There is also a .Switch method, for when you aren't returning a value:

```csharp
   OneOf<string, DateTime> dateValue = ...;
   dateValue.Switch(
     str => AddEntry(DateTime.Parse(str), foo),
     int => AddEntry(int, foo)
   );
   


```

### TryPick𝑥 method

As an alternative to `.Switch` or `.Match` you can use the `.TryPick𝑥` methods.

```csharp
    //TryPick𝑥 methods for OneOf<T0, T1, T2>
    public bool TryPickT0(out T0 value, out OneOf<T1, T2> remainder) { ... } 
    public bool TryPickT1(out T1 value, out OneOf<T0, T2> remainder) { ... } 
    public bool TryPickT2(out T2 value, out OneOf<T0, T1> remainder) { ... } 
```

The return value indicates if the OneOf contains a T𝑥 or not. If so, then `value` will be set to the inner value from the OneOf. If not, then the remainder will be a OneOf of the remaining generic types. You can use them like this:

```csharp

IActionResult Get(string id)
{
	OneOf<Thing, NotFound, Error> thingOrNotFoundOrError = GetThingFromDb(string id);

	if (thingOrNotFoundOrError.TryPickT1(out NotFound notFound, out var thingOrError)) //thingOrError is a OneOf<Thing, Error>
		return StatusCode(404);

	if (thingOrError.TryPickT1(out var error, out var thing)) //note that thing is a Thing rather than a OneOf<Thing>
	{
		_logger.LogError(error.Message);
		return StatusCode(500);
	}

	return Ok(thing);
}

```

### Reusable OneOf Types using OneOfBase

You can declare a OneOf as a Type, by inheriting from `OneOfBase`. 

```csharp
    public abstract class PaymentResult : OneOfBase<PaymentResult.Success, PaymentResult.Declined, PaymentStatus.Failed>
    {
        public class Success : PaymentResult { }  
        public class Declined : PaymentResult { }
        public class Failed  : PaymentResult { public string Reason { get; set; } }
    }
    
    
```
The PaymentResult class will inherit the `.Match` and `.Switch` methods.
