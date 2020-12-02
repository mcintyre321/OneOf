namespace OneOf.Types
{
    public class YesNoOrMaybe : OneOfBase<YesNoOrMaybe.Yes, YesNoOrMaybe.No, YesNoOrMaybe.Maybe>
    {
        YesNoOrMaybe(OneOf<Yes, No, Maybe> _) : base(_) { }
        public class Yes { }
        public class No { }
        public class Maybe { }

        public static implicit operator YesNoOrMaybe(Yes _) => new YesNoOrMaybe(_);
        public static implicit operator YesNoOrMaybe(No _) => new YesNoOrMaybe(_);
        public static implicit operator YesNoOrMaybe(Maybe _) => new YesNoOrMaybe(_);

        public static implicit operator YesNoOrMaybe(bool? value) => new YesNoOrMaybe(
            value is null ? new Maybe() :
            value.Value ? new Yes() :
            (OneOf<Yes, No, Maybe>)new No()
        );
    }
}