using System;

namespace OneOf
{
    public class OneOfBase<T0> : IOneOf
    {
        readonly object _value;
        readonly int _index;
        
        OneOfBase(object value, int index)
        {
            _value = value; 
            _index = index;
        }

        protected OneOfBase()
        {
            _value = this;

            if (this is T0)
            {
                _index = 0;
            }
        }

        object IOneOf.Value 
        {
            get { return _value; }
        }
    
        T Get<T>(int index)
        {
            if (index != _index)
            {
                throw new InvalidOperationException($"Cannot return as T{index} as result is T{_index}");
            }
            return (T)_value;
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }
        
        public T0 AsT0
        {
            get { return Get<T0>(0); }
        }
        
        public static implicit operator OneOfBase<T0> (T0 t)
        {
             return new OneOfBase<T0>(t, 0);
        }

        public void Switch(Action<T0> f0)
        {
            if (IsT0 && f0 != null)
            {
                f0(AsT0);
                return; 
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0> other)
        {
            return _index == other._index && Equals(_value, other._value);
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
                return ((_value?.GetHashCode() ?? 0)*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1> : IOneOf
    {
        readonly object _value;
        readonly int _index;
        
        OneOfBase(object value, int index)
        {
            _value = value; 
            _index = index;
        }

        protected OneOfBase()
        {
            _value = this;

            if (this is T0)
            {
                _index = 0;
            }

            if (this is T1)
            {
                _index = 1;
            }
        }

        object IOneOf.Value 
        {
            get { return _value; }
        }
    
        T Get<T>(int index)
        {
            if (index != _index)
            {
                throw new InvalidOperationException($"Cannot return as T{index} as result is T{_index}");
            }
            return (T)_value;
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }
        
        public T0 AsT0
        {
            get { return Get<T0>(0); }
        }
        
        public static implicit operator OneOfBase<T0, T1> (T0 t)
        {
             return new OneOfBase<T0, T1>(t, 0);
        }


        public bool IsT1
        {
            get { return _index == 1; }
        }
        
        public T1 AsT1
        {
            get { return Get<T1>(1); }
        }
        
        public static implicit operator OneOfBase<T0, T1> (T1 t)
        {
             return new OneOfBase<T0, T1>(t, 1);
        }

        public void Switch(Action<T0> f0, Action<T1> f1)
        {
            if (IsT0 && f0 != null)
            {
                f0(AsT0);
                return; 
            }
            if (IsT1 && f1 != null)
            {
                f1(AsT1);
                return; 
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1> other)
        {
            return _index == other._index && Equals(_value, other._value);
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
                return ((_value?.GetHashCode() ?? 0)*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2> : IOneOf
    {
        readonly object _value;
        readonly int _index;
        
        OneOfBase(object value, int index)
        {
            _value = value; 
            _index = index;
        }

        protected OneOfBase()
        {
            _value = this;

            if (this is T0)
            {
                _index = 0;
            }

            if (this is T1)
            {
                _index = 1;
            }

            if (this is T2)
            {
                _index = 2;
            }
        }

        object IOneOf.Value 
        {
            get { return _value; }
        }
    
        T Get<T>(int index)
        {
            if (index != _index)
            {
                throw new InvalidOperationException($"Cannot return as T{index} as result is T{_index}");
            }
            return (T)_value;
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }
        
        public T0 AsT0
        {
            get { return Get<T0>(0); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2> (T0 t)
        {
             return new OneOfBase<T0, T1, T2>(t, 0);
        }


        public bool IsT1
        {
            get { return _index == 1; }
        }
        
        public T1 AsT1
        {
            get { return Get<T1>(1); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2> (T1 t)
        {
             return new OneOfBase<T0, T1, T2>(t, 1);
        }


        public bool IsT2
        {
            get { return _index == 2; }
        }
        
        public T2 AsT2
        {
            get { return Get<T2>(2); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2> (T2 t)
        {
             return new OneOfBase<T0, T1, T2>(t, 2);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2)
        {
            if (IsT0 && f0 != null)
            {
                f0(AsT0);
                return; 
            }
            if (IsT1 && f1 != null)
            {
                f1(AsT1);
                return; 
            }
            if (IsT2 && f2 != null)
            {
                f2(AsT2);
                return; 
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2> other)
        {
            return _index == other._index && Equals(_value, other._value);
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
                return ((_value?.GetHashCode() ?? 0)*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3> : IOneOf
    {
        readonly object _value;
        readonly int _index;
        
        OneOfBase(object value, int index)
        {
            _value = value; 
            _index = index;
        }

        protected OneOfBase()
        {
            _value = this;

            if (this is T0)
            {
                _index = 0;
            }

            if (this is T1)
            {
                _index = 1;
            }

            if (this is T2)
            {
                _index = 2;
            }

            if (this is T3)
            {
                _index = 3;
            }
        }

        object IOneOf.Value 
        {
            get { return _value; }
        }
    
        T Get<T>(int index)
        {
            if (index != _index)
            {
                throw new InvalidOperationException($"Cannot return as T{index} as result is T{_index}");
            }
            return (T)_value;
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }
        
        public T0 AsT0
        {
            get { return Get<T0>(0); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3> (T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3>(t, 0);
        }


        public bool IsT1
        {
            get { return _index == 1; }
        }
        
        public T1 AsT1
        {
            get { return Get<T1>(1); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3> (T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3>(t, 1);
        }


        public bool IsT2
        {
            get { return _index == 2; }
        }
        
        public T2 AsT2
        {
            get { return Get<T2>(2); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3> (T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3>(t, 2);
        }


        public bool IsT3
        {
            get { return _index == 3; }
        }
        
        public T3 AsT3
        {
            get { return Get<T3>(3); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3> (T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3>(t, 3);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3)
        {
            if (IsT0 && f0 != null)
            {
                f0(AsT0);
                return; 
            }
            if (IsT1 && f1 != null)
            {
                f1(AsT1);
                return; 
            }
            if (IsT2 && f2 != null)
            {
                f2(AsT2);
                return; 
            }
            if (IsT3 && f3 != null)
            {
                f3(AsT3);
                return; 
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3> other)
        {
            return _index == other._index && Equals(_value, other._value);
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
                return ((_value?.GetHashCode() ?? 0)*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4> : IOneOf
    {
        readonly object _value;
        readonly int _index;
        
        OneOfBase(object value, int index)
        {
            _value = value; 
            _index = index;
        }

        protected OneOfBase()
        {
            _value = this;

            if (this is T0)
            {
                _index = 0;
            }

            if (this is T1)
            {
                _index = 1;
            }

            if (this is T2)
            {
                _index = 2;
            }

            if (this is T3)
            {
                _index = 3;
            }

            if (this is T4)
            {
                _index = 4;
            }
        }

        object IOneOf.Value 
        {
            get { return _value; }
        }
    
        T Get<T>(int index)
        {
            if (index != _index)
            {
                throw new InvalidOperationException($"Cannot return as T{index} as result is T{_index}");
            }
            return (T)_value;
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }
        
        public T0 AsT0
        {
            get { return Get<T0>(0); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4> (T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4>(t, 0);
        }


        public bool IsT1
        {
            get { return _index == 1; }
        }
        
        public T1 AsT1
        {
            get { return Get<T1>(1); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4> (T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4>(t, 1);
        }


        public bool IsT2
        {
            get { return _index == 2; }
        }
        
        public T2 AsT2
        {
            get { return Get<T2>(2); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4> (T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4>(t, 2);
        }


        public bool IsT3
        {
            get { return _index == 3; }
        }
        
        public T3 AsT3
        {
            get { return Get<T3>(3); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4> (T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4>(t, 3);
        }


        public bool IsT4
        {
            get { return _index == 4; }
        }
        
        public T4 AsT4
        {
            get { return Get<T4>(4); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4> (T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4>(t, 4);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4)
        {
            if (IsT0 && f0 != null)
            {
                f0(AsT0);
                return; 
            }
            if (IsT1 && f1 != null)
            {
                f1(AsT1);
                return; 
            }
            if (IsT2 && f2 != null)
            {
                f2(AsT2);
                return; 
            }
            if (IsT3 && f3 != null)
            {
                f3(AsT3);
                return; 
            }
            if (IsT4 && f4 != null)
            {
                f4(AsT4);
                return; 
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (IsT4 && f4 != null)
            {
                return f4(AsT4);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (IsT4 && f4 != null)
            {
                return f4(AsT4);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4> other)
        {
            return _index == other._index && Equals(_value, other._value);
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
                return ((_value?.GetHashCode() ?? 0)*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5> : IOneOf
    {
        readonly object _value;
        readonly int _index;
        
        OneOfBase(object value, int index)
        {
            _value = value; 
            _index = index;
        }

        protected OneOfBase()
        {
            _value = this;

            if (this is T0)
            {
                _index = 0;
            }

            if (this is T1)
            {
                _index = 1;
            }

            if (this is T2)
            {
                _index = 2;
            }

            if (this is T3)
            {
                _index = 3;
            }

            if (this is T4)
            {
                _index = 4;
            }

            if (this is T5)
            {
                _index = 5;
            }
        }

        object IOneOf.Value 
        {
            get { return _value; }
        }
    
        T Get<T>(int index)
        {
            if (index != _index)
            {
                throw new InvalidOperationException($"Cannot return as T{index} as result is T{_index}");
            }
            return (T)_value;
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }
        
        public T0 AsT0
        {
            get { return Get<T0>(0); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(t, 0);
        }


        public bool IsT1
        {
            get { return _index == 1; }
        }
        
        public T1 AsT1
        {
            get { return Get<T1>(1); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(t, 1);
        }


        public bool IsT2
        {
            get { return _index == 2; }
        }
        
        public T2 AsT2
        {
            get { return Get<T2>(2); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(t, 2);
        }


        public bool IsT3
        {
            get { return _index == 3; }
        }
        
        public T3 AsT3
        {
            get { return Get<T3>(3); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(t, 3);
        }


        public bool IsT4
        {
            get { return _index == 4; }
        }
        
        public T4 AsT4
        {
            get { return Get<T4>(4); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(t, 4);
        }


        public bool IsT5
        {
            get { return _index == 5; }
        }
        
        public T5 AsT5
        {
            get { return Get<T5>(5); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5> (T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5>(t, 5);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5)
        {
            if (IsT0 && f0 != null)
            {
                f0(AsT0);
                return; 
            }
            if (IsT1 && f1 != null)
            {
                f1(AsT1);
                return; 
            }
            if (IsT2 && f2 != null)
            {
                f2(AsT2);
                return; 
            }
            if (IsT3 && f3 != null)
            {
                f3(AsT3);
                return; 
            }
            if (IsT4 && f4 != null)
            {
                f4(AsT4);
                return; 
            }
            if (IsT5 && f5 != null)
            {
                f5(AsT5);
                return; 
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (IsT4 && f4 != null)
            {
                return f4(AsT4);
            }
            if (IsT5 && f5 != null)
            {
                return f5(AsT5);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (IsT4 && f4 != null)
            {
                return f4(AsT4);
            }
            if (IsT5 && f5 != null)
            {
                return f5(AsT5);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5> other)
        {
            return _index == other._index && Equals(_value, other._value);
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
                return ((_value?.GetHashCode() ?? 0)*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6> : IOneOf
    {
        readonly object _value;
        readonly int _index;
        
        OneOfBase(object value, int index)
        {
            _value = value; 
            _index = index;
        }

        protected OneOfBase()
        {
            _value = this;

            if (this is T0)
            {
                _index = 0;
            }

            if (this is T1)
            {
                _index = 1;
            }

            if (this is T2)
            {
                _index = 2;
            }

            if (this is T3)
            {
                _index = 3;
            }

            if (this is T4)
            {
                _index = 4;
            }

            if (this is T5)
            {
                _index = 5;
            }

            if (this is T6)
            {
                _index = 6;
            }
        }

        object IOneOf.Value 
        {
            get { return _value; }
        }
    
        T Get<T>(int index)
        {
            if (index != _index)
            {
                throw new InvalidOperationException($"Cannot return as T{index} as result is T{_index}");
            }
            return (T)_value;
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }
        
        public T0 AsT0
        {
            get { return Get<T0>(0); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(t, 0);
        }


        public bool IsT1
        {
            get { return _index == 1; }
        }
        
        public T1 AsT1
        {
            get { return Get<T1>(1); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(t, 1);
        }


        public bool IsT2
        {
            get { return _index == 2; }
        }
        
        public T2 AsT2
        {
            get { return Get<T2>(2); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(t, 2);
        }


        public bool IsT3
        {
            get { return _index == 3; }
        }
        
        public T3 AsT3
        {
            get { return Get<T3>(3); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(t, 3);
        }


        public bool IsT4
        {
            get { return _index == 4; }
        }
        
        public T4 AsT4
        {
            get { return Get<T4>(4); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(t, 4);
        }


        public bool IsT5
        {
            get { return _index == 5; }
        }
        
        public T5 AsT5
        {
            get { return Get<T5>(5); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(t, 5);
        }


        public bool IsT6
        {
            get { return _index == 6; }
        }
        
        public T6 AsT6
        {
            get { return Get<T6>(6); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6> (T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6>(t, 6);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6)
        {
            if (IsT0 && f0 != null)
            {
                f0(AsT0);
                return; 
            }
            if (IsT1 && f1 != null)
            {
                f1(AsT1);
                return; 
            }
            if (IsT2 && f2 != null)
            {
                f2(AsT2);
                return; 
            }
            if (IsT3 && f3 != null)
            {
                f3(AsT3);
                return; 
            }
            if (IsT4 && f4 != null)
            {
                f4(AsT4);
                return; 
            }
            if (IsT5 && f5 != null)
            {
                f5(AsT5);
                return; 
            }
            if (IsT6 && f6 != null)
            {
                f6(AsT6);
                return; 
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (IsT4 && f4 != null)
            {
                return f4(AsT4);
            }
            if (IsT5 && f5 != null)
            {
                return f5(AsT5);
            }
            if (IsT6 && f6 != null)
            {
                return f6(AsT6);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (IsT4 && f4 != null)
            {
                return f4(AsT4);
            }
            if (IsT5 && f5 != null)
            {
                return f5(AsT5);
            }
            if (IsT6 && f6 != null)
            {
                return f6(AsT6);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6> other)
        {
            return _index == other._index && Equals(_value, other._value);
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
                return ((_value?.GetHashCode() ?? 0)*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> : IOneOf
    {
        readonly object _value;
        readonly int _index;
        
        OneOfBase(object value, int index)
        {
            _value = value; 
            _index = index;
        }

        protected OneOfBase()
        {
            _value = this;

            if (this is T0)
            {
                _index = 0;
            }

            if (this is T1)
            {
                _index = 1;
            }

            if (this is T2)
            {
                _index = 2;
            }

            if (this is T3)
            {
                _index = 3;
            }

            if (this is T4)
            {
                _index = 4;
            }

            if (this is T5)
            {
                _index = 5;
            }

            if (this is T6)
            {
                _index = 6;
            }

            if (this is T7)
            {
                _index = 7;
            }
        }

        object IOneOf.Value 
        {
            get { return _value; }
        }
    
        T Get<T>(int index)
        {
            if (index != _index)
            {
                throw new InvalidOperationException($"Cannot return as T{index} as result is T{_index}");
            }
            return (T)_value;
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }
        
        public T0 AsT0
        {
            get { return Get<T0>(0); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(t, 0);
        }


        public bool IsT1
        {
            get { return _index == 1; }
        }
        
        public T1 AsT1
        {
            get { return Get<T1>(1); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(t, 1);
        }


        public bool IsT2
        {
            get { return _index == 2; }
        }
        
        public T2 AsT2
        {
            get { return Get<T2>(2); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(t, 2);
        }


        public bool IsT3
        {
            get { return _index == 3; }
        }
        
        public T3 AsT3
        {
            get { return Get<T3>(3); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(t, 3);
        }


        public bool IsT4
        {
            get { return _index == 4; }
        }
        
        public T4 AsT4
        {
            get { return Get<T4>(4); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(t, 4);
        }


        public bool IsT5
        {
            get { return _index == 5; }
        }
        
        public T5 AsT5
        {
            get { return Get<T5>(5); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(t, 5);
        }


        public bool IsT6
        {
            get { return _index == 6; }
        }
        
        public T6 AsT6
        {
            get { return Get<T6>(6); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(t, 6);
        }


        public bool IsT7
        {
            get { return _index == 7; }
        }
        
        public T7 AsT7
        {
            get { return Get<T7>(7); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> (T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7>(t, 7);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7)
        {
            if (IsT0 && f0 != null)
            {
                f0(AsT0);
                return; 
            }
            if (IsT1 && f1 != null)
            {
                f1(AsT1);
                return; 
            }
            if (IsT2 && f2 != null)
            {
                f2(AsT2);
                return; 
            }
            if (IsT3 && f3 != null)
            {
                f3(AsT3);
                return; 
            }
            if (IsT4 && f4 != null)
            {
                f4(AsT4);
                return; 
            }
            if (IsT5 && f5 != null)
            {
                f5(AsT5);
                return; 
            }
            if (IsT6 && f6 != null)
            {
                f6(AsT6);
                return; 
            }
            if (IsT7 && f7 != null)
            {
                f7(AsT7);
                return; 
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (IsT4 && f4 != null)
            {
                return f4(AsT4);
            }
            if (IsT5 && f5 != null)
            {
                return f5(AsT5);
            }
            if (IsT6 && f6 != null)
            {
                return f6(AsT6);
            }
            if (IsT7 && f7 != null)
            {
                return f7(AsT7);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (IsT4 && f4 != null)
            {
                return f4(AsT4);
            }
            if (IsT5 && f5 != null)
            {
                return f5(AsT5);
            }
            if (IsT6 && f6 != null)
            {
                return f6(AsT6);
            }
            if (IsT7 && f7 != null)
            {
                return f7(AsT7);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7> other)
        {
            return _index == other._index && Equals(_value, other._value);
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
                return ((_value?.GetHashCode() ?? 0)*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IOneOf
    {
        readonly object _value;
        readonly int _index;
        
        OneOfBase(object value, int index)
        {
            _value = value; 
            _index = index;
        }

        protected OneOfBase()
        {
            _value = this;

            if (this is T0)
            {
                _index = 0;
            }

            if (this is T1)
            {
                _index = 1;
            }

            if (this is T2)
            {
                _index = 2;
            }

            if (this is T3)
            {
                _index = 3;
            }

            if (this is T4)
            {
                _index = 4;
            }

            if (this is T5)
            {
                _index = 5;
            }

            if (this is T6)
            {
                _index = 6;
            }

            if (this is T7)
            {
                _index = 7;
            }

            if (this is T8)
            {
                _index = 8;
            }
        }

        object IOneOf.Value 
        {
            get { return _value; }
        }
    
        T Get<T>(int index)
        {
            if (index != _index)
            {
                throw new InvalidOperationException($"Cannot return as T{index} as result is T{_index}");
            }
            return (T)_value;
        }

        public bool IsT0
        {
            get { return _index == 0; }
        }
        
        public T0 AsT0
        {
            get { return Get<T0>(0); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T0 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 0);
        }


        public bool IsT1
        {
            get { return _index == 1; }
        }
        
        public T1 AsT1
        {
            get { return Get<T1>(1); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T1 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 1);
        }


        public bool IsT2
        {
            get { return _index == 2; }
        }
        
        public T2 AsT2
        {
            get { return Get<T2>(2); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T2 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 2);
        }


        public bool IsT3
        {
            get { return _index == 3; }
        }
        
        public T3 AsT3
        {
            get { return Get<T3>(3); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T3 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 3);
        }


        public bool IsT4
        {
            get { return _index == 4; }
        }
        
        public T4 AsT4
        {
            get { return Get<T4>(4); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T4 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 4);
        }


        public bool IsT5
        {
            get { return _index == 5; }
        }
        
        public T5 AsT5
        {
            get { return Get<T5>(5); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T5 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 5);
        }


        public bool IsT6
        {
            get { return _index == 6; }
        }
        
        public T6 AsT6
        {
            get { return Get<T6>(6); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T6 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 6);
        }


        public bool IsT7
        {
            get { return _index == 7; }
        }
        
        public T7 AsT7
        {
            get { return Get<T7>(7); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T7 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 7);
        }


        public bool IsT8
        {
            get { return _index == 8; }
        }
        
        public T8 AsT8
        {
            get { return Get<T8>(8); }
        }
        
        public static implicit operator OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T8 t)
        {
             return new OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 8);
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8)
        {
            if (IsT0 && f0 != null)
            {
                f0(AsT0);
                return; 
            }
            if (IsT1 && f1 != null)
            {
                f1(AsT1);
                return; 
            }
            if (IsT2 && f2 != null)
            {
                f2(AsT2);
                return; 
            }
            if (IsT3 && f3 != null)
            {
                f3(AsT3);
                return; 
            }
            if (IsT4 && f4 != null)
            {
                f4(AsT4);
                return; 
            }
            if (IsT5 && f5 != null)
            {
                f5(AsT5);
                return; 
            }
            if (IsT6 && f6 != null)
            {
                f6(AsT6);
                return; 
            }
            if (IsT7 && f7 != null)
            {
                f7(AsT7);
                return; 
            }
            if (IsT8 && f8 != null)
            {
                f8(AsT8);
                return; 
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (IsT4 && f4 != null)
            {
                return f4(AsT4);
            }
            if (IsT5 && f5 != null)
            {
                return f5(AsT5);
            }
            if (IsT6 && f6 != null)
            {
                return f6(AsT6);
            }
            if (IsT7 && f7 != null)
            {
                return f7(AsT7);
            }
            if (IsT8 && f8 != null)
            {
                return f8(AsT8);
            }
            throw new InvalidOperationException();
        }

        public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<TResult> otherwise = null)
        {
            if (IsT0 && f0 != null)
            {
                return f0(AsT0);
            }
            if (IsT1 && f1 != null)
            {
                return f1(AsT1);
            }
            if (IsT2 && f2 != null)
            {
                return f2(AsT2);
            }
            if (IsT3 && f3 != null)
            {
                return f3(AsT3);
            }
            if (IsT4 && f4 != null)
            {
                return f4(AsT4);
            }
            if (IsT5 && f5 != null)
            {
                return f5(AsT5);
            }
            if (IsT6 && f6 != null)
            {
                return f6(AsT6);
            }
            if (IsT7 && f7 != null)
            {
                return f7(AsT7);
            }
            if (IsT8 && f8 != null)
            {
                return f8(AsT8);
            }
            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            return _index == other._index && Equals(_value, other._value);
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
                return ((_value?.GetHashCode() ?? 0)*397) ^ _index;
            }
        }
    }

}
