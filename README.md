# OneOf

> install-package OneOf


This library provides F# style discriminated unions for C#, using a custom type `OneOf<T0, ... Tn>`. An instance of this type holds a single value, which is one of the types in its generic argument list.

Use cases
---------

You can use this as a parameter type:

```

public void SetBackground(OneOf<string, ColorName, Color> backgroundColor) { ... }

//The method above can be called with either a string or an ColorName enum valyr or a Color instance.
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
