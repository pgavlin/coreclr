using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _InterfaceFolding_Ambiguous_Ambiguous_
    {
        [OuterLoop]
        [Fact]
        public void _InterfaceFolding_Ambiguous_Ambiguous_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\InterfaceFolding\\Ambiguous\\Ambiguous.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
