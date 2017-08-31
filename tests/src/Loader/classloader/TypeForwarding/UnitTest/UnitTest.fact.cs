using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _TypeForwarding_UnitTest_UnitTest_UnitTest_
    {
        [OuterLoop]
        [Fact]
        public void _TypeForwarding_UnitTest_UnitTest_UnitTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\TypeForwarding\\UnitTest\\UnitTest\\UnitTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
