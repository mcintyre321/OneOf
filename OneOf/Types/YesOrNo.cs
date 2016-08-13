namespace OneOf.Types
{
    public class YesOrNo : OneOfBase<YesOrNo.Yes, YesOrNo.No>
    {
        public class Yes : YesOrNo { }
        public class No : YesOrNo { }

        public static implicit operator YesOrNo(bool value)
        {
            return value ? (YesOrNo)new YesOrNo.Yes() : new YesOrNo.No();
        }
    }
}