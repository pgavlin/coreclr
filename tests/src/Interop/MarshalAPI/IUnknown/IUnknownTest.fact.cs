using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _IUnknown_IUnknownTest_IUnknownTest_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _IUnknown_IUnknownTest_IUnknownTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\IUnknown\\IUnknownTest\\IUnknownTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
