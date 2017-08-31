using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    class _Regressions_pressureoverflow_pressureoverflow_
    {
        [Fact]
        public void _Regressions_pressureoverflow_pressureoverflow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\LargeMemory\\Regressions\\pressureoverflow\\pressureoverflow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
