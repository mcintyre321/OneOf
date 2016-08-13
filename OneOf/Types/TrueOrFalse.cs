namespace OneOf.Types
{
    public class TrueOrFalse : OneOfBase<TrueOrFalse.True, TrueOrFalse.False>
    {
        public class True : TrueOrFalse { }
        public class False : TrueOrFalse { }

        public static implicit operator TrueOrFalse(bool value)
        {
            return value ? (TrueOrFalse) new True() : new False();
        }
    }
}