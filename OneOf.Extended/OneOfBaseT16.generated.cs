using System;
using static OneOf.Functions;

namespace OneOf
{
    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IOneOf
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
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> input)
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
                default: throw new InvalidOperationException();
            }
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

        

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16)
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
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16)
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
            throw new InvalidOperationException();
        }

        

        

        public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT0;
        }
        
        public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT1;
        }
        
        public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT2;
        }
        
        public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT3;
        }
        
        public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT4;
        }
        
        public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT5;
        }
        
        public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT6;
        }
        
        public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT7;
        }
        
        public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT8;
        }
        
        public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT9;
        }
        
        public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT10;
        }
        
        public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT11;
        }
        
        public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT12;
        }
        
        public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT13;
        }
        
        public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT14;
        }
        
        public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT15;
        }
        
        public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
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
                default: throw new InvalidOperationException();
            }
            return this.IsT16;
        }

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other) {
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
                default: return false;
            };
                             }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj)) {
                    return true;
            }

            return obj is OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o && Equals(o);
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
                    default: { hashCode = 0; break; }
                }
                return (hashCode*397) ^ _index;
            }
        }
    }
}
