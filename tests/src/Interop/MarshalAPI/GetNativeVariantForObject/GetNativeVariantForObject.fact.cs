using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _GetNativeVariantForObject_GetNativeVariantForObject_GetNativeVariantForObject_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _GetNativeVariantForObject_GetNativeVariantForObject_GetNativeVariantForObject_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\GetNativeVariantForObject\\GetNativeVariantForObject\\GetNativeVariantForObject.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
