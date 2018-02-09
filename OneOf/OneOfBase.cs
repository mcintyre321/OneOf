using System;

namespace OneOf
{
    public class OneOfBase<T0> : IOneOf, IOneOf<T0>
    {
        readonly T0 _value0;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0))
        {
            _index = index;
            _value0 = value0;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
        }

        object IOneOf.Value
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

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0>(T0 t)
        {
             return new OneOfBase<T0>(0, value0: t);
        }

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

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<TResult> otherwise = null)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0>;
            return other != null && Equals(other);
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

    public class OneOfBase<T0, T1> : IOneOf, IOneOf<T0, T1>
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1))
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
        }

        object IOneOf.Value
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

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1>(T0 t)
        {
             return new OneOfBase<T0, T1>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1>(T1 t)
        {
             return new OneOfBase<T0, T1>(1, value1: t);
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

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<TResult> otherwise = null)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1>;
            return other != null && Equals(other);
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

    public class OneOfBase<T0, T1, T2> : IOneOf, IOneOf<T0, T1, T2>
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2))
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2>(T0 t)
        {
             return new OneOfBase<T0, T1, T2>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2>(T1 t)
        {
             return new OneOfBase<T0, T1, T2>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2>(T2 t)
        {
             return new OneOfBase<T0, T1, T2>(2, value2: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2)
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
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2)
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
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<TResult> otherwise = null)
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
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2>;
            return other != null && Equals(other);
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
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3> : IOneOf, IOneOf<T0, T1, T2, T3>
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3))
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3>(3, value3: t);
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

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<TResult> otherwise = null)
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
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3>;
            return other != null && Equals(other);
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

    public class OneOfBase<T0, T1, T2, T3, T4> : IOneOf, IOneOf<T0, T1, T2, T3, T4>
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4))
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4>(4, value4: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4)
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
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4)
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
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<TResult> otherwise = null)
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
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4>;
            return other != null && Equals(other);
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
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5>
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5))
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(5, value5: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5)
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
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5)
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
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<TResult> otherwise = null)
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
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5>;
            return other != null && Equals(other);
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
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6>
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6))
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(6, value6: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6)
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
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6)
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
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<TResult> otherwise = null)
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
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6>;
            return other != null && Equals(other);
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
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7>
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7))
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
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(7, value7: t);
        }

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
            throw new InvalidOperationException();
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
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<TResult> otherwise = null)
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
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>;
            return other != null && Equals(other);
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
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8))
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

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(8, value8: t);
        }

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

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<TResult> otherwise = null)
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
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>;
            return other != null && Equals(other);
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
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9))
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
            _value9 = value9;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(9, value9: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9)
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
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9)
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
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<TResult> otherwise = null)
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
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>;
            return other != null && Equals(other);
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
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10))
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
            _value9 = value9;
            _value10 = value10;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(10, value10: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10)
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
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10)
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
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<TResult> otherwise = null)
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
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>;
            return other != null && Equals(other);
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
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(11, value11: t);
        }

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

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<TResult> otherwise = null)
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
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>;
            return other != null && Equals(other);
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

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
        readonly T12 _value12;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(12, value12: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(13, value13: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(14, value14: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(15, value15: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(16, value16: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(17, value17: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(18, value18: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(19, value19: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(20, value20: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(21, value21: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21), T22 value22 = default(T22))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
            if (this is T22)
            {
                _index = 22;
                _value22 = (T22)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(21, value21: t);
        }

        public bool IsT22
        {
            get { return _index == 22; }
        }

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T22 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(22, value22: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<T22, TResult> f22 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                case 22:
                    return Equals(_value22, other._value22);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21), T22 value22 = default(T22), T23 value23 = default(T23))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
            _value23 = value23;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
            if (this is T22)
            {
                _index = 22;
                _value22 = (T22)(object)this;
                return;
            }
            if (this is T23)
            {
                _index = 23;
                _value23 = (T23)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(21, value21: t);
        }

        public bool IsT22
        {
            get { return _index == 22; }
        }

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T22 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(22, value22: t);
        }

        public bool IsT23
        {
            get { return _index == 23; }
        }

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T23 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(23, value23: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<T22, TResult> f22 = null, Func<T23, TResult> f23 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                case 22:
                    return Equals(_value22, other._value22);
                case 23:
                    return Equals(_value23, other._value23);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21), T22 value22 = default(T22), T23 value23 = default(T23), T24 value24 = default(T24))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
            _value23 = value23;
            _value24 = value24;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
            if (this is T22)
            {
                _index = 22;
                _value22 = (T22)(object)this;
                return;
            }
            if (this is T23)
            {
                _index = 23;
                _value23 = (T23)(object)this;
                return;
            }
            if (this is T24)
            {
                _index = 24;
                _value24 = (T24)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(21, value21: t);
        }

        public bool IsT22
        {
            get { return _index == 22; }
        }

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T22 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(22, value22: t);
        }

        public bool IsT23
        {
            get { return _index == 23; }
        }

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T23 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(23, value23: t);
        }

        public bool IsT24
        {
            get { return _index == 24; }
        }

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T24 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(24, value24: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<T22, TResult> f22 = null, Func<T23, TResult> f23 = null, Func<T24, TResult> f24 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                case 22:
                    return Equals(_value22, other._value22);
                case 23:
                    return Equals(_value23, other._value23);
                case 24:
                    return Equals(_value24, other._value24);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21), T22 value22 = default(T22), T23 value23 = default(T23), T24 value24 = default(T24), T25 value25 = default(T25))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
            _value23 = value23;
            _value24 = value24;
            _value25 = value25;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
            if (this is T22)
            {
                _index = 22;
                _value22 = (T22)(object)this;
                return;
            }
            if (this is T23)
            {
                _index = 23;
                _value23 = (T23)(object)this;
                return;
            }
            if (this is T24)
            {
                _index = 24;
                _value24 = (T24)(object)this;
                return;
            }
            if (this is T25)
            {
                _index = 25;
                _value25 = (T25)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(21, value21: t);
        }

        public bool IsT22
        {
            get { return _index == 22; }
        }

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T22 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(22, value22: t);
        }

        public bool IsT23
        {
            get { return _index == 23; }
        }

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T23 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(23, value23: t);
        }

        public bool IsT24
        {
            get { return _index == 24; }
        }

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T24 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(24, value24: t);
        }

        public bool IsT25
        {
            get { return _index == 25; }
        }

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T25 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(25, value25: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<T22, TResult> f22 = null, Func<T23, TResult> f23 = null, Func<T24, TResult> f24 = null, Func<T25, TResult> f25 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                case 22:
                    return Equals(_value22, other._value22);
                case 23:
                    return Equals(_value23, other._value23);
                case 24:
                    return Equals(_value24, other._value24);
                case 25:
                    return Equals(_value25, other._value25);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21), T22 value22 = default(T22), T23 value23 = default(T23), T24 value24 = default(T24), T25 value25 = default(T25), T26 value26 = default(T26))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
            _value23 = value23;
            _value24 = value24;
            _value25 = value25;
            _value26 = value26;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
            if (this is T22)
            {
                _index = 22;
                _value22 = (T22)(object)this;
                return;
            }
            if (this is T23)
            {
                _index = 23;
                _value23 = (T23)(object)this;
                return;
            }
            if (this is T24)
            {
                _index = 24;
                _value24 = (T24)(object)this;
                return;
            }
            if (this is T25)
            {
                _index = 25;
                _value25 = (T25)(object)this;
                return;
            }
            if (this is T26)
            {
                _index = 26;
                _value26 = (T26)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(21, value21: t);
        }

        public bool IsT22
        {
            get { return _index == 22; }
        }

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T22 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(22, value22: t);
        }

        public bool IsT23
        {
            get { return _index == 23; }
        }

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T23 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(23, value23: t);
        }

        public bool IsT24
        {
            get { return _index == 24; }
        }

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T24 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(24, value24: t);
        }

        public bool IsT25
        {
            get { return _index == 25; }
        }

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T25 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(25, value25: t);
        }

        public bool IsT26
        {
            get { return _index == 26; }
        }

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T26 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(26, value26: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<T22, TResult> f22 = null, Func<T23, TResult> f23 = null, Func<T24, TResult> f24 = null, Func<T25, TResult> f25 = null, Func<T26, TResult> f26 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                case 22:
                    return Equals(_value22, other._value22);
                case 23:
                    return Equals(_value23, other._value23);
                case 24:
                    return Equals(_value24, other._value24);
                case 25:
                    return Equals(_value25, other._value25);
                case 26:
                    return Equals(_value26, other._value26);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21), T22 value22 = default(T22), T23 value23 = default(T23), T24 value24 = default(T24), T25 value25 = default(T25), T26 value26 = default(T26), T27 value27 = default(T27))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
            _value23 = value23;
            _value24 = value24;
            _value25 = value25;
            _value26 = value26;
            _value27 = value27;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
            if (this is T22)
            {
                _index = 22;
                _value22 = (T22)(object)this;
                return;
            }
            if (this is T23)
            {
                _index = 23;
                _value23 = (T23)(object)this;
                return;
            }
            if (this is T24)
            {
                _index = 24;
                _value24 = (T24)(object)this;
                return;
            }
            if (this is T25)
            {
                _index = 25;
                _value25 = (T25)(object)this;
                return;
            }
            if (this is T26)
            {
                _index = 26;
                _value26 = (T26)(object)this;
                return;
            }
            if (this is T27)
            {
                _index = 27;
                _value27 = (T27)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    case 27:
                        return _value27;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(21, value21: t);
        }

        public bool IsT22
        {
            get { return _index == 22; }
        }

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T22 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(22, value22: t);
        }

        public bool IsT23
        {
            get { return _index == 23; }
        }

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T23 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(23, value23: t);
        }

        public bool IsT24
        {
            get { return _index == 24; }
        }

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T24 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(24, value24: t);
        }

        public bool IsT25
        {
            get { return _index == 25; }
        }

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T25 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(25, value25: t);
        }

        public bool IsT26
        {
            get { return _index == 26; }
        }

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T26 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(26, value26: t);
        }

        public bool IsT27
        {
            get { return _index == 27; }
        }

        public T27 AsT27
        {
            get
            {
                if (_index != 27)
                {
                    throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
                }
                return _value27;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T27 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(27, value27: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            if (_index == 27 && f27 != null)
            {
                f27(_value27);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<T22, TResult> f22 = null, Func<T23, TResult> f23 = null, Func<T24, TResult> f24 = null, Func<T25, TResult> f25 = null, Func<T26, TResult> f26 = null, Func<T27, TResult> f27 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                case 22:
                    return Equals(_value22, other._value22);
                case 23:
                    return Equals(_value23, other._value23);
                case 24:
                    return Equals(_value24, other._value24);
                case 25:
                    return Equals(_value25, other._value25);
                case 26:
                    return Equals(_value26, other._value26);
                case 27:
                    return Equals(_value27, other._value27);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    case 27:
                    hashCode = _value27?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly T28 _value28;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21), T22 value22 = default(T22), T23 value23 = default(T23), T24 value24 = default(T24), T25 value25 = default(T25), T26 value26 = default(T26), T27 value27 = default(T27), T28 value28 = default(T28))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
            _value23 = value23;
            _value24 = value24;
            _value25 = value25;
            _value26 = value26;
            _value27 = value27;
            _value28 = value28;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
            if (this is T22)
            {
                _index = 22;
                _value22 = (T22)(object)this;
                return;
            }
            if (this is T23)
            {
                _index = 23;
                _value23 = (T23)(object)this;
                return;
            }
            if (this is T24)
            {
                _index = 24;
                _value24 = (T24)(object)this;
                return;
            }
            if (this is T25)
            {
                _index = 25;
                _value25 = (T25)(object)this;
                return;
            }
            if (this is T26)
            {
                _index = 26;
                _value26 = (T26)(object)this;
                return;
            }
            if (this is T27)
            {
                _index = 27;
                _value27 = (T27)(object)this;
                return;
            }
            if (this is T28)
            {
                _index = 28;
                _value28 = (T28)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    case 27:
                        return _value27;
                    case 28:
                        return _value28;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(21, value21: t);
        }

        public bool IsT22
        {
            get { return _index == 22; }
        }

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T22 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(22, value22: t);
        }

        public bool IsT23
        {
            get { return _index == 23; }
        }

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T23 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(23, value23: t);
        }

        public bool IsT24
        {
            get { return _index == 24; }
        }

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T24 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(24, value24: t);
        }

        public bool IsT25
        {
            get { return _index == 25; }
        }

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T25 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(25, value25: t);
        }

        public bool IsT26
        {
            get { return _index == 26; }
        }

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T26 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(26, value26: t);
        }

        public bool IsT27
        {
            get { return _index == 27; }
        }

        public T27 AsT27
        {
            get
            {
                if (_index != 27)
                {
                    throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
                }
                return _value27;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T27 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(27, value27: t);
        }

        public bool IsT28
        {
            get { return _index == 28; }
        }

        public T28 AsT28
        {
            get
            {
                if (_index != 28)
                {
                    throw new InvalidOperationException($"Cannot return as T28 as result is T{_index}");
                }
                return _value28;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T28 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(28, value28: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27, Action<T28> f28)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            if (_index == 27 && f27 != null)
            {
                f27(_value27);
                return;
            }
            if (_index == 28 && f28 != null)
            {
                f28(_value28);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27, Func<T28, TResult> f28)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<T22, TResult> f22 = null, Func<T23, TResult> f23 = null, Func<T24, TResult> f24 = null, Func<T25, TResult> f25 = null, Func<T26, TResult> f26 = null, Func<T27, TResult> f27 = null, Func<T28, TResult> f28 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                case 22:
                    return Equals(_value22, other._value22);
                case 23:
                    return Equals(_value23, other._value23);
                case 24:
                    return Equals(_value24, other._value24);
                case 25:
                    return Equals(_value25, other._value25);
                case 26:
                    return Equals(_value26, other._value26);
                case 27:
                    return Equals(_value27, other._value27);
                case 28:
                    return Equals(_value28, other._value28);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    case 27:
                    hashCode = _value27?.GetHashCode() ?? 0;
                    break;
                    case 28:
                    hashCode = _value28?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly T28 _value28;
        readonly T29 _value29;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21), T22 value22 = default(T22), T23 value23 = default(T23), T24 value24 = default(T24), T25 value25 = default(T25), T26 value26 = default(T26), T27 value27 = default(T27), T28 value28 = default(T28), T29 value29 = default(T29))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
            _value23 = value23;
            _value24 = value24;
            _value25 = value25;
            _value26 = value26;
            _value27 = value27;
            _value28 = value28;
            _value29 = value29;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
            if (this is T22)
            {
                _index = 22;
                _value22 = (T22)(object)this;
                return;
            }
            if (this is T23)
            {
                _index = 23;
                _value23 = (T23)(object)this;
                return;
            }
            if (this is T24)
            {
                _index = 24;
                _value24 = (T24)(object)this;
                return;
            }
            if (this is T25)
            {
                _index = 25;
                _value25 = (T25)(object)this;
                return;
            }
            if (this is T26)
            {
                _index = 26;
                _value26 = (T26)(object)this;
                return;
            }
            if (this is T27)
            {
                _index = 27;
                _value27 = (T27)(object)this;
                return;
            }
            if (this is T28)
            {
                _index = 28;
                _value28 = (T28)(object)this;
                return;
            }
            if (this is T29)
            {
                _index = 29;
                _value29 = (T29)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    case 27:
                        return _value27;
                    case 28:
                        return _value28;
                    case 29:
                        return _value29;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(21, value21: t);
        }

        public bool IsT22
        {
            get { return _index == 22; }
        }

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T22 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(22, value22: t);
        }

        public bool IsT23
        {
            get { return _index == 23; }
        }

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T23 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(23, value23: t);
        }

        public bool IsT24
        {
            get { return _index == 24; }
        }

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T24 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(24, value24: t);
        }

        public bool IsT25
        {
            get { return _index == 25; }
        }

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T25 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(25, value25: t);
        }

        public bool IsT26
        {
            get { return _index == 26; }
        }

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T26 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(26, value26: t);
        }

        public bool IsT27
        {
            get { return _index == 27; }
        }

        public T27 AsT27
        {
            get
            {
                if (_index != 27)
                {
                    throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
                }
                return _value27;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T27 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(27, value27: t);
        }

        public bool IsT28
        {
            get { return _index == 28; }
        }

        public T28 AsT28
        {
            get
            {
                if (_index != 28)
                {
                    throw new InvalidOperationException($"Cannot return as T28 as result is T{_index}");
                }
                return _value28;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T28 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(28, value28: t);
        }

        public bool IsT29
        {
            get { return _index == 29; }
        }

        public T29 AsT29
        {
            get
            {
                if (_index != 29)
                {
                    throw new InvalidOperationException($"Cannot return as T29 as result is T{_index}");
                }
                return _value29;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T29 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(29, value29: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27, Action<T28> f28, Action<T29> f29)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            if (_index == 27 && f27 != null)
            {
                f27(_value27);
                return;
            }
            if (_index == 28 && f28 != null)
            {
                f28(_value28);
                return;
            }
            if (_index == 29 && f29 != null)
            {
                f29(_value29);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27, Func<T28, TResult> f28, Func<T29, TResult> f29)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            if (_index == 29 && f29 != null)
            {
                return f29(_value29);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<T22, TResult> f22 = null, Func<T23, TResult> f23 = null, Func<T24, TResult> f24 = null, Func<T25, TResult> f25 = null, Func<T26, TResult> f26 = null, Func<T27, TResult> f27 = null, Func<T28, TResult> f28 = null, Func<T29, TResult> f29 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            if (_index == 29 && f29 != null)
            {
                return f29(_value29);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                case 22:
                    return Equals(_value22, other._value22);
                case 23:
                    return Equals(_value23, other._value23);
                case 24:
                    return Equals(_value24, other._value24);
                case 25:
                    return Equals(_value25, other._value25);
                case 26:
                    return Equals(_value26, other._value26);
                case 27:
                    return Equals(_value27, other._value27);
                case 28:
                    return Equals(_value28, other._value28);
                case 29:
                    return Equals(_value29, other._value29);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    case 27:
                    hashCode = _value27?.GetHashCode() ?? 0;
                    break;
                    case 28:
                    hashCode = _value28?.GetHashCode() ?? 0;
                    break;
                    case 29:
                    hashCode = _value29?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly T28 _value28;
        readonly T29 _value29;
        readonly T30 _value30;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21), T22 value22 = default(T22), T23 value23 = default(T23), T24 value24 = default(T24), T25 value25 = default(T25), T26 value26 = default(T26), T27 value27 = default(T27), T28 value28 = default(T28), T29 value29 = default(T29), T30 value30 = default(T30))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
            _value23 = value23;
            _value24 = value24;
            _value25 = value25;
            _value26 = value26;
            _value27 = value27;
            _value28 = value28;
            _value29 = value29;
            _value30 = value30;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
            if (this is T22)
            {
                _index = 22;
                _value22 = (T22)(object)this;
                return;
            }
            if (this is T23)
            {
                _index = 23;
                _value23 = (T23)(object)this;
                return;
            }
            if (this is T24)
            {
                _index = 24;
                _value24 = (T24)(object)this;
                return;
            }
            if (this is T25)
            {
                _index = 25;
                _value25 = (T25)(object)this;
                return;
            }
            if (this is T26)
            {
                _index = 26;
                _value26 = (T26)(object)this;
                return;
            }
            if (this is T27)
            {
                _index = 27;
                _value27 = (T27)(object)this;
                return;
            }
            if (this is T28)
            {
                _index = 28;
                _value28 = (T28)(object)this;
                return;
            }
            if (this is T29)
            {
                _index = 29;
                _value29 = (T29)(object)this;
                return;
            }
            if (this is T30)
            {
                _index = 30;
                _value30 = (T30)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    case 27:
                        return _value27;
                    case 28:
                        return _value28;
                    case 29:
                        return _value29;
                    case 30:
                        return _value30;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(21, value21: t);
        }

        public bool IsT22
        {
            get { return _index == 22; }
        }

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T22 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(22, value22: t);
        }

        public bool IsT23
        {
            get { return _index == 23; }
        }

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T23 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(23, value23: t);
        }

        public bool IsT24
        {
            get { return _index == 24; }
        }

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T24 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(24, value24: t);
        }

        public bool IsT25
        {
            get { return _index == 25; }
        }

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T25 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(25, value25: t);
        }

        public bool IsT26
        {
            get { return _index == 26; }
        }

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T26 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(26, value26: t);
        }

        public bool IsT27
        {
            get { return _index == 27; }
        }

        public T27 AsT27
        {
            get
            {
                if (_index != 27)
                {
                    throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
                }
                return _value27;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T27 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(27, value27: t);
        }

        public bool IsT28
        {
            get { return _index == 28; }
        }

        public T28 AsT28
        {
            get
            {
                if (_index != 28)
                {
                    throw new InvalidOperationException($"Cannot return as T28 as result is T{_index}");
                }
                return _value28;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T28 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(28, value28: t);
        }

        public bool IsT29
        {
            get { return _index == 29; }
        }

        public T29 AsT29
        {
            get
            {
                if (_index != 29)
                {
                    throw new InvalidOperationException($"Cannot return as T29 as result is T{_index}");
                }
                return _value29;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T29 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(29, value29: t);
        }

        public bool IsT30
        {
            get { return _index == 30; }
        }

        public T30 AsT30
        {
            get
            {
                if (_index != 30)
                {
                    throw new InvalidOperationException($"Cannot return as T30 as result is T{_index}");
                }
                return _value30;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T30 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(30, value30: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27, Action<T28> f28, Action<T29> f29, Action<T30> f30)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            if (_index == 27 && f27 != null)
            {
                f27(_value27);
                return;
            }
            if (_index == 28 && f28 != null)
            {
                f28(_value28);
                return;
            }
            if (_index == 29 && f29 != null)
            {
                f29(_value29);
                return;
            }
            if (_index == 30 && f30 != null)
            {
                f30(_value30);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27, Func<T28, TResult> f28, Func<T29, TResult> f29, Func<T30, TResult> f30)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            if (_index == 29 && f29 != null)
            {
                return f29(_value29);
            }
            if (_index == 30 && f30 != null)
            {
                return f30(_value30);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<T22, TResult> f22 = null, Func<T23, TResult> f23 = null, Func<T24, TResult> f24 = null, Func<T25, TResult> f25 = null, Func<T26, TResult> f26 = null, Func<T27, TResult> f27 = null, Func<T28, TResult> f28 = null, Func<T29, TResult> f29 = null, Func<T30, TResult> f30 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            if (_index == 29 && f29 != null)
            {
                return f29(_value29);
            }
            if (_index == 30 && f30 != null)
            {
                return f30(_value30);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                case 22:
                    return Equals(_value22, other._value22);
                case 23:
                    return Equals(_value23, other._value23);
                case 24:
                    return Equals(_value24, other._value24);
                case 25:
                    return Equals(_value25, other._value25);
                case 26:
                    return Equals(_value26, other._value26);
                case 27:
                    return Equals(_value27, other._value27);
                case 28:
                    return Equals(_value28, other._value28);
                case 29:
                    return Equals(_value29, other._value29);
                case 30:
                    return Equals(_value30, other._value30);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    case 27:
                    hashCode = _value27?.GetHashCode() ?? 0;
                    break;
                    case 28:
                    hashCode = _value28?.GetHashCode() ?? 0;
                    break;
                    case 29:
                    hashCode = _value29?.GetHashCode() ?? 0;
                    break;
                    case 30:
                    hashCode = _value30?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> : IOneOf, IOneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>
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
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly T28 _value28;
        readonly T29 _value29;
        readonly T30 _value30;
        readonly T31 _value31;
        readonly int _index;

        protected OneOfBase(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8), T9 value9 = default(T9), T10 value10 = default(T10), T11 value11 = default(T11), T12 value12 = default(T12), T13 value13 = default(T13), T14 value14 = default(T14), T15 value15 = default(T15), T16 value16 = default(T16), T17 value17 = default(T17), T18 value18 = default(T18), T19 value19 = default(T19), T20 value20 = default(T20), T21 value21 = default(T21), T22 value22 = default(T22), T23 value23 = default(T23), T24 value24 = default(T24), T25 value25 = default(T25), T26 value26 = default(T26), T27 value27 = default(T27), T28 value28 = default(T28), T29 value29 = default(T29), T30 value30 = default(T30), T31 value31 = default(T31))
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
            _value9 = value9;
            _value10 = value10;
            _value11 = value11;
            _value12 = value12;
            _value13 = value13;
            _value14 = value14;
            _value15 = value15;
            _value16 = value16;
            _value17 = value17;
            _value18 = value18;
            _value19 = value19;
            _value20 = value20;
            _value21 = value21;
            _value22 = value22;
            _value23 = value23;
            _value24 = value24;
            _value25 = value25;
            _value26 = value26;
            _value27 = value27;
            _value28 = value28;
            _value29 = value29;
            _value30 = value30;
            _value31 = value31;
        }

        protected OneOfBase()
        {
            if (this is T0)
            {
                _index = 0;
                _value0 = (T0)(object)this;
                return;
            }
            if (this is T1)
            {
                _index = 1;
                _value1 = (T1)(object)this;
                return;
            }
            if (this is T2)
            {
                _index = 2;
                _value2 = (T2)(object)this;
                return;
            }
            if (this is T3)
            {
                _index = 3;
                _value3 = (T3)(object)this;
                return;
            }
            if (this is T4)
            {
                _index = 4;
                _value4 = (T4)(object)this;
                return;
            }
            if (this is T5)
            {
                _index = 5;
                _value5 = (T5)(object)this;
                return;
            }
            if (this is T6)
            {
                _index = 6;
                _value6 = (T6)(object)this;
                return;
            }
            if (this is T7)
            {
                _index = 7;
                _value7 = (T7)(object)this;
                return;
            }
            if (this is T8)
            {
                _index = 8;
                _value8 = (T8)(object)this;
                return;
            }
            if (this is T9)
            {
                _index = 9;
                _value9 = (T9)(object)this;
                return;
            }
            if (this is T10)
            {
                _index = 10;
                _value10 = (T10)(object)this;
                return;
            }
            if (this is T11)
            {
                _index = 11;
                _value11 = (T11)(object)this;
                return;
            }
            if (this is T12)
            {
                _index = 12;
                _value12 = (T12)(object)this;
                return;
            }
            if (this is T13)
            {
                _index = 13;
                _value13 = (T13)(object)this;
                return;
            }
            if (this is T14)
            {
                _index = 14;
                _value14 = (T14)(object)this;
                return;
            }
            if (this is T15)
            {
                _index = 15;
                _value15 = (T15)(object)this;
                return;
            }
            if (this is T16)
            {
                _index = 16;
                _value16 = (T16)(object)this;
                return;
            }
            if (this is T17)
            {
                _index = 17;
                _value17 = (T17)(object)this;
                return;
            }
            if (this is T18)
            {
                _index = 18;
                _value18 = (T18)(object)this;
                return;
            }
            if (this is T19)
            {
                _index = 19;
                _value19 = (T19)(object)this;
                return;
            }
            if (this is T20)
            {
                _index = 20;
                _value20 = (T20)(object)this;
                return;
            }
            if (this is T21)
            {
                _index = 21;
                _value21 = (T21)(object)this;
                return;
            }
            if (this is T22)
            {
                _index = 22;
                _value22 = (T22)(object)this;
                return;
            }
            if (this is T23)
            {
                _index = 23;
                _value23 = (T23)(object)this;
                return;
            }
            if (this is T24)
            {
                _index = 24;
                _value24 = (T24)(object)this;
                return;
            }
            if (this is T25)
            {
                _index = 25;
                _value25 = (T25)(object)this;
                return;
            }
            if (this is T26)
            {
                _index = 26;
                _value26 = (T26)(object)this;
                return;
            }
            if (this is T27)
            {
                _index = 27;
                _value27 = (T27)(object)this;
                return;
            }
            if (this is T28)
            {
                _index = 28;
                _value28 = (T28)(object)this;
                return;
            }
            if (this is T29)
            {
                _index = 29;
                _value29 = (T29)(object)this;
                return;
            }
            if (this is T30)
            {
                _index = 30;
                _value30 = (T30)(object)this;
                return;
            }
            if (this is T31)
            {
                _index = 31;
                _value31 = (T31)(object)this;
                return;
            }
        }

        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    case 27:
                        return _value27;
                    case 28:
                        return _value28;
                    case 29:
                        return _value29;
                    case 30:
                        return _value30;
                    case 31:
                        return _value31;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(0, value0: t);
        }

        public bool IsT1
        {
            get { return _index == 1; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(1, value1: t);
        }

        public bool IsT2
        {
            get { return _index == 2; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(2, value2: t);
        }

        public bool IsT3
        {
            get { return _index == 3; }
        }

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

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(3, value3: t);
        }

        public bool IsT4
        {
            get { return _index == 4; }
        }

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(4, value4: t);
        }

        public bool IsT5
        {
            get { return _index == 5; }
        }

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(5, value5: t);
        }

        public bool IsT6
        {
            get { return _index == 6; }
        }

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(6, value6: t);
        }

        public bool IsT7
        {
            get { return _index == 7; }
        }

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(7, value7: t);
        }

        public bool IsT8
        {
            get { return _index == 8; }
        }

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(8, value8: t);
        }

        public bool IsT9
        {
            get { return _index == 9; }
        }

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T9 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(9, value9: t);
        }

        public bool IsT10
        {
            get { return _index == 10; }
        }

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T10 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(10, value10: t);
        }

        public bool IsT11
        {
            get { return _index == 11; }
        }

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T11 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(11, value11: t);
        }

        public bool IsT12
        {
            get { return _index == 12; }
        }

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T12 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(12, value12: t);
        }

        public bool IsT13
        {
            get { return _index == 13; }
        }

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T13 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(13, value13: t);
        }

        public bool IsT14
        {
            get { return _index == 14; }
        }

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T14 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(14, value14: t);
        }

        public bool IsT15
        {
            get { return _index == 15; }
        }

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T15 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(15, value15: t);
        }

        public bool IsT16
        {
            get { return _index == 16; }
        }

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T16 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(16, value16: t);
        }

        public bool IsT17
        {
            get { return _index == 17; }
        }

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T17 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(17, value17: t);
        }

        public bool IsT18
        {
            get { return _index == 18; }
        }

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T18 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(18, value18: t);
        }

        public bool IsT19
        {
            get { return _index == 19; }
        }

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T19 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(19, value19: t);
        }

        public bool IsT20
        {
            get { return _index == 20; }
        }

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T20 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(20, value20: t);
        }

        public bool IsT21
        {
            get { return _index == 21; }
        }

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T21 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(21, value21: t);
        }

        public bool IsT22
        {
            get { return _index == 22; }
        }

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T22 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(22, value22: t);
        }

        public bool IsT23
        {
            get { return _index == 23; }
        }

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T23 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(23, value23: t);
        }

        public bool IsT24
        {
            get { return _index == 24; }
        }

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T24 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(24, value24: t);
        }

        public bool IsT25
        {
            get { return _index == 25; }
        }

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T25 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(25, value25: t);
        }

        public bool IsT26
        {
            get { return _index == 26; }
        }

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T26 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(26, value26: t);
        }

        public bool IsT27
        {
            get { return _index == 27; }
        }

        public T27 AsT27
        {
            get
            {
                if (_index != 27)
                {
                    throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
                }
                return _value27;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T27 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(27, value27: t);
        }

        public bool IsT28
        {
            get { return _index == 28; }
        }

        public T28 AsT28
        {
            get
            {
                if (_index != 28)
                {
                    throw new InvalidOperationException($"Cannot return as T28 as result is T{_index}");
                }
                return _value28;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T28 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(28, value28: t);
        }

        public bool IsT29
        {
            get { return _index == 29; }
        }

        public T29 AsT29
        {
            get
            {
                if (_index != 29)
                {
                    throw new InvalidOperationException($"Cannot return as T29 as result is T{_index}");
                }
                return _value29;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T29 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(29, value29: t);
        }

        public bool IsT30
        {
            get { return _index == 30; }
        }

        public T30 AsT30
        {
            get
            {
                if (_index != 30)
                {
                    throw new InvalidOperationException($"Cannot return as T30 as result is T{_index}");
                }
                return _value30;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T30 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(30, value30: t);
        }

        public bool IsT31
        {
            get { return _index == 31; }
        }

        public T31 AsT31
        {
            get
            {
                if (_index != 31)
                {
                    throw new InvalidOperationException($"Cannot return as T31 as result is T{_index}");
                }
                return _value31;
            }
        }

        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T31 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(31, value31: t);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27, Action<T28> f28, Action<T29> f29, Action<T30> f30, Action<T31> f31)
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
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            if (_index == 27 && f27 != null)
            {
                f27(_value27);
                return;
            }
            if (_index == 28 && f28 != null)
            {
                f28(_value28);
                return;
            }
            if (_index == 29 && f29 != null)
            {
                f29(_value29);
                return;
            }
            if (_index == 30 && f30 != null)
            {
                f30(_value30);
                return;
            }
            if (_index == 31 && f31 != null)
            {
                f31(_value31);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27, Func<T28, TResult> f28, Func<T29, TResult> f29, Func<T30, TResult> f30, Func<T31, TResult> f31)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            if (_index == 29 && f29 != null)
            {
                return f29(_value29);
            }
            if (_index == 30 && f30 != null)
            {
                return f30(_value30);
            }
            if (_index == 31 && f31 != null)
            {
                return f31(_value31);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<T9, TResult> f9 = null, Func<T10, TResult> f10 = null, Func<T11, TResult> f11 = null, Func<T12, TResult> f12 = null, Func<T13, TResult> f13 = null, Func<T14, TResult> f14 = null, Func<T15, TResult> f15 = null, Func<T16, TResult> f16 = null, Func<T17, TResult> f17 = null, Func<T18, TResult> f18 = null, Func<T19, TResult> f19 = null, Func<T20, TResult> f20 = null, Func<T21, TResult> f21 = null, Func<T22, TResult> f22 = null, Func<T23, TResult> f23 = null, Func<T24, TResult> f24 = null, Func<T25, TResult> f25 = null, Func<T26, TResult> f26 = null, Func<T27, TResult> f27 = null, Func<T28, TResult> f28 = null, Func<T29, TResult> f29 = null, Func<T30, TResult> f30 = null, Func<T31, TResult> f31 = null, Func<TResult> otherwise = null)
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
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            if (_index == 29 && f29 != null)
            {
                return f29(_value29);
            }
            if (_index == 30 && f30 != null)
            {
                return f30(_value30);
            }
            if (_index == 31 && f31 != null)
            {
                return f31(_value31);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0:
                    return Equals(_value0, other._value0);
                case 1:
                    return Equals(_value1, other._value1);
                case 2:
                    return Equals(_value2, other._value2);
                case 3:
                    return Equals(_value3, other._value3);
                case 4:
                    return Equals(_value4, other._value4);
                case 5:
                    return Equals(_value5, other._value5);
                case 6:
                    return Equals(_value6, other._value6);
                case 7:
                    return Equals(_value7, other._value7);
                case 8:
                    return Equals(_value8, other._value8);
                case 9:
                    return Equals(_value9, other._value9);
                case 10:
                    return Equals(_value10, other._value10);
                case 11:
                    return Equals(_value11, other._value11);
                case 12:
                    return Equals(_value12, other._value12);
                case 13:
                    return Equals(_value13, other._value13);
                case 14:
                    return Equals(_value14, other._value14);
                case 15:
                    return Equals(_value15, other._value15);
                case 16:
                    return Equals(_value16, other._value16);
                case 17:
                    return Equals(_value17, other._value17);
                case 18:
                    return Equals(_value18, other._value18);
                case 19:
                    return Equals(_value19, other._value19);
                case 20:
                    return Equals(_value20, other._value20);
                case 21:
                    return Equals(_value21, other._value21);
                case 22:
                    return Equals(_value22, other._value22);
                case 23:
                    return Equals(_value23, other._value23);
                case 24:
                    return Equals(_value24, other._value24);
                case 25:
                    return Equals(_value25, other._value25);
                case 26:
                    return Equals(_value26, other._value26);
                case 27:
                    return Equals(_value27, other._value27);
                case 28:
                    return Equals(_value28, other._value28);
                case 29:
                    return Equals(_value29, other._value29);
                case 30:
                    return Equals(_value30, other._value30);
                case 31:
                    return Equals(_value31, other._value31);
                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>;
            return other != null && Equals(other);
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
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    case 27:
                    hashCode = _value27?.GetHashCode() ?? 0;
                    break;
                    case 28:
                    hashCode = _value28?.GetHashCode() ?? 0;
                    break;
                    case 29:
                    hashCode = _value29?.GetHashCode() ?? 0;
                    break;
                    case 30:
                    hashCode = _value30?.GetHashCode() ?? 0;
                    break;
                    case 31:
                    hashCode = _value31?.GetHashCode() ?? 0;
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
