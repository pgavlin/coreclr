using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _GetObjectsForNativeVariants_GetObjectsForNativeVariants_GetObjectsForNativeVariants_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _GetObjectsForNativeVariants_GetObjectsForNativeVariants_GetObjectsForNativeVariants_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\GetObjectsForNativeVariants\\GetObjectsForNativeVariants\\GetObjectsForNativeVariants.cmd");
        }
    }
}
