using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_529206_vsw529206ModuleCctor_vsw529206ModuleCctor_
    {
        [Fact]
        public void _regressions_529206_vsw529206ModuleCctor_vsw529206ModuleCctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\529206\\vsw529206ModuleCctor\\vsw529206ModuleCctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
