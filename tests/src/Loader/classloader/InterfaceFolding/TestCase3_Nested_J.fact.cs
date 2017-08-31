using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _InterfaceFolding_TestCase3_Nested_J_TestCase3_Nested_J_
    {
        [OuterLoop]
        [Fact]
        public void _InterfaceFolding_TestCase3_Nested_J_TestCase3_Nested_J_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\InterfaceFolding\\TestCase3_Nested_J\\TestCase3_Nested_J.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
