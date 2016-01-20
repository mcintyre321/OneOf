# OneOf

> install-package OneOf


This library provides F# style discriminated unions for C#, using a custom type `OneOf<T0, ... Tn>`. An instance of this type holds a single value, which is one of the types in its generic argument list.

Use cases
---------

You can use this as a parameter type:

```

public void SetBackground(OneOf<string, ColorName, Color> backgroundColor) { ... }

//The method above can be called with either a string or an ColorName enum valyr or a Color instance.


//you could achieve a similar result with overloads, but if you have multiple parameters of different types you would find the number of overloads required would increase very rapidly...

```

Or as a return type:


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

//Typically you would have to make multiple the return types implement a base class or interface and then use casts to access the values.

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


