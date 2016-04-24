<Query Kind="Program" />

void Main()
{
	var sb = new StringBuilder();
	sb.AppendLine(@"
using System;

using Newtonsoft.Json;
namespace OneOf
{
    public interface IOneOf { object Value { get ; } }
  

    [JsonConverter(typeof(OneOfJsonConverter))]
  public struct OneOf<T0> : IOneOf
    {
      readonly object value;
      readonly int index;

      OneOf(object value, int index)      { this.value = value; this.index = index;       }
  
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


      public void Match(Action<T0> f0)
        {
      
      if (this.IsT0 && f0 != null) { f0(this.AsT0); return; }

        throw new InvalidOperationException();
    }


      public TResult Match<TResult>(Func<T0, TResult> f0)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);

        throw new InvalidOperationException();
    }


      public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<TResult> otherwise = null)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);

        if (otherwise != null) return otherwise();
        throw new InvalidOperationException();
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


    [JsonConverter(typeof(OneOfJsonConverter))]
  public struct OneOf<T0, T1> : IOneOf
    {
      readonly object value;
      readonly int index;

      OneOf(object value, int index)      { this.value = value; this.index = index;       }
  
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


      public void Match(Action<T0> f0, Action<T1> f1)
        {
      
      if (this.IsT0 && f0 != null) { f0(this.AsT0); return; }
      if (this.IsT1 && f1 != null) { f1(this.AsT1); return; }

        throw new InvalidOperationException();
    }


      public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);

        throw new InvalidOperationException();
    }


      public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<TResult> otherwise = null)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);

        if (otherwise != null) return otherwise();
        throw new InvalidOperationException();
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


    [JsonConverter(typeof(OneOfJsonConverter))]
  public struct OneOf<T0, T1, T2> : IOneOf
    {
      readonly object value;
      readonly int index;

      OneOf(object value, int index)      { this.value = value; this.index = index;       }
  
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


      public void Match(Action<T0> f0, Action<T1> f1, Action<T2> f2)
        {
      
      if (this.IsT0 && f0 != null) { f0(this.AsT0); return; }
      if (this.IsT1 && f1 != null) { f1(this.AsT1); return; }
      if (this.IsT2 && f2 != null) { f2(this.AsT2); return; }

        throw new InvalidOperationException();
    }


      public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);

        throw new InvalidOperationException();
    }


      public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<TResult> otherwise = null)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);

        if (otherwise != null) return otherwise();
        throw new InvalidOperationException();
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


    [JsonConverter(typeof(OneOfJsonConverter))]
  public struct OneOf<T0, T1, T2, T3> : IOneOf
    {
      readonly object value;
      readonly int index;

      OneOf(object value, int index)      { this.value = value; this.index = index;       }
  
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


      public void Match(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3)
        {
      
      if (this.IsT0 && f0 != null) { f0(this.AsT0); return; }
      if (this.IsT1 && f1 != null) { f1(this.AsT1); return; }
      if (this.IsT2 && f2 != null) { f2(this.AsT2); return; }
      if (this.IsT3 && f3 != null) { f3(this.AsT3); return; }

        throw new InvalidOperationException();
    }


      public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);

        throw new InvalidOperationException();
    }


      public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<TResult> otherwise = null)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);

        if (otherwise != null) return otherwise();
        throw new InvalidOperationException();
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


    [JsonConverter(typeof(OneOfJsonConverter))]
  public struct OneOf<T0, T1, T2, T3, T4> : IOneOf
    {
      readonly object value;
      readonly int index;

      OneOf(object value, int index)      { this.value = value; this.index = index;       }
  
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


      public void Match(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4)
        {
      
      if (this.IsT0 && f0 != null) { f0(this.AsT0); return; }
      if (this.IsT1 && f1 != null) { f1(this.AsT1); return; }
      if (this.IsT2 && f2 != null) { f2(this.AsT2); return; }
      if (this.IsT3 && f3 != null) { f3(this.AsT3); return; }
      if (this.IsT4 && f4 != null) { f4(this.AsT4); return; }

        throw new InvalidOperationException();
    }


      public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);
      if (this.IsT4 && f4 != null) return f4(this.AsT4);

        throw new InvalidOperationException();
    }


      public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<TResult> otherwise = null)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);
      if (this.IsT4 && f4 != null) return f4(this.AsT4);

        if (otherwise != null) return otherwise();
        throw new InvalidOperationException();
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


    [JsonConverter(typeof(OneOfJsonConverter))]
  public struct OneOf<T0, T1, T2, T3, T4, T5> : IOneOf
    {
      readonly object value;
      readonly int index;

      OneOf(object value, int index)      { this.value = value; this.index = index;       }
  
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


      public void Match(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5)
        {
      
      if (this.IsT0 && f0 != null) { f0(this.AsT0); return; }
      if (this.IsT1 && f1 != null) { f1(this.AsT1); return; }
      if (this.IsT2 && f2 != null) { f2(this.AsT2); return; }
      if (this.IsT3 && f3 != null) { f3(this.AsT3); return; }
      if (this.IsT4 && f4 != null) { f4(this.AsT4); return; }
      if (this.IsT5 && f5 != null) { f5(this.AsT5); return; }

        throw new InvalidOperationException();
    }


      public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);
      if (this.IsT4 && f4 != null) return f4(this.AsT4);
      if (this.IsT5 && f5 != null) return f5(this.AsT5);

        throw new InvalidOperationException();
    }


      public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<TResult> otherwise = null)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);
      if (this.IsT4 && f4 != null) return f4(this.AsT4);
      if (this.IsT5 && f5 != null) return f5(this.AsT5);

        if (otherwise != null) return otherwise();
        throw new InvalidOperationException();
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


    [JsonConverter(typeof(OneOfJsonConverter))]
  public struct OneOf<T0, T1, T2, T3, T4, T5, T6> : IOneOf
    {
      readonly object value;
      readonly int index;

      OneOf(object value, int index)      { this.value = value; this.index = index;       }
  
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


      public void Match(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6)
        {
      
      if (this.IsT0 && f0 != null) { f0(this.AsT0); return; }
      if (this.IsT1 && f1 != null) { f1(this.AsT1); return; }
      if (this.IsT2 && f2 != null) { f2(this.AsT2); return; }
      if (this.IsT3 && f3 != null) { f3(this.AsT3); return; }
      if (this.IsT4 && f4 != null) { f4(this.AsT4); return; }
      if (this.IsT5 && f5 != null) { f5(this.AsT5); return; }
      if (this.IsT6 && f6 != null) { f6(this.AsT6); return; }

        throw new InvalidOperationException();
    }


      public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);
      if (this.IsT4 && f4 != null) return f4(this.AsT4);
      if (this.IsT5 && f5 != null) return f5(this.AsT5);
      if (this.IsT6 && f6 != null) return f6(this.AsT6);

        throw new InvalidOperationException();
    }


      public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<TResult> otherwise = null)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);
      if (this.IsT4 && f4 != null) return f4(this.AsT4);
      if (this.IsT5 && f5 != null) return f5(this.AsT5);
      if (this.IsT6 && f6 != null) return f6(this.AsT6);

        if (otherwise != null) return otherwise();
        throw new InvalidOperationException();
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


    [JsonConverter(typeof(OneOfJsonConverter))]
  public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7> : IOneOf
    {
      readonly object value;
      readonly int index;

      OneOf(object value, int index)      { this.value = value; this.index = index;       }
  
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


      public void Match(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7)
        {
      
      if (this.IsT0 && f0 != null) { f0(this.AsT0); return; }
      if (this.IsT1 && f1 != null) { f1(this.AsT1); return; }
      if (this.IsT2 && f2 != null) { f2(this.AsT2); return; }
      if (this.IsT3 && f3 != null) { f3(this.AsT3); return; }
      if (this.IsT4 && f4 != null) { f4(this.AsT4); return; }
      if (this.IsT5 && f5 != null) { f5(this.AsT5); return; }
      if (this.IsT6 && f6 != null) { f6(this.AsT6); return; }
      if (this.IsT7 && f7 != null) { f7(this.AsT7); return; }

        throw new InvalidOperationException();
    }


      public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);
      if (this.IsT4 && f4 != null) return f4(this.AsT4);
      if (this.IsT5 && f5 != null) return f5(this.AsT5);
      if (this.IsT6 && f6 != null) return f6(this.AsT6);
      if (this.IsT7 && f7 != null) return f7(this.AsT7);

        throw new InvalidOperationException();
    }


      public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<TResult> otherwise = null)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);
      if (this.IsT4 && f4 != null) return f4(this.AsT4);
      if (this.IsT5 && f5 != null) return f5(this.AsT5);
      if (this.IsT6 && f6 != null) return f6(this.AsT6);
      if (this.IsT7 && f7 != null) return f7(this.AsT7);

        if (otherwise != null) return otherwise();
        throw new InvalidOperationException();
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


    [JsonConverter(typeof(OneOfJsonConverter))]
  public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IOneOf
    {
      readonly object value;
      readonly int index;

      OneOf(object value, int index)      { this.value = value; this.index = index;       }
  
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


      public void Match(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8)
        {
      
      if (this.IsT0 && f0 != null) { f0(this.AsT0); return; }
      if (this.IsT1 && f1 != null) { f1(this.AsT1); return; }
      if (this.IsT2 && f2 != null) { f2(this.AsT2); return; }
      if (this.IsT3 && f3 != null) { f3(this.AsT3); return; }
      if (this.IsT4 && f4 != null) { f4(this.AsT4); return; }
      if (this.IsT5 && f5 != null) { f5(this.AsT5); return; }
      if (this.IsT6 && f6 != null) { f6(this.AsT6); return; }
      if (this.IsT7 && f7 != null) { f7(this.AsT7); return; }
      if (this.IsT8 && f8 != null) { f8(this.AsT8); return; }

        throw new InvalidOperationException();
    }


      public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);
      if (this.IsT4 && f4 != null) return f4(this.AsT4);
      if (this.IsT5 && f5 != null) return f5(this.AsT5);
      if (this.IsT6 && f6 != null) return f6(this.AsT6);
      if (this.IsT7 && f7 != null) return f7(this.AsT7);
      if (this.IsT8 && f8 != null) return f8(this.AsT8);

        throw new InvalidOperationException();
    }


      public TResult MatchSome<TResult>(Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<T3, TResult> f3 = null, Func<T4, TResult> f4 = null, Func<T5, TResult> f5 = null, Func<T6, TResult> f6 = null, Func<T7, TResult> f7 = null, Func<T8, TResult> f8 = null, Func<TResult> otherwise = null)
        {
      
      if (this.IsT0 && f0 != null) return f0(this.AsT0);
      if (this.IsT1 && f1 != null) return f1(this.AsT1);
      if (this.IsT2 && f2 != null) return f2(this.AsT2);
      if (this.IsT3 && f3 != null) return f3(this.AsT3);
      if (this.IsT4 && f4 != null) return f4(this.AsT4);
      if (this.IsT5 && f5 != null) return f5(this.AsT5);
      if (this.IsT6 && f6 != null) return f6(this.AsT6);
      if (this.IsT7 && f7 != null) return f7(this.AsT7);
      if (this.IsT8 && f8 != null) return f8(this.AsT8);

        if (otherwise != null) return otherwise();
        throw new InvalidOperationException();
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

C:\Users\Harry\Dropbox\stuff\OneOf\OneOf\OneOf.cs


namespace OneOf
{
    public interface IOneOf { object Value { get ; } }
	");
	for (var i = 1; i < 10; i++)
	{
		var genericArg = string.Join(", ", Enumerable.Range(0, i).Select(e => "T" + e));



	
		sb.AppendLine(string.Format(

@"
    [JsonConverter(typeof(OneOfJsonConverter))]
	public struct OneOf<{0}> : IOneOf
    {{
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    {{ this.value = value; this.index = index;	     }}
	
		object IOneOf.Value {{ get {{ return value; }} }}
	
	    T Get<T>(int index)
	    {{
		    if (index != this.index)
		    {{
		    	throw new InvalidOperationException(""Cannot return as T"" + index + "" as result is T"" + this.index);
            }}
	        return (T)value;
	    }}
", genericArg));
		for (var j = 0; j < i; j++)
		{
			sb.AppendLine(string.Format(
@"
        public bool IsT{0} {{ get {{ return index == {0}; }} }}
        public T{0} AsT{0} {{ get {{ return Get<T{0}>({0}); }} }} 
        public static implicit operator OneOf<{1}> (T{0} t)
        {{
	         return new OneOf<{1}>(t, {0});
        }}
", j, genericArg));
		}

		var matchArgList0 = string.Join(", ", Enumerable.Range(0, i).Select(e => "Action<T" + e + "> f" + e));
		sb.AppendLine(string.Format(@"
	    public void Match({1})
        {{
			", genericArg, matchArgList0));

		for (var j = 0; j < i; j++)
		{
			sb.AppendLine(string.Format(@"			if (this.IsT{0} && f{0} != null) {{ f{0}(this.AsT{0}); return; }}", j));
		}

		sb.AppendLine(string.Format(@"
	    	throw new InvalidOperationException();
		}}
"));

		var matchArgList = string.Join(", ", Enumerable.Range(0, i).Select(e => "Func<T" + e + ", TResult> f" + e));
		sb.AppendLine(string.Format(@"
	    public TResult Match<TResult>({1})
        {{
			", genericArg, matchArgList));

		for (var j = 0; j < i; j++)
		{
			sb.AppendLine(string.Format(@"			if (this.IsT{0} && f{0} != null) return f{0}(this.AsT{0});", j));
		}

		sb.AppendLine(string.Format(@"
	    	throw new InvalidOperationException();
		}}
"));

		var matchArgList2 = string.Join(", ", Enumerable.Range(0, i).Select(e => "Func<T" + e + ", TResult> f" + e + " = null"));
		sb.AppendLine(string.Format(@"
	    public TResult MatchSome<TResult>({1}, Func<TResult> otherwise = null)
        {{
			", genericArg, matchArgList2));

		for (var j = 0; j < i; j++)
		{
			sb.AppendLine(string.Format(@"			if (this.IsT{0} && f{0} != null) return f{0}(this.AsT{0});", j));
		}

		sb.AppendLine(string.Format(@"
		    if (otherwise != null) return otherwise();
	    	throw new InvalidOperationException();
		}}
"));

		sb.AppendLine(string.Format(@"
		
		bool Equals(OneOf<{0}> other)
        {{
            return index == other.index && Equals(value, other.value);
        }}

        public override bool Equals(object obj)
        {{
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<{0}> && Equals(obj);
        }}

        public override int GetHashCode()
        {{
            unchecked
            {{
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }}
        }}

	}}
", genericArg));
	}
	sb.AppendLine("}");
	sb.ToString().Dump();
	var outpath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "OneOf.cs");
	File.WriteAllText(outpath.Dump(), sb.ToString());
}