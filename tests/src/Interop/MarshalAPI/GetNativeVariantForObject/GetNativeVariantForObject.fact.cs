using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _GetNativeVariantForObject_GetNativeVariantForObject_GetNativeVariantForObject_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _GetNativeVariantForObject_GetNativeVariantForObject_GetNativeVariantForObject_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\GetNativeVariantForObject\\GetNativeVariantForObject\\GetNativeVariantForObject.cmd");
        }
    }
}
