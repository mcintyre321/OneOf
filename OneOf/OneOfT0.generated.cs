using System;

namespace OneOf
{
    public struct OneOf<T0> : IOneOf
    {
        readonly T0 _value0;
        readonly int _index;

        OneOf(int index, T0 value0 = default(T0))
        {
            _index = index;
            _value0 = value0;
        }

        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public static implicit operator OneOf<T0>(T0 t) => new OneOf<T0>(0, value0: t);

        public void Switch(Action<T0> f0)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0> FromT0(T0 input)
        {
            return input;
        }

        public OneOf<TResult> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult>>(
                input0 => mapFunc(input0)
            );
        }

        bool Equals(OneOf<T0> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            return obj is OneOf<T0> && Equals((OneOf<T0>)obj);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }
}