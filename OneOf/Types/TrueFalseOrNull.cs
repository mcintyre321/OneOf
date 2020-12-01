namespace OneOf.Types
{
    public class TrueFalseOrNull : OneOf.OneOfBase<TrueFalseOrNull.True, TrueFalseOrNull.False, TrueFalseOrNull.Null>
    {
        TrueFalseOrNull(OneOf<True, False, Null> _) : base(_) { }
        public class True { }
        public class False { }
        public class Null { }

        public static implicit operator TrueFalseOrNull(True _) => new TrueFalseOrNull(_);
        public static implicit operator TrueFalseOrNull(False _) => new TrueFalseOrNull(_);
        public static implicit operator TrueFalseOrNull(Null _) => new TrueFalseOrNull(_);

        public static implicit operator TrueFalseOrNull(bool? value) => new TrueFalseOrNull(
            value is null ? new Null() :
            value.Value ? new True() :
            (OneOf<True, False, Null>)new False()
        );
    }
}
