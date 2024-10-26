using System;
using static OneOf.Functions;
#if NETSTANDARD2_0 || NET40_OR_GREATER
using System.Threading.Tasks;
#endif

namespace OneOf
{
    public readonly struct OneOf<T0> : IOneOf
    {
        readonly T0 _value0;
        readonly int _index;

        OneOf(int index, T0 value0 = default)
        {
            _index = index;
            _value0 = value0;
        }

        public object Value =>
            _index switch
            {
                0 => _value0,
                _ => throw new InvalidOperationException()
            };

        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");

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

#if NETSTANDARD2_0 || NET40_OR_GREATER
        public async Task SwitchAsync(Func<T0,Task> f0)
        {
            if (_index == 0 && f0 != null)
            {
                await f0(_value0);
                return;
            }
            throw new InvalidOperationException();
        }
#endif

        public TResult Match<TResult>(Func<T0, TResult> f0)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            throw new InvalidOperationException();
        }

#if NETSTANDARD2_0 || NET40_OR_GREATER
        public async Task<TResult> MatchAsync<TResult>(Func<T0, Task<TResult>> f0)
        {
            if (_index == 0 && f0 != null)
            {
                return await f0(_value0);
            }
            throw new InvalidOperationException();
        }
#endif

        public static OneOf<T0> FromT0(T0 input) => input;

        
        public OneOf<TResult> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => mapFunc(AsT0),
                _ => throw new InvalidOperationException()
            };
        }

#if NETSTANDARD2_0 || NET40_OR_GREATER
        public async Task<OneOf<TResult>> MapT0Async<TResult>(Func<T0, Task<TResult>> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => await mapFunc(AsT0),
                _ => throw new InvalidOperationException()
            };
        }
#endif

        bool Equals(OneOf<T0> other) =>
            _index == other._index &&
            _index switch
            {
                0 => Equals(_value0, other._value0),
                _ => false
            };

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0> o && Equals(o);
        }

        public override string ToString() =>
            _index switch {
                0 => FormatValue(_value0),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = _index switch
                {
                    0 => _value0?.GetHashCode(),
                    _ => 0
                } ?? 0;
                return (hashCode*397) ^ _index;
            }
        }
    }
}
