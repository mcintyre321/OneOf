# OneOf

> "Ah! It's like a compile time checked switch statement!" - Mike Giorgaras

## Getting Started

> install-package OneOf


This library provides F# style discriminated unions for C#, using a custom type `OneOf<T0, ... Tn>`. An instance of this type holds a single value, which is one of the types in its generic argument list.

I can't encourage you enough to give it a try! Due to exhaustive matching DUs provide an alternative to polymorphism when you want to have a method with guaranteed behaviour-per-type (i.e. adding an abstract method on a base type, and then implementing that method in each type). It's a really powerful tool, ask any f#/Scala dev! :)

## Use cases


### As a method return value

The most frequent use case is as a return value, when you need to return different results from a method. Here's how you might use it in an MVC controller action:

```
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

#### Benefits

  - True strongly typed method signature
    - No need to return a custom result base type e.g `IActionResult`, or even worse, a non-descriptive type (e.g. object)   
    - The method signature accurately describes all the potential outcomes, making it easier for consumers to understand the code
    - Method consumer HAS to handle all cases (see 'Matching', below)
  - You can avoid using ["Exceptions for control flow"](http://softwareengineering.stackexchange.com/questions/189222/are-exceptions-as-control-flow-considered-a-serious-antipattern-if-so-why) antipattern by returning custom Typed error objects
  
### As a method parameter value

You can use also use `OneOf` as a parameter type, allowing a caller to pass different types without requiring additional overloads. This might not seem that useful for a single parameter, but if you have multiple parameters, the numer of overloads required increases rapidly.

```

public void SetBackground(OneOf<string, ColorName, Color> backgroundColor) { ... }

//The method above can be called with either a string, a ColorName enum value or a Color instance.


```


Matching
##

You use the `TOut Match(Func<T0, TOut> f0, ... Func<Tn,TOut> fn)` method to get a value out. 


### Advantages over `switch` or `if`:

This has a major advantage over a switch statement, as it
  - requires every case to be handled
  - No fallback - if you extend a methods return types, you HAVE to update all the calling code to handle your changes.
    In brown-field code-bases this is incredibly useful, as the default handler is often a runtime `throw NotImplementedException`, or behaviour that wouldn't suit the new result type.


E.g.

```
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

```
   OneOf<string, DateTime> dateValue = ...;
   dateValue.Switch(
     str => AddEntry(DateTime.Parse(str), foo),
     int => AddEntry(int, foo)
   );
   
}

