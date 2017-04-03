


namespace OneOf.Types
{
    public struct Yes { }
    public struct No { }
    public struct Maybe { }

    public struct Unknown { }
    public struct True { }
    public struct False { }

    public struct All { }
    public struct Some { }
    public struct None { }

    public struct NotFound { }

    public struct Success { }

    public struct Success<T>
    {
        public Success(T value)
        {
            Value = value;
        }
        public T Value { get; }
    }

    public struct Result<T>
    {
        public Result(T value)
        {
            Value = value;
        }
        public T Value { get; }
    }

    public struct Error { }
    public struct Error<T>
    {
        public Error(T value)
        {
            Value = value;
        }
        public T Value { get; }
    }


}
