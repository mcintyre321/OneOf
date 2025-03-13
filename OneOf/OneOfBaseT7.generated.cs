#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;
using static OneOf.Functions;

namespace OneOf
{
    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> : IOneOf
    {
        readonly T0 _value0 = default!;
        readonly T1 _value1 = default!;
        readonly T2 _value2 = default!;
        readonly T3 _value3 = default!;
        readonly T4 _value4 = default!;
        readonly T5 _value5 = default!;
        readonly T6 _value6 = default!;
        readonly T7 _value7 = default!;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                default: throw InvalidIndexException(_index);
            }
        }

        public object? Value =>
            _index switch
            {
                0 => _value0,
                1 => _value1,
                2 => _value2,
                3 => _value3,
                4 => _value4,
                5 => _value5,
                6 => _value6,
                7 => _value7,
                _ => throw InvalidIndexException(_index)
            };

        public int Index => _index;

        public bool IsT0 => _index == 0;
        public bool IsT1 => _index == 1;
        public bool IsT2 => _index == 2;
        public bool IsT3 => _index == 3;
        public bool IsT4 => _index == 4;
        public bool IsT5 => _index == 5;
        public bool IsT6 => _index == 6;
        public bool IsT7 => _index == 7;

        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
        public T4 AsT4 =>
            _index == 4 ?
                _value4 :
                throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
        public T5 AsT5 =>
            _index == 5 ?
                _value5 :
                throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
        public T6 AsT6 =>
            _index == 6 ?
                _value6 :
                throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
        public T7 AsT7 =>
            _index == 7 ?
                _value7 :
                throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");

        

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            throw InvalidIndexException(_index);
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            throw InvalidIndexException(_index);
        }

        

        

#if NET
		public bool TryPickT0([NotNullWhen(true)] out T0? value, out OneOf<T1, T2, T3, T4, T5, T6, T7> remainder)
#else
		public bool TryPickT0(out T0? value, out OneOf<T1, T2, T3, T4, T5, T6, T7> remainder)
#endif
		{
			value = IsT0 ? AsT0 : default;
            remainder = _index switch
            {
                0 => default,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                _ => throw InvalidIndexException(_index)
            };
			return this.IsT0;
		}
        
#if NET
		public bool TryPickT1([NotNullWhen(true)] out T1? value, out OneOf<T0, T2, T3, T4, T5, T6, T7> remainder)
#else
		public bool TryPickT1(out T1? value, out OneOf<T0, T2, T3, T4, T5, T6, T7> remainder)
#endif
		{
			value = IsT1 ? AsT1 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => default,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                _ => throw InvalidIndexException(_index)
            };
			return this.IsT1;
		}
        
#if NET
		public bool TryPickT2([NotNullWhen(true)] out T2? value, out OneOf<T0, T1, T3, T4, T5, T6, T7> remainder)
#else
		public bool TryPickT2(out T2? value, out OneOf<T0, T1, T3, T4, T5, T6, T7> remainder)
#endif
		{
			value = IsT2 ? AsT2 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => default,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                _ => throw InvalidIndexException(_index)
            };
			return this.IsT2;
		}
        
#if NET
		public bool TryPickT3([NotNullWhen(true)] out T3? value, out OneOf<T0, T1, T2, T4, T5, T6, T7> remainder)
#else
		public bool TryPickT3(out T3? value, out OneOf<T0, T1, T2, T4, T5, T6, T7> remainder)
#endif
		{
			value = IsT3 ? AsT3 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => default,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                _ => throw InvalidIndexException(_index)
            };
			return this.IsT3;
		}
        
#if NET
		public bool TryPickT4([NotNullWhen(true)] out T4? value, out OneOf<T0, T1, T2, T3, T5, T6, T7> remainder)
#else
		public bool TryPickT4(out T4? value, out OneOf<T0, T1, T2, T3, T5, T6, T7> remainder)
#endif
		{
			value = IsT4 ? AsT4 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => default,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                _ => throw InvalidIndexException(_index)
            };
			return this.IsT4;
		}
        
#if NET
		public bool TryPickT5([NotNullWhen(true)] out T5? value, out OneOf<T0, T1, T2, T3, T4, T6, T7> remainder)
#else
		public bool TryPickT5(out T5? value, out OneOf<T0, T1, T2, T3, T4, T6, T7> remainder)
#endif
		{
			value = IsT5 ? AsT5 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => default,
                6 => AsT6,
                7 => AsT7,
                _ => throw InvalidIndexException(_index)
            };
			return this.IsT5;
		}
        
#if NET
		public bool TryPickT6([NotNullWhen(true)] out T6? value, out OneOf<T0, T1, T2, T3, T4, T5, T7> remainder)
#else
		public bool TryPickT6(out T6? value, out OneOf<T0, T1, T2, T3, T4, T5, T7> remainder)
#endif
		{
			value = IsT6 ? AsT6 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => default,
                7 => AsT7,
                _ => throw InvalidIndexException(_index)
            };
			return this.IsT6;
		}
        
#if NET
		public bool TryPickT7([NotNullWhen(true)] out T7? value, out OneOf<T0, T1, T2, T3, T4, T5, T6> remainder)
#else
		public bool TryPickT7(out T7? value, out OneOf<T0, T1, T2, T3, T4, T5, T6> remainder)
#endif
		{
			value = IsT7 ? AsT7 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => default,
                _ => throw InvalidIndexException(_index)
            };
			return this.IsT7;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> other) =>
            _index == other._index &&
            _index switch
            {
                0 => Equals(_value0, other._value0),
                1 => Equals(_value1, other._value1),
                2 => Equals(_value2, other._value2),
                3 => Equals(_value3, other._value3),
                4 => Equals(_value4, other._value4),
                5 => Equals(_value5, other._value5),
                6 => Equals(_value6, other._value6),
                7 => Equals(_value7, other._value7),
                _ => false
            };

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj)) {
                    return true;
            }

            return obj is OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> o && Equals(o);
        }

        public override string ToString() =>
            _index switch {
                0 => FormatValue(_value0),
                1 => FormatValue(_value1),
                2 => FormatValue(_value2),
                3 => FormatValue(_value3),
                4 => FormatValue(_value4),
                5 => FormatValue(_value5),
                6 => FormatValue(_value6),
                7 => FormatValue(_value7),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = _index switch
                {
                    0 => _value0?.GetHashCode(),
                    1 => _value1?.GetHashCode(),
                    2 => _value2?.GetHashCode(),
                    3 => _value3?.GetHashCode(),
                    4 => _value4?.GetHashCode(),
                    5 => _value5?.GetHashCode(),
                    6 => _value6?.GetHashCode(),
                    7 => _value7?.GetHashCode(),
                    _ => 0
                } ?? 0;
                return (hashCode*397) ^ _index;
            }
        }
    }
}
