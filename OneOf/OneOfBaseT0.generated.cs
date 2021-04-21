using System;
using static OneOf.Functions;

namespace OneOf
{
    public class OneOfBase<T0> : IOneOf
    {
        readonly T0 _value0;
        readonly int _index;

        protected OneOfBase(OneOf<T0> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                default: throw new InvalidOperationException();
            }
        }

    public object Value { get {
                    switch (_index)
                    {
                            case 0: return _value0;
                            default: throw new InvalidOperationException();
                        };
                } }

        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");

        

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

        

        

        bool Equals(OneOfBase<T0> other) {
            var check1 = _index == other._index;
            if (!check1) { return false; }
            switch (_index)
            {
                case 0: return check1 && Equals(_value0, other._value0);
                default: return false;
            };
                             }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj)) {
                    return true;
            }

            return obj is OneOfBase<T0> o && Equals(o);
        }

        public override string ToString() {
            switch (_index) {
                case 0: return FormatValue(_value0);
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
                    case 0: { hashCode = _value0?.GetHashCode() ?? 0; break; }
                    default: { hashCode = 0; break; }
                }
                return (hashCode*397) ^ _index;
            }
        }
    }
}
