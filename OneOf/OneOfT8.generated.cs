using System;
using static OneOf.Functions;

namespace OneOf
{
    public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly int _index;

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default, T6 value6 = default, T7 value7 = default, T8 value8 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _value7 = value7;
            _value8 = value8;
        }

        public object Value =>
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
                8 => _value8,
                _ => throw new InvalidOperationException()
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
        public bool IsT8 => _index == 8;

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
        public T8 AsT8 =>
            _index == 8 ?
                _value8 :
                throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(0, value0: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(1, value1: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(2, value2: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(3, value3: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(4, value4: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(5, value5: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(6, value6: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(7, value7: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T8 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(8, value8: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8)
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
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8)
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
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT3(T3 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT4(T4 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT5(T5 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT6(T6 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT7(T7 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT8(T8 input) => input;

        public OneOf<TResult, T1, T2, T3, T4, T5, T6, T7, T8> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult, T1, T2, T3, T4, T5, T6, T7, T8>>(
                input0 => mapFunc(input0),
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8
            );
        }
        
        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7, T8> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, TResult, T2, T3, T4, T5, T6, T7, T8>>(
                input0 => input0,
                input1 => mapFunc(input1),
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8
            );
        }
        
        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7, T8> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, TResult, T3, T4, T5, T6, T7, T8>>(
                input0 => input0,
                input1 => input1,
                input2 => mapFunc(input2),
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8
            );
        }
        
        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7, T8> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, TResult, T4, T5, T6, T7, T8>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => mapFunc(input3),
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8
            );
        }
        
        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7, T8> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, TResult, T5, T6, T7, T8>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => mapFunc(input4),
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => input8
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7, T8> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, TResult, T6, T7, T8>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => mapFunc(input5),
                input6 => input6,
                input7 => input7,
                input8 => input8
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7, T8> MapT6<TResult>(Func<T6, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, TResult, T7, T8>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => mapFunc(input6),
                input7 => input7,
                input8 => input8
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult, T8> MapT7<TResult>(Func<T7, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, TResult, T8>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => mapFunc(input7),
                input8 => input8
            );
        }
        
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, TResult> MapT8<TResult>(Func<T8, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, TResult>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7,
                input8 => mapFunc(input8)
            );
        }
        
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException());
			return this.IsT8;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> other) =>
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
                8 => Equals(_value8, other._value8),
                _ => false
            };

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> o && Equals(o);
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
                8 => FormatValue(_value8),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };

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
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
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
