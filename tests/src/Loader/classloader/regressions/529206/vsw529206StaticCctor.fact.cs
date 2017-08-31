using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_529206_vsw529206StaticCctor_vsw529206StaticCctor_
    {
        [Fact]
        public void _regressions_529206_vsw529206StaticCctor_vsw529206StaticCctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\529206\\vsw529206StaticCctor\\vsw529206StaticCctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
