namespace OneOf.Types
{
    public class YesNoOrMaybe : OneOfBase<YesNoOrMaybe.Yes, YesNoOrMaybe.No, YesNoOrMaybe.Maybe>
    {
        public class Yes : YesNoOrMaybe { }
        public class No : YesNoOrMaybe { }
        public class Maybe : YesNoOrMaybe { }

        public static implicit operator YesNoOrMaybe(bool? value)
        {
            return value == null ? new Maybe()
                : value.Value ? (YesNoOrMaybe) new Yes()
                    : new No();
        }
    }
}