using System;

namespace OneOf
{
    public class OneOfBase<T0, T1, T2, T3> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
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
                _ => throw new InvalidOperationException()
            };

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
        
        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }
        
        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }
        
        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }
        
        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3)
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
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3)
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
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3>) 
				: this.Match<OneOf<T1, T2, T3>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3>) 
				: this.Match<OneOf<T0, T2, T3>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3>) 
				: this.Match<OneOf<T0, T1, T3>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2>) 
				: this.Match<OneOf<T0, T1, T2>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException());
			return this.IsT3;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;


            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
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
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }
}
