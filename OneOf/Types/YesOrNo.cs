namespace OneOf.Types
{
    public class YesOrNo : OneOfBase<YesOrNo.Yes, YesOrNo.No>
    {
        YesOrNo(OneOf<Yes, No> _) : base(_) { }
        public class Yes { }
        public class No { }

        public static implicit operator YesOrNo(Yes _) => new YesOrNo(_);
        public static implicit operator YesOrNo(No _) => new YesOrNo(_);

        public static implicit operator YesOrNo(bool value) => new YesOrNo(
            value ? new Yes() :
            (OneOf<Yes, No>)new No()
        );
    }
}