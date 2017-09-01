using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _IUnknown_IUnknownTest_IUnknownTest_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _IUnknown_IUnknownTest_IUnknownTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\IUnknown\\IUnknownTest\\IUnknownTest.cmd");
        }
    }
}
