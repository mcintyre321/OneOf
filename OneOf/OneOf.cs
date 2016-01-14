
using System;
namespace OneOf
{
    public interface IOneOf { object Value { get ; } }
	

	public struct OneOf<T0> : IOneOf
    {
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    { this.value = value; this.index = index;	     }
	
		object IOneOf.Value { get { return value; } }
	
	    T Get<T>(int index)
	    {
		    if (index != this.index)
		    {
		    	throw new InvalidOperationException("Cannot return as T" + index + " as result is T" + this.index);
            }
	        return (T)value;
	    }


        public bool IsT0 { get { return index == 0; } }
        public T0 AsT0 { get { return Get<T0>(0); } } 
        public static implicit operator OneOf<T0> (T0 t)
        {
	         return new OneOf<T0>(t, 0);
        }


	    public static Func<OneOf<T0>, TResult > Match<TResult>(Func<T0, TResult> f0 = null, Func<TResult> otherwise = null)
        {
			return oneof =>
			{
					if (oneof.IsT0 && f0 != null) return f0(oneof.AsT0);

		        if (otherwise != null) return otherwise();
	    		throw new InvalidOperationException();
    		};
		}
		
		bool Equals(OneOf<T0> other)
        {
            return index == other.index && Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<T0> && Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }
        }

	}


	public struct OneOf<T0, T1> : IOneOf
    {
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    { this.value = value; this.index = index;	     }
	
		object IOneOf.Value { get { return value; } }
	
	    T Get<T>(int index)
	    {
		    if (index != this.index)
		    {
		    	throw new InvalidOperationException("Cannot return as T" + index + " as result is T" + this.index);
            }
	        return (T)value;
	    }


        public bool IsT0 { get { return index == 0; } }
        public T0 AsT0 { get { return Get<T0>(0); } } 
        public static implicit operator OneOf<T0, T1> (T0 t)
        {
	         return new OneOf<T0, T1>(t, 0);
        }


        public bool IsT1 { get { return index == 1; } }
        public T1 AsT1 { get { return Get<T1>(1); } } 
        public static implicit operator OneOf<T0, T1> (T1 t)
        {
	         return new OneOf<T0, T1>(t, 1);
        }


	    public static Func<OneOf<T0, T1>, TResult > Match<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<TResult> otherwise = null)
        {
			return oneof =>
			{
					if (oneof.IsT0 && f0 != null) return f0(oneof.AsT0);
					if (oneof.IsT1 && f1 != null) return f1(oneof.AsT1);

		        if (otherwise != null) return otherwise();
	    		throw new InvalidOperationException();
    		};
		}
		
		bool Equals(OneOf<T0, T1> other)
        {
            return index == other.index && Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<T0, T1> && Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }
        }

	}


	public struct OneOf<T0, T1, T2> : IOneOf
    {
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    { this.value = value; this.index = index;	     }
	
		object IOneOf.Value { get { return value; } }
	
	    T Get<T>(int index)
	    {
		    if (index != this.index)
		    {
		    	throw new InvalidOperationException("Cannot return as T" + index + " as result is T" + this.index);
            }
	        return (T)value;
	    }


        public bool IsT0 { get { return index == 0; } }
        public T0 AsT0 { get { return Get<T0>(0); } } 
        public static implicit operator OneOf<T0, T1, T2> (T0 t)
        {
	         return new OneOf<T0, T1, T2>(t, 0);
        }


        public bool IsT1 { get { return index == 1; } }
        public T1 AsT1 { get { return Get<T1>(1); } } 
        public static implicit operator OneOf<T0, T1, T2> (T1 t)
        {
	         return new OneOf<T0, T1, T2>(t, 1);
        }


        public bool IsT2 { get { return index == 2; } }
        public T2 AsT2 { get { return Get<T2>(2); } } 
        public static implicit operator OneOf<T0, T1, T2> (T2 t)
        {
	         return new OneOf<T0, T1, T2>(t, 2);
        }


	    public static Func<OneOf<T0, T1, T2>, TResult > Match<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<TResult> otherwise = null)
        {
			return oneof =>
			{
					if (oneof.IsT0 && f0 != null) return f0(oneof.AsT0);
					if (oneof.IsT1 && f1 != null) return f1(oneof.AsT1);
					if (oneof.IsT2 && f2 != null) return f2(oneof.AsT2);

		        if (otherwise != null) return otherwise();
	    		throw new InvalidOperationException();
    		};
		}
		
		bool Equals(OneOf<T0, T1, T2> other)
        {
            return index == other.index && Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<T0, T1, T2> && Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }
        }

	}


	public struct OneOf<T0, T1, T2, T3> : IOneOf
    {
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    { this.value = value; this.index = index;	     }
	
		object IOneOf.Value { get { return value; } }
	
	    T Get<T>(int index)
	    {
		    if (index != this.index)
		    {
		    	throw new InvalidOperationException("Cannot return as T" + index + " as result is T" + this.index);
            }
	        return (T)value;
	    }


        public bool IsT0 { get { return index == 0; } }
        public T0 AsT0 { get { return Get<T0>(0); } } 
        public static implicit operator OneOf<T0, T1, T2, T3> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3>(t, 0);
        }


        public bool IsT1 { get { return index == 1; } }
        public T1 AsT1 { get { return Get<T1>(1); } } 
        public static implicit operator OneOf<T0, T1, T2, T3> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3>(t, 1);
        }


        public bool IsT2 { get { return index == 2; } }
        public T2 AsT2 { get { return Get<T2>(2); } } 
        public static implicit operator OneOf<T0, T1, T2, T3> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3>(t, 2);
        }


        public bool IsT3 { get { return index == 3; } }
        public T3 AsT3 { get { return Get<T3>(3); } } 
        public static implicit operator OneOf<T0, T1, T2, T3> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3>(t, 3);
        }


	    public static Func<OneOf<T0, T1, T2, T3>, TResult > Match<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<TResult> otherwise = null)
        {
			return oneof =>
			{
					if (oneof.IsT0 && f0 != null) return f0(oneof.AsT0);
					if (oneof.IsT1 && f1 != null) return f1(oneof.AsT1);
					if (oneof.IsT2 && f2 != null) return f2(oneof.AsT2);
					if (oneof.IsT3 && f3 != null) return f3(oneof.AsT3);

		        if (otherwise != null) return otherwise();
	    		throw new InvalidOperationException();
    		};
		}
		
		bool Equals(OneOf<T0, T1, T2, T3> other)
        {
            return index == other.index && Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<T0, T1, T2, T3> && Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }
        }

	}


	public struct OneOf<T0, T1, T2, T3, T4> : IOneOf
    {
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    { this.value = value; this.index = index;	     }
	
		object IOneOf.Value { get { return value; } }
	
	    T Get<T>(int index)
	    {
		    if (index != this.index)
		    {
		    	throw new InvalidOperationException("Cannot return as T" + index + " as result is T" + this.index);
            }
	        return (T)value;
	    }


        public bool IsT0 { get { return index == 0; } }
        public T0 AsT0 { get { return Get<T0>(0); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4>(t, 0);
        }


        public bool IsT1 { get { return index == 1; } }
        public T1 AsT1 { get { return Get<T1>(1); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4>(t, 1);
        }


        public bool IsT2 { get { return index == 2; } }
        public T2 AsT2 { get { return Get<T2>(2); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4>(t, 2);
        }


        public bool IsT3 { get { return index == 3; } }
        public T3 AsT3 { get { return Get<T3>(3); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4>(t, 3);
        }


        public bool IsT4 { get { return index == 4; } }
        public T4 AsT4 { get { return Get<T4>(4); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4>(t, 4);
        }


	    public static Func<OneOf<T0, T1, T2, T3, T4>, TResult > Match<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<TResult> otherwise = null)
        {
			return oneof =>
			{
					if (oneof.IsT0 && f0 != null) return f0(oneof.AsT0);
					if (oneof.IsT1 && f1 != null) return f1(oneof.AsT1);
					if (oneof.IsT2 && f2 != null) return f2(oneof.AsT2);
					if (oneof.IsT3 && f3 != null) return f3(oneof.AsT3);
					if (oneof.IsT4 && f4 != null) return f4(oneof.AsT4);

		        if (otherwise != null) return otherwise();
	    		throw new InvalidOperationException();
    		};
		}
		
		bool Equals(OneOf<T0, T1, T2, T3, T4> other)
        {
            return index == other.index && Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<T0, T1, T2, T3, T4> && Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }
        }

	}


	public struct OneOf<T0, T1, T2, T3, T4, T5> : IOneOf
    {
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    { this.value = value; this.index = index;	     }
	
		object IOneOf.Value { get { return value; } }
	
	    T Get<T>(int index)
	    {
		    if (index != this.index)
		    {
		    	throw new InvalidOperationException("Cannot return as T" + index + " as result is T" + this.index);
            }
	        return (T)value;
	    }


        public bool IsT0 { get { return index == 0; } }
        public T0 AsT0 { get { return Get<T0>(0); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 0);
        }


        public bool IsT1 { get { return index == 1; } }
        public T1 AsT1 { get { return Get<T1>(1); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 1);
        }


        public bool IsT2 { get { return index == 2; } }
        public T2 AsT2 { get { return Get<T2>(2); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 2);
        }


        public bool IsT3 { get { return index == 3; } }
        public T3 AsT3 { get { return Get<T3>(3); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 3);
        }


        public bool IsT4 { get { return index == 4; } }
        public T4 AsT4 { get { return Get<T4>(4); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 4);
        }


        public bool IsT5 { get { return index == 5; } }
        public T5 AsT5 { get { return Get<T5>(5); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5>(t, 5);
        }


	    public static Func<OneOf<T0, T1, T2, T3, T4, T5>, TResult > Match<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<TResult> otherwise = null)
        {
			return oneof =>
			{
					if (oneof.IsT0 && f0 != null) return f0(oneof.AsT0);
					if (oneof.IsT1 && f1 != null) return f1(oneof.AsT1);
					if (oneof.IsT2 && f2 != null) return f2(oneof.AsT2);
					if (oneof.IsT3 && f3 != null) return f3(oneof.AsT3);
					if (oneof.IsT4 && f4 != null) return f4(oneof.AsT4);
					if (oneof.IsT5 && f5 != null) return f5(oneof.AsT5);

		        if (otherwise != null) return otherwise();
	    		throw new InvalidOperationException();
    		};
		}
		
		bool Equals(OneOf<T0, T1, T2, T3, T4, T5> other)
        {
            return index == other.index && Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<T0, T1, T2, T3, T4, T5> && Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }
        }

	}


	public struct OneOf<T0, T1, T2, T3, T4, T5, T6> : IOneOf
    {
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    { this.value = value; this.index = index;	     }
	
		object IOneOf.Value { get { return value; } }
	
	    T Get<T>(int index)
	    {
		    if (index != this.index)
		    {
		    	throw new InvalidOperationException("Cannot return as T" + index + " as result is T" + this.index);
            }
	        return (T)value;
	    }


        public bool IsT0 { get { return index == 0; } }
        public T0 AsT0 { get { return Get<T0>(0); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 0);
        }


        public bool IsT1 { get { return index == 1; } }
        public T1 AsT1 { get { return Get<T1>(1); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 1);
        }


        public bool IsT2 { get { return index == 2; } }
        public T2 AsT2 { get { return Get<T2>(2); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 2);
        }


        public bool IsT3 { get { return index == 3; } }
        public T3 AsT3 { get { return Get<T3>(3); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 3);
        }


        public bool IsT4 { get { return index == 4; } }
        public T4 AsT4 { get { return Get<T4>(4); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 4);
        }


        public bool IsT5 { get { return index == 5; } }
        public T5 AsT5 { get { return Get<T5>(5); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 5);
        }


        public bool IsT6 { get { return index == 6; } }
        public T6 AsT6 { get { return Get<T6>(6); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6>(t, 6);
        }


	    public static Func<OneOf<T0, T1, T2, T3, T4, T5, T6>, TResult > Match<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<TResult> otherwise = null)
        {
			return oneof =>
			{
					if (oneof.IsT0 && f0 != null) return f0(oneof.AsT0);
					if (oneof.IsT1 && f1 != null) return f1(oneof.AsT1);
					if (oneof.IsT2 && f2 != null) return f2(oneof.AsT2);
					if (oneof.IsT3 && f3 != null) return f3(oneof.AsT3);
					if (oneof.IsT4 && f4 != null) return f4(oneof.AsT4);
					if (oneof.IsT5 && f5 != null) return f5(oneof.AsT5);
					if (oneof.IsT6 && f6 != null) return f6(oneof.AsT6);

		        if (otherwise != null) return otherwise();
	    		throw new InvalidOperationException();
    		};
		}
		
		bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6> other)
        {
            return index == other.index && Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6> && Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }
        }

	}


	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7> : IOneOf
    {
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    { this.value = value; this.index = index;	     }
	
		object IOneOf.Value { get { return value; } }
	
	    T Get<T>(int index)
	    {
		    if (index != this.index)
		    {
		    	throw new InvalidOperationException("Cannot return as T" + index + " as result is T" + this.index);
            }
	        return (T)value;
	    }


        public bool IsT0 { get { return index == 0; } }
        public T0 AsT0 { get { return Get<T0>(0); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 0);
        }


        public bool IsT1 { get { return index == 1; } }
        public T1 AsT1 { get { return Get<T1>(1); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 1);
        }


        public bool IsT2 { get { return index == 2; } }
        public T2 AsT2 { get { return Get<T2>(2); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 2);
        }


        public bool IsT3 { get { return index == 3; } }
        public T3 AsT3 { get { return Get<T3>(3); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 3);
        }


        public bool IsT4 { get { return index == 4; } }
        public T4 AsT4 { get { return Get<T4>(4); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 4);
        }


        public bool IsT5 { get { return index == 5; } }
        public T5 AsT5 { get { return Get<T5>(5); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 5);
        }


        public bool IsT6 { get { return index == 6; } }
        public T6 AsT6 { get { return Get<T6>(6); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 6);
        }


        public bool IsT7 { get { return index == 7; } }
        public T7 AsT7 { get { return Get<T7>(7); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7> (T7 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(t, 7);
        }


	    public static Func<OneOf<T0, T1, T2, T3, T4, T5, T6, T7>, TResult > Match<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<TResult> otherwise = null)
        {
			return oneof =>
			{
					if (oneof.IsT0 && f0 != null) return f0(oneof.AsT0);
					if (oneof.IsT1 && f1 != null) return f1(oneof.AsT1);
					if (oneof.IsT2 && f2 != null) return f2(oneof.AsT2);
					if (oneof.IsT3 && f3 != null) return f3(oneof.AsT3);
					if (oneof.IsT4 && f4 != null) return f4(oneof.AsT4);
					if (oneof.IsT5 && f5 != null) return f5(oneof.AsT5);
					if (oneof.IsT6 && f6 != null) return f6(oneof.AsT6);
					if (oneof.IsT7 && f7 != null) return f7(oneof.AsT7);

		        if (otherwise != null) return otherwise();
	    		throw new InvalidOperationException();
    		};
		}
		
		bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7> other)
        {
            return index == other.index && Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7> && Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }
        }

	}


	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IOneOf
    {
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    { this.value = value; this.index = index;	     }
	
		object IOneOf.Value { get { return value; } }
	
	    T Get<T>(int index)
	    {
		    if (index != this.index)
		    {
		    	throw new InvalidOperationException("Cannot return as T" + index + " as result is T" + this.index);
            }
	        return (T)value;
	    }


        public bool IsT0 { get { return index == 0; } }
        public T0 AsT0 { get { return Get<T0>(0); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T0 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 0);
        }


        public bool IsT1 { get { return index == 1; } }
        public T1 AsT1 { get { return Get<T1>(1); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T1 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 1);
        }


        public bool IsT2 { get { return index == 2; } }
        public T2 AsT2 { get { return Get<T2>(2); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T2 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 2);
        }


        public bool IsT3 { get { return index == 3; } }
        public T3 AsT3 { get { return Get<T3>(3); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T3 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 3);
        }


        public bool IsT4 { get { return index == 4; } }
        public T4 AsT4 { get { return Get<T4>(4); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T4 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 4);
        }


        public bool IsT5 { get { return index == 5; } }
        public T5 AsT5 { get { return Get<T5>(5); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T5 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 5);
        }


        public bool IsT6 { get { return index == 6; } }
        public T6 AsT6 { get { return Get<T6>(6); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T6 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 6);
        }


        public bool IsT7 { get { return index == 7; } }
        public T7 AsT7 { get { return Get<T7>(7); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T7 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 7);
        }


        public bool IsT8 { get { return index == 8; } }
        public T8 AsT8 { get { return Get<T8>(8); } } 
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> (T8 t)
        {
	         return new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, 8);
        }


	    public static Func<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>, TResult > Match<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<TResult> otherwise = null)
        {
			return oneof =>
			{
					if (oneof.IsT0 && f0 != null) return f0(oneof.AsT0);
					if (oneof.IsT1 && f1 != null) return f1(oneof.AsT1);
					if (oneof.IsT2 && f2 != null) return f2(oneof.AsT2);
					if (oneof.IsT3 && f3 != null) return f3(oneof.AsT3);
					if (oneof.IsT4 && f4 != null) return f4(oneof.AsT4);
					if (oneof.IsT5 && f5 != null) return f5(oneof.AsT5);
					if (oneof.IsT6 && f6 != null) return f6(oneof.AsT6);
					if (oneof.IsT7 && f7 != null) return f7(oneof.AsT7);
					if (oneof.IsT8 && f8 != null) return f8(oneof.AsT8);

		        if (otherwise != null) return otherwise();
	    		throw new InvalidOperationException();
    		};
		}
		
		bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            return index == other.index && Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> && Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }
        }

	}

}
