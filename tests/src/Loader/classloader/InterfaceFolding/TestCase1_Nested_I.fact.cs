using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _InterfaceFolding_TestCase1_Nested_I_TestCase1_Nested_I_
    {
        [OuterLoop]
        [Fact]
        public void _InterfaceFolding_TestCase1_Nested_I_TestCase1_Nested_I_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\InterfaceFolding\\TestCase1_Nested_I\\TestCase1_Nested_I.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
