using System;
using static OneOf.Functions;

namespace OneOf
{
    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> : IOneOf
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
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                case 23: _value23 = input.AsT23; break;
                default: throw new InvalidOperationException();
            }
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

        

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23)
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
            throw new InvalidOperationException();
        }

        public void Deconstruct(out T0 value0, out T1 value1, out T2 value2, out T3 value3, out T4 value4, out T5 value5, out T6 value6, out T7 value7, out T8 value8, out T9 value9, out T10 value10, out T11 value11, out T12 value12, out T13 value13, out T14 value14, out T15 value15, out T16 value16, out T17 value17, out T18 value18, out T19 value19, out T20 value20, out T21 value21, out T22 value22, out T23 value23)
        {
            value0 = _value0;
            value1 = _value1;
            value2 = _value2;
            value3 = _value3;
            value4 = _value4;
            value5 = _value5;
            value6 = _value6;
            value7 = _value7;
            value8 = _value8;
            value9 = _value9;
            value10 = _value10;
            value11 = _value11;
            value12 = _value12;
            value13 = _value13;
            value14 = _value14;
            value15 = _value15;
            value16 = _value16;
            value17 = _value17;
            value18 = _value18;
            value19 = _value19;
            value20 = _value20;
            value21 = _value21;
            value22 = _value22;
            value23 = _value23;
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23)
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
            throw new InvalidOperationException();
        }

        

        

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT0;
		}
        
		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT1;
		}
        
		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT2;
		}
        
		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT3;
		}
        
		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT4;
		}
        
		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT5;
		}
        
		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT6;
		}
        
		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT7;
		}
        
		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT8;
		}
        
		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT9;
		}
        
		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT10;
		}
        
		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT11;
		}
        
		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT12;
		}
        
		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT13;
		}
        
		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT14;
		}
        
		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT15;
		}
        
		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT16;
		}
        
		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT17;
		}
        
		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT18;
		}
        
		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT19;
		}
        
		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT20;
		}
        
		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT21;
		}
        
		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT22;
		}
        
		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
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
                _ => throw new InvalidOperationException()
            };
			return this.IsT23;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> other) =>
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
                _ => false
            };

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj)) {
                    return true;
            }

            return obj is OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> o && Equals(o);
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
                    _ => 0
                } ?? 0;
                return (hashCode*397) ^ _index;
            }
        }
    }
}
