# OneOf

> install-package OneOf


This library provides F# style discriminated unions for C#, using a custom type `OneOf<T0, ... Tn>`. An instance of this type holds a single value, which is one of the types in its generic argument list.

Use cases
---------

You can use this as a parameter type, allowing a caller to pass different types without requiring additional overloads. This might not seem that useful for a single parameter, but if you have multiple parameters, the numer of overloads required increases rapidly.

```

public void SetBackground(OneOf<string, ColorName, Color> backgroundColor) { ... }

//The method above can be called with either a string, a ColorName enum value or a Color instance.


```
Or as a return type, giving the ability to return strongly typed results without having to implement a type with a common base type or interface:

```
public OneOf<User, InvalidName, NameTaken> CreateUser(string username)
{
    if (IsValid(username)) return new InvalidName();
    var user = _repo.FindByUsername(username);
    if(user != null) return new NameTaken();
    var user = new User(username);
    _repo.Save(user);
    return user;
}

```

Matching
--------

You use the `TOut Match(Func<T0, TOut> f0, ... Func<Tn,TOut> fn)` method to get a value out. E.g.

```
public void SetBackground(OneOf<string, ColorName, Color> backgroundColor) {
   Color c = backgroundColor.Match(
     str => CssHelper.GetColorFromString(str),
     name => new Color(name),
     col => col
   );
   _window.BackgroundColor = c;
}
```


