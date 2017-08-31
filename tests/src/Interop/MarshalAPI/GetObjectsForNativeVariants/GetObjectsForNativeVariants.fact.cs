using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _GetObjectsForNativeVariants_GetObjectsForNativeVariants_GetObjectsForNativeVariants_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _GetObjectsForNativeVariants_GetObjectsForNativeVariants_GetObjectsForNativeVariants_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\GetObjectsForNativeVariants\\GetObjectsForNativeVariants\\GetObjectsForNativeVariants.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
