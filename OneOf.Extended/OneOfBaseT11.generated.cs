using System;

namespace OneOf
{
    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IOneOf
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
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> input)
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
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                default: throw new InvalidOperationException();
            }
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
                9 => _value9,
                10 => _value10,
                11 => _value11,
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
        public bool IsT9 => _index == 9;
        public bool IsT10 => _index == 10;
        public bool IsT11 => _index == 11;

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
        public T9 AsT9 =>
            _index == 9 ?
                _value9 :
                throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
        public T10 AsT10 =>
            _index == 10 ?
                _value10 :
                throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
        public T11 AsT11 =>
            _index == 11 ?
                _value11 :
                throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");

        

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11)
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
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11)
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
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            throw new InvalidOperationException();
        }

        

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException());
			return this.IsT11;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other) =>
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
                9 => Equals(_value9, other._value9),
                10 => Equals(_value10, other._value10),
                11 => Equals(_value11, other._value11),
                _ => false
            };

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj)) {
                    return true;
            }

            return obj is OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o && Equals(o);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
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
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
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
