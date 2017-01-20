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
        
        public static implicit operator OneOf<T0>(T0 t)
        {
             return new OneOf<T0>(0, value0: t);
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

        bool Equals(OneOf<T0> other)
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

            return obj is OneOf<T0> && Equals((OneOf<T0>)obj);
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

    public struct OneOf<T0, T1> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly int _index;
    
        OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1))
        { 
            _index = index;
            _value0 = value0;
            _value1 = value1;
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
        
        public static implicit operator OneOf<T0, T1>(T0 t)
        {
             return new OneOf<T0, T1>(0, value0: t);
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
        
        public static implicit operator OneOf<T0, T1>(T1 t)
        {
             return new OneOf<T0, T1>(1, value1: t);
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

        bool Equals(OneOf<T0, T1> other)
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

            return obj is OneOf<T0, T1> && Equals((OneOf<T0, T1>)obj);
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

    public struct OneOf<T0, T1, T2> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly int _index;
    
        OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2))
        { 
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
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
        
        public static implicit operator OneOf<T0, T1, T2>(T0 t)
        {
             return new OneOf<T0, T1, T2>(0, value0: t);
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
        
        public static implicit operator OneOf<T0, T1, T2>(T1 t)
        {
             return new OneOf<T0, T1, T2>(1, value1: t);
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
        
        public static implicit operator OneOf<T0, T1, T2>(T2 t)
        {
             return new OneOf<T0, T1, T2>(2, value2: t);
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

        bool Equals(OneOf<T0, T1, T2> other)
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

            return obj is OneOf<T0, T1, T2> && Equals((OneOf<T0, T1, T2>)obj);
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

    public struct OneOf<T0, T1, T2, T3> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly int _index;
    
        OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3))
        { 
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
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
        
        public static implicit operator OneOf<T0, T1, T2, T3>(T0 t)
        {
             return new OneOf<T0, T1, T2, T3>(0, value0: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3>(T1 t)
        {
             return new OneOf<T0, T1, T2, T3>(1, value1: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3>(T2 t)
        {
             return new OneOf<T0, T1, T2, T3>(2, value2: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3>(T3 t)
        {
             return new OneOf<T0, T1, T2, T3>(3, value3: t);
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

        bool Equals(OneOf<T0, T1, T2, T3> other)
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

            return obj is OneOf<T0, T1, T2, T3> && Equals((OneOf<T0, T1, T2, T3>)obj);
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

    public struct OneOf<T0, T1, T2, T3, T4> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly int _index;
    
        OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4))
        { 
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T0 t)
        {
             return new OneOf<T0, T1, T2, T3, T4>(0, value0: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T1 t)
        {
             return new OneOf<T0, T1, T2, T3, T4>(1, value1: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T2 t)
        {
             return new OneOf<T0, T1, T2, T3, T4>(2, value2: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T3 t)
        {
             return new OneOf<T0, T1, T2, T3, T4>(3, value3: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T4 t)
        {
             return new OneOf<T0, T1, T2, T3, T4>(4, value4: t);
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

        bool Equals(OneOf<T0, T1, T2, T3, T4> other)
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

            return obj is OneOf<T0, T1, T2, T3, T4> && Equals((OneOf<T0, T1, T2, T3, T4>)obj);
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

    public struct OneOf<T0, T1, T2, T3, T4, T5> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly int _index;
    
        OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5))
        { 
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T0 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5>(0, value0: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T1 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5>(1, value1: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T2 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5>(2, value2: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T3 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5>(3, value3: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T4 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5>(4, value4: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T5 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5>(5, value5: t);
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

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5> other)
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

            return obj is OneOf<T0, T1, T2, T3, T4, T5> && Equals((OneOf<T0, T1, T2, T3, T4, T5>)obj);
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

    public struct OneOf<T0, T1, T2, T3, T4, T5, T6> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly int _index;
    
        OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6))
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T0 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6>(0, value0: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T1 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6>(1, value1: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T2 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6>(2, value2: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T3 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6>(3, value3: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T4 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6>(4, value4: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T5 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6>(5, value5: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T6 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6>(6, value6: t);
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

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6> other)
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

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6>)obj);
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

    public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7> : IOneOf
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
    
        OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7))
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T0 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(0, value0: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T1 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(1, value1: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T2 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(2, value2: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T3 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(3, value3: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T4 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(4, value4: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T5 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(5, value5: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T6 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(6, value6: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T7 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(7, value7: t);
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

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7> other)
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

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7>)obj);
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
    
        OneOf(int index, T0 value0 = default(T0), T1 value1 = default(T1), T2 value2 = default(T2), T3 value3 = default(T3), T4 value4 = default(T4), T5 value5 = default(T5), T6 value6 = default(T6), T7 value7 = default(T7), T8 value8 = default(T8))
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(0, value0: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(1, value1: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(2, value2: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(3, value3: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(4, value4: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(5, value5: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(6, value6: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(7, value7: t);
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
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T8 t)
        {
             return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(8, value8: t);
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

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> other)
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

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>)obj);
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
}
