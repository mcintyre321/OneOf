using System;
using static OneOf.Functions;

namespace OneOf
{
    public readonly struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : IOneOf
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

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default, T6 value6 = default, T7 value7 = default, T8 value8 = default, T9 value9 = default, T10 value10 = default, T11 value11 = default, T12 value12 = default, T13 value13 = default, T14 value14 = default, T15 value15 = default, T16 value16 = default, T17 value17 = default, T18 value18 = default, T19 value19 = default)
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

    public object Value { get {
                    switch (_index)
                    {
                            case 0: return _value0;
                case 1: return _value1;
                case 2: return _value2;
                case 3: return _value3;
                case 4: return _value4;
                case 5: return _value5;
                case 6: return _value6;
                case 7: return _value7;
                case 8: return _value8;
                case 9: return _value9;
                case 10: return _value10;
                case 11: return _value11;
                case 12: return _value12;
                case 13: return _value13;
                case 14: return _value14;
                case 15: return _value15;
                case 16: return _value16;
                case 17: return _value17;
                case 18: return _value18;
                case 19: return _value19;
                            default: throw new InvalidOperationException();
                        };
                } }

        public int Index => _index;

        public bool IsT0 => _index == 0;
        public bool IsT1 => _index == 1;
        public bool IsT2 => _index == 2;
        public bool IsT3 => _index == 3;
        public bool IsT4 => _index == 4;
        public bool IsT5 => _index == 5;
        public bool IsT6 => _index == 6;
        public bool IsT7 => _index == 7;
        public bool IsT8 => _index == 8;
        public bool IsT9 => _index == 9;
        public bool IsT10 => _index == 10;
        public bool IsT11 => _index == 11;
        public bool IsT12 => _index == 12;
        public bool IsT13 => _index == 13;
        public bool IsT14 => _index == 14;
        public bool IsT15 => _index == 15;
        public bool IsT16 => _index == 16;
        public bool IsT17 => _index == 17;
        public bool IsT18 => _index == 18;
        public bool IsT19 => _index == 19;

        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
        public T4 AsT4 =>
            _index == 4 ?
                _value4 :
                throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
        public T5 AsT5 =>
            _index == 5 ?
                _value5 :
                throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
        public T6 AsT6 =>
            _index == 6 ?
                _value6 :
                throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
        public T7 AsT7 =>
            _index == 7 ?
                _value7 :
                throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
        public T8 AsT8 =>
            _index == 8 ?
                _value8 :
                throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
        public T9 AsT9 =>
            _index == 9 ?
                _value9 :
                throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
        public T10 AsT10 =>
            _index == 10 ?
                _value10 :
                throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
        public T11 AsT11 =>
            _index == 11 ?
                _value11 :
                throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
        public T12 AsT12 =>
            _index == 12 ?
                _value12 :
                throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
        public T13 AsT13 =>
            _index == 13 ?
                _value13 :
                throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
        public T14 AsT14 =>
            _index == 14 ?
                _value14 :
                throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
        public T15 AsT15 =>
            _index == 15 ?
                _value15 :
                throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
        public T16 AsT16 =>
            _index == 16 ?
                _value16 :
                throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
        public T17 AsT17 =>
            _index == 17 ?
                _value17 :
                throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
        public T18 AsT18 =>
            _index == 18 ?
                _value18 :
                throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
        public T19 AsT19 =>
            _index == 19 ?
                _value19 :
                throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(0, value0: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(1, value1: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(2, value2: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(3, value3: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(4, value4: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(5, value5: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(6, value6: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(7, value7: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T8 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(8, value8: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T9 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(9, value9: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T10 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(10, value10: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T11 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(11, value11: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T12 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(12, value12: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T13 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(13, value13: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T14 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(14, value14: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T15 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(15, value15: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T16 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(16, value16: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T17 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(17, value17: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T18 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(18, value18: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T19 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(19, value19: t);

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

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT3(T3 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT4(T4 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT5(T5 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT6(T6 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT7(T7 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT8(T8 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT9(T9 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT10(T10 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT11(T11 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT12(T12 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT13(T13 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT14(T14 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT15(T15 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT16(T16 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT17(T17 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT18(T18 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> FromT19(T19 input) => input;

        
        public OneOf<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return mapFunc(AsT0);
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return mapFunc(AsT1);
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return mapFunc(AsT2);
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return mapFunc(AsT3);
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return mapFunc(AsT4);
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return mapFunc(AsT5);
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT6<TResult>(Func<T6, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return mapFunc(AsT6);
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT7<TResult>(Func<T7, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return mapFunc(AsT7);
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, TResult, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT8<TResult>(Func<T8, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return mapFunc(AsT8);
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT9<TResult>(Func<T9, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return mapFunc(AsT9);
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult, T11, T12, T13, T14, T15, T16, T17, T18, T19> MapT10<TResult>(Func<T10, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return mapFunc(AsT10);
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult, T12, T13, T14, T15, T16, T17, T18, T19> MapT11<TResult>(Func<T11, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return mapFunc(AsT11);
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult, T13, T14, T15, T16, T17, T18, T19> MapT12<TResult>(Func<T12, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return mapFunc(AsT12);
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult, T14, T15, T16, T17, T18, T19> MapT13<TResult>(Func<T13, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return mapFunc(AsT13);
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult, T15, T16, T17, T18, T19> MapT14<TResult>(Func<T14, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return mapFunc(AsT14);
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult, T16, T17, T18, T19> MapT15<TResult>(Func<T15, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return mapFunc(AsT15);
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult, T17, T18, T19> MapT16<TResult>(Func<T16, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return mapFunc(AsT16);
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult, T18, T19> MapT17<TResult>(Func<T17, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return mapFunc(AsT17);
                case 18: return AsT18;
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TResult, T19> MapT18<TResult>(Func<T18, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return mapFunc(AsT18);
                case 19: return AsT19;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TResult> MapT19<TResult>(Func<T19, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                case 8: return AsT8;
                case 9: return AsT9;
                case 10: return AsT10;
                case 11: return AsT11;
                case 12: return AsT12;
                case 13: return AsT13;
                case 14: return AsT14;
                case 15: return AsT15;
                case 16: return AsT16;
                case 17: return AsT17;
                case 18: return AsT18;
                case 19: return mapFunc(AsT19);
                  default: throw new InvalidOperationException();
            }
        }

        public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT0 ? AsT0 : default;
            switch (_index)
            {
                case 0: { remainder = default; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT0;
        }
        
        public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT1 ? AsT1 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = default; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT1;
        }
        
        public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT2 ? AsT2 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = default; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT2;
        }
        
        public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT3 ? AsT3 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = default; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT3;
        }
        
        public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT4 ? AsT4 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = default; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT4;
        }
        
        public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT5 ? AsT5 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = default; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT5;
        }
        
        public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT6 ? AsT6 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = default; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT6;
        }
        
        public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT7 ? AsT7 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = default; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT7;
        }
        
        public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT8 ? AsT8 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = default; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT8;
        }
        
        public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT9 ? AsT9 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = default; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT9;
        }
        
        public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT10 ? AsT10 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = default; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT10;
        }
        
        public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT11 ? AsT11 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = default; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT11;
        }
        
        public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT12 ? AsT12 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = default; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT12;
        }
        
        public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT13 ? AsT13 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = default; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT13;
        }
        
        public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19> remainder)
        {
            value = IsT14 ? AsT14 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = default; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT14;
        }
        
        public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19> remainder)
        {
            value = IsT15 ? AsT15 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = default; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT15;
        }
        
        public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19> remainder)
        {
            value = IsT16 ? AsT16 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = default; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT16;
        }
        
        public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19> remainder)
        {
            value = IsT17 ? AsT17 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = default; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT17;
        }
        
        public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19> remainder)
        {
            value = IsT18 ? AsT18 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = default; break; }
                case 19: { remainder = AsT19; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT18;
        }
        
        public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
        {
            value = IsT19 ? AsT19 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                case 8: { remainder = AsT8; break; }
                case 9: { remainder = AsT9; break; }
                case 10: { remainder = AsT10; break; }
                case 11: { remainder = AsT11; break; }
                case 12: { remainder = AsT12; break; }
                case 13: { remainder = AsT13; break; }
                case 14: { remainder = AsT14; break; }
                case 15: { remainder = AsT15; break; }
                case 16: { remainder = AsT16; break; }
                case 17: { remainder = AsT17; break; }
                case 18: { remainder = AsT18; break; }
                case 19: { remainder = default; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT19;
        }

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> other) {
            var check1 = _index == other._index;
            if (!check1) { return false; }
            switch (_index)
            {
                case 0: return check1 && Equals(_value0, other._value0);
                             case 1: return check1 && Equals(_value1, other._value1);
                             case 2: return check1 && Equals(_value2, other._value2);
                             case 3: return check1 && Equals(_value3, other._value3);
                             case 4: return check1 && Equals(_value4, other._value4);
                             case 5: return check1 && Equals(_value5, other._value5);
                             case 6: return check1 && Equals(_value6, other._value6);
                             case 7: return check1 && Equals(_value7, other._value7);
                             case 8: return check1 && Equals(_value8, other._value8);
                             case 9: return check1 && Equals(_value9, other._value9);
                             case 10: return check1 && Equals(_value10, other._value10);
                             case 11: return check1 && Equals(_value11, other._value11);
                             case 12: return check1 && Equals(_value12, other._value12);
                             case 13: return check1 && Equals(_value13, other._value13);
                             case 14: return check1 && Equals(_value14, other._value14);
                             case 15: return check1 && Equals(_value15, other._value15);
                             case 16: return check1 && Equals(_value16, other._value16);
                             case 17: return check1 && Equals(_value17, other._value17);
                             case 18: return check1 && Equals(_value18, other._value18);
                             case 19: return check1 && Equals(_value19, other._value19);
                default: return false;
            };
                             }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> o && Equals(o);
        }

        public override string ToString() {
            switch (_index) {
                case 0: return FormatValue(_value0);
                case 1: return FormatValue(_value1);
                case 2: return FormatValue(_value2);
                case 3: return FormatValue(_value3);
                case 4: return FormatValue(_value4);
                case 5: return FormatValue(_value5);
                case 6: return FormatValue(_value6);
                case 7: return FormatValue(_value7);
                case 8: return FormatValue(_value8);
                case 9: return FormatValue(_value9);
                case 10: return FormatValue(_value10);
                case 11: return FormatValue(_value11);
                case 12: return FormatValue(_value12);
                case 13: return FormatValue(_value13);
                case 14: return FormatValue(_value14);
                case 15: return FormatValue(_value15);
                case 16: return FormatValue(_value16);
                case 17: return FormatValue(_value17);
                case 18: return FormatValue(_value18);
                case 19: return FormatValue(_value19);
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
                    case 1: { hashCode = _value1?.GetHashCode() ?? 0; break; }
                    case 2: { hashCode = _value2?.GetHashCode() ?? 0; break; }
                    case 3: { hashCode = _value3?.GetHashCode() ?? 0; break; }
                    case 4: { hashCode = _value4?.GetHashCode() ?? 0; break; }
                    case 5: { hashCode = _value5?.GetHashCode() ?? 0; break; }
                    case 6: { hashCode = _value6?.GetHashCode() ?? 0; break; }
                    case 7: { hashCode = _value7?.GetHashCode() ?? 0; break; }
                    case 8: { hashCode = _value8?.GetHashCode() ?? 0; break; }
                    case 9: { hashCode = _value9?.GetHashCode() ?? 0; break; }
                    case 10: { hashCode = _value10?.GetHashCode() ?? 0; break; }
                    case 11: { hashCode = _value11?.GetHashCode() ?? 0; break; }
                    case 12: { hashCode = _value12?.GetHashCode() ?? 0; break; }
                    case 13: { hashCode = _value13?.GetHashCode() ?? 0; break; }
                    case 14: { hashCode = _value14?.GetHashCode() ?? 0; break; }
                    case 15: { hashCode = _value15?.GetHashCode() ?? 0; break; }
                    case 16: { hashCode = _value16?.GetHashCode() ?? 0; break; }
                    case 17: { hashCode = _value17?.GetHashCode() ?? 0; break; }
                    case 18: { hashCode = _value18?.GetHashCode() ?? 0; break; }
                    case 19: { hashCode = _value19?.GetHashCode() ?? 0; break; }
                    default: { hashCode = 0; break; }
                }
                return (hashCode*397) ^ _index;
            }
        }
    }
}
