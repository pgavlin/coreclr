using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _GetObjectForNativeVariant_GetObjectForNativeVariant_GetObjectForNativeVariant_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _GetObjectForNativeVariant_GetObjectForNativeVariant_GetObjectForNativeVariant_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\GetObjectForNativeVariant\\GetObjectForNativeVariant\\GetObjectForNativeVariant.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
