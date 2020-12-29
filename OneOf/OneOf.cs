using System;

using static OneOf.Functions;

namespace OneOf
{
    public struct OneOf<T0> : IOneOf
    {
        readonly T0 _value0;
        readonly int _index;

        OneOf(int index, T0 value0 = default)
        {
            _index = index;
            _value0 = value0;
        }

        public object Value => _index switch
        {
            0 => _value0,
            _ => throw new InvalidOperationException()
        };
        
        public int Index => _index;
        
        public bool IsT0 => _index == 0;
        
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new NotImplementedException($"Cannot return as T0 as result is T{_index}");
        
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

        public TResult Match<TResult>(Func<T0, TResult> f0)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0> FromT0(T0 input) => input;

        public OneOf<TResult> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => mapFunc(AsT0),
                _ => throw new InvalidOperationException()
            };
        }
        bool Equals(OneOf<T0> other) =>
            _index == other._index &&
            _index switch
            {
                
                0 => Equals(_value0, other._value0),
                _ => false
            };

        public override bool Equals(object obj) => obj is OneOf<T0> o && Equals(o);

        public override string ToString()
        {
            return _index switch
            {
                0 => FormatValue(typeof(T0), _value0),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
        }

        public override int GetHashCode()
        {
            int hashCode = _index switch
            {
                0 => _value0?.GetHashCode() ?? 0,
                _ => 0
            };
            return (hashCode*397) ^ _index;
        }
    }

    public struct OneOf<T0, T1> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly int _index;

        OneOf(int index, T0 value0 = default, T1 value1 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
        }

        public object Value => _index switch
        {
            0 => _value0,
            1 => _value1,
            _ => throw new InvalidOperationException()
        };
        
        public int Index => _index;
        
        public bool IsT0 => _index == 0;
        
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new NotImplementedException($"Cannot return as T0 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1>(T0 t) => new OneOf<T0, T1>(0, value0: t);
        
        public bool IsT1 => _index == 1;
        
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new NotImplementedException($"Cannot return as T1 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1>(T1 t) => new OneOf<T0, T1>(1, value1: t);
        

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

        public static OneOf<T0, T1> FromT0(T0 input) => input;
        public static OneOf<T0, T1> FromT1(T1 input) => input;

        public OneOf<TResult, T1> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => mapFunc(AsT0),
                1 => AsT1,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, TResult> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => mapFunc(AsT1),
                _ => throw new InvalidOperationException()
            };
        }
		public bool TryPickT0(out T0 value, out T1 remainder)
		{
            value = IsT0 ? AsT0 : default;
            remainder = 
                _index == 0 ? default :
                _index == 1 ? AsT1 :
                throw new InvalidOperationException();
            return IsT0;
		}

		public bool TryPickT1(out T1 value, out T0 remainder)
		{
            value = IsT1 ? AsT1 : default;
            remainder = 
                _index == 0 ? AsT0 :
                _index == 1 ? default :
                throw new InvalidOperationException();
            return IsT1;
		}

        bool Equals(OneOf<T0, T1> other) =>
            _index == other._index &&
            _index switch
            {
                
                0 => Equals(_value0, other._value0),
                1 => Equals(_value1, other._value1),
                _ => false
            };

        public override bool Equals(object obj) => obj is OneOf<T0, T1> o && Equals(o);

        public override string ToString()
        {
            return _index switch
            {
                0 => FormatValue(typeof(T0), _value0),
                1 => FormatValue(typeof(T1), _value1),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
        }

        public override int GetHashCode()
        {
            int hashCode = _index switch
            {
                0 => _value0?.GetHashCode() ?? 0,
                1 => _value1?.GetHashCode() ?? 0,
                _ => 0
            };
            return (hashCode*397) ^ _index;
        }
    }

    public struct OneOf<T0, T1, T2> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly int _index;

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
        }

        public object Value => _index switch
        {
            0 => _value0,
            1 => _value1,
            2 => _value2,
            _ => throw new InvalidOperationException()
        };
        
        public int Index => _index;
        
        public bool IsT0 => _index == 0;
        
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new NotImplementedException($"Cannot return as T0 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2>(T0 t) => new OneOf<T0, T1, T2>(0, value0: t);
        
        public bool IsT1 => _index == 1;
        
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new NotImplementedException($"Cannot return as T1 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2>(T1 t) => new OneOf<T0, T1, T2>(1, value1: t);
        
        public bool IsT2 => _index == 2;
        
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new NotImplementedException($"Cannot return as T2 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2>(T2 t) => new OneOf<T0, T1, T2>(2, value2: t);
        

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

        public static OneOf<T0, T1, T2> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2> FromT2(T2 input) => input;

        public OneOf<TResult, T1, T2> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => mapFunc(AsT0),
                1 => AsT1,
                2 => AsT2,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, TResult, T2> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => mapFunc(AsT1),
                2 => AsT2,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, TResult> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => mapFunc(AsT2),
                _ => throw new InvalidOperationException()
            };
        }
		public bool TryPickT0(out T0 value, out OneOf<T1, T2> remainder)
		{
            value = IsT0 ? AsT0 : default;
            remainder = 
                _index == 0 ? default :
                _index == 1 ? OneOf<T1, T2>.FromT0(AsT1) :
                _index == 2 ? OneOf<T1, T2>.FromT1(AsT2) :
                throw new InvalidOperationException();
            return IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2> remainder)
		{
            value = IsT1 ? AsT1 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T2>.FromT0(AsT0) :
                _index == 1 ? default :
                _index == 2 ? OneOf<T0, T2>.FromT1(AsT2) :
                throw new InvalidOperationException();
            return IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1> remainder)
		{
            value = IsT2 ? AsT2 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1>.FromT1(AsT1) :
                _index == 2 ? default :
                throw new InvalidOperationException();
            return IsT2;
		}

        bool Equals(OneOf<T0, T1, T2> other) =>
            _index == other._index &&
            _index switch
            {
                
                0 => Equals(_value0, other._value0),
                1 => Equals(_value1, other._value1),
                2 => Equals(_value2, other._value2),
                _ => false
            };

        public override bool Equals(object obj) => obj is OneOf<T0, T1, T2> o && Equals(o);

        public override string ToString()
        {
            return _index switch
            {
                0 => FormatValue(typeof(T0), _value0),
                1 => FormatValue(typeof(T1), _value1),
                2 => FormatValue(typeof(T2), _value2),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
        }

        public override int GetHashCode()
        {
            int hashCode = _index switch
            {
                0 => _value0?.GetHashCode() ?? 0,
                1 => _value1?.GetHashCode() ?? 0,
                2 => _value2?.GetHashCode() ?? 0,
                _ => 0
            };
            return (hashCode*397) ^ _index;
        }
    }

    public struct OneOf<T0, T1, T2, T3> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly int _index;

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
        }

        public object Value => _index switch
        {
            0 => _value0,
            1 => _value1,
            2 => _value2,
            3 => _value3,
            _ => throw new InvalidOperationException()
        };
        
        public int Index => _index;
        
        public bool IsT0 => _index == 0;
        
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new NotImplementedException($"Cannot return as T0 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3>(T0 t) => new OneOf<T0, T1, T2, T3>(0, value0: t);
        
        public bool IsT1 => _index == 1;
        
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new NotImplementedException($"Cannot return as T1 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3>(T1 t) => new OneOf<T0, T1, T2, T3>(1, value1: t);
        
        public bool IsT2 => _index == 2;
        
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new NotImplementedException($"Cannot return as T2 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3>(T2 t) => new OneOf<T0, T1, T2, T3>(2, value2: t);
        
        public bool IsT3 => _index == 3;
        
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new NotImplementedException($"Cannot return as T3 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3>(T3 t) => new OneOf<T0, T1, T2, T3>(3, value3: t);
        

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

        public static OneOf<T0, T1, T2, T3> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3> FromT3(T3 input) => input;

        public OneOf<TResult, T1, T2, T3> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => mapFunc(AsT0),
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, TResult, T2, T3> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => mapFunc(AsT1),
                2 => AsT2,
                3 => AsT3,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, TResult, T3> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => mapFunc(AsT2),
                3 => AsT3,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, TResult> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => mapFunc(AsT3),
                _ => throw new InvalidOperationException()
            };
        }
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3> remainder)
		{
            value = IsT0 ? AsT0 : default;
            remainder = 
                _index == 0 ? default :
                _index == 1 ? OneOf<T1, T2, T3>.FromT0(AsT1) :
                _index == 2 ? OneOf<T1, T2, T3>.FromT1(AsT2) :
                _index == 3 ? OneOf<T1, T2, T3>.FromT2(AsT3) :
                throw new InvalidOperationException();
            return IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3> remainder)
		{
            value = IsT1 ? AsT1 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T2, T3>.FromT0(AsT0) :
                _index == 1 ? default :
                _index == 2 ? OneOf<T0, T2, T3>.FromT1(AsT2) :
                _index == 3 ? OneOf<T0, T2, T3>.FromT2(AsT3) :
                throw new InvalidOperationException();
            return IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3> remainder)
		{
            value = IsT2 ? AsT2 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T3>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T3>.FromT1(AsT1) :
                _index == 2 ? default :
                _index == 3 ? OneOf<T0, T1, T3>.FromT2(AsT3) :
                throw new InvalidOperationException();
            return IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2> remainder)
		{
            value = IsT3 ? AsT3 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2>.FromT2(AsT2) :
                _index == 3 ? default :
                throw new InvalidOperationException();
            return IsT3;
		}

        bool Equals(OneOf<T0, T1, T2, T3> other) =>
            _index == other._index &&
            _index switch
            {
                
                0 => Equals(_value0, other._value0),
                1 => Equals(_value1, other._value1),
                2 => Equals(_value2, other._value2),
                3 => Equals(_value3, other._value3),
                _ => false
            };

        public override bool Equals(object obj) => obj is OneOf<T0, T1, T2, T3> o && Equals(o);

        public override string ToString()
        {
            return _index switch
            {
                0 => FormatValue(typeof(T0), _value0),
                1 => FormatValue(typeof(T1), _value1),
                2 => FormatValue(typeof(T2), _value2),
                3 => FormatValue(typeof(T3), _value3),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
        }

        public override int GetHashCode()
        {
            int hashCode = _index switch
            {
                0 => _value0?.GetHashCode() ?? 0,
                1 => _value1?.GetHashCode() ?? 0,
                2 => _value2?.GetHashCode() ?? 0,
                3 => _value3?.GetHashCode() ?? 0,
                _ => 0
            };
            return (hashCode*397) ^ _index;
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

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
        }

        public object Value => _index switch
        {
            0 => _value0,
            1 => _value1,
            2 => _value2,
            3 => _value3,
            4 => _value4,
            _ => throw new InvalidOperationException()
        };
        
        public int Index => _index;
        
        public bool IsT0 => _index == 0;
        
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new NotImplementedException($"Cannot return as T0 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T0 t) => new OneOf<T0, T1, T2, T3, T4>(0, value0: t);
        
        public bool IsT1 => _index == 1;
        
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new NotImplementedException($"Cannot return as T1 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T1 t) => new OneOf<T0, T1, T2, T3, T4>(1, value1: t);
        
        public bool IsT2 => _index == 2;
        
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new NotImplementedException($"Cannot return as T2 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T2 t) => new OneOf<T0, T1, T2, T3, T4>(2, value2: t);
        
        public bool IsT3 => _index == 3;
        
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new NotImplementedException($"Cannot return as T3 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T3 t) => new OneOf<T0, T1, T2, T3, T4>(3, value3: t);
        
        public bool IsT4 => _index == 4;
        
        public T4 AsT4 =>
            _index == 4 ?
                _value4 :
                throw new NotImplementedException($"Cannot return as T4 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T4 t) => new OneOf<T0, T1, T2, T3, T4>(4, value4: t);
        

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

        public static OneOf<T0, T1, T2, T3, T4> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3, T4> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3, T4> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3, T4> FromT3(T3 input) => input;
        public static OneOf<T0, T1, T2, T3, T4> FromT4(T4 input) => input;

        public OneOf<TResult, T1, T2, T3, T4> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => mapFunc(AsT0),
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, TResult, T2, T3, T4> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => mapFunc(AsT1),
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, TResult, T3, T4> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => mapFunc(AsT2),
                3 => AsT3,
                4 => AsT4,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, TResult, T4> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => mapFunc(AsT3),
                4 => AsT4,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, TResult> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => mapFunc(AsT4),
                _ => throw new InvalidOperationException()
            };
        }
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4> remainder)
		{
            value = IsT0 ? AsT0 : default;
            remainder = 
                _index == 0 ? default :
                _index == 1 ? OneOf<T1, T2, T3, T4>.FromT0(AsT1) :
                _index == 2 ? OneOf<T1, T2, T3, T4>.FromT1(AsT2) :
                _index == 3 ? OneOf<T1, T2, T3, T4>.FromT2(AsT3) :
                _index == 4 ? OneOf<T1, T2, T3, T4>.FromT3(AsT4) :
                throw new InvalidOperationException();
            return IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4> remainder)
		{
            value = IsT1 ? AsT1 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T2, T3, T4>.FromT0(AsT0) :
                _index == 1 ? default :
                _index == 2 ? OneOf<T0, T2, T3, T4>.FromT1(AsT2) :
                _index == 3 ? OneOf<T0, T2, T3, T4>.FromT2(AsT3) :
                _index == 4 ? OneOf<T0, T2, T3, T4>.FromT3(AsT4) :
                throw new InvalidOperationException();
            return IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4> remainder)
		{
            value = IsT2 ? AsT2 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T3, T4>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T3, T4>.FromT1(AsT1) :
                _index == 2 ? default :
                _index == 3 ? OneOf<T0, T1, T3, T4>.FromT2(AsT3) :
                _index == 4 ? OneOf<T0, T1, T3, T4>.FromT3(AsT4) :
                throw new InvalidOperationException();
            return IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4> remainder)
		{
            value = IsT3 ? AsT3 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T4>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T4>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T4>.FromT2(AsT2) :
                _index == 3 ? default :
                _index == 4 ? OneOf<T0, T1, T2, T4>.FromT3(AsT4) :
                throw new InvalidOperationException();
            return IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3> remainder)
		{
            value = IsT4 ? AsT4 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3>.FromT3(AsT3) :
                _index == 4 ? default :
                throw new InvalidOperationException();
            return IsT4;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4> other) =>
            _index == other._index &&
            _index switch
            {
                
                0 => Equals(_value0, other._value0),
                1 => Equals(_value1, other._value1),
                2 => Equals(_value2, other._value2),
                3 => Equals(_value3, other._value3),
                4 => Equals(_value4, other._value4),
                _ => false
            };

        public override bool Equals(object obj) => obj is OneOf<T0, T1, T2, T3, T4> o && Equals(o);

        public override string ToString()
        {
            return _index switch
            {
                0 => FormatValue(typeof(T0), _value0),
                1 => FormatValue(typeof(T1), _value1),
                2 => FormatValue(typeof(T2), _value2),
                3 => FormatValue(typeof(T3), _value3),
                4 => FormatValue(typeof(T4), _value4),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
        }

        public override int GetHashCode()
        {
            int hashCode = _index switch
            {
                0 => _value0?.GetHashCode() ?? 0,
                1 => _value1?.GetHashCode() ?? 0,
                2 => _value2?.GetHashCode() ?? 0,
                3 => _value3?.GetHashCode() ?? 0,
                4 => _value4?.GetHashCode() ?? 0,
                _ => 0
            };
            return (hashCode*397) ^ _index;
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

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
        }

        public object Value => _index switch
        {
            0 => _value0,
            1 => _value1,
            2 => _value2,
            3 => _value3,
            4 => _value4,
            5 => _value5,
            _ => throw new InvalidOperationException()
        };
        
        public int Index => _index;
        
        public bool IsT0 => _index == 0;
        
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new NotImplementedException($"Cannot return as T0 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5>(0, value0: t);
        
        public bool IsT1 => _index == 1;
        
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new NotImplementedException($"Cannot return as T1 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5>(1, value1: t);
        
        public bool IsT2 => _index == 2;
        
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new NotImplementedException($"Cannot return as T2 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5>(2, value2: t);
        
        public bool IsT3 => _index == 3;
        
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new NotImplementedException($"Cannot return as T3 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5>(3, value3: t);
        
        public bool IsT4 => _index == 4;
        
        public T4 AsT4 =>
            _index == 4 ?
                _value4 :
                throw new NotImplementedException($"Cannot return as T4 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5>(4, value4: t);
        
        public bool IsT5 => _index == 5;
        
        public T5 AsT5 =>
            _index == 5 ?
                _value5 :
                throw new NotImplementedException($"Cannot return as T5 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5>(5, value5: t);
        

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

        public static OneOf<T0, T1, T2, T3, T4, T5> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5> FromT3(T3 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5> FromT4(T4 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5> FromT5(T5 input) => input;

        public OneOf<TResult, T1, T2, T3, T4, T5> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => mapFunc(AsT0),
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, TResult, T2, T3, T4, T5> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => mapFunc(AsT1),
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, TResult, T3, T4, T5> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => mapFunc(AsT2),
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, TResult, T4, T5> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => mapFunc(AsT3),
                4 => AsT4,
                5 => AsT5,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, TResult, T5> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => mapFunc(AsT4),
                5 => AsT5,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, T4, TResult> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => mapFunc(AsT5),
                _ => throw new InvalidOperationException()
            };
        }
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5> remainder)
		{
            value = IsT0 ? AsT0 : default;
            remainder = 
                _index == 0 ? default :
                _index == 1 ? OneOf<T1, T2, T3, T4, T5>.FromT0(AsT1) :
                _index == 2 ? OneOf<T1, T2, T3, T4, T5>.FromT1(AsT2) :
                _index == 3 ? OneOf<T1, T2, T3, T4, T5>.FromT2(AsT3) :
                _index == 4 ? OneOf<T1, T2, T3, T4, T5>.FromT3(AsT4) :
                _index == 5 ? OneOf<T1, T2, T3, T4, T5>.FromT4(AsT5) :
                throw new InvalidOperationException();
            return IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5> remainder)
		{
            value = IsT1 ? AsT1 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T2, T3, T4, T5>.FromT0(AsT0) :
                _index == 1 ? default :
                _index == 2 ? OneOf<T0, T2, T3, T4, T5>.FromT1(AsT2) :
                _index == 3 ? OneOf<T0, T2, T3, T4, T5>.FromT2(AsT3) :
                _index == 4 ? OneOf<T0, T2, T3, T4, T5>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T2, T3, T4, T5>.FromT4(AsT5) :
                throw new InvalidOperationException();
            return IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5> remainder)
		{
            value = IsT2 ? AsT2 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T3, T4, T5>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T3, T4, T5>.FromT1(AsT1) :
                _index == 2 ? default :
                _index == 3 ? OneOf<T0, T1, T3, T4, T5>.FromT2(AsT3) :
                _index == 4 ? OneOf<T0, T1, T3, T4, T5>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T1, T3, T4, T5>.FromT4(AsT5) :
                throw new InvalidOperationException();
            return IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5> remainder)
		{
            value = IsT3 ? AsT3 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T4, T5>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T4, T5>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T4, T5>.FromT2(AsT2) :
                _index == 3 ? default :
                _index == 4 ? OneOf<T0, T1, T2, T4, T5>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T1, T2, T4, T5>.FromT4(AsT5) :
                throw new InvalidOperationException();
            return IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5> remainder)
		{
            value = IsT4 ? AsT4 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T5>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T5>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T5>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T5>.FromT3(AsT3) :
                _index == 4 ? default :
                _index == 5 ? OneOf<T0, T1, T2, T3, T5>.FromT4(AsT5) :
                throw new InvalidOperationException();
            return IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4> remainder)
		{
            value = IsT5 ? AsT5 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T4>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T4>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T4>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T4>.FromT3(AsT3) :
                _index == 4 ? OneOf<T0, T1, T2, T3, T4>.FromT4(AsT4) :
                _index == 5 ? default :
                throw new InvalidOperationException();
            return IsT5;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5> other) =>
            _index == other._index &&
            _index switch
            {
                
                0 => Equals(_value0, other._value0),
                1 => Equals(_value1, other._value1),
                2 => Equals(_value2, other._value2),
                3 => Equals(_value3, other._value3),
                4 => Equals(_value4, other._value4),
                5 => Equals(_value5, other._value5),
                _ => false
            };

        public override bool Equals(object obj) => obj is OneOf<T0, T1, T2, T3, T4, T5> o && Equals(o);

        public override string ToString()
        {
            return _index switch
            {
                0 => FormatValue(typeof(T0), _value0),
                1 => FormatValue(typeof(T1), _value1),
                2 => FormatValue(typeof(T2), _value2),
                3 => FormatValue(typeof(T3), _value3),
                4 => FormatValue(typeof(T4), _value4),
                5 => FormatValue(typeof(T5), _value5),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
        }

        public override int GetHashCode()
        {
            int hashCode = _index switch
            {
                0 => _value0?.GetHashCode() ?? 0,
                1 => _value1?.GetHashCode() ?? 0,
                2 => _value2?.GetHashCode() ?? 0,
                3 => _value3?.GetHashCode() ?? 0,
                4 => _value4?.GetHashCode() ?? 0,
                5 => _value5?.GetHashCode() ?? 0,
                _ => 0
            };
            return (hashCode*397) ^ _index;
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

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default, T6 value6 = default)
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

        public object Value => _index switch
        {
            0 => _value0,
            1 => _value1,
            2 => _value2,
            3 => _value3,
            4 => _value4,
            5 => _value5,
            6 => _value6,
            _ => throw new InvalidOperationException()
        };
        
        public int Index => _index;
        
        public bool IsT0 => _index == 0;
        
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new NotImplementedException($"Cannot return as T0 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(0, value0: t);
        
        public bool IsT1 => _index == 1;
        
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new NotImplementedException($"Cannot return as T1 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(1, value1: t);
        
        public bool IsT2 => _index == 2;
        
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new NotImplementedException($"Cannot return as T2 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(2, value2: t);
        
        public bool IsT3 => _index == 3;
        
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new NotImplementedException($"Cannot return as T3 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(3, value3: t);
        
        public bool IsT4 => _index == 4;
        
        public T4 AsT4 =>
            _index == 4 ?
                _value4 :
                throw new NotImplementedException($"Cannot return as T4 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(4, value4: t);
        
        public bool IsT5 => _index == 5;
        
        public T5 AsT5 =>
            _index == 5 ?
                _value5 :
                throw new NotImplementedException($"Cannot return as T5 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(5, value5: t);
        
        public bool IsT6 => _index == 6;
        
        public T6 AsT6 =>
            _index == 6 ?
                _value6 :
                throw new NotImplementedException($"Cannot return as T6 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(6, value6: t);
        

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

        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT3(T3 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT4(T4 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT5(T5 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT6(T6 input) => input;

        public OneOf<TResult, T1, T2, T3, T4, T5, T6> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => mapFunc(AsT0),
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, TResult, T2, T3, T4, T5, T6> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => mapFunc(AsT1),
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, TResult, T3, T4, T5, T6> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => mapFunc(AsT2),
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, TResult, T4, T5, T6> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => mapFunc(AsT3),
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, TResult, T5, T6> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => mapFunc(AsT4),
                5 => AsT5,
                6 => AsT6,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, T4, TResult, T6> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => mapFunc(AsT5),
                6 => AsT6,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, T4, T5, TResult> MapT6<TResult>(Func<T6, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => mapFunc(AsT6),
                _ => throw new InvalidOperationException()
            };
        }
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6> remainder)
		{
            value = IsT0 ? AsT0 : default;
            remainder = 
                _index == 0 ? default :
                _index == 1 ? OneOf<T1, T2, T3, T4, T5, T6>.FromT0(AsT1) :
                _index == 2 ? OneOf<T1, T2, T3, T4, T5, T6>.FromT1(AsT2) :
                _index == 3 ? OneOf<T1, T2, T3, T4, T5, T6>.FromT2(AsT3) :
                _index == 4 ? OneOf<T1, T2, T3, T4, T5, T6>.FromT3(AsT4) :
                _index == 5 ? OneOf<T1, T2, T3, T4, T5, T6>.FromT4(AsT5) :
                _index == 6 ? OneOf<T1, T2, T3, T4, T5, T6>.FromT5(AsT6) :
                throw new InvalidOperationException();
            return IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6> remainder)
		{
            value = IsT1 ? AsT1 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T2, T3, T4, T5, T6>.FromT0(AsT0) :
                _index == 1 ? default :
                _index == 2 ? OneOf<T0, T2, T3, T4, T5, T6>.FromT1(AsT2) :
                _index == 3 ? OneOf<T0, T2, T3, T4, T5, T6>.FromT2(AsT3) :
                _index == 4 ? OneOf<T0, T2, T3, T4, T5, T6>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T2, T3, T4, T5, T6>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T2, T3, T4, T5, T6>.FromT5(AsT6) :
                throw new InvalidOperationException();
            return IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6> remainder)
		{
            value = IsT2 ? AsT2 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T3, T4, T5, T6>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T3, T4, T5, T6>.FromT1(AsT1) :
                _index == 2 ? default :
                _index == 3 ? OneOf<T0, T1, T3, T4, T5, T6>.FromT2(AsT3) :
                _index == 4 ? OneOf<T0, T1, T3, T4, T5, T6>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T1, T3, T4, T5, T6>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T1, T3, T4, T5, T6>.FromT5(AsT6) :
                throw new InvalidOperationException();
            return IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6> remainder)
		{
            value = IsT3 ? AsT3 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T4, T5, T6>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T4, T5, T6>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T4, T5, T6>.FromT2(AsT2) :
                _index == 3 ? default :
                _index == 4 ? OneOf<T0, T1, T2, T4, T5, T6>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T1, T2, T4, T5, T6>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T1, T2, T4, T5, T6>.FromT5(AsT6) :
                throw new InvalidOperationException();
            return IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6> remainder)
		{
            value = IsT4 ? AsT4 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T5, T6>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T5, T6>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T5, T6>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T5, T6>.FromT3(AsT3) :
                _index == 4 ? default :
                _index == 5 ? OneOf<T0, T1, T2, T3, T5, T6>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T1, T2, T3, T5, T6>.FromT5(AsT6) :
                throw new InvalidOperationException();
            return IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6> remainder)
		{
            value = IsT5 ? AsT5 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T4, T6>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T4, T6>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T4, T6>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T4, T6>.FromT3(AsT3) :
                _index == 4 ? OneOf<T0, T1, T2, T3, T4, T6>.FromT4(AsT4) :
                _index == 5 ? default :
                _index == 6 ? OneOf<T0, T1, T2, T3, T4, T6>.FromT5(AsT6) :
                throw new InvalidOperationException();
            return IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5> remainder)
		{
            value = IsT6 ? AsT6 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T4, T5>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T4, T5>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T4, T5>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T4, T5>.FromT3(AsT3) :
                _index == 4 ? OneOf<T0, T1, T2, T3, T4, T5>.FromT4(AsT4) :
                _index == 5 ? OneOf<T0, T1, T2, T3, T4, T5>.FromT5(AsT5) :
                _index == 6 ? default :
                throw new InvalidOperationException();
            return IsT6;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6> other) =>
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
                _ => false
            };

        public override bool Equals(object obj) => obj is OneOf<T0, T1, T2, T3, T4, T5, T6> o && Equals(o);

        public override string ToString()
        {
            return _index switch
            {
                0 => FormatValue(typeof(T0), _value0),
                1 => FormatValue(typeof(T1), _value1),
                2 => FormatValue(typeof(T2), _value2),
                3 => FormatValue(typeof(T3), _value3),
                4 => FormatValue(typeof(T4), _value4),
                5 => FormatValue(typeof(T5), _value5),
                6 => FormatValue(typeof(T6), _value6),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
        }

        public override int GetHashCode()
        {
            int hashCode = _index switch
            {
                0 => _value0?.GetHashCode() ?? 0,
                1 => _value1?.GetHashCode() ?? 0,
                2 => _value2?.GetHashCode() ?? 0,
                3 => _value3?.GetHashCode() ?? 0,
                4 => _value4?.GetHashCode() ?? 0,
                5 => _value5?.GetHashCode() ?? 0,
                6 => _value6?.GetHashCode() ?? 0,
                _ => 0
            };
            return (hashCode*397) ^ _index;
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

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default, T6 value6 = default, T7 value7 = default)
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

        public object Value => _index switch
        {
            0 => _value0,
            1 => _value1,
            2 => _value2,
            3 => _value3,
            4 => _value4,
            5 => _value5,
            6 => _value6,
            7 => _value7,
            _ => throw new InvalidOperationException()
        };
        
        public int Index => _index;
        
        public bool IsT0 => _index == 0;
        
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new NotImplementedException($"Cannot return as T0 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(0, value0: t);
        
        public bool IsT1 => _index == 1;
        
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new NotImplementedException($"Cannot return as T1 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(1, value1: t);
        
        public bool IsT2 => _index == 2;
        
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new NotImplementedException($"Cannot return as T2 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(2, value2: t);
        
        public bool IsT3 => _index == 3;
        
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new NotImplementedException($"Cannot return as T3 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(3, value3: t);
        
        public bool IsT4 => _index == 4;
        
        public T4 AsT4 =>
            _index == 4 ?
                _value4 :
                throw new NotImplementedException($"Cannot return as T4 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(4, value4: t);
        
        public bool IsT5 => _index == 5;
        
        public T5 AsT5 =>
            _index == 5 ?
                _value5 :
                throw new NotImplementedException($"Cannot return as T5 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(5, value5: t);
        
        public bool IsT6 => _index == 6;
        
        public T6 AsT6 =>
            _index == 6 ?
                _value6 :
                throw new NotImplementedException($"Cannot return as T6 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(6, value6: t);
        
        public bool IsT7 => _index == 7;
        
        public T7 AsT7 =>
            _index == 7 ?
                _value7 :
                throw new NotImplementedException($"Cannot return as T7 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(7, value7: t);
        

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

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT3(T3 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT4(T4 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT5(T5 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT6(T6 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT7(T7 input) => input;

        public OneOf<TResult, T1, T2, T3, T4, T5, T6, T7> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => mapFunc(AsT0),
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => mapFunc(AsT1),
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => mapFunc(AsT2),
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => mapFunc(AsT3),
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => mapFunc(AsT4),
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => mapFunc(AsT5),
                6 => AsT6,
                7 => AsT7,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7> MapT6<TResult>(Func<T6, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => mapFunc(AsT6),
                7 => AsT7,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult> MapT7<TResult>(Func<T7, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => mapFunc(AsT7),
                _ => throw new InvalidOperationException()
            };
        }
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7> remainder)
		{
            value = IsT0 ? AsT0 : default;
            remainder = 
                _index == 0 ? default :
                _index == 1 ? OneOf<T1, T2, T3, T4, T5, T6, T7>.FromT0(AsT1) :
                _index == 2 ? OneOf<T1, T2, T3, T4, T5, T6, T7>.FromT1(AsT2) :
                _index == 3 ? OneOf<T1, T2, T3, T4, T5, T6, T7>.FromT2(AsT3) :
                _index == 4 ? OneOf<T1, T2, T3, T4, T5, T6, T7>.FromT3(AsT4) :
                _index == 5 ? OneOf<T1, T2, T3, T4, T5, T6, T7>.FromT4(AsT5) :
                _index == 6 ? OneOf<T1, T2, T3, T4, T5, T6, T7>.FromT5(AsT6) :
                _index == 7 ? OneOf<T1, T2, T3, T4, T5, T6, T7>.FromT6(AsT7) :
                throw new InvalidOperationException();
            return IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7> remainder)
		{
            value = IsT1 ? AsT1 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T2, T3, T4, T5, T6, T7>.FromT0(AsT0) :
                _index == 1 ? default :
                _index == 2 ? OneOf<T0, T2, T3, T4, T5, T6, T7>.FromT1(AsT2) :
                _index == 3 ? OneOf<T0, T2, T3, T4, T5, T6, T7>.FromT2(AsT3) :
                _index == 4 ? OneOf<T0, T2, T3, T4, T5, T6, T7>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T2, T3, T4, T5, T6, T7>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T2, T3, T4, T5, T6, T7>.FromT5(AsT6) :
                _index == 7 ? OneOf<T0, T2, T3, T4, T5, T6, T7>.FromT6(AsT7) :
                throw new InvalidOperationException();
            return IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7> remainder)
		{
            value = IsT2 ? AsT2 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T3, T4, T5, T6, T7>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T3, T4, T5, T6, T7>.FromT1(AsT1) :
                _index == 2 ? default :
                _index == 3 ? OneOf<T0, T1, T3, T4, T5, T6, T7>.FromT2(AsT3) :
                _index == 4 ? OneOf<T0, T1, T3, T4, T5, T6, T7>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T1, T3, T4, T5, T6, T7>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T1, T3, T4, T5, T6, T7>.FromT5(AsT6) :
                _index == 7 ? OneOf<T0, T1, T3, T4, T5, T6, T7>.FromT6(AsT7) :
                throw new InvalidOperationException();
            return IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7> remainder)
		{
            value = IsT3 ? AsT3 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T4, T5, T6, T7>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T4, T5, T6, T7>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T4, T5, T6, T7>.FromT2(AsT2) :
                _index == 3 ? default :
                _index == 4 ? OneOf<T0, T1, T2, T4, T5, T6, T7>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T1, T2, T4, T5, T6, T7>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T1, T2, T4, T5, T6, T7>.FromT5(AsT6) :
                _index == 7 ? OneOf<T0, T1, T2, T4, T5, T6, T7>.FromT6(AsT7) :
                throw new InvalidOperationException();
            return IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7> remainder)
		{
            value = IsT4 ? AsT4 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T5, T6, T7>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T5, T6, T7>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T5, T6, T7>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T5, T6, T7>.FromT3(AsT3) :
                _index == 4 ? default :
                _index == 5 ? OneOf<T0, T1, T2, T3, T5, T6, T7>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T1, T2, T3, T5, T6, T7>.FromT5(AsT6) :
                _index == 7 ? OneOf<T0, T1, T2, T3, T5, T6, T7>.FromT6(AsT7) :
                throw new InvalidOperationException();
            return IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7> remainder)
		{
            value = IsT5 ? AsT5 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T4, T6, T7>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T4, T6, T7>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T4, T6, T7>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T4, T6, T7>.FromT3(AsT3) :
                _index == 4 ? OneOf<T0, T1, T2, T3, T4, T6, T7>.FromT4(AsT4) :
                _index == 5 ? default :
                _index == 6 ? OneOf<T0, T1, T2, T3, T4, T6, T7>.FromT5(AsT6) :
                _index == 7 ? OneOf<T0, T1, T2, T3, T4, T6, T7>.FromT6(AsT7) :
                throw new InvalidOperationException();
            return IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7> remainder)
		{
            value = IsT6 ? AsT6 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T4, T5, T7>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T4, T5, T7>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T4, T5, T7>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T4, T5, T7>.FromT3(AsT3) :
                _index == 4 ? OneOf<T0, T1, T2, T3, T4, T5, T7>.FromT4(AsT4) :
                _index == 5 ? OneOf<T0, T1, T2, T3, T4, T5, T7>.FromT5(AsT5) :
                _index == 6 ? default :
                _index == 7 ? OneOf<T0, T1, T2, T3, T4, T5, T7>.FromT6(AsT7) :
                throw new InvalidOperationException();
            return IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6> remainder)
		{
            value = IsT7 ? AsT7 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T4, T5, T6>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T4, T5, T6>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T4, T5, T6>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T4, T5, T6>.FromT3(AsT3) :
                _index == 4 ? OneOf<T0, T1, T2, T3, T4, T5, T6>.FromT4(AsT4) :
                _index == 5 ? OneOf<T0, T1, T2, T3, T4, T5, T6>.FromT5(AsT5) :
                _index == 6 ? OneOf<T0, T1, T2, T3, T4, T5, T6>.FromT6(AsT6) :
                _index == 7 ? default :
                throw new InvalidOperationException();
            return IsT7;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7> other) =>
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

        public override bool Equals(object obj) => obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7> o && Equals(o);

        public override string ToString()
        {
            return _index switch
            {
                0 => FormatValue(typeof(T0), _value0),
                1 => FormatValue(typeof(T1), _value1),
                2 => FormatValue(typeof(T2), _value2),
                3 => FormatValue(typeof(T3), _value3),
                4 => FormatValue(typeof(T4), _value4),
                5 => FormatValue(typeof(T5), _value5),
                6 => FormatValue(typeof(T6), _value6),
                7 => FormatValue(typeof(T7), _value7),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
        }

        public override int GetHashCode()
        {
            int hashCode = _index switch
            {
                0 => _value0?.GetHashCode() ?? 0,
                1 => _value1?.GetHashCode() ?? 0,
                2 => _value2?.GetHashCode() ?? 0,
                3 => _value3?.GetHashCode() ?? 0,
                4 => _value4?.GetHashCode() ?? 0,
                5 => _value5?.GetHashCode() ?? 0,
                6 => _value6?.GetHashCode() ?? 0,
                7 => _value7?.GetHashCode() ?? 0,
                _ => 0
            };
            return (hashCode*397) ^ _index;
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

        public object Value => _index switch
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
        
        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new NotImplementedException($"Cannot return as T0 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(0, value0: t);
        
        public bool IsT1 => _index == 1;
        
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new NotImplementedException($"Cannot return as T1 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(1, value1: t);
        
        public bool IsT2 => _index == 2;
        
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new NotImplementedException($"Cannot return as T2 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(2, value2: t);
        
        public bool IsT3 => _index == 3;
        
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new NotImplementedException($"Cannot return as T3 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(3, value3: t);
        
        public bool IsT4 => _index == 4;
        
        public T4 AsT4 =>
            _index == 4 ?
                _value4 :
                throw new NotImplementedException($"Cannot return as T4 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(4, value4: t);
        
        public bool IsT5 => _index == 5;
        
        public T5 AsT5 =>
            _index == 5 ?
                _value5 :
                throw new NotImplementedException($"Cannot return as T5 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(5, value5: t);
        
        public bool IsT6 => _index == 6;
        
        public T6 AsT6 =>
            _index == 6 ?
                _value6 :
                throw new NotImplementedException($"Cannot return as T6 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(6, value6: t);
        
        public bool IsT7 => _index == 7;
        
        public T7 AsT7 =>
            _index == 7 ?
                _value7 :
                throw new NotImplementedException($"Cannot return as T7 as result is T{_index}");
        
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(7, value7: t);
        
        public bool IsT8 => _index == 8;
        
        public T8 AsT8 =>
            _index == 8 ?
                _value8 :
                throw new NotImplementedException($"Cannot return as T8 as result is T{_index}");
        
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
            return _index switch
            {
                0 => mapFunc(AsT0),
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7, T8> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => mapFunc(AsT1),
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7, T8> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => mapFunc(AsT2),
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7, T8> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => mapFunc(AsT3),
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7, T8> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => mapFunc(AsT4),
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7, T8> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => mapFunc(AsT5),
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7, T8> MapT6<TResult>(Func<T6, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => mapFunc(AsT6),
                7 => AsT7,
                8 => AsT8,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult, T8> MapT7<TResult>(Func<T7, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => mapFunc(AsT7),
                8 => AsT8,
                _ => throw new InvalidOperationException()
            };
        }
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, TResult> MapT8<TResult>(Func<T8, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => mapFunc(AsT8),
                _ => throw new InvalidOperationException()
            };
        }
		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8> remainder)
		{
            value = IsT0 ? AsT0 : default;
            remainder = 
                _index == 0 ? default :
                _index == 1 ? OneOf<T1, T2, T3, T4, T5, T6, T7, T8>.FromT0(AsT1) :
                _index == 2 ? OneOf<T1, T2, T3, T4, T5, T6, T7, T8>.FromT1(AsT2) :
                _index == 3 ? OneOf<T1, T2, T3, T4, T5, T6, T7, T8>.FromT2(AsT3) :
                _index == 4 ? OneOf<T1, T2, T3, T4, T5, T6, T7, T8>.FromT3(AsT4) :
                _index == 5 ? OneOf<T1, T2, T3, T4, T5, T6, T7, T8>.FromT4(AsT5) :
                _index == 6 ? OneOf<T1, T2, T3, T4, T5, T6, T7, T8>.FromT5(AsT6) :
                _index == 7 ? OneOf<T1, T2, T3, T4, T5, T6, T7, T8>.FromT6(AsT7) :
                _index == 8 ? OneOf<T1, T2, T3, T4, T5, T6, T7, T8>.FromT7(AsT8) :
                throw new InvalidOperationException();
            return IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8> remainder)
		{
            value = IsT1 ? AsT1 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T2, T3, T4, T5, T6, T7, T8>.FromT0(AsT0) :
                _index == 1 ? default :
                _index == 2 ? OneOf<T0, T2, T3, T4, T5, T6, T7, T8>.FromT1(AsT2) :
                _index == 3 ? OneOf<T0, T2, T3, T4, T5, T6, T7, T8>.FromT2(AsT3) :
                _index == 4 ? OneOf<T0, T2, T3, T4, T5, T6, T7, T8>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T2, T3, T4, T5, T6, T7, T8>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T2, T3, T4, T5, T6, T7, T8>.FromT5(AsT6) :
                _index == 7 ? OneOf<T0, T2, T3, T4, T5, T6, T7, T8>.FromT6(AsT7) :
                _index == 8 ? OneOf<T0, T2, T3, T4, T5, T6, T7, T8>.FromT7(AsT8) :
                throw new InvalidOperationException();
            return IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8> remainder)
		{
            value = IsT2 ? AsT2 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T3, T4, T5, T6, T7, T8>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T3, T4, T5, T6, T7, T8>.FromT1(AsT1) :
                _index == 2 ? default :
                _index == 3 ? OneOf<T0, T1, T3, T4, T5, T6, T7, T8>.FromT2(AsT3) :
                _index == 4 ? OneOf<T0, T1, T3, T4, T5, T6, T7, T8>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T1, T3, T4, T5, T6, T7, T8>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T1, T3, T4, T5, T6, T7, T8>.FromT5(AsT6) :
                _index == 7 ? OneOf<T0, T1, T3, T4, T5, T6, T7, T8>.FromT6(AsT7) :
                _index == 8 ? OneOf<T0, T1, T3, T4, T5, T6, T7, T8>.FromT7(AsT8) :
                throw new InvalidOperationException();
            return IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8> remainder)
		{
            value = IsT3 ? AsT3 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T4, T5, T6, T7, T8>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T4, T5, T6, T7, T8>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T4, T5, T6, T7, T8>.FromT2(AsT2) :
                _index == 3 ? default :
                _index == 4 ? OneOf<T0, T1, T2, T4, T5, T6, T7, T8>.FromT3(AsT4) :
                _index == 5 ? OneOf<T0, T1, T2, T4, T5, T6, T7, T8>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T1, T2, T4, T5, T6, T7, T8>.FromT5(AsT6) :
                _index == 7 ? OneOf<T0, T1, T2, T4, T5, T6, T7, T8>.FromT6(AsT7) :
                _index == 8 ? OneOf<T0, T1, T2, T4, T5, T6, T7, T8>.FromT7(AsT8) :
                throw new InvalidOperationException();
            return IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8> remainder)
		{
            value = IsT4 ? AsT4 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T5, T6, T7, T8>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T5, T6, T7, T8>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T5, T6, T7, T8>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T5, T6, T7, T8>.FromT3(AsT3) :
                _index == 4 ? default :
                _index == 5 ? OneOf<T0, T1, T2, T3, T5, T6, T7, T8>.FromT4(AsT5) :
                _index == 6 ? OneOf<T0, T1, T2, T3, T5, T6, T7, T8>.FromT5(AsT6) :
                _index == 7 ? OneOf<T0, T1, T2, T3, T5, T6, T7, T8>.FromT6(AsT7) :
                _index == 8 ? OneOf<T0, T1, T2, T3, T5, T6, T7, T8>.FromT7(AsT8) :
                throw new InvalidOperationException();
            return IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8> remainder)
		{
            value = IsT5 ? AsT5 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T4, T6, T7, T8>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T4, T6, T7, T8>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T4, T6, T7, T8>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T4, T6, T7, T8>.FromT3(AsT3) :
                _index == 4 ? OneOf<T0, T1, T2, T3, T4, T6, T7, T8>.FromT4(AsT4) :
                _index == 5 ? default :
                _index == 6 ? OneOf<T0, T1, T2, T3, T4, T6, T7, T8>.FromT5(AsT6) :
                _index == 7 ? OneOf<T0, T1, T2, T3, T4, T6, T7, T8>.FromT6(AsT7) :
                _index == 8 ? OneOf<T0, T1, T2, T3, T4, T6, T7, T8>.FromT7(AsT8) :
                throw new InvalidOperationException();
            return IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8> remainder)
		{
            value = IsT6 ? AsT6 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T4, T5, T7, T8>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T4, T5, T7, T8>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T4, T5, T7, T8>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T4, T5, T7, T8>.FromT3(AsT3) :
                _index == 4 ? OneOf<T0, T1, T2, T3, T4, T5, T7, T8>.FromT4(AsT4) :
                _index == 5 ? OneOf<T0, T1, T2, T3, T4, T5, T7, T8>.FromT5(AsT5) :
                _index == 6 ? default :
                _index == 7 ? OneOf<T0, T1, T2, T3, T4, T5, T7, T8>.FromT6(AsT7) :
                _index == 8 ? OneOf<T0, T1, T2, T3, T4, T5, T7, T8>.FromT7(AsT8) :
                throw new InvalidOperationException();
            return IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8> remainder)
		{
            value = IsT7 ? AsT7 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T8>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T8>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T8>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T8>.FromT3(AsT3) :
                _index == 4 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T8>.FromT4(AsT4) :
                _index == 5 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T8>.FromT5(AsT5) :
                _index == 6 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T8>.FromT6(AsT6) :
                _index == 7 ? default :
                _index == 8 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T8>.FromT7(AsT8) :
                throw new InvalidOperationException();
            return IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7> remainder)
		{
            value = IsT8 ? AsT8 : default;
            remainder = 
                _index == 0 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T7>.FromT0(AsT0) :
                _index == 1 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T7>.FromT1(AsT1) :
                _index == 2 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T7>.FromT2(AsT2) :
                _index == 3 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T7>.FromT3(AsT3) :
                _index == 4 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T7>.FromT4(AsT4) :
                _index == 5 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T7>.FromT5(AsT5) :
                _index == 6 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T7>.FromT6(AsT6) :
                _index == 7 ? OneOf<T0, T1, T2, T3, T4, T5, T6, T7>.FromT7(AsT7) :
                _index == 8 ? default :
                throw new InvalidOperationException();
            return IsT8;
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

        public override bool Equals(object obj) => obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> o && Equals(o);

        public override string ToString()
        {
            return _index switch
            {
                0 => FormatValue(typeof(T0), _value0),
                1 => FormatValue(typeof(T1), _value1),
                2 => FormatValue(typeof(T2), _value2),
                3 => FormatValue(typeof(T3), _value3),
                4 => FormatValue(typeof(T4), _value4),
                5 => FormatValue(typeof(T5), _value5),
                6 => FormatValue(typeof(T6), _value6),
                7 => FormatValue(typeof(T7), _value7),
                8 => FormatValue(typeof(T8), _value8),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };
        }

        public override int GetHashCode()
        {
            int hashCode = _index switch
            {
                0 => _value0?.GetHashCode() ?? 0,
                1 => _value1?.GetHashCode() ?? 0,
                2 => _value2?.GetHashCode() ?? 0,
                3 => _value3?.GetHashCode() ?? 0,
                4 => _value4?.GetHashCode() ?? 0,
                5 => _value5?.GetHashCode() ?? 0,
                6 => _value6?.GetHashCode() ?? 0,
                7 => _value7?.GetHashCode() ?? 0,
                8 => _value8?.GetHashCode() ?? 0,
                _ => 0
            };
            return (hashCode*397) ^ _index;
        }
    }
}
