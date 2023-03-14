using System;
using static OneOf.Functions;

namespace OneOf
{
    public readonly struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> : IOneOf
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

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default, T6 value6 = default, T7 value7 = default, T8 value8 = default, T9 value9 = default, T10 value10 = default, T11 value11 = default, T12 value12 = default, T13 value13 = default, T14 value14 = default, T15 value15 = default, T16 value16 = default, T17 value17 = default, T18 value18 = default, T19 value19 = default, T20 value20 = default, T21 value21 = default, T22 value22 = default, T23 value23 = default, T24 value24 = default, T25 value25 = default, T26 value26 = default, T27 value27 = default, T28 value28 = default, T29 value29 = default, T30 value30 = default, T31 value31 = default)
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
                16 => _value16,
                17 => _value17,
                18 => _value18,
                19 => _value19,
                20 => _value20,
                21 => _value21,
                22 => _value22,
                23 => _value23,
                24 => _value24,
                25 => _value25,
                26 => _value26,
                27 => _value27,
                28 => _value28,
                29 => _value29,
                30 => _value30,
                31 => _value31,
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
        public bool IsT16 => _index == 16;
        public bool IsT17 => _index == 17;
        public bool IsT18 => _index == 18;
        public bool IsT19 => _index == 19;
        public bool IsT20 => _index == 20;
        public bool IsT21 => _index == 21;
        public bool IsT22 => _index == 22;
        public bool IsT23 => _index == 23;
        public bool IsT24 => _index == 24;
        public bool IsT25 => _index == 25;
        public bool IsT26 => _index == 26;
        public bool IsT27 => _index == 27;
        public bool IsT28 => _index == 28;
        public bool IsT29 => _index == 29;
        public bool IsT30 => _index == 30;
        public bool IsT31 => _index == 31;

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
        public T20 AsT20 =>
            _index == 20 ?
                _value20 :
                throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
        public T21 AsT21 =>
            _index == 21 ?
                _value21 :
                throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
        public T22 AsT22 =>
            _index == 22 ?
                _value22 :
                throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
        public T23 AsT23 =>
            _index == 23 ?
                _value23 :
                throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
        public T24 AsT24 =>
            _index == 24 ?
                _value24 :
                throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
        public T25 AsT25 =>
            _index == 25 ?
                _value25 :
                throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
        public T26 AsT26 =>
            _index == 26 ?
                _value26 :
                throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
        public T27 AsT27 =>
            _index == 27 ?
                _value27 :
                throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
        public T28 AsT28 =>
            _index == 28 ?
                _value28 :
                throw new InvalidOperationException($"Cannot return as T28 as result is T{_index}");
        public T29 AsT29 =>
            _index == 29 ?
                _value29 :
                throw new InvalidOperationException($"Cannot return as T29 as result is T{_index}");
        public T30 AsT30 =>
            _index == 30 ?
                _value30 :
                throw new InvalidOperationException($"Cannot return as T30 as result is T{_index}");
        public T31 AsT31 =>
            _index == 31 ?
                _value31 :
                throw new InvalidOperationException($"Cannot return as T31 as result is T{_index}");

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(0, value0: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(1, value1: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(2, value2: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(3, value3: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(4, value4: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(5, value5: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(6, value6: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(7, value7: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T8 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(8, value8: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T9 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(9, value9: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T10 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(10, value10: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T11 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(11, value11: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T12 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(12, value12: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T13 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(13, value13: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T14 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(14, value14: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T15 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(15, value15: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T16 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(16, value16: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T17 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(17, value17: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T18 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(18, value18: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T19 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(19, value19: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T20 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(20, value20: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T21 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(21, value21: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T22 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(22, value22: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T23 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(23, value23: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T24 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(24, value24: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T25 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(25, value25: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T26 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(26, value26: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T27 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(27, value27: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T28 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(28, value28: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T29 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(29, value29: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T30 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(30, value30: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T31 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(31, value31: t);

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

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT3(T3 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT4(T4 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT5(T5 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT6(T6 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT7(T7 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT8(T8 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT9(T9 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT10(T10 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT11(T11 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT12(T12 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT13(T13 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT14(T14 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT15(T15 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT16(T16 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT17(T17 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT18(T18 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT19(T19 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT20(T20 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT21(T21 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT22(T22 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT23(T23 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT24(T24 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT25(T25 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT26(T26 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT27(T27 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT28(T28 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT29(T29 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT30(T30 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> FromT31(T31 input) => input;

        
        public OneOf<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT0<TResult>(Func<T0, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT1<TResult>(Func<T1, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT2<TResult>(Func<T2, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT3<TResult>(Func<T3, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT4<TResult>(Func<T4, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT5<TResult>(Func<T5, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT6<TResult>(Func<T6, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT7<TResult>(Func<T7, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, TResult, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT8<TResult>(Func<T8, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT9<TResult>(Func<T9, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT10<TResult>(Func<T10, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT11<TResult>(Func<T11, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT12<TResult>(Func<T12, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT13<TResult>(Func<T13, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT14<TResult>(Func<T14, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT15<TResult>(Func<T15, TResult> mapFunc)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT16<TResult>(Func<T16, TResult> mapFunc)
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
                15 => AsT15,
                16 => mapFunc(AsT16),
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT17<TResult>(Func<T17, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => mapFunc(AsT17),
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TResult, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT18<TResult>(Func<T18, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => mapFunc(AsT18),
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TResult, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT19<TResult>(Func<T19, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => mapFunc(AsT19),
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TResult, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT20<TResult>(Func<T20, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => mapFunc(AsT20),
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TResult, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT21<TResult>(Func<T21, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => mapFunc(AsT21),
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TResult, T23, T24, T25, T26, T27, T28, T29, T30, T31> MapT22<TResult>(Func<T22, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => mapFunc(AsT22),
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TResult, T24, T25, T26, T27, T28, T29, T30, T31> MapT23<TResult>(Func<T23, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => mapFunc(AsT23),
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TResult, T25, T26, T27, T28, T29, T30, T31> MapT24<TResult>(Func<T24, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => mapFunc(AsT24),
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TResult, T26, T27, T28, T29, T30, T31> MapT25<TResult>(Func<T25, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => mapFunc(AsT25),
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TResult, T27, T28, T29, T30, T31> MapT26<TResult>(Func<T26, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => mapFunc(AsT26),
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TResult, T28, T29, T30, T31> MapT27<TResult>(Func<T27, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => mapFunc(AsT27),
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TResult, T29, T30, T31> MapT28<TResult>(Func<T28, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => mapFunc(AsT28),
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TResult, T30, T31> MapT29<TResult>(Func<T29, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => mapFunc(AsT29),
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TResult, T31> MapT30<TResult>(Func<T30, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => mapFunc(AsT30),
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TResult> MapT31<TResult>(Func<T31, TResult> mapFunc)
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => mapFunc(AsT31),
                _ => throw new InvalidOperationException()
            };
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT0;
		}
        
		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT1;
		}
        
		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT2;
		}
        
		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT3;
		}
        
		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT4;
		}
        
		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT5;
		}
        
		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT6;
		}
        
		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT7;
		}
        
		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT8;
		}
        
		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT9;
		}
        
		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT10;
		}
        
		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT11;
		}
        
		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT12;
		}
        
		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT13;
		}
        
		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT14;
		}
        
		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
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
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT15;
		}
        
		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT16 ? AsT16 : default;
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
                15 => AsT15,
                16 => default,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT16;
		}
        
		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT17 ? AsT17 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => default,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT17;
		}
        
		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT18 ? AsT18 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => default,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT18;
		}
        
		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT19 ? AsT19 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => default,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT19;
		}
        
		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT20 ? AsT20 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => default,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT20;
		}
        
		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT21 ? AsT21 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => default,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT21;
		}
        
		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT22 ? AsT22 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => default,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT22;
		}
        
		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT23 ? AsT23 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => default,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT23;
		}
        
		public bool TryPickT24(out T24 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT24 ? AsT24 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => default,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT24;
		}
        
		public bool TryPickT25(out T25 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT25 ? AsT25 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => default,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT25;
		}
        
		public bool TryPickT26(out T26 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28, T29, T30, T31> remainder)
		{
			value = IsT26 ? AsT26 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => default,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT26;
		}
        
		public bool TryPickT27(out T27 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28, T29, T30, T31> remainder)
		{
			value = IsT27 ? AsT27 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => default,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT27;
		}
        
		public bool TryPickT28(out T28 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T29, T30, T31> remainder)
		{
			value = IsT28 ? AsT28 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => default,
                29 => AsT29,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT28;
		}
        
		public bool TryPickT29(out T29 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T30, T31> remainder)
		{
			value = IsT29 ? AsT29 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => default,
                30 => AsT30,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT29;
		}
        
		public bool TryPickT30(out T30 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T31> remainder)
		{
			value = IsT30 ? AsT30 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => default,
                31 => AsT31,
                _ => throw new InvalidOperationException()
            };
			return this.IsT30;
		}
        
		public bool TryPickT31(out T31 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = IsT31 ? AsT31 : default;
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
                15 => AsT15,
                16 => AsT16,
                17 => AsT17,
                18 => AsT18,
                19 => AsT19,
                20 => AsT20,
                21 => AsT21,
                22 => AsT22,
                23 => AsT23,
                24 => AsT24,
                25 => AsT25,
                26 => AsT26,
                27 => AsT27,
                28 => AsT28,
                29 => AsT29,
                30 => AsT30,
                31 => default,
                _ => throw new InvalidOperationException()
            };
			return this.IsT31;
		}

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> other) =>
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
                16 => Equals(_value16, other._value16),
                17 => Equals(_value17, other._value17),
                18 => Equals(_value18, other._value18),
                19 => Equals(_value19, other._value19),
                20 => Equals(_value20, other._value20),
                21 => Equals(_value21, other._value21),
                22 => Equals(_value22, other._value22),
                23 => Equals(_value23, other._value23),
                24 => Equals(_value24, other._value24),
                25 => Equals(_value25, other._value25),
                26 => Equals(_value26, other._value26),
                27 => Equals(_value27, other._value27),
                28 => Equals(_value28, other._value28),
                29 => Equals(_value29, other._value29),
                30 => Equals(_value30, other._value30),
                31 => Equals(_value31, other._value31),
                _ => false
            };

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> o && Equals(o);
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
                16 => FormatValue(_value16),
                17 => FormatValue(_value17),
                18 => FormatValue(_value18),
                19 => FormatValue(_value19),
                20 => FormatValue(_value20),
                21 => FormatValue(_value21),
                22 => FormatValue(_value22),
                23 => FormatValue(_value23),
                24 => FormatValue(_value24),
                25 => FormatValue(_value25),
                26 => FormatValue(_value26),
                27 => FormatValue(_value27),
                28 => FormatValue(_value28),
                29 => FormatValue(_value29),
                30 => FormatValue(_value30),
                31 => FormatValue(_value31),
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
                    16 => _value16?.GetHashCode(),
                    17 => _value17?.GetHashCode(),
                    18 => _value18?.GetHashCode(),
                    19 => _value19?.GetHashCode(),
                    20 => _value20?.GetHashCode(),
                    21 => _value21?.GetHashCode(),
                    22 => _value22?.GetHashCode(),
                    23 => _value23?.GetHashCode(),
                    24 => _value24?.GetHashCode(),
                    25 => _value25?.GetHashCode(),
                    26 => _value26?.GetHashCode(),
                    27 => _value27?.GetHashCode(),
                    28 => _value28?.GetHashCode(),
                    29 => _value29?.GetHashCode(),
                    30 => _value30?.GetHashCode(),
                    31 => _value31?.GetHashCode(),
                    _ => 0
                } ?? 0;
                return (hashCode*397) ^ _index;
            }
        }
    }
}
