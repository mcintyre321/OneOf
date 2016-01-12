using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace OneOf
{
    public static class MatchExtension
    {
        public static TResult Match<T0, TResult>(this OneOf<T0> oneOf, Func<T0, TResult> f0 = null, Func<TResult> otherwise = null)
        {
            if (oneOf.IsT0 && f0 != null) return f0(oneOf.AsT0);
            if (otherwise != null) return otherwise();
            throw new InvalidOperationException();
        }

        public static TResult Match<T0, T1, TResult>(this OneOf<T0, T1> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<TResult> otherwise = null)
        {
            if (oneOf.IsT0 && f0 != null) return f0(oneOf.AsT0);
            if (oneOf.IsT1 && f1 != null) return f1(oneOf.AsT1);
            if (otherwise != null) return otherwise();
            throw new InvalidOperationException();
        }

        public static TResult Match<T0, T1, T2, TResult>(this OneOf<T0, T1, T2> oneOf, Func<T0, TResult> f0 = null, Func<T1, TResult> f1 = null, Func<T2, TResult> f2 = null, Func<TResult> otherwise = null)
        {
            if (oneOf.IsT0 && f0 != null) return f0(oneOf.AsT0);
            if (oneOf.IsT1 && f1 != null) return f1(oneOf.AsT1);
            if (oneOf.IsT2 && f2 != null) return f2(oneOf.AsT2);
            if (otherwise != null) return otherwise();
            throw new InvalidOperationException();
        }
    }

    public struct OneOf<T0> : IOneOf
    {
        private readonly object _value;
        private readonly int _index;

        OneOf(object value, int index)
        {
            _value = value;
            _index = index;
        }

        object IOneOf.Value => _value;

        public bool IsT0 => _index == 0;
        public T0 AsT0 => _value == null ? default(T0) : (T0)_value;
        public static implicit operator OneOf.OneOf<T0>(T0 t) => new OneOf<T0>(t, 0);

    }

    public struct OneOf<T0, T1> : IOneOf
    {
        private readonly object _value;
        private readonly int _index;

        OneOf(object value, int index)
        {
            _value = value;
            _index = index;
        }

        object IOneOf.Value => _value;

        public bool IsT0 => _index == 0;
        public T0 AsT0 => _value == null ? default(T0) : (T0)_value;
        public static implicit operator OneOf.OneOf<T0, T1>(T0 t) => new OneOf<T0, T1>(t, 0);

        public bool IsT1 => _index == 1;
        public T1 AsT1 => _value == null ? default(T1) : (T1)_value;
        public static implicit operator OneOf.OneOf<T0, T1>(T1 t) => new OneOf<T0, T1>(t, 1);


    }
    public struct OneOf<T0, T1, T2> : IOneOf
    {
        private readonly object _value;
        private readonly int _index;

        OneOf(object value, int index)
        {
            _value = value;
            _index = index;
        }

        object IOneOf.Value => _value;

        public bool IsT0 => _index == 0;
        public T0 AsT0 => _value == null ? default(T0) : (T0)_value;
        public static implicit operator OneOf.OneOf<T0, T1, T2>(T0 t) => new OneOf<T0, T1, T2>(t, 0);

        public bool IsT1 => _index == 1;
        public T1 AsT1 => _value == null ? default(T1) : (T1)_value;
        public static implicit operator OneOf.OneOf<T0, T1, T2>(T1 t) => new OneOf<T0, T1, T2>(t, 1);

        public bool IsT2 => _index == 2;
        public T2 AsT2 => _value == null ? default(T2) : (T2)_value;
        public static implicit operator OneOf.OneOf<T0, T1, T2>(T2 t) => new OneOf<T0, T1, T2>(t, 2);

    }



    public interface IOneOf
    {
        object Value { get; }
    }
}
