using System;

namespace OneOf
{
    public struct OneOf<T0> : IOneOf
    {
        readonly T0 _value0;
        readonly int _index;

        OneOf(int index, T0 value0 = default(T0))
        {
            _index = index + 1;
            _value0 = value0;
        }

        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 1:
                        return _value0;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0 => _index == 1;

        public T0 AsT0
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index - 1}");
                }
                return _value0;
            }
        }

        public static implicit operator OneOf<T0>(T0 t) => new OneOf<T0>(0, value0: t);


        public void Switch(Action<T0> f0)
        {
            if (_index == 1 && f0 != null)
            {
                f0(_value0);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0)
        {
            if (_index == 1 && f0 != null)
            {
                return f0(_value0);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0> FromT0(T0 input)
        {
            return input;
        }

        public OneOf<TResult> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult>>(
                input0 => mapFunc(input0)
            );
        }

        bool Equals(OneOf<T0> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 1: return Equals(_value0, other._value0);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            return obj is OneOf<T0> && Equals((OneOf<T0>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 1:
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
            _index = index + 1;
            _value0 = value0;
            _value1 = value1;
        }

        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 1:
                        return _value0;
                    case 2:
                        return _value1;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0 => _index == 1;

        public T0 AsT0
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index - 1}");
                }
                return _value0;
            }
        }

        public static implicit operator OneOf<T0, T1>(T0 t) => new OneOf<T0, T1>(0, value0: t);


        public bool IsT1 => _index == 2;

        public T1 AsT1
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index - 1}");
                }
                return _value1;
            }
        }

        public static implicit operator OneOf<T0, T1>(T1 t) => new OneOf<T0, T1>(1, value1: t);


        public void Switch(Action<T0> f0, Action<T1> f1)
        {
            if (_index == 1 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 2 && f1 != null)
            {
                f1(_value1);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1)
        {
            if (_index == 1 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 2 && f1 != null)
            {
                return f1(_value1);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1> FromT0(T0 input)
        {
            return input;
        }

        public static OneOf<T0, T1> FromT1(T1 input)
        {
            return input;
        }

        public OneOf<TResult, T1> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult, T1>>(
                input0 => mapFunc(input0),
                input1 => input1
            );
        }

        public OneOf<T0, TResult> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, TResult>>(
                input0 => input0,
                input1 => mapFunc(input1)
            );
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

        bool Equals(OneOf<T0, T1> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 1: return Equals(_value0, other._value0);
                case 2: return Equals(_value1, other._value1);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            return obj is OneOf<T0, T1> && Equals((OneOf<T0, T1>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 1:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 2:
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
            _index = index + 1;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
        }

        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 1:
                        return _value0;
                    case 2:
                        return _value1;
                    case 3:
                        return _value2;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0 => _index == 1;

        public T0 AsT0
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index - 1}");
                }
                return _value0;
            }
        }

        public static implicit operator OneOf<T0, T1, T2>(T0 t) => new OneOf<T0, T1, T2>(0, value0: t);


        public bool IsT1 => _index == 2;

        public T1 AsT1
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index - 1}");
                }
                return _value1;
            }
        }

        public static implicit operator OneOf<T0, T1, T2>(T1 t) => new OneOf<T0, T1, T2>(1, value1: t);


        public bool IsT2 => _index == 3;

        public T2 AsT2
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index - 1}");
                }
                return _value2;
            }
        }

        public static implicit operator OneOf<T0, T1, T2>(T2 t) => new OneOf<T0, T1, T2>(2, value2: t);


        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2)
        {
            if (_index == 1 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 2 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 3 && f2 != null)
            {
                f2(_value2);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2)
        {
            if (_index == 1 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 2 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 3 && f2 != null)
            {
                return f2(_value2);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1, T2> FromT0(T0 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2> FromT1(T1 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2> FromT2(T2 input)
        {
            return input;
        }

        public OneOf<TResult, T1, T2> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult, T1, T2>>(
                input0 => mapFunc(input0),
                input1 => input1,
                input2 => input2
            );
        }

        public OneOf<T0, TResult, T2> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, TResult, T2>>(
                input0 => input0,
                input1 => mapFunc(input1),
                input2 => input2
            );
        }

        public OneOf<T0, T1, TResult> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, TResult>>(
                input0 => input0,
                input1 => input1,
                input2 => mapFunc(input2)
            );
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2>) 
				: this.Match<OneOf<T1, T2>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2>) 
				: this.Match<OneOf<T0, T2>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1>) 
				: this.Match<OneOf<T0, T1>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException());
			return this.IsT2;
		}

        bool Equals(OneOf<T0, T1, T2> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 1: return Equals(_value0, other._value0);
                case 2: return Equals(_value1, other._value1);
                case 3: return Equals(_value2, other._value2);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            return obj is OneOf<T0, T1, T2> && Equals((OneOf<T0, T1, T2>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 1:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 3:
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
            _index = index + 1;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
        }

        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 1:
                        return _value0;
                    case 2:
                        return _value1;
                    case 3:
                        return _value2;
                    case 4:
                        return _value3;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0 => _index == 1;

        public T0 AsT0
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index - 1}");
                }
                return _value0;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3>(T0 t) => new OneOf<T0, T1, T2, T3>(0, value0: t);


        public bool IsT1 => _index == 2;

        public T1 AsT1
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index - 1}");
                }
                return _value1;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3>(T1 t) => new OneOf<T0, T1, T2, T3>(1, value1: t);


        public bool IsT2 => _index == 3;

        public T2 AsT2
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index - 1}");
                }
                return _value2;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3>(T2 t) => new OneOf<T0, T1, T2, T3>(2, value2: t);


        public bool IsT3 => _index == 4;

        public T3 AsT3
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index - 1}");
                }
                return _value3;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3>(T3 t) => new OneOf<T0, T1, T2, T3>(3, value3: t);


        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3)
        {
            if (_index == 1 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 2 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 3 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 4 && f3 != null)
            {
                f3(_value3);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3)
        {
            if (_index == 1 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 2 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 3 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 4 && f3 != null)
            {
                return f3(_value3);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1, T2, T3> FromT0(T0 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3> FromT1(T1 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3> FromT2(T2 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3> FromT3(T3 input)
        {
            return input;
        }

        public OneOf<TResult, T1, T2, T3> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult, T1, T2, T3>>(
                input0 => mapFunc(input0),
                input1 => input1,
                input2 => input2,
                input3 => input3
            );
        }

        public OneOf<T0, TResult, T2, T3> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, TResult, T2, T3>>(
                input0 => input0,
                input1 => mapFunc(input1),
                input2 => input2,
                input3 => input3
            );
        }

        public OneOf<T0, T1, TResult, T3> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, TResult, T3>>(
                input0 => input0,
                input1 => input1,
                input2 => mapFunc(input2),
                input3 => input3
            );
        }

        public OneOf<T0, T1, T2, TResult> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, TResult>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => mapFunc(input3)
            );
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

        bool Equals(OneOf<T0, T1, T2, T3> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 1: return Equals(_value0, other._value0);
                case 2: return Equals(_value1, other._value1);
                case 3: return Equals(_value2, other._value2);
                case 4: return Equals(_value3, other._value3);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            return obj is OneOf<T0, T1, T2, T3> && Equals((OneOf<T0, T1, T2, T3>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 1:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 4:
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
            _index = index + 1;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
        }

        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 1:
                        return _value0;
                    case 2:
                        return _value1;
                    case 3:
                        return _value2;
                    case 4:
                        return _value3;
                    case 5:
                        return _value4;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0 => _index == 1;

        public T0 AsT0
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index - 1}");
                }
                return _value0;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T0 t) => new OneOf<T0, T1, T2, T3, T4>(0, value0: t);


        public bool IsT1 => _index == 2;

        public T1 AsT1
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index - 1}");
                }
                return _value1;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T1 t) => new OneOf<T0, T1, T2, T3, T4>(1, value1: t);


        public bool IsT2 => _index == 3;

        public T2 AsT2
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index - 1}");
                }
                return _value2;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T2 t) => new OneOf<T0, T1, T2, T3, T4>(2, value2: t);


        public bool IsT3 => _index == 4;

        public T3 AsT3
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index - 1}");
                }
                return _value3;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T3 t) => new OneOf<T0, T1, T2, T3, T4>(3, value3: t);


        public bool IsT4 => _index == 5;

        public T4 AsT4
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index - 1}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4>(T4 t) => new OneOf<T0, T1, T2, T3, T4>(4, value4: t);


        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4)
        {
            if (_index == 1 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 2 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 3 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 4 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 5 && f4 != null)
            {
                f4(_value4);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4)
        {
            if (_index == 1 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 2 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 3 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 4 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 5 && f4 != null)
            {
                return f4(_value4);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1, T2, T3, T4> FromT0(T0 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4> FromT1(T1 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4> FromT2(T2 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4> FromT3(T3 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4> FromT4(T4 input)
        {
            return input;
        }

        public OneOf<TResult, T1, T2, T3, T4> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult, T1, T2, T3, T4>>(
                input0 => mapFunc(input0),
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4
            );
        }

        public OneOf<T0, TResult, T2, T3, T4> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, TResult, T2, T3, T4>>(
                input0 => input0,
                input1 => mapFunc(input1),
                input2 => input2,
                input3 => input3,
                input4 => input4
            );
        }

        public OneOf<T0, T1, TResult, T3, T4> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, TResult, T3, T4>>(
                input0 => input0,
                input1 => input1,
                input2 => mapFunc(input2),
                input3 => input3,
                input4 => input4
            );
        }

        public OneOf<T0, T1, T2, TResult, T4> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, TResult, T4>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => mapFunc(input3),
                input4 => input4
            );
        }

        public OneOf<T0, T1, T2, T3, TResult> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, TResult>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => mapFunc(input4)
            );
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4>) 
				: this.Match<OneOf<T1, T2, T3, T4>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4>) 
				: this.Match<OneOf<T0, T2, T3, T4>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4>) 
				: this.Match<OneOf<T0, T1, T3, T4>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4>) 
				: this.Match<OneOf<T0, T1, T2, T4>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3>) 
				: this.Match<OneOf<T0, T1, T2, T3>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException());
			return this.IsT4;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 1: return Equals(_value0, other._value0);
                case 2: return Equals(_value1, other._value1);
                case 3: return Equals(_value2, other._value2);
                case 4: return Equals(_value3, other._value3);
                case 5: return Equals(_value4, other._value4);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            return obj is OneOf<T0, T1, T2, T3, T4> && Equals((OneOf<T0, T1, T2, T3, T4>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 1:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 5:
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
            _index = index + 1;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
        }

        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 1:
                        return _value0;
                    case 2:
                        return _value1;
                    case 3:
                        return _value2;
                    case 4:
                        return _value3;
                    case 5:
                        return _value4;
                    case 6:
                        return _value5;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0 => _index == 1;

        public T0 AsT0
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index - 1}");
                }
                return _value0;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5>(0, value0: t);


        public bool IsT1 => _index == 2;

        public T1 AsT1
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index - 1}");
                }
                return _value1;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5>(1, value1: t);


        public bool IsT2 => _index == 3;

        public T2 AsT2
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index - 1}");
                }
                return _value2;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5>(2, value2: t);


        public bool IsT3 => _index == 4;

        public T3 AsT3
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index - 1}");
                }
                return _value3;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5>(3, value3: t);


        public bool IsT4 => _index == 5;

        public T4 AsT4
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index - 1}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5>(4, value4: t);


        public bool IsT5 => _index == 6;

        public T5 AsT5
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index - 1}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5>(5, value5: t);


        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5)
        {
            if (_index == 1 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 2 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 3 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 4 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 5 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 6 && f5 != null)
            {
                f5(_value5);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5)
        {
            if (_index == 1 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 2 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 3 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 4 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 5 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 6 && f5 != null)
            {
                return f5(_value5);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1, T2, T3, T4, T5> FromT0(T0 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5> FromT1(T1 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5> FromT2(T2 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5> FromT3(T3 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5> FromT4(T4 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5> FromT5(T5 input)
        {
            return input;
        }

        public OneOf<TResult, T1, T2, T3, T4, T5> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult, T1, T2, T3, T4, T5>>(
                input0 => mapFunc(input0),
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5
            );
        }

        public OneOf<T0, TResult, T2, T3, T4, T5> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, TResult, T2, T3, T4, T5>>(
                input0 => input0,
                input1 => mapFunc(input1),
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5
            );
        }

        public OneOf<T0, T1, TResult, T3, T4, T5> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, TResult, T3, T4, T5>>(
                input0 => input0,
                input1 => input1,
                input2 => mapFunc(input2),
                input3 => input3,
                input4 => input4,
                input5 => input5
            );
        }

        public OneOf<T0, T1, T2, TResult, T4, T5> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, TResult, T4, T5>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => mapFunc(input3),
                input4 => input4,
                input5 => input5
            );
        }

        public OneOf<T0, T1, T2, T3, TResult, T5> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, TResult, T5>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => mapFunc(input4),
                input5 => input5
            );
        }

        public OneOf<T0, T1, T2, T3, T4, TResult> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, TResult>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => mapFunc(input5)
            );
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException());
			return this.IsT5;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 1: return Equals(_value0, other._value0);
                case 2: return Equals(_value1, other._value1);
                case 3: return Equals(_value2, other._value2);
                case 4: return Equals(_value3, other._value3);
                case 5: return Equals(_value4, other._value4);
                case 6: return Equals(_value5, other._value5);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            return obj is OneOf<T0, T1, T2, T3, T4, T5> && Equals((OneOf<T0, T1, T2, T3, T4, T5>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 1:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 6:
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
            _index = index + 1;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
        }

        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 1:
                        return _value0;
                    case 2:
                        return _value1;
                    case 3:
                        return _value2;
                    case 4:
                        return _value3;
                    case 5:
                        return _value4;
                    case 6:
                        return _value5;
                    case 7:
                        return _value6;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0 => _index == 1;

        public T0 AsT0
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index - 1}");
                }
                return _value0;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(0, value0: t);


        public bool IsT1 => _index == 2;

        public T1 AsT1
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index - 1}");
                }
                return _value1;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(1, value1: t);


        public bool IsT2 => _index == 3;

        public T2 AsT2
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index - 1}");
                }
                return _value2;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(2, value2: t);


        public bool IsT3 => _index == 4;

        public T3 AsT3
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index - 1}");
                }
                return _value3;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(3, value3: t);


        public bool IsT4 => _index == 5;

        public T4 AsT4
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index - 1}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(4, value4: t);


        public bool IsT5 => _index == 6;

        public T5 AsT5
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index - 1}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(5, value5: t);


        public bool IsT6 => _index == 7;

        public T6 AsT6
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index - 1}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6>(6, value6: t);


        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6)
        {
            if (_index == 1 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 2 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 3 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 4 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 5 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 6 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 7 && f6 != null)
            {
                f6(_value6);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6)
        {
            if (_index == 1 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 2 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 3 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 4 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 5 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 6 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 7 && f6 != null)
            {
                return f6(_value6);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT0(T0 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT1(T1 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT2(T2 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT3(T3 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT4(T4 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT5(T5 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6> FromT6(T6 input)
        {
            return input;
        }

        public OneOf<TResult, T1, T2, T3, T4, T5, T6> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult, T1, T2, T3, T4, T5, T6>>(
                input0 => mapFunc(input0),
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6
            );
        }

        public OneOf<T0, TResult, T2, T3, T4, T5, T6> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, TResult, T2, T3, T4, T5, T6>>(
                input0 => input0,
                input1 => mapFunc(input1),
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6
            );
        }

        public OneOf<T0, T1, TResult, T3, T4, T5, T6> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, TResult, T3, T4, T5, T6>>(
                input0 => input0,
                input1 => input1,
                input2 => mapFunc(input2),
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6
            );
        }

        public OneOf<T0, T1, T2, TResult, T4, T5, T6> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, TResult, T4, T5, T6>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => mapFunc(input3),
                input4 => input4,
                input5 => input5,
                input6 => input6
            );
        }

        public OneOf<T0, T1, T2, T3, TResult, T5, T6> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, TResult, T5, T6>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => mapFunc(input4),
                input5 => input5,
                input6 => input6
            );
        }

        public OneOf<T0, T1, T2, T3, T4, TResult, T6> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, TResult, T6>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => mapFunc(input5),
                input6 => input6
            );
        }

        public OneOf<T0, T1, T2, T3, T4, T5, TResult> MapT6<TResult>(Func<T6, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, TResult>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => mapFunc(input6)
            );
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException());
			return this.IsT6;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 1: return Equals(_value0, other._value0);
                case 2: return Equals(_value1, other._value1);
                case 3: return Equals(_value2, other._value2);
                case 4: return Equals(_value3, other._value3);
                case 5: return Equals(_value4, other._value4);
                case 6: return Equals(_value5, other._value5);
                case 7: return Equals(_value6, other._value6);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 1:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 7:
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
            _index = index + 1;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _value7 = value7;
        }

        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 1:
                        return _value0;
                    case 2:
                        return _value1;
                    case 3:
                        return _value2;
                    case 4:
                        return _value3;
                    case 5:
                        return _value4;
                    case 6:
                        return _value5;
                    case 7:
                        return _value6;
                    case 8:
                        return _value7;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0 => _index == 1;

        public T0 AsT0
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index - 1}");
                }
                return _value0;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(0, value0: t);


        public bool IsT1 => _index == 2;

        public T1 AsT1
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index - 1}");
                }
                return _value1;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(1, value1: t);


        public bool IsT2 => _index == 3;

        public T2 AsT2
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index - 1}");
                }
                return _value2;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(2, value2: t);


        public bool IsT3 => _index == 4;

        public T3 AsT3
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index - 1}");
                }
                return _value3;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(3, value3: t);


        public bool IsT4 => _index == 5;

        public T4 AsT4
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index - 1}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(4, value4: t);


        public bool IsT5 => _index == 6;

        public T5 AsT5
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index - 1}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(5, value5: t);


        public bool IsT6 => _index == 7;

        public T6 AsT6
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index - 1}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(6, value6: t);


        public bool IsT7 => _index == 8;

        public T7 AsT7
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index - 1}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(7, value7: t);


        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7)
        {
            if (_index == 1 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 2 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 3 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 4 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 5 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 6 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 7 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 8 && f7 != null)
            {
                f7(_value7);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7)
        {
            if (_index == 1 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 2 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 3 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 4 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 5 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 6 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 7 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 8 && f7 != null)
            {
                return f7(_value7);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT0(T0 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT1(T1 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT2(T2 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT3(T3 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT4(T4 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT5(T5 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT6(T6 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT7(T7 input)
        {
            return input;
        }

        public OneOf<TResult, T1, T2, T3, T4, T5, T6, T7> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<TResult, T1, T2, T3, T4, T5, T6, T7>>(
                input0 => mapFunc(input0),
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7
            );
        }

        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, TResult, T2, T3, T4, T5, T6, T7>>(
                input0 => input0,
                input1 => mapFunc(input1),
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7
            );
        }

        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, TResult, T3, T4, T5, T6, T7>>(
                input0 => input0,
                input1 => input1,
                input2 => mapFunc(input2),
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7
            );
        }

        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, TResult, T4, T5, T6, T7>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => mapFunc(input3),
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => input7
            );
        }

        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, TResult, T5, T6, T7>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => mapFunc(input4),
                input5 => input5,
                input6 => input6,
                input7 => input7
            );
        }

        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, TResult, T6, T7>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => mapFunc(input5),
                input6 => input6,
                input7 => input7
            );
        }

        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7> MapT6<TResult>(Func<T6, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, TResult, T7>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => mapFunc(input6),
                input7 => input7
            );
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult> MapT7<TResult>(Func<T7, TResult> mapFunc)
        {
            if(mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            return Match<OneOf<T0, T1, T2, T3, T4, T5, T6, TResult>>(
                input0 => input0,
                input1 => input1,
                input2 => input2,
                input3 => input3,
                input4 => input4,
                input5 => input5,
                input6 => input6,
                input7 => mapFunc(input7)
            );
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException());
			return this.IsT7;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 1: return Equals(_value0, other._value0);
                case 2: return Equals(_value1, other._value1);
                case 3: return Equals(_value2, other._value2);
                case 4: return Equals(_value3, other._value3);
                case 5: return Equals(_value4, other._value4);
                case 6: return Equals(_value5, other._value5);
                case 7: return Equals(_value6, other._value6);
                case 8: return Equals(_value7, other._value7);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 1:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 8:
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
            _index = index + 1;
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

        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 1:
                        return _value0;
                    case 2:
                        return _value1;
                    case 3:
                        return _value2;
                    case 4:
                        return _value3;
                    case 5:
                        return _value4;
                    case 6:
                        return _value5;
                    case 7:
                        return _value6;
                    case 8:
                        return _value7;
                    case 9:
                        return _value8;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public bool IsT0 => _index == 1;

        public T0 AsT0
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index - 1}");
                }
                return _value0;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(0, value0: t);


        public bool IsT1 => _index == 2;

        public T1 AsT1
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index - 1}");
                }
                return _value1;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(1, value1: t);


        public bool IsT2 => _index == 3;

        public T2 AsT2
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index - 1}");
                }
                return _value2;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(2, value2: t);


        public bool IsT3 => _index == 4;

        public T3 AsT3
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index - 1}");
                }
                return _value3;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(3, value3: t);


        public bool IsT4 => _index == 5;

        public T4 AsT4
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index - 1}");
                }
                return _value4;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(4, value4: t);


        public bool IsT5 => _index == 6;

        public T5 AsT5
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index - 1}");
                }
                return _value5;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(5, value5: t);


        public bool IsT6 => _index == 7;

        public T6 AsT6
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index - 1}");
                }
                return _value6;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(6, value6: t);


        public bool IsT7 => _index == 8;

        public T7 AsT7
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index - 1}");
                }
                return _value7;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(7, value7: t);


        public bool IsT8 => _index == 9;

        public T8 AsT8
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index - 1}");
                }
                return _value8;
            }
        }

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T8 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(8, value8: t);


        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8)
        {
            if (_index == 1 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 2 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 3 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 4 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 5 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 6 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 7 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 8 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 9 && f8 != null)
            {
                f8(_value8);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8)
        {
            if (_index == 1 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 2 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 3 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 4 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 5 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 6 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 7 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 8 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 9 && f8 != null)
            {
                return f8(_value8);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT0(T0 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT1(T1 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT2(T2 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT3(T3 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT4(T4 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT5(T5 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT6(T6 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT7(T7 input)
        {
            return input;
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT8(T8 input)
        {
            return input;
        }

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

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 1: return Equals(_value0, other._value0);
                case 2: return Equals(_value1, other._value1);
                case 3: return Equals(_value2, other._value2);
                case 4: return Equals(_value3, other._value3);
                case 5: return Equals(_value4, other._value4);
                case 6: return Equals(_value5, other._value5);
                case 7: return Equals(_value6, other._value6);
                case 8: return Equals(_value7, other._value7);
                case 9: return Equals(_value8, other._value8);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> && Equals((OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 1:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 9:
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
