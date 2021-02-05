using System;

namespace OneOf
{
    public class OneOfBase<T0, T1> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
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

        public void Switch(Action<T0> f0, Action<T1> f1)
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
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out T1 remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0 ? default(T1) : this.AsT1;
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out T0 remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1 ? default(T0) : this.AsT0;
			return this.IsT1;
		}

        bool Equals(OneOfBase<T0, T1> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
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
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }
}
