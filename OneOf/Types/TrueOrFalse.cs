namespace OneOf.Types
{
    public class TrueOrFalse : OneOfBase<TrueOrFalse.True, TrueOrFalse.False> 
    {
        TrueOrFalse(OneOf<True, False> _) : base(_) { }
        public class True { }
        public class False { }

        public static implicit operator TrueOrFalse(True _) => new TrueOrFalse(_);
        public static implicit operator TrueOrFalse(False _) => new TrueOrFalse(_);

        public static implicit operator TrueOrFalse(bool value) => new TrueOrFalse(
            value ? new True() :
            (OneOf<True, False>)new False()
        );
    }
}