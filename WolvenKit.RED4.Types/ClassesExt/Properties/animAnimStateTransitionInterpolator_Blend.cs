namespace WolvenKit.RED4.Types
{
    public partial class animAnimStateTransitionInterpolator_Blend
    {
        [Ordinal(999)]
        [RED("visTransitionDuration")]
        public CFloat VisTransitionDuration
        {
            get => GetPropertyValue<CFloat>();
            set => SetPropertyValue<CFloat>(value);
        }

        public animAnimStateTransitionInterpolator_Blend()
        {
            VisTransitionDuration = 1F;
        }
    }
}
