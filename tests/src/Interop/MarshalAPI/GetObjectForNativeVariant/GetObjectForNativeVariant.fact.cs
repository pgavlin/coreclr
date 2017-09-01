using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _GetObjectForNativeVariant_GetObjectForNativeVariant_GetObjectForNativeVariant_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _GetObjectForNativeVariant_GetObjectForNativeVariant_GetObjectForNativeVariant_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\GetObjectForNativeVariant\\GetObjectForNativeVariant\\GetObjectForNativeVariant.cmd");
        }
    }
}
