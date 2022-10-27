using System;
using static OneOf.Functions;

namespace OneOf
{
    public readonly struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IOneOf
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

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default, T6 value6 = default, T7 value7 = default, T8 value8 = default, T9 value9 = default, T10 value10 = default, T11 value11 = default, T12 value12 = default, T13 value13 = default, T14 value14 = default, T15 value15 = default)
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

        public object Value =>
            _index switch
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
                9 => _value9,
                10 => _value10,
                11 => _value11,
                12 => _value12,
                13 => _value13,
                14 => _value14,
                15 => _value15,
                _ => throw new InvalidOperationException()
            };

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

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(0, value0: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(1, value1: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(2, value2: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(3, value3: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(4, value4: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(5, value5: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(6, value6: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(7, value7: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T8 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(8, value8: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T9 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(9, value9: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T10 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(10, value10: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T11 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(11, value11: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T12 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(12, value12: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T13 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(13, value13: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T14 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(14, value14: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T15 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(15, value15: t);

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

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT3(T3 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT4(T4 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT5(T5 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT6(T6 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT7(T7 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT8(T8 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT9(T9 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT10(T10 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT11(T11 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT12(T12 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT13(T13 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT14(T14 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> FromT15(T15 input) => input;

        
        public OneOf<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7, T8, T9, T10, T11, T12, T13, T14, T15> MapT6<TResult>(Func<T6, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult, T8, T9, T10, T11, T12, T13, T14, T15> MapT7<TResult>(Func<T7, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, TResult, T9, T10, T11, T12, T13, T14, T15> MapT8<TResult>(Func<T8, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult, T10, T11, T12, T13, T14, T15> MapT9<TResult>(Func<T9, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                8 => AsT8,
                9 => mapFunc(AsT9),
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult, T11, T12, T13, T14, T15> MapT10<TResult>(Func<T10, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                8 => AsT8,
                9 => AsT9,
                10 => mapFunc(AsT10),
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult, T12, T13, T14, T15> MapT11<TResult>(Func<T11, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => mapFunc(AsT11),
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult, T13, T14, T15> MapT12<TResult>(Func<T12, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => mapFunc(AsT12),
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult, T14, T15> MapT13<TResult>(Func<T13, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => mapFunc(AsT13),
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult, T15> MapT14<TResult>(Func<T14, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => mapFunc(AsT14),
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> MapT15<TResult>(Func<T15, TResult> mapFunc)
        {
            if (mapFunc == null)
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
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => mapFunc(AsT15),
                _ => throw new InvalidOperationException()
            };
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT0 ? AsT0 : default;
            remainder = _index switch
            {
                0 => default,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT0;
		}
        
		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT1 ? AsT1 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => default,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT1;
		}
        
		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT2 ? AsT2 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => default,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT2;
		}
        
		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT3 ? AsT3 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => default,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT3;
		}
        
		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT4 ? AsT4 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => default,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT4;
		}
        
		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT5 ? AsT5 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => default,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT5;
		}
        
		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT6 ? AsT6 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => default,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT6;
		}
        
		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT7 ? AsT7 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => default,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT7;
		}
        
		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT8 ? AsT8 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => default,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT8;
		}
        
		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT9 ? AsT9 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => default,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT9;
		}
        
		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15> remainder)
		{
			value = IsT10 ? AsT10 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => default,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT10;
		}
        
		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15> remainder)
		{
			value = IsT11 ? AsT11 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => default,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT11;
		}
        
		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15> remainder)
		{
			value = IsT12 ? AsT12 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => default,
                13 => AsT13,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT12;
		}
        
		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15> remainder)
		{
			value = IsT13 ? AsT13 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => default,
                14 => AsT14,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT13;
		}
        
		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15> remainder)
		{
			value = IsT14 ? AsT14 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => default,
                15 => AsT15,
                _ => throw new InvalidOperationException()
            };
			return this.IsT14;
		}
        
		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = IsT15 ? AsT15 : default;
            remainder = _index switch
            {
                0 => AsT0,
                1 => AsT1,
                2 => AsT2,
                3 => AsT3,
                4 => AsT4,
                5 => AsT5,
                6 => AsT6,
                7 => AsT7,
                8 => AsT8,
                9 => AsT9,
                10 => AsT10,
                11 => AsT11,
                12 => AsT12,
                13 => AsT13,
                14 => AsT14,
                15 => default,
                _ => throw new InvalidOperationException()
            };
			return this.IsT15;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other) =>
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
                9 => Equals(_value9, other._value9),
                10 => Equals(_value10, other._value10),
                11 => Equals(_value11, other._value11),
                12 => Equals(_value12, other._value12),
                13 => Equals(_value13, other._value13),
                14 => Equals(_value14, other._value14),
                15 => Equals(_value15, other._value15),
                _ => false
            };

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o && Equals(o);
        }

        public override string ToString() =>
            _index switch {
                0 => FormatValue(_value0),
                1 => FormatValue(_value1),
                2 => FormatValue(_value2),
                3 => FormatValue(_value3),
                4 => FormatValue(_value4),
                5 => FormatValue(_value5),
                6 => FormatValue(_value6),
                7 => FormatValue(_value7),
                8 => FormatValue(_value8),
                9 => FormatValue(_value9),
                10 => FormatValue(_value10),
                11 => FormatValue(_value11),
                12 => FormatValue(_value12),
                13 => FormatValue(_value13),
                14 => FormatValue(_value14),
                15 => FormatValue(_value15),
                _ => throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.")
            };

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = _index switch
                {
                    0 => _value0?.GetHashCode(),
                    1 => _value1?.GetHashCode(),
                    2 => _value2?.GetHashCode(),
                    3 => _value3?.GetHashCode(),
                    4 => _value4?.GetHashCode(),
                    5 => _value5?.GetHashCode(),
                    6 => _value6?.GetHashCode(),
                    7 => _value7?.GetHashCode(),
                    8 => _value8?.GetHashCode(),
                    9 => _value9?.GetHashCode(),
                    10 => _value10?.GetHashCode(),
                    11 => _value11?.GetHashCode(),
                    12 => _value12?.GetHashCode(),
                    13 => _value13?.GetHashCode(),
                    14 => _value14?.GetHashCode(),
                    15 => _value15?.GetHashCode(),
                    _ => 0
                } ?? 0;
                return (hashCode*397) ^ _index;
            }
        }
    }
}
